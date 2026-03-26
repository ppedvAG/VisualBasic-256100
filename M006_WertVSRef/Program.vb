Imports System

Module Program

    'WERTEtyp-Objekte werden bei Zuweisung zu einer anderen Variablen oder bei Übergabe an eine Methode kopiert.
    ''Eine Veränderung der Kopie hat keine Auswirkungen auf das Original-Objekt.
    ''STRUCTUREs sind Klassen-ähnliche Konstrukte welche nicht, wie Klassen, als Referenztypen behandelt werden, sondern ein Wertetyp sind.

    ' Class und Struct unterscheiden sich vor allem in ihrem Verhalten bei Zuweisung und Methodenaufrufen:
    ' Eine Class ist ein Referenztyp. Mehrere Variablen können auf dasselbe Objekt zeigen, daher sind Änderungen
    ' über eine Variable auch über die andere sichtbar.
    ' Eine Struct ist ein Wertetyp. Bei Zuweisung oder Übergabe wird eine Kopie erstellt, daher betreffen Änderungen
    ' normalerweise nur die Kopie und nicht das Original.
    Public Structure Struct_Person

        Private _name As String
        Public Property Name() As String
            Get
                Return _name
            End Get
            Set(ByVal value As String)
                _name = value
            End Set
        End Property

        Private _alter As Integer
        Public Property Alter() As Integer
            Get
                Return _alter
            End Get
            Set(ByVal value As Integer)
                _alter = value
            End Set
        End Property

        Public Sub New(name As String, alter As Integer)
            _alter = alter
            _name = name
        End Sub

    End Structure

    'Bei REFERENZtyp-Objekten, wie z.B. Klassenobjekten, wird bei einer Übergabe an eine Methode oder einer Zuweisung
    ''zu einer neuen Variablen die entsprechende Speicherstelle übergeben. D.h. eine Manipulation des Objekts macht sich
    ''bei beiden Variablen bemerkbar, da beide auf dasselbe Objekt zeigen
    Public Class Class_Person

        Private _name As String
        Public Property Name() As String
            Get
                Return _name
            End Get
            Set(ByVal value As String)
                _name = value
            End Set
        End Property

        Private _alter As Integer
        Public Property Alter() As Integer
            Get
                Return _alter
            End Get
            Set(ByVal value As Integer)
                _alter = value
            End Set
        End Property

        Public Sub New(name As String, alter As Integer)
            _alter = alter
            _name = name
        End Sub

    End Class

    Sub Main()

        'Referenztyp: beide Variablen zeigen auf dasselbe Objekt
        Dim ClassPerson01 As Class_Person = New Class_Person("Anna", 34)
        Dim ClassPerson02 As Class_Person = ClassPerson01

        Console.WriteLine($"ClassPerson01: {ClassPerson01.Name}") 'Ausgabe: Anna
        Console.WriteLine($"ClassPerson02: {ClassPerson02.Name}") 'Ausgabe: Anna, da beide auf dasselbe Objekt zeigen

        ClassPerson02.Name = "Maria"
        Console.WriteLine($"ClassPerson01: {ClassPerson01.Name}") 'Jetzt ebenfalls Maria, weil dieselbe Klasseninstanz verändert wurde
        Console.WriteLine($"ClassPerson02: {ClassPerson02.Name}") 'Maria, da der Name direkt über ClassPerson02 geändert wurde


        'Wertetyp: bei der Zuweisung wird eine Kopie erstellt
        Dim StructPerson01 As Struct_Person = New Struct_Person("Hugo", 34)
        Dim StructPerson02 As Struct_Person = StructPerson01

        Console.WriteLine($"StructPerson01: {StructPerson01.Name}") 'Ausgabe: Hugo
        Console.WriteLine($"StructPerson02: {StructPerson02.Name}") 'Ausgabe: Hugo, da die Kopie anfangs dieselben Werte hat

        StructPerson02.Name = "Maria"
        Console.WriteLine($"StructPerson01: {StructPerson01.Name}") 'Bleibt Hugo, da nur die Kopie geändert wurde
        Console.WriteLine($"StructPerson02: {StructPerson02.Name}") 'Maria, weil nur StructPerson02 geändert wurde


        'Startzustand vor den Methodenaufrufen
        Console.WriteLine($"{StructPerson01.Name}: {StructPerson01.Alter}") 'Hugo: 34
        Console.WriteLine($"{ClassPerson01.Name}: {ClassPerson01.Alter}") 'Maria: 34

        'Übergabe an jeweilige Altern()-Methode
        Altern(StructPerson01)
        Altern(ClassPerson01)

        'Ergebnis nach Altern():
        'Beim Struct bleibt das Original unverändert, bei der Class wird das Objekt verändert
        Console.WriteLine($"{StructPerson01.Name}: {StructPerson01.Alter}") 'Hugo: 34, da bei Wertetypen nur eine Kopie übergeben wurde
        Console.WriteLine($"{ClassPerson01.Name}: {ClassPerson01.Alter}") 'Maria: 35, da das Klassenobjekt direkt verändert wurde

        'Aufruf der ByRef-Methode
        WirklichAltern(StructPerson01)
        Console.WriteLine($"{StructPerson01.Name}: {StructPerson01.Alter}") 'Hugo: 35, da ByRef die Originalvariable direkt verändert


        'Bsp für .NET-interne Verwendung des ByRef-Stichworts (hier in Integer.TryParse())
        ''Dies gibt hier die Möglichkeit zwei Rückgabewerte zu erlangen (1. Boolean über return, 2. Integer [eingabeAlsInteger] über ByRef)
        Dim eingabe As String = Console.ReadLine()
        Dim eingabeAlsInterger As Integer

        If Integer.TryParse(eingabe, eingabeAlsInterger) Then

            Console.WriteLine(eingabeAlsInterger * 2) 'Gibt die eingegebene Zahl verdoppelt aus

        End If

        Console.ReadKey()

    End Sub

    Sub Altern(person As Class_Person)
        person.Alter += 1
    End Sub

    Sub Altern(ByVal person As Struct_Person)
        person.Alter += 1
    End Sub

    'Mittels des BYREF-Stichworts können Wertetypen als Referenz an Methoden übergeben werden. D.h. die übergebene Speicherstelle selbst 
    ''wird manipuliert und nicht, wie normalerweise bei Wertetypen, eine Kopie des Werts.
    Sub WirklichAltern(ByRef person As Struct_Person)
        person.Alter += 1
    End Sub

End Module