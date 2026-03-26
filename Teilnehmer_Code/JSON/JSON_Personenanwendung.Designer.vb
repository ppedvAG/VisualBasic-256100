<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class JSON_Personenanwendung
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Personenliste = New ListBox()
        NeuButton = New Button()
        LöschenButton = New Button()
        SpeichernButton = New Button()
        LadenButton = New Button()
        SuspendLayout()
        ' 
        ' Personenliste
        ' 
        Personenliste.FormattingEnabled = True
        Personenliste.Location = New Point(48, 33)
        Personenliste.Name = "Personenliste"
        Personenliste.Size = New Size(263, 364)
        Personenliste.TabIndex = 0
        ' 
        ' NeuButton
        ' 
        NeuButton.Location = New Point(605, 48)
        NeuButton.Name = "NeuButton"
        NeuButton.Size = New Size(75, 23)
        NeuButton.TabIndex = 1
        NeuButton.Text = "Neu"
        NeuButton.UseVisualStyleBackColor = True
        ' 
        ' LöschenButton
        ' 
        LöschenButton.Location = New Point(605, 102)
        LöschenButton.Name = "LöschenButton"
        LöschenButton.Size = New Size(75, 23)
        LöschenButton.TabIndex = 2
        LöschenButton.Text = "Löschen"
        LöschenButton.UseVisualStyleBackColor = True
        ' 
        ' SpeichernButton
        ' 
        SpeichernButton.Location = New Point(605, 157)
        SpeichernButton.Name = "SpeichernButton"
        SpeichernButton.Size = New Size(75, 23)
        SpeichernButton.TabIndex = 3
        SpeichernButton.Text = "Speichern"
        SpeichernButton.UseVisualStyleBackColor = True
        ' 
        ' LadenButton
        ' 
        LadenButton.Location = New Point(605, 218)
        LadenButton.Name = "LadenButton"
        LadenButton.Size = New Size(75, 23)
        LadenButton.TabIndex = 4
        LadenButton.Text = "Laden"
        LadenButton.UseVisualStyleBackColor = True
        ' 
        ' JSON_Personenanwendung
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(LadenButton)
        Controls.Add(SpeichernButton)
        Controls.Add(LöschenButton)
        Controls.Add(NeuButton)
        Controls.Add(Personenliste)
        Name = "JSON_Personenanwendung"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Personenliste As ListBox
    Friend WithEvents NeuButton As Button
    Friend WithEvents LöschenButton As Button
    Friend WithEvents SpeichernButton As Button
    Friend WithEvents LadenButton As Button

End Class
