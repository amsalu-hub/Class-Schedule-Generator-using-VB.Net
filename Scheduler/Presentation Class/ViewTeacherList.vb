Public Class ViewTeacherList
    Private Teacher_id As String
    Private Response As String
    Private teacher As New Teacher
    Private editteacher As New TeacherRegistration
    Private Sub ViewTeacherList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        teacher.LoadTeacher(lvTeacher, "select*from Teacher")
        If lvTeacher.Items.Count > 0 Then
            Teacher_id = lvTeacher.Items(lvTeacher.FocusedItem.Index).SubItems(0).Text
        End If
        TeacherRegistration.btnSave.Text = "Save Changes"
        TeacherRegistration.btnSave.Width = 80
        TeacherRegistration.btnSave.Height = 23
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Try
            If lvTeacher.Items.Count > 0 Then
                editteacher.txtTeacherID.Text = lvTeacher.FocusedItem.SubItems(0).Text
                editteacher.txtFname.Text = lvTeacher.FocusedItem.SubItems(1).Text
                editteacher.txtLname.Text = lvTeacher.FocusedItem.SubItems(2).Text
                editteacher.txtBlockNo.Text = lvTeacher.FocusedItem.SubItems(3).Text
                editteacher.txtFloorNo.Text = lvTeacher.FocusedItem.SubItems(4).Text
                editteacher.txtOfficeNo.Text = lvTeacher.FocusedItem.SubItems(5).Text
                editteacher.txtPhone.Text = lvTeacher.FocusedItem.SubItems(6).Text
                editteacher.txtEmail.Text = lvTeacher.FocusedItem.SubItems(7).Text
                editteacher.ShowDialog()
            Else
                MessageBox.Show("No items to be edited!!", "No items", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If lvTeacher.Items.Count > 0 Then
                Response = MessageBox.Show("You are about to delete one record." + vbNewLine + "Are you sure you want to permanently delete this record?", "Scheduler", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString
                If Response = "Yes" Then
                    If teacher.delete(Teacher_id) Then
                        MessageBox.Show("Record deleted successfully!", "Scheduler", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        teacher.LoadTeacher(lvTeacher, "select*from Teacher")
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
            lvTeacher.Items.Clear()
            teacher.LoadTeacher(lvTeacher, "select*from Teacher")
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class