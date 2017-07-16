Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class settings

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_check.Click
        If main_frm.checkConnection(txtbox_server.Text, txtbox_username.Text, txtbox_password.Text, txtbox_database.Text) Then
            MsgBox("Valid settings!", MsgBoxStyle.Information)
        Else
            MsgBox("Invalid settings or no internet connection!", MsgBoxStyle.Exclamation)
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            My.Settings.ip = txtbox_server.Text
            My.Settings.username = txtbox_username.Text
            My.Settings.password = txtbox_password.Text
            My.Settings.database = txtbox_database.Text
            MsgBox("Settings saved succesfully!", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Failed to save settings!", MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Private Sub settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtbox_server.Text = My.Settings.ip
        txtbox_username.Text = My.Settings.username
        txtbox_password.Text = My.Settings.password
        txtbox_database.Text = My.Settings.database
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim conn As New MySqlConnection
        conn.ConnectionString = "server=" & My.Settings.ip & ";userid=" & My.Settings.username & ";password=" & My.Settings.password & ";database=" & My.Settings.database
        Dim command As MySqlCommand
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim query As String = "DELETE FROM entries WHERE Linkdoc='" & TextBox5.Text & "';"
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            conn.Dispose()
        End Try
    End Sub
End Class
