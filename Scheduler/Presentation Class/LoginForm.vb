Public Class LoginForm
    Private dataaccess As New DataAccessClass
    Private usertype As String
    Private insertserial As New frmInsertSerial
    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.
    Public Sub AsignPrevileges()
        If usertype = "Teacher" Or usertype = "Student" Then
            SchedulerMDIParent.DataEntryMenu.Visible = False
            SchedulerMDIParent.GenerateMenu.Visible = False
            'SchedulerMDIParent.ViewToolStripMenuItem.Site = SchedulerMDIParent.DataEntryMenu.Site
            'SchedulerMDIParent.UserToolStripMenuItem.Site = SchedulerMDIParent.GenerateMenu.Site
            'SchedulerMDIParent.HelpMenu.Site = SchedulerMDIParent.ViewToolStripMenuItem.Site
        Else
            SchedulerMDIParent.DataEntryMenu.Visible = True
            SchedulerMDIParent.GenerateMenu.Visible = True
        End If
    End Sub
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Try
            If UsernameTextBox.Text = "" Or PasswordTextBox.Text = "" Then
                MessageBox.Show("Please fill your User name and password", "Scheduler", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Dim query As String = "select User_type,User_name,Password from Users where User_name='" + UsernameTextBox.Text + "' and Password='" + PasswordTextBox.Text + "'"
                usertype = dataaccess.ExecuteScalar(query)
                If Not usertype = "" Then
                    Dim mdi As New SchedulerMDIParent
                    Me.Hide()
                    AsignPrevileges()
                    mdi.Show()
                Else
                    MessageBox.Show("Your User name or password is inccorect." + vbNewLine + "Check your user name or password.", "Scheduler", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'If Not My.Computer.Network.IsAvailable Then
        '    MessageBox.Show("You are not connected to your Local Area Network." + vbNewLine + "Please connect your computer to LAN and open the application again.", "Scheduler", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    Me.Close()
        'End If
        If My.Settings.Registered Then
            frmInsertSerial.Hide()
        End If
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Try
            ViewClassSchedule.Show()
            ViewClassSchedule.btnExport.Enabled = False
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
End Class
