<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClass
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClass))
        Me.lblSelectUnit = New System.Windows.Forms.Label()
        Me.cbxSelectUnit = New System.Windows.Forms.ComboBox()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblLecid = New System.Windows.Forms.Label()
        Me.txtUnitName = New System.Windows.Forms.TextBox()
        Me.spreadUnitStudents = New AxFPSpread.AxvaSpread()
        Me.lblUnitName = New System.Windows.Forms.Label()
        Me.lblLecName = New System.Windows.Forms.Label()
        Me.txtReadBar = New System.Windows.Forms.TextBox()
        Me.txtAttend = New System.Windows.Forms.TextBox()
        Me.txtTotalAttend = New System.Windows.Forms.TextBox()
        Me.txtPerAttend = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtStudName = New System.Windows.Forms.TextBox()
        Me.lblTime = New System.Windows.Forms.Label()
        CType(Me.spreadUnitStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSelectUnit
        '
        Me.lblSelectUnit.AutoSize = True
        Me.lblSelectUnit.Location = New System.Drawing.Point(68, 59)
        Me.lblSelectUnit.Name = "lblSelectUnit"
        Me.lblSelectUnit.Size = New System.Drawing.Size(62, 13)
        Me.lblSelectUnit.TabIndex = 0
        Me.lblSelectUnit.Text = "Select Unit "
        '
        'cbxSelectUnit
        '
        Me.cbxSelectUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxSelectUnit.FormattingEnabled = True
        Me.cbxSelectUnit.Location = New System.Drawing.Point(136, 54)
        Me.cbxSelectUnit.Name = "cbxSelectUnit"
        Me.cbxSelectUnit.Size = New System.Drawing.Size(105, 21)
        Me.cbxSelectUnit.TabIndex = 1
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(207, 14)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(20, 13)
        Me.lblUser.TabIndex = 3
        Me.lblUser.Text = "ID"
        '
        'lblLecid
        '
        Me.lblLecid.AutoSize = True
        Me.lblLecid.Location = New System.Drawing.Point(164, 14)
        Me.lblLecid.Name = "lblLecid"
        Me.lblLecid.Size = New System.Drawing.Size(37, 13)
        Me.lblLecid.TabIndex = 4
        Me.lblLecid.Text = "Lec Id"
        '
        'txtUnitName
        '
        Me.txtUnitName.Location = New System.Drawing.Point(247, 54)
        Me.txtUnitName.Multiline = True
        Me.txtUnitName.Name = "txtUnitName"
        Me.txtUnitName.Size = New System.Drawing.Size(120, 20)
        Me.txtUnitName.TabIndex = 5
        '
        'spreadUnitStudents
        '
        Me.spreadUnitStudents.Location = New System.Drawing.Point(51, 182)
        Me.spreadUnitStudents.Name = "spreadUnitStudents"
        Me.spreadUnitStudents.OcxState = CType(resources.GetObject("spreadUnitStudents.OcxState"), System.Windows.Forms.AxHost.State)
        Me.spreadUnitStudents.Size = New System.Drawing.Size(768, 294)
        Me.spreadUnitStudents.TabIndex = 6
        '
        'lblUnitName
        '
        Me.lblUnitName.AutoSize = True
        Me.lblUnitName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnitName.ForeColor = System.Drawing.Color.Navy
        Me.lblUnitName.Location = New System.Drawing.Point(382, 9)
        Me.lblUnitName.Name = "lblUnitName"
        Me.lblUnitName.Size = New System.Drawing.Size(93, 20)
        Me.lblUnitName.TabIndex = 7
        Me.lblUnitName.Text = " UnitName"
        '
        'lblLecName
        '
        Me.lblLecName.AutoSize = True
        Me.lblLecName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLecName.ForeColor = System.Drawing.Color.Navy
        Me.lblLecName.Location = New System.Drawing.Point(391, 44)
        Me.lblLecName.Name = "lblLecName"
        Me.lblLecName.Size = New System.Drawing.Size(84, 20)
        Me.lblLecName.TabIndex = 8
        Me.lblLecName.Text = "LecName"
        '
        'txtReadBar
        '
        Me.txtReadBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReadBar.ForeColor = System.Drawing.Color.Maroon
        Me.txtReadBar.Location = New System.Drawing.Point(71, 124)
        Me.txtReadBar.Name = "txtReadBar"
        Me.txtReadBar.Size = New System.Drawing.Size(166, 20)
        Me.txtReadBar.TabIndex = 9
        '
        'txtAttend
        '
        Me.txtAttend.Location = New System.Drawing.Point(483, 115)
        Me.txtAttend.Name = "txtAttend"
        Me.txtAttend.Size = New System.Drawing.Size(28, 20)
        Me.txtAttend.TabIndex = 10
        Me.txtAttend.Visible = False
        '
        'txtTotalAttend
        '
        Me.txtTotalAttend.Location = New System.Drawing.Point(532, 115)
        Me.txtTotalAttend.Name = "txtTotalAttend"
        Me.txtTotalAttend.Size = New System.Drawing.Size(34, 20)
        Me.txtTotalAttend.TabIndex = 11
        Me.txtTotalAttend.Visible = False
        '
        'txtPerAttend
        '
        Me.txtPerAttend.Location = New System.Drawing.Point(591, 115)
        Me.txtPerAttend.Name = "txtPerAttend"
        Me.txtPerAttend.Size = New System.Drawing.Size(75, 20)
        Me.txtPerAttend.TabIndex = 12
        Me.txtPerAttend.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.lblTime)
        Me.Panel1.Controls.Add(Me.btnStart)
        Me.Panel1.Controls.Add(Me.lblUnitName)
        Me.Panel1.Controls.Add(Me.lblLecid)
        Me.Panel1.Controls.Add(Me.lblUser)
        Me.Panel1.Controls.Add(Me.lblLecName)
        Me.Panel1.Location = New System.Drawing.Point(34, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(805, 101)
        Me.Panel1.TabIndex = 13
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(99, 72)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(102, 23)
        Me.btnStart.TabIndex = 9
        Me.btnStart.Text = "START CLASS"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Location = New System.Drawing.Point(34, 170)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(805, 333)
        Me.Panel2.TabIndex = 14
        '
        'txtStudName
        '
        Me.txtStudName.Location = New System.Drawing.Point(322, 124)
        Me.txtStudName.Name = "txtStudName"
        Me.txtStudName.Size = New System.Drawing.Size(120, 20)
        Me.txtStudName.TabIndex = 15
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(708, 13)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(39, 13)
        Me.lblTime.TabIndex = 10
        Me.lblTime.Text = "Label1"
        '
        'frmClass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(851, 515)
        Me.Controls.Add(Me.txtStudName)
        Me.Controls.Add(Me.txtPerAttend)
        Me.Controls.Add(Me.txtTotalAttend)
        Me.Controls.Add(Me.txtAttend)
        Me.Controls.Add(Me.txtReadBar)
        Me.Controls.Add(Me.spreadUnitStudents)
        Me.Controls.Add(Me.txtUnitName)
        Me.Controls.Add(Me.cbxSelectUnit)
        Me.Controls.Add(Me.lblSelectUnit)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frmClass"
        Me.Text = "Class"
        CType(Me.spreadUnitStudents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSelectUnit As System.Windows.Forms.Label
    Friend WithEvents cbxSelectUnit As System.Windows.Forms.ComboBox
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents lblLecid As System.Windows.Forms.Label
    Friend WithEvents txtUnitName As System.Windows.Forms.TextBox
    Friend WithEvents spreadUnitStudents As AxFPSpread.AxvaSpread
    Friend WithEvents lblUnitName As System.Windows.Forms.Label
    Friend WithEvents lblLecName As System.Windows.Forms.Label
    Friend WithEvents txtReadBar As System.Windows.Forms.TextBox
    Friend WithEvents txtAttend As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalAttend As System.Windows.Forms.TextBox
    Friend WithEvents txtPerAttend As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtStudName As System.Windows.Forms.TextBox
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents lblTime As System.Windows.Forms.Label
End Class
