<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCourses
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCourses))
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.lblCourseCode = New System.Windows.Forms.Label()
        Me.lblCourseName = New System.Windows.Forms.Label()
        Me.txtCourseCode = New System.Windows.Forms.TextBox()
        Me.txtCourseName = New System.Windows.Forms.TextBox()
        Me.cbxDepartment = New System.Windows.Forms.ComboBox()
        Me.spreadUnits = New AxFPSpread.AxvaSpread()
        Me.GroupBoxCourses = New System.Windows.Forms.GroupBox()
        Me.txtDepCode = New System.Windows.Forms.TextBox()
        Me.txtFacCode = New System.Windows.Forms.TextBox()
        Me.lblFaculty = New System.Windows.Forms.Label()
        Me.cbxFaculty = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLoad = New System.Windows.Forms.Button()
        CType(Me.spreadUnits, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxCourses.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDepartment
        '
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.Location = New System.Drawing.Point(7, 95)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(62, 13)
        Me.lblDepartment.TabIndex = 0
        Me.lblDepartment.Text = "Department"
        '
        'lblCourseCode
        '
        Me.lblCourseCode.AutoSize = True
        Me.lblCourseCode.Location = New System.Drawing.Point(6, 154)
        Me.lblCourseCode.Name = "lblCourseCode"
        Me.lblCourseCode.Size = New System.Drawing.Size(68, 13)
        Me.lblCourseCode.TabIndex = 1
        Me.lblCourseCode.Text = "Course Code"
        '
        'lblCourseName
        '
        Me.lblCourseName.AutoSize = True
        Me.lblCourseName.Location = New System.Drawing.Point(7, 200)
        Me.lblCourseName.Name = "lblCourseName"
        Me.lblCourseName.Size = New System.Drawing.Size(71, 13)
        Me.lblCourseName.TabIndex = 2
        Me.lblCourseName.Text = "Course Name"
        '
        'txtCourseCode
        '
        Me.txtCourseCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCourseCode.Location = New System.Drawing.Point(104, 147)
        Me.txtCourseCode.Name = "txtCourseCode"
        Me.txtCourseCode.Size = New System.Drawing.Size(243, 20)
        Me.txtCourseCode.TabIndex = 4
        '
        'txtCourseName
        '
        Me.txtCourseName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCourseName.Location = New System.Drawing.Point(104, 193)
        Me.txtCourseName.Name = "txtCourseName"
        Me.txtCourseName.Size = New System.Drawing.Size(243, 20)
        Me.txtCourseName.TabIndex = 5
        '
        'cbxDepartment
        '
        Me.cbxDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxDepartment.FormattingEnabled = True
        Me.cbxDepartment.Location = New System.Drawing.Point(161, 92)
        Me.cbxDepartment.Name = "cbxDepartment"
        Me.cbxDepartment.Size = New System.Drawing.Size(186, 21)
        Me.cbxDepartment.TabIndex = 6
        '
        'spreadUnits
        '
        Me.spreadUnits.Location = New System.Drawing.Point(464, 131)
        Me.spreadUnits.Name = "spreadUnits"
        Me.spreadUnits.OcxState = CType(resources.GetObject("spreadUnits.OcxState"), System.Windows.Forms.AxHost.State)
        Me.spreadUnits.Size = New System.Drawing.Size(482, 288)
        Me.spreadUnits.TabIndex = 7
        '
        'GroupBoxCourses
        '
        Me.GroupBoxCourses.Controls.Add(Me.txtDepCode)
        Me.GroupBoxCourses.Controls.Add(Me.txtFacCode)
        Me.GroupBoxCourses.Controls.Add(Me.lblFaculty)
        Me.GroupBoxCourses.Controls.Add(Me.cbxFaculty)
        Me.GroupBoxCourses.Controls.Add(Me.lblCourseName)
        Me.GroupBoxCourses.Controls.Add(Me.cbxDepartment)
        Me.GroupBoxCourses.Controls.Add(Me.txtCourseName)
        Me.GroupBoxCourses.Controls.Add(Me.lblDepartment)
        Me.GroupBoxCourses.Controls.Add(Me.txtCourseCode)
        Me.GroupBoxCourses.Controls.Add(Me.lblCourseCode)
        Me.GroupBoxCourses.Location = New System.Drawing.Point(25, 122)
        Me.GroupBoxCourses.Name = "GroupBoxCourses"
        Me.GroupBoxCourses.Size = New System.Drawing.Size(413, 297)
        Me.GroupBoxCourses.TabIndex = 8
        Me.GroupBoxCourses.TabStop = False
        Me.GroupBoxCourses.Text = "Add Courses"
        '
        'txtDepCode
        '
        Me.txtDepCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDepCode.Location = New System.Drawing.Point(104, 92)
        Me.txtDepCode.Multiline = True
        Me.txtDepCode.Name = "txtDepCode"
        Me.txtDepCode.Size = New System.Drawing.Size(51, 21)
        Me.txtDepCode.TabIndex = 10
        '
        'txtFacCode
        '
        Me.txtFacCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFacCode.Location = New System.Drawing.Point(104, 31)
        Me.txtFacCode.Multiline = True
        Me.txtFacCode.Name = "txtFacCode"
        Me.txtFacCode.Size = New System.Drawing.Size(51, 21)
        Me.txtFacCode.TabIndex = 9
        '
        'lblFaculty
        '
        Me.lblFaculty.AutoSize = True
        Me.lblFaculty.Location = New System.Drawing.Point(12, 31)
        Me.lblFaculty.Name = "lblFaculty"
        Me.lblFaculty.Size = New System.Drawing.Size(41, 13)
        Me.lblFaculty.TabIndex = 8
        Me.lblFaculty.Text = "Faculty"
        '
        'cbxFaculty
        '
        Me.cbxFaculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxFaculty.FormattingEnabled = True
        Me.cbxFaculty.Location = New System.Drawing.Point(161, 31)
        Me.cbxFaculty.Name = "cbxFaculty"
        Me.cbxFaculty.Size = New System.Drawing.Size(186, 21)
        Me.cbxFaculty.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Location = New System.Drawing.Point(13, 114)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(957, 315)
        Me.Panel1.TabIndex = 9
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(535, 88)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(133, 23)
        Me.btnLoad.TabIndex = 10
        Me.btnLoad.Text = "All Units"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'frmCourses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 670)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.spreadUnits)
        Me.Controls.Add(Me.GroupBoxCourses)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmCourses"
        Me.Text = "Courses"
        CType(Me.spreadUnits, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxCourses.ResumeLayout(False)
        Me.GroupBoxCourses.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblDepartment As System.Windows.Forms.Label
    Friend WithEvents lblCourseCode As System.Windows.Forms.Label
    Friend WithEvents lblCourseName As System.Windows.Forms.Label
    Friend WithEvents txtCourseCode As System.Windows.Forms.TextBox
    Friend WithEvents txtCourseName As System.Windows.Forms.TextBox
    Friend WithEvents cbxDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents spreadUnits As AxFPSpread.AxvaSpread
    Friend WithEvents GroupBoxCourses As System.Windows.Forms.GroupBox
    Friend WithEvents lblFaculty As System.Windows.Forms.Label
    Friend WithEvents cbxFaculty As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtDepCode As System.Windows.Forms.TextBox
    Friend WithEvents txtFacCode As System.Windows.Forms.TextBox
    Friend WithEvents btnLoad As System.Windows.Forms.Button
End Class
