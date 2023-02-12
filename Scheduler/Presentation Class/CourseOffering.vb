Imports System.Data
Public Class CourseOffering
    Private courseofferred As New CourseOffer
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
    Public Sub AssignValues()
        courseofferred.Course_ID = cmbxcid.Text
        courseofferred.Section_ID = GetSectionNo(cmbxprog.Text, cmbxacyr.Text, cmbxsec.Text)
        courseofferred.Teacher_ID = cmbxtid.Text
        If cmblabreq.SelectedItem.ToString = "Yes" Then
            courseofferred.Asistant_ID = txtAsistName.Text
        Else
            courseofferred.Asistant_ID = ""
        End If
    End Sub
    Public Sub Comboboxes()
        For i = 0 To dataaccess.ReturnCombobox("select Course_ID from Course").Items.Count - 1
            cmbxcid.Items.Add(dataaccess.ReturnCombobox("select Course_ID from Course").Items(i).ToString)
        Next
        For i = 0 To dataaccess.ReturnCombobox("select Teacher_ID from Teacher").Items.Count - 1
            cmbxtid.Items.Add(dataaccess.ReturnCombobox("select Teacher_ID from Teacher").Items(i).ToString)
        Next
    End Sub
    Private Sub CourseOffering_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Comboboxes()
        txtAsistName.ReadOnly = True
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            If cmbxacyr.Text = "" Or cmbxcid.Text = "" Or cmbxprog.Text = "" Or cmbxsec.Text = "" Or cmbxtid.Text = "" Then
                MessageBox.Show("Empty fields not allowed," + vbNewLine + "check for empty fields", "Scheduler", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                AssignValues()
                If courseofferred.save(courseofferred) Then
                    MsgBox("Data saved successfully!!")
                Else
                    MessageBox.Show("Cannot save course data!", "Scheduler", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Try
            cmbxacyr.Text = ""
            cmbxcid.Text = ""
            cmbxprog.Text = ""
            cmbxsec.Text = ""
            cmbxtid.Text = ""
            cmblabreq.Text = ""
            txtAsistName.Text = ""
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub cmbxprog_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbxprog.SelectedIndexChanged
        Try
            cmbxacyr.Items.Clear()
            For i = 0 To dataaccess.ReturnCombobox("select Accademic_year from Section where Program='" + cmbxprog.Text + "' group by Accademic_year").Items.Count - 1
                cmbxacyr.Items.Add(dataaccess.ReturnCombobox("select Accademic_year from Section where Program='" + cmbxprog.Text + "' group by Accademic_year").Items(i).ToString)
            Next
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub cmbxacyr_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbxacyr.SelectedIndexChanged
        Try
            cmbxsec.Items.Clear()
            For i = 0 To dataaccess.ReturnCombobox("select Section_ID from Section where Accademic_year='" + cmbxacyr.Text + "'group by Section_ID").Items.Count - 1
                cmbxsec.Items.Add(dataaccess.ReturnCombobox("select Section_ID from Section where Accademic_year='" + cmbxacyr.Text + "'group by Section_ID").Items(i).ToString)
            Next
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub cmblabreq_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmblabreq.SelectedIndexChanged
        If cmblabreq.SelectedItem.ToString = "Yes" Then
            txtAsistName.ReadOnly = False
        Else
            txtAsistName.ReadOnly = True
        End If
    End Sub

    Private Sub btnImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class