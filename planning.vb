Public Class planning
    Dim lignes() As String

    Function HeureValide(texte As String) As Boolean
        Dim t() As String = texte.Split("-"c)

        If t.Length <> 2 Then Return False

        Dim debut As DateTime
        Dim fin As DateTime

        If Not DateTime.TryParse(t(0).Trim(), debut) Then Return False
        If Not DateTime.TryParse(t(1).Trim(), fin) Then Return False

        If fin <= debut Then Return False

        Return True
    End Function


    Private Sub planning_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim chemin As String = "C:\Users\Rayen\Desktop\projet_peven\membres.txt"

        lignes = System.IO.File.ReadAllLines("C:\Users\Rayen\Desktop\projet_peven\membres.txt")

        ComboBox1.Items.Clear()

        For Each ligne As String In lignes
            Dim champs() As String = ligne.Split("#"c)
            ComboBox1.Items.Add(champs(1) & " " & champs(2))
        Next
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) _
Handles ComboBox1.SelectedIndexChanged

        Dim index As Integer = ComboBox1.SelectedIndex
        Dim champs() As String = lignes(index).Split("#"c)

        TextBox2.Text = champs(4) ' Activité
    End Sub

End Class