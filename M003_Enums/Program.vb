Imports System

Module Program

    'ENUMs sind Datentypen, deren Variablen ausschließlich bestimmte vordefinierte Werte annehmen können.
    'Enumes müssen außerhalb von Methoden definiert werden
    'Standardmäßig sind Enums im Kern eine Zahl mit einem Namen. Jeder Enum Wert wird intern als Zahl
    'eines bestimmten Datentyps gespeichert (standardmäßig Integer)
    'Enums starten standardmäßig bei 0.
    'Da die Schleife aber bei 1 beginnt, muss Addition = 1 gesetzt werden, damit die Anzeige passt.
    'Nach "Addition = 1" werden die restlichen Enum-Werte automatisch um 1 hochgezählt.


    Enum Wochentag
        Montag = 1
        Dienstag
        Mittwoch
        Donnerstag
        Freitag
        Samstag
        Sonntag
    End Enum


    Sub Main()

        'Deklaration und Initialisierung einer Enum-Variablen
        Dim heute As Wochentag = Wochentag.Montag
        Console.WriteLine($"Heute ist {heute}.")

        Console.WriteLine("Was glaubst du, was heute für ein Wochentag ist? (Gib eine Zahl für den Wochentag ein)")
        For index = 1 To 7
            'Durchlauf über die möglichen Zustande
            Console.WriteLine($"{index}: {DirectCast(index, Wochentag)}")
            'Durch DirectCast greifen wir auf den index, mit dem dazugehörigen Wert zu.
            'Bsp.: index = 1 und Enum Wochentag an der Stelle 1
        Next
        heute = Integer.Parse(Console.ReadLine())
        'Abfrage eines Enumerator-Zustandes vom Benutzer und Umwandlung von String -> Int -> Enumarator
        Console.WriteLine($"Du denkst, dass heute {heute} ist.")

        'Abfrage eines Enum-Zustandes vom Benutzer und String -> Enum per Parsing
        Console.WriteLine("Was glaubst du, was heute für ein Wochentag ist? (Gib den Wochentag als Wort ein)")
        heute = [Enum].Parse(GetType(Wochentag), Console.ReadLine())
        Console.WriteLine($"Du denkst, dass heute {heute} ist.")


        'SELECTs sind verkürzte If-Blöcke, mit denen genau eine Variable auf ihren Zustand hin überprüft wird.
        ''Jeder Zustand, bei dem etwas passieren soll, wird als CASE definiert, in welchem dann der spezifische Programm-
        ''verlauf definiert wird. Wenn die Variable einen nicht näher definierten Zustand annimmt, wird der ELSE-CASE
        ''ausgeführt
        Select Case heute
            Case Wochentag.Montag
                Console.WriteLine($"Wochentag: {heute}")
                Console.WriteLine("Wochenstart")

            Case Wochentag.Dienstag, Wochentag.Mittwoch, Wochentag.Donnerstag
                Console.WriteLine($"Wochentag: {heute}")
                Console.WriteLine("Woche läuft")

            Case Else
                Console.WriteLine($"Wochentag: {heute}")
                Console.WriteLine("Wochenende")

        End Select

        Console.ReadKey()
    End Sub

End Module
