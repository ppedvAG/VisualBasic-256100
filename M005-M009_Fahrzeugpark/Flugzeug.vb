'vgl Schiff
Public Class Flugzeug
    Inherits Fahrzeug
    Implements IBerädert

    Private _maxFlughöhe As Integer
    Public Property MaxFlughöhe() As Integer
        Get
            Return _maxFlughöhe
        End Get
        Set(ByVal value As Integer)
            _maxFlughöhe = value
        End Set
    End Property


    Private _anzahlRäder As Integer
    Public Property AnzahlRäder As Integer Implements IBerädert.AnzahlRäder
        Get
            Return _anzahlRäder
        End Get
        Set(value As Integer)
            _anzahlRäder = value
        End Set
    End Property

    Public Sub New(name As String, preis As Double, maxG As Integer, maxF As Integer)
        MyBase.New(name, preis, maxG)
        _maxFlughöhe = maxF
        _anzahlRäder = 6
    End Sub

    Public Overrides Function BeschreibeMich() As String
        Return "Das Flugzeug " + MyBase.BeschreibeMich() + $" Es kann auf {MaxFlughöhe}m aufsteigen."
    End Function

    'Für Lab-05 und Module-05 muss du es auskommentiert bleiben
    'Für Lab-07 und Module-07 muss du es entkommentieren
    Public Overrides Sub Hupen()
        Console.WriteLine("Piep")
    End Sub
    Public Sub BaueUnfall() Implements IBerädert.BaueUnfall
        AnzahlRäder -= 1
        Console.WriteLine("Du hast einen Vogel übersehen.")
    End Sub
End Class
