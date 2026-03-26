Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        Console.WriteLine("Bitte gib eine Zahl zwischen 1 und 10 ein")
        Dim Gewinnzahl1 As Integer = Console.ReadLine()
        Console.WriteLine("Bitte gib eine Zahl zwischen 1 und 10 ein")
        Dim Gewinnzahl2 As Integer = Console.ReadLine()
        Console.WriteLine("Bitte gib eine Zahl zwischen 1 und 10 ein")
        Dim Gewinnzahl3 As Integer = Console.ReadLine()

        Dim generator As Random = New Random()


        Dim Zufallszahl1 As Integer = generator.Next(1, 11)
        Dim Zufallszahl2 As Integer = generator.Next(1, 11)
        Dim Zufallszahl3 As Integer = generator.Next(1, 11)


        Console.WriteLine($"{Zufallszahl1},{Zufallszahl2},{Zufallszahl3}")

        If Gewinnzahl1 And Gewinnzahl2 And Gewinnzahl3 = Zufallszahl1 And Zufallszahl2 And Zufallszahl3 Then
            Console.WriteLine("Du hast 3 Richtige")

        ElseIf Gewinnzahl1 Or Gewinnzahl2 Or Gewinnzahl3 = Zufallszahl1 And Zufallszahl2 And Zufallszahl3 Then
            Console.WriteLine("Du hast 2 Richtige")

        ElseIf Gewinnzahl1 = Zufallszahl1 And Zufallszahl2 And Zufallszahl3 Then
            Console.WriteLine("Du hast 1 Richtige")

        Else
            Console.WriteLine("Du hast 0 Richtige")
        End If




    End Sub
End Module
