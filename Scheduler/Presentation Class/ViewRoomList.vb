Public Class ViewRoomList
    Private Room_no As String
    Private Block_no As String
    Private Response As String
    Private room As New Room
    Private Sub ViewRoomList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        room.LoadRoom(lvRoom, "select*from Room")
        If lvRoom.Items.Count > 0 Then
            Room_no = lvRoom.FocusedItem.SubItems(0).Text
            Block_no = lvRoom.FocusedItem.SubItems(1).Text
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Try
            If lvRoom.Items.Count > 0 Then
                Dim editroom As New RoomRegistration
                editroom.txtRoomNo.Text = lvRoom.FocusedItem.SubItems(0).Text
                editroom.txtBlockNo.Text = lvRoom.FocusedItem.SubItems(1).Text
                editroom.txtFloorNo.Text = lvRoom.FocusedItem.SubItems(2).Text
                editroom.txtHeadname.Text = lvRoom.FocusedItem.SubItems(5).Text
                editroom.txtHeadPhone.Text = lvRoom.FocusedItem.SubItems(6).Text
                editroom.txtHeadEmail.Text = lvRoom.FocusedItem.SubItems(7).Text
                editroom.cmbRoomType.Text = lvRoom.FocusedItem.SubItems(3).Text
                editroom.ShowDialog()
            Else
                MessageBox.Show("No items to be edited!!", "No items", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Try
            lvRoom.Items.Clear()
            room.LoadRoom(lvRoom, "select*from Room")
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If lvRoom.Items.Count > 0 Then
                Response = MessageBox.Show("You are about to delete one record." + vbNewLine + "Are you sure you want to permanently delete this record?", "Scheduler", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString
                If Response = "Yes" Then
                    If room.delete(Room_no, Block_no) Then
                        MessageBox.Show("Record deleted successfully!", "Scheduler", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        room.LoadRoom(lvRoom, "select*from Room")
                    End If
                End If
            Else
                MessageBox.Show("No items to be deleted!!", "No items", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
End Class