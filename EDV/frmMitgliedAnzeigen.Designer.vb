<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMitgliedAnzeigen
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
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.calEintritt = New System.Windows.Forms.MonthCalendar()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.dtpGeburt = New System.Windows.Forms.DateTimePicker()
        Me.cmbKlasse = New System.Windows.Forms.ComboBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblGeburt = New System.Windows.Forms.Label()
        Me.lblEintritt = New System.Windows.Forms.Label()
        Me.lblKlasse = New System.Windows.Forms.Label()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.dgvSparten = New System.Windows.Forms.DataGridView()
        CType(Me.dgvSparten, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(232, 92)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(196, 30)
        Me.txtID.TabIndex = 0
        '
        'calEintritt
        '
        Me.calEintritt.Location = New System.Drawing.Point(232, 222)
        Me.calEintritt.Name = "calEintritt"
        Me.calEintritt.TabIndex = 1
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(232, 134)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 30)
        Me.txtName.TabIndex = 2
        '
        'dtpGeburt
        '
        Me.dtpGeburt.Location = New System.Drawing.Point(232, 171)
        Me.dtpGeburt.Name = "dtpGeburt"
        Me.dtpGeburt.Size = New System.Drawing.Size(392, 30)
        Me.dtpGeburt.TabIndex = 4
        '
        'cmbKlasse
        '
        Me.cmbKlasse.FormattingEnabled = True
        Me.cmbKlasse.Location = New System.Drawing.Point(232, 471)
        Me.cmbKlasse.Name = "cmbKlasse"
        Me.cmbKlasse.Size = New System.Drawing.Size(121, 33)
        Me.cmbKlasse.TabIndex = 5
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(54, 97)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(60, 25)
        Me.lblID.TabIndex = 7
        Me.lblID.Text = "MgNr"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(54, 134)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(64, 25)
        Me.lblName.TabIndex = 8
        Me.lblName.Text = "Name"
        '
        'lblGeburt
        '
        Me.lblGeburt.AutoSize = True
        Me.lblGeburt.Location = New System.Drawing.Point(54, 171)
        Me.lblGeburt.Name = "lblGeburt"
        Me.lblGeburt.Size = New System.Drawing.Size(71, 25)
        Me.lblGeburt.TabIndex = 9
        Me.lblGeburt.Text = "Geburt"
        '
        'lblEintritt
        '
        Me.lblEintritt.AutoSize = True
        Me.lblEintritt.Location = New System.Drawing.Point(54, 222)
        Me.lblEintritt.Name = "lblEintritt"
        Me.lblEintritt.Size = New System.Drawing.Size(65, 25)
        Me.lblEintritt.TabIndex = 10
        Me.lblEintritt.Text = "Eintritt"
        '
        'lblKlasse
        '
        Me.lblKlasse.AutoSize = True
        Me.lblKlasse.Location = New System.Drawing.Point(54, 479)
        Me.lblKlasse.Name = "lblKlasse"
        Me.lblKlasse.Size = New System.Drawing.Size(139, 25)
        Me.lblKlasse.TabIndex = 11
        Me.lblKlasse.Text = "Beitragsklasse"
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(661, 493)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(154, 79)
        Me.btnQuit.TabIndex = 12
        Me.btnQuit.Text = "Schließen"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'dgvSparten
        '
        Me.dgvSparten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSparten.Location = New System.Drawing.Point(649, 104)
        Me.dgvSparten.Name = "dgvSparten"
        Me.dgvSparten.RowHeadersWidth = 51
        Me.dgvSparten.RowTemplate.Height = 24
        Me.dgvSparten.Size = New System.Drawing.Size(503, 325)
        Me.dgvSparten.TabIndex = 13
        '
        'frmMitgliedAnzeigen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1225, 703)
        Me.Controls.Add(Me.dgvSparten)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.lblKlasse)
        Me.Controls.Add(Me.lblEintritt)
        Me.Controls.Add(Me.lblGeburt)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.cmbKlasse)
        Me.Controls.Add(Me.dtpGeburt)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.calEintritt)
        Me.Controls.Add(Me.txtID)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMitgliedAnzeigen"
        Me.Text = "Mitglied anzeigen"
        CType(Me.dgvSparten, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtID As TextBox
    Friend WithEvents calEintritt As MonthCalendar
    Friend WithEvents txtName As TextBox
    Friend WithEvents dtpGeburt As DateTimePicker
    Friend WithEvents cmbKlasse As ComboBox
    Friend WithEvents lblID As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblGeburt As Label
    Friend WithEvents lblEintritt As Label
    Friend WithEvents lblKlasse As Label
    Friend WithEvents btnQuit As Button
    Friend WithEvents dgvSparten As DataGridView
End Class
