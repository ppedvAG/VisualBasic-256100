Imports System

Module Program

    ' Custom Exception
    Public Class MyException
        Inherits Exception
        Public Sub New(message As String)
            MyBase.New(message)
        End Sub
    End Class

    Sub Main(args As String())
        Try
            ' Erste Zahl eingeben
            Console.WriteLine("Bitte geben Sie eine Integer-Zahl ein:")
            Dim benutzereingabeInteger1 As Integer = Integer.Parse(Console.ReadLine())
            Console.WriteLine("Zahl 1: " & benutzereingabeInteger1)

            ' Zweite Zahl eingeben
            Console.WriteLine("Bitte geben Sie eine zweite Integer-Zahl ein:")
            Dim benutzereingabeInteger2 As Integer = Integer.Parse(Console.ReadLine())
            Console.WriteLine("Zahl 2: " & benutzereingabeInteger2)

            ' Addition
            Dim ergebnisInt As Integer = benutzereingabeInteger1 + benutzereingabeInteger2
            Console.WriteLine($"{benutzereingabeInteger1} + {benutzereingabeInteger2} = {ergebnisInt}")

            ' Division
            Dim ergebnisDivision As Integer = benutzereingabeInteger1 \ benutzereingabeInteger2
            Console.WriteLine($"{benutzereingabeInteger1} \ {benutzereingabeInteger2} = {ergebnisDivision}")

        Catch ex As FormatException
            Console.WriteLine("Bitte eine ganze Zahl eingeben.")
        Catch ex As OverflowException
            Console.WriteLine("Deine Zahl ist zu groß.")
            'Catch ex As DivideByZeroException
            '    ' Auskommentiert, kann bei Bedarf aktiviert werden
            '    Dim myEx As New MyException("Division durch 0 ist nicht erlaubt!")
            '    Console.WriteLine("Custom Exception: " & myEx.Message)
        Catch ex As Exception
            ' Alle anderen Ausnahmen in Custom Exception wandeln
            Dim myEx As New MyException("Die Berechnung war nicht erfolgreich, das Programm wird abgebrochen.")
            Console.WriteLine("Custom Exception: " & myEx.Message)
        Finally
            Console.WriteLine("Programm wird beendet.")
        End Try
    End Sub

End Module