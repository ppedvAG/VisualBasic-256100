Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Linq
Imports System.Runtime.CompilerServices

Module Program

    Sub Main()
        Demo_Operatoren()
        Demo_Enumerator()
        Demo_Erweiterungsmethoden()
        Demo_Lambda()
        Demo_Linq()
        Demo_WichtigeLinqBefehle()
        Demo_Kopierkonstruktor()
        Demo_CloneFunktion()

    End Sub

    ' ============================================================
    ' Operatoren überladen
    ' ============================================================
    Private Sub Demo_Operatoren()

        Console.WriteLine("=== Operatoren überladen ===")

        ' Es werden zwei einzelne Wagon-Objekte erzeugt.
        ' Jeder Wagon hat eine Bezeichnung und eine Anzahl an Sitzplätzen.
        Dim wagon1 As New Wagon("Wagen A", 40)
        Dim wagon2 As New Wagon("Wagen B", 55)

        ' Hier wird der + Operator verwendet.
        ' Normalerweise kennt man + nur für Zahlen oder Strings.
        ' In unserer Klasse Wagon wurde der Operator aber selbst definiert.
        ' Dadurch kann man zwei Wagons mit + "zusammenfügen".
        '
        ' Das Ergebnis ist ein neues Zug-Objekt,
        ' das beide Wagons enthält.
        Dim zug1 As Zug = wagon1 + wagon2

        ' Nun wird ein dritter Wagon erzeugt.
        Dim wagon3 As New Wagon("Wagen C", 60)

        ' Auch in der Klasse Zug wurde der + Operator definiert.
        ' Dadurch kann man an einen bestehenden Zug einen weiteren Wagon anhängen.
        Dim kompletterZug As Zug = zug1 + wagon3

        ' Jetzt wird zusätzlich der = Operator demonstriert.
        ' In der Klasse Wagon wurde festgelegt:
        ' Zwei Wagons gelten hier als gleich,
        ' wenn sie gleich viele Sitzplätze haben.
        Dim wagon4 As New Wagon("Wagen D", 40)

        Console.WriteLine("Vergleich wagon1 = wagon4: " & (wagon1 = wagon4).ToString())
        Console.WriteLine("Anzahl Wagons im Zug: " & kompletterZug.Wagons.Count)
        Console.WriteLine("Gesamt-Sitzplätze im Zug: " & kompletterZug.GesamtSitzplaetze())
        Console.WriteLine()

    End Sub

    ' ============================================================
    ' Enumerator für eine Klasse definieren
    ' ============================================================
    Private Sub Demo_Enumerator()

        Console.WriteLine("=== Enumerator für eine Klasse definieren ===")

        ' Es wird ein neuer Zug erzeugt.
        Dim ice As New Zug("ICE")

        ' Dem Zug werden drei Wagons hinzugefügt.
        ice.AddWagon(New Wagon("Wagen 1", 50))
        ice.AddWagon(New Wagon("Wagen 2", 60))
        ice.AddWagon(New Wagon("Wagen 3", 70))

        ' Die Klasse Zug implementiert IEnumerable(Of Wagon).
        ' Das bedeutet:
        ' Ein Zug kann wie eine Sammlung behandelt werden.
        '
        ' Deshalb kann man mit For Each direkt über die enthaltenen Wagons laufen,
        ' obwohl Zug selbst keine klassische Liste ist.
        '
        ' Ohne GetEnumerator() wäre diese Schleife nicht möglich.
        For Each wagon As Wagon In ice
            Console.WriteLine(wagon.Bezeichnung & " mit " & wagon.Sitzplaetze & " Sitzplätzen")
        Next

        Console.WriteLine()

    End Sub

    ' ============================================================
    ' Erweiterungsmethoden
    ' ============================================================
    Private Sub Demo_Erweiterungsmethoden()

        Console.WriteLine("=== Erweiterungsmethoden ===")

        Dim zahl As Integer = 10232

        ' Die Methode GetQuersumme gehört eigentlich nicht zur Integer-Klasse.
        ' Sie wurde in einem separaten Modul als Erweiterungsmethode definiert.
        '
        ' Durch das <Extension()>-Attribut kann man die Methode aber so aufrufen,
        ' als wäre sie eine normale Methode des Integer-Datentyps.
        '
        ' Das wirkt für den Aufruf sehr komfortabel:
        ' zahl.GetQuersumme()
        Dim quersumme As Integer = zahl.GetQuersumme()

        Console.WriteLine("Zahl: " & zahl)
        Console.WriteLine("Quersumme: " & quersumme)
        Console.WriteLine()

    End Sub

    ' ============================================================
    ' Lambda-Ausdrücke
    ' ============================================================
    Private Sub Demo_Lambda()

        Console.WriteLine("=== Lambda-Ausdrücke ===")

        ' Ein Lambda-Ausdruck ist eine kurze, anonyme Funktion.
        ' "Anonym" bedeutet:
        ' Die Funktion bekommt keinen eigenen Methodennamen.
        '
        ' Hier wird eine Funktion definiert, die zwei Integer-Werte addiert.
        ' Func(Of Integer, Integer, Integer) bedeutet:
        ' - erster Parameter: Integer
        ' - zweiter Parameter: Integer
        ' - Rückgabewert: Integer
        Dim addiere As Func(Of Integer, Integer, Integer) = Function(x, y) x + y

        ' Die anonyme Funktion wird wie eine normale Methode aufgerufen.
        Dim ergebnis As Integer = addiere(7, 5)

        Console.WriteLine("7 + 5 = " & ergebnis)

        ' Lambdas werden in der Praxis besonders häufig bei LINQ,
        ' Sortierungen, Filtern und kleinen Hilfsfunktionen verwendet.
        Console.WriteLine()

    End Sub

    ' ============================================================
    ' LINQ
    ' ============================================================
    Private Sub Demo_Linq()

        Console.WriteLine("=== LINQ ===")

        ' LINQ steht für "Language Integrated Query".
        ' Damit kann man Daten direkt in VB.NET abfragen,
        ' ähnlich wie man es von Datenbankabfragen kennt.
        '
        ' Hier verwenden wir als Datenquelle einfach ein String-Array.
        Dim staedte As String() = {"Leipzig", "Hamburg", "Hannover", "Berlin"}

        ' Query-Syntax:
        ' Es werden alle Städte ausgewählt,
        ' deren Name mit dem Buchstaben H beginnt.
        Dim mitH = From stadt In staedte
                   Where stadt.StartsWith("H")
                   Select stadt

        Console.WriteLine("Städte mit H:")

        ' Das Ergebnis der Abfrage wird mit For Each ausgegeben.
        For Each stadt In mitH
            Console.WriteLine("- " & stadt)
        Next

        Console.WriteLine()

    End Sub

    ' ============================================================
    ' Wichtige LINQ-Befehle
    ' ============================================================
    Private Sub Demo_WichtigeLinqBefehle()

        Console.WriteLine("=== Wichtige LINQ-Befehle ===")

        ' Eine einfache Zahlenliste als Datenbasis.
        Dim zahlen As Integer() = {7, 2, 10, 3, 8, 1}

        ' --------------------------------------------------------
        ' WHERE
        ' --------------------------------------------------------
        ' Where filtert Elemente nach einer Bedingung.
        ' Hier werden nur Zahlen größer als 5 ausgewählt.
        Dim nurGroesser5 = zahlen.Where(Function(z) z > 5)
        Console.WriteLine("Where (z > 5): " & String.Join(", ", nurGroesser5))

        ' --------------------------------------------------------
        ' SELECT
        ' --------------------------------------------------------
        ' Select projiziert oder verändert Daten.
        ' Hier wird jede Zahl verdoppelt.
        Dim verdoppelt = zahlen.Select(Function(z) z * 2)
        Console.WriteLine("Select (z * 2): " & String.Join(", ", verdoppelt))

        ' --------------------------------------------------------
        ' ORDER BY DESCENDING
        ' --------------------------------------------------------
        ' Sortiert die Zahlen absteigend.
        Dim sortiertAbsteigend = zahlen.OrderByDescending(Function(z) z)
        Console.WriteLine("OrderByDescending: " & String.Join(", ", sortiertAbsteigend))

        ' --------------------------------------------------------
        ' FIRST OR DEFAULT
        ' --------------------------------------------------------
        ' Gibt das erste Element zurück, das die Bedingung erfüllt.
        ' Falls kein passendes Element gefunden wird,
        ' wird der Standardwert des Datentyps zurückgegeben.
        ' Bei Integer ist dieser Standardwert 0.
        Dim ersteZahlGroesser5 = zahlen.FirstOrDefault(Function(z) z > 5)
        Console.WriteLine("FirstOrDefault (z > 5): " & ersteZahlGroesser5)

        ' --------------------------------------------------------
        ' COUNT
        ' --------------------------------------------------------
        ' Zählt, wie viele Elemente eine Bedingung erfüllen.
        ' Hier: Wie viele Zahlen sind gerade?
        Dim anzahlGerade = zahlen.Count(Function(z) z Mod 2 = 0)
        Console.WriteLine("Count (gerade Zahlen): " & anzahlGerade)

        Console.WriteLine()

    End Sub

    ' ============================================================
    ' Kopierkonstruktor
    ' ============================================================
    Private Sub Demo_Kopierkonstruktor()

        Console.WriteLine("=== Kopierkonstruktor ===")

        ' Es wird ein ursprüngliches Person-Objekt erzeugt.
        Dim person1 As New Person("Alex")
        person1.Alter = 25

        ' Hier wird der Kopierkonstruktor verwendet.
        ' Das bedeutet:
        ' Ein neues Objekt wird erzeugt,
        ' dessen Werte aus einem vorhandenen Objekt übernommen werden.
        Dim person2 As New Person(person1)

        ' Jetzt wird nur die Kopie verändert.
        person2.Name = "Chris"

        ' Daran sieht man:
        ' person1 und person2 sind zwei getrennte Objekte.
        ' Änderungen an der Kopie ändern das Original nicht automatisch.
        Console.WriteLine("Original: " & person1.Name & ", Alter: " & person1.Alter)
        Console.WriteLine("Kopie:    " & person2.Name & ", Alter: " & person2.Alter)
        Console.WriteLine("=> Das Original bleibt unverändert.")
        Console.WriteLine()

    End Sub

    ' ============================================================
    ' Clone-Funktion
    ' ============================================================
    Private Sub Demo_CloneFunktion()

        Console.WriteLine("=== Clone-Funktion ===")

        ' Zuerst wird eine Person als Fahrer angelegt.
        Dim fahrer1 As New Person("Maria")
        fahrer1.Alter = 30

        ' Danach wird ein Auto mit diesem Fahrer erzeugt.
        Dim auto1 As New Auto(4, fahrer1)

        ' Nun wird das Auto geklont.
        ' Die Clone-Methode liefert Object zurück,
        ' deshalb wird mit DirectCast wieder in Auto umgewandelt.
        Dim auto2 As Auto = DirectCast(auto1.Clone(), Auto)

        ' Es wird nur der Fahrer der Kopie verändert.
        auto2.Fahrer.Name = "Laura"

        ' Wenn das Klonen korrekt als Deep Copy umgesetzt wurde,
        ' bleibt der Fahrer im Original-Auto unverändert.
        Console.WriteLine("Original-Auto Fahrer: " & auto1.Fahrer.Name)
        Console.WriteLine("Geklontes Auto Fahrer: " & auto2.Fahrer.Name)
        Console.WriteLine("=> Durch Deep Copy bleibt das Original unabhängig.")
        Console.WriteLine()

    End Sub

