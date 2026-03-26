' Wir benötigen System.IO, um mit Dateien zu arbeiten.
Imports System.IO

' ------------------------------------------------------------
' Die Klasse Logger kapselt die komplette Logging-Funktionalität.
' Dadurch bleibt der restliche Code sauber und übersichtlich.
' ------------------------------------------------------------
Public Class Logger

    ' --------------------------------------------------------
    ' In dieser Variablen speichern wir den Pfad zur Log-Datei.
    ' "ReadOnly" bedeutet:
    ' Der Wert darf nur bei der Initialisierung gesetzt werden
    ' (z.B. bei der Deklaration oder im Konstruktor).
    ' Danach kann der Variablen kein neuer Wert mehr zugewiesen werden.
    ' Lesen ist jederzeit erlaubt.
    ' Allgemein bei Objekten bedeutet ReadOnly nur: die Referenz darf nicht neu gesetzt werden.
    ' Das Objekt selbst könnte trotzdem veränderbar sein.
    ' --------------------------------------------------------
    Private ReadOnly _logFilePath As String

    ' --------------------------------------------------------
    ' Konstruktor der Klasse Logger
    ' Dieser wird automatisch aufgerufen, wenn ein neues Logger-
    ' Objekt erzeugt wird.
    '
    ' Parameter:
    ' logFilePath = Dateiname oder kompletter Pfad zur Log-Datei
    ' --------------------------------------------------------
    Public Sub New(logFilePath As String)
        _logFilePath = logFilePath
    End Sub

    ' --------------------------------------------------------
    ' Öffentliche Methode für normale Informationen.
    ' Beispiel:
    ' logger.Info("Programm wurde gestartet")
    ' --------------------------------------------------------
    Public Sub Info(message As String)
        WriteLog("INFO", message)
    End Sub

    ' --------------------------------------------------------
    ' Öffentliche Methode für Warnungen.
    ' Warnungen bedeuten:
    ' Es gibt ein mögliches Problem, aber das Programm läuft weiter.
    ' Beispiel:
    ' logger.Warning("Datei nicht gefunden, Standardwerte werden benutzt")
    ' --------------------------------------------------------
    Public Sub Warning(message As String)
        WriteLog("WARNING", message)
    End Sub

    ' --------------------------------------------------------
    ' Methode für Fehlermeldungen.
    '
    ' Warum steht Error in eckigen Klammern?
    ' "Error" ist in VB ein reserviertes Wort.
    ' Reservierte Wörter haben in der Sprache bereits eine
    ' feste Bedeutung und können normalerweise nicht direkt
    ' als Methodenname verwendet werden.
    '
    ' Durch die Schreibweise [Error] teilen wir VB mit:
    ' Dieses Wort soll hier nicht als Schlüsselwort,
    ' sondern als Name der Methode behandelt werden.
    '
    ' Technisch funktioniert das, aber in echtem Projektcode
    ' wäre ein Name wie LogError oft klarer.
    ' --------------------------------------------------------
    Public Sub [Error](message As String)
        WriteLog("ERROR", message)
    End Sub

    ' --------------------------------------------------------
    ' Überladene Error-Methode:
    ' Diese Version nimmt zusätzlich ein Exception-Objekt entgegen.
    '
    ' Warum ist das nützlich?
    ' So können wir nicht nur eine eigene Fehlermeldung loggen,
    ' sondern auch die technische Fehlermeldung der Exception.
    ' --------------------------------------------------------
    Public Sub [Error](message As String, ex As Exception)
        Dim fullMessage As String = message & " | Ausnahme: " & ex.Message

        WriteLog("ERROR", fullMessage)
    End Sub

    ' --------------------------------------------------------
    ' Zentrale interne Methode zum Schreiben des Log-Eintrags.
    '
    ' level   = INFO, WARNING oder ERROR
    ' message = eigentliche Nachricht
    '
    ' Diese Methode ist "Private", weil sie nur innerhalb der
    ' Logger-Klasse benutzt werden soll.
    ' --------------------------------------------------------
    Private Sub WriteLog(level As String, message As String)

        ' ----------------------------------------------------
        ' Jede Log-Zeile bekommt einen Zeitstempel.
        ' Now liefert aktuelles Datum + aktuelle Uhrzeit.
        ' ToString formatiert den Zeitstempel lesbar.
        ' ----------------------------------------------------
        Dim timestamp As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")

        ' ----------------------------------------------------
        ' Zusammensetzen der kompletten Log-Zeile.
        ' Beispiel:
        ' 2026-03-25 10:15:30 [INFO] Programm wurde gestartet
        ' ----------------------------------------------------
        Dim logEntry As String = timestamp & " [" & level & "] " & message

        ' ----------------------------------------------------
        ' 1) Ausgabe in die Konsole
        ' ----------------------------------------------------
        Console.WriteLine(logEntry)

        ' ----------------------------------------------------
        ' 2) Schreiben in die Log-Datei
        ' AppendAllText hängt Text an das Ende der Datei an.
        ' Falls die Datei noch nicht existiert, wird sie erstellt.
        '
        ' Environment.NewLine sorgt dafür, dass jeder Eintrag
        ' in einer neuen Zeile steht.
        ' ----------------------------------------------------
        Try
            File.AppendAllText(_logFilePath, logEntry & Environment.NewLine)

        Catch ex As Exception
            ' ------------------------------------------------
            ' Falls sogar das Logging selbst fehlschlägt,
            ' schreiben wir die Meldung wenigstens in die Konsole.
            '
            ' Beispiel:
            ' - kein Schreibrecht im Ordner
            ' - Datei wird von anderem Prozess blockiert
            ' ------------------------------------------------
            Console.WriteLine("Fehler beim Schreiben der Log-Datei: " & ex.Message)
        End Try
    End Sub

