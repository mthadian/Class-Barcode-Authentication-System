<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegLecs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegLecs))
        Me.lblLecId = New System.Windows.Forms.Label()
        Me.lblLecName = New System.Windows.Forms.Label()
        Me.lblLecFaculty = New System.Windows.Forms.Label()
        Me.txtLecId = New System.Windows.Forms.TextBox()
        Me.txtLecName = New System.Windows.Forms.TextBox()
        Me.AxvaSpread1 = New AxFPSpread.AxvaSpread()
        Me.pnlCourses = New System.Windows.Forms.Panel()
        Me.spreadLecUnits = New AxFPSpread.AxvaSpread()
        Me.cbxFaculty = New System.Windows.Forms.ComboBox()
        Me.cbxDep = New System.Windows.Forms.ComboBox()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.pnlPicbox = New System.Windows.Forms.Panel()
        Me.btnPicBrowse = New System.Windows.Forms.Button()
        Me.PicLec = New System.Windows.Forms.PictureBox()
        Me.lblPic = New System.Windows.Forms.Label()
        Me.pnlDetails = New System.Windows.Forms.Panel()
        Me.txtSex = New System.Windows.Forms.TextBox()
        Me.RBFemale = New System.Windows.Forms.RadioButton()
        Me.RBMale = New System.Windows.Forms.RadioButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblSex = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtDepCode = New System.Windows.Forms.TextBox()
        Me.txtFacCode = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.AxvaSpread1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCourses.SuspendLayout()
        CType(Me.spreadLecUnits, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPicbox.SuspendLayout()
        CType(Me.PicLec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDetails.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
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
        'lblLecName
        '
        Me.lblLecName.AutoSize = True
        Me.lblLecName.Location = New System.Drawing.Point(6, 35)
        Me.lblLecName.Name = "lblLecName"
        Me.lblLecName.Size = New System.Drawing.Size(77, 13)
        Me.lblLecName.TabIndex = 1
        Me.lblLecName.Text = "Lecturer Name"
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
        'txtLecId
        '
        Me.txtLecId.Location = New System.Drawing.Point(98, 3)
        Me.txtLecId.Name = "txtLecId"
        Me.txtLecId.Size = New System.Drawing.Size(183, 20)
        Me.txtLecId.TabIndex = 8
        '
        'txtLecName
        '
        Me.txtLecName.Location = New System.Drawing.Point(109, 64)
        Me.txtLecName.Name = "txtLecName"
        Me.txtLecName.Size = New System.Drawing.Size(183, 20)
        Me.txtLecName.TabIndex = 9
        '
        'AxvaSpread1
        '
        Me.AxvaSpread1.Location = New System.Drawing.Point(379, 334)
        Me.AxvaSpread1.Name = "AxvaSpread1"
        Me.AxvaSpread1.OcxState = CType(resources.GetObject("AxvaSpread1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxvaSpread1.Size = New System.Drawing.Size(367, 170)
        Me.AxvaSpread1.TabIndex = 22
        '
        'pnlCourses
        '
        Me.pnlCourses.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlCourses.Controls.Add(Me.spreadLecUnits)
        Me.pnlCourses.Location = New System.Drawing.Point(4, 320)
        Me.pnlCourses.Name = "pnlCourses"
        Me.pnlCourses.Size = New System.Drawing.Size(803, 211)
        Me.pnlCourses.TabIndex = 23
        '
        'spreadLecUnits
        '
        Me.spreadLecUnits.Location = New System.Drawing.Point(77, 12)
        Me.spreadLecUnits.Name = "spreadLecUnits"
        Me.spreadLecUnits.OcxState = CType(resources.GetObject("spreadLecUnits.OcxState"), System.Windows.Forms.AxHost.State)
        Me.spreadLecUnits.Size = New System.Drawing.Size(602, 170)
        Me.spreadLecUnits.TabIndex = 1
        '
        'cbxFaculty
        '
        Me.cbxFaculty.FormattingEnabled = True
        Me.cbxFaculty.Location = New System.Drawing.Point(126, 21)
        Me.cbxFaculty.Name = "cbxFaculty"
        Me.cbxFaculty.Size = New System.Drawing.Size(183, 21)
        Me.cbxFaculty.TabIndex = 7
        '
        'cbxDep
        '
        Me.cbxDep.FormattingEnabled = True
        Me.cbxDep.Location = New System.Drawing.Point(126, 66)
        Me.cbxDep.Name = "cbxDep"
        Me.cbxDep.Size = New System.Drawing.Size(183, 21)
        Me.cbxDep.TabIndex = 6
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
        'pnlPicbox
        '
        Me.pnlPicbox.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pnlPicbox.Controls.Add(Me.btnPicBrowse)
        Me.pnlPicbox.Controls.Add(Me.PicLec)
        Me.pnlPicbox.Location = New System.Drawing.Point(517, 14)
        Me.pnlPicbox.Name = "pnlPicbox"
        Me.pnlPicbox.Size = New System.Drawing.Size(238, 235)
        Me.pnlPicbox.TabIndex = 13
        '
        'btnPicBrowse
        '
        Me.btnPicBrowse.Location = New System.Drawing.Point(3, 209)
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
        'lblPic
        '
        Me.lblPic.AutoSize = True
        Me.lblPic.Location = New System.Drawing.Point(514, 0)
        Me.lblPic.Name = "lblPic"
        Me.lblPic.Size = New System.Drawing.Size(71, 13)
        Me.lblPic.TabIndex = 14
        Me.lblPic.Text = "Add a Picture"
        '
        'pnlDetails
        '
        Me.pnlDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlDetails.Controls.Add(Me.txtSex)
        Me.pnlDetails.Controls.Add(Me.RBFemale)
        Me.pnlDetails.Controls.Add(Me.RBMale)
        Me.pnlDetails.Controls.Add(Me.lblPic)
        Me.pnlDetails.Controls.Add(Me.pnlPicbox)
        Me.pnlDetails.Controls.Add(Me.Panel2)
        Me.pnlDetails.Controls.Add(Me.Panel3)
        Me.pnlDetails.Location = New System.Drawing.Point(4, 12)
        Me.pnlDetails.Name = "pnlDetails"
        Me.pnlDetails.Size = New System.Drawing.Size(803, 258)
        Me.pnlDetails.TabIndex = 24
        '
        'txtSex
        '
        Me.txtSex.Location = New System.Drawing.Point(222, 87)
        Me.txtSex.Name = "txtSex"
        Me.txtSex.Size = New System.Drawing.Size(65, 20)
        Me.txtSex.TabIndex = 18
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
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.txtLecId)
        Me.Panel2.Controls.Add(Me.lblLecName)
        Me.Panel2.Controls.Add(Me.lblLecId)
        Me.Panel2.Controls.Add(Me.lblSex)
        Me.Panel2.Location = New System.Drawing.Point(3, 13)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(317, 108)
        Me.Panel2.TabIndex = 19
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
        Me.Panel3.Size = New System.Drawing.Size(316, 102)
        Me.Panel3.TabIndex = 20
        '
        'txtDepCode
        '
        Me.txtDepCode.Location = New System.Drawing.Point(72, 63)
        Me.txtDepCode.Name = "txtDepCode"
        Me.txtDepCode.Size = New System.Drawing.Size(48, 20)
        Me.txtDepCode.TabIndex = 9
        '
        'txtFacCode
        '
        Me.txtFacCode.Location = New System.Drawing.Point(72, 23)
        Me.txtFacCode.Name = "txtFacCode"
        Me.txtFacCode.Size = New System.Drawing.Size(48, 20)
        Me.txtFacCode.TabIndex = 8
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmRegLecs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(892, 561)
        Me.Controls.Add(Me.txtLecName)
        Me.Controls.Add(Me.pnlDetails)
        Me.Controls.Add(Me.pnlCourses)
        Me.Name = "frmRegLecs"
        Me.Text = "Register Lecturers"
        CType(Me.AxvaSpread1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCourses.ResumeLayout(False)
        CType(Me.spreadLecUnits, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPicbox.ResumeLayout(False)
        CType(Me.PicLec,System.ComponentModel.ISupportInitialize).EndInit
        Me.pnlDetails.ResumeLayout(false)
        Me.pnlDetails.PerformLayout
        Me.Panel2.ResumeLayout(false)
        Me.Panel2.PerformLayout
        Me.Panel3.ResumeLayout(false)
        Me.Panel3.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents lblLecId As System.Windows.Forms.Label
    Friend WithEvents lblLecName As System.Windows.Forms.Label
    Friend WithEvents lblLecFaculty As System.Windows.Forms.Label
    Friend WithEvents txtLecId As System.Windows.Forms.TextBox
    Friend WithEvents txtLecName As System.Windows.Forms.TextBox
    Friend WithEvents AxvaSpread1 As AxFPSpread.AxvaSpread
    Friend WithEvents pnlCourses As System.Windows.Forms.Panel
    Friend WithEvents cbxFaculty As System.Windows.Forms.ComboBox
    Friend WithEvents cbxDep As System.Windows.Forms.ComboBox
    Friend WithEvents lblDepartment As System.Windows.Forms.Label
    Friend WithEvents pnlPicbox As System.Windows.Forms.Panel
    Friend WithEvents btnPicBrowse As System.Windows.Forms.Button
    Friend WithEvents PicLec As System.Windows.Forms.PictureBox
    Friend WithEvents lblPic As System.Windows.Forms.Label
    Friend WithEvents pnlDetails As System.Windows.Forms.Panel
    Friend WithEvents RBFemale As System.Windows.Forms.RadioButton
    Friend WithEvents RBMale As System.Windows.Forms.RadioButton
    Friend WithEvents lblSex As System.Windows.Forms.Label
    Friend WithEvents txtSex As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents spreadLecUnits As AxFPSpread.AxvaSpread
    Friend WithEvents txtDepCode As System.Windows.Forms.TextBox
    Friend WithEvents txtFacCode As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
