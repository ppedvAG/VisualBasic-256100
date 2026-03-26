Imports System

Module Program
    Public Delegate Function MyDelegate(zahl1 As Integer, zahl2 As Integer) As Integer

    Sub Main(args As String())
        Dim delegateAddiere As MyDelegate = AddressOf Addiere
        Dim delegateSubtrahiere As MyDelegate = AddressOf Subtrahiere
        Dim delegateMultipliziere As MyDelegate = AddressOf Multipliziere
        delegateAddiere(4, 6)
        delegateSubtrahiere(10, 6)
        delegateMultipliziere(5, 5)
        RechneUndGibAusAddiere(delegateAddiere)
        RechneUndGibAusSubtrahiere(delegateSubtrahiere)
        RechneUndGibAusMultipliziere(delegateMultipliziere)

    End Sub

    Public Function Addiere(A As Integer, B As Integer) As Integer
        Dim Summe As Integer = A + B
        Console.WriteLine("Addiere")
        Console.WriteLine($"Ergebnis: {Summe}")

        Return Summe

    End Function

    Public Function Subtrahiere(A As Integer, B As Integer) As Integer
        Dim Differenz As Integer = A - B
        Console.WriteLine("Subtrahiere")
        Console.WriteLine($"Ergebnis: {Differenz}")

        Return Differenz

    End Function

    Public Function Multipliziere(A As Integer, B As Integer) As Integer
        Dim Produkt As Integer = A * B
        Console.WriteLine("Multipliziere")
        Console.WriteLine($"Ergebnis: {Produkt}")

        Return Produkt

    End Function

    Public Sub RechneUndGibAusAddiere(methode As MyDelegate)
        Console.WriteLine("Aufruf über Übergabeparameter")
        methode(4, 6)

    End Sub

    Public Sub RechneUndGibAusSubtrahiere(methode As MyDelegate)
        Console.WriteLine("Aufruf über Übergabeparameter")
        methode(10, 6)

    End Sub

    Public Sub RechneUndGibAusMultipliziere(methode As MyDelegate)
        Console.WriteLine("Aufruf über Übergabeparameter")
        methode(5, 5)

    End Sub


End Module
