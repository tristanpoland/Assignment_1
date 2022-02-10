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
        Me.BtnShrink = New System.Windows.Forms.Button()
        Me.BtnRed = New System.Windows.Forms.Button()
        Me.BtnBlue = New System.Windows.Forms.Button()
        Me.BtnGrow = New System.Windows.Forms.Button()
        Me.LblTest = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnShrink
        '
        Me.BtnShrink.Location = New System.Drawing.Point(12, 342)
        Me.BtnShrink.Name = "BtnShrink"
        Me.BtnShrink.Size = New System.Drawing.Size(162, 23)
        Me.BtnShrink.TabIndex = 0
        Me.BtnShrink.Text = "Minify This Form"
        Me.BtnShrink.UseVisualStyleBackColor = True
        '
        'BtnRed
        '
        Me.BtnRed.Location = New System.Drawing.Point(12, 27)
        Me.BtnRed.Name = "BtnRed"
        Me.BtnRed.Size = New System.Drawing.Size(162, 23)
        Me.BtnRed.TabIndex = 1
        Me.BtnRed.Text = "Make Form Red"
        Me.BtnRed.UseVisualStyleBackColor = True
        '
        'BtnBlue
        '
        Me.BtnBlue.Location = New System.Drawing.Point(12, 27)
        Me.BtnBlue.Name = "BtnBlue"
        Me.BtnBlue.Size = New System.Drawing.Size(162, 23)
        Me.BtnBlue.TabIndex = 2
        Me.BtnBlue.Text = "Make Form Blue"
        Me.BtnBlue.UseVisualStyleBackColor = True
        '
        'BtnGrow
        '
        Me.BtnGrow.Location = New System.Drawing.Point(12, 343)
        Me.BtnGrow.Name = "BtnGrow"
        Me.BtnGrow.Size = New System.Drawing.Size(162, 23)
        Me.BtnGrow.TabIndex = 3
        Me.BtnGrow.Text = "Max This Form"
        Me.BtnGrow.UseVisualStyleBackColor = True
        '
        'LblTest
        '
        Me.LblTest.AutoSize = True
        Me.LblTest.Location = New System.Drawing.Point(55, 9)
        Me.LblTest.Name = "LblTest"
        Me.LblTest.Size = New System.Drawing.Size(73, 15)
        Me.LblTest.TabIndex = 4
        Me.LblTest.Text = "Hello World!"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 307)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(162, 29)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Show Information box"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(186, 372)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LblTest)
        Me.Controls.Add(Me.BtnGrow)
        Me.Controls.Add(Me.BtnBlue)
        Me.Controls.Add(Me.BtnRed)
        Me.Controls.Add(Me.BtnShrink)
        Me.Name = "Form1"
        Me.Text = "Assignment 1 Forms (Programming in VisualBasic)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnShrink As Button
    Friend WithEvents BtnRed As Button
    Friend WithEvents BtnBlue As Button
    Friend WithEvents BtnGrow As Button
    Friend WithEvents LblTest As Label
    Friend WithEvents Button1 As Button
End Class
