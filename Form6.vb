Imports System.IO

Public Class Form6
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fs As New FileStream("C:\Users\Rayen\Desktop\projet_peven\membres.txt", FileMode.Open, FileAccess.Read)
        Dim sr As New StreamReader(fs)
        Dim s As String
        Dim t() As String
        While sr.Peek > -1
            s = sr.ReadLine()
            t = s.Split("#")
            DataGridView1.Rows.Add(t(0), t(1), t(2), t(3), t(4), t(5))
        End While
        sr.Close()
        fs.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f As New Form5
        f.Show()
        Me.Hide()

    End Sub
End Class