End Module

' ============================================================
' Klasse Wagon
' Wird für die Beispiele zu Operatoren und Zug verwendet.
' ============================================================
Public Class Wagon

    ' Bezeichnung des Wagons, z. B. "Wagen 1"
    Public Property Bezeichnung As String

    ' Anzahl der Sitzplätze im Wagon
    Public Property Sitzplaetze As Integer

    ' Konstruktor:
    ' Beim Erzeugen eines Wagons werden Bezeichnung und Sitzplätze gesetzt.
    Public Sub New(bezeichnung As String, sitzplaetze As Integer)
        Me.Bezeichnung = bezeichnung
        Me.Sitzplaetze = sitzplaetze
    End Sub

    ' ------------------------------------------------------------
    ' Überladung des + Operators für zwei Wagons
    ' ------------------------------------------------------------
    ' Bedeutung in diesem Beispiel:
    ' Zwei einzelne Wagons werden zu einem neuen Zug kombiniert.
    Public Shared Operator +(wagon1 As Wagon, wagon2 As Wagon) As Zug

        ' Es wird ein neuer Zug erzeugt.
        Dim zug As New Zug("Neuer Zug")

        ' Beide Wagons werden dem Zug hinzugefügt.
        zug.AddWagon(wagon1)
        zug.AddWagon(wagon2)

        ' Der fertige Zug wird zurückgegeben.
        Return zug

    End Operator

    ' ------------------------------------------------------------
    ' Überladung des = Operators
    ' ------------------------------------------------------------
    ' In diesem Beispiel gilt:
    ' Zwei Wagons sind "gleich",
    ' wenn sie gleich viele Sitzplätze besitzen.
    Public Shared Operator =(wagon1 As Wagon, wagon2 As Wagon) As Boolean

        ' Sonderfall:
        ' Wenn beide Objekte Nothing sind, gelten sie als gleich.
        If wagon1 Is Nothing AndAlso wagon2 Is Nothing Then Return True

        ' Wenn nur eines der beiden Objekte Nothing ist,
        ' dann sind sie nicht gleich.
        If wagon1 Is Nothing OrElse wagon2 Is Nothing Then Return False

        ' Vergleich der Sitzplatzanzahl.
        Return wagon1.Sitzplaetze = wagon2.Sitzplaetze

    End Operator

    ' Wenn = überladen wird, sollte auch <> überladen werden.
    Public Shared Operator <>(wagon1 As Wagon, wagon2 As Wagon) As Boolean
        Return Not (wagon1 = wagon2)
    End Operator

