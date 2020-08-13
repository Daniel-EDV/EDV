<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMitgliedNeuanlage
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
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.dtpGeburt = New System.Windows.Forms.DateTimePicker()
        Me.calEintritt = New System.Windows.Forms.MonthCalendar()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbKlasse = New System.Windows.Forms.ComboBox()
        Me.cmbSparte = New System.Windows.Forms.ComboBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Label1.Location = New System.Drawing.Point(127, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Label2.Location = New System.Drawing.Point(127, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Geburt"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Label3.Location = New System.Drawing.Point(127, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Eintritt"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(307, 32)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(239, 30)
        Me.txtName.TabIndex = 3
        '
        'dtpGeburt
        '
        Me.dtpGeburt.Location = New System.Drawing.Point(307, 94)
        Me.dtpGeburt.Name = "dtpGeburt"
        Me.dtpGeburt.Size = New System.Drawing.Size(321, 30)
        Me.dtpGeburt.TabIndex = 4
        '
        'calEintritt
        '
        Me.calEintritt.Location = New System.Drawing.Point(307, 156)
        Me.calEintritt.Name = "calEintritt"
        Me.calEintritt.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Label4.Location = New System.Drawing.Point(127, 380)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Beitragsklasse"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Label5.Location = New System.Drawing.Point(127, 431)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 25)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Sparte"
        '
        'cmbKlasse
        '
        Me.cmbKlasse.FormattingEnabled = True
        Me.cmbKlasse.Location = New System.Drawing.Point(307, 380)
        Me.cmbKlasse.Name = "cmbKlasse"
        Me.cmbKlasse.Size = New System.Drawing.Size(239, 33)
        Me.cmbKlasse.TabIndex = 8
        '
        'cmbSparte
        '
        Me.cmbSparte.FormattingEnabled = True
        Me.cmbSparte.Location = New System.Drawing.Point(307, 423)
        Me.cmbSparte.Name = "cmbSparte"
        Me.cmbSparte.Size = New System.Drawing.Size(239, 33)
        Me.cmbSparte.TabIndex = 9
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnAdd.Location = New System.Drawing.Point(132, 484)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(158, 60)
        Me.btnAdd.TabIndex = 10
        Me.btnAdd.Text = "Anlegen"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnQuit
        '
        Me.btnQuit.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnQuit.Location = New System.Drawing.Point(487, 484)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(158, 60)
        Me.btnQuit.TabIndex = 11
        Me.btnQuit.Text = "Abbrechen"
        Me.btnQuit.UseVisualStyleBackColor = False
        '
        'frmMitgliedNeuanlage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 703)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.cmbSparte)
        Me.Controls.Add(Me.cmbKlasse)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.calEintritt)
        Me.Controls.Add(Me.dtpGeburt)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "frmMitgliedNeuanlage"
        Me.Text = "Mitglied Neuanlage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents dtpGeburt As DateTimePicker
    Friend WithEvents calEintritt As MonthCalendar
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbKlasse As ComboBox
    Friend WithEvents cmbSparte As ComboBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnQuit As Button
End Class
