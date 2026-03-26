<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Lbx_People = New System.Windows.Forms.ListBox()
        Me.Btn_New = New System.Windows.Forms.Button()
        Me.Btn_Delete = New System.Windows.Forms.Button()
        Me.Btn_Save = New System.Windows.Forms.Button()
        Me.Btn_Load = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lbx_People
        '
        Me.Lbx_People.FormattingEnabled = True
        Me.Lbx_People.ItemHeight = 16
        Me.Lbx_People.Location = New System.Drawing.Point(12, 12)
        Me.Lbx_People.Name = "Lbx_People"
        Me.Lbx_People.Size = New System.Drawing.Size(260, 420)
        Me.Lbx_People.TabIndex = 0
        '
        'Btn_New
        '
        Me.Btn_New.Location = New System.Drawing.Point(278, 12)
        Me.Btn_New.Name = "Btn_New"
        Me.Btn_New.Size = New System.Drawing.Size(113, 23)
        Me.Btn_New.TabIndex = 1
        Me.Btn_New.Text = "Neu"
        Me.Btn_New.UseVisualStyleBackColor = True
        '
        'Btn_Delete
        '
        Me.Btn_Delete.Location = New System.Drawing.Point(278, 41)
        Me.Btn_Delete.Name = "Btn_Delete"
        Me.Btn_Delete.Size = New System.Drawing.Size(113, 23)
        Me.Btn_Delete.TabIndex = 2
        Me.Btn_Delete.Text = "Löschen"
        Me.Btn_Delete.UseVisualStyleBackColor = True
        '
        'Btn_Save
        '
        Me.Btn_Save.Location = New System.Drawing.Point(278, 70)
        Me.Btn_Save.Name = "Btn_Save"
        Me.Btn_Save.Size = New System.Drawing.Size(113, 23)
        Me.Btn_Save.TabIndex = 3
        Me.Btn_Save.Text = "Speichern"
        Me.Btn_Save.UseVisualStyleBackColor = True
        '
        'Btn_Load
        '
        Me.Btn_Load.Location = New System.Drawing.Point(278, 99)
        Me.Btn_Load.Name = "Btn_Load"
        Me.Btn_Load.Size = New System.Drawing.Size(113, 23)
        Me.Btn_Load.TabIndex = 4
        Me.Btn_Load.Text = "Laden"
        Me.Btn_Load.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 450)
        Me.Controls.Add(Me.Btn_Load)
        Me.Controls.Add(Me.Btn_Save)
        Me.Controls.Add(Me.Btn_Delete)
        Me.Controls.Add(Me.Btn_New)
        Me.Controls.Add(Me.Lbx_People)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Lbx_People As ListBox
    Friend WithEvents Btn_New As Button
    Friend WithEvents Btn_Delete As Button
    Friend WithEvents Btn_Save As Button
    Friend WithEvents Btn_Load As Button
End Class