End Class

' ============================================================
' Klasse Zug
' Zeigt:
' - eigene Sammlung von Wagons
' - Operatorüberladung
' - Implementierung eines Enumerators
' ============================================================
Public Class Zug
    Implements IEnumerable(Of Wagon)

    ' Name des Zuges
    Public Property Name As String

    ' Interne Liste aller Wagons
    Public Property Wagons As List(Of Wagon)

    ' Konstruktor:
    ' Beim Erzeugen eines Zuges wird die Wagon-Liste initialisiert.
    Public Sub New(name As String)
        Me.Name = name
        Me.Wagons = New List(Of Wagon)()
    End Sub

    ' Fügt einen Wagon zur internen Liste hinzu.
    Public Sub AddWagon(wagon As Wagon)
        Wagons.Add(wagon)
    End Sub

    ' ------------------------------------------------------------
    ' Überladung des + Operators für Zug + Wagon
    ' ------------------------------------------------------------
    ' Bedeutung:
    ' Ein weiterer Wagon wird an einen bestehenden Zug angehängt.
    Public Shared Operator +(zug As Zug, wagon As Wagon) As Zug

        zug.AddWagon(wagon)
        Return zug

    End Operator

    ' Berechnet die Gesamtzahl aller Sitzplätze im Zug.
    Public Function GesamtSitzplaetze() As Integer

        ' Sum verwendet LINQ.
        ' Für jeden Wagon wird die Sitzplatzzahl gelesen und addiert.
        Return Wagons.Sum(Function(w) w.Sitzplaetze)

    End Function

    ' ------------------------------------------------------------
    ' Generischer Enumerator
    ' ------------------------------------------------------------
    ' Diese Methode macht es möglich,
    ' mit For Each über ein Zug-Objekt zu iterieren.
    Public Function GetEnumerator() As IEnumerator(Of Wagon) Implements IEnumerable(Of Wagon).GetEnumerator
        Return Wagons.GetEnumerator()
    End Function

    ' ------------------------------------------------------------
    ' Nicht-generischer Enumerator
    ' ------------------------------------------------------------
    ' Diese zusätzliche Implementierung ist erforderlich,
    ' weil IEnumerable(Of T) auch auf IEnumerable basiert.
    Private Function GetEnumeratorNichtGenerisch() As IEnumerator Implements IEnumerable.GetEnumerator
        Return Wagons.GetEnumerator()
    End Function

