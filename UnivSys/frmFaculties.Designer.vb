<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFaculties
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFaculties))
        Me.spreadFaculty = New AxFPSpread.AxvaSpread()
        Me.grpbxFaculties = New System.Windows.Forms.GroupBox()
        Me.txtFacHead = New System.Windows.Forms.TextBox()
        Me.txtFacName = New System.Windows.Forms.TextBox()
        Me.txtFacCode = New System.Windows.Forms.TextBox()
        Me.lblFacHead = New System.Windows.Forms.Label()
        Me.lblFacName = New System.Windows.Forms.Label()
        Me.lblFacCode = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.spreadFaculty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpbxFaculties.SuspendLayout()
        Me.SuspendLayout()
        '
        'spreadFaculty
        '
        Me.spreadFaculty.Location = New System.Drawing.Point(531, 64)
        Me.spreadFaculty.Name = "spreadFaculty"
        Me.spreadFaculty.OcxState = CType(resources.GetObject("spreadFaculty.OcxState"), System.Windows.Forms.AxHost.State)
        Me.spreadFaculty.Size = New System.Drawing.Size(404, 258)
        Me.spreadFaculty.TabIndex = 1
        '
        'grpbxFaculties
        '
        Me.grpbxFaculties.Controls.Add(Me.txtFacHead)
        Me.grpbxFaculties.Controls.Add(Me.txtFacName)
        Me.grpbxFaculties.Controls.Add(Me.txtFacCode)
        Me.grpbxFaculties.Controls.Add(Me.lblFacHead)
        Me.grpbxFaculties.Controls.Add(Me.lblFacName)
        Me.grpbxFaculties.Controls.Add(Me.lblFacCode)
        Me.grpbxFaculties.Location = New System.Drawing.Point(29, 64)
        Me.grpbxFaculties.Name = "grpbxFaculties"
        Me.grpbxFaculties.Size = New System.Drawing.Size(403, 258)
        Me.grpbxFaculties.TabIndex = 2
        Me.grpbxFaculties.TabStop = False
        Me.grpbxFaculties.Text = "Add Faculties"
        '
        'txtFacHead
        '
        Me.txtFacHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFacHead.Location = New System.Drawing.Point(108, 114)
        Me.txtFacHead.Name = "txtFacHead"
        Me.txtFacHead.Size = New System.Drawing.Size(213, 20)
        Me.txtFacHead.TabIndex = 5
        '
        'txtFacName
        '
        Me.txtFacName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFacName.Location = New System.Drawing.Point(108, 80)
        Me.txtFacName.Name = "txtFacName"
        Me.txtFacName.Size = New System.Drawing.Size(213, 20)
        Me.txtFacName.TabIndex = 4
        '
        'txtFacCode
        '
        Me.txtFacCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFacCode.Location = New System.Drawing.Point(108, 38)
        Me.txtFacCode.Name = "txtFacCode"
        Me.txtFacCode.Size = New System.Drawing.Size(213, 20)
        Me.txtFacCode.TabIndex = 3
        '
        'lblFacHead
        '
        Me.lblFacHead.AutoSize = True
        Me.lblFacHead.Location = New System.Drawing.Point(11, 114)
        Me.lblFacHead.Name = "lblFacHead"
        Me.lblFacHead.Size = New System.Drawing.Size(70, 13)
        Me.lblFacHead.TabIndex = 2
        Me.lblFacHead.Text = "Faculty Head"
        '
        'lblFacName
        '
        Me.lblFacName.AutoSize = True
        Me.lblFacName.Location = New System.Drawing.Point(11, 74)
        Me.lblFacName.Name = "lblFacName"
        Me.lblFacName.Size = New System.Drawing.Size(72, 13)
        Me.lblFacName.TabIndex = 1
        Me.lblFacName.Text = "Faculty Name"
        '
        'lblFacCode
        '
        Me.lblFacCode.AutoSize = True
        Me.lblFacCode.Location = New System.Drawing.Point(11, 41)
        Me.lblFacCode.Name = "lblFacCode"
        Me.lblFacCode.Size = New System.Drawing.Size(69, 13)
        Me.lblFacCode.TabIndex = 0
        Me.lblFacCode.Text = "Faculty Code"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Location = New System.Drawing.Point(12, 55)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(928, 282)
        Me.Panel1.TabIndex = 3
        '
        'frmFaculties
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(996, 349)
        Me.Controls.Add(Me.grpbxFaculties)
        Me.Controls.Add(Me.spreadFaculty)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmFaculties"
        Me.Text = "Faculties"
        CType(Me.spreadFaculty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpbxFaculties.ResumeLayout(False)
        Me.grpbxFaculties.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents spreadFaculty As AxFPSpread.AxvaSpread
    Friend WithEvents grpbxFaculties As System.Windows.Forms.GroupBox
    Friend WithEvents txtFacHead As System.Windows.Forms.TextBox
    Friend WithEvents txtFacName As System.Windows.Forms.TextBox
    Friend WithEvents txtFacCode As System.Windows.Forms.TextBox
    Friend WithEvents lblFacHead As System.Windows.Forms.Label
    Friend WithEvents lblFacName As System.Windows.Forms.Label
    Friend WithEvents lblFacCode As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
