' Importiert Klassen zum Lesen und Schreiben von Dateien
Imports System.IO
' Importiert die Newtonsoft-Bibliothek zur JSON-Serialisierung
Imports Newtonsoft.Json

' Hauptformular der Anwendung
Public Class Form1

    ' Diese Zeile ist ein allgemeiner Hinweis:
    ' Die folgenden Methoden reagieren auf Klicks der Buttons im Formular.
    ' "Handles Btn_X.Click" bedeutet, dass die jeweilige Methode automatisch
    ' aufgerufen wird, wenn der Benutzer auf den entsprechenden Button klickt.

    ' Wird ausgeführt, wenn auf den Button "Neu" geklickt wird
    Private Sub Btn_New_Click(sender As Object, e As EventArgs) Handles Btn_New.Click
        ' Erstellt mit der Methode CreateNewPerson() eine zufällige Person
        ' und fügt diese anschließend der ListBox hinzu.
        ' Die ListBox heißt hier Lbx_People.
        Lbx_People.Items.Add(CreateNewPerson())
    End Sub

    ' Wird ausgeführt, wenn auf den Button "Löschen" geklickt wird
    Private Sub Btn_Delete_Click(sender As Object, e As EventArgs) Handles Btn_Delete.Click
        ' Übergibt das aktuell in der ListBox markierte Objekt
        ' an die Methode DeletePerson().
        ' SelectedItem liefert das ausgewählte Element zurück.
        DeletePerson(Lbx_People.SelectedItem)
    End Sub

    ' Wird ausgeführt, wenn auf den Button "Speichern" geklickt wird
    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
        ' Übergibt alle Elemente der ListBox an die Methode SavePeople(),
        ' damit diese in einer Datei gespeichert werden.

        SavePeople(Lbx_People.Items)
    End Sub

    ' Wird ausgeführt, wenn auf den Button "Laden" geklickt wird
    Private Sub Btn_Load_Click(sender As Object, e As EventArgs) Handles Btn_Load.Click
        ' Zuerst wird die aktuelle Anzeige in der ListBox vollständig geleert,
        ' damit keine alten Einträge bestehen bleiben.
        Lbx_People.Items.Clear()

        ' Die Methode LoadPeople() lädt eine Liste von Personen aus der Datei.
        ' Anschließend wird jede geladene Person einzeln wieder in die ListBox eingefügt.
        For Each person In LoadPeople()
            Lbx_People.Items.Add(person)
        Next
    End Sub

    ' Ein Zufallsgenerator wird als Klassenvariable angelegt.
    ' Dadurch muss nicht bei jedem Methodenaufruf ein neuer Random-Generator erzeugt werden.
    Private generator As Random = New Random()

    ' Diese Funktion erstellt zufällig ein neues Person-Objekt
    ' und gibt es anschließend zurück.
    Private Function CreateNewPerson() As Person

        ' Variable für den Namen der neuen Person
        Dim name As String = String.Empty

        ' Mit generator.Next(1, 5) wird eine Zufallszahl zwischen 1 und 4 erzeugt.
        ' Die obere Grenze 5 ist exklusiv und wird daher nicht erreicht.
        ' Abhängig von der Zufallszahl wird ein Name ausgewählt.
        Select Case generator.Next(1, 5)
            Case 1
                name = "Anna Nass"
            Case 2
                name = "Rainer Zufall"
            Case 3
                name = "Maria Johanna"
            Case 4
                name = "Hugo Meier"
        End Select

        ' Erzeugt ein zufälliges Geburtsdatum.
        ' Das Jahr liegt zwischen 1930 und 2020,
        ' der Monat zwischen 1 und 12,
        ' der Tag zwischen 1 und 28.
        ' Der Tag wird bewusst nur bis 28 gewählt,
        ' damit es in keinem Monat zu ungültigen Datumswerten kommt.
        Dim geburtsdatum As DateTime = New DateTime(
            generator.Next(1930, 2021),
            generator.Next(1, 13),
            generator.Next(1, 29)
        )

        ' Erstellt ein neues Person-Objekt mit:
        ' - dem zufälligen Namen,
        ' - einer zufälligen Größe zwischen 120 cm und 209 cm,
        ' - dem zufälligen Geburtsdatum.
        ' Dieses Objekt wird dann als Rückgabewert der Funktion zurückgegeben.
        Return New Person(name, generator.Next(120, 210), geburtsdatum)
    End Function

    ' Diese Methode löscht eine übergebene Person aus der ListBox
    Private Sub DeletePerson(person As Person)
        ' Entfernt das Objekt "person" aus der Elementliste der ListBox.
        ' Falls nichts markiert ist, ist person ggf. Nothing.
        Lbx_People.Items.Remove(person)
    End Sub

    ' Diese Methode speichert alle Personen aus einer Liste in eine Textdatei.
    ' Als Parameter wird eine allgemeine IList übergeben,
    ' damit die Methode mit einer Sammlung von Listenelementen arbeiten kann.
    Private Sub SavePeople(liste As IList)

        ' Variable für den StreamWriter.
        ' Mit einem StreamWriter kann Text zeilenweise in eine Datei geschrieben werden.
        Dim writer As StreamWriter

        ' Try-Catch-Finally dient der Fehlerbehandlung:
        ' - Try: Code, der ausgeführt werden soll
        ' - Catch: Code, falls ein Fehler auftritt
        ' - Finally: Code, der in jedem Fall ausgeführt wird
        Try

            ' Öffnet bzw. erstellt die Datei "personen.txt" zum Schreiben.
            ' Existiert die Datei bereits, wird ihr Inhalt überschrieben.
            writer = New StreamWriter("personen.txt")

            ' Es wird ein neues Einstellungsobjekt für die JSON-Verarbeitung angelegt.
            ' In diesem Objekt kann festgelegt werden, wie Newtonsoft.Json
            ' Daten beim Speichern (Serialisieren) und beim Laden (Deserialisieren)
            ' behandeln soll.
            ' Ohne solche Einstellungen würde die Bibliothek mit den Standardregeln arbeiten.
            ' Hier werden die Einstellungen später sowohl beim Speichern
            ' als auch beim Laden verwendet, damit beide Vorgänge identisch arbeiten.
            Dim settings As JsonSerializerSettings = New JsonSerializerSettings()

            ' Mit TypeNameHandling wird festgelegt, ob zusätzliche Typinformationen
            ' mit in den JSON-Text geschrieben werden sollen.
            ' Der Wert "Objects" bedeutet:
            ' Für Objekte werden Informationen über den konkreten Datentyp ergänzt.
            ' Dadurch wird im JSON nicht nur der Inhalt gespeichert
            ' (z. B. Name, Größe, Geburtsdatum),
            ' sondern auch, von welchem Objekttyp diese Daten stammen.

            ' Das ist besonders dann nützlich, wenn beim späteren Laden genau erkannt werden soll,
            ' in welches Objekt der JSON-Text zurückverwandelt werden muss.
            ' Beim Deserialisieren kann Newtonsoft.Json dadurch sicherer erkennen,
            ' dass aus dem gespeicherten JSON wieder ein Person-Objekt erzeugt werden soll.
            settings.TypeNameHandling = TypeNameHandling.Objects

            ' Durchläuft alle Elemente der übergebenen Liste.
            ' Jedes Element soll in einen JSON-String umgewandelt und gespeichert werden.
            For Each person In liste

                ' Wandelt das aktuelle Objekt in einen JSON-String um.
                ' Beispiel: {"Name":"Anna Nass","Groesse":180,...}
                Dim personAsString As String = JsonConvert.SerializeObject(person, settings)

                ' Schreibt den JSON-String als eigene Zeile in die Datei.
                ' Dadurch steht später jede Person in einer separaten Zeile.
                writer.WriteLine(personAsString)
            Next

            ' Zeigt nach erfolgreichem Speichern eine Meldung an.
            MessageBox.Show("Speichern erfolgreich")
            ' Falls man nicht weiß, wo die Datei gespeichert wird, kann man es damit auslesen
            'MessageBox.Show(Path.GetFullPath("personen.txt"))

        Catch ex As Exception

            ' Falls beim Schreiben ein Fehler auftritt
            ' (z. B. fehlende Berechtigung oder Datei gesperrt),
            ' wird diese Meldung angezeigt.
            MessageBox.Show("Speichern fehgeschlagen")

        Finally

            ' Schließt den StreamWriter am Ende sicher,
            ' auch wenn vorher ein Fehler aufgetreten ist.
            ' Das Fragezeichen bedeutet:
            ' Nur schließen, wenn writer nicht Nothing ist.
            writer?.Close()

        End Try

    End Sub

    ' Diese Funktion lädt Personen aus der Datei
    ' und gibt sie als Liste von Person-Objekten zurück.
    Private Function LoadPeople() As List(Of Person)

        ' Erstellt eine leere Liste, in der die geladenen Personen gesammelt werden.
        Dim personenliste As List(Of Person) = New List(Of Person)

        ' Variable für den StreamReader.
        ' Mit einem StreamReader kann Text aus einer Datei gelesen werden.
        Dim reader As StreamReader

        Try
            ' Öffnet die Datei "personen.txt" zum Lesen.
            reader = New StreamReader("personen.txt")

            ' Erstellt wieder dieselben JSON-Einstellungen wie beim Speichern.
            ' Das ist wichtig, damit die gespeicherten Daten korrekt zurückverwandelt werden können.
            Dim settings As JsonSerializerSettings = New JsonSerializerSettings()
            settings.TypeNameHandling = TypeNameHandling.Objects

            ' Solange das Ende der Datei noch nicht erreicht ist,
            ' wird zeilenweise gelesen.
            While Not reader.EndOfStream

                ' Liest eine Zeile aus der Datei,
                ' wandelt diese mit DeserializeObject wieder in ein Person-Objekt um
                ' und fügt das Objekt anschließend der Liste hinzu.
                personenliste.Add(
                    JsonConvert.DeserializeObject(Of Person)(reader.ReadLine(), settings)
                )

            End While

            ' Zeigt nach erfolgreichem Laden eine Meldung an.
            MessageBox.Show("Laden erfolgreich")

        Catch ex As Exception

            ' Falls beim Lesen ein Fehler auftritt
            ' (z. B. Datei existiert nicht oder enthält ungültige Daten),
            ' wird diese Meldung angezeigt.
            MessageBox.Show("Laden fehlgeschlagen")

        Finally

            ' Schließt den StreamReader am Ende sicher,
            ' auch wenn beim Laden ein Fehler aufgetreten ist.
            reader?.Close()

        End Try

        ' Gibt die Liste mit allen geladenen Personen zurück.
        Return personenliste

    End Function

End Class