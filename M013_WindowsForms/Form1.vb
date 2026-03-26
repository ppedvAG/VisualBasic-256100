Public Class MainWindow

    'Events, welche von GUI-Elementen unter bestimmten Umständen geworfen werden, sind spezielle Delegates.
    ''Methoden, welche durch diese Events ausgeführt werden sollen, können mittels des HANDLES-Stichworts an
    ''Events gebunden werden
    Private Sub Btn_KlickMich_Click(sender As Object, e As EventArgs) Handles Btn_KlickMich.Click, Btn_Zwei.Click

        'Die einzelnen GUI-Elemenete sind auch OOP-Objekte. Sie besitzen diverse Properties, welche manipuliert werden können.
        ''Manipulation der Hintergrundfarbe des Fensters (Me)
        Me.BackColor = Color.DeepPink

        ''Manipulation der Button-Beschriftung des Buttons Btn_KlickMich
        Btn_KlickMich.Text = "HALLO"


        'Prüfung, ob die CheckBox abgehakt ist
        If Cbx_Haken.Checked Then
            ''Manipulation der Left-Eigenschaft des Buttons, der dieses Event gefeuert hat
            DirectCast(sender, Button).Left = 2
        End If

        ''Beschriftung des Labels mit dem ausgewählten Item der ComboBox
        Btn_Zwei.Text = Cbb_Auswahl.SelectedItem

    End Sub


    Private Sub Btn_MessageBox_Click(sender As Object, e As EventArgs) Handles Btn_MessageBox.Click

        'Mittels Message-Boxen können simple Benutzerabfragen gestartet Werden. Diese geben ein DialogResult-Objekt zurück, das die Antwort des
        ''Benutzers beinhaltet und das in einer If-Abfrage überprüft werden kann.
        If MessageBox.Show("Geht es dir gut?", "Gesundheitsabfrage", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            MessageBox.Show("Aber nicht mehr lange...")
        End If

    End Sub

    Private Sub ButtonTextbox_Click(sender As Object, e As EventArgs) Handles ButtonTextbox.Click
        Dim neuesFenster As New Form()
        Dim lblText As New Label()

        neuesFenster.Text = "Eingabetext"
        neuesFenster.Size = New Size(300, 200)
        neuesFenster.StartPosition = FormStartPosition.CenterParent

        lblText.AutoSize = True
        lblText.Location = New Point(30, 30)
        lblText.Text = Tbx_Input.Text

        neuesFenster.Controls.Add(lblText)
        neuesFenster.ShowDialog()
    End Sub
End Class
