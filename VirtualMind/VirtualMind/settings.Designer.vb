<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class settings
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_check = New System.Windows.Forms.Button()
        Me.txtbox_server = New System.Windows.Forms.TextBox()
        Me.txtbox_username = New System.Windows.Forms.TextBox()
        Me.txtbox_password = New System.Windows.Forms.TextBox()
        Me.txtbox_database = New System.Windows.Forms.TextBox()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Server:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(0, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Username:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(2, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(2, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Database:"
        '
        'btn_check
        '
        Me.btn_check.Location = New System.Drawing.Point(3, 112)
        Me.btn_check.Name = "btn_check"
        Me.btn_check.Size = New System.Drawing.Size(280, 23)
        Me.btn_check.TabIndex = 4
        Me.btn_check.Text = "Check settings"
        Me.btn_check.UseVisualStyleBackColor = True
        '
        'txtbox_server
        '
        Me.txtbox_server.Location = New System.Drawing.Point(64, 6)
        Me.txtbox_server.Name = "txtbox_server"
        Me.txtbox_server.Size = New System.Drawing.Size(219, 20)
        Me.txtbox_server.TabIndex = 5
        '
        'txtbox_username
        '
        Me.txtbox_username.Location = New System.Drawing.Point(64, 30)
        Me.txtbox_username.Name = "txtbox_username"
        Me.txtbox_username.Size = New System.Drawing.Size(219, 20)
        Me.txtbox_username.TabIndex = 6
        '
        'txtbox_password
        '
        Me.txtbox_password.Location = New System.Drawing.Point(64, 56)
        Me.txtbox_password.Name = "txtbox_password"
        Me.txtbox_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtbox_password.Size = New System.Drawing.Size(219, 20)
        Me.txtbox_password.TabIndex = 7
        '
        'txtbox_database
        '
        Me.txtbox_database.Location = New System.Drawing.Point(64, 86)
        Me.txtbox_database.Name = "txtbox_database"
        Me.txtbox_database.Size = New System.Drawing.Size(219, 20)
        Me.txtbox_database.TabIndex = 8
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(3, 141)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(280, 23)
        Me.btn_save.TabIndex = 9
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(472, 373)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(472, 312)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 11
        '
        'settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(665, 413)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.txtbox_database)
        Me.Controls.Add(Me.txtbox_password)
        Me.Controls.Add(Me.txtbox_username)
        Me.Controls.Add(Me.txtbox_server)
        Me.Controls.Add(Me.btn_check)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "settings"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MySQL-Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_check As Button
    Friend WithEvents txtbox_server As TextBox
    Friend WithEvents txtbox_username As TextBox
    Friend WithEvents txtbox_password As TextBox
    Friend WithEvents txtbox_database As TextBox
    Friend WithEvents btn_save As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox5 As TextBox
End Class
