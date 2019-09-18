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
        Me.btnLoadFile = New System.Windows.Forms.Button()
        Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.label2 = New System.Windows.Forms.Label()
        Me.txtPhoneNumbers = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.lstTelCell = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnLoadFile
        '
        Me.btnLoadFile.Location = New System.Drawing.Point(17, 20)
        Me.btnLoadFile.Name = "btnLoadFile"
        Me.btnLoadFile.Size = New System.Drawing.Size(120, 22)
        Me.btnLoadFile.TabIndex = 5
        Me.btnLoadFile.Text = "Load File"
        Me.btnLoadFile.UseVisualStyleBackColor = True
        '
        'openFileDialog1
        '
        Me.openFileDialog1.FileName = "openFileDialog1"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(305, 64)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(193, 13)
        Me.label2.TabIndex = 9
        Me.label2.Text = "Comma Separated Telephone Numbers"
        '
        'txtPhoneNumbers
        '
        Me.txtPhoneNumbers.Location = New System.Drawing.Point(308, 85)
        Me.txtPhoneNumbers.Multiline = True
        Me.txtPhoneNumbers.Name = "txtPhoneNumbers"
        Me.txtPhoneNumbers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPhoneNumbers.Size = New System.Drawing.Size(376, 238)
        Me.txtPhoneNumbers.TabIndex = 8
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(10, 64)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(134, 13)
        Me.label1.TabIndex = 7
        Me.label1.Text = "Extracted Telephone Lines"
        '
        'lstTelCell
        '
        Me.lstTelCell.FormattingEnabled = True
        Me.lstTelCell.Location = New System.Drawing.Point(12, 86)
        Me.lstTelCell.Name = "lstTelCell"
        Me.lstTelCell.Size = New System.Drawing.Size(209, 238)
        Me.lstTelCell.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(507, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 33)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "EXIT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog2"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(162, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(125, 33)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "CLEAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(321, 17)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(120, 22)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Find Number"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 432)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnLoadFile)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.txtPhoneNumbers)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.lstTelCell)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents btnLoadFile As System.Windows.Forms.Button
    Private WithEvents openFileDialog1 As System.Windows.Forms.OpenFileDialog
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents txtPhoneNumbers As System.Windows.Forms.TextBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents lstTelCell As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog2 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Private WithEvents Button3 As System.Windows.Forms.Button

End Class
