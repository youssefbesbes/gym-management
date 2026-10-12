Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form5
    Function verif1(a As String) As Boolean
        For i As Integer = 0 To a.Length - 1
            If Not (Char.IsLetter(a(i)) Or a(i) = " ") Then
                Return False
            End If
        Next
        Return True
    End Function
    Function verif2(a As String) As Boolean
        For i As Integer = 0 To a.Length - 1
            If Not Char.IsNumber(a(i)) Then
                Return False
            End If
        Next
        Return True
    End Function
    Function DateValide(d As Date) As Boolean
        Dim dateMin As Date = #1/1/1900#        ' 1er janvier 1900
        Dim dateMax As Date = Date.Today        ' Aujourd'hui

        If d < dateMin Or d > dateMax Then
            Return False
        Else
            Return True
        End If
    End Function

    Function VerifierNCIN(ncin As String) As Boolean
        If ncin.Length <> 8 Then Return False
        If Not IsNumeric(ncin) Then Return False
        If Not (ncin.StartsWith("0") Or ncin.StartsWith("1")) Then Return False
        Return True
    End Function





    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f As New Form1
        f.Show()
        Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If VerifierNCIN(TextBox1.Text) = False Then
            MsgBox("verifier votre ncin s'il vous plaît", MsgBoxStyle.Exclamation, "Attention")
        ElseIf TextBox2.Text = "" Or TextBox2.Text.Length > 20 Or verif1(TextBox2.Text) = False Then
            MsgBox("verifier votre nom s'il vous plaît", MsgBoxStyle.Exclamation, "Attention")
        ElseIf TextBox3.Text = "" Or TextBox3.Text.Length > 20 Or verif1(TextBox3.Text) = False Then
            MsgBox("verifier votre prenom s'il vous plaît", MsgBoxStyle.Exclamation, "Attention")
        ElseIf ComboBox1.SelectedIndex = -1 Then
            MsgBox("veuiller choisir votre poste", MsgBoxStyle.Exclamation, "Attention")
        ElseIf TextBox5.Text = "" Or TextBox5.Text.Length <> 8 Or verif2(TextBox5.Text) = False Then
            MsgBox("verifier votre numero s'il vous plaît", MsgBoxStyle.Exclamation, "Attention")
        Else
            Dim fs1 As New FileStream("C:\Users\Rayen\Desktop\projet_peven\membres.txt", FileMode.Open, FileAccess.Read)
            Dim sr As New StreamReader(fs1)
            Dim s As String
            Dim t() As String
            Dim trouve = 0

            While sr.Peek > -1
                s = sr.ReadLine
                t = s.Split("#")
                If t(0) = TextBox1.Text Then
                    trouve = 1

                End If
            End While
            sr.Close()
            fs1.Close()

            If trouve = 1 Then
                MsgBox("Impossible d'ajouter car l'etudiant existe deja", vbCritical, "attention")
            Else
                Dim fs As New FileStream("C:\Users\Rayen\Desktop\projet_peven\membres.txt", FileMode.Append, FileAccess.Write)
                Dim sw As New StreamWriter(fs)
                sw.WriteLine(TextBox1.Text + "#" + TextBox2.Text + "#" + TextBox3.Text + "#" + DateTimePicker1.Value.ToShortDateString + "#" + ComboBox1.SelectedItem + "#" + TextBox5.Text)
                MsgBox("l'enregisrement est fait avec succes", MsgBoxStyle.Information, "bien")
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox5.Text = ""
                sw.Close()
                fs.Close()

            End If
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim f As New Form6
        f.Show()
        Hide()
    End Sub
End Class