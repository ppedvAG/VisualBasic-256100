Imports System
Imports Fahrzeugpark

Module Program
    Sub Main(args As String())

#Region "Modul 05 OOP" 'Für Lab-05 muss es auskommentiert bleiben

        ''Deklaration von Klassen-Variablen und Initialisierung von neuen Objekten über deren Konstruktor
        'Dim fz1 As Fahrzeug = New Fahrzeug("BMW", 230)
        'Dim fz2 As Fahrzeug = New Fahrzeug("Mercedes", 190)
        'Dim fz3 As Fahrzeug = New Fahrzeug("Volkswagen", 190, 40000.0)

        '''Ausgabe von Objekt-Eigenschaften (über Property-Getter)
        'Console.WriteLine(fz1.Name)
        'Console.WriteLine(fz1.MaxGeschwindigkeit)
        'Console.WriteLine(fz2.Name)
        'Console.WriteLine(fz2.MaxGeschwindigkeit)
        'Console.WriteLine(fz3.Preis)

        ''Neubelegung einer Eigenschaft (über Property-Setter)
        ''Dies hat nur Auswirkungen auf diese spezifische Fahrzeug-Instanz und auf kein anderes Fahrzeug-Objekt
        'fz2.Name = "Audi"
        'Console.WriteLine(fz2.Name)

        ''Aufruf einer Klassen-Funktion und Ausgabe des Rückgabewerts
        ''Ist möglich, da die "BeschreibeMich()" Methode eine Funktion ist und deshalb einen Rückgabewert hat. 
        'Console.WriteLine(fz2.BeschreibeMich())
        'Console.WriteLine(fz1.BeschreibeMich())

        'Schleife zur Demonstration des Destruktors
        ''Für Lab-05 und Module-05 muss es auskommentiert bleiben. Für die Demo musst du es auskommentieren und dann wieder kommentieren,
        ''damit Lab-05 und Module-05 keine unnötigen Ausgaben haben.

        'Dim fz As Fahrzeug
        'For index = 1 To 10000
        '    fz = New Fahrzeug($"{index}", 100)
        'Next

        'Erzwingung einer GarbageCollection-Iteration zur Demonstration des Destruktors
        ''Für Lab-05 und Module-05 muss es auskommentiert bleiben. Für die Demo musst du es auskommentieren und dann wieder kommentieren,
        ''damit Lab-05 und Module-05 keine unnötigen Ausgaben haben.
        'GC.Collect()
        'GC.WaitForPendingFinalizers()
#End Region

#Region "Lab 05 Fahrzeug-Klasse" 'Für Modul-05 muss es auskommentiert bleiben

        ''Deklaration der Fahrzeugvariablen und Initialisierung der Fahrzeugobjekte
        'Dim fz1 As Fahrzeug = New Fahrzeug("BMW", 270, 25000)
        'Dim fz2 As Fahrzeug = New Fahrzeug("Mercedes", 260, 28000)

        ''Ausgabe der Name-Property von fz1 (über deren Getter)
        'Console.WriteLine($"Fahrzeugname FZ1: {fz1.Name}")

        ''Ausführen der StarteMotor Funktion von fz1
        'fz1.StarteMotor()

        ''Ausführen der Beschleunige Methode von fz1
        'fz1.Beschleunige(80)

        ''Ausgabe der AktGeschwindigkeit-Properties
        'Console.WriteLine($"Aktuelle Geschwindigkeit FZ1: {fz1.AktGeschwindigkeit}")
        'Console.WriteLine($"Aktuelle Geschwindigkeit FZ2: {fz2.AktGeschwindigkeit}")

        ''Ausführen von Methoden von fz1 -> extra über maximale Geschwindigkeit
        'fz1.Beschleunige(300)

        ''Ausgabe der BeschreibeMich()-Methoden
        'Console.WriteLine($"Beschreibung FZ1: {fz1.BeschreibeMich()}")
        'Console.WriteLine($"Beschreibung FZ2: {fz2.BeschreibeMich()}")

#End Region

#Region "Modul 07 Vererbung"
        'Für Lab-07 und Module-07 musst du es entkommentieren
        'Dim pkw1 As PKW = New PKW("BMW", 260, 28000, 5)

        'Console.WriteLine($"pkw1.BeschreibeMich(): {pkw1.BeschreibeMich()}")

        'Console.WriteLine($"pkw1: : {pkw1}")

        'Wenn die Klasse als "MustInherit" markiert ist, kann man keine Instanz/Objekt davon erstellen
        'Dim fz1 As Fahrzeug = New Fahrzeug()

        'Fahrzeug.ZeigeAnzahlErstellterFahrzeuge()

        'pkw1.Hupen()
#End Region

#Region "Lab 07 Schiffs-, PKW-, Flugzeug-Klassen"
        ''Deklaration und Initialisierung der spezifischen Fahrzeuge sowie Aufruf der BeschreibeMich()-Methoden
        'Dim pkw1 As PKW = New PKW("BMW", 270, 27000, 5)
        'Console.WriteLine(pkw1.BeschreibeMich())

        'Dim flugzeug1 As Flugzeug = New Flugzeug("Boing", 800, 3500000, 9999)
        'Console.WriteLine(flugzeug1.BeschreibeMich())

        'Dim schiff1 As Schiff = New Schiff("Titanic", 50, 2900000, Schiff.Schiffstreibstoff.Dampf)
        'Console.WriteLine(schiff1.BeschreibeMich())

        ''Aufruf der abstarkten Methoden Hupen()
        'pkw1.Hupen()
        'schiff1.Hupen()
        'flugzeug1.Hupen()

        ''Ausgabe des Shared Members der Fahrzeug-Klasse
        'Fahrzeug.ZeigeAnzahlErstellterFahrzeuge()
#End Region

#Region "Modul 08: Interfaces und Polymorphismus"
        ''Bsp-Objekt
        'Dim pkw1 As PKW = New PKW("BMW", 270, 27000, 5)

        '''Zugriff auf durch Interface definierte Property und Methode
        'Console.WriteLine(pkw1.AnzahlRäder)
        'pkw1.BaueUnfall()

        '''Durch den POLYMORPHISMUS kann der PKW auch als allgemeines FAHRZEUG (Vererbung) oder
        ''''IBERÄDERT-OBJEKT (Interface) betrachtet werden. Dies erlaubt einen gemeinsamen Zugriff auf Objekte,
        ''''welche eine Vererbungshierachie oder ein Interface teilen (Bsp in Arrays oder Methodenübergaben)

        '''PKW in Fahrzeug-Variabler
        'Dim fz1 As Fahrzeug = pkw1
        '''PKW in IBerädert-Variabler
        'Dim berädertesObjekt As IBerädert = pkw1
        '''Array von Fahrzeugen mit einem PKW und einem Schiff