End Class
Module Program

    Sub Main()

        ' --------------------------------------------------------
        ' Name der Log-Datei
        '
        ' Hier wird nur ein Dateiname und kein vollständiger Pfad
        ' angegeben. Deshalb verwendet das Programm einen relativen
        ' Pfad.
        '
        ' Die Datei wird dadurch nicht automatisch im Projektordner,
        ' sondern im aktuellen Ausführungsordner gespeichert.
        ' Bei einer normalen VB.NET-Konsolenanwendung ist das oft:
        ' bin\Debug\net10.0
        ' --------------------------------------------------------
        Dim logFile As String = "schulung_log.txt"

        ' --------------------------------------------------------
        ' Erzeugen eines Logger-Objekts
        ' Ab jetzt können wir mit logger.Info / Warning / Error
        ' arbeiten.
        ' --------------------------------------------------------
        Dim logger As New Logger(logFile)

        ' --------------------------------------------------------
        ' Startmeldung
        ' Solche Meldungen sind sinnvoll, um später zu erkennen,
        ' wann ein Programm gestartet wurde.
        ' --------------------------------------------------------
        logger.Info("Programmstart")

        ' --------------------------------------------------------
        ' Beispiel 1: Normale Programmaktion protokollieren
        ' --------------------------------------------------------
        logger.Info("Benutzer öffnet das Programm")

        ' --------------------------------------------------------
        ' Beispiel 2: Warnung protokollieren
        ' Eine Warnung ist kein schwerer Fehler, aber ein Hinweis,
        ' dass etwas ungewöhnlich ist.
        ' --------------------------------------------------------
        logger.Warning("Beispieldatei nicht gefunden, es werden Testdaten verwendet")

        ' --------------------------------------------------------
        ' Beispiel 3: Fehler bewusst erzeugen und loggen
        '
        ' Wir teilen absichtlich durch 0, um eine Exception
        ' auszulösen. 
        ' --------------------------------------------------------
        Try
            Dim zahl1 As Integer = 10
            Dim zahl2 As Integer = 0

            ' Dieser Ausdruck erzeugt einen Laufzeitfehler.
            Dim ergebnis As Integer = zahl1 \ zahl2

            ' Diese Zeile wird niemals erreicht, weil vorher
            ' bereits die Exception auftritt.
            logger.Info("Ergebnis der Berechnung: " & ergebnis)

        Catch ex As Exception
            ' ----------------------------------------------------
            ' Hier fangen wir den Fehler ab, damit das Programm
            ' nicht einfach abstürzt.
            '
            ' Stattdessen schreiben wir einen Fehler ins Log.
            ' ----------------------------------------------------
            logger.Error("Fehler bei der Berechnung", ex)
        End Try

        ' --------------------------------------------------------
        ' Beispiel 4: Weitere normale Aktion
        ' --------------------------------------------------------
        logger.Info("Programm läuft nach dem Fehler weiter")

        ' --------------------------------------------------------
        ' Endmeldung
        ' Auch diese Information ist nützlich, um den vollständigen
        ' Ablauf später nachvollziehen zu können.
        ' --------------------------------------------------------
        logger.Info("Programmende")

        ' --------------------------------------------------------
        ' Pause, damit das Konsolenfenster offen bleibt.
        ' --------------------------------------------------------
        Console.WriteLine()
        Console.WriteLine("Zum Beenden bitte eine Taste drücken ...")
        Console.ReadKey()

    End Sub

End Module