Public Class frmMitgliedAnzeigen
    Private dbsgMitglied As New clsDatabase
    Private datgMitglied As New DataTable

    Private dbsgSparten As New clsDatabase
    Private datgSparten As New DataTable
    Private Sub frmMitgliedAnzeigen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dbsKlasse As New clsDatabase
        If Not dbsKlasse.readData("Select * FROM tblBeitragsklassen") Then
            Stop
        Else
            'Angezeigter Wert
            cmbKlasse.DisplayMember = "txtBezeichnung"
            'Zurückzugebene ID
            cmbKlasse.ValueMember = "pkyBeitragsklasse"
            'Datenübergabe
            cmbKlasse.DataSource = dbsKlasse.getTable
            'Nur gültige Werte, keine freie Eingabe zulassen
            cmbKlasse.DropDownStyle = ComboBoxStyle.DropDownList
            ' Laden der Beitragsklasse des aktuellen Mitglieds
            cmbKlasse.SelectedValue = datgMitglied.Rows(0).Item("fkyBeitragsklasse")
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged
        Dim dbsKlasse As New clsDatabase
        If Not dbsgMitglied.readData("Select * FROM tblMitglieder WHERE pkyMitglied = " & txtID.Text) Then
            Stop
        Else
            'Datenübergabe
            datgMitglied = dbsgMitglied.getTable

            'Felder füllen
            txtName.Text = datgMitglied.Rows(0).Item("txtName")
            dtpGeburt.Text = datgMitglied.Rows(0).Item("datGeburt")
            calEintritt.SetDate(datgMitglied.Rows(0).Item("datEintritt"))
            'Sparten zum Mitglied 
            If Not dbsgSparten.readData("Select * FROM qryMitgliederSparten WHERE fkyMitglied = " & txtID.Text) Then
                Stop
            Else
                'Datenübergabe: Merken im Table und Anzeigen im DGV
                datgSparten = dbsgSparten.getTable
                dgvSparten.DataSource = datgSparten
                'Aufhübschen
                dgvSparten.AllowUserToAddRows = False
                dgvSparten.ReadOnly = True
                dgvSparten.RowHeadersVisible = False

                dgvSparten.Columns("fkyMitglied").Visible = False
                dgvSparten.Columns("fkySparte").HeaderText = "Sparte"
                dgvSparten.Columns("datSparteneintritt").HeaderText = "Eintritt"
                'Spaltentitel ändern
                dgvSparten.Columns("txtTelefon").HeaderText = "Telefon"
                dgvSparten.Columns("dblBudget").HeaderText = "Budget"
                dgvSparten.Columns("AnzahlvonfkyMitglied").HeaderText = "Mitglieder"
                'Euro-Formatierung
                dgvSparten.Columns("dblBudget").DefaultCellStyle.Format = "C"
                dgvSparten.Columns("txtTelefon").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvSparten.Columns("AnzahlvonfkyMitglied").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                'Spaltenbreite 
                dgvSparten.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                dgvSparten.AutoResizeColumns()
            End If
        End If
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Dispose()
    End Sub

    Private Sub dgvSparten_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSparten.CellContentClick
    End Sub
End Class