#End Region

#Region "Lab08: IBeladbar"
        ''Methode "BeladeFahrzeug" ist weiter unten zu finden unter "Modul 08 Methode". Musst du auskommentieren.
        'Dim pkw1 As PKW = New PKW("BMW", 270, 27000, 5)
        'Dim flugzeug1 As Flugzeug = New Flugzeug("Boing", 800, 3500000, 9999)
        'Dim schiff1 As Schiff = New Schiff("Titanic", 50, 2900000, Schiff.Schiffstreibstoff.Dampf)

        'schiff1.Belade(flugzeug1)

        'schiff1.Entlade()

        'Console.WriteLine(schiff1.BeschreibeMich())

#End Region

#Region "Modul09: Generische Listen"

        ''Deklaration und Initialisierung einer List-Variablen, welche Strings fassen kann
        Dim städteListe As List(Of String) = New List(Of String)

        ''Hinzufügen von Strings zu der Liste
        städteListe.Add("Hamburg")
        städteListe.Add("Berlin")
        städteListe.Add("München")
        städteListe.Add("Köln")

        ''Ausgabe der Anzahl der Elemente in der Liste
        Console.WriteLine($"städteListe.Count: {städteListe.Count}")

        ''Ausgabe des dritten Elements in der Liste
        Console.WriteLine($"städteListe(2): {städteListe(2)}")

        ''Löschen des Objekts 'Berlin' aus der Liste -> untere Objekte rutschen nach oben und Platz-Anzahl innerhalb der Liste wird reduziert
        städteListe.Remove("Berlin")
        Console.WriteLine($"städteListe.Count nach entfernen von 'Berlin': {städteListe.Count}")
        Console.WriteLine($"städteListe(2) nach entfernen von 'Berlin': {städteListe(2)}")

        ''Neuzuweisung des zweiten Elements in der Liste
        städteListe(1) = "Magdeburg"

        Console.WriteLine($"städteListe(1) nach Neuzuweisung des zweiten Elementes in der Liste: {städteListe(1)}")

        ''Ausgabe der Liste in einer For-Each-Schleife
        For Each stadt In städteListe
            Console.WriteLine($"Ausgabe von stadt in einer For-Each Schleife: {stadt}")
        Next

        ''Erstellen einer Liste, welche beliebige Fahrzeuge (PKWs, Flugzeuge, Schiffe) fassen kann
        Dim fahrzeugListe As List(Of Fahrzeug) = New List(Of Fahrzeug)

        ''Deklaration und Initialisierung von Bsp-Variablen
        Dim pkw1 As PKW = New PKW("BMW", 270, 27000, 5)
        Dim schiff1 As Schiff = New Schiff("Titanic", 50, 2900000, Schiff.Schiffstreibstoff.Dampf)

        ''Hinzufügen von Elementen zur Liste
        fahrzeugListe.Add(pkw1)
        fahrzeugListe.Add(New Flugzeug("Boing", 800, 3500000, 9999))
        fahrzeugListe.Add(schiff1)

        ''For-Schleife über die Liste
        For index = 0 To fahrzeugListe.Count - 1
            Console.WriteLine(fahrzeugListe(index).BeschreibeMich())
        Next

        ''Erstellen eines neuen Dictionaries mit Strins als Keys und Fahrzeugen als Values
        Dim dict As Dictionary(Of String, Fahrzeug) = New Dictionary(Of String, Fahrzeug)

        ''Hinzufügen von neuen Dictionary-Einträgen
        dict.Add("fahren", pkw1)
        dict.Add("schwimmen", schiff1)
        dict.Add("fliegen", fahrzeugListe(1))

        ''Ausgabe der BeschreibeMich()-Methode des Flugzeuges über den String-Key des Dictionaries
        Console.WriteLine(dict("schwimmen").BeschreibeMich())

        ''ForEach-Schleife über Dictionary
        For Each zeile In dict
            Console.WriteLine($"{zeile.Key}: {zeile.Value.Name}")
        Next

        'Stack Beispiel
        Dim stapel As New Stack(Of String)

        Console.WriteLine("=== Elemente auf den Stack legen ===")
        stapel.Push("Erstes Buch")
        Console.WriteLine("Hinzugefügt: Erstes Buch")

        stapel.Push("Zweites Buch")
        Console.WriteLine("Hinzugefügt: Zweites Buch")

        stapel.Push("Drittes Buch")
        Console.WriteLine("Hinzugefügt: Drittes Buch")

        Console.WriteLine()
        Console.WriteLine($"Aktuelles oberstes Element: {stapel.Peek()}")
        Console.WriteLine($"Anzahl Elemente: {stapel.Count}")

        Console.WriteLine()
        Console.WriteLine("=== Elemente wieder vom Stack nehmen ===")
        Console.WriteLine($"Entnommen: {stapel.Pop()}")
        Console.WriteLine($"Jetzt oben: {stapel.Peek()}")

        Console.WriteLine($"Entnommen: {stapel.Pop()}")
        Console.WriteLine($"Jetzt oben: {stapel.Peek()}")

        Console.WriteLine($"Entnommen: {stapel.Pop()}")

        Console.WriteLine()
        Console.WriteLine($"Anzahl Elemente am Ende: {stapel.Count}")

        'Queue Beispiel
        Dim warteschlange As New Queue(Of String)

        Console.WriteLine("=== Elemente in die Queue einfügen ===")
        warteschlange.Enqueue("Erste Person")
        Console.WriteLine("Hinzugefügt: Erste Person")

        warteschlange.Enqueue("Zweite Person")
        Console.WriteLine("Hinzugefügt: Zweite Person")

        warteschlange.Enqueue("Dritte Person")
        Console.WriteLine("Hinzugefügt: Dritte Person")

        Console.WriteLine()
        Console.WriteLine($"Vorderstes Element: {warteschlange.Peek()}")
        Console.WriteLine($"Anzahl Elemente: {warteschlange.Count}")

        Console.WriteLine()
        Console.WriteLine("=== Elemente wieder aus der Queue nehmen ===")
        Console.WriteLine($"Entnommen: {warteschlange.Dequeue()}")
        Console.WriteLine($"Jetzt vorne: {warteschlange.Peek()}")

        Console.WriteLine($"Entnommen: {warteschlange.Dequeue()}")
        Console.WriteLine($"Jetzt vorne: {warteschlange.Peek()}")

        Console.WriteLine($"Entnommen: {warteschlange.Dequeue()}")

        Console.WriteLine()
        Console.WriteLine($"Anzahl Elemente am Ende: {warteschlange.Count}")

        Dim ht As New Hashtable()

        Console.WriteLine("=== Einträge in die Hashtable einfügen ===")
        ht.Add("Name", "Max")
        Console.WriteLine("Hinzugefügt: Key = Name, Value = Max")

        ht.Add("Alter", 25)
        Console.WriteLine("Hinzugefügt: Key = Alter, Value = 25")

        ht.Add("Stadt", "Berlin")
        Console.WriteLine("Hinzugefügt: Key = Stadt, Value = Berlin")

        Console.WriteLine()
        Console.WriteLine("=== Auf Werte über den Key zugreifen ===")
        Console.WriteLine($"ht(""Name"") = {ht("Name")}")
        Console.WriteLine($"ht(""Alter"") = {ht("Alter")}")
        Console.WriteLine($"ht(""Stadt"") = {ht("Stadt")}")

        Console.WriteLine()
        Console.WriteLine("=== Wert zu einem vorhandenen Key ändern ===")
        ht("Stadt") = "Hamburg"
        Console.WriteLine("Key 'Stadt' wurde geändert.")
        Console.WriteLine($"ht(""Stadt"") = {ht("Stadt")}")

        Console.WriteLine()
        Console.WriteLine("=== Prüfen, ob ein Key vorhanden ist ===")
        If ht.ContainsKey("Name") Then
            Console.WriteLine("Der Key 'Name' ist vorhanden.")
        Else
            Console.WriteLine("Der Key 'Name' ist nicht vorhanden.")
        End If

        If ht.ContainsKey("Land") Then
            Console.WriteLine("Der Key 'Land' ist vorhanden.")
        Else
            Console.WriteLine("Der Key 'Land' ist nicht vorhanden.")
        End If

        Console.WriteLine()
        Console.WriteLine("=== Alle Einträge der Hashtable ausgeben ===")
        For Each eintrag As DictionaryEntry In ht
            Console.WriteLine($"Key: {eintrag.Key} | Value: {eintrag.Value}")
        Next
#End Region

#Region "Lab 09: Zufällige Fahrzeuglisten"
        ''Initialisierung der Listen und des Zufallszahlengenerators
        Dim generator As Random = New Random()
        Dim fzQueue As Queue(Of Fahrzeug) = New Queue(Of Fahrzeug)()
        Dim fzStack As Stack(Of Fahrzeug) = New Stack(Of Fahrzeug)()
        Dim fzDict As Dictionary(Of Fahrzeug, Fahrzeug) = New Dictionary(Of Fahrzeug, Fahrzeug)()

        '''Initialisierung einer Variablen zur Angabe der Durchläufe
        Dim anzahlFahrzeuge As Integer = 10

        '''Zufällige "Befüllung" der Listen mittels des Zufallszahlengenerators und SelectCase
        For index = 1 To anzahlFahrzeuge
            Select Case generator.Next(1, 4)
                Case 1
                    fzStack.Push(PKW.ErstelleZufälligenPKW($"_Stack{index}"))
                    fzQueue.Enqueue(PKW.ErstelleZufälligenPKW($"_Queue{index}"))
                Case 2
                    fzStack.Push(New Schiff($"Titanic_Stack{index}", 50, 3000000, Schiff.Schiffstreibstoff.Dampf))
                    fzQueue.Enqueue(New Schiff($"Titanic_Queue{index}", 50, 3000000, Schiff.Schiffstreibstoff.Dampf))
                Case 3
                    fzStack.Push(New Flugzeug($"Boeing_Stack{index}", 800, 2900000, 9900))
                    fzQueue.Enqueue(New Flugzeug($"Boeing_Queue{index}", 800, 2900000, 9900))
            End Select
        Next

        '''Versuch, die QueueFz's mit den StackFz's zu beladen
        For index = 1 To anzahlFahrzeuge
            'Prüfung auf das Interface (ob beladen werden kann)
            If TypeOf fzQueue.Peek() Is IBeladbar Then
                'wenn ja, dann Cast ins Interface 
                Dim beladbaresFz As IBeladbar = DirectCast(fzQueue.Peek(), IBeladbar)
                'und Aufruf der Belade()-Funktion (mittels Peek(), da die Fz's noch benötigt werden)
                beladbaresFz.Belade(fzStack.Peek())
                'Hinzufügen der Fz's zum Dictionary (mittels Dequeue()/Pop(), damit beim nächsten Durchlauf andere Fz's oben sind)
                fzDict.Add(fzQueue.Dequeue(), fzStack.Pop())
            Else
                'wenn nein, dann werden die Fz's vor dem nächsten Durchlauf rausgeschmissen
                fzQueue.Dequeue()
                fzStack.Pop()
            End If
        Next

        '''Programmpause
        Console.ReadKey()
        Console.WriteLine("-----LADELISTE----")

        '''Ausgabe des Dictionaries
        For Each item In fzDict
            Console.WriteLine($"{item.Key.Name} hat {item.Value.Name} geladen.")
        Next
#End Region

    End Sub

#Region "Modul 08 Methode"
    'Für Lab-08 sollte das entkommentiert werden, damit der Funktionsaufruf funktioniert
    'Sub Repariere(fz1 As Fahrzeug)

    '    'Prüfung, ob das Fahrzeug ein PKW ist
    '    If TypeOf fz1 Is PKW Then

    '        'Cast in PKW und Reperatur der Tür
    '        Dim pkw1 As PKW = DirectCast(fz1, PKW)
    '        pkw1.AnzahlTüren += 1

    '    End If

    '    'Prüfung, ob das Fahrzeug Räder hat
    '    If TypeOf fz1 Is IBerädert Then

    '        'Cast in IBerädert und Reperatur der Räder
    '        DirectCast(fz1, IBerädert).AnzahlRäder += 1

    '    End If

    '    Console.WriteLine($"{fz1.Name} wurde repariert.")

    'End Sub
#End Region

#Region "Lab 08 Methode"
    'Für Lab-08 sollte das entkommentiert werden, damit der Funktionsaufruf funktioniert

    'Public Sub BeladeFahrzeug(fz1 As Fahrzeug, fz2 As Fahrzeug)
    '    'Überprüfung, ob die fz's das Interface implementiert haben (dh. ob sie eine Ladung aufnehmen können)
    '    If TypeOf fz1 Is IBeladbar Then
    '        'Wenn ja, dann Cast in temporäre IBeladbar-Variable
    '        Dim beladbaresO As IBeladbar = DirectCast(fz1, IBeladbar)
    '        'und Aufruf der Belade()-Funktion mit Übergabe des anderen Fahrzeugs
    '        beladbaresO.Belade(fz2)
    '    ElseIf TypeOf fz2 Is IBeladbar Then
    '        'Alternative Schreibweise ohne temporäre Variable
    '        DirectCast(fz2, IBeladbar).Belade(fz1)
    '    Else
    '        Console.WriteLine("Kein Fahrzeug hat einen Laderaum, der beladen werden konnte.")
    '    End If
    'End Sub
#End Region

End Module


