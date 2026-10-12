<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveCaption
        Button1.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        Button1.Location = New Point(24, 50)
        Button1.Name = "Button1"
        Button1.Size = New Size(303, 37)
        Button1.TabIndex = 0
        Button1.Text = "Gestion des abonnés"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        Button2.Location = New Point(24, 106)
        Button2.Name = "Button2"
        Button2.Size = New Size(303, 37)
        Button2.TabIndex = 1
        Button2.Text = "Gestion des membres du staff"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(24, 162)
        Button3.Name = "Button3"
        Button3.Size = New Size(303, 38)
        Button3.TabIndex = 2
        Button3.Text = "Gestion des activités sportives"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        Button4.Location = New Point(24, 216)
        Button4.Name = "Button4"
        Button4.Size = New Size(303, 35)
        Button4.TabIndex = 3
        Button4.Text = "Gestion des planning"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        Button5.Location = New Point(24, 270)
        Button5.Name = "Button5"
        Button5.Size = New Size(416, 38)
        Button5.TabIndex = 4
        Button5.Text = "Gestion des abonnements/paiements"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold Or FontStyle.Italic)
        Button6.Location = New Point(653, 361)
        Button6.Name = "Button6"
        Button6.Size = New Size(216, 35)
        Button6.TabIndex = 5
        Button6.Text = "Quitter"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ActiveBorder
        Label1.Font = New Font("Stencil", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(383, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(191, 38)
        Label1.TabIndex = 6
        Label1.Text = "BIENVENUE"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        BackgroundImage = My.Resources.Resources.image_4
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(881, 450)
        Controls.Add(Label1)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Label1 As Label

End Class
