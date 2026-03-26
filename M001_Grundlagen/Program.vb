'MODULE sind grundlegende Programmeinheiten, von welchen sich keine Instanzen erstellen lassen. Sie beinhalten nur ausführbaren Code
''der einer bestimmten Aufgabe zugeordnet ist.
Module Program

    'Die Main()-Methode ist der Einstiegspunkt in jedes .NET-Programm. Hier startet das Programm.
    'Sub steht in Visual Basic für ein Unterprogramm bzw. eine Prozedur
    Sub Main()

        'Zugriff auf die BackgroundColor-Eigenschaft der Console-Klasse und Neuzuweisung dieser
        Console.BackgroundColor = ConsoleColor.Blue

        'Ausgabe eines String-Literals in der Console
        Console.WriteLine("Einfache Ausgabe: Hello World")

        'Deklaration einer String-Variablen
        Dim meinString As String
        'Initialisierung der String-Variablen
        meinString = "Hello World"
        'Ausgabe der String-Variablen
        Console.WriteLine($"meinString: {meinString}")

        'Neuzuweisung und Ausgabe der String-Variablen
        meinString = "Heute ist ein schöner Tag!"
        Console.WriteLine($"meinString Neuzuweisung: {meinString}")

        'Deklaration und Initialisierung weiterer Variablen (jeweils in einer Zeile)
        Dim Name As String = "Klaas"
        Dim Alter As Integer = 33

        'String-Formatierungen
        ''"traditionelle" Verknüpfung durch +-Operatoren (Nicht-Strings müssen explizit umgewandelt werden)
        Dim kombinierterString As String = "Mein Name ist " + Name + " und ich bin " + Alter.ToString() + " Jahre alt."
        Console.WriteLine($"kombinierterString mit traditioneller Verknüpfung: {kombinierterString}")
        Console.WriteLine("Direkte Ausgabe des Strings: Mein Name ist " + Name + " und ich bin " + Alter.ToString() + " Jahre alt.")

        ''$-Schreibweise -> Variablen werden direkt im String platziert
        kombinierterString = $"Mein Name ist {Name} und ich bin {Alter} Jahre alt."
        Console.WriteLine($"kombinierterString mit $-Schreibweise: {kombinierterString}")

        ''Indexschreibweise -> Null-basierte Indizes werden durch angegebene Variablen ausgetauscht
        Console.WriteLine("Indexschreibweise: Mein Name ist {0} und ich bin {1} Jahre alt.", Name, Alter)

        'Formatierung durch Konstanten
        ''vbNewLine -> erzwingt Zeilenumbruch
        ''vbTab -> erzwingt horizontalen Tabulator
        Console.WriteLine($"Dies ist ein Zeilenumbruch{vbCrLf}und dies ein {vbTab} horizontaler Tab.")


        'Deklaration und Initialisierung einer eigenen Konstanten
        'Const kann nicht verändert werden, daher der Name "Const"
        Const PI As Double = 3.15
        Console.WriteLine($"PI: {PI}")

        'Speichern einer Benutzereingabe (String) in einer Variablen
        Console.WriteLine("Bitte gib eine Zahl ein:")
        Dim benutzereingabe As String = Console.ReadLine()
        Console.WriteLine($"Dein Zahl ist: {benutzereingabe}")

        'Parsen des Strings in einen Integer
        Dim eingabeAlsString As Integer = Integer.Parse(benutzereingabe)
        Console.WriteLine($"Das Doppelte deiner Zahl ist: {eingabeAlsString * 2}")

        'Abgreifen und Zwischenspeichern einer gedrückten Taste
        Console.WriteLine("Tippe auf Zeichen auf der Tastatur")
        'True als Argument = Die gedrückte Taste wird in der Konsole angezeigt
        Dim gedrückteTaste As ConsoleKeyInfo = Console.ReadKey(True)
        Console.WriteLine($"Du hast die Taste >>{gedrückteTaste.Key}<< gedrückt.")

        'Charvariableninitialisierung. Optional auch ohne das "c" am Ende, aber könnte zu Komplierfehler führen.
        Dim c As Char = "a"c

        ' Implizite Umwandlung: Integer -> Double
        Dim ganzeZahl As Integer = 23
        Dim kommaZahl As Double = ganzeZahl
        Console.WriteLine($"Kommazahl (implizit): {kommaZahl}")

        ' Explizite Umwandlung: Double -> Integer
        ' Es wird kaufmännisch aufgerundet, wenn vonls
        ' Double -> Integer
        kommaZahl = 23.33
        ganzeZahl = CInt(kommaZahl)
        Console.WriteLine($"Ganze Zahl (explizit): {ganzeZahl}")

        'Anwendung von Math.Floor() (Rundung zur niedrigeren Zahl)
        ganzeZahl = Math.Floor(kommaZahl)
        Console.WriteLine($"Ganze Zahl mit Math.Floor: {ganzeZahl}")


        'Teilung durch 0
        Dim a As Integer = 12
        Dim b As Integer = 2
        Dim erg As Double = a / b
        Console.WriteLine($"erg: {erg}") 'Zeigt eine 8, soll aber ein Unendlichkeitszeichen sein
        Console.WriteLine(Double.IsInfinity(erg)) 'Zeigt, dass die Variable "erg" unendlich ist, wenn "True" kommt





        Console.ReadKey()

    End Sub

End Module