End Class

' ============================================================
' Modul mit Erweiterungsmethoden
' ============================================================
Module Erweiterungen

    ' Das <Extension()>-Attribut kennzeichnet die Methode
    ' als Erweiterungsmethode.
    '
    ' Dadurch kann diese Funktion auf Integer-Werten aufgerufen werden,
    ' als wäre sie Teil der Integer-Klasse.
    <Extension()>
    Public Function GetQuersumme(zahl As Integer) As Integer

        ' Hier wird die Summe aller Ziffern gespeichert.
        Dim summe As Integer = 0

        ' Die Zahl wird in einen String umgewandelt,
        ' damit man Zeichen für Zeichen darüber laufen kann.
        Dim zahlAlsString As String = zahl.ToString()

        ' Schleife über jede einzelne Ziffer.
        For index As Integer = 0 To zahlAlsString.Length - 1

            ' Char.GetNumericValue liefert den numerischen Wert eines Zeichens.
            ' Beispiel: aus dem Zeichen "3" wird die Zahl 3.
            summe += CInt(Char.GetNumericValue(zahlAlsString(index)))

        Next

        Return summe

    End Function

End Module

' ============================================================
' Klasse Person
' Zeigt:
' - normalen Konstruktor
' - Kopierkonstruktor
' - Clone-Funktion
' ============================================================
Public Class Person
    Implements ICloneable

    ' Name der Person
    Public Property Name As String

    ' Alter der Person
    Public Property Alter As Integer

    ' Normaler Konstruktor:
    ' Erzeugt eine neue Person anhand eines Namens.
    Public Sub New(name As String)
        Me.Name = name
    End Sub

    ' ------------------------------------------------------------
    ' Kopierkonstruktor
    ' ------------------------------------------------------------
    ' Erzeugt eine neue Person auf Basis eines vorhandenen Objekts.
    '
    ' Wichtig:
    ' Es wird ein neues Objekt erstellt.
    ' Es ist also nicht nur eine zweite Variable,
    ' die auf dasselbe Objekt zeigt.
    Public Sub New(anderePerson As Person)

        Me.Name = anderePerson.Name
        Me.Alter = anderePerson.Alter

    End Sub

    ' ------------------------------------------------------------
    ' Clone-Funktion
    ' ------------------------------------------------------------
    ' Erstellt ebenfalls eine Kopie des Objekts.
    ' Hier wird intern einfach der Kopierkonstruktor genutzt.
    Public Function Clone() As Object Implements ICloneable.Clone

        Return New Person(Me)

    End Function

