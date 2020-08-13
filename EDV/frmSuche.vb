Public Class frmSuche
    Private Sub frmSuche_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dbsKlasse As New clsDatabase
        If Not dbsKlasse.readData("Select * FROM tblBeitragsklassen") Then
            Stop
        Else
            cmbKlasse.DisplayMember = "txtBezeichnung"
            cmbKlasse.ValueMember = "pkyBeitragsklasse"
            cmbKlasse.DataSource = dbsKlasse.getTable
            cmbKlasse.DropDownStyle = ComboBoxStyle.DropDownList
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles dbsKlasse.Click
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Dispose()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNeuesMitglied.Click
        frmMitgliedNeuanlage.ShowDialog()
        loadDGV()
    End Sub

    Private Sub CmbKlasse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbKlasse.SelectedIndexChanged
        loadDGV
    End Sub

    Private Sub loadDGV()

        Dim dbsMitglieder As New clsDatabase
        Dim strRichtung As String
        If radASC.Checked Then
            strRichtung = "ASC"
        Else
            strRichtung = "DESC"
        End If
        If IsNothing(cmbKlasse.SelectedValue) Then Exit Sub

        If Not dbsMitglieder.readData("Select * FROM qryMitglieder Where fkyBeitragsklasse=" & cmbKlasse.SelectedValue &
                                                                    " AND txtName LIKE  '%" & txtName.Text & "%'" &
                                                                    " ORDER BY txtName " & strRichtung) Then
            Stop
        Else
            ' Datenübergabe
            dgvMitglieder.DataSource = dbsMitglieder.getTable
            'DGV vor Änderungen und Mehrfachauswahl schützen 
            'sowie Eingabezeile ausblenden
            dgvMitglieder.ReadOnly = True
            dgvMitglieder.AllowUserToAddRows = False
            dgvMitglieder.MultiSelect = False
            'Zeilenköpfe weg
            dgvMitglieder.RowHeadersVisible = False
            ' Spalten ausblenden
            dgvMitglieder.Columns("fkyBeitragsklasse").Visible = False
            dgvMitglieder.Columns("txtBezeichnung").Visible = False
            'Spaltentitel ändern
            dgvMitglieder.Columns("pkyMitglied").HeaderText = "MgNr"
            dgvMitglieder.Columns("txtName").HeaderText = "Name"
            dgvMitglieder.Columns("datGeburt").HeaderText = "Geburtsdatum"
            dgvMitglieder.Columns("datEintritt").HeaderText = "Eintrittsdatum"
            'Euro-Formatierung
            dgvMitglieder.Columns("dblBeitrag").HeaderText = "Beitrag"
            dgvMitglieder.Columns("dblBeitrag").DefaultCellStyle.Format = "C"
            dgvMitglieder.Columns("dblBeitrag").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            'Breite der Spalten und des DGV
            dgvMitglieder.Columns(5).Width = 150
            dgvMitglieder.Columns(5).Width = 0.2 * dgvMitglieder.Width
            dgvMitglieder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells

            'Wenn alles gerichtet ist, als Letztes die Spaltenbreite
            dgvMitglieder.AutoResizeColumns()
        End If
    End Sub
    Private Sub cmbName_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        loadDGV()
    End Sub

    Private Sub dgvMitglieder_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMitglieder.CellDoubleClick
        'Nicht reagieren, wenn die Titelseite geklickt wurde
        If e.RowIndex > -1 Then
            'Laden des Mitglied ins Unterformular und öffnen
            frmMitgliedAnzeigen.txtID.Text = dgvMitglieder.Rows(e.RowIndex).Cells(0).Value
            frmMitgliedAnzeigen.ShowDialog()
        End If
    End Sub

    Private Sub dgvMitglieder_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMitglieder.CellContentClick

    End Sub

    Private Sub radASC_CheckedChanged(sender As Object, e As EventArgs) Handles radASC.CheckedChanged
        loadDGV()
    End Sub

    Private Sub radDESC_CheckedChanged(sender As Object, e As EventArgs) Handles radDESC.CheckedChanged
        loadDGV()
    End Sub
End Class
