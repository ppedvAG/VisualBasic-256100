<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Btn_Left = New System.Windows.Forms.Button()
        Me.Btn_Right = New System.Windows.Forms.Button()
        Me.Btn_Start = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btn_Left
        '
        Me.Btn_Left.Location = New System.Drawing.Point(18, 19)
        Me.Btn_Left.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btn_Left.Name = "Btn_Left"
        Me.Btn_Left.Size = New System.Drawing.Size(236, 112)
        Me.Btn_Left.TabIndex = 0
        Me.Btn_Left.Text = "Links"
        Me.Btn_Left.UseVisualStyleBackColor = True
        '
        'Btn_Right
        '
        Me.Btn_Right.Location = New System.Drawing.Point(946, 19)
        Me.Btn_Right.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btn_Right.Name = "Btn_Right"
        Me.Btn_Right.Size = New System.Drawing.Size(236, 112)
        Me.Btn_Right.TabIndex = 1
        Me.Btn_Right.Text = "Rechts"
        Me.Btn_Right.UseVisualStyleBackColor = True
        '
        'Btn_Start
        '
        Me.Btn_Start.Location = New System.Drawing.Point(18, 141)
        Me.Btn_Start.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btn_Start.Name = "Btn_Start"
        Me.Btn_Start.Size = New System.Drawing.Size(1164, 50)
        Me.Btn_Start.TabIndex = 2
        Me.Btn_Start.Text = "Start"
        Me.Btn_Start.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 233)
        Me.Controls.Add(Me.Btn_Start)
        Me.Controls.Add(Me.Btn_Right)
        Me.Controls.Add(Me.Btn_Left)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btn_Left As Button
    Friend WithEvents Btn_Right As Button
    Friend WithEvents Btn_Start As Button
End Class
