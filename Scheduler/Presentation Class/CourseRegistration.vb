Public Class CourseRegistration
    Private course As New Course
    Private Sub CourseRegistration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            If txtcid.Text = "" Or txtCrhr.Text = "" Or txtECTS.Text = "" Or txtTitle.Text = "" Or cmbClassYear.Text = "" Or cmbProgram.Text = "" Or cmbReqLab.Text = "" Or cmbSemester.Text = "" Then
                MessageBox.Show("Empty fields not allowed!!", "Scheduler", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Else
                If MessageBox.Show("Do you want to save this record?", "Scheduler", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    course.Course_ID = txtcid.Text
                    course.ECTS = txtECTS.Text
                    course.Chr = txtCrhr.Text
                    course.Requires_lab = cmbReqLab.Text
                    course.Title = txtTitle.Text
                    course.Class_year = cmbClassYear.Text
                    course.Program = cmbProgram.Text
                    course.Semester = cmbSemester.Text
                    If course.save(course) Then
                        MessageBox.Show("Course data successfully saved!", "Scheduler", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Try
            txtcid.Text = ""
            txtCrhr.Text = ""
            txtECTS.Text = ""
            txtTitle.Text = ""
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
End Class