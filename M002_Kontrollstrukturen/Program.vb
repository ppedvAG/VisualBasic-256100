Imports System

Module Program

    'KONTROLLSTRUKTUREN regeln den Ablauf des Programms unter Bezug auf bestimmte, durch boolsche Werte oder logische
    ''Operationen dargestellte Zustände des Programms
    Sub Main(args As String())

        'Deklaration und Initialisierung von Bool-Variablen
        Dim a As Integer = 110
        Dim b As Integer = 120

        'Ein IF-Block teilt den Programmablauf in mehrere Pfade, abhängig von einer oder mehrerer Bedingungen. Das Programm
        ''wird jeweils den ersten Block ausführen, bei welchem es auf eine wahre Bedingung trifft.
        If a < b Then
            'Dies wird ausgeführt, wenn die Bedingung des IF-Blocks wahr ist.
            Console.WriteLine("A ist kleiner als B")
            'Diese Variable ist nur innerhalb des If-Blocks bekannt
            Dim zahl As Integer = 123
            Console.WriteLine(zahl)

        ElseIf a > b Then
            'Ein If-Block kann beliebig viele ELSEIF-Blöcke beinhalten, welche weitere Bedingungen prüfen. Diese werden
            ''jedoch nur geprüft, wenn alle vorherigen Bedingungen false sind.
            Console.WriteLine("A ist größer als B")

        ElseIf a > b Then
            'Dieser Block wird nie ausgeführt, da diese Bedingung bereits durch die vorherige abgedeckt wird
            Console.WriteLine("Hallo")

        Else
            'Der optionale ELSE-Block wird ausgeführt, wenn keine der vorherigen Bedingungen wahr sind.
            Console.WriteLine("A ist gleich B")

        End If
        Console.WriteLine("Ende des IF-Blocks")

        '----------------

        'Eine WHILE-Schleife wird wiederholt, solange die Bedingung wahr ist. Ist die Bedingung von vornherein
        ''unwahr, wird die Schleife übersprungen
        While a < b
            a += 1

            If a = 115 Then
                Continue While
                'Bei 115 wird das untere "Console.WriteLine(a)" übersprungen, da die Bedingung hier stimmt
                'und der Loop von Vorne geprüft werden muss
            End If

            Console.WriteLine(a)
        End While
        '----------------

        'Auch eine DO-WHILE-Schleife wird solange wiederholt, bis die Bedingung unwahr ist. Allerdings findet die Bedingungs-
        ''prüfung erst am Ende eines Schleifendurchlaufs statt. D.h. die Scheife läuft mindestens einmal durch.
        Do

            Console.WriteLine("Do-Schleife")

            Console.Write("Soll die Schleife wiederholt werden (Y/N)?")
            If Console.ReadKey().Key <> ConsoleKey.Y Then
                'Der EXIT-Befehl beendet eine Schleife sofort und zwingt das Programm unterhalb der Schleife weiter zu machen.
                Console.WriteLine($"{vbCrLf}")
                Exit Do
            End If

        Loop While True

        '----------------

        'Bsp für Do Until (<= Verneinung von Do While)
        Do

            a -= 1
            Console.WriteLine($"Bsp für Do Until 1: Stand von a ist: {a}")

            '1.) Die Schleife startet.
            '2.) a wird um 1 verringert: a = 119
            '3.) Das geht so weiter bis 109
            '4.) Der Wert 109 wird ausgegeben.
            '5.) Danach wird geprüft: a < 110
            '6.) Die Bedingung ist True, deshalb endet die Schleife.


        Loop Until a < 110

        '----------------

        Do

            a -= 1

            Console.WriteLine($"Bsp für Do Until 2: Stand von a ist: {a}")


            'Wiederhole die Schleife, solange a nicht kleiner als 110 ist. 
            '1.) a startet mit 109
            '2.) a -= 1 → a wird 108
            '3.) Ausgabe: 108
            '4.) Prüfung: Not (108 < 110) → Not True → False
            '5.) Schleife endet
        Loop While Not a < 110

        '----------------

        'Eine FOR-Schleife besitzt eine Laufindexvariable, welche bei jedem Durchlauf manipuliert wird. Durch die Initialisierung
        ''dieser und der Angabe eines maximalen Werts, kann man festlegen, wie oft die Schleife durchläuft
        For index = 1 To 10

            Console.WriteLine("Durchlauf Nr. " + index.ToString())

        Next

        'Mittels des optionalen STEP-Befehls kann man selbst die Manipulation der Indexvariablen bestimmen
        For index = 10 To 0 Step -2

            Console.WriteLine("Durchlauf Nr. " + index.ToString())

        Next

        '----------------

        'Ein ARRAY ist eine Sammlung von Werten eines bestimmten Datentyps. Ein Zugriff auf die einzelnen Werte erfolgt über
        ''einen Null-basierten Index. Die Größe eines Arrays muss bei Deklaration festgelegt werden.
        Dim Städte As String() = {"München", "Berlin", "Hamburg"}
        Dim Städte2 = New String() {"München", "Berlin", "Hamburg"}

        'Ausgabe des Werts an der Indexposition 1
        Console.WriteLine($"Städte Array an der Indexposition 1: {Städte(1)}")
        'Manipulation des Wertes an der ersten(!) Position
        Städte(0) = "Köln"

        'Iteration einer For-Schleife über ein Array
        For index = 0 To Städte.Length - 1

            Console.WriteLine($"Städte Array Iteration: {Städte(index)}")

        Next

        'Eine FOREACH-Schleife kann über eine Collection wie z.B. ein Array laufen und spricht dabei jedes Element genau
        ''einmal an
        For Each stadt In Städte

            Console.WriteLine($"For Each Schleife mit dem Array 'stadt': {stadt}")

        Next

        'Mittels des REDIM-Befehls kann man die Größe (d.h. Kapazität) des Arrays manipulieren. In die Klammern schreibt man
        ''die neue Größe des Arrays. Mit dem PRESERVE-Stichwort behält das Array alle bisherigen Werte
        ReDim Preserve Städte(3)
        Städte(3) = "Regensburg"
        Console.Write($"Städte.Lenght mit dem Array 'Städte': {Städte.Length}")
        Console.WriteLine($"{vbCrLf}")
        For Each stadt In Städte

            Console.WriteLine($"ReDim Preserve mit der neuen Stadt 'Regensburg': {stadt}")

        Next

        'Mittels der Contains()-Methode kann eine Collection auf einen Inhalt hin überprüft werden
        Console.WriteLine(vbCrLf)
        Console.WriteLine($"Städte.Contains mit Hamburg: {Städte.Contains("Hamburg")}")

    End Sub

End Module
