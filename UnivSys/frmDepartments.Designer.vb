<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDepartments
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDepartments))
        Me.AxvaSpread1 = New AxFPSpread.AxvaSpread()
        Me.txtDepCode = New System.Windows.Forms.TextBox()
        Me.spreadDep = New AxFPSpread.AxvaSpread()
        Me.lblDepCode = New System.Windows.Forms.Label()
        Me.lblFaculty = New System.Windows.Forms.Label()
        Me.cbxFaculty = New System.Windows.Forms.ComboBox()
        Me.lblDepName = New System.Windows.Forms.Label()
        Me.lblDepHead = New System.Windows.Forms.Label()
        Me.txtDepName = New System.Windows.Forms.TextBox()
        Me.grpbxDep = New System.Windows.Forms.GroupBox()
        Me.txtDepHeadID = New System.Windows.Forms.TextBox()
        Me.lblDepHeadCode = New System.Windows.Forms.Label()
        Me.txtDepHead = New System.Windows.Forms.TextBox()
        Me.txtFacCode = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLoad = New System.Windows.Forms.Button()
        CType(Me.AxvaSpread1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spreadDep, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpbxDep.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'AxvaSpread1
        '
        Me.AxvaSpread1.Location = New System.Drawing.Point(582, 300)
        Me.AxvaSpread1.Name = "AxvaSpread1"
        Me.AxvaSpread1.OcxState = CType(resources.GetObject("AxvaSpread1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxvaSpread1.Size = New System.Drawing.Size(75, 23)
        Me.AxvaSpread1.TabIndex = 10
        '
        'txtDepCode
        '
        Me.txtDepCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDepCode.Location = New System.Drawing.Point(175, 132)
        Me.txtDepCode.Name = "txtDepCode"
        Me.txtDepCode.Size = New System.Drawing.Size(187, 20)
        Me.txtDepCode.TabIndex = 0
        '
        'spreadDep
        '
        Me.spreadDep.Location = New System.Drawing.Point(454, 61)
        Me.spreadDep.Name = "spreadDep"
        Me.spreadDep.OcxState = CType(resources.GetObject("spreadDep.OcxState"), System.Windows.Forms.AxHost.State)
        Me.spreadDep.Size = New System.Drawing.Size(507, 274)
        Me.spreadDep.TabIndex = 1
        '
        'lblDepCode
        '
        Me.lblDepCode.AutoSize = True
        Me.lblDepCode.Location = New System.Drawing.Point(41, 139)
        Me.lblDepCode.Name = "lblDepCode"
        Me.lblDepCode.Size = New System.Drawing.Size(90, 13)
        Me.lblDepCode.TabIndex = 2
        Me.lblDepCode.Text = "Department Code"
        '
        'lblFaculty
        '
        Me.lblFaculty.AutoSize = True
        Me.lblFaculty.Location = New System.Drawing.Point(41, 85)
        Me.lblFaculty.Name = "lblFaculty"
        Me.lblFaculty.Size = New System.Drawing.Size(41, 13)
        Me.lblFaculty.TabIndex = 3
        Me.lblFaculty.Text = "Faculty"
        '
        'cbxFaculty
        '
        Me.cbxFaculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxFaculty.FormattingEnabled = True
        Me.cbxFaculty.Location = New System.Drawing.Point(175, 77)
        Me.cbxFaculty.Name = "cbxFaculty"
        Me.cbxFaculty.Size = New System.Drawing.Size(187, 21)
        Me.cbxFaculty.TabIndex = 4
        '
        'lblDepName
        '
        Me.lblDepName.AutoSize = True
        Me.lblDepName.Location = New System.Drawing.Point(38, 186)
        Me.lblDepName.Name = "lblDepName"
        Me.lblDepName.Size = New System.Drawing.Size(93, 13)
        Me.lblDepName.TabIndex = 5
        Me.lblDepName.Text = "Department Name"
        '
        'lblDepHead
        '
        Me.lblDepHead.AutoSize = True
        Me.lblDepHead.Location = New System.Drawing.Point(38, 247)
        Me.lblDepHead.Name = "lblDepHead"
        Me.lblDepHead.Size = New System.Drawing.Size(91, 13)
        Me.lblDepHead.TabIndex = 6
        Me.lblDepHead.Text = "Department Head"
        '
        'txtDepName
        '
        Me.txtDepName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDepName.Location = New System.Drawing.Point(175, 197)
        Me.txtDepName.Name = "txtDepName"
        Me.txtDepName.Size = New System.Drawing.Size(187, 20)
        Me.txtDepName.TabIndex = 8
        '
        'grpbxDep
        '
        Me.grpbxDep.Controls.Add(Me.txtDepHeadID)
        Me.grpbxDep.Controls.Add(Me.lblDepHeadCode)
        Me.grpbxDep.Controls.Add(Me.txtDepHead)
        Me.grpbxDep.Controls.Add(Me.txtFacCode)
        Me.grpbxDep.Location = New System.Drawing.Point(17, 12)
        Me.grpbxDep.Name = "grpbxDep"
        Me.grpbxDep.Size = New System.Drawing.Size(382, 274)
        Me.grpbxDep.TabIndex = 10
        Me.grpbxDep.TabStop = False
        Me.grpbxDep.Text = "Add Department"
        '
        'txtDepHeadID
        '
        Me.txtDepHeadID.Location = New System.Drawing.Point(144, 220)
        Me.txtDepHeadID.Name = "txtDepHeadID"
        Me.txtDepHeadID.Size = New System.Drawing.Size(187, 20)
        Me.txtDepHeadID.TabIndex = 3
        '
        'lblDepHeadCode
        '
        Me.lblDepHeadCode.AutoSize = True
        Me.lblDepHeadCode.Location = New System.Drawing.Point(12, 221)
        Me.lblDepHeadCode.Name = "lblDepHeadCode"
        Me.lblDepHeadCode.Size = New System.Drawing.Size(47, 13)
        Me.lblDepHeadCode.TabIndex = 2
        Me.lblDepHeadCode.Text = "Head ID"
        '
        'txtDepHead
        '
        Me.txtDepHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDepHead.Location = New System.Drawing.Point(144, 183)
        Me.txtDepHead.Name = "txtDepHead"
        Me.txtDepHead.Size = New System.Drawing.Size(187, 20)
        Me.txtDepHead.TabIndex = 1
        '
        'txtFacCode
        '
        Me.txtFacCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFacCode.Location = New System.Drawing.Point(144, 43)
        Me.txtFacCode.Multiline = True
        Me.txtFacCode.Name = "txtFacCode"
        Me.txtFacCode.Size = New System.Drawing.Size(100, 20)
        Me.txtFacCode.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.grpbxDep)
        Me.Panel1.Location = New System.Drawing.Point(12, 47)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(967, 298)
        Me.Panel1.TabIndex = 11
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(454, 18)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(171, 23)
        Me.btnLoad.TabIndex = 12
        Me.btnLoad.Text = "Load all Departments"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'frmDepartments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1247, 677)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.txtDepName)
        Me.Controls.Add(Me.lblDepHead)
        Me.Controls.Add(Me.lblDepName)
        Me.Controls.Add(Me.cbxFaculty)
        Me.Controls.Add(Me.lblFaculty)
        Me.Controls.Add(Me.lblDepCode)
        Me.Controls.Add(Me.spreadDep)
        Me.Controls.Add(Me.txtDepCode)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmDepartments"
        Me.Text = "Departments"
        CType(Me.AxvaSpread1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spreadDep, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpbxDep.ResumeLayout(False)
        Me.grpbxDep.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AxvaSpread1 As AxFPSpread.AxvaSpread
    Friend WithEvents txtDepCode As System.Windows.Forms.TextBox
    Friend WithEvents spreadDep As AxFPSpread.AxvaSpread
    Friend WithEvents lblDepCode As System.Windows.Forms.Label
    Friend WithEvents lblFaculty As System.Windows.Forms.Label
    Friend WithEvents cbxFaculty As System.Windows.Forms.ComboBox
    Friend WithEvents lblDepName As System.Windows.Forms.Label
    Friend WithEvents lblDepHead As System.Windows.Forms.Label
    Friend WithEvents txtDepName As System.Windows.Forms.TextBox
    Friend WithEvents grpbxDep As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtFacCode As System.Windows.Forms.TextBox
    Friend WithEvents txtDepHead As System.Windows.Forms.TextBox
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents txtDepHeadID As System.Windows.Forms.TextBox
    Friend WithEvents lblDepHeadCode As System.Windows.Forms.Label
End Class
