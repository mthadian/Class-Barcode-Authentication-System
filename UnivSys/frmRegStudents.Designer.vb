<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegStudents
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegStudents))
        Me.pnlPicbox = New System.Windows.Forms.Panel()
        Me.lblPic = New System.Windows.Forms.Label()
        Me.picStude = New System.Windows.Forms.PictureBox()
        Me.btnPicBrowse = New System.Windows.Forms.Button()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.pnlDetails = New System.Windows.Forms.Panel()
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.lblFaculty = New System.Windows.Forms.Label()
        Me.pnlSelect = New System.Windows.Forms.Panel()
        Me.cbxFaculty = New System.Windows.Forms.ComboBox()
        Me.txtCourseCode = New System.Windows.Forms.TextBox()
        Me.lblDep = New System.Windows.Forms.Label()
        Me.txtDepCode = New System.Windows.Forms.TextBox()
        Me.cbxCourse = New System.Windows.Forms.ComboBox()
        Me.txtFacCode = New System.Windows.Forms.TextBox()
        Me.cbxDepartment = New System.Windows.Forms.ComboBox()
        Me.pnlEnter = New System.Windows.Forms.Panel()
        Me.txtSex = New System.Windows.Forms.TextBox()
        Me.RBFemale = New System.Windows.Forms.RadioButton()
        Me.RBMale = New System.Windows.Forms.RadioButton()
        Me.lblStudRegNo = New System.Windows.Forms.Label()
        Me.txtStudRegNo = New System.Windows.Forms.TextBox()
        Me.lblStudName = New System.Windows.Forms.Label()
        Me.txtStudName = New System.Windows.Forms.TextBox()
        Me.pnlPic = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.spreadStud = New AxFPSpread.AxvaSpread()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.pnlPicbox.SuspendLayout()
        CType(Me.picStude, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMain.SuspendLayout()
        Me.pnlDetails.SuspendLayout()
        Me.pnlSelect.SuspendLayout()
        Me.pnlEnter.SuspendLayout()
        Me.pnlPic.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.spreadStud, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlPicbox
        '
        Me.pnlPicbox.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pnlPicbox.Controls.Add(Me.lblPic)
        Me.pnlPicbox.Controls.Add(Me.picStude)
        Me.pnlPicbox.Location = New System.Drawing.Point(404, 19)
        Me.pnlPicbox.Name = "pnlPicbox"
        Me.pnlPicbox.Size = New System.Drawing.Size(327, 226)
        Me.pnlPicbox.TabIndex = 14
        '
        'lblPic
        '
        Me.lblPic.AutoSize = True
        Me.lblPic.Location = New System.Drawing.Point(4, 3)
        Me.lblPic.Name = "lblPic"
        Me.lblPic.Size = New System.Drawing.Size(71, 13)
        Me.lblPic.TabIndex = 14
        Me.lblPic.Text = "Add a Picture"
        '
        'picStude
        '
        Me.picStude.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picStude.Location = New System.Drawing.Point(97, 9)
        Me.picStude.Name = "picStude"
        Me.picStude.Size = New System.Drawing.Size(227, 212)
        Me.picStude.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picStude.TabIndex = 12
        Me.picStude.TabStop = False
        '
        'btnPicBrowse
        '
        Me.btnPicBrowse.Location = New System.Drawing.Point(15, 241)
        Me.btnPicBrowse.Name = "btnPicBrowse"
        Me.btnPicBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnPicBrowse.TabIndex = 13
        Me.btnPicBrowse.Text = "Browse..."
        Me.btnPicBrowse.UseVisualStyleBackColor = True
        '
        'pnlMain
        '
        Me.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlMain.Controls.Add(Me.pnlDetails)
        Me.pnlMain.Controls.Add(Me.pnlPic)
        Me.pnlMain.Location = New System.Drawing.Point(11, 3)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(821, 281)
        Me.pnlMain.TabIndex = 15
        '
        'pnlDetails
        '
        Me.pnlDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlDetails.Controls.Add(Me.lblCourse)
        Me.pnlDetails.Controls.Add(Me.lblFaculty)
        Me.pnlDetails.Controls.Add(Me.pnlSelect)
        Me.pnlDetails.Controls.Add(Me.pnlEnter)
        Me.pnlDetails.Location = New System.Drawing.Point(3, 7)
        Me.pnlDetails.Name = "pnlDetails"
        Me.pnlDetails.Size = New System.Drawing.Size(346, 267)
        Me.pnlDetails.TabIndex = 12
        '
        'lblCourse
        '
        Me.lblCourse.AutoSize = True
        Me.lblCourse.Location = New System.Drawing.Point(11, 106)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(40, 13)
        Me.lblCourse.TabIndex = 2
        Me.lblCourse.Text = "Course"
        '
        'lblFaculty
        '
        Me.lblFaculty.AutoSize = True
        Me.lblFaculty.Location = New System.Drawing.Point(7, 36)
        Me.lblFaculty.Name = "lblFaculty"
        Me.lblFaculty.Size = New System.Drawing.Size(41, 13)
        Me.lblFaculty.TabIndex = 3
        Me.lblFaculty.Text = "Faculty"
        '
        'pnlSelect
        '
        Me.pnlSelect.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlSelect.Controls.Add(Me.cbxFaculty)
        Me.pnlSelect.Controls.Add(Me.txtCourseCode)
        Me.pnlSelect.Controls.Add(Me.lblDep)
        Me.pnlSelect.Controls.Add(Me.txtDepCode)
        Me.pnlSelect.Controls.Add(Me.cbxCourse)
        Me.pnlSelect.Controls.Add(Me.txtFacCode)
        Me.pnlSelect.Controls.Add(Me.cbxDepartment)
        Me.pnlSelect.Location = New System.Drawing.Point(4, 14)
        Me.pnlSelect.Name = "pnlSelect"
        Me.pnlSelect.Size = New System.Drawing.Size(324, 130)
        Me.pnlSelect.TabIndex = 12
        '
        'cbxFaculty
        '
        Me.cbxFaculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxFaculty.FormattingEnabled = True
        Me.cbxFaculty.Location = New System.Drawing.Point(141, 13)
        Me.cbxFaculty.Name = "cbxFaculty"
        Me.cbxFaculty.Size = New System.Drawing.Size(159, 21)
        Me.cbxFaculty.TabIndex = 9
        '
        'txtCourseCode
        '
        Me.txtCourseCode.Location = New System.Drawing.Point(78, 88)
        Me.txtCourseCode.Name = "txtCourseCode"
        Me.txtCourseCode.Size = New System.Drawing.Size(49, 20)
        Me.txtCourseCode.TabIndex = 14
        '
        'lblDep
        '
        Me.lblDep.AutoSize = True
        Me.lblDep.Location = New System.Drawing.Point(3, 60)
        Me.lblDep.Name = "lblDep"
        Me.lblDep.Size = New System.Drawing.Size(62, 13)
        Me.lblDep.TabIndex = 4
        Me.lblDep.Text = "Department"
        '
        'txtDepCode
        '
        Me.txtDepCode.Location = New System.Drawing.Point(78, 52)
        Me.txtDepCode.Name = "txtDepCode"
        Me.txtDepCode.Size = New System.Drawing.Size(49, 20)
        Me.txtDepCode.TabIndex = 1
        '
        'cbxCourse
        '
        Me.cbxCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCourse.FormattingEnabled = True
        Me.cbxCourse.Location = New System.Drawing.Point(141, 87)
        Me.cbxCourse.Name = "cbxCourse"
        Me.cbxCourse.Size = New System.Drawing.Size(159, 21)
        Me.cbxCourse.TabIndex = 11
        '
        'txtFacCode
        '
        Me.txtFacCode.Location = New System.Drawing.Point(78, 13)
        Me.txtFacCode.Name = "txtFacCode"
        Me.txtFacCode.Size = New System.Drawing.Size(49, 20)
        Me.txtFacCode.TabIndex = 0
        '
        'cbxDepartment
        '
        Me.cbxDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxDepartment.FormattingEnabled = True
        Me.cbxDepartment.Location = New System.Drawing.Point(141, 52)
        Me.cbxDepartment.MaxDropDownItems = 10
        Me.cbxDepartment.Name = "cbxDepartment"
        Me.cbxDepartment.Size = New System.Drawing.Size(159, 21)
        Me.cbxDepartment.TabIndex = 10
        '
        'pnlEnter
        '
        Me.pnlEnter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlEnter.Controls.Add(Me.txtSex)
        Me.pnlEnter.Controls.Add(Me.RBFemale)
        Me.pnlEnter.Controls.Add(Me.RBMale)
        Me.pnlEnter.Controls.Add(Me.lblStudRegNo)
        Me.pnlEnter.Controls.Add(Me.txtStudRegNo)
        Me.pnlEnter.Controls.Add(Me.lblStudName)
        Me.pnlEnter.Controls.Add(Me.txtStudName)
        Me.pnlEnter.Location = New System.Drawing.Point(4, 150)
        Me.pnlEnter.Name = "pnlEnter"
        Me.pnlEnter.Size = New System.Drawing.Size(324, 110)
        Me.pnlEnter.TabIndex = 13
        '
        'txtSex
        '
        Me.txtSex.Enabled = False
        Me.txtSex.Location = New System.Drawing.Point(206, 70)
        Me.txtSex.Name = "txtSex"
        Me.txtSex.Size = New System.Drawing.Size(71, 20)
        Me.txtSex.TabIndex = 9
        Me.txtSex.Visible = False
        '
        'RBFemale
        '
        Me.RBFemale.AutoSize = True
        Me.RBFemale.Location = New System.Drawing.Point(141, 70)
        Me.RBFemale.Name = "RBFemale"
        Me.RBFemale.Size = New System.Drawing.Size(59, 17)
        Me.RBFemale.TabIndex = 8
        Me.RBFemale.TabStop = True
        Me.RBFemale.Text = "Female"
        Me.RBFemale.UseVisualStyleBackColor = True
        '
        'RBMale
        '
        Me.RBMale.AutoSize = True
        Me.RBMale.Location = New System.Drawing.Point(63, 70)
        Me.RBMale.Name = "RBMale"
        Me.RBMale.Size = New System.Drawing.Size(48, 17)
        Me.RBMale.TabIndex = 7
        Me.RBMale.TabStop = True
        Me.RBMale.Text = "Male"
        Me.RBMale.UseVisualStyleBackColor = True
        '
        'lblStudRegNo
        '
        Me.lblStudRegNo.AutoSize = True
        Me.lblStudRegNo.Location = New System.Drawing.Point(3, 44)
        Me.lblStudRegNo.Name = "lblStudRegNo"
        Me.lblStudRegNo.Size = New System.Drawing.Size(44, 13)
        Me.lblStudRegNo.TabIndex = 0
        Me.lblStudRegNo.Text = "Reg.No"
        '
        'txtStudRegNo
        '
        Me.txtStudRegNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStudRegNo.Location = New System.Drawing.Point(63, 44)
        Me.txtStudRegNo.Name = "txtStudRegNo"
        Me.txtStudRegNo.Size = New System.Drawing.Size(214, 20)
        Me.txtStudRegNo.TabIndex = 5
        '
        'lblStudName
        '
        Me.lblStudName.AutoSize = True
        Me.lblStudName.Location = New System.Drawing.Point(5, 13)
        Me.lblStudName.Name = "lblStudName"
        Me.lblStudName.Size = New System.Drawing.Size(35, 13)
        Me.lblStudName.TabIndex = 1
        Me.lblStudName.Text = "Name"
        '
        'txtStudName
        '
        Me.txtStudName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStudName.Location = New System.Drawing.Point(63, 10)
        Me.txtStudName.Name = "txtStudName"
        Me.txtStudName.Size = New System.Drawing.Size(214, 20)
        Me.txtStudName.TabIndex = 6
        '
        'pnlPic
        '
        Me.pnlPic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlPic.Controls.Add(Me.btnPicBrowse)
        Me.pnlPic.Location = New System.Drawing.Point(374, 3)
        Me.pnlPic.Name = "pnlPic"
        Me.pnlPic.Size = New System.Drawing.Size(373, 271)
        Me.pnlPic.TabIndex = 13
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.spreadStud)
        Me.Panel2.Location = New System.Drawing.Point(4, 311)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(828, 272)
        Me.Panel2.TabIndex = 16
        '
        'spreadStud
        '
        Me.spreadStud.Location = New System.Drawing.Point(3, 14)
        Me.spreadStud.Name = "spreadStud"
        Me.spreadStud.OcxState = CType(resources.GetObject("spreadStud.OcxState"), System.Windows.Forms.AxHost.State)
        Me.spreadStud.Size = New System.Drawing.Size(815, 229)
        Me.spreadStud.TabIndex = 0
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmRegStudents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(865, 583)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pnlPicbox)
        Me.Controls.Add(Me.pnlMain)
        Me.Name = "frmRegStudents"
        Me.Text = "Register Students"
        Me.pnlPicbox.ResumeLayout(False)
        Me.pnlPicbox.PerformLayout()
        CType(Me.picStude, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMain.ResumeLayout(False)
        Me.pnlDetails.ResumeLayout(False)
        Me.pnlDetails.PerformLayout()
        Me.pnlSelect.ResumeLayout(False)
        Me.pnlSelect.PerformLayout()
        Me.pnlEnter.ResumeLayout(False)
        Me.pnlEnter.PerformLayout()
        Me.pnlPic.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.spreadStud, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlPicbox As System.Windows.Forms.Panel
    Friend WithEvents lblPic As System.Windows.Forms.Label
    Friend WithEvents btnPicBrowse As System.Windows.Forms.Button
    Friend WithEvents picStude As System.Windows.Forms.PictureBox
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents spreadStud As AxFPSpread.AxvaSpread
    Friend WithEvents pnlPic As System.Windows.Forms.Panel
    Friend WithEvents pnlDetails As System.Windows.Forms.Panel
    Friend WithEvents cbxFaculty As System.Windows.Forms.ComboBox
    Friend WithEvents lblStudRegNo As System.Windows.Forms.Label
    Friend WithEvents cbxCourse As System.Windows.Forms.ComboBox
    Friend WithEvents lblCourse As System.Windows.Forms.Label
    Friend WithEvents txtStudRegNo As System.Windows.Forms.TextBox
    Friend WithEvents lblDep As System.Windows.Forms.Label
    Friend WithEvents cbxDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents txtStudName As System.Windows.Forms.TextBox
    Friend WithEvents lblStudName As System.Windows.Forms.Label
    Friend WithEvents lblFaculty As System.Windows.Forms.Label
    Friend WithEvents pnlSelect As System.Windows.Forms.Panel
    Friend WithEvents pnlEnter As System.Windows.Forms.Panel
    Friend WithEvents txtCourseCode As System.Windows.Forms.TextBox
    Friend WithEvents txtDepCode As System.Windows.Forms.TextBox
    Friend WithEvents txtFacCode As System.Windows.Forms.TextBox
    Friend WithEvents RBFemale As System.Windows.Forms.RadioButton
    Friend WithEvents RBMale As System.Windows.Forms.RadioButton
    Friend WithEvents txtSex As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
