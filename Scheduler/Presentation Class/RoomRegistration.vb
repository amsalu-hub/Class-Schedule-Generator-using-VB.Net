Public Class RoomRegistration
    Private room As New Room
    Public Sub AssignValues()
        room.Room_No = txtRoomNo.Text
        room.Block_No = txtBlockNo.Text
        room.Floor_No = txtFloorNo.Text
        room.Room_Type = cmbRoomType.Text
        room.School = cmbSchool.SelectedItem.ToString
        If GroupBox2.Enabled Then
            room.Head_email = txtHeadEmail.Text
            room.Head_name = txtHeadname.Text
            room.Head_phone = txtHeadPhone.Text
        Else
            room.Head_email = ""
            room.Head_name = ""
            room.Head_phone = ""
        End If
    End Sub
    Private Function CheckEmpty() As Boolean
        Dim err As Boolean = False
        Try
            If txtBlockNo.Text = "" Then
                err = True
                errRoom.SetError(txtBlockNo, "Please,fill block number!!")
            End If
            If txtFloorNo.Text = "" Then
                err = True
                errRoom.SetError(txtFloorNo, "Please,fill floor number!!")
            End If
            If cmbRoomType.Text = "Lab room" And txtHeadEmail.Text = "" Then
                err = True
                errRoom.SetError(txtHeadEmail, "Please,fill lab head email!!")
            End If
            If cmbRoomType.Text = "Lab room" And txtHeadname.Text = "" Then
                err = True
                errRoom.SetError(txtHeadname, "Please,fill lab head name!!")
            End If
            If cmbRoomType.Text = "Lab room" And txtHeadPhone.Text = "" Then
                err = True
                errRoom.SetError(txtHeadPhone, "Please,fill lab head phone number!!")
            End If
            If txtRoomNo.Text = "" Then
                err = True
                errRoom.SetError(txtRoomNo, "Please,fill room number!!")
            End If
            If cmbRoomType.Text = "" Then
                err = True
                errRoom.SetError(txtRoomNo, "Please,select room type!!")
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return err
    End Function
    Private Sub RoomRegistration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GroupBox2.Enabled = False
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If Not CheckEmpty() Then
                AssignValues()
                If room.save(room) Then
                    MessageBox.Show("Room data successfully saved!", "Scheduler", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub cmbRoomType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRoomType.SelectedIndexChanged
        Try
            If cmbRoomType.SelectedItem.ToString = "Class room" Then
                GroupBox2.Enabled = False
            Else
                GroupBox2.Enabled = True
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
End Class