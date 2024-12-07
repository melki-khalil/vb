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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.t_ISBN = New System.Windows.Forms.TextBox()
        Me.t_auteur = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.t_titre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_ajout = New System.Windows.Forms.Button()
        Me.btn_affich = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(81, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ISBN"
        '
        't_ISBN
        '
        Me.t_ISBN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.t_ISBN.Location = New System.Drawing.Point(175, 77)
        Me.t_ISBN.Name = "t_ISBN"
        Me.t_ISBN.Size = New System.Drawing.Size(100, 30)
        Me.t_ISBN.TabIndex = 1
        '
        't_auteur
        '
        Me.t_auteur.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.t_auteur.Location = New System.Drawing.Point(175, 254)
        Me.t_auteur.Name = "t_auteur"
        Me.t_auteur.Size = New System.Drawing.Size(100, 30)
        Me.t_auteur.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(81, 254)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Auteur"
        '
        't_titre
        '
        Me.t_titre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.t_titre.Location = New System.Drawing.Point(175, 167)
        Me.t_titre.Name = "t_titre"
        Me.t_titre.Size = New System.Drawing.Size(100, 30)
        Me.t_titre.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(81, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Titre"
        '
        'btn_ajout
        '
        Me.btn_ajout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btn_ajout.Location = New System.Drawing.Point(447, 352)
        Me.btn_ajout.Name = "btn_ajout"
        Me.btn_ajout.Size = New System.Drawing.Size(146, 62)
        Me.btn_ajout.TabIndex = 6
        Me.btn_ajout.Text = "ajouter"
        Me.btn_ajout.UseVisualStyleBackColor = True
        '
        'btn_affich
        '
        Me.btn_affich.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btn_affich.Location = New System.Drawing.Point(631, 352)
        Me.btn_affich.Name = "btn_affich"
        Me.btn_affich.Size = New System.Drawing.Size(146, 62)
        Me.btn_affich.TabIndex = 7
        Me.btn_affich.Text = "afficher"
        Me.btn_affich.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_affich)
        Me.Controls.Add(Me.btn_ajout)
        Me.Controls.Add(Me.t_titre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.t_auteur)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.t_ISBN)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents t_ISBN As TextBox
    Friend WithEvents t_auteur As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents t_titre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_ajout As Button
    Friend WithEvents btn_affich As Button
End Class
