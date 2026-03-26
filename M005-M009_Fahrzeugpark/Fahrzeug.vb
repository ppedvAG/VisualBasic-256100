'Eine KLASSE ist ein Programmteil, welches die Struktur von bestimmten Objekten definiert. Alle Objekte, welche von dieser
''Klasse abgeleitet werden, besitzen die selben Methoden und Eigenschaften, welche aber unterschiedlich befüllt werden können
''und unabhängig von anderen gleichartigen Objekten agieren.
'Wenn eine Klassensignatur das Stichwort MUSTINHERIT beinhaltet, gilt die Klasse als abstarkt. D.h. von dieser Klasse dürfen
''keine Objekte mehr erzeugt werden. Sie ist nur noch Vorlage für Kindklassen.

'Zum Thema Vererbung und abstrakte Klassen:
' Overridable:
' Eine Methode in der Basisklasse kann mit Overridable markiert werden.
' Dadurch wird festgelegt, dass eine Kindklasse diese Methode bei Bedarf überschreiben darf.
' Die Basisklasse liefert also bereits eine normale Implementierung,
' erlaubt aber zusätzlich eine angepasste Version in der abgeleiteten Klasse.

' Overrides:
' Eine Methode in der Kindklasse wird mit Overrides markiert,
' wenn sie eine geerbte Overridable- oder MustOverride-Methode ersetzt.
' Damit wird nicht einfach eine neue Methode erstellt,
' sondern die geerbte Methode gezielt überschrieben.
' Wird die Methode später über ein Objekt der Kindklasse aufgerufen,
' dann wird die Version der Kindklasse ausgeführt.

' MustOverride:
' Eine Methode mit MustOverride besitzt in der Basisklasse keinen Methodenrumpf,
' sondern nur die Signatur.
' Die Basisklasse gibt damit nur vor, dass diese Methode existieren muss,
' aber nicht, wie sie genau umgesetzt wird.
' Jede nicht-abstrakte Kindklasse ist dann verpflichtet,
' diese Methode mit Overrides zu implementieren.
' Geschieht das nicht, entsteht ein Compilerfehler.

' Wichtig:
' Overridable = darf überschrieben werden
' MustOverride = muss überschrieben werden
' Overrides = wird in der Kindklasse tatsächlich überschrieben

' Zusätzlich:
' MustOverride darf nur in einer MustInherit-Klasse verwendet werden,
' weil eine abstrakte Methode nur in einer abstrakten Basisklasse sinnvoll ist.
Public MustInherit Class Fahrzeug
    'Für Lab-05 musst du MustInherit entfernen 
    'Für Lab-07 und Module-07 musst du MustInherit wieder einfügen, um die Klasse abstrakt zu machen
#Region "Shared Member"
    'SHARED Variablen und Methoden gelten unabhängig von Instanzen für die ganze Klasse.  
    Public Shared AnzahlErstellterFahrzeuge As Integer = 0

    Public Shared Sub ZeigeAnzahlErstellterFahrzeuge()
        Console.WriteLine($"Es wurden {AnzahlErstellterFahrzeuge} Fahrzeuge gebaut.")
    End Sub
#End Region

#Region "Felder und Properties"
    'FELDER sind die Variablen, welche jedes Objekt dieser Klasse besitzt und welche individuell befüllt werden können.
    'PROPERTIES sind jeweils einem Feld zugeordnet und definieren über die Getter und Setter den Lese- und Schreibzugriff
    ''auf das jeweilige Feld.
    Private _name As String
    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(value As String)
            'Innerhalb der Getter und Setter können bei Bedarf spezifische Zugriffslogiken abgelegt werden
            'If value.Length > 0 Then
            _name = value
            'End If
        End Set
    End Property


    Private _maxGeschwindigkeit As Integer
    Public Property MaxGeschwindigkeit() As Integer
        Get
            Return _maxGeschwindigkeit
        End Get
        'Getter und Setter können spezifische Zugriffsmodifikatoren erhalten und die einzelnen Zugriffe gezielt einzuschränken
        Private Set(value As Integer)
            _maxGeschwindigkeit = value
        End Set
    End Property

    Private _aktGeschwindigkeit As Integer
    Public Property AktGeschwindigkeit() As Integer
        Get
            Return _aktGeschwindigkeit
        End Get
        Set(value As Integer)
            _aktGeschwindigkeit = value
        End Set
    End Property

    Private _preis As Double
    Public Property Preis() As Double
        Get
            Return _preis
        End Get
        Set(value As Double)
            _preis = value
        End Set
    End Property

    Private _zustand As Boolean 'true = Motor läuft
    Public Property Zustand() As Boolean
        Get
            Return _zustand
        End Get
        Set(value As Boolean)
            _zustand = value
        End Set
    End Property
