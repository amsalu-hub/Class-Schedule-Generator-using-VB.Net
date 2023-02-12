<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExamRegistration
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
        Me.btncancel = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtTimeallowed = New System.Windows.Forms.TextBox
        Me.cmbaccyear = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.cmbprog = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmbtid = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbcid = New System.Windows.Forms.ComboBox
        Me.cmbsection = New System.Windows.Forms.ComboBox
        Me.txtInvagilators_name = New System.Windows.Forms.TextBox
        Me.txtExaminar_name = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btncancel
        '
        Me.btncancel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btncancel.Location = New System.Drawing.Point(320, 199)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 23)
        Me.btncancel.TabIndex = 2
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnsave.Location = New System.Drawing.Point(230, 199)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 1
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTimeallowed)
        Me.GroupBox1.Controls.Add(Me.cmbaccyear)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cmbprog)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cmbtid)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmbcid)
        Me.GroupBox1.Controls.Add(Me.cmbsection)
        Me.GroupBox1.Controls.Add(Me.txtInvagilators_name)
        Me.GroupBox1.Controls.Add(Me.txtExaminar_name)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(501, 172)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Exam Details"
        '
        'txtTimeallowed
        '
        Me.txtTimeallowed.Location = New System.Drawing.Point(347, 139)
        Me.txtTimeallowed.Name = "txtTimeallowed"
        Me.txtTimeallowed.Size = New System.Drawing.Size(135, 20)
        Me.txtTimeallowed.TabIndex = 15
        '
        'cmbaccyear
        '
        Me.cmbaccyear.FormattingEnabled = True
        Me.cmbaccyear.Location = New System.Drawing.Point(107, 111)
        Me.cmbaccyear.Name = "cmbaccyear"
        Me.cmbaccyear.Size = New System.Drawing.Size(135, 21)
        Me.cmbaccyear.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(16, 119)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Accademic year"
        '
        'cmbprog
        '
        Me.cmbprog.FormattingEnabled = True
        Me.cmbprog.Location = New System.Drawing.Point(107, 84)
        Me.cmbprog.Name = "cmbprog"
        Me.cmbprog.Size = New System.Drawing.Size(135, 21)
        Me.cmbprog.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(53, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Program"
        '
        'cmbtid
        '
        Me.cmbtid.FormattingEnabled = True
        Me.cmbtid.Location = New System.Drawing.Point(107, 56)
        Me.cmbtid.Name = "cmbtid"
        Me.cmbtid.Size = New System.Drawing.Size(135, 21)
        Me.cmbtid.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(38, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Teacher ID"
        '
        'cmbcid
        '
        Me.cmbcid.FormattingEnabled = True
        Me.cmbcid.Location = New System.Drawing.Point(107, 29)
        Me.cmbcid.Name = "cmbcid"
        Me.cmbcid.Size = New System.Drawing.Size(135, 21)
        Me.cmbcid.TabIndex = 1
        '
        'cmbsection
        '
        Me.cmbsection.FormattingEnabled = True
        Me.cmbsection.Location = New System.Drawing.Point(107, 138)
        Me.cmbsection.Name = "cmbsection"
        Me.cmbsection.Size = New System.Drawing.Size(135, 21)
        Me.cmbsection.TabIndex = 9
        '
        'txtInvagilators_name
        '
        Me.txtInvagilators_name.Location = New System.Drawing.Point(347, 29)
        Me.txtInvagilators_name.Multiline = True
        Me.txtInvagilators_name.Name = "txtInvagilators_name"
        Me.txtInvagilators_name.Size = New System.Drawing.Size(135, 43)
        Me.txtInvagilators_name.TabIndex = 11
        '
        'txtExaminar_name
        '
        Me.txtExaminar_name.Location = New System.Drawing.Point(347, 84)
        Me.txtExaminar_name.Multiline = True
        Me.txtExaminar_name.Name = "txtExaminar_name"
        Me.txtExaminar_name.Size = New System.Drawing.Size(135, 44)
        Me.txtExaminar_name.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(56, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Section"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(45, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Course ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(248, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Examinar(s) name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(272, 146)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Time allowed"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(246, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Invagilator(s) name"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(0, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(532, 251)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.btncancel)
        Me.TabPage1.Controls.Add(Me.btnsave)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(524, 225)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Add Exam"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ExamRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 252)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ExamRegistration"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Exam Registration"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtInvagilators_name As System.Windows.Forms.TextBox
    Friend WithEvents txtExaminar_name As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbsection As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbaccyear As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbprog As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbtid As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbcid As System.Windows.Forms.ComboBox
    Friend WithEvents txtTimeallowed As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
End Class
