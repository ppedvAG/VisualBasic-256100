Public Class Form1

    'Felder zum Zwischenspeichern der Positionen
    Private btn_Left_Start As Integer
    Private btn_Right_Start As Integer

    'Konstruktor
    Public Sub New()
        ' Diese Methode definiert und rendert die GUI. Sie muss als erste Methode im Konstruktor von Forms ausgeführt werden
        InitializeComponent()

        'Initialisierung der Felder
        btn_Left_Start = Btn_Left.Left
        btn_Right_Start = Btn_Right.Left
    End Sub

    'Event-Handler des Click-Events des linken und des Start-Button
    Private Sub Btn_Left_Click(sender As Object, e As EventArgs) Handles Btn_Left.Click, Btn_Start.Click
        'Bewegung des Buttons um 10 Pixel nach rechts
        Btn_Left.Left += 10
    End Sub

    'Event-Handler des Click-Events des rechten und des Start-Button
    Private Sub Btn_Right_Click(sender As Object, e As EventArgs) Handles Btn_Right.Click, Btn_Start.Click
        'Bewegung des Buttons um 10 Pixel nach links
        Btn_Right.Left -= 10
    End Sub

    'Event-Handler des Click-Events des Start-Button
    Private Sub Btn_Start_Click(sender As Object, e As EventArgs) Handles Btn_Start.Click
        'Prüfung, ob die Buttons sich berühren
        If Btn_Left.Left + Btn_Left.Width > Btn_Right.Left Then
            'Frage, ob die Buttons zurückgesetzt werden sollen
            If MessageBox.Show("Sollen die Buttons zurückgesetzt werden?", "KOLLISION", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
                'Zurücksetzen der Buttons
                Btn_Left.Left = btn_Left_Start
                Btn_Right.Left = btn_Right_Start
            End If
        End If
    End Sub
End Class
