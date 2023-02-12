Public Class CreateUser
    Private user As New User
    Private dataaccess As New DataAccessClass
    Public Sub AssignValues()
        user.Username = txtusername.Text
        user.Password = txtpassword.Text
        user.User_type = cmbusertype.Text
        user.Security_question = cmbsecuQues.Text
        user.Security_answer = txtsecuAns.Text
    End Sub
    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Try
            txtpassword.Text = ""
            txtsecuAns.Text = ""
            txtusername.Text = ""
            cmbsecuQues.Text = ""
            cmbusertype.Text = ""
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            If cmbsecuQues.Text = "" Or cmbusertype.Text = "" Or txtusername.Text = "" Or txtpassword.Text = "" Or txtsecuAns.Text = "" Then
                MessageBox.Show("Empty fields not allowed," + vbNewLine + "check for empty fields", "Scheduler", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                If txtconfrimpass.Text = txtpassword.Text Then
                    AssignValues()
                    If user.save(user) Then
                        MsgBox("Data saved successfully!!")
                    Else
                        MessageBox.Show("Cannot Save User data!", "Scheduler", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Password mismatch. Check your password.", "Scheduler", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub
End Class