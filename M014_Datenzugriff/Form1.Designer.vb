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
        Me.Tbx_Input = New System.Windows.Forms.TextBox()
        Me.Btn_Save = New System.Windows.Forms.Button()
        Me.Btn_Load = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Tbx_Input
        '
        Me.Tbx_Input.AcceptsReturn = True
        Me.Tbx_Input.AcceptsTab = True
        Me.Tbx_Input.Location = New System.Drawing.Point(12, 12)
        Me.Tbx_Input.Multiline = True
        Me.Tbx_Input.Name = "Tbx_Input"
        Me.Tbx_Input.Size = New System.Drawing.Size(238, 255)
        Me.Tbx_Input.TabIndex = 0
        '
        'Btn_Save
        '
        Me.Btn_Save.Location = New System.Drawing.Point(256, 12)
        Me.Btn_Save.Name = "Btn_Save"
        Me.Btn_Save.Size = New System.Drawing.Size(170, 37)
        Me.Btn_Save.TabIndex = 1
        Me.Btn_Save.Text = "Speichern"
        Me.Btn_Save.UseVisualStyleBackColor = True
        '
        'Btn_Load
        '
        Me.Btn_Load.Location = New System.Drawing.Point(256, 55)
        Me.Btn_Load.Name = "Btn_Load"
        Me.Btn_Load.Size = New System.Drawing.Size(170, 37)
        Me.Btn_Load.TabIndex = 2
        Me.Btn_Load.Text = "Laden"
        Me.Btn_Load.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 285)
        Me.Controls.Add(Me.Btn_Load)
        Me.Controls.Add(Me.Btn_Save)
        Me.Controls.Add(Me.Tbx_Input)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Tbx_Input As TextBox
    Friend WithEvents Btn_Save As Button
    Friend WithEvents Btn_Load As Button
End Class
