<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Button1 = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox5 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Button2 = New Button()
        Label6 = New Label()
        ComboBox1 = New ComboBox()
        DateTimePicker1 = New DateTimePicker()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ActiveCaption
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label1.Location = New Point(79, 48)
        Label1.Name = "Label1"
        Label1.Size = New Size(44, 17)
        Label1.TabIndex = 0
        Label1.Text = "Ncin :"
        Label1.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        Button1.Location = New Point(734, 327)
        Button1.Name = "Button1"
        Button1.Size = New Size(128, 34)
        Button1.TabIndex = 1
        Button1.Text = "Retour"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(231, 48)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(144, 23)
        TextBox1.TabIndex = 2
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(231, 98)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(144, 23)
        TextBox2.TabIndex = 3
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(231, 144)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(144, 23)
        TextBox3.TabIndex = 4
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(228, 283)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(124, 23)
        TextBox5.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ActiveCaption
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label2.Location = New Point(79, 99)
        Label2.Name = "Label2"
        Label2.Size = New Size(46, 17)
        Label2.TabIndex = 7
        Label2.Text = "Nom :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.ActiveCaption
        Label3.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label3.Location = New Point(79, 150)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 17)
        Label3.TabIndex = 8
        Label3.Text = "Prenom :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.ActiveCaption
        Label4.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label4.Location = New Point(79, 196)
        Label4.Name = "Label4"
        Label4.Size = New Size(128, 17)
        Label4.TabIndex = 9
        Label4.Text = "Date d'embauche  :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.ActiveCaption
        Label5.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label5.Location = New Point(79, 241)
        Label5.Name = "Label5"
        Label5.Size = New Size(50, 17)
        Label5.TabIndex = 10
        Label5.Text = "Poste :"
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Button2.Location = New Point(198, 335)
        Button2.Name = "Button2"
        Button2.Size = New Size(256, 23)
        Button2.TabIndex = 11
        Button2.Text = "Enregistrer les informations"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = SystemColors.ActiveCaption
        Label6.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label6.Location = New Point(79, 289)
        Label6.Name = "Label6"
        Label6.Size = New Size(34, 17)
        Label6.TabIndex = 13
        Label6.Text = "Tel :"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Directeur", "Coach sportif", "Instructeur de fitness", "Nutritionniste sportif", "Réceptionniste", "Agent de sécurité", "Technicien d'installations sportives", "nettoyeur/nettoyeuse"})
        ComboBox1.Location = New Point(231, 241)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 14
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(231, 190)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(200, 23)
        DateTimePicker1.TabIndex = 15
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Button3.Location = New Point(631, 42)
        Button3.Name = "Button3"
        Button3.Size = New Size(231, 29)
        Button3.TabIndex = 16
        Button3.Text = "L'affichage de tout les membres"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.image_2
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(893, 450)
        Controls.Add(Button3)
        Controls.Add(DateTimePicker1)
        Controls.Add(ComboBox1)
        Controls.Add(Label6)
        Controls.Add(Button2)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TextBox5)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Name = "Form5"
        Text = "but"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button3 As Button
End Class
