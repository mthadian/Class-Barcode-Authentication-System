<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLecForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLecForm))
        Me.cbxUnitName = New System.Windows.Forms.ComboBox()
        Me.lblUnitName = New System.Windows.Forms.Label()
        Me.lblUnitCode = New System.Windows.Forms.Label()
        Me.pnlCourses = New System.Windows.Forms.Panel()
        Me.txtStudAtend = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbxUnitStud = New System.Windows.Forms.ComboBox()
        Me.lblSelectUnit = New System.Windows.Forms.Label()
        Me.spreadStudLec = New AxFPSpread.AxvaSpread()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbltimeguide = New System.Windows.Forms.Label()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.txtRoom = New System.Windows.Forms.TextBox()
        Me.cbxDay = New System.Windows.Forms.ComboBox()
        Me.lblRoom = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtUnitCode = New System.Windows.Forms.TextBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.pnlDetails = New System.Windows.Forms.Panel()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.spreadLecUnits = New AxFPSpread.AxvaSpread()
        Me.RBFemale = New System.Windows.Forms.RadioButton()
        Me.RBMale = New System.Windows.Forms.RadioButton()
        Me.lblPic = New System.Windows.Forms.Label()
        Me.pnlPicbox = New System.Windows.Forms.Panel()
        Me.btnPicBrowse = New System.Windows.Forms.Button()
        Me.PicLec = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtSex = New System.Windows.Forms.TextBox()
        Me.txtLecName = New System.Windows.Forms.TextBox()
        Me.txtLecId = New System.Windows.Forms.TextBox()
        Me.lblLecName = New System.Windows.Forms.Label()
        Me.lblLecId = New System.Windows.Forms.Label()
        Me.lblSex = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtDepCode = New System.Windows.Forms.TextBox()
        Me.txtFacCode = New System.Windows.Forms.TextBox()
        Me.lblLecFaculty = New System.Windows.Forms.Label()
        Me.cbxFaculty = New System.Windows.Forms.ComboBox()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.cbxDep = New System.Windows.Forms.ComboBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblProfileName = New System.Windows.Forms.Label()
        Me.pnlCourses.SuspendLayout()
        CType(Me.spreadStudLec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.pnlDetails.SuspendLayout()
        CType(Me.spreadLecUnits, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPicbox.SuspendLayout()
        CType(Me.PicLec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbxUnitName
        '
        Me.cbxUnitName.FormattingEnabled = True
        Me.cbxUnitName.Location = New System.Drawing.Point(93, 14)
        Me.cbxUnitName.Name = "cbxUnitName"
        Me.cbxUnitName.Size = New System.Drawing.Size(142, 21)
        Me.cbxUnitName.TabIndex = 36
        '
        'lblUnitName
        '
        Me.lblUnitName.AutoSize = True
        Me.lblUnitName.Location = New System.Drawing.Point(19, 17)
        Me.lblUnitName.Name = "lblUnitName"
        Me.lblUnitName.Size = New System.Drawing.Size(57, 13)
        Me.lblUnitName.TabIndex = 35
        Me.lblUnitName.Text = "Unit Name"
        '
        'lblUnitCode
        '
        Me.lblUnitCode.AutoSize = True
        Me.lblUnitCode.Location = New System.Drawing.Point(19, 45)
        Me.lblUnitCode.Name = "lblUnitCode"
        Me.lblUnitCode.Size = New System.Drawing.Size(54, 13)
        Me.lblUnitCode.TabIndex = 34
        Me.lblUnitCode.Text = "Unit Code"
        '
        'pnlCourses
        '
        Me.pnlCourses.BackColor = System.Drawing.Color.Transparent
        Me.pnlCourses.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlCourses.Controls.Add(Me.txtStudAtend)
        Me.pnlCourses.Controls.Add(Me.Label2)
        Me.pnlCourses.Controls.Add(Me.cbxUnitStud)
        Me.pnlCourses.Controls.Add(Me.lblSelectUnit)
        Me.pnlCourses.Controls.Add(Me.spreadStudLec)
        Me.pnlCourses.Controls.Add(Me.Panel1)
        Me.pnlCourses.Location = New System.Drawing.Point(48, 304)
        Me.pnlCourses.Name = "pnlCourses"
        Me.pnlCourses.Size = New System.Drawing.Size(976, 294)
        Me.pnlCourses.TabIndex = 38
        '
        'txtStudAtend
        '
        Me.txtStudAtend.Location = New System.Drawing.Point(859, 11)
        Me.txtStudAtend.Name = "txtStudAtend"
        Me.txtStudAtend.Size = New System.Drawing.Size(53, 20)
        Me.txtStudAtend.TabIndex = 46
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(745, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Student Details"
        '
        'cbxUnitStud
        '
        Me.cbxUnitStud.FormattingEnabled = True
        Me.cbxUnitStud.Location = New System.Drawing.Point(618, 14)
        Me.cbxUnitStud.Name = "cbxUnitStud"
        Me.cbxUnitStud.Size = New System.Drawing.Size(121, 21)
        Me.cbxUnitStud.TabIndex = 44
        '
        'lblSelectUnit
        '
        Me.lblSelectUnit.AutoSize = True
        Me.lblSelectUnit.Location = New System.Drawing.Point(553, 17)
        Me.lblSelectUnit.Name = "lblSelectUnit"
        Me.lblSelectUnit.Size = New System.Drawing.Size(62, 13)
        Me.lblSelectUnit.TabIndex = 43
        Me.lblSelectUnit.Text = "Select Unit:"
        '
        'spreadStudLec
        '
        Me.spreadStudLec.Location = New System.Drawing.Point(348, 33)
        Me.spreadStudLec.Name = "spreadStudLec"
        Me.spreadStudLec.OcxState = CType(resources.GetObject("spreadStudLec.OcxState"), System.Windows.Forms.AxHost.State)
        Me.spreadStudLec.Size = New System.Drawing.Size(606, 235)
        Me.spreadStudLec.TabIndex = 42
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.lbltimeguide)
        Me.Panel1.Controls.Add(Me.txtTime)
        Me.Panel1.Controls.Add(Me.txtRoom)
        Me.Panel1.Controls.Add(Me.cbxDay)
        Me.Panel1.Controls.Add(Me.lblRoom)
        Me.Panel1.Controls.Add(Me.lblTime)
        Me.Panel1.Controls.Add(Me.lblDay)
        Me.Panel1.Controls.Add(Me.txtDescription)
        Me.Panel1.Controls.Add(Me.cbxUnitName)
        Me.Panel1.Controls.Add(Me.txtUnitCode)
        Me.Panel1.Controls.Add(Me.lblDescription)
        Me.Panel1.Controls.Add(Me.lblUnitCode)
        Me.Panel1.Controls.Add(Me.lblUnitName)
        Me.Panel1.Location = New System.Drawing.Point(3, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(295, 237)
        Me.Panel1.TabIndex = 41
        '
        'lbltimeguide
        '
        Me.lbltimeguide.AutoSize = True
        Me.lbltimeguide.Location = New System.Drawing.Point(85, 105)
        Me.lbltimeguide.Name = "lbltimeguide"
        Me.lbltimeguide.Size = New System.Drawing.Size(107, 13)
        Me.lbltimeguide.TabIndex = 50
        Me.lbltimeguide.Text = "eg:10.00am-12.30pm"
        '
        'txtTime
        '
        Me.txtTime.Location = New System.Drawing.Point(93, 121)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(140, 20)
        Me.txtTime.TabIndex = 49
        '
        'txtRoom
        '
        Me.txtRoom.Location = New System.Drawing.Point(95, 153)
        Me.txtRoom.Name = "txtRoom"
        Me.txtRoom.Size = New System.Drawing.Size(140, 20)
        Me.txtRoom.TabIndex = 48
        '
        'cbxDay
        '
        Me.cbxDay.FormattingEnabled = True
        Me.cbxDay.Items.AddRange(New Object() {"MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY"})
        Me.cbxDay.Location = New System.Drawing.Point(93, 74)
        Me.cbxDay.Name = "cbxDay"
        Me.cbxDay.Size = New System.Drawing.Size(142, 21)
        Me.cbxDay.TabIndex = 47
        '
        'lblRoom
        '
        Me.lblRoom.AutoSize = True
        Me.lblRoom.Location = New System.Drawing.Point(37, 153)
        Me.lblRoom.Name = "lblRoom"
        Me.lblRoom.Size = New System.Drawing.Size(35, 13)
        Me.lblRoom.TabIndex = 46
        Me.lblRoom.Text = "Room"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(37, 124)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(30, 13)
        Me.lblTime.TabIndex = 44
        Me.lblTime.Text = "Time"
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.Location = New System.Drawing.Point(40, 82)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(26, 13)
        Me.lblDay.TabIndex = 43
        Me.lblDay.Text = "Day"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(88, 186)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(147, 30)
        Me.txtDescription.TabIndex = 39
        '
        'txtUnitCode
        '
        Me.txtUnitCode.Location = New System.Drawing.Point(93, 42)
        Me.txtUnitCode.Name = "txtUnitCode"
        Me.txtUnitCode.Size = New System.Drawing.Size(142, 20)
        Me.txtUnitCode.TabIndex = 42
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(6, 203)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(60, 13)
        Me.lblDescription.TabIndex = 38
        Me.lblDescription.Text = "Description"
        '
        'pnlDetails
        '
        Me.pnlDetails.BackColor = System.Drawing.Color.Transparent
        Me.pnlDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlDetails.Controls.Add(Me.btnDelete)
        Me.pnlDetails.Controls.Add(Me.spreadLecUnits)
        Me.pnlDetails.Controls.Add(Me.RBFemale)
        Me.pnlDetails.Controls.Add(Me.RBMale)
        Me.pnlDetails.Controls.Add(Me.lblPic)
        Me.pnlDetails.Controls.Add(Me.pnlPicbox)
        Me.pnlDetails.Controls.Add(Me.Panel2)
        Me.pnlDetails.Controls.Add(Me.Panel3)
        Me.pnlDetails.Location = New System.Drawing.Point(48, 40)
        Me.pnlDetails.Name = "pnlDetails"
        Me.pnlDetails.Size = New System.Drawing.Size(976, 258)
        Me.pnlDetails.TabIndex = 39
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(400, 5)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 22
        Me.btnDelete.Text = "Delete Unit"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'spreadLecUnits
        '
        Me.spreadLecUnits.Location = New System.Drawing.Point(374, 34)
        Me.spreadLecUnits.Name = "spreadLecUnits"
        Me.spreadLecUnits.OcxState = CType(resources.GetObject("spreadLecUnits.OcxState"), System.Windows.Forms.AxHost.State)
        Me.spreadLecUnits.Size = New System.Drawing.Size(348, 187)
        Me.spreadLecUnits.TabIndex = 21
        '
        'RBFemale
        '
        Me.RBFemale.AutoSize = True
        Me.RBFemale.Location = New System.Drawing.Point(157, 88)
        Me.RBFemale.Name = "RBFemale"
        Me.RBFemale.Size = New System.Drawing.Size(59, 17)
        Me.RBFemale.TabIndex = 17
        Me.RBFemale.TabStop = True
        Me.RBFemale.Text = "Female"
        Me.RBFemale.UseVisualStyleBackColor = True
        '
        'RBMale
        '
        Me.RBMale.AutoSize = True
        Me.RBMale.Location = New System.Drawing.Point(103, 86)
        Me.RBMale.Name = "RBMale"
        Me.RBMale.Size = New System.Drawing.Size(48, 17)
        Me.RBMale.TabIndex = 16
        Me.RBMale.TabStop = True
        Me.RBMale.Text = "Male"
        Me.RBMale.UseVisualStyleBackColor = True
        '
        'lblPic
        '
        Me.lblPic.AutoSize = True
        Me.lblPic.Location = New System.Drawing.Point(728, 2)
        Me.lblPic.Name = "lblPic"
        Me.lblPic.Size = New System.Drawing.Size(71, 13)
        Me.lblPic.TabIndex = 14
        Me.lblPic.Text = "Add a Picture"
        '
        'pnlPicbox
        '
        Me.pnlPicbox.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pnlPicbox.Controls.Add(Me.btnPicBrowse)
        Me.pnlPicbox.Controls.Add(Me.PicLec)
        Me.pnlPicbox.Location = New System.Drawing.Point(731, 18)
        Me.pnlPicbox.Name = "pnlPicbox"
        Me.pnlPicbox.Size = New System.Drawing.Size(238, 231)
        Me.pnlPicbox.TabIndex = 13
        '
        'btnPicBrowse
        '
        Me.btnPicBrowse.Location = New System.Drawing.Point(39, 209)
        Me.btnPicBrowse.Name = "btnPicBrowse"
        Me.btnPicBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnPicBrowse.TabIndex = 13
        Me.btnPicBrowse.Text = "Browse..."
        Me.btnPicBrowse.UseVisualStyleBackColor = True
        '
        'PicLec
        '
        Me.PicLec.Location = New System.Drawing.Point(9, 16)
        Me.PicLec.Name = "PicLec"
        Me.PicLec.Size = New System.Drawing.Size(214, 187)
        Me.PicLec.TabIndex = 12
        Me.PicLec.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.txtSex)
        Me.Panel2.Controls.Add(Me.txtLecName)
        Me.Panel2.Controls.Add(Me.txtLecId)
        Me.Panel2.Controls.Add(Me.lblLecName)
        Me.Panel2.Controls.Add(Me.lblLecId)
        Me.Panel2.Controls.Add(Me.lblSex)
        Me.Panel2.Location = New System.Drawing.Point(3, 13)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(365, 108)
        Me.Panel2.TabIndex = 19
        '
        'txtSex
        '
        Me.txtSex.Location = New System.Drawing.Point(216, 71)
        Me.txtSex.Name = "txtSex"
        Me.txtSex.Size = New System.Drawing.Size(65, 20)
        Me.txtSex.TabIndex = 18
        '
        'txtLecName
        '
        Me.txtLecName.Location = New System.Drawing.Point(98, 35)
        Me.txtLecName.Name = "txtLecName"
        Me.txtLecName.Size = New System.Drawing.Size(183, 20)
        Me.txtLecName.TabIndex = 16
        '
        'txtLecId
        '
        Me.txtLecId.Location = New System.Drawing.Point(98, 3)
        Me.txtLecId.Name = "txtLecId"
        Me.txtLecId.Size = New System.Drawing.Size(183, 20)
        Me.txtLecId.TabIndex = 8
        '
        'lblLecName
        '
        Me.lblLecName.AutoSize = True
        Me.lblLecName.Location = New System.Drawing.Point(6, 35)
        Me.lblLecName.Name = "lblLecName"
        Me.lblLecName.Size = New System.Drawing.Size(77, 13)
        Me.lblLecName.TabIndex = 1
        Me.lblLecName.Text = "Lecturer Name"
        '
        'lblLecId
        '
        Me.lblLecId.AutoSize = True
        Me.lblLecId.Location = New System.Drawing.Point(6, 6)
        Me.lblLecId.Name = "lblLecId"
        Me.lblLecId.Size = New System.Drawing.Size(60, 13)
        Me.lblLecId.TabIndex = 0
        Me.lblLecId.Text = "Lecturer ID"
        '
        'lblSex
        '
        Me.lblSex.AutoSize = True
        Me.lblSex.Location = New System.Drawing.Point(6, 73)
        Me.lblSex.Name = "lblSex"
        Me.lblSex.Size = New System.Drawing.Size(42, 13)
        Me.lblSex.TabIndex = 15
        Me.lblSex.Text = "Gender"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.txtDepCode)
        Me.Panel3.Controls.Add(Me.txtFacCode)
        Me.Panel3.Controls.Add(Me.lblLecFaculty)
        Me.Panel3.Controls.Add(Me.cbxFaculty)
        Me.Panel3.Controls.Add(Me.lblDepartment)
        Me.Panel3.Controls.Add(Me.cbxDep)
        Me.Panel3.Location = New System.Drawing.Point(3, 133)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(365, 116)
        Me.Panel3.TabIndex = 20
        '
        'txtDepCode
        '
        Me.txtDepCode.Location = New System.Drawing.Point(93, 61)
        Me.txtDepCode.Name = "txtDepCode"
        Me.txtDepCode.Size = New System.Drawing.Size(53, 20)
        Me.txtDepCode.TabIndex = 9
        '
        'txtFacCode
        '
        Me.txtFacCode.Location = New System.Drawing.Point(93, 18)
        Me.txtFacCode.Name = "txtFacCode"
        Me.txtFacCode.Size = New System.Drawing.Size(58, 20)
        Me.txtFacCode.TabIndex = 8
        '
        'lblLecFaculty
        '
        Me.lblLecFaculty.AutoSize = True
        Me.lblLecFaculty.Location = New System.Drawing.Point(4, 21)
        Me.lblLecFaculty.Name = "lblLecFaculty"
        Me.lblLecFaculty.Size = New System.Drawing.Size(41, 13)
        Me.lblLecFaculty.TabIndex = 4
        Me.lblLecFaculty.Text = "Faculty"
        '
        'cbxFaculty
        '
        Me.cbxFaculty.FormattingEnabled = True
        Me.cbxFaculty.Location = New System.Drawing.Point(152, 18)
        Me.cbxFaculty.Name = "cbxFaculty"
        Me.cbxFaculty.Size = New System.Drawing.Size(183, 21)
        Me.cbxFaculty.TabIndex = 7
        '
        'lblDepartment
        '
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.Location = New System.Drawing.Point(4, 70)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(62, 13)
        Me.lblDepartment.TabIndex = 5
        Me.lblDepartment.Text = "Department"
        '
        'cbxDep
        '
        Me.cbxDep.FormattingEnabled = True
        Me.cbxDep.Location = New System.Drawing.Point(152, 62)
        Me.cbxDep.Name = "cbxDep"
        Me.cbxDep.Size = New System.Drawing.Size(183, 21)
        Me.cbxDep.TabIndex = 6
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(89, 12)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(100, 20)
        Me.txtUser.TabIndex = 40
        Me.txtUser.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnLogOut
        '
        Me.btnLogOut.Location = New System.Drawing.Point(770, 14)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(75, 23)
        Me.btnLogOut.TabIndex = 41
        Me.btnLogOut.Text = "Logout"
        Me.btnLogOut.UseVisualStyleBackColor = True
        Me.btnLogOut.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(426, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 13)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Your  are logged in as"
        '
        'lblProfileName
        '
        Me.lblProfileName.AutoSize = True
        Me.lblProfileName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProfileName.ForeColor = System.Drawing.Color.Blue
        Me.lblProfileName.Location = New System.Drawing.Point(542, 9)
        Me.lblProfileName.Name = "lblProfileName"
        Me.lblProfileName.Size = New System.Drawing.Size(55, 20)
        Me.lblProfileName.TabIndex = 43
        Me.lblProfileName.Text = "Name"
        '
        'frmLecForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1069, 646)
        Me.Controls.Add(Me.pnlDetails)
        Me.Controls.Add(Me.lblProfileName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLogOut)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.pnlCourses)
        Me.Name = "frmLecForm"
        Me.Text = "Lecturer Form"
        Me.pnlCourses.ResumeLayout(False)
        Me.pnlCourses.PerformLayout()
        CType(Me.spreadStudLec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlDetails.ResumeLayout(False)
        Me.pnlDetails.PerformLayout()
        CType(Me.spreadLecUnits, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPicbox.ResumeLayout(False)
        CType(Me.PicLec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbxUnitName As System.Windows.Forms.ComboBox
    Friend WithEvents lblUnitName As System.Windows.Forms.Label
    Friend WithEvents lblUnitCode As System.Windows.Forms.Label
    Friend WithEvents pnlCourses As System.Windows.Forms.Panel
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pnlDetails As System.Windows.Forms.Panel
    Friend WithEvents txtSex As System.Windows.Forms.TextBox
    Friend WithEvents RBFemale As System.Windows.Forms.RadioButton
    Friend WithEvents RBMale As System.Windows.Forms.RadioButton
    Friend WithEvents lblPic As System.Windows.Forms.Label
    Friend WithEvents pnlPicbox As System.Windows.Forms.Panel
    Friend WithEvents btnPicBrowse As System.Windows.Forms.Button
    Friend WithEvents PicLec As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtLecId As System.Windows.Forms.TextBox
    Friend WithEvents lblLecName As System.Windows.Forms.Label
    Friend WithEvents lblLecId As System.Windows.Forms.Label
    Friend WithEvents lblSex As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblLecFaculty As System.Windows.Forms.Label
    Friend WithEvents cbxFaculty As System.Windows.Forms.ComboBox
    Friend WithEvents lblDepartment As System.Windows.Forms.Label
    Friend WithEvents cbxDep As System.Windows.Forms.ComboBox
    Friend WithEvents txtLecName As System.Windows.Forms.TextBox
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtDepCode As System.Windows.Forms.TextBox
    Friend WithEvents txtFacCode As System.Windows.Forms.TextBox
    Friend WithEvents txtUnitCode As System.Windows.Forms.TextBox
    Friend WithEvents btnLogOut As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblProfileName As System.Windows.Forms.Label
    Friend WithEvents spreadStudLec As AxFPSpread.AxvaSpread
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbxUnitStud As System.Windows.Forms.ComboBox
    Friend WithEvents lblSelectUnit As System.Windows.Forms.Label
    Friend WithEvents txtStudAtend As System.Windows.Forms.TextBox
    Friend WithEvents spreadLecUnits As AxFPSpread.AxvaSpread
    Friend WithEvents cbxDay As System.Windows.Forms.ComboBox
    Friend WithEvents lblRoom As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblDay As System.Windows.Forms.Label
    Friend WithEvents txtRoom As System.Windows.Forms.TextBox
    Friend WithEvents txtTime As System.Windows.Forms.TextBox
    Friend WithEvents lbltimeguide As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Button
End Class
