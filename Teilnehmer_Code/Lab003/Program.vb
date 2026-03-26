Imports System

Module Program
    Enum Wochentag
        Montag = 1
        Dienstag
        Mittwoch
        Donnerstag
        Freitag
        Samstag
        Sonntag

    End Enum
    Sub Main(args As String())

        Dim tag As Wochentag = Wochentag.Montag


        For index = 1 To 7

            Console.WriteLine($"{index}:{DirectCast(index, Wochentag)}")
        Next

        Console.WriteLine("Welcher Wochentag ist heute?")

        tag = [Enum].Parse(GetType(Wochentag), Console.ReadLine())

        Select Case tag
            Case Wochentag.Montag
                Console.WriteLine("Wochenstart")
            Case Wochentag.Dienstag, Wochentag.Mittwoch, Wochentag.Donnerstag
                Console.WriteLine("Woche läuft")
            Case Wochentag.Freitag
                Console.WriteLine("Bald ist Wochenende")
            Case Wochentag.Samstag, Wochentag.Sonntag
                Console.WriteLine("Wochenende")

        End Select






    End Sub
End Module
