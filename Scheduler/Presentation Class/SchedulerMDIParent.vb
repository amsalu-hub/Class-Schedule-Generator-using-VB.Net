Imports System.Windows.Forms

Public Class SchedulerMDIParent
    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        LoginForm.Close()
        frmInsertSerial.Close()
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SectionMenuItem.Click
        Try
            SectionRegistration.TopLevel = False
            SectionRegistration.Parent = SplitContainer1.Panel2
            SectionRegistration.Show()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CourseOfferingStripMenuItem.Click
        Try
            CourseOffering.TopLevel = False
            CourseOffering.Parent = SplitContainer1.Panel2
            CourseOffering.Show()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExamToolStripMenuItem.Click
        Try
            ExamRegistration.TopLevel = False
            ExamRegistration.Parent = SplitContainer1.Panel2
            ExamRegistration.Show()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ClassScheduleToolStripMenuItem.Click
        Try
            GenerateSchedule.TopLevel = False
            GenerateSchedule.Parent = SplitContainer1.Panel2
            GenerateSchedule.Show()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        'Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExamBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.ExamBarToolStripMenuItem.Checked
    End Sub

    Private Sub UndoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomMenuItem.Click
        Try
            RoomRegistration.TopLevel = False
            RoomRegistration.Parent = SplitContainer1.Panel2
            RoomRegistration.Show()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub RedoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CourseMenuItem.Click
        Try
            CourseRegistration.TopLevel = False
            CourseRegistration.Parent = SplitContainer1.Panel2
            CourseRegistration.Show()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TeacherToolStripMenuItem.Click
        Try
            TeacherRegistration.TopLevel = False
            TeacherRegistration.Parent = SplitContainer1.Panel2
            TeacherRegistration.Show()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Private Sub CourseListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CourseListToolStripMenuItem.Click
        Try
            ViewCourseList.TopLevel = False
            ViewCourseList.Parent = SplitContainer1.Panel2
            ViewCourseList.Show()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub RoomListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomListToolStripMenuItem.Click
        Try
            ViewRoomList.TopLevel = False
            ViewRoomList.Parent = SplitContainer1.Panel2
            ViewRoomList.Show()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub SectionListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SectionListToolStripMenuItem.Click
        Try
            ViewSectionList.TopLevel = False
            ViewSectionList.Parent = SplitContainer1.Panel2
            ViewSectionList.Show()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub TeacherListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TeacherListToolStripMenuItem.Click
        Try
            ViewTeacherList.TopLevel = False
            ViewTeacherList.Parent = SplitContainer1.Panel2
            ViewTeacherList.Show()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub UserListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserListToolStripMenuItem.Click
        Try
            ViewUserList.TopLevel = False
            ViewUserList.Parent = SplitContainer1.Panel2
            ViewUserList.Show()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub

    Private Sub CourseOfferredListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CourseOfferredListToolStripMenuItem.Click
        Try
            ViewCourseOfferredList.TopLevel = False
            ViewCourseOfferredList.Parent = SplitContainer1.Panel2
            ViewCourseOfferredList.Show()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub

    Private Sub LabScheduleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabScheduleToolStripMenuItem.Click
        Try
            GenerateSchedulelab.TopLevel = False
            GenerateSchedulelab.Parent = SplitContainer1.Panel2
            GenerateSchedulelab.Show()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Try
            AboutBox.TopLevel = False
            AboutBox.Parent = SplitContainer1.Panel2
            AboutBox.Show()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub CreateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateToolStripMenuItem.Click
        Try
            CreateUser.TopLevel = False
            CreateUser.Parent = SplitContainer1.Panel2
            CreateUser.Show()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOutToolStripMenuItem.Click
        Try
            Me.Hide()
            LoginForm.Show()
            LoginForm.UsernameTextBox.Clear()
            LoginForm.PasswordTextBox.Clear()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub SchedulerMDIParent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'LoginForm.AsignPrevileges()
    End Sub

    Private Sub btnCourseOff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCourseOff.Click
        Try
            CourseOffering.TopLevel = False
            CourseOffering.Parent = SplitContainer1.Panel2
            CourseOffering.Show()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub btnSection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSection.Click
        Try
            SectionRegistration.TopLevel = False
            SectionRegistration.Parent = SplitContainer1.Panel2
            SectionRegistration.Show()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub btnRoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRoom.Click
        Try
            RoomRegistration.TopLevel = False
            RoomRegistration.Parent = SplitContainer1.Panel2
            RoomRegistration.Show()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub btnInstructor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInstructor.Click
        Try
            TeacherRegistration.TopLevel = False
            TeacherRegistration.Parent = SplitContainer1.Panel2
            TeacherRegistration.Show()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub btnClassSche_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClassSche.Click
        Try
            GenerateSchedule.TopLevel = False
            GenerateSchedule.Parent = SplitContainer1.Panel2
            GenerateSchedule.Show()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub btnLabSche_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLabSche.Click
        Try
            GenerateSchedulelab.TopLevel = False
            GenerateSchedulelab.Parent = SplitContainer1.Panel2
            GenerateSchedulelab.Show()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub brnVClassSche_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles brnVClassSche.Click
        Try
            ViewClassSchedule.TopLevel = False
            ViewClassSchedule.Parent = SplitContainer1.Panel2
            ViewClassSchedule.Show()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub btnVLabSche_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVLabSche.Click
        Try
            ViewClassSchedule.TopLevel = False
            ViewClassSchedule.Parent = SplitContainer1.Panel2
            ViewClassSchedule.Show()
            ViewClassSchedule.TabControl1.SelectedTab = ViewClassSchedule.tplabschedule
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub ClassScheduleToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClassScheduleToolStripMenuItem1.Click
        Try
            ViewClassSchedule.TopLevel = False
            ViewClassSchedule.Parent = SplitContainer1.Panel2
            ViewClassSchedule.Show()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub LabScheduleToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabScheduleToolStripMenuItem1.Click
        Try
            ViewClassSchedule.TopLevel = False
            ViewClassSchedule.Parent = SplitContainer1.Panel2
            ViewClassSchedule.Show()
            ViewClassSchedule.TabControl1.SelectedTab = ViewClassSchedule.tplabschedule
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
End Class
