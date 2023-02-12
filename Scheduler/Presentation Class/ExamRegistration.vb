Public Class ExamRegistration
    Private exam As New Exam
    Private dataaccess As New DataAccessClass
    Public Sub AssignValues()
        Try
            exam.Course_ID = cmbcid.Text
            exam.Teacher_ID = cmbtid.Text
            exam.Program = cmbprog.Text
            exam.Accademic_year = cmbaccyear.Text
            exam.Section = cmbsection.Text
            exam.Examinar_name = txtExaminar_name.Text
            exam.Invagilators_name = txtInvagilators_name.Text
            exam.Time_allowed = txtTimeallowed.Text
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Public Sub comboboxses()
        For i = 0 To dataaccess.ReturnCombobox("select Course_ID from Course_offerred group by Course_ID ").Items.Count - 1
            cmbcid.Items.Add(dataaccess.ReturnCombobox("select Course_ID from Course_offerred group by Course_ID").Items(i).ToString)
        Next
        For i = 0 To dataaccess.ReturnCombobox("select Teacher_ID from Course_offerred group by Teacher_ID").Items.Count - 1
            cmbtid.Items.Add(dataaccess.ReturnCombobox("select Teacher_ID from Course_offerred group by Teacher_ID").Items(i).ToString)
        Next
        For i = 0 To dataaccess.ReturnCombobox("select Program from Course_offerred group by Program").Items.Count - 1
            cmbprog.Items.Add(dataaccess.ReturnCombobox("select Program from Course_offerred group by Program").Items(i).ToString)
        Next
        For i = 0 To dataaccess.ReturnCombobox("select Accademic_year from Course_offerred group by Accademic_year").Items.Count - 1
            cmbaccyear.Items.Add(dataaccess.ReturnCombobox("select Accademic_year from Course_offerred group by Accademic_year").Items(i).ToString)
        Next
        For i = 0 To dataaccess.ReturnCombobox("select Section_ID from Course_offerred group by Section_ID").Items.Count - 1
            cmbsection.Items.Add(dataaccess.ReturnCombobox("select Section_ID from Course_offerred group by Section_ID").Items(i).ToString)
        Next

    End Sub

    Private Sub ExamRegistration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        comboboxses()
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            If cmbcid.Text = "" Or cmbtid.Text = "" Or cmbprog.Text = "" Or cmbaccyear.Text = "" Or cmbsection.Text = "" Or txtExaminar_name.Text = "" Or txtInvagilators_name.Text = "" Or txtTimeallowed.Text = "" Then
                MessageBox.Show("Empty fields not allowed!!", "Scheduler", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Else
                AssignValues()
                If exam.save(exam) Then
                    MessageBox.Show("Exam data successfully saved!", "Scheduler", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cannot save Exam data!", "Scheduler", MessageBoxButtons.OK, MessageBoxIcon.Error)
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