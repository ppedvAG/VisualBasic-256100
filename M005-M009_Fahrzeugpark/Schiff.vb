Public Class Schiff
    'Mittels des INHERITS-Stichwort wird diese Klasse zur erbenden Klasse der Fahrzeugklasse. Damit übernimmt diese Klasse
    ''alle Eigenschaften und Methoden der Mutterklasse
    Inherits Fahrzeug
    Implements IBeladbar

    'Klasseneigener (dh nur für diese Klasse gültiger) Enumerator
    Enum Schiffstreibstoff
        Diesel
        Schweröl
        Dampf
        Wind
        Muskelkraft
    End Enum

    'Eigene Property der Kindklasse
    Private _treibstoff As Schiffstreibstoff
    Public Property Treibstoff() As Schiffstreibstoff
        Get
            Return _treibstoff
        End Get
        Set(ByVal value As Schiffstreibstoff)
            _treibstoff = value
        End Set
    End Property

    'Property des Interfaces
    Private _ladung As Fahrzeug
    Public Property Ladung As Fahrzeug Implements IBeladbar.Ladung
        Get
            Return _ladung
        End Get
        Set(value As Fahrzeug)
            _ladung = value
        End Set
    End Property

    'Konstruktor der Kindklasse
    Public Sub New(name As String, preis As Double, maxG As Integer, treibstoff As Schiffstreibstoff)
        'Mittels des MYBASE-Stichworts wird Bezug auf die Mutterklasse genommen. Im Konstruktor muss dieser Bezug vorhanden
        ''sein: Es wird zuerst der Konstruktor der Mutterklasse aufgerufen, bevor Kindklassen-spezifische Eigenschaften
        ''gesetzt werden
        MyBase.New(name, preis, maxG)
        _treibstoff = treibstoff
    End Sub

    'Mittels des OVERRIDES-Stichwort können in der Mutterklasse als 'Overridable' und 'MustOverride' markierte Methoden
    ''überschrieben werden. Damit wird bei einem Methodenaufruf die Methode der Kindklasse und nicht jene der Mutterklasse
    ''aufgerufen
    Public Overrides Function BeschreibeMich() As String
        If IsNothing(Ladung) Then
            Return "Das Schiff " + MyBase.BeschreibeMich() + $" Es fährt mit {Treibstoff}."
        Else
            Return "Das Schiff " + MyBase.BeschreibeMich() + $" Es fährt mit {Treibstoff} und hat {Ladung.Name} geladen."
        End If
    End Function

    'Durch abstrakte Methode der Mutterklasse verlangte Methode
    'Für Lab-05 und Module-05 muss du es auskommentiert bleiben
    'Für Lab-07 und Module-07 muss du es entkommentieren
    Public Overrides Sub Hupen()
        Console.WriteLine("Trööööt")
    End Sub

    'Durch Interface verlangte Methoden
    Public Sub Belade(fz As Fahrzeug) Implements IBeladbar.Belade

        If fz.Equals(Me) Then           'Prüfung, ob das zu beladende und das aufzuladene Fahrzeug dasselbe ist
            Console.WriteLine($"{Name} kann nicht auf sich selbst geladen werden.")
        ElseIf IsNothing(Ladung) Then   'Prüfung, ob der Ladeplatz leer ist
            'Übertrag des übergebenen Fahrzeugs in die Ladung-Property
            Ladung = fz
            Console.WriteLine($"Ladevorgang von {fz.Name} auf {Name} war erfolgreich.")
        Else                            'Fall tritt ein, wenn der Ladeplatz bereits belegt ist
            Console.WriteLine($"{fz.Name} konnte nicht auf {Name} geladen werden, da der Laderaum schon belegt ist.")
        End If

    End Sub

    Public Function Entlade() As Fahrzeug Implements IBeladbar.Entlade
        Dim ladung As Fahrzeug = Me.Ladung
        If IsNothing(ladung) Then       'Prüfung, ob der Ladeplatz leer ist
            Console.WriteLine($"Entladevorgang nicht möglich, da der Laderaum von {Name} bereits leer ist.")
        Else                            'Fall tritt ein, wenn der Ladeplatz belegt ist
            Console.WriteLine($"{ladung.Name} wurde erfolgreich von {Name} entladen.")
            'Löschen der Referenz in der Ladung-Property
            Me.Ladung = Nothing
        End If
        Return ladung
    End Function
End Class
