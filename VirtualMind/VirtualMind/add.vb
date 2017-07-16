Imports System.Windows.Forms

Public Class add

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Word-Dokument|*.doc"
        ofd.Multiselect = False

        If ofd.ShowDialog = DialogResult.OK Then
            TextBox3.Text = ofd.FileName

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "PDF|*.pdf"
        ofd.Multiselect = False

        If ofd.ShowDialog = DialogResult.OK Then
            TextBox4.Text = ofd.FileName

        End If
    End Sub
End Class
