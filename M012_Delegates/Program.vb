Imports System

Module Program

    'Delegates sind Datentypen, deren Variablen Refernzen auf Methoden aufnehmen können. Bei Aufruf der
    ''Variablen werden dann die Methoden ausgeführt. Jeder Delegatetyp kann die Methoden aufnehmen, welche
    ''seiner Signatur entsprechen

    'Defnition eines Delegate-Datentypen
    Public Delegate Function MyDelegate(zahl1 As Integer, zahl2 As Integer) As Integer

    Sub Main(args As String())

        'Deklaration einer Delegatevariablen
        'Mittels des ADDRESSOF-Stichworts können Methoden den Delegate-Variablen zugeordnet werden 
        Dim delegateVariable As MyDelegate = AddressOf Addiere
        'Ausführung der Methode in der Variablen
        Console.WriteLine($"delegateVariable: {delegateVariable(78, 45)}")

        'Neuzuweisung der Variablen
        delegateVariable = AddressOf Subtrahiere
        Console.WriteLine($"delegateVariable: {delegateVariable(78, 45)}")

        'Übergabe einer Methode an eine andere Methode (mittels Delegate-Übergabeparameter)
        RechneUndGibAus(delegateVariable)
        RechneUndGibAus(AddressOf Addiere)

        'Deklaration eines Funcs (generischer Delegate) und Initialisierung mit einer Methode
        'Hier stehen keine Werte oder Methodenparameter in Klammern, sondern Typangaben für den generischen Delegate Func.
        'In VB verwendet man dafür "Of ...".
        'Of ist das Schlüsselwort für: "Jetzt kommen die Typangaben"
        'Func(Of Integer, Integer, Integer) bedeutet:
        '1. Parameter = Integer
        '2. Parameter = Integer
        'Rückgabewert = Integer
        'Normale Klammern (...) würden wie ein Methodenaufruf oder eine Parameterliste wirken, nicht wie eine Typliste.
        Dim myFunc As Func(Of Integer, Integer, Integer) = AddressOf Addiere
        'Ausführung des Funcs
        Console.WriteLine($"myFunc: {myFunc(56, 12)}")

        Dim städteListe As List(Of String) = New List(Of String)
        städteListe.Add("München")
        städteListe.Add("Hamburg")
        städteListe.Add("Berlin")
        städteListe.Add("Köln")
        städteListe.Add("Stuttgart")

        'Verschiedene Ausführungen der Befüllung der Find()-Funktion einer Liste:
        ''Übergabe einer Methode (für Methode s.u.)
        Dim ergebnis1 As String = städteListe.Find(AddressOf SucheStadtMitH)

        Console.WriteLine($"ergebnis1: {ergebnis1}")

        ''Übergabe einer anonymen Methode in einem Delegate <- Methode, welche keinen Bezeichner hat und nur ein einem Delegate existiert
        Dim suchPredicate As Predicate(Of String) =
            Function(stadt As String) As Boolean
                Return stadt.StartsWith("H")
            End Function

        Dim ergebnis2 As String = städteListe.Find(suchPredicate)

        Console.WriteLine($"ergebnis2: {ergebnis2}")

        ''Übergabe einer anonymen Methode direkt in den Übergabeparamteren
        Dim ergebnis3 = städteListe.Find(Function(stadt As String) As Boolean
                                             Return stadt.StartsWith("H")
                                         End Function)

        Console.WriteLine($"ergebnis3: {ergebnis3}")

        ''Übergabe der anonymen Methode in KurzSchreibweise
        Dim ergebnis4 As String = städteListe.Find(Function(stadt) stadt.StartsWith("H"))

        Console.WriteLine($"ergebnis4: {ergebnis4}")

        'Sortieren der Liste nach Wortlänge per Kurzschreibweise
        städteListe = städteListe.OrderByDescending(Function(stadt) stadt.Length).ToList()

        'Ausgabe der Liste
        For Each stadt In städteListe
            Console.WriteLine($"Städte nach Wortlänge: {stadt}")
        Next
    End Sub

    'Beispielmethoden:
    ''Methode, welche die Suchlogik für die Find()-Funktion beinhaltet
    Public Function SucheStadtMitH(stadt As String) As Boolean
        Return stadt.StartsWith("H")
    End Function

    ''Methode, welche einen Delegate als Übegabeparameter verlangt
    Public Sub RechneUndGibAus(methode As MyDelegate)
        Console.WriteLine(methode(123, 456))
    End Sub

    ''Bsp-Methoden zur Befüllung der Delegates
    Public Function Addiere(a As Integer, b As Integer) As Integer
        Console.WriteLine("Addiere")
        Return a + b
    End Function

    Public Function Subtrahiere(a As Integer, b As Integer) As Integer
        Console.WriteLine("Subtrahiere")
        Return a - b
    End Function

End Module
