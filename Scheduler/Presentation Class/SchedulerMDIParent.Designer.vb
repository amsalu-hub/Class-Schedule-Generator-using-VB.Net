<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SchedulerMDIParent
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SchedulerMDIParent))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DataEntryMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.RoomMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CourseMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SectionMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CourseOfferingStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExamToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TeacherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GenerateMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.ClassScheduleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LabScheduleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExamBarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CourseOfferredListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CourseListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RoomListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TeacherListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SectionListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExamListToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.UserListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ScheduleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClassScheduleToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.LabScheduleToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CreateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.ContentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.IndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btnVLabSche = New System.Windows.Forms.Button
        Me.brnVClassSche = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnLabSche = New System.Windows.Forms.Button
        Me.btnClassSche = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnInstructor = New System.Windows.Forms.Button
        Me.btnRoom = New System.Windows.Forms.Button
        Me.btnSection = New System.Windows.Forms.Button
        Me.btnCourseOff = New System.Windows.Forms.Button
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.DataEntryMenu, Me.GenerateMenu, Me.ViewToolStripMenuItem, Me.UserToolStripMenuItem, Me.HelpMenu})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1025, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(57, 20)
        Me.FileMenu.Text = "System"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'DataEntryMenu
        '
        Me.DataEntryMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RoomMenuItem, Me.CourseMenuItem, Me.SectionMenuItem, Me.CourseOfferingStripMenuItem, Me.ExamToolStripMenuItem, Me.TeacherToolStripMenuItem})
        Me.DataEntryMenu.Name = "DataEntryMenu"
        Me.DataEntryMenu.Size = New System.Drawing.Size(73, 20)
        Me.DataEntryMenu.Text = "Data Entry"
        '
        'RoomMenuItem
        '
        Me.RoomMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.RoomMenuItem.Name = "RoomMenuItem"
        Me.RoomMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.RoomMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.RoomMenuItem.Text = "Room"
        '
        'CourseMenuItem
        '
        Me.CourseMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.CourseMenuItem.Name = "CourseMenuItem"
        Me.CourseMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CourseMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.CourseMenuItem.Text = "Course"
        '
        'SectionMenuItem
        '
        Me.SectionMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.SectionMenuItem.Name = "SectionMenuItem"
        Me.SectionMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SectionMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.SectionMenuItem.Text = "Section"
        '
        'CourseOfferingStripMenuItem
        '
        Me.CourseOfferingStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.CourseOfferingStripMenuItem.Name = "CourseOfferingStripMenuItem"
        Me.CourseOfferingStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.CourseOfferingStripMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.CourseOfferingStripMenuItem.Text = "Course Offering"
        '
        'ExamToolStripMenuItem
        '
        Me.ExamToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.ExamToolStripMenuItem.Name = "ExamToolStripMenuItem"
        Me.ExamToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.ExamToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.ExamToolStripMenuItem.Text = "Exam"
        '
        'TeacherToolStripMenuItem
        '
        Me.TeacherToolStripMenuItem.Name = "TeacherToolStripMenuItem"
        Me.TeacherToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.TeacherToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.TeacherToolStripMenuItem.Text = "Teacher"
        '
        'GenerateMenu
        '
        Me.GenerateMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClassScheduleToolStripMenuItem, Me.LabScheduleToolStripMenuItem, Me.ExamBarToolStripMenuItem})
        Me.GenerateMenu.Name = "GenerateMenu"
        Me.GenerateMenu.Size = New System.Drawing.Size(117, 20)
        Me.GenerateMenu.Text = "Generate Schedule"
        '
        'ClassScheduleToolStripMenuItem
        '
        Me.ClassScheduleToolStripMenuItem.CheckOnClick = True
        Me.ClassScheduleToolStripMenuItem.Name = "ClassScheduleToolStripMenuItem"
        Me.ClassScheduleToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ClassScheduleToolStripMenuItem.Text = "Class Schedule"
        '
        'LabScheduleToolStripMenuItem
        '
        Me.LabScheduleToolStripMenuItem.Name = "LabScheduleToolStripMenuItem"
        Me.LabScheduleToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.LabScheduleToolStripMenuItem.Text = "Lab Schedule"
        '
        'ExamBarToolStripMenuItem
        '
        Me.ExamBarToolStripMenuItem.CheckOnClick = True
        Me.ExamBarToolStripMenuItem.Name = "ExamBarToolStripMenuItem"
        Me.ExamBarToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ExamBarToolStripMenuItem.Text = "Exam Schedule"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CourseOfferredListToolStripMenuItem, Me.CourseListToolStripMenuItem, Me.RoomListToolStripMenuItem, Me.TeacherListToolStripMenuItem, Me.SectionListToolStripMenuItem, Me.ExamListToolStripMenuItem1, Me.UserListToolStripMenuItem, Me.ScheduleToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.ViewToolStripMenuItem.Text = "View "
        '
        'CourseOfferredListToolStripMenuItem
        '
        Me.CourseOfferredListToolStripMenuItem.Name = "CourseOfferredListToolStripMenuItem"
        Me.CourseOfferredListToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.CourseOfferredListToolStripMenuItem.Text = "Course Offerred List"
        '
        'CourseListToolStripMenuItem
        '
        Me.CourseListToolStripMenuItem.Name = "CourseListToolStripMenuItem"
        Me.CourseListToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.CourseListToolStripMenuItem.Text = "Course List"
        '
        'RoomListToolStripMenuItem
        '
        Me.RoomListToolStripMenuItem.Name = "RoomListToolStripMenuItem"
        Me.RoomListToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.RoomListToolStripMenuItem.Text = "Room List"
        '
        'TeacherListToolStripMenuItem
        '
        Me.TeacherListToolStripMenuItem.Name = "TeacherListToolStripMenuItem"
        Me.TeacherListToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.TeacherListToolStripMenuItem.Text = "Teacher List"
        '
        'SectionListToolStripMenuItem
        '
        Me.SectionListToolStripMenuItem.Name = "SectionListToolStripMenuItem"
        Me.SectionListToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.SectionListToolStripMenuItem.Text = "Section List"
        '
        'ExamListToolStripMenuItem1
        '
        Me.ExamListToolStripMenuItem1.Name = "ExamListToolStripMenuItem1"
        Me.ExamListToolStripMenuItem1.Size = New System.Drawing.Size(179, 22)
        Me.ExamListToolStripMenuItem1.Text = "Exam List"
        '
        'UserListToolStripMenuItem
        '
        Me.UserListToolStripMenuItem.Name = "UserListToolStripMenuItem"
        Me.UserListToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.UserListToolStripMenuItem.Text = "User List"
        '
        'ScheduleToolStripMenuItem
        '
        Me.ScheduleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClassScheduleToolStripMenuItem1, Me.LabScheduleToolStripMenuItem1})
        Me.ScheduleToolStripMenuItem.Name = "ScheduleToolStripMenuItem"
        Me.ScheduleToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.ScheduleToolStripMenuItem.Text = "Schedule"
        '
        'ClassScheduleToolStripMenuItem1
        '
        Me.ClassScheduleToolStripMenuItem1.Name = "ClassScheduleToolStripMenuItem1"
        Me.ClassScheduleToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ClassScheduleToolStripMenuItem1.Text = "Class Schedule"
        '
        'LabScheduleToolStripMenuItem1
        '
        Me.LabScheduleToolStripMenuItem1.Name = "LabScheduleToolStripMenuItem1"
        Me.LabScheduleToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.LabScheduleToolStripMenuItem1.Text = "Lab Schedule"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogOutToolStripMenuItem, Me.CreateToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.UserToolStripMenuItem.Text = "User"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.LogOutToolStripMenuItem.Text = "Log out"
        '
        'CreateToolStripMenuItem
        '
        Me.CreateToolStripMenuItem.Name = "CreateToolStripMenuItem"
        Me.CreateToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.CreateToolStripMenuItem.Text = "Create"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete "
        '
        'HelpMenu
        '
        Me.HelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContentsToolStripMenuItem, Me.IndexToolStripMenuItem, Me.SearchToolStripMenuItem, Me.ToolStripSeparator8, Me.AboutToolStripMenuItem})
        Me.HelpMenu.Name = "HelpMenu"
        Me.HelpMenu.Size = New System.Drawing.Size(44, 20)
        Me.HelpMenu.Text = "Help"
        '
        'ContentsToolStripMenuItem
        '
        Me.ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem"
        Me.ContentsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.ContentsToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ContentsToolStripMenuItem.Text = "&Contents"
        '
        'IndexToolStripMenuItem
        '
        Me.IndexToolStripMenuItem.Image = CType(resources.GetObject("IndexToolStripMenuItem.Image"), System.Drawing.Image)
        Me.IndexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
        Me.IndexToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.IndexToolStripMenuItem.Text = "&Index"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Image = CType(resources.GetObject("SearchToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SearchToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.SearchToolStripMenuItem.Text = "&Search"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(165, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.AboutToolStripMenuItem.Text = "&About ..."
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 570)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1025, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(4, 26)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1018, 542)
        Me.SplitContainer1.SplitterDistance = 179
        Me.SplitContainer1.SplitterWidth = 1
        Me.SplitContainer1.TabIndex = 9
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnVLabSche)
        Me.GroupBox3.Controls.Add(Me.brnVClassSche)
        Me.GroupBox3.Location = New System.Drawing.Point(18, 378)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(142, 100)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "View Schedule"
        '
        'btnVLabSche
        '
        Me.btnVLabSche.Location = New System.Drawing.Point(23, 58)
        Me.btnVLabSche.Name = "btnVLabSche"
        Me.btnVLabSche.Size = New System.Drawing.Size(93, 23)
        Me.btnVLabSche.TabIndex = 3
        Me.btnVLabSche.Text = "Lab Schedule"
        Me.btnVLabSche.UseVisualStyleBackColor = True
        '
        'brnVClassSche
        '
        Me.brnVClassSche.Location = New System.Drawing.Point(23, 29)
        Me.brnVClassSche.Name = "brnVClassSche"
        Me.brnVClassSche.Size = New System.Drawing.Size(93, 23)
        Me.brnVClassSche.TabIndex = 2
        Me.brnVClassSche.Text = "Class Schedule"
        Me.brnVClassSche.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnLabSche)
        Me.GroupBox2.Controls.Add(Me.btnClassSche)
        Me.GroupBox2.Location = New System.Drawing.Point(18, 228)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(142, 100)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Generate Schedule"
        '
        'btnLabSche
        '
        Me.btnLabSche.Location = New System.Drawing.Point(23, 59)
        Me.btnLabSche.Name = "btnLabSche"
        Me.btnLabSche.Size = New System.Drawing.Size(93, 23)
        Me.btnLabSche.TabIndex = 3
        Me.btnLabSche.Text = "Lab Schedule"
        Me.btnLabSche.UseVisualStyleBackColor = True
        '
        'btnClassSche
        '
        Me.btnClassSche.Location = New System.Drawing.Point(23, 30)
        Me.btnClassSche.Name = "btnClassSche"
        Me.btnClassSche.Size = New System.Drawing.Size(93, 23)
        Me.btnClassSche.TabIndex = 2
        Me.btnClassSche.Text = "Class Schedule"
        Me.btnClassSche.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnInstructor)
        Me.GroupBox1.Controls.Add(Me.btnRoom)
        Me.GroupBox1.Controls.Add(Me.btnSection)
        Me.GroupBox1.Controls.Add(Me.btnCourseOff)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(142, 151)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Entry"
        '
        'btnInstructor
        '
        Me.btnInstructor.Location = New System.Drawing.Point(23, 122)
        Me.btnInstructor.Name = "btnInstructor"
        Me.btnInstructor.Size = New System.Drawing.Size(93, 23)
        Me.btnInstructor.TabIndex = 3
        Me.btnInstructor.Text = "Instructor"
        Me.btnInstructor.UseVisualStyleBackColor = True
        '
        'btnRoom
        '
        Me.btnRoom.Location = New System.Drawing.Point(23, 91)
        Me.btnRoom.Name = "btnRoom"
        Me.btnRoom.Size = New System.Drawing.Size(93, 23)
        Me.btnRoom.TabIndex = 2
        Me.btnRoom.Text = "Room"
        Me.btnRoom.UseVisualStyleBackColor = True
        '
        'btnSection
        '
        Me.btnSection.Location = New System.Drawing.Point(23, 61)
        Me.btnSection.Name = "btnSection"
        Me.btnSection.Size = New System.Drawing.Size(93, 23)
        Me.btnSection.TabIndex = 1
        Me.btnSection.Text = "Section"
        Me.btnSection.UseVisualStyleBackColor = True
        '
        'btnCourseOff
        '
        Me.btnCourseOff.Location = New System.Drawing.Point(23, 29)
        Me.btnCourseOff.Name = "btnCourseOff"
        Me.btnCourseOff.Size = New System.Drawing.Size(93, 23)
        Me.btnCourseOff.TabIndex = 0
        Me.btnCourseOff.Text = "Course Offering"
        Me.btnCourseOff.UseVisualStyleBackColor = True
        '
        'SchedulerMDIParent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1025, 592)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.MaximizeBox = False
        Me.Name = "SchedulerMDIParent"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LAN Based Automatic Schedule Generator"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents DataEntryMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RoomMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CourseMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SectionMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CourseOfferingStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExamToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TeacherToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerateMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClassScheduleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExamBarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabScheduleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ScheduleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CourseListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RoomListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TeacherListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SectionListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExamListToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CourseOfferredListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnLabSche As System.Windows.Forms.Button
    Friend WithEvents btnClassSche As System.Windows.Forms.Button
    Friend WithEvents btnInstructor As System.Windows.Forms.Button
    Friend WithEvents btnRoom As System.Windows.Forms.Button
    Friend WithEvents btnSection As System.Windows.Forms.Button
    Friend WithEvents btnCourseOff As System.Windows.Forms.Button
    Friend WithEvents btnVLabSche As System.Windows.Forms.Button
    Friend WithEvents brnVClassSche As System.Windows.Forms.Button
    Friend WithEvents ClassScheduleToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabScheduleToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem

End Class
