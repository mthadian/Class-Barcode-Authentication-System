<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDephead
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDephead))
        Me.spreadLecs = New AxFPSpread.AxvaSpread()
        Me.spreadUnitStudents = New AxFPSpread.AxvaSpread()
        Me.lblLecs = New System.Windows.Forms.Label()
        Me.lblSortCourse = New System.Windows.Forms.Label()
        Me.lblSelectUnit = New System.Windows.Forms.Label()
        Me.cbxSortCourse = New System.Windows.Forms.ComboBox()
        Me.cbxSelectUnit = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblSrchStud = New System.Windows.Forms.Label()
        Me.txtSearchStud = New System.Windows.Forms.TextBox()
        Me.spreadUnitAttendance = New AxFPSpread.AxvaSpread()
        Me.spreadLecUnits = New AxFPSpread.AxvaSpread()
        Me.lblDepHead = New System.Windows.Forms.Label()
        Me.lblDepName = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.lblLecName = New System.Windows.Forms.Label()
        Me.lblLecId = New System.Windows.Forms.Label()
        CType(Me.spreadLecs,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.spreadUnitStudents,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.spreadUnitAttendance,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.spreadLecUnits,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'spreadLecs
        '
        Me.spreadLecs.Location = New System.Drawing.Point(12, 111)
        Me.spreadLecs.Name = "spreadLecs"
        Me.spreadLecs.OcxState = CType(resources.GetObject("spreadLecs.OcxState"), System.Windows.Forms.AxHost.State)
        Me.spreadLecs.Size = New System.Drawing.Size(413, 198)
        Me.spreadLecs.TabIndex = 0
        '
        'spreadUnitStudents
        '
        Me.spreadUnitStudents.Location = New System.Drawing.Point(445, 111)
        Me.spreadUnitStudents.Name = "spreadUnitStudents"
        Me.spreadUnitStudents.OcxState = CType(resources.GetObject("spreadUnitStudents.OcxState"), System.Windows.Forms.AxHost.State)
        Me.spreadUnitStudents.Size = New System.Drawing.Size(596, 198)
        Me.spreadUnitStudents.TabIndex = 1
        '
        'lblLecs
        '
        Me.lblLecs.AutoSize = True
        Me.lblLecs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLecs.Location = New System.Drawing.Point(40, 81)
        Me.lblLecs.Name = "lblLecs"
        Me.lblLecs.Size = New System.Drawing.Size(81, 13)
        Me.lblLecs.TabIndex = 2
        Me.lblLecs.Text = "LECTURERS"
        '
        'lblSortCourse
        '
        Me.lblSortCourse.AutoSize = True
        Me.lblSortCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSortCourse.Location = New System.Drawing.Point(541, 82)
        Me.lblSortCourse.Name = "lblSortCourse"
        Me.lblSortCourse.Size = New System.Drawing.Size(94, 13)
        Me.lblSortCourse.TabIndex = 3
        Me.lblSortCourse.Text = "Sort by Course:"
        '
        'lblSelectUnit
        '
        Me.lblSelectUnit.AutoSize = True
        Me.lblSelectUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectUnit.Location = New System.Drawing.Point(185, 326)
        Me.lblSelectUnit.Name = "lblSelectUnit"
        Me.lblSelectUnit.Size = New System.Drawing.Size(74, 13)
        Me.lblSelectUnit.TabIndex = 4
        Me.lblSelectUnit.Text = "Select Unit:"
        Me.lblSelectUnit.Visible = False
        '
        'cbxSortCourse
        '
        Me.cbxSortCourse.FormattingEnabled = True
        Me.cbxSortCourse.Location = New System.Drawing.Point(641, 78)
        Me.cbxSortCourse.Name = "cbxSortCourse"
        Me.cbxSortCourse.Size = New System.Drawing.Size(142, 21)
        Me.cbxSortCourse.TabIndex = 7
        '
        'cbxSelectUnit
        '
        Me.cbxSelectUnit.FormattingEnabled = True
        Me.cbxSelectUnit.Location = New System.Drawing.Point(265, 323)
        Me.cbxSelectUnit.Name = "cbxSelectUnit"
        Me.cbxSelectUnit.Size = New System.Drawing.Size(121, 21)
        Me.cbxSelectUnit.TabIndex = 8
        Me.cbxSelectUnit.Visible = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(433, 76)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "All Students"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblSrchStud
        '
        Me.lblSrchStud.AutoSize = True
        Me.lblSrchStud.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSrchStud.Location = New System.Drawing.Point(789, 86)
        Me.lblSrchStud.Name = "lblSrchStud"
        Me.lblSrchStud.Size = New System.Drawing.Size(99, 13)
        Me.lblSrchStud.TabIndex = 11
        Me.lblSrchStud.Text = "Search Student:"
        '
        'txtSearchStud
        '
        Me.txtSearchStud.Location = New System.Drawing.Point(894, 83)
        Me.txtSearchStud.Name = "txtSearchStud"
        Me.txtSearchStud.Size = New System.Drawing.Size(146, 20)
        Me.txtSearchStud.TabIndex = 12
        '
        'spreadUnitAttendance
        '
        Me.spreadUnitAttendance.Location = New System.Drawing.Point(445, 385)
        Me.spreadUnitAttendance.Name = "spreadUnitAttendance"
        Me.spreadUnitAttendance.OcxState = CType(resources.GetObject("spreadUnitAttendance.OcxState"), System.Windows.Forms.AxHost.State)
        Me.spreadUnitAttendance.Size = New System.Drawing.Size(570, 161)
        Me.spreadUnitAttendance.TabIndex = 13
        '
        'spreadLecUnits
        '
        Me.spreadLecUnits.Location = New System.Drawing.Point(12, 385)
        Me.spreadLecUnits.Name = "spreadLecUnits"
        Me.spreadLecUnits.OcxState = CType(resources.GetObject("spreadLecUnits.OcxState"), System.Windows.Forms.AxHost.State)
        Me.spreadLecUnits.Size = New System.Drawing.Size(413, 161)
        Me.spreadLecUnits.TabIndex = 14
        '
        'lblDepHead
        '
        Me.lblDepHead.AutoSize = True
        Me.lblDepHead.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepHead.Location = New System.Drawing.Point(40, 31)
        Me.lblDepHead.Name = "lblDepHead"
        Me.lblDepHead.Size = New System.Drawing.Size(98, 24)
        Me.lblDepHead.TabIndex = 15
        Me.lblDepHead.Text = "DepHead"
        '
        'lblDepName
        '
        Me.lblDepName.AutoSize = True
        Me.lblDepName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepName.Location = New System.Drawing.Point(235, 31)
        Me.lblDepName.Name = "lblDepName"
        Me.lblDepName.Size = New System.Drawing.Size(88, 20)
        Me.lblDepName.TabIndex = 16
        Me.lblDepName.Text = "DepName"
        '
        'lblName
        '
        Me.lblName.AutoSize = true
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblName.Location = New System.Drawing.Point(685, 351)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(14, 20)
        Me.lblName.TabIndex = 17
        Me.lblName.Text = "."
        '
        'lblCode
        '
        Me.lblCode.AutoSize = true
        Me.lblCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblCode.Location = New System.Drawing.Point(461, 351)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(14, 20)
        Me.lblCode.TabIndex = 18
        Me.lblCode.Text = "."
        '
        'lblLecName
        '
        Me.lblLecName.AutoSize = true
        Me.lblLecName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblLecName.Location = New System.Drawing.Point(40, 355)
        Me.lblLecName.Name = "lblLecName"
        Me.lblLecName.Size = New System.Drawing.Size(14, 20)
        Me.lblLecName.TabIndex = 19
        Me.lblLecName.Text = "."
        '
        'lblLecId
        '
        Me.lblLecId.AutoSize = true
        Me.lblLecId.Location = New System.Drawing.Point(40, 332)
        Me.lblLecId.Name = "lblLecId"
        Me.lblLecId.Size = New System.Drawing.Size(29, 13)
        Me.lblLecId.TabIndex = 20
        Me.lblLecId.Text = "lecid"
        Me.lblLecId.Visible = false
        '
        'frmDephead
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1094, 558)
        Me.Controls.Add(Me.lblLecId)
        Me.Controls.Add(Me.lblLecName)
        Me.Controls.Add(Me.lblCode)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblDepName)
        Me.Controls.Add(Me.lblDepHead)
        Me.Controls.Add(Me.spreadLecUnits)
        Me.Controls.Add(Me.spreadUnitAttendance)
        Me.Controls.Add(Me.txtSearchStud)
        Me.Controls.Add(Me.lblSrchStud)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cbxSelectUnit)
        Me.Controls.Add(Me.cbxSortCourse)
        Me.Controls.Add(Me.lblSelectUnit)
        Me.Controls.Add(Me.lblSortCourse)
        Me.Controls.Add(Me.lblLecs)
        Me.Controls.Add(Me.spreadUnitStudents)
        Me.Controls.Add(Me.spreadLecs)
        Me.Name = "frmDephead"
        Me.Text = "frmDephead"
        CType(Me.spreadLecs,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.spreadUnitStudents,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.spreadUnitAttendance,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.spreadLecUnits,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents spreadLecs As AxFPSpread.AxvaSpread
    Friend WithEvents spreadUnitStudents As AxFPSpread.AxvaSpread
    Friend WithEvents lblLecs As System.Windows.Forms.Label
    Friend WithEvents lblSortCourse As System.Windows.Forms.Label
    Friend WithEvents lblSelectUnit As System.Windows.Forms.Label
    Friend WithEvents cbxSortCourse As System.Windows.Forms.ComboBox
    Friend WithEvents cbxSelectUnit As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblSrchStud As System.Windows.Forms.Label
    Friend WithEvents txtSearchStud As System.Windows.Forms.TextBox
    Friend WithEvents spreadUnitAttendance As AxFPSpread.AxvaSpread
    Friend WithEvents spreadLecUnits As AxFPSpread.AxvaSpread
    Friend WithEvents lblDepHead As System.Windows.Forms.Label
    Friend WithEvents lblDepName As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblCode As System.Windows.Forms.Label
    Friend WithEvents lblLecName As System.Windows.Forms.Label
    Friend WithEvents lblLecId As System.Windows.Forms.Label
End Class
