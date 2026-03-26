Imports System

Module Program

    'Delegate-Typ:
    '2 Integer-Parameter, Rückgabewert Integer
    Public Delegate Function MyDelegate(a As Integer, b As Integer) As Integer

    Sub Main(args As String())

        Dim rechner As MyDelegate

        rechner = AddressOf Addiere
        Console.WriteLine("Ergebnis: " & rechner(10, 5))
        Console.WriteLine()

        rechner = AddressOf Subtrahiere
        Console.WriteLine("Ergebnis: " & rechner(10, 5))
        Console.WriteLine()

        rechner = AddressOf Multipliziere
        Console.WriteLine("Ergebnis: " & rechner(10, 5))
        Console.WriteLine()

        RechneUndGibAus(AddressOf Addiere)
        RechneUndGibAus(AddressOf Subtrahiere)
        RechneUndGibAus(AddressOf Multipliziere)

        Console.ReadLine()
    End Sub

    Public Sub RechneUndGibAus(methode As MyDelegate)
        Console.WriteLine("Aufruf über Übergabeparameter:")
        Console.WriteLine("Ergebnis: " & methode(10, 5))
        Console.WriteLine()
    End Sub

    Public Function Addiere(a As Integer, b As Integer) As Integer
        Console.WriteLine("Addiere")
        Return a + b
    End Function

    Public Function Subtrahiere(a As Integer, b As Integer) As Integer
        Console.WriteLine("Subtrahiere")
        Return a - b
    End Function

    Public Function Multipliziere(a As Integer, b As Integer) As Integer
        Console.WriteLine("Multipliziere")
        Return a * b
    End Function

End Module