Module Module1

    Sub Main()

        'Bsp-Variablen
        Dim zahl1, zahl2 As Integer
        zahl1 = 123
        zahl2 = 234

        'Ein Sub gibt keinen Wert zurück und kann deshalb nicht in Console.WriteLine(...) verwendet werden.
        'Eine Function liefert ein Ergebnis zurück, das ausgegeben werden kann.

        'SUB-Aufruf mit Übergabe der Variablen
        AddiereUndGibAus(zahl1, zahl2)

        'FUNCTION-Aufruf mit Variablen-Übergabe und Speichern des Rückgabewerts in einer weiteren Variablen
        Dim erg As Integer = Addiere(78, Addiere(zahl1, zahl2))
        Console.WriteLine($"Funktionsaufruf mit Variablen Übergabe: {erg}")
        'Verwendung des Rückgabewerts
        erg = erg * 2
        Console.WriteLine($"Verwendung des Rückgabewertes mit der Multiplikation: {erg}")

        'Bsp eines Aufrufs der überladenen Funktion
        Dim ergDbl As Double = Addiere(45.1, 67.12)
        Console.WriteLine($"Ergebnis der überladenen Funktion 'Addiere' mit Double Werten: {ergDbl}")

        'Bsp eines Aufrufs der Funktion mit optionalem Parameter OHNE Übergabe des optionalen Parameters
        erg = Addiere(1, 2, 3)
        Console.WriteLine($"Ergebnis Aufruf Funktion mit optionalem Parameter OHNE Übergabe des optionalen Parameters: {erg}")

        'Bsp für Übergabe eines Arrays
        Dim zahlen As Integer() = {1, 2, 3, 4, 5}
        erg = BildeSumme(zahlen)
        Console.WriteLine($"Ergebnis BildeSumme mit einem Array: {erg}")

        'Bsp eines Aufrufs der ParamArray-Funktion
        erg = BildeSumme(23, 45, 12, -34, 67)
        Console.WriteLine($"Ergebnis BildeSumme mit separaten Zahlen: {erg}")

        Dim differenz As Integer
        Dim summe As Integer = AddiereUndSubtrahiere(8, 3, differenz)
        Console.WriteLine($"Summe 'AddiereUndSubtrahiere': {summe}")
        Console.WriteLine($"Differenz 'AddiereUndSubtrahiere': {differenz}")

        Console.ReadKey()

    End Sub

    'Methoden sind Programmteile, von denen jeder eine sehr spezielle und kleinteilige Aufgabe ausführt.
    ''Es wird unterschieden zwischen Prozeduren, welche keinen Rückgabewert besitzen und mit dem Stichwort
    ''SUB gekennzeichnet sind...
    Sub AddiereUndGibAus(a As Integer, b As Integer)
        Dim summe As Integer = a + b
        Console.WriteLine(summe)
    End Sub

    '...und Funktionen, die einen Rückgabewert besitzen und mit dem Stichwort FUNCTION markiert werden.
    ''Jede Methode besteht aus einem Kopf (einer Signatur) in welchem der Zugriff und die Methodenart
    ''definiert werden, ein Bezeichner für die Methode bestimmt wird und Übergabeparameter (und Rückgabe-
    ''wert bei Funktionen) definiert werden... 
    Function Addiere(a As Integer, b As Integer) As Integer
        '...und einem Körper, in welchem die Programmlogik hinterlegt wird.
        ''Mittels des RETURN-Befehls wird in Funktionen der Rückgabewert an den Aufrufer gesand und die
        ''Ausführung der Methode unterbrochen
        Dim summe = a + b
        Return summe
    End Function

    'Methoden, welche den gleichen Bezeichner haben aber unterschiedliche Übergabeparameter heißen 'ÜBERLADENE
    ''Methoden'. Eine Eindeutigkeit wird durch die verschiedenen Übergabeparameter erzielt. 
    Function Addiere(a As Double, b As Double) As Double
        Return a + b
    End Function

    'Mit dem OPTIONAL-Stichwort kann man Default-Werte für die Übergabeparameter definieren. Diese werden
    ''bei Nicht-Angabe der Parameter während des Methodenaufrufs eingesetzt.
    Function Addiere(a As Integer, b As Integer, c As Integer, Optional d As Integer = 0) As Integer
        Dim summe = a + b + c + d
        Return summe
    End Function

    'Mittels des PARAMARRAY-Stichwort können beliebig viele Parameter eines Datentyps übergeben werden, welche 
    ''methodenintern als Array interpretiert werden
    Function BildeSumme(ParamArray summanden As Integer()) As Integer
        Dim summe As Integer = 0
        For Each summand In summanden
            summe += summand
        Next
        Return summe
    End Function

    Function AddiereUndSubtrahiere(a As Integer, b As Integer, ByRef erg As Integer) As Integer
        erg = a - b
        Return a + b
    End Function

End Module