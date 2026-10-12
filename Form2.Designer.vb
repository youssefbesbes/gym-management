<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label4 = New Label()
        Button1 = New Button()
        Label7 = New Label()
        Label3 = New Label()
        Label5 = New Label()
        Label2 = New Label()
        Button2 = New Button()
        Label6 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        Button3 = New Button()
        Button4 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(446, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(150, 15)
        Label1.TabIndex = 0
        Label1.Text = "GESTION DES ABONNES"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.FlatStyle = FlatStyle.System
        Label4.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(89, 141)
        Label4.Name = "Label4"
        Label4.Size = New Size(117, 17)
        Label4.TabIndex = 8
        Label4.Text = "date de naissance"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(107, 306)
        Button1.Name = "Button1"
        Button1.Size = New Size(86, 23)
        Button1.TabIndex = 11
        Button1.Text = "enregistrer"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.FlatStyle = FlatStyle.System
        Label7.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(89, 62)
        Label7.Name = "Label7"
        Label7.Size = New Size(46, 17)
        Label7.TabIndex = 12
        Label7.Text = "Nom :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.FlatStyle = FlatStyle.System
        Label3.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(89, 175)
        Label3.Name = "Label3"
        Label3.Size = New Size(56, 17)
        Label3.TabIndex = 13
        Label3.Text = "Adresse"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.FlatStyle = FlatStyle.System
        Label5.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(89, 210)
        Label5.Name = "Label5"
        Label5.Size = New Size(151, 17)
        Label5.TabIndex = 14
        Label5.Text = "Numero de telephone :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.FlatStyle = FlatStyle.System
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(89, 102)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 17)
        Label2.TabIndex = 15
        Label2.Text = "Prenom :"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(479, 306)
        Button2.Name = "Button2"
        Button2.Size = New Size(225, 23)
        Button2.TabIndex = 17
        Button2.Text = "retour a la menu principale"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.FlatStyle = FlatStyle.System
        Label6.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(89, 29)
        Label6.Name = "Label6"
        Label6.Size = New Size(36, 17)
        Label6.TabIndex = 18
        Label6.Text = "Ncin"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(259, 29)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(114, 23)
        TextBox1.TabIndex = 19
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(259, 62)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(114, 23)
        TextBox2.TabIndex = 20
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(259, 101)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(114, 23)
        TextBox4.TabIndex = 21
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(259, 175)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(114, 23)
        TextBox5.TabIndex = 22
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(259, 210)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(114, 23)
        TextBox6.TabIndex = 23
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(259, 141)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(228, 23)
        DateTimePicker1.TabIndex = 24
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(703, 12)
        Button3.Name = "Button3"
        Button3.Size = New Size(86, 23)
        Button3.TabIndex = 25
        Button3.Text = "supprimer"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(816, 12)
        Button4.Name = "Button4"
        Button4.Size = New Size(86, 23)
        Button4.TabIndex = 26
        Button4.Text = "modifier"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        BackgroundImage = My.Resources.Resources.image_5
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(914, 450)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(DateTimePicker1)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label6)
        Controls.Add(Button2)
        Controls.Add(Label2)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label7)
        Controls.Add(Button1)
        Controls.Add(Label4)
        Controls.Add(Label1)
        Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
