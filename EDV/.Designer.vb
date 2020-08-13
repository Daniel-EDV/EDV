<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSuche
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
        Me.btnNeuesMitglied = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.dbsKlasse = New System.Windows.Forms.Label()
        Me.dgvMitglieder = New System.Windows.Forms.DataGridView()
        Me.cmbKlasse = New System.Windows.Forms.ComboBox()
        Me.dbsName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.grpSortierung = New System.Windows.Forms.GroupBox()
        Me.radDESC = New System.Windows.Forms.RadioButton()
        Me.radASC = New System.Windows.Forms.RadioButton()
        CType(Me.dgvMitglieder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSortierung.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnNeuesMitglied
        '
        Me.btnNeuesMitglied.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnNeuesMitglied.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNeuesMitglied.ForeColor = System.Drawing.SystemColors.InfoText
        Me.btnNeuesMitglied.Location = New System.Drawing.Point(110, 580)
        Me.btnNeuesMitglied.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnNeuesMitglied.Name = "btnNeuesMitglied"
        Me.btnNeuesMitglied.Size = New System.Drawing.Size(180, 89)
        Me.btnNeuesMitglied.TabIndex = 0
        Me.btnNeuesMitglied.Text = "Neues Mitglied"
        Me.btnNeuesMitglied.UseVisualStyleBackColor = False
        '
        'btnQuit
        '
        Me.btnQuit.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnQuit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.ForeColor = System.Drawing.SystemColors.InfoText
        Me.btnQuit.Location = New System.Drawing.Point(759, 580)
        Me.btnQuit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(177, 89)
        Me.btnQuit.TabIndex = 1
        Me.btnQuit.Text = "Beenden"
        Me.btnQuit.UseVisualStyleBackColor = False
        '
        'dbsKlasse
        '
        Me.dbsKlasse.AutoSize = True
        Me.dbsKlasse.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.dbsKlasse.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dbsKlasse.ForeColor = System.Drawing.SystemColors.InfoText
        Me.dbsKlasse.Location = New System.Drawing.Point(107, 91)
        Me.dbsKlasse.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.dbsKlasse.Name = "dbsKlasse"
        Me.dbsKlasse.Size = New System.Drawing.Size(139, 23)
        Me.dbsKlasse.TabIndex = 2
        Me.dbsKlasse.Text = "Beitragsklasse"
        '
        'dgvMitglieder
        '
        Me.dgvMitglieder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMitglieder.Location = New System.Drawing.Point(110, 147)
        Me.dgvMitglieder.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvMitglieder.Name = "dgvMitglieder"
        Me.dgvMitglieder.RowHeadersWidth = 51
        Me.dgvMitglieder.RowTemplate.Height = 24
        Me.dgvMitglieder.Size = New System.Drawing.Size(826, 423)
        Me.dgvMitglieder.TabIndex = 3
        '
        'cmbKlasse
        '
        Me.cmbKlasse.BackColor = System.Drawing.SystemColors.HighlightText
        Me.cmbKlasse.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbKlasse.ForeColor = System.Drawing.SystemColors.InfoText
        Me.cmbKlasse.FormattingEnabled = True
        Me.cmbKlasse.Location = New System.Drawing.Point(290, 33)
        Me.cmbKlasse.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbKlasse.Name = "cmbKlasse"
        Me.cmbKlasse.Size = New System.Drawing.Size(376, 24)
        Me.cmbKlasse.TabIndex = 4
        '
        'dbsName
        '
        Me.dbsName.AutoSize = True
        Me.dbsName.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.dbsName.Location = New System.Drawing.Point(105, 33)
        Me.dbsName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.dbsName.Name = "dbsName"
        Me.dbsName.Size = New System.Drawing.Size(64, 25)
        Me.dbsName.TabIndex = 5
        Me.dbsName.Text = "Name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(290, 81)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(376, 30)
        Me.txtName.TabIndex = 6
        '
        'grpSortierung
        '
        Me.grpSortierung.Controls.Add(Me.radDESC)
        Me.grpSortierung.Controls.Add(Me.radASC)
        Me.grpSortierung.Location = New System.Drawing.Point(710, 19)
        Me.grpSortierung.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpSortierung.Name = "grpSortierung"
        Me.grpSortierung.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpSortierung.Size = New System.Drawing.Size(300, 105)
        Me.grpSortierung.TabIndex = 7
        Me.grpSortierung.TabStop = False
        '
        'radDESC
        '
        Me.radDESC.AutoSize = True
        Me.radDESC.Location = New System.Drawing.Point(9, 62)
        Me.radDESC.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.radDESC.Name = "radDESC"
        Me.radDESC.Size = New System.Drawing.Size(129, 29)
        Me.radDESC.TabIndex = 1
        Me.radDESC.Text = "absteigend"
        Me.radDESC.UseVisualStyleBackColor = True
        '
        'radASC
        '
        Me.radASC.AutoSize = True
        Me.radASC.Checked = True
        Me.radASC.Location = New System.Drawing.Point(9, 19)
        Me.radASC.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.radASC.Name = "radASC"
        Me.radASC.Size = New System.Drawing.Size(134, 29)
        Me.radASC.TabIndex = 0
        Me.radASC.TabStop = True
        Me.radASC.Text = "aufsteigend"
        Me.radASC.UseVisualStyleBackColor = True
        '
        'frmSuche
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 703)
        Me.ControlBox = False
        Me.Controls.Add(Me.grpSortierung)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.dbsName)
        Me.Controls.Add(Me.cmbKlasse)
        Me.Controls.Add(Me.dgvMitglieder)
        Me.Controls.Add(Me.dbsKlasse)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnNeuesMitglied)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSuche"
        Me.Text = "Mitgliedssuche"
        CType(Me.dgvMitglieder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSortierung.ResumeLayout(False)
        Me.grpSortierung.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNeuesMitglied As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents dbsKlasse As Label
    Friend WithEvents dgvMitglieder As DataGridView
    Friend WithEvents cmbKlasse As ComboBox
    Friend WithEvents dbsName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents grpSortierung As GroupBox
    Friend WithEvents radDESC As RadioButton
    Friend WithEvents radASC As RadioButton
End Class
