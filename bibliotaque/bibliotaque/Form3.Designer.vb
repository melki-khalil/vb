<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.L1 = New System.Windows.Forms.ListBox()
        Me.L2 = New System.Windows.Forms.ListBox()
        Me.L3 = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_affichd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'L1
        '
        Me.L1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.L1.FormattingEnabled = True
        Me.L1.ItemHeight = 25
        Me.L1.Location = New System.Drawing.Point(63, 94)
        Me.L1.Name = "L1"
        Me.L1.Size = New System.Drawing.Size(164, 254)
        Me.L1.TabIndex = 0
        '
        'L2
        '
        Me.L2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.L2.FormattingEnabled = True
        Me.L2.ItemHeight = 25
        Me.L2.Location = New System.Drawing.Point(292, 94)
        Me.L2.Name = "L2"
        Me.L2.Size = New System.Drawing.Size(164, 254)
        Me.L2.TabIndex = 1
        '
        'L3
        '
        Me.L3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.L3.FormattingEnabled = True
        Me.L3.ItemHeight = 25
        Me.L3.Location = New System.Drawing.Point(525, 94)
        Me.L3.Name = "L3"
        Me.L3.Size = New System.Drawing.Size(164, 254)
        Me.L3.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(343, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 25)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Titre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(562, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Auteur"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(109, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ISBN"
        '
        'btn_affichd
        '
        Me.btn_affichd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btn_affichd.Location = New System.Drawing.Point(567, 365)
        Me.btn_affichd.Name = "btn_affichd"
        Me.btn_affichd.Size = New System.Drawing.Size(221, 62)
        Me.btn_affichd.TabIndex = 8
        Me.btn_affichd.Text = "affichage detaié"
        Me.btn_affichd.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_affichd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.L3)
        Me.Controls.Add(Me.L2)
        Me.Controls.Add(Me.L1)
        Me.Name = "Form3"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents L1 As ListBox
    Friend WithEvents L2 As ListBox
    Friend WithEvents L3 As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_affichd As Button
End Class
