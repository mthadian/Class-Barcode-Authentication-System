<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUnits
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUnits))
        Me.lblFaculty = New System.Windows.Forms.Label()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.cbxFaculty = New System.Windows.Forms.ComboBox()
        Me.cbxDepartment = New System.Windows.Forms.ComboBox()
        Me.grpboxAddUnits = New System.Windows.Forms.GroupBox()
        Me.txtDescri = New System.Windows.Forms.TextBox()
        Me.lblDescr = New System.Windows.Forms.Label()
        Me.txtDepCode = New System.Windows.Forms.TextBox()
        Me.txtFacCode = New System.Windows.Forms.TextBox()
        Me.txtUnitName = New System.Windows.Forms.TextBox()
        Me.txtUnitCode = New System.Windows.Forms.TextBox()
        Me.lblUnitName = New System.Windows.Forms.Label()
        Me.lblUnitCode = New System.Windows.Forms.Label()
        Me.spreadAddUnits = New AxFPSpread.AxvaSpread()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.grpboxAddUnits.SuspendLayout()
        CType(Me.spreadAddUnits, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFaculty
        '
        Me.lblFaculty.AutoSize = True
        Me.lblFaculty.Location = New System.Drawing.Point(33, 23)
        Me.lblFaculty.Name = "lblFaculty"
        Me.lblFaculty.Size = New System.Drawing.Size(41, 13)
        Me.lblFaculty.TabIndex = 0
        Me.lblFaculty.Text = "Faculty"
        '
        'lblDepartment
        '
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.Location = New System.Drawing.Point(23, 55)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(62, 13)
        Me.lblDepartment.TabIndex = 1
        Me.lblDepartment.Text = "Department"
        '
        'cbxFaculty
        '
        Me.cbxFaculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxFaculty.FormattingEnabled = True
        Me.cbxFaculty.Location = New System.Drawing.Point(155, 20)
        Me.cbxFaculty.Name = "cbxFaculty"
        Me.cbxFaculty.Size = New System.Drawing.Size(186, 21)
        Me.cbxFaculty.TabIndex = 2
        '
        'cbxDepartment
        '
        Me.cbxDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxDepartment.FormattingEnabled = True
        Me.cbxDepartment.Location = New System.Drawing.Point(155, 47)
        Me.cbxDepartment.Name = "cbxDepartment"
        Me.cbxDepartment.Size = New System.Drawing.Size(186, 21)
        Me.cbxDepartment.TabIndex = 3
        '
        'grpboxAddUnits
        '
        Me.grpboxAddUnits.Controls.Add(Me.txtDescri)
        Me.grpboxAddUnits.Controls.Add(Me.lblDescr)
        Me.grpboxAddUnits.Controls.Add(Me.txtDepCode)
        Me.grpboxAddUnits.Controls.Add(Me.txtFacCode)
        Me.grpboxAddUnits.Controls.Add(Me.txtUnitName)
        Me.grpboxAddUnits.Controls.Add(Me.txtUnitCode)
        Me.grpboxAddUnits.Controls.Add(Me.lblDepartment)
        Me.grpboxAddUnits.Controls.Add(Me.cbxDepartment)
        Me.grpboxAddUnits.Controls.Add(Me.lblUnitName)
        Me.grpboxAddUnits.Controls.Add(Me.cbxFaculty)
        Me.grpboxAddUnits.Controls.Add(Me.lblFaculty)
        Me.grpboxAddUnits.Controls.Add(Me.lblUnitCode)
        Me.grpboxAddUnits.Location = New System.Drawing.Point(21, 16)
        Me.grpboxAddUnits.Name = "grpboxAddUnits"
        Me.grpboxAddUnits.Size = New System.Drawing.Size(388, 338)
        Me.grpboxAddUnits.TabIndex = 2
        Me.grpboxAddUnits.TabStop = False
        Me.grpboxAddUnits.Text = "Add Unit"
        '
        'txtDescri
        '
        Me.txtDescri.Location = New System.Drawing.Point(155, 161)
        Me.txtDescri.Multiline = True
        Me.txtDescri.Name = "txtDescri"
        Me.txtDescri.Size = New System.Drawing.Size(188, 52)
        Me.txtDescri.TabIndex = 9
        '
        'lblDescr
        '
        Me.lblDescr.AutoSize = True
        Me.lblDescr.Location = New System.Drawing.Point(35, 178)
        Me.lblDescr.Name = "lblDescr"
        Me.lblDescr.Size = New System.Drawing.Size(60, 13)
        Me.lblDescr.TabIndex = 8
        Me.lblDescr.Text = "Description"
        '
        'txtDepCode
        '
        Me.txtDepCode.Location = New System.Drawing.Point(91, 47)
        Me.txtDepCode.Multiline = True
        Me.txtDepCode.Name = "txtDepCode"
        Me.txtDepCode.Size = New System.Drawing.Size(49, 21)
        Me.txtDepCode.TabIndex = 7
        '
        'txtFacCode
        '
        Me.txtFacCode.Location = New System.Drawing.Point(90, 20)
        Me.txtFacCode.Multiline = True
        Me.txtFacCode.Name = "txtFacCode"
        Me.txtFacCode.Size = New System.Drawing.Size(48, 22)
        Me.txtFacCode.TabIndex = 6
        '
        'txtUnitName
        '
        Me.txtUnitName.Location = New System.Drawing.Point(155, 124)
        Me.txtUnitName.Name = "txtUnitName"
        Me.txtUnitName.Size = New System.Drawing.Size(188, 20)
        Me.txtUnitName.TabIndex = 5
        '
        'txtUnitCode
        '
        Me.txtUnitCode.Location = New System.Drawing.Point(155, 87)
        Me.txtUnitCode.Name = "txtUnitCode"
        Me.txtUnitCode.Size = New System.Drawing.Size(186, 20)
        Me.txtUnitCode.TabIndex = 4
        '
        'lblUnitName
        '
        Me.lblUnitName.AutoSize = True
        Me.lblUnitName.Location = New System.Drawing.Point(28, 131)
        Me.lblUnitName.Name = "lblUnitName"
        Me.lblUnitName.Size = New System.Drawing.Size(57, 13)
        Me.lblUnitName.TabIndex = 1
        Me.lblUnitName.Text = "Unit Name"
        '
        'lblUnitCode
        '
        Me.lblUnitCode.AutoSize = True
        Me.lblUnitCode.Location = New System.Drawing.Point(33, 94)
        Me.lblUnitCode.Name = "lblUnitCode"
        Me.lblUnitCode.Size = New System.Drawing.Size(54, 13)
        Me.lblUnitCode.TabIndex = 0
        Me.lblUnitCode.Text = "Unit Code"
        '
        'spreadAddUnits
        '
        Me.spreadAddUnits.Location = New System.Drawing.Point(461, 54)
        Me.spreadAddUnits.Name = "spreadAddUnits"
        Me.spreadAddUnits.OcxState = CType(resources.GetObject("spreadAddUnits.OcxState"), System.Windows.Forms.AxHost.State)
        Me.spreadAddUnits.Size = New System.Drawing.Size(566, 338)
        Me.spreadAddUnits.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.grpboxAddUnits)
        Me.Panel1.Location = New System.Drawing.Point(24, 36)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1055, 361)
        Me.Panel1.TabIndex = 4
        '
        'frmUnits
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1091, 521)
        Me.Controls.Add(Me.spreadAddUnits)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmUnits"
        Me.Text = "Units"
        Me.grpboxAddUnits.ResumeLayout(False)
        Me.grpboxAddUnits.PerformLayout()
        CType(Me.spreadAddUnits, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblFaculty As System.Windows.Forms.Label
    Friend WithEvents lblDepartment As System.Windows.Forms.Label
    Friend WithEvents cbxFaculty As System.Windows.Forms.ComboBox
    Friend WithEvents cbxDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents grpboxAddUnits As System.Windows.Forms.GroupBox
    Friend WithEvents txtUnitName As System.Windows.Forms.TextBox
    Friend WithEvents txtUnitCode As System.Windows.Forms.TextBox
    Friend WithEvents lblUnitName As System.Windows.Forms.Label
    Friend WithEvents lblUnitCode As System.Windows.Forms.Label
    Friend WithEvents spreadAddUnits As AxFPSpread.AxvaSpread
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtDepCode As System.Windows.Forms.TextBox
    Friend WithEvents txtFacCode As System.Windows.Forms.TextBox
    Friend WithEvents txtDescri As System.Windows.Forms.TextBox
    Friend WithEvents lblDescr As System.Windows.Forms.Label

End Class
