<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GenerateSchedule
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
        Me.btnGenerateSchedule = New System.Windows.Forms.Button
        Me.cmbProgram = New System.Windows.Forms.ComboBox
        Me.cmbAccyear = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbSection = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbSchool = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.btnCancel = New System.Windows.Forms.Button
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGenerateSchedule
        '
        Me.btnGenerateSchedule.Location = New System.Drawing.Point(44, 131)
        Me.btnGenerateSchedule.Name = "btnGenerateSchedule"
        Me.btnGenerateSchedule.Size = New System.Drawing.Size(135, 23)
        Me.btnGenerateSchedule.TabIndex = 8
        Me.btnGenerateSchedule.Text = "Generate Class Schedule"
        Me.btnGenerateSchedule.UseVisualStyleBackColor = True
        '
        'cmbProgram
        '
        Me.cmbProgram.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProgram.FormattingEnabled = True
        Me.cmbProgram.Location = New System.Drawing.Point(112, 39)
        Me.cmbProgram.Name = "cmbProgram"
        Me.cmbProgram.Size = New System.Drawing.Size(178, 21)
        Me.cmbProgram.TabIndex = 3
        '
        'cmbAccyear
        '
        Me.cmbAccyear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAccyear.FormattingEnabled = True
        Me.cmbAccyear.Location = New System.Drawing.Point(112, 66)
        Me.cmbAccyear.Name = "cmbAccyear"
        Me.cmbAccyear.Size = New System.Drawing.Size(121, 21)
        Me.cmbAccyear.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Program"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Accademic year"
        '
        'cmbSection
        '
        Me.cmbSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSection.FormattingEnabled = True
        Me.cmbSection.Location = New System.Drawing.Point(112, 93)
        Me.cmbSection.Name = "cmbSection"
        Me.cmbSection.Size = New System.Drawing.Size(121, 21)
        Me.cmbSection.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(54, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Section"
        '
        'cmbSchool
        '
        Me.cmbSchool.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSchool.FormattingEnabled = True
        Me.cmbSchool.Items.AddRange(New Object() {"Animal and range Science", "Behavioral science", "Bio systems and environmental engineering", "Chemical engineering", "Civil and urban engineering", "Construction technology and management", "Cooperatives", "Economics", "Education and training", "Electrical and computer engineering", "Electromechanical engineering", "Forestry", "Geography and environmental studies", "Hotel and tourism management", "Informatics", "Irrigation and water resources engineering", "Language studies", "Law", "Management and accounting", "Mathematics and statistics", "Mechanical engineering", "Medical and laboratory science", "Medicine", "Natural resource management", "Nursing and midwifery", "Plant and Horticulture Science", "Public and Environmental Health", "Veterinary medicine", "Wildlife and eco-tourism management"})
        Me.cmbSchool.Location = New System.Drawing.Point(112, 12)
        Me.cmbSchool.Name = "cmbSchool"
        Me.cmbSchool.Size = New System.Drawing.Size(192, 21)
        Me.cmbSchool.Sorted = True
        Me.cmbSchool.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(57, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "School"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(1, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(322, 186)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnCancel)
        Me.TabPage1.Controls.Add(Me.cmbProgram)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.btnGenerateSchedule)
        Me.TabPage1.Controls.Add(Me.cmbSchool)
        Me.TabPage1.Controls.Add(Me.cmbAccyear)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.cmbSection)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(314, 160)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Generate Class Schedule"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(205, 131)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'GenerateSchedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 190)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GenerateSchedule"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Generate Class Schedule"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnGenerateSchedule As System.Windows.Forms.Button
    Friend WithEvents cmbProgram As System.Windows.Forms.ComboBox
    Friend WithEvents cmbAccyear As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbSection As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbSchool As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
