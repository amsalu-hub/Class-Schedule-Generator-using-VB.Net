Public Class GenerateSchedulelab
    Private schedule As New GenerateLabSchedule
    Private dataaccess As New DataAccessClass
    Private Function GetSectionNo(ByVal program As String, ByVal academic_year As String, ByVal section_no As String) As String
        Dim secno As String = ""
        Try
            secno = dataaccess.ExecuteScalar("select Section_ID from Section where Academic_year='" + academic_year + "' and Program='" + program + "' and Section_no='" + section_no + "'")
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return secno
    End Function
    Private Sub btnGenerateSchedule_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerateSchedule.Click
        Try
            Dim vs As New ViewClassSchedule
            vs.MdiParent = SchedulerMDIParent
            If schedule.GenerateSchedule(cmbSchool.SelectedItem.ToString, GetSectionNo(cmbProgram.SelectedItem.ToString, cmbAccyear.SelectedItem.ToString, cmbSection.SelectedItem.ToString)) Then
                If MessageBox.Show("Laboratory Schedule Generated Successfully.Do you want to view the schedule?", "Scheduler", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) Then
                    Me.Hide()
                    vs.Show()
                End If
            Else
                If MessageBox.Show("No new Laboratory Schedule Generated.Do you want to view the previous schedule?", "Scheduler", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) Then
                    Me.Hide()
                    vs.Show()
                End If
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub GenerateSchedule_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub cmbProgram_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProgram.SelectedIndexChanged
        Try
            cmbAccyear.Items.Clear()
            For i = 0 To dataaccess.ReturnCombobox("select Academic_year from Section  where Program='" + cmbProgram.SelectedItem.ToString + "'group by Academic_year").Items.Count - 1
                cmbAccyear.Items.Add(dataaccess.ReturnCombobox("select Academic_year from Section  where Program='" + cmbProgram.SelectedItem.ToString + "'group by Academic_year").Items(i).ToString)
            Next
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub cmbAccyear_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAccyear.SelectedIndexChanged
        Try
            cmbSection.Items.Clear()
            For i = 0 To dataaccess.ReturnCombobox("select Section_ID from Section where Program='" + cmbProgram.SelectedItem.ToString + "' and Academic_year='" + cmbAccyear.SelectedItem.ToString + "'  group by Section_ID").Items.Count - 1
                cmbSection.Items.Add(dataaccess.ReturnCombobox("select Section_ID from Section where Program='" + cmbProgram.SelectedItem.ToString + "'and Academic_year='" + cmbAccyear.SelectedItem.ToString + "'  group by Section_ID").Items(i).ToString)
            Next
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub cmbSchool_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSchool.SelectedIndexChanged
        cmbProgram.Items.Clear()
        For i = 0 To dataaccess.ReturnCombobox("select Program from Section where School_name='" + cmbSchool.SelectedItem.ToString + "'group by Program").Items.Count - 1
            cmbProgram.Items.Add(dataaccess.ReturnCombobox("select Program from Section where School_name='" + cmbSchool.SelectedItem.ToString + "'group by Program").Items(i).ToString)
        Next
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class