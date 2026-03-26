Public Class Flugzeug
    Inherits Fahrzeug
    Private _anzahlFlügel As Integer
    Public Property AnzahlFlügel() As Integer
        Get
            Return _anzahlFlügel
        End Get
        Set(value As Integer)
            _anzahlFlügel = value
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
        _anzahlFlügel = AnzahlFlügel
        _anzahlRäder = AnzahlRäder
    End Sub
    Public Overrides Function BeschreibeMich() As String
        Return $"Das Flugzeug " + MyBase.Beschreibemich() + $" Es hat {_anzahlFlügel} Flügel und {_anzahlRäder} Räder."
    End Function
End Class
