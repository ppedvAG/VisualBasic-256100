Public Class Person

    Private _geburtsdatum As DateTime
    Public Property Geburtsdatum() As DateTime
        Get
            Return _geburtsdatum
        End Get
        Set(ByVal value As DateTime)
            _geburtsdatum = value
        End Set
    End Property

    Private _name As String
    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property

    Private _groesse As Integer
    Public Property Groesse() As Integer
        Get
            Return _groesse
        End Get
        Set(ByVal value As Integer)
            _groesse = value
        End Set
    End Property

    Public Sub New(name As String, groesse As Integer, geburtsdatum As DateTime)
        _name = name
        _groesse = groesse
        _geburtsdatum = geburtsdatum
    End Sub

    Public Overrides Function ToString() As String
        Return $"{Name} ({Groesse} cm): {Geburtsdatum.ToShortDateString()}"
    End Function '

End Class
