Public Class ViewCourseList
    Private coursecode As String
    Private response As String
    Private course As New Course
    Private Sub ViewCourseList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        course.LoadCourse(lvCourse, "select*from Course")
        If lvCourse.Items.Count > 0 Then
            coursecode = lvCourse.Items(lvCourse.FocusedItem.Index).SubItems(0).Text
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Try
            If lvCourse.Items.Count > 0 Then
                Dim editcourse As New CourseRegistration
                editcourse.txtcid.Text = lvCourse.FocusedItem.SubItems(0).Text
                editcourse.txtTitle.Text = lvCourse.FocusedItem.SubItems(1).Text
                editcourse.txtECTS.Text = Integer.Parse(lvCourse.FocusedItem.SubItems(2).Text)
                editcourse.txtCrhr.Text = lvCourse.FocusedItem.SubItems(2).Text
                editcourse.cmbReqLab.Text = lvCourse.FocusedItem.SubItems(3).Text
                editcourse.cmbProgram.Text = lvCourse.FocusedItem.SubItems(4).Text
                editcourse.cmbClassYear.Text = lvCourse.FocusedItem.SubItems(5).Text
                editcourse.cmbSemester.Text = lvCourse.FocusedItem.SubItems(6).Text
                editcourse.ShowDialog()
            Else
                MessageBox.Show("No items to be edited!!", "No items", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If lvCourse.Items.Count > 0 Then
                response = MessageBox.Show("You are about to delete one record." + vbNewLine + " Are you sure you want to permanently delete this record?", "Scheduler", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString
                If response = "Yes" Then
                    If course.delete(coursecode) Then
                        MessageBox.Show("Record deleted successfully!", "Scheduler", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        course.LoadCourse(lvCourse, "select*from Course")
                    End If
                End If
            Else
                MessageBox.Show("No items to be deleted!!", "No items", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Try
            course.LoadCourse(lvCourse, "select*from Course")
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
End Class