Imports System
Imports System.Formats
Imports System.Security.Cryptography.X509Certificates

Module Program
    Enum Rechenoperationen
        Addition = 1
        Subtraktion
        Multiplikation
        Division

    End Enum
    Sub Main(args As String())
        Dim Zahl As Rechenoperationen = Rechenoperationen.Addition

        For index = 1 To 4
            Console.WriteLine($"{index}:{DirectCast(index, Rechenoperationen)}")
        Next

        Console.WriteLine("Gib eine Zahl oder Gleitkommazahl ein")
        Dim A As Double = Console.ReadLine()
        Console.WriteLine("Gib eine weitere Zahl oder Gleitkommazahl ein")
        Dim B As Double = Console.ReadLine()
        Console.WriteLine("Wähle eine Rechenoperation. Gib dafür die gewünschte Zahl ein.")
        Zahl = [Enum].Parse(GetType(Rechenoperationen), Console.ReadLine())

        Select Case Zahl
            Case Rechenoperationen.Addition
                Addiere(A, B)

            Case Rechenoperationen.Subtraktion
                Dim Differenz As Double = Subtrahiere(A, B)
                Console.WriteLine($"Ergebnis = {Differenz}")

            Case Rechenoperationen.Multiplikation
                Dim Produkt As Double = Multipliziere(A, B)
                Console.WriteLine($"Ergebnis = {Produkt}")

            Case Rechenoperationen.Division
                Dim Quotient As Double = Dividiere(A, B)
                Console.WriteLine($"Ergebnis = {Quotient}")

        End Select


        Console.WriteLine("Klicke auf eine beliebige Taste, um das Programm zu beenden")
        Console.ReadKey()


    End Sub

    Public Function Addiere(A As Double, B As Double) As Double
        Dim Summe As Double = A + B
        Console.WriteLine($"Ergebnis = {Summe}")

        Return Summe

    End Function

    Public Function Subtrahiere(A As Double, B As Double) As Double

        Return A - B

    End Function

    Public Function Multipliziere(A As Double, B As Double) As Double

        Return A * B

    End Function

    Public Function Dividiere(A As Double, B As Double) As Double

        Return A / B

    End Function



End Module