#End Region

#Region "Konstruktor und Destruktor"
    'Ein KONSTRUKTOR wird vom Programm aufgerufen, wenn eine neue Instanz (ein neues Objekt) dieser Klasse erstellt werden
    ''soll. Dabei wird der Startzustand der Objekte definiert.
    'Das 'Me.' muss technisch nicht geschrieben werden, wird aber als Namenskonvention dazu geschrieben
    'Die Reihenfolge der Eigenschaften ist relevant -> Eigenschaft = Parameter
    Public Sub New(name As String, maxG As Integer, preis As Double)
        'Individuelle Belegung von Felder über die Übergabeparameter
        Me._name = name
        Me._maxGeschwindigkeit = maxG
        Me._preis = preis
        'Fixe Belegung von Felder, die immer den gleichen Startwert
        Me._aktGeschwindigkeit = 0
        Me._zustand = False

        AnzahlErstellterFahrzeuge += 1
    End Sub

    'Alternativer überladener Konstruktor
    Public Sub New(name As String, maxG As Integer)
        Me._name = name
        Me._maxGeschwindigkeit = maxG
    End Sub

    'Parameterloser Standartkonstruktor
    Public Sub New()

    End Sub

    'Der Destruktor wird von der GarbageCollection aufgerufen, wenn das entsprechende Objekt durch keine Variable mehr referenziert wird, und 
    ''löscht dieses aus dem Speicher. Der Destruktor muss nicht manuell definiert werden, kann aber in der Klasse mit weiternen Aktionen, welche 
    ''über die Zerstörung des Objekts hinausgehen befüllt werden (wie hier mit einer Konsolen-Ausgabe)
    Protected Overrides Sub Finalize()
        Console.WriteLine($"{Me.Name} wurde zerstört")
    End Sub
#End Region

#Region "Methoden"
    'Methoden einer Klasse (welche nicht als Shared markiert sind) gelten jeweils für ein Objekt der Klasse. Jedes Objekt
    ''besitzt alle definierten Methoden, welche bei Aufruf (über den Variablenbezeichner des Objekts) ausgeführt werden
    ''und dieses spezielle Objekt manipulieren.
    Public Sub StarteMotor()
        Me.Zustand = True
    End Sub

    Public Sub StoppeMotor()
        Me.Zustand = False
    End Sub

    Public Sub Beschleunige(a As Integer)
        If Me.Zustand Then
            If Me.AktGeschwindigkeit + a > Me.MaxGeschwindigkeit Then
                Me.AktGeschwindigkeit = Me.MaxGeschwindigkeit
            ElseIf Me.AktGeschwindigkeit + a < 0 Then
                Me.AktGeschwindigkeit = 0
            Else
                Me.AktGeschwindigkeit += a
            End If
        End If
    End Sub

    'Als OVERRIDABLE markierte Methoden erlauben erbenden Klassen diese zu überschreiben, so dass bei Methodenaufruf die Methode
    ''der Kindklasse ausgeführt wird
    'Relevant für Module-07
    Public Overridable Function BeschreibeMich() As String
        If Me.Zustand Then
            'Mittels der Variable ME kann man innerhalb von Klassen auf die Member der jeweilgen Instanz zugreifen
            Return $"{Me.Name} fährt mit {Me.AktGeschwindigkeit} von {Me.MaxGeschwindigkeit} km/h und kostet {Me.Preis} Euro."
        Else
            Return $"{Me.Name} könnte mit maximal {Me.MaxGeschwindigkeit} km/h fahren und kostet {Me.Preis} Euro."
        End If
    End Function

    'Überschreibung der ToString-Funktion
    'Relevant für Module-07
    Public Overrides Function ToString() As String
        Return Me.BeschreibeMich()
    End Function


    'Abstarkte Methoden (markiert mit dem MUSTOVERRIDE-Stichwort) besitzen nur eine Signatur. Die Implementierung des Körpers
    ''erfolgt individuell in den Kindklassen, welche dazu gewungen werden. Abstrakte Methoden dürfen nur in eine abstrakten
    ''Klasse geschrieben werden
    'Für Lab-05 und Module-05 muss du es auskommentiert bleiben
    'Für Lab-07 und Module-07 muss du es entkommentieren
    Public MustOverride Sub Hupen()

#End Region

End Class
