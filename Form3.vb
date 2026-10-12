Imports System.IO

Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fs As New FileStream("C:\Users\Rayen\Desktop\projet_peven\adherents.txt", FileMode.Open, FileAccess.Read)
        Dim sr As New StreamReader(fs)
        Dim s As String
        Dim t() As String
        While sr.Peek > -1
            s = sr.ReadLine()
            t = s.Split("#")
            DataGridView1.Rows.Add(t(0), t(1), t(2), t(3), t(4))
        End While
        sr.Close()
        fs.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        For i As Integer = DataGridView1.SelectedRows.Count - 1 To 0 Step -1
            DataGridView1.Rows.RemoveAt(DataGridView1.SelectedRows(i).Index)
        Next

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


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim f As New Form2
        f.Show()
        Me.Hide()
    End Sub
End Class