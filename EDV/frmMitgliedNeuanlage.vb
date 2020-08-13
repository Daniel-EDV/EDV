Public Class frmMitgliedNeuanlage
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        'Feldprüfungen
        'Ist der Name mit mindestens zwei Zeichen gefüllt und enthält vorne und hinten keine Leerzeichen?
        If txtName.Text.Trim.Length < 2 Then
            MessageBox.Show("Der Name ist zu kurz.", "Eingabeprüfung",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        'Ist das Geburtsdatum frühestens heute?
        If dtpGeburt.Value > Now() Then
            MessageBox.Show("Anmeldung ist erst nach Geburt möglich.", "Eingabeprüfung",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        'Ist das Eintrittsdatum mindestens so groß wie das Geburtsdatum?
        If calEintritt.SelectionStart.ToShortDateString < dtpGeburt.Value.ToShortDateString Then
            MessageBox.Show("Eintritt ist erst ab Geburt möglich.", "Eingabeprüfung",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim dbsMitglieder As New clsDatabase
        Dim datMitglieder As New DataTable

        If Not dbsMitglieder.readData("Select * FROM tblMitglieder WHERE false") Then
            Stop
        Else
            'Übernahme der Struktur und anlegen einer Leerzeile
            datMitglieder = dbsMitglieder.getTable
            datMitglieder.Rows.Add()

            'Übernahme der Formularwerte
            datMitglieder.Rows(0).Item("txtName") = txtName.Text
            datMitglieder.Rows(0).Item("datGeburt") = dtpGeburt.Value.ToShortDateString
            datMitglieder.Rows(0).Item("datEintritt") = calEintritt.SelectionStart.ToShortDateString
            datMitglieder.Rows(0).Item("fkyBeitragsklasse") = cmbKlasse.SelectedValue

            'Speichern
            dbsMitglieder.saveTable(datMitglieder)
            'Schließen
            Me.Dispose()

        End If

        'Hier muss noch die Sparte gespeichert werden
        If cmbKlasse.SelectedValue <> 3 Then
            Dim dbsMitgliedID As New clsDatabase
            Dim dbsMGSparten As New clsDatabase
        Dim datMGSparten As New DataTable

        If Not dbsMitgliedID.readData("Select MAX (pkyMitglied) as ID FROM tblMitglieder") Then
            Stop
        Else
                'Die MitgliedsID steht nun in dbsMitgliedID.getTable.Rows().Item("ID")
                If Not dbsMGSparten.readData("Select * FROM tblMitgliederSparten WHERE false") Then
                    Stop
                Else
                    'Übernahme der Struktur und anlegen einer Leerzeile
                    datMGSparten = dbsMGSparten.getTable
                    datMGSparten.Rows.Add()

                    'Übernahme der Werte
                    datMGSparten.Rows(0).Item("fkyMitglied") = dbsMitgliedID.getTable.Rows(0).Item("ID")
                    datMGSparten.Rows(0).Item("fkySparte") = cmbSparte.SelectedValue

                    'Speichern
                    dbsMGSparten.saveTable(datMGSparten)
                End If
            End If
        End If
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click

        If vbYes = MessageBox.Show("Sind Sie sicher?", "Abbrechen",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
            Me.Dispose()
        End If
    End Sub

    Private Sub frmMitgliedNeuanlage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        End If
        Dim dbsSparte As New clsDatabase
        If Not dbsSparte.readData("Select * FROM tblSparten") Then
            Stop
        Else
            'Angezeigter Wert
            cmbSparte.DisplayMember = "pkySparte"
            'Zurückzugebene ID
            cmbSparte.ValueMember = "pkySparte"
            'Datenübergabe
            cmbSparte.DataSource = dbsSparte.getTable
            'Nur gültige Werte, keine freie Eingabe zulassen
            cmbSparte.DropDownStyle = ComboBoxStyle.DropDownList
        End If


    End Sub

    Private Sub cmbSparte_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSparte.SelectedIndexChanged
        loadDGV
    End Sub
    Private Sub loadDGV()

    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        loadDGV()
    End Sub

    Private Sub cmbKlasse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbKlasse.SelectedIndexChanged

    End Sub
End Class