End Class

' ============================================================
' Klasse Auto
' Zeigt Deep Copy mit Clone
' ============================================================
Public Class Auto
    Implements ICloneable

    ' Anzahl der Reifen
    Public Property Reifenanzahl As Integer

    ' Fahrer des Autos
    Public Property Fahrer As Person

    ' Konstruktor:
    ' Legt Reifenanzahl und Fahrer fest.
    Public Sub New(reifenanzahl As Integer, fahrer As Person)
        Me.Reifenanzahl = reifenanzahl
        Me.Fahrer = fahrer
    End Sub

    ' ------------------------------------------------------------
    ' Clone-Funktion des Autos
    ' ------------------------------------------------------------
    ' Ziel:
    ' Nicht nur das Auto soll kopiert werden,
    ' sondern auch das enthaltene Fahrer-Objekt.
    '
    ' Das ist wichtig, damit Original und Kopie später
    ' unabhängig voneinander verändert werden können.
    Public Function Clone() As Object Implements ICloneable.Clone

        ' MemberwiseClone erstellt zunächst eine flache Kopie.
        ' Das bedeutet:
        ' Ein neues Auto-Objekt entsteht,
        ' aber Referenztypen wie Fahrer würden zunächst noch
        ' auf dasselbe innere Objekt zeigen.
        Dim neuesAuto As Auto = DirectCast(Me.MemberwiseClone(), Auto)

        ' Deshalb wird der Fahrer zusätzlich separat geklont.
        ' So erhält die Kopie ein eigenes Person-Objekt.
        neuesAuto.Fahrer = DirectCast(Me.Fahrer.Clone(), Person)

        ' Jetzt handelt es sich um eine Deep Copy
        ' bezüglich des Fahrer-Objekts.
        Return neuesAuto

    End Function

End Class