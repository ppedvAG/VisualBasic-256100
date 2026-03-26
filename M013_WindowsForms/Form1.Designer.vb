<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
        Me.Btn_KlickMich = New System.Windows.Forms.Button()
        Me.Btn_Zwei = New System.Windows.Forms.Button()
        Me.Cbx_Haken = New System.Windows.Forms.CheckBox()
        Me.Cbb_Auswahl = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Lbl_Ausgabe = New System.Windows.Forms.Label()
        Me.Tbx_Input = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÖffenenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SchließenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Btn_MessageBox = New System.Windows.Forms.Button()
        Me.ButtonTextbox = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_KlickMich
        '
        Me.Btn_KlickMich.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_KlickMich.Location = New System.Drawing.Point(106, 90)
        Me.Btn_KlickMich.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btn_KlickMich.Name = "Btn_KlickMich"
        Me.Btn_KlickMich.Size = New System.Drawing.Size(222, 70)
        Me.Btn_KlickMich.TabIndex = 0
        Me.Btn_KlickMich.Text = "Klick Mich"
        Me.Btn_KlickMich.UseVisualStyleBackColor = True
        '
        'Btn_Zwei
        '
        Me.Btn_Zwei.Location = New System.Drawing.Point(76, 200)
        Me.Btn_Zwei.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btn_Zwei.Name = "Btn_Zwei"
        Me.Btn_Zwei.Size = New System.Drawing.Size(252, 92)
        Me.Btn_Zwei.TabIndex = 1
        Me.Btn_Zwei.Text = "Moin"
        Me.Btn_Zwei.UseVisualStyleBackColor = True
        '
        'Cbx_Haken
        '
        Me.Cbx_Haken.AutoSize = True
        Me.Cbx_Haken.Checked = True
        Me.Cbx_Haken.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Cbx_Haken.Location = New System.Drawing.Point(196, 356)
        Me.Cbx_Haken.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Cbx_Haken.Name = "Cbx_Haken"
        Me.Cbx_Haken.Size = New System.Drawing.Size(163, 29)
        Me.Cbx_Haken.TabIndex = 2
        Me.Cbx_Haken.Text = "Hak mich ab"
        Me.Cbx_Haken.UseVisualStyleBackColor = True
        '
        'Cbb_Auswahl
        '
        Me.Cbb_Auswahl.FormattingEnabled = True
        Me.Cbb_Auswahl.Items.AddRange(New Object() {"Eintrag 1", "Auswahl 2", "Item 3"})
        Me.Cbb_Auswahl.Location = New System.Drawing.Point(472, 94)
        Me.Cbb_Auswahl.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Cbb_Auswahl.Name = "Cbb_Auswahl"
        Me.Cbb_Auswahl.Size = New System.Drawing.Size(342, 33)
        Me.Cbb_Auswahl.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Location = New System.Drawing.Point(970, 70)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(366, 222)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gruppe 1"
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(40, 91)
        Me.RadioButton4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(173, 29)
        Me.RadioButton4.TabIndex = 8
        Me.RadioButton4.Text = "RadioButton4"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Checked = True
        Me.RadioButton3.Location = New System.Drawing.Point(40, 48)
        Me.RadioButton3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(173, 29)
        Me.RadioButton3.TabIndex = 7
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "RadioButton3"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(1110, 314)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(173, 29)
        Me.RadioButton1.TabIndex = 5
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(1110, 356)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(173, 29)
        Me.RadioButton2.TabIndex = 6
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "RadioButton2"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Lbl_Ausgabe
        '
        Me.Lbl_Ausgabe.AutoSize = True
        Me.Lbl_Ausgabe.Location = New System.Drawing.Point(468, 200)
        Me.Lbl_Ausgabe.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_Ausgabe.Name = "Lbl_Ausgabe"
        Me.Lbl_Ausgabe.Size = New System.Drawing.Size(190, 25)
        Me.Lbl_Ausgabe.TabIndex = 7
        Me.Lbl_Ausgabe.Text = "Ich bin ein String!!!"
        '
        'Tbx_Input
        '
        Me.Tbx_Input.AcceptsReturn = True
        Me.Tbx_Input.AcceptsTab = True
        Me.Tbx_Input.Location = New System.Drawing.Point(472, 297)
        Me.Tbx_Input.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Tbx_Input.Multiline = True
        Me.Tbx_Input.Name = "Tbx_Input"
        Me.Tbx_Input.Size = New System.Drawing.Size(406, 188)
        Me.Tbx_Input.TabIndex = 8
        Me.Tbx_Input.Text = "EINGABE"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(1425, 42)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DateiToolStripMenuItem
        '
        Me.DateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ÖffenenToolStripMenuItem, Me.SchließenToolStripMenuItem})
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(90, 36)
        Me.DateiToolStripMenuItem.Text = "Datei"
        '
        'ÖffenenToolStripMenuItem
        '
        Me.ÖffenenToolStripMenuItem.Name = "ÖffenenToolStripMenuItem"
        Me.ÖffenenToolStripMenuItem.Size = New System.Drawing.Size(250, 44)
        Me.ÖffenenToolStripMenuItem.Text = "Öffenen"
        '
        'SchließenToolStripMenuItem
        '
        Me.SchließenToolStripMenuItem.Name = "SchließenToolStripMenuItem"
        Me.SchließenToolStripMenuItem.Size = New System.Drawing.Size(250, 44)
        Me.SchließenToolStripMenuItem.Text = "Schließen"
        '
        'Btn_MessageBox
        '
        Me.Btn_MessageBox.Location = New System.Drawing.Point(124, 508)
        Me.Btn_MessageBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btn_MessageBox.Name = "Btn_MessageBox"
        Me.Btn_MessageBox.Size = New System.Drawing.Size(141, 66)
        Me.Btn_MessageBox.TabIndex = 10
        Me.Btn_MessageBox.Text = "Öffne MB"
        Me.Btn_MessageBox.UseVisualStyleBackColor = True
        '
        'ButtonTextbox
        '
        Me.ButtonTextbox.Location = New System.Drawing.Point(493, 527)
        Me.ButtonTextbox.Name = "ButtonTextbox"
        Me.ButtonTextbox.Size = New System.Drawing.Size(327, 47)
        Me.ButtonTextbox.TabIndex = 11
        Me.ButtonTextbox.Text = "Eingabetext anzeigen lassen"
        Me.ButtonTextbox.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(970, 434)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 82
        Me.DataGridView1.RowTemplate.Height = 33
        Me.DataGridView1.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView1.TabIndex = 12
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1425, 627)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ButtonTextbox)
        Me.Controls.Add(Me.Btn_MessageBox)
        Me.Controls.Add(Me.Tbx_Input)
        Me.Controls.Add(Me.Lbl_Ausgabe)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Btn_Zwei)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Cbb_Auswahl)
        Me.Controls.Add(Me.Cbx_Haken)
        Me.Controls.Add(Me.Btn_KlickMich)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MainWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mein besonders schönes Fenster"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_KlickMich As Button
    Friend WithEvents Btn_Zwei As Button
    Friend WithEvents Cbx_Haken As CheckBox
    Friend WithEvents Cbb_Auswahl As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents Lbl_Ausgabe As Label
    Friend WithEvents Tbx_Input As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DateiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÖffenenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SchließenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Btn_MessageBox As Button
    Friend WithEvents ButtonTextbox As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
