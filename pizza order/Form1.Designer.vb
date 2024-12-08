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
        CMB = New ComboBox()
        CF = New RadioButton()
        CC = New RadioButton()
        CE = New RadioButton()
        Ch = New CheckBox()
        FS = New CheckBox()
        Po = New CheckBox()
        Ol = New CheckBox()
        BTN = New Button()
        LB1 = New Label()
        LBL2 = New Label()
        SuspendLayout()
        ' 
        ' CMB
        ' 
        CMB.FormattingEnabled = True
        CMB.Items.AddRange(New Object() {"Petite", "Moyenne", "Grande"})
        CMB.Location = New Point(251, 30)
        CMB.Name = "CMB"
        CMB.Size = New Size(151, 28)
        CMB.TabIndex = 0
        ' 
        ' CF
        ' 
        CF.AutoSize = True
        CF.Location = New Point(52, 88)
        CF.Name = "CF"
        CF.Size = New Size(103, 24)
        CF.TabIndex = 1
        CF.TabStop = True
        CF.Text = "Croute fine"
        CF.UseVisualStyleBackColor = True
        ' 
        ' CC
        ' 
        CC.AutoSize = True
        CC.Location = New Point(52, 144)
        CC.Name = "CC"
        CC.Size = New Size(140, 24)
        CC.TabIndex = 3
        CC.TabStop = True
        CC.Text = "Croute Classique"
        CC.UseVisualStyleBackColor = True
        ' 
        ' CE
        ' 
        CE.AutoSize = True
        CE.Location = New Point(52, 201)
        CE.Name = "CE"
        CE.Size = New Size(127, 24)
        CE.TabIndex = 4
        CE.TabStop = True
        CE.Text = "Croute epaisse"
        CE.UseVisualStyleBackColor = True
        ' 
        ' Ch
        ' 
        Ch.AutoSize = True
        Ch.Location = New Point(382, 89)
        Ch.Name = "Ch"
        Ch.Size = New Size(122, 24)
        Ch.TabIndex = 5
        Ch.Text = "Champignons"
        Ch.UseVisualStyleBackColor = True
        ' 
        ' FS
        ' 
        FS.AutoSize = True
        FS.Location = New Point(382, 265)
        FS.Name = "FS"
        FS.Size = New Size(197, 24)
        FS.TabIndex = 6
        FS.Text = "Fromage supplémentaire"
        FS.UseVisualStyleBackColor = True
        ' 
        ' Po
        ' 
        Po.AutoSize = True
        Po.Location = New Point(382, 202)
        Po.Name = "Po"
        Po.Size = New Size(86, 24)
        Po.TabIndex = 7
        Po.Text = "Poivrons"
        Po.UseVisualStyleBackColor = True
        ' 
        ' Ol
        ' 
        Ol.AutoSize = True
        Ol.Location = New Point(382, 144)
        Ol.Name = "Ol"
        Ol.Size = New Size(71, 24)
        Ol.TabIndex = 8
        Ol.Text = "Olives"
        Ol.UseVisualStyleBackColor = True
        ' 
        ' BTN
        ' 
        BTN.Location = New Point(12, 334)
        BTN.Name = "BTN"
        BTN.Size = New Size(163, 29)
        BTN.TabIndex = 9
        BTN.Text = "Valider Commande"
        BTN.UseVisualStyleBackColor = True
        ' 
        ' LB1
        ' 
        LB1.AutoSize = True
        LB1.Location = New Point(52, 33)
        LB1.Name = "LB1"
        LB1.Size = New Size(160, 20)
        LB1.TabIndex = 10
        LB1.Text = "Coisir la Taille de pizza"
        ' 
        ' LBL2
        ' 
        LBL2.AutoSize = True
        LBL2.Location = New Point(212, 333)
        LBL2.MinimumSize = New Size(100, 30)
        LBL2.Name = "LBL2"
        LBL2.Size = New Size(100, 30)
        LBL2.TabIndex = 11
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(LBL2)
        Controls.Add(LB1)
        Controls.Add(BTN)
        Controls.Add(Ol)
        Controls.Add(Po)
        Controls.Add(FS)
        Controls.Add(Ch)
        Controls.Add(CE)
        Controls.Add(CC)
        Controls.Add(CF)
        Controls.Add(CMB)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents CMB As ComboBox
    Friend WithEvents CF As RadioButton
    Friend WithEvents CC As RadioButton
    Friend WithEvents CE As RadioButton
    Friend WithEvents Ch As CheckBox
    Friend WithEvents FS As CheckBox
    Friend WithEvents Po As CheckBox
    Friend WithEvents Ol As CheckBox
    Friend WithEvents BTN As Button
    Friend WithEvents LB1 As Label
    Friend WithEvents LBL2 As Label

End Class
