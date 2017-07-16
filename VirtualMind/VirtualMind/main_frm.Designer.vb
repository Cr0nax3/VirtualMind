<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main_frm
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EndToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EinstellungenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuchenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BearbeitenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LöschenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuchenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EinstellungenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MySQLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerellToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.datagrid = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.datagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem, Me.EinstellungenToolStripMenuItem, Me.EinstellungenToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(755, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DateiToolStripMenuItem
        '
        Me.DateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.SaveToolStripMenuItem1, Me.EndToolStripMenuItem})
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.DateiToolStripMenuItem.Text = "Datei"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.SaveToolStripMenuItem.Text = "Aktualisieren"
        '
        'SaveToolStripMenuItem1
        '
        Me.SaveToolStripMenuItem1.Name = "SaveToolStripMenuItem1"
        Me.SaveToolStripMenuItem1.Size = New System.Drawing.Size(142, 22)
        Me.SaveToolStripMenuItem1.Text = "Speichern"
        '
        'EndToolStripMenuItem
        '
        Me.EndToolStripMenuItem.Name = "EndToolStripMenuItem"
        Me.EndToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.EndToolStripMenuItem.Text = "Beenden"
        '
        'EinstellungenToolStripMenuItem
        '
        Me.EinstellungenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SuchenToolStripMenuItem, Me.BearbeitenToolStripMenuItem, Me.LöschenToolStripMenuItem, Me.SuchenToolStripMenuItem1})
        Me.EinstellungenToolStripMenuItem.Name = "EinstellungenToolStripMenuItem"
        Me.EinstellungenToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.EinstellungenToolStripMenuItem.Text = "Liste"
        '
        'SuchenToolStripMenuItem
        '
        Me.SuchenToolStripMenuItem.Name = "SuchenToolStripMenuItem"
        Me.SuchenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SuchenToolStripMenuItem.Text = "Hinzufügen"
        '
        'BearbeitenToolStripMenuItem
        '
        Me.BearbeitenToolStripMenuItem.Name = "BearbeitenToolStripMenuItem"
        Me.BearbeitenToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.BearbeitenToolStripMenuItem.Text = "Bearbeiten"
        '
        'LöschenToolStripMenuItem
        '
        Me.LöschenToolStripMenuItem.Name = "LöschenToolStripMenuItem"
        Me.LöschenToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.LöschenToolStripMenuItem.Text = "Löschen"
        '
        'SuchenToolStripMenuItem1
        '
        Me.SuchenToolStripMenuItem1.Name = "SuchenToolStripMenuItem1"
        Me.SuchenToolStripMenuItem1.Size = New System.Drawing.Size(136, 22)
        Me.SuchenToolStripMenuItem1.Text = "Suchen..."
        '
        'EinstellungenToolStripMenuItem1
        '
        Me.EinstellungenToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MySQLToolStripMenuItem, Me.GenerellToolStripMenuItem})
        Me.EinstellungenToolStripMenuItem1.Name = "EinstellungenToolStripMenuItem1"
        Me.EinstellungenToolStripMenuItem1.Size = New System.Drawing.Size(90, 20)
        Me.EinstellungenToolStripMenuItem1.Text = "Einstellungen"
        '
        'MySQLToolStripMenuItem
        '
        Me.MySQLToolStripMenuItem.Name = "MySQLToolStripMenuItem"
        Me.MySQLToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MySQLToolStripMenuItem.Text = "MySQL"
        '
        'GenerellToolStripMenuItem
        '
        Me.GenerellToolStripMenuItem.Name = "GenerellToolStripMenuItem"
        Me.GenerellToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.GenerellToolStripMenuItem.Text = "Generell"
        '
        'datagrid
        '
        Me.datagrid.AllowUserToAddRows = False
        Me.datagrid.AllowUserToDeleteRows = False
        Me.datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagrid.ColumnHeadersVisible = False
        Me.datagrid.Location = New System.Drawing.Point(0, 27)
        Me.datagrid.Name = "datagrid"
        Me.datagrid.ReadOnly = True
        Me.datagrid.Size = New System.Drawing.Size(806, 478)
        Me.datagrid.TabIndex = 1
        '
        'main_frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 505)
        Me.Controls.Add(Me.datagrid)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "main_frm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VirtualMind v.1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.datagrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DateiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EndToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents datagrid As DataGridView
    Friend WithEvents EinstellungenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SuchenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EinstellungenToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents BearbeitenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LöschenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SuchenToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MySQLToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GenerellToolStripMenuItem As ToolStripMenuItem
End Class
