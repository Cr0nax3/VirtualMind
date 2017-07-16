Imports MySql.Data.MySqlClient
Public Class main_frm

    Private Sub main_frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadTable()
        Me.Size = New Size(datagrid.Width + 2, Me.Size.Height)
    End Sub

    Public Function loadTable() As Boolean
        Dim conn As New MySqlConnection
        conn.ConnectionString = "server=" & My.Settings.ip & ";userid=" & My.Settings.username & ";password=" & My.Settings.password & ";database=" & My.Settings.database
        Dim dataAdapter As New MySqlDataAdapter
        Dim dataTable As New DataTable
        Dim bindingSource As New BindingSource
        Dim command As MySqlCommand

        Try
            conn.Open()
            Dim query As String = "select * from virtualmind.entries"
            command = New MySqlCommand(query, conn)
            dataAdapter.SelectCommand = command
            dataAdapter.Fill(dataTable)
            bindingSource.DataSource = dataTable
            datagrid.DataSource = bindingSource
            dataAdapter.Update(dataTable)
            conn.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conn.Dispose()
        End Try
    End Function

    Public Function checkConnection(ByVal server As String, ByVal username As String, ByVal password As String, ByVal database As String) As Boolean
        Dim conn As MySqlConnection = New MySqlConnection
        conn.ConnectionString = "server=" & server & ";userid=" & username & ";password=" & password & ";database=" & database

        Try
            conn.Open()
            conn.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conn.Dispose()
        End Try
    End Function

    Private Sub EndToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EndToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub MySQLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MySQLToolStripMenuItem.Click
        settings.Show()
    End Sub

    Private Sub SuchenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SuchenToolStripMenuItem.Click
        add.Show()
    End Sub
End Class
