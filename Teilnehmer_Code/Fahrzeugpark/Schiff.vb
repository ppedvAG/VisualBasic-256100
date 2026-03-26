Public Class Schiff
    Inherits Fahrzeug
    Implements IBeladbar
    Private _anzahlMotoren As Integer
    Public Property AnzahlMotoren() As Integer
        Get
            Return _anzahlMotoren
        End Get
        Set(value As Integer)
            _anzahlMotoren = value
        End Set
    End Property
    Private _ladung As Fahrzeug
    Public Property Ladung As Fahrzeug Implements IBeladbar.Ladung
        Get
            Return _ladung
        End Get
        Set(value As Fahrzeug)
            _ladung = value
        End Set
    End Property

    Public Sub Belade(fz As Fahrzeug) Implements IBeladbar.Belade
        If fz.Equals(Me) Then
            Console.WriteLine($"{Name} kann nicht auf sich selbst geladen werden.")
        ElseIf IsNothing(Ladung) Then
            Ladung = fz
            Console.WriteLine($"Ladevorgang von {fz.Name} auf {Name} war erfolgreich.")
        Else
            Console.WriteLine($"{fz.Name} konnt nicht auf {Name} geladen werden, da der Laderaum schon belegt war.")

        End If
    End Sub
    Public Function Entlade() As Fahrzeug Implements IBeladbar.Entlade
        Dim ladung As Fahrzeug = _ladung
        If IsNothing(ladung) Then
            Console.WriteLine($"Entladevorgang nicht möglich, da der Laderaum von {Name} bereits leer ist.")
        Else
            Console.WriteLine($"{ladung.Name} wurde erfolgreich von {Name} entladen.")
            _ladung = Nothing
        End If
        Return ladung

    End Function


    Public Sub New(Name As String, maxGeschwindigkeit As Integer, Preis As Double, aktGeschwindigkeit As Integer, Zustand As Boolean, AnzahlMotoren As Integer)
        MyBase.New(Name, maxGeschwindigkeit, Preis, aktGeschwindigkeit, Zustand)
        _anzahlMotoren = AnzahlMotoren

    End Sub
    Public Overrides Function BeschreibeMich() As String
        If IsNothing(Ladung) Then
            Return "Das Schiff " + MyBase.Beschreibemich() + $" Es wird mit {_anzahlMotoren} Motoren angetrieben."
        Else
            Return "Das Schiff " + MyBase.Beschreibemich() + $" Es wird mit {_anzahlMotoren} Motoren angetrieben und hat {Ladung.Name} geladen."
        End If

    End Function


End Class
