Imports System.IO

Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f As New Form2
        f.Show()
        Me.Hide()
    End Sub
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fs As New FileStream("C:\Users\Rayen\Desktop\projet_peven\adherents.txt", FileMode.Open, FileAccess.Read)
        Dim sr As New StreamReader(fs)
        Dim s As String
        Dim t() As String
        While sr.Peek > -1
            s = sr.ReadLine()
            t = s.Split("#")
            DataGridView1.Rows.Add(t(0), t(1), t(2), --t(3), t(4))
        End While
        sr.Close()
        fs.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DataGridView1.CurrentRow.Cells(0).Value = TextBox1.Text
        DataGridView1.CurrentRow.Cells(1).Value = TextBox2.Text
        DataGridView1.CurrentRow.Cells(2).Value = TextBox3.Text
        DataGridView1.CurrentRow.Cells(3).Value = TextBox4.Text
        DataGridView1.CurrentRow.Cells(4).Value = TextBox5.Text
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        Dim path As String = "C:\Users\Rayen\Desktop\projet_peven\adherents.txt"

        Using writer As New StreamWriter(path, False)
            For Each row As DataGridViewRow In DataGridView1.Rows
                If Not row.IsNewRow Then

                    Dim ligne As String =
                    row.Cells(0).Value.ToString() & "#" &
                    row.Cells(1).Value.ToString() & "#" &
                    row.Cells(2).Value.ToString() & "#" &
                    row.Cells(3).Value.ToString() & "#" &
                    row.Cells(4).Value.ToString()

                    writer.WriteLine(ligne)
                End If
            Next
        End Using

        MessageBox.Show("Fichier mis à jour avec succès !")
    End Sub
End Class