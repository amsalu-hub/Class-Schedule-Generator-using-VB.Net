Public Class ViewSectionList
    Private section_no As String
    Private program As String
    Private accademic_year As String
    Private Response As String
    Private section As New Section
    Private Sub ViewSectionList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        section.LoadSection(lvSection, "select*from Section")
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Try
            If lvSection.Items.Count > 0 Then
                Dim editsection As New SectionRegistration
                editsection.cmbSchool.Text = lvSection.FocusedItem.SubItems(0).Text
                editsection.cmbxsec.Text = lvSection.FocusedItem.SubItems(1).Text
                editsection.cmbxprog.Text = lvSection.FocusedItem.SubItems(2).Text
                editsection.cmbxacyr.Text = lvSection.FocusedItem.SubItems(3).Text
                editsection.txtRepName.Text = lvSection.FocusedItem.SubItems(4).Text
                editsection.txtRepPhone.Text = lvSection.FocusedItem.SubItems(5).Text
                editsection.txtRepEmail.Text = lvSection.FocusedItem.SubItems(6).Text
                editsection.ShowDialog()
            Else
                MessageBox.Show("No items to be edited!!", "No items", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If lvSection.Items.Count > 0 Then
                Response = MessageBox.Show("You are about to delete one record." + vbNewLine + "Are you sure you want to permanently delete this record?", "Scheduler", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString
                If Response = "Yes" Then
                    If section.delete(section_no, accademic_year, program) Then
                        MessageBox.Show("Record deleted successfully!", "Scheduler", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        section.LoadSection(lvSection, "select*from Section")
                    End If
                End If
            Else
                MessageBox.Show("No items to be deleted!!", "No items", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Try
            lvSection.Items.Clear()
            section.LoadSection(lvSection, "select*from Section")
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class