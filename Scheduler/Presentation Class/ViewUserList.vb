Public Class ViewUserList
    Private user_id As Integer
    Private Response As String
    Private user As New User
    Private Sub ViewUserList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        user.LoadUser(lvUsers, "select*from Users where User_name<>'admin' and User_type<>'Admin'")
        If lvUsers.Items.Count > 0 Then
            user_id = Integer.Parse(lvUsers.Items(lvUsers.FocusedItem.Index).SubItems(0).Text)
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Try
            If lvUsers.Items.Count > 0 Then
                Dim edituser As New CreateUser
                edituser.txtusername.Text = lvUsers.FocusedItem.SubItems(1).Text
                edituser.txtpassword.Text = lvUsers.FocusedItem.SubItems(2).Text
                edituser.cmbusertype.Text = lvUsers.FocusedItem.SubItems(3).Text
                edituser.cmbsecuQues.Text = lvUsers.FocusedItem.SubItems(4).Text
                edituser.txtsecuAns.Text = lvUsers.FocusedItem.SubItems(5).Text
                edituser.ShowDialog()
            Else
                MessageBox.Show("No items to be edited!!", "No items", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If lvUsers.Items.Count > 0 Then
                Response = MessageBox.Show("You are about to delete one record." + vbNewLine + "Are you sure you want to permanently delete this record?", "Scheduler", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString
                If Response = "Yes" Then
                    If user.delete(user_id) Then
                        MessageBox.Show("Record deleted successfully!", "Scheduler", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        user.LoadUser(lvUsers, "select*from Users where User_name<>'admin' and User_type<>'Admin'")
                    Else
                        MessageBox.Show("Sorry, you cant' delete this user!", "Can't Delete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)
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
            lvUsers.Items.Clear()
            user.LoadUser(lvUsers, "select*from Users where User_name<>'Admin' and User_type<>'Admin'")
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class