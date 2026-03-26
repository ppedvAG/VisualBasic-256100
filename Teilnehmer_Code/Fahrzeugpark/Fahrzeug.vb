Public MustInherit Class Fahrzeug
    Public Shared AnzahlErstellterFahrzeuge As Integer = 0
    Public Shared Sub ZeigeAnzahlErstellterFahrzeuge()
        Console.WriteLine($"Es wurden {AnzahlErstellterFahrzeuge} Fahrzeuge gebaut.")
    End Sub

    Private _name As String
    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Private _maxG As Integer
    Public Property maxGeschwindigkeit() As Integer
        Get
            Return _maxG
        End Get
        Set(value As Integer)
            _maxG = value
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

    Private _aktG As Integer
    Public Property aktGeschwindigkeit() As Integer
        Get
            Return _aktG
        End Get
        Set(value As Integer)
            _aktG = value
        End Set

    End Property

    Private _zustand As Boolean
    Public Property Zustand() As Boolean
        Get
            Return _zustand
        End Get
        Set(value As Boolean)
            _zustand = value
        End Set
    End Property

    Public Sub StarteMotor()
        Me.Zustand = True
    End Sub
    Public Sub StoppeMotor()
        Me.Zustand = False
    End Sub

    Public Sub Beschleunige(a As Integer)
        If Me.Zustand Then
            If Me.aktGeschwindigkeit + a > Me.maxGeschwindigkeit Then
                Me.aktGeschwindigkeit = Me.maxGeschwindigkeit
            ElseIf Me.aktGeschwindigkeit + a < 0 Then
                Me.aktGeschwindigkeit = 0
            Else
                Me.aktGeschwindigkeit += a
            End If
        End If
    End Sub
    Public Overridable Function Beschreibemich() As String
        Return $"Der {Name},fährt maximal {maxGeschwindigkeit}kmh,kostet {Preis}EURO,fährt aktuell {aktGeschwindigkeit}kmh,mit gestartetem {Zustand} Motor"
    End Function

    Public Sub New(Name As String, maxGeschwindigkeit As Integer, Preis As Double, aktGeschwindigkeit As Integer, Zustand As Boolean)
        _name = Name
        _maxG = maxGeschwindigkeit
        _preis = Preis
        _aktG = aktGeschwindigkeit
        _zustand = Zustand
    End Sub

End Class
