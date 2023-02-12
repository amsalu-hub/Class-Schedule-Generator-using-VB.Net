Public Class ViewCourseOfferredList
    Private cid As String
    Private tid As String
    Private prog As String
    Private accy As String
    Private sec As String
    Private cofferred As New CourseOffer
    Private response As String
    Private Sub ViewCourseOfferredList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cofferred.LoadCourseOfferred(lvCourseOfferred, "select*from Course_offerred")
    End Sub
    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Try
            If lvCourseOfferred.Items.Count > 0 Then
                Dim editcourseoffer As New CourseOffering
                editcourseoffer.cmbxcid.Text = lvCourseOfferred.FocusedItem.SubItems(0).Text
                editcourseoffer.cmbxtid.Text = lvCourseOfferred.FocusedItem.SubItems(1).Text
                editcourseoffer.cmbxprog.Text = lvCourseOfferred.FocusedItem.SubItems(2).Text
                editcourseoffer.cmbxacyr.Text = lvCourseOfferred.FocusedItem.SubItems(3).Text
                editcourseoffer.cmbxsec.Text = lvCourseOfferred.FocusedItem.SubItems(5).Text
                editcourseoffer.cmblabreq.Text = lvCourseOfferred.FocusedItem.SubItems(6).Text
                editcourseoffer.txtAsistName.Text = lvCourseOfferred.FocusedItem.SubItems(7).Text
                editcourseoffer.ShowDialog()
            Else
                MessageBox.Show("No items to be edited!!", "No items", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If lvCourseOfferred.Items.Count > 0 Then
                response = MessageBox.Show("You are about to delete one record." + vbNewLine + " Are you sure you want to permanently delete this record?", "Scheduler", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString
                If response = "Yes" Then
                    cid = lvCourseOfferred.FocusedItem.SubItems(0).Text
                    tid = lvCourseOfferred.FocusedItem.SubItems(1).Text
                    prog = lvCourseOfferred.FocusedItem.SubItems(2).Text
                    sec = lvCourseOfferred.FocusedItem.SubItems(3).Text
                    If cofferred.delete(cid, tid, prog, accy, sec) Then
                        MessageBox.Show("Record deleted successfully!", "Scheduler", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        cofferred.LoadCourseOfferred(lvCourseOfferred, "select*from Course_offerred")
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
            cofferred.LoadCourseOfferred(lvCourseOfferred, "select*from Course_offerred")
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        Try
            Dim query As String = ""
            If cmbsearch.SelectedItem.ToString = "Teacher" Then
                query = "select*from Course_offerred where Teacher_ID='" + txtvalue.Text + "'"
            ElseIf cmbsearch.SelectedItem.ToString = "Program" Then
                query = "select*from Course_offerred where Program='" + txtvalue.Text + "' and Accademic_year='" + txtvalue.Text + "'"
            ElseIf cmbsearch.SelectedItem.ToString = "Course" Then
                query = "select*from Course_offerred where Course_ID='" + txtvalue.Text + "'"
            End If
            cofferred.LoadCourseOfferred(lvCourseOfferred, query)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
End Class