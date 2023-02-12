Public Class SectionRegistration
    Private section As New Section
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If cmbxprog.Text = "" Or cmbxacyr.Text = "" Or cmbxsec.Text = "" Or txtRepEmail.Text = "" Or txtRepName.Text = "" Or txtRepPhone.Text = "" Then
                MessageBox.Show("Empty fields not allowed!!", "Scheduler", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Else
                section.School = cmbSchool.Text
                section.Section = cmbxsec.Text
                section.Program = cmbxprog.Text
                section.Accademic_year = cmbxacyr.Text
                section.Rep_email = txtRepEmail.Text
                section.Rep_name = txtRepName.Text
                section.Rep_phone = txtRepPhone.Text
                If section.save(section) Then
                    MessageBox.Show("Section data successfully saved!", "Scheduler", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class