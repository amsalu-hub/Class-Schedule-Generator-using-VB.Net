Public Class TeacherRegistration
    Private teacher As New Teacher
    Public Sub AssignValues()
        Try
            teacher.Teacher_ID = txtTeacherID.Text
            teacher.First_name = txtFname.Text
            teacher.Last_name = txtLname.Text
            teacher.Block_no = txtBlockNo.Text
            teacher.Floor_no = txtFloorNo.Text
            teacher.Office_no = txtOfficeNo.Text
            teacher.Phone = txtPhone.Text
            teacher.Email = txtEmail.Text
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If txtTeacherID.Text = "" Or txtFname.Text = "" Or txtLname.Text = "" Or txtBlockNo.Text = "" Or txtFloorNo.Text = "" Or txtOfficeNo.Text = "" Or txtPhone.Text = "" Or txtEmail.Text = "" Then
                MessageBox.Show("Empty fields not allowed!!", "Scheduler", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Else
                AssignValues()
                If btnSave.Text = "Save" Then
                    If teacher.save(teacher) Then
                        MessageBox.Show("Teacher data successfully saved!", "Scheduler", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("There was a problem with saving the data", "Scheduler", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)
                    End If
                ElseIf btnSave.Text = "Save Changes" Then
                    If teacher.update(teacher) Then
                        MessageBox.Show("Teacher data successfully saved!", "Scheduler", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("There was a problem with saving the data", "Scheduler", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)
                    End If
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
