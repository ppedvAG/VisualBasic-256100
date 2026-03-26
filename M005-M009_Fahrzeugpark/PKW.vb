Public Class PKW
    'Mittels des INHERITS-Stichwort wird diese Klasse zur erbenden Klasse der Fahrzeugklasse. Damit übernimmt diese Klasse
    ''alle Eigenschaften und Methoden der Mutterklasse
    Inherits Fahrzeug
    'Mittels des IMPLEMENTS-Stichwort implementiert diese Klasse ein Interface. Dadurch wird die Klasse gezwungen die Eigenschaften
    ''und Methoden von diesem mit einzubauen. vgl. IBerädert
    Implements IBerädert

    'Eigene Property der Kindklasse
    Private _anzahlTüren As Integer
    Public Property AnzahlTüren() As Integer
        Get
            Return _anzahlTüren
        End Get
        Set(value As Integer)
            _anzahlTüren = value
        End Set
    End Property

    'Property des Interfaces
    Private _anzahlRäder As Integer
    Public Property AnzahlRäder As Integer Implements IBerädert.AnzahlRäder
        Get
            Return _anzahlRäder
        End Get
        Set(value As Integer)
            _anzahlRäder = value
        End Set
    End Property

    'Konstruktor der Kindklasse
    Public Sub New(name As String, maxG As Integer, preis As Double, anzahlTüren As Integer)
        'Mittels des MYBASE-Stichworts wird Bezug auf die Mutterklasse genommen. Im Konstruktor muss dieser Bezug vorhanden
        ''sein: Es wird zuerst der Konstruktor der Mutterklasse aufgerufen, bevor Kindklassen-spezifische Eigenschaften
        ''gesetzt werden
        MyBase.New(name, maxG, preis)

        Me._anzahlTüren = anzahlTüren
        Me._anzahlRäder = 4
    End Sub

    'Mittels des OVERRIDES-Stichwort können in der Mutterklasse als 'Overridable' und 'MustOverride' markierte Methoden
    ''überschrieben werden. Damit wird bei einem Methodenaufruf die Methode der Kindklasse und nicht jene der Mutterklasse
    ''aufgerufen
    Public Overrides Function BeschreibeMich() As String
        Return "Der PKW " + MyBase.BeschreibeMich() + $" Er hat {Me.AnzahlTüren} Türen."
    End Function

    'Durch abstrakte Methode der Mutterklasse verlangte Methode
    'Für Lab-05 und Module-05 musst du es auskommentiert bleiben
    'Für Lab-07 und Module-07 musst du es entkommentieren
    Public Overrides Sub Hupen()
        Console.WriteLine("Hup Hup")
    End Sub

    'Durch Interface verlangte Methoden
    Public Sub BaueUnfall() Implements IBerädert.BaueUnfall
        AnzahlRäder -= 1
        AnzahlTüren -= 1
        Console.WriteLine("Du hast einen Baum übersehen.")
    End Sub

    'Funktion zur zufälligen Erstellung eines PKWs
    Private Shared generator As Random = New Random

    Public Shared Function ErstelleZufälligenPKW(nameSuffix As String) As PKW
        Dim name As String
        Select Case generator.Next(0, 4)
            Case 0
                name = "Audi"
            Case 1
                name = "Mercedes"
            Case 2
                name = "BMW"
            Case Else
                name = "VW"
        End Select
        name = name + nameSuffix
        Return New PKW(name, generator.Next(15, 31) * 10, generator.Next(2, 21) * 1000, generator.Next(3, 6))
    End Function
End Class
