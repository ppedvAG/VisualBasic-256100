Imports System

Module Program

    'Definition des Enumerators
    'Enums starten standardmäßig bei 0.
    'Da die Schleife aber bei 1 beginnt, muss Addition = 1 gesetzt werden, damit die Anzeige passt.
    'Nach "Addition = 1" werden die restlichen Enum-Werte automatisch um 1 hochgezählt.
    Enum Rechenoperation
        Addition = 1
        Subtraktion
        Multiplikation
        Division
    End Enum

    Sub Main()
        'Deklaration der Variablen
        Dim zahl1, zahl2 As Double
        Dim operation As Rechenoperation

        'Abfrage der Zahlen
        zahl1 = Eingabe("Gib eine Zahl oder Gleitkommazahl ein: ")
        zahl2 = Eingabe("Gib eine weitere Zahl oder Gleitkommazahl ein: ")

        'Abfrage der Rechenoperation
        Console.WriteLine("Wähle eine Rechenoperation. Gib dafür die gewünschte Zahl ein:")
        For index = 1 To 4
            Console.WriteLine($"{index}: {DirectCast(index, Rechenoperation)}")
        Next

        'Eingabe der Benutzerwahl (ReadLine) -> Umwandeln in Integer (Parse) -> Zuweisung zu Enum-Variable (=)
        operation = Integer.Parse(Console.ReadLine())

        'Übergabe der Werte an Funktion und Zuweisung des Rückgabewerts (Ergebnis) zu einer Double-Variablen
        Dim ergebnis As Double = Berechne(zahl1, zahl2, operation)

        If Double.IsNaN(ergebnis) Then
            Console.WriteLine("Deine Eingabe war fehlerhaft")
        ElseIf Double.IsInfinity(ergebnis) Then
            Console.WriteLine("Eine Teilung durch 0 ist nicht möglich")
        Else
            Console.WriteLine($"Ergebnis: {ergebnis}")
        End If


        'Programmpause
        Console.ReadKey()
    End Sub

    'Berechne()-Funktion
    Public Function Berechne(zahl1 As Double, zahl2 As Double, operation As Rechenoperation) As Double
        'SelectCase zur Fallunterscheidung
        Select Case operation
            Case Rechenoperation.Addition
                Return zahl1 + zahl2
            Case Rechenoperation.Subtraktion
                Return zahl1 - zahl2
            Case Rechenoperation.Multiplikation
                Return zahl1 * zahl2
            Case Rechenoperation.Division
                Return zahl1 / zahl2
            Case Else
                'Rückgabe der Konstanten NaN (Not A Number) der Double-Klasse bei fehlerhafter Eingabe
                Return Double.NaN
        End Select
    End Function

    'Eingabe()-Funktion
    Public Function Eingabe(anweisung As String) As Double
        Console.Write(anweisung)
        Return Double.Parse(Console.ReadLine())
    End Function

End Module
