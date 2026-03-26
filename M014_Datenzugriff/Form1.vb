Imports System.IO
' Der Namespace System.IO enthält Klassen für die Arbeit mit Dateien und Ordnern.
' Für dieses Beispiel sind besonders wichtig:
' - StreamWriter: schreibt Text in eine Datei
' - StreamReader: liest Text aus einer Datei

Public Class Form1

    ' =========================================================
    ' 1. EVENT-HANDLER DER BUTTONS
    ' =========================================================
    ' Ein Event-Handler ist eine Methode, die automatisch ausgeführt wird,
    ' wenn ein bestimmtes Ereignis eintritt.
    ' Hier reagieren die beiden Methoden auf Click-Events von Buttons.


    ' Diese Methode wird automatisch ausgeführt,
    ' wenn der Benutzer auf den Button Btn_Save klickt.
    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click

        ' Tbx_Input ist die TextBox auf der Form.
        ' Mit Tbx_Input.Text liest man den aktuellen Inhalt der TextBox aus.
        '
        ' Dieser Inhalt wird an die Methode SaveText(...) übergeben.
        ' SaveText übernimmt danach den eigentlichen Speichervorgang.
        SaveText(Tbx_Input.Text)

    End Sub


    ' Diese Methode wird automatisch ausgeführt,
    ' wenn der Benutzer auf den Button Btn_Load klickt.
    Private Sub Btn_Load_Click(sender As Object, e As EventArgs) Handles Btn_Load.Click

        ' Clear() entfernt den bisherigen Inhalt der TextBox.
        ' Das ist hier nicht zwingend nötig, weil direkt danach ein neuer Text
        ' gesetzt wird, macht aber den Ablauf etwas klarer.
        ' Eingebaute Methode dieser Textbox
        Tbx_Input.Clear()

        ' LoadText() lädt Text aus einer Datei und gibt diesen Text als String zurück.
        ' Der zurückgegebene String wird dann in die TextBox geschrieben.
        ' Selbstgeschriebene Methode
        Tbx_Input.Text = LoadText()

    End Sub


    ' =========================================================
    ' 2. METHODE ZUM SPEICHERN EINES TEXTES
    ' =========================================================
    ' Diese Methode speichert einen String in einer Datei.
    '
    ' Übergabeparameter:
    ' text As String
    ' -> Der Text, der gespeichert werden soll.
    Private Sub SaveText(text As String)

        ' Deklaration einer Variablen für den StreamWriter.
        ' Noch ist sie nicht mit einem echten Objekt belegt.
        ' Das passiert erst später im Try-Block.
        '
        ' Warum hier außerhalb von Try?
        ' Weil wir im Finally-Block noch darauf zugreifen möchten,
        ' um den Stream wieder zu schließen.
        Dim writer As StreamWriter

        Try
            ' =================================================
            ' 2.1 SaveFileDialog erstellen
            ' =================================================
            ' Der SaveFileDialog ist das Windows-Fenster,
            ' in dem der Benutzer Speicherort und Dateinamen auswählt.
            Dim saveDialog As SaveFileDialog = New SaveFileDialog()

            ' =================================================
            ' 2.2 Eigenschaften des Dialogs setzen
            ' =================================================

            ' Vorschlag für den Dateinamen, der im Dialog schon eingetragen ist.
            saveDialog.FileName = "testText.txt"

            ' Dieser Ordner würde zuerst gesetzt werden ...
            saveDialog.InitialDirectory = "C:\"

            ' ... wird aber direkt wieder überschrieben.
            ' Wirksam ist deshalb nur diese zweite Zuweisung:
            ' Der Dialog startet im Ordner "Eigene Dokumente".
            saveDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)

            ' Filter legt fest, welche Dateitypen im Dialog angeboten werden.
            ' Aufbau:
            ' "Anzeigename|Dateimuster|Anzeigename|Dateimuster|..."
            '
            ' Hier gibt es drei Möglichkeiten:
            ' - Textdatei (*.txt)
            ' - Stringdatei (*.string)
            ' - Alle Dateien (*.*)
            saveDialog.Filter = "Textdatei|*.txt|Stringdatei|*.string|Alle Dateien|*.*"

            ' =================================================
            ' 2.3 Dialog öffnen und Antwort prüfen
            ' =================================================
            ' ShowDialog() öffnet den Speichern-Dialog.
            '
            ' Der Benutzer kann dort:
            ' - einen Dateinamen eingeben
            ' - einen Speicherort auswählen
            ' - mit "Speichern" bestätigen
            ' - oder abbrechen
            '
            ' Im Code wird geprüft, ob der Dialog intern den Rückgabewert
            ' DialogResult.OK liefert.
            ' Das bedeutet: Der Benutzer hat bestätigt.
            If saveDialog.ShowDialog() = DialogResult.OK Then

                ' =============================================
                ' 2.4 Datei mit StreamWriter öffnen
                ' =============================================
                ' saveDialog.FileName enthält den vollständigen Pfad
                ' der Datei, die der Benutzer ausgewählt hat.
                '
                ' Beispiel:
                ' C:\Users\Name\Documents\testText.txt
                writer = New StreamWriter(saveDialog.FileName)

                ' =============================================
                ' 2.5 Text in die Datei schreiben
                ' =============================================

                ' WriteLine(text) schreibt den Inhalt von "text"
                ' in die Datei und fügt am Ende automatisch
                ' einen Zeilenumbruch ein.
                writer.WriteLine(text)

                ' Write("ENDE DER DATEI") schreibt zusätzlichen Text,
                ' aber OHNE automatischen Zeilenumbruch.
                '
                ' Wenn die TextBox z. B. "Hallo" enthält,
                ' steht in der Datei danach ungefähr:
                '
                ' Hallo
                ' ENDE DER DATEI
                writer.Write("ENDE DER DATEI")

                ' Nachricht an den Benutzer:
                ' Der Speichervorgang war erfolgreich.
                MessageBox.Show("Speichern erfolgreich")

            End If

        Catch ex As Exception
            ' Dieser Block wird ausgeführt,
            ' wenn irgendwo im Try-Block ein Fehler entsteht.
            '
            ' Beispiele:
            ' - Datei kann nicht geschrieben werden
            ' - kein Zugriff auf den Ordner
            ' - ungültiger Pfad
            MessageBox.Show("Speichern fehlgeschlagen")

        Finally
            ' Der Finally-Block wird IMMER ausgeführt:
            ' - egal ob alles funktioniert hat
            ' - egal ob ein Fehler aufgetreten ist
            ' - egal ob der Benutzer abgebrochen hat
            '
            ' Er ist der richtige Ort, um Ressourcen aufzuräumen,
            ' z. B. Dateien wieder zu schließen.

            ' Es wird geprüft, ob writer überhaupt initialisiert wurde.
            ' Nur dann darf writer.Close() aufgerufen werden.
            If Not IsNothing(writer) Then

                ' Close() schließt den StreamWriter.
                ' Das ist sehr wichtig, weil sonst die Datei eventuell
                ' noch "gesperrt" bleibt und andere Programme
                ' nicht darauf zugreifen können.
                writer.Close()

            End If

            ' Alternative Kurzschreibweise:
            ' writer?.Close()
            '
            ' Bedeutung:
            ' Wenn writer nicht Nothing ist, dann schließe ihn.
            ' Wenn writer Nothing ist, passiert nichts.
        End Try

    End Sub


    ' =========================================================
    ' 3. FUNKTION ZUM LADEN EINES TEXTES
    ' =========================================================
    ' Im Unterschied zu einer Sub-Methode liefert eine Function
    ' einen Rückgabewert zurück.
    '
    ' Hier ist der Rückgabewert ein String:
    ' -> der Text, der aus der Datei geladen wurde.
    Private Function LoadText() As String

        ' In dieser Variablen wird der gelesene Text gesammelt.
        ' Anfangswert ist ein leerer String.
        Dim loadedString As String = String.Empty

        ' Variable für den StreamReader.
        ' Auch diese Variable wird erst später initialisiert.
        ' Deshalb muss am Ende geprüft werden, ob sie Nothing ist.
        Dim reader As StreamReader

        Try
            ' =================================================
            ' 3.1 OpenFileDialog erstellen
            ' =================================================
            ' Der OpenFileDialog ist das Windows-Fenster,
            ' mit dem der Benutzer eine Datei zum Öffnen auswählt.
            Dim openDialog = New OpenFileDialog()

            ' Standard-Dateiname, der zunächst im Dialog vorgeschlagen wird.
            openDialog.FileName = "testText.txt"

            ' Startordner des Dialogs:
            ' Wieder "Eigene Dokumente".
            openDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)

            ' Dieselbe Filterliste wie beim Speichern.
            openDialog.Filter = "Textdatei|*.txt|Stringdatei|*.string|Alle Dateien|*.*"

            ' =================================================
            ' 3.2 Dialog öffnen und Antwort prüfen
            ' =================================================
            ' ShowDialog() öffnet den Öffnen-Dialog.
            '
            ' Sichtbar steht dort meist "Öffnen" auf dem Button,
            ' intern liefert der Dialog aber bei Bestätigung
            ' wieder DialogResult.OK zurück.
            If openDialog.ShowDialog() = DialogResult.OK Then

                ' =============================================
                ' 3.3 Datei mit StreamReader öffnen
                ' =============================================
                ' openDialog.FileName enthält den Pfad zur Datei,
                ' die der Benutzer ausgewählt hat.
                reader = New StreamReader(openDialog.FileName)

                ' =============================================
                ' 3.4 Dateiinhalt lesen
                ' =============================================

                ' ReadToEnd() liest den gesamten Inhalt der Datei
                ' vom Anfang bis zum Ende in einem Schritt ein.
                ' Das Ergebnis wird in loadedString gespeichert.
                loadedString = reader.ReadToEnd()

                ' Alternative:
                ' Die Datei könnte auch zeilenweise gelesen werden.
                ' Das wäre nützlich, wenn man jede Zeile einzeln
                ' weiterverarbeiten möchte.
                '
                ' While Not reader.EndOfStream
                '     loadedString += reader.ReadLine() + vbNewLine
                ' End While

                ' Meldung für den Benutzer, dass das Laden geklappt hat.
                MessageBox.Show("Laden erfolgreich")

            End If

        Catch ex As Exception
            ' Dieser Block wird ausgeführt,
            ' wenn beim Öffnen oder Lesen ein Fehler auftritt.
            '
            ' Beispiele:
            ' - Datei existiert nicht mehr
            ' - Datei ist beschädigt
            ' - kein Lesezugriff erlaubt
            MessageBox.Show("Laden fehlgeschlagen")

        Finally
            ' reader?.Close() ist die Kurzschreibweise für:
            ' "Schließe reader nur dann, wenn reader nicht Nothing ist."
            '
            ' So wird der Dateistream sauber geschlossen.
            reader?.Close()
        End Try

        ' Rückgabe des geladenen Textes an die aufrufende Stelle.
        ' In diesem Programm ist das:
        ' Tbx_Input.Text = LoadText()
        Return loadedString

    End Function

End Class