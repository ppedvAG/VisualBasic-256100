Public Class PKW
    Inherits Fahrzeug
    Private _anzahlTüren As Integer
    Public Property AnzahlTüren() As Integer
        Get
            Return _anzahlTüren
        End Get
        Set(value As Integer)
            _anzahlTüren = value
        End Set
    End Property
    Private _anzahlRäder As Integer
    Public Property AnzahlRäder() As Integer
        Get
            Return _anzahlRäder
        End Get
        Set(value As Integer)
            _anzahlRäder = value
        End Set
    End Property

    Public Sub New(Name As String, maxGeschwindigkeit As Integer, Preis As Double, aktGeschwindigkeit As Integer, Zustand As Boolean, AnzahlTüren As Integer, AnzahlRäder As Integer)
        MyBase.New(Name, maxGeschwindigkeit, Preis, aktGeschwindigkeit, Zustand)
        _anzahlTüren = AnzahlTüren
        _anzahlRäder = AnzahlRäder
    End Sub
    Public Overrides Function BeschreibeMich() As String
        Return $"Das Auto " + MyBase.Beschreibemich() + $". Es hat {_anzahlTüren} Türen und {_anzahlRäder} Räder."
    End Function
End Class

