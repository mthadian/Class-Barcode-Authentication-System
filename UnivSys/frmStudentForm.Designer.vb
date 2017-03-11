<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudentForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStudentForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.spreadLoadAllRegistered = New AxFPSpread.AxvaSpread()
        Me.pnlPicbox = New System.Windows.Forms.Panel()
        Me.btnSavePic = New System.Windows.Forms.Button()
        Me.btnPicBrowse = New System.Windows.Forms.Button()
        Me.PicStude = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.pnlFacDep = New System.Windows.Forms.Panel()
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.cbxFaculty = New System.Windows.Forms.ComboBox()
        Me.txtCourseCode = New System.Windows.Forms.TextBox()
        Me.lblDep = New System.Windows.Forms.Label()
        Me.txtDepCode = New System.Windows.Forms.TextBox()
        Me.cbxCourse = New System.Windows.Forms.ComboBox()
        Me.txtFacCode = New System.Windows.Forms.TextBox()
        Me.cbxDepartment = New System.Windows.Forms.ComboBox()
        Me.lblFaculty = New System.Windows.Forms.Label()
        Me.pnlStudName = New System.Windows.Forms.Panel()
        Me.txtSex = New System.Windows.Forms.TextBox()
        Me.lblSex = New System.Windows.Forms.Label()
        Me.lblStudName = New System.Windows.Forms.Label()
        Me.txtStudRegNo = New System.Windows.Forms.TextBox()
        Me.lblStudRegNo = New System.Windows.Forms.Label()
        Me.txtStudName = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnDoneAdding = New System.Windows.Forms.Button()
        Me.btnShowpanel = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.pnlRegUnits = New System.Windows.Forms.Panel()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.btnNewUnit = New System.Windows.Forms.Button()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.spreadUnits = New AxFPSpread.AxvaSpread()
        Me.spreadMoveUnits = New AxFPSpread.AxvaSpread()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cbxTime = New System.Windows.Forms.ComboBox()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.cbxFacSearch = New System.Windows.Forms.ComboBox()
        Me.txtUnitName = New System.Windows.Forms.TextBox()
        Me.cbxDepSearch = New System.Windows.Forms.ComboBox()
        Me.txtUnitCode = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblLogAs = New System.Windows.Forms.Label()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.spreadLoadAllRegistered, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPicbox.SuspendLayout()
        CType(Me.PicStude, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.pnlFacDep.SuspendLayout()
        Me.pnlStudName.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.pnlRegUnits.SuspendLayout()
        CType(Me.spreadUnits, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spreadMoveUnits, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.spreadLoadAllRegistered)
        Me.Panel1.Controls.Add(Me.pnlPicbox)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Location = New System.Drawing.Point(12, 34)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1032, 282)
        Me.Panel1.TabIndex = 17
        '
        'spreadLoadAllRegistered
        '
        Me.spreadLoadAllRegistered.Location = New System.Drawing.Point(327, 51)
        Me.spreadLoadAllRegistered.Name = "spreadLoadAllRegistered"
        Me.spreadLoadAllRegistered.OcxState = CType(resources.GetObject("spreadLoadAllRegistered.OcxState"), System.Windows.Forms.AxHost.State)
        Me.spreadLoadAllRegistered.Size = New System.Drawing.Size(473, 195)
        Me.spreadLoadAllRegistered.TabIndex = 17
        '
        'pnlPicbox
        '
        Me.pnlPicbox.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pnlPicbox.Controls.Add(Me.btnSavePic)
        Me.pnlPicbox.Controls.Add(Me.btnPicBrowse)
        Me.pnlPicbox.Controls.Add(Me.PicStude)
        Me.pnlPicbox.Location = New System.Drawing.Point(820, 23)
        Me.pnlPicbox.Name = "pnlPicbox"
        Me.pnlPicbox.Size = New System.Drawing.Size(197, 207)
        Me.pnlPicbox.TabIndex = 16
        '
        'btnSavePic
        '
        Me.btnSavePic.Location = New System.Drawing.Point(133, 183)
        Me.btnSavePic.Name = "btnSavePic"
        Me.btnSavePic.Size = New System.Drawing.Size(75, 23)
        Me.btnSavePic.TabIndex = 23
        Me.btnSavePic.Text = "Save"
        Me.btnSavePic.UseVisualStyleBackColor = True
        Me.btnSavePic.Visible = False
        '
        'btnPicBrowse
        '
        Me.btnPicBrowse.Location = New System.Drawing.Point(3, 183)
        Me.btnPicBrowse.Name = "btnPicBrowse"
        Me.btnPicBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnPicBrowse.TabIndex = 13
        Me.btnPicBrowse.Text = "Browse..."
        Me.btnPicBrowse.UseVisualStyleBackColor = True
        Me.btnPicBrowse.Visible = False
        '
        'PicStude
        '
        Me.PicStude.Location = New System.Drawing.Point(15, 12)
        Me.PicStude.Name = "PicStude"
        Me.PicStude.Size = New System.Drawing.Size(167, 161)
        Me.PicStude.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicStude.TabIndex = 12
        Me.PicStude.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.pnlFacDep)
        Me.Panel3.Controls.Add(Me.pnlStudName)
        Me.Panel3.Location = New System.Drawing.Point(4, 15)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(308, 260)
        Me.Panel3.TabIndex = 12
        '
        'pnlFacDep
        '
        Me.pnlFacDep.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlFacDep.Controls.Add(Me.lblCourse)
        Me.pnlFacDep.Controls.Add(Me.cbxFaculty)
        Me.pnlFacDep.Controls.Add(Me.txtCourseCode)
        Me.pnlFacDep.Controls.Add(Me.lblDep)
        Me.pnlFacDep.Controls.Add(Me.txtDepCode)
        Me.pnlFacDep.Controls.Add(Me.cbxCourse)
        Me.pnlFacDep.Controls.Add(Me.txtFacCode)
        Me.pnlFacDep.Controls.Add(Me.cbxDepartment)
        Me.pnlFacDep.Controls.Add(Me.lblFaculty)
        Me.pnlFacDep.Location = New System.Drawing.Point(6, 119)
        Me.pnlFacDep.Name = "pnlFacDep"
        Me.pnlFacDep.Size = New System.Drawing.Size(293, 125)
        Me.pnlFacDep.TabIndex = 15
        '
        'lblCourse
        '
        Me.lblCourse.AutoSize = True
        Me.lblCourse.Location = New System.Drawing.Point(9, 91)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(40, 13)
        Me.lblCourse.TabIndex = 15
        Me.lblCourse.Text = "Course"
        '
        'cbxFaculty
        '
        Me.cbxFaculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbxFaculty.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxFaculty.FormattingEnabled = True
        Me.cbxFaculty.Location = New System.Drawing.Point(123, 13)
        Me.cbxFaculty.Name = "cbxFaculty"
        Me.cbxFaculty.Size = New System.Drawing.Size(140, 21)
        Me.cbxFaculty.TabIndex = 9
        '
        'txtCourseCode
        '
        Me.txtCourseCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCourseCode.Location = New System.Drawing.Point(71, 88)
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
        Me.txtDepCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDepCode.Location = New System.Drawing.Point(71, 52)
        Me.txtDepCode.Name = "txtDepCode"
        Me.txtDepCode.Size = New System.Drawing.Size(49, 20)
        Me.txtDepCode.TabIndex = 1
        '
        'cbxCourse
        '
        Me.cbxCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbxCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxCourse.FormattingEnabled = True
        Me.cbxCourse.Location = New System.Drawing.Point(123, 89)
        Me.cbxCourse.Name = "cbxCourse"
        Me.cbxCourse.Size = New System.Drawing.Size(140, 21)
        Me.cbxCourse.TabIndex = 11
        '
        'txtFacCode
        '
        Me.txtFacCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFacCode.Location = New System.Drawing.Point(71, 13)
        Me.txtFacCode.Name = "txtFacCode"
        Me.txtFacCode.Size = New System.Drawing.Size(49, 20)
        Me.txtFacCode.TabIndex = 0
        '
        'cbxDepartment
        '
        Me.cbxDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbxDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxDepartment.FormattingEnabled = True
        Me.cbxDepartment.Location = New System.Drawing.Point(123, 52)
        Me.cbxDepartment.MaxDropDownItems = 10
        Me.cbxDepartment.Name = "cbxDepartment"
        Me.cbxDepartment.Size = New System.Drawing.Size(140, 21)
        Me.cbxDepartment.TabIndex = 10
        '
        'lblFaculty
        '
        Me.lblFaculty.AutoSize = True
        Me.lblFaculty.Location = New System.Drawing.Point(8, 20)
        Me.lblFaculty.Name = "lblFaculty"
        Me.lblFaculty.Size = New System.Drawing.Size(41, 13)
        Me.lblFaculty.TabIndex = 3
        Me.lblFaculty.Text = "Faculty"
        '
        'pnlStudName
        '
        Me.pnlStudName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlStudName.Controls.Add(Me.txtSex)
        Me.pnlStudName.Controls.Add(Me.lblSex)
        Me.pnlStudName.Controls.Add(Me.lblStudName)
        Me.pnlStudName.Controls.Add(Me.txtStudRegNo)
        Me.pnlStudName.Controls.Add(Me.lblStudRegNo)
        Me.pnlStudName.Controls.Add(Me.txtStudName)
        Me.pnlStudName.Location = New System.Drawing.Point(3, 8)
        Me.pnlStudName.Name = "pnlStudName"
        Me.pnlStudName.Size = New System.Drawing.Size(296, 105)
        Me.pnlStudName.TabIndex = 16
        '
        'txtSex
        '
        Me.txtSex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSex.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSex.Location = New System.Drawing.Point(55, 78)
        Me.txtSex.Name = "txtSex"
        Me.txtSex.Size = New System.Drawing.Size(53, 20)
        Me.txtSex.TabIndex = 8
        '
        'lblSex
        '
        Me.lblSex.AutoSize = True
        Me.lblSex.Location = New System.Drawing.Point(11, 80)
        Me.lblSex.Name = "lblSex"
        Me.lblSex.Size = New System.Drawing.Size(25, 13)
        Me.lblSex.TabIndex = 7
        Me.lblSex.Text = "Sex"
        '
        'lblStudName
        '
        Me.lblStudName.AutoSize = True
        Me.lblStudName.Location = New System.Drawing.Point(8, 45)
        Me.lblStudName.Name = "lblStudName"
        Me.lblStudName.Size = New System.Drawing.Size(35, 13)
        Me.lblStudName.TabIndex = 1
        Me.lblStudName.Text = "Name"
        '
        'txtStudRegNo
        '
        Me.txtStudRegNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStudRegNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudRegNo.Location = New System.Drawing.Point(51, 7)
        Me.txtStudRegNo.Name = "txtStudRegNo"
        Me.txtStudRegNo.Size = New System.Drawing.Size(193, 20)
        Me.txtStudRegNo.TabIndex = 5
        '
        'lblStudRegNo
        '
        Me.lblStudRegNo.AutoSize = True
        Me.lblStudRegNo.Location = New System.Drawing.Point(1, 7)
        Me.lblStudRegNo.Name = "lblStudRegNo"
        Me.lblStudRegNo.Size = New System.Drawing.Size(44, 13)
        Me.lblStudRegNo.TabIndex = 0
        Me.lblStudRegNo.Text = "Reg.No"
        '
        'txtStudName
        '
        Me.txtStudName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStudName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudName.Location = New System.Drawing.Point(51, 42)
        Me.txtStudName.Name = "txtStudName"
        Me.txtStudName.Size = New System.Drawing.Size(193, 20)
        Me.txtStudName.TabIndex = 6
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.btnDelete)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Location = New System.Drawing.Point(327, 23)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(473, 24)
        Me.Panel4.TabIndex = 19
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(27, -2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 22
        Me.btnDelete.Text = "Delete Unit"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(131, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 16)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Registered Units"
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Controls.Add(Me.btnDoneAdding)
        Me.Panel5.Controls.Add(Me.btnShowpanel)
        Me.Panel5.Location = New System.Drawing.Point(318, 15)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(487, 260)
        Me.Panel5.TabIndex = 20
        '
        'btnDoneAdding
        '
        Me.btnDoneAdding.Location = New System.Drawing.Point(220, 230)
        Me.btnDoneAdding.Name = "btnDoneAdding"
        Me.btnDoneAdding.Size = New System.Drawing.Size(186, 23)
        Me.btnDoneAdding.TabIndex = 1
        Me.btnDoneAdding.Text = "Done Adding"
        Me.btnDoneAdding.UseVisualStyleBackColor = True
        '
        'btnShowpanel
        '
        Me.btnShowpanel.Location = New System.Drawing.Point(7, 230)
        Me.btnShowpanel.Name = "btnShowpanel"
        Me.btnShowpanel.Size = New System.Drawing.Size(159, 23)
        Me.btnShowpanel.TabIndex = 0
        Me.btnShowpanel.Text = "Click here to add new unit"
        Me.btnShowpanel.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel6.Location = New System.Drawing.Point(811, 15)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(213, 260)
        Me.Panel6.TabIndex = 24
        '
        'pnlRegUnits
        '
        Me.pnlRegUnits.BackColor = System.Drawing.Color.Transparent
        Me.pnlRegUnits.Controls.Add(Me.txtTime)
        Me.pnlRegUnits.Controls.Add(Me.btnNewUnit)
        Me.pnlRegUnits.Controls.Add(Me.btnRegister)
        Me.pnlRegUnits.Controls.Add(Me.spreadUnits)
        Me.pnlRegUnits.Controls.Add(Me.spreadMoveUnits)
        Me.pnlRegUnits.Controls.Add(Me.Panel2)
        Me.pnlRegUnits.Location = New System.Drawing.Point(12, 338)
        Me.pnlRegUnits.Name = "pnlRegUnits"
        Me.pnlRegUnits.Size = New System.Drawing.Size(1032, 267)
        Me.pnlRegUnits.TabIndex = 18
        '
        'txtTime
        '
        Me.txtTime.Location = New System.Drawing.Point(563, 64)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(100, 20)
        Me.txtTime.TabIndex = 9
        Me.txtTime.Visible = False
        '
        'btnNewUnit
        '
        Me.btnNewUnit.Location = New System.Drawing.Point(44, 32)
        Me.btnNewUnit.Name = "btnNewUnit"
        Me.btnNewUnit.Size = New System.Drawing.Size(75, 23)
        Me.btnNewUnit.TabIndex = 7
        Me.btnNewUnit.Text = "Add Another"
        Me.btnNewUnit.UseVisualStyleBackColor = True
        '
        'btnRegister
        '
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.Location = New System.Drawing.Point(552, 113)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(111, 23)
        Me.btnRegister.TabIndex = 2
        Me.btnRegister.Text = ">>>Register>>>"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'spreadUnits
        '
        Me.spreadUnits.Location = New System.Drawing.Point(164, 19)
        Me.spreadUnits.Name = "spreadUnits"
        Me.spreadUnits.OcxState = CType(resources.GetObject("spreadUnits.OcxState"), System.Windows.Forms.AxHost.State)
        Me.spreadUnits.Size = New System.Drawing.Size(382, 227)
        Me.spreadUnits.TabIndex = 1
        '
        'spreadMoveUnits
        '
        Me.spreadMoveUnits.Location = New System.Drawing.Point(666, 19)
        Me.spreadMoveUnits.Name = "spreadMoveUnits"
        Me.spreadMoveUnits.OcxState = CType(resources.GetObject("spreadMoveUnits.OcxState"), System.Windows.Forms.AxHost.State)
        Me.spreadMoveUnits.Size = New System.Drawing.Size(351, 227)
        Me.spreadMoveUnits.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.cbxTime)
        Me.Panel2.Controls.Add(Me.lblTime)
        Me.Panel2.Controls.Add(Me.cbxFacSearch)
        Me.Panel2.Controls.Add(Me.txtUnitName)
        Me.Panel2.Controls.Add(Me.cbxDepSearch)
        Me.Panel2.Controls.Add(Me.txtUnitCode)
        Me.Panel2.Location = New System.Drawing.Point(9, 19)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(149, 227)
        Me.Panel2.TabIndex = 8
        '
        'cbxTime
        '
        Me.cbxTime.FormattingEnabled = True
        Me.cbxTime.Location = New System.Drawing.Point(9, 199)
        Me.cbxTime.Name = "cbxTime"
        Me.cbxTime.Size = New System.Drawing.Size(133, 21)
        Me.cbxTime.TabIndex = 8
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(8, 183)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(30, 13)
        Me.lblTime.TabIndex = 7
        Me.lblTime.Text = "Time"
        '
        'cbxFacSearch
        '
        Me.cbxFacSearch.FormattingEnabled = True
        Me.cbxFacSearch.Location = New System.Drawing.Point(11, 42)
        Me.cbxFacSearch.Name = "cbxFacSearch"
        Me.cbxFacSearch.Size = New System.Drawing.Size(131, 21)
        Me.cbxFacSearch.TabIndex = 3
        Me.cbxFacSearch.Text = "...Select Faculty..."
        '
        'txtUnitName
        '
        Me.txtUnitName.Location = New System.Drawing.Point(11, 157)
        Me.txtUnitName.Name = "txtUnitName"
        Me.txtUnitName.Size = New System.Drawing.Size(131, 20)
        Me.txtUnitName.TabIndex = 6
        '
        'cbxDepSearch
        '
        Me.cbxDepSearch.FormattingEnabled = True
        Me.cbxDepSearch.Location = New System.Drawing.Point(11, 82)
        Me.cbxDepSearch.Name = "cbxDepSearch"
        Me.cbxDepSearch.Size = New System.Drawing.Size(131, 21)
        Me.cbxDepSearch.TabIndex = 4
        Me.cbxDepSearch.Text = "...Search Department..."
        '
        'txtUnitCode
        '
        Me.txtUnitCode.Location = New System.Drawing.Point(11, 118)
        Me.txtUnitCode.Name = "txtUnitCode"
        Me.txtUnitCode.Size = New System.Drawing.Size(131, 20)
        Me.txtUnitCode.TabIndex = 5
        '
        'txtUser
        '
        Me.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUser.Enabled = False
        Me.txtUser.Location = New System.Drawing.Point(149, 8)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(100, 20)
        Me.txtUser.TabIndex = 19
        Me.txtUser.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'lblUser
        '
        Me.lblUser.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.Maroon
        Me.lblUser.Location = New System.Drawing.Point(675, 7)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(46, 18)
        Me.lblUser.TabIndex = 20
        Me.lblUser.Text = "name"
        '
        'lblLogAs
        '
        Me.lblLogAs.AutoSize = True
        Me.lblLogAs.Location = New System.Drawing.Point(561, 10)
        Me.lblLogAs.Name = "lblLogAs"
        Me.lblLogAs.Size = New System.Drawing.Size(108, 13)
        Me.lblLogAs.TabIndex = 21
        Me.lblLogAs.Text = "You are logged In as:"
        '
        'btnLogOut
        '
        Me.btnLogOut.Location = New System.Drawing.Point(956, 8)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(75, 23)
        Me.btnLogOut.TabIndex = 21
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.UseVisualStyleBackColor = True
        Me.btnLogOut.Visible = False
        '
        'frmStudentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1048, 617)
        Me.Controls.Add(Me.btnLogOut)
        Me.Controls.Add(Me.lblLogAs)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.pnlRegUnits)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Name = "frmStudentForm"
        Me.Text = "Student Form"
        Me.TransparencyKey = System.Drawing.Color.Transparent
        Me.Panel1.ResumeLayout(False)
        CType(Me.spreadLoadAllRegistered, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPicbox.ResumeLayout(False)
        CType(Me.PicStude, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.pnlFacDep.ResumeLayout(False)
        Me.pnlFacDep.PerformLayout()
        Me.pnlStudName.ResumeLayout(False)
        Me.pnlStudName.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.pnlRegUnits.ResumeLayout(False)
        Me.pnlRegUnits.PerformLayout()
        CType(Me.spreadUnits, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spreadMoveUnits, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtStudRegNo As System.Windows.Forms.TextBox
    Friend WithEvents txtStudName As System.Windows.Forms.TextBox
    Friend WithEvents lblStudRegNo As System.Windows.Forms.Label
    Friend WithEvents lblStudName As System.Windows.Forms.Label
    Friend WithEvents lblFaculty As System.Windows.Forms.Label
    Friend WithEvents spreadMoveUnits As AxFPSpread.AxvaSpread
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents pnlFacDep As System.Windows.Forms.Panel
    Friend WithEvents cbxFaculty As System.Windows.Forms.ComboBox
    Friend WithEvents txtCourseCode As System.Windows.Forms.TextBox
    Friend WithEvents lblDep As System.Windows.Forms.Label
    Friend WithEvents txtDepCode As System.Windows.Forms.TextBox
    Friend WithEvents cbxCourse As System.Windows.Forms.ComboBox
    Friend WithEvents txtFacCode As System.Windows.Forms.TextBox
    Friend WithEvents cbxDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents lblCourse As System.Windows.Forms.Label
    Friend WithEvents pnlStudName As System.Windows.Forms.Panel
    Friend WithEvents lblSex As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pnlRegUnits As System.Windows.Forms.Panel
    Friend WithEvents spreadUnits As AxFPSpread.AxvaSpread
    Friend WithEvents btnRegister As System.Windows.Forms.Button
    Friend WithEvents cbxDepSearch As System.Windows.Forms.ComboBox
    Friend WithEvents cbxFacSearch As System.Windows.Forms.ComboBox
    Friend WithEvents txtUnitName As System.Windows.Forms.TextBox
    Friend WithEvents txtUnitCode As System.Windows.Forms.TextBox
    Friend WithEvents txtSex As System.Windows.Forms.TextBox
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents lblLogAs As System.Windows.Forms.Label
    Friend WithEvents btnNewUnit As System.Windows.Forms.Button
    Friend WithEvents pnlPicbox As System.Windows.Forms.Panel
    Friend WithEvents btnPicBrowse As System.Windows.Forms.Button
    Friend WithEvents PicStude As System.Windows.Forms.PictureBox
    Friend WithEvents spreadLoadAllRegistered As AxFPSpread.AxvaSpread
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents btnShowpanel As System.Windows.Forms.Button
    Friend WithEvents btnDoneAdding As System.Windows.Forms.Button
    Friend WithEvents btnLogOut As System.Windows.Forms.Button
    Friend WithEvents btnSavePic As System.Windows.Forms.Button
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cbxTime As System.Windows.Forms.ComboBox
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents txtTime As System.Windows.Forms.TextBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
End Class
