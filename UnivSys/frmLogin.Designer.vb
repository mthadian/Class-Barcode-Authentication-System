<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnUpdatePw = New System.Windows.Forms.Button()
        Me.lnkUpdatePW = New System.Windows.Forms.LinkLabel()
        Me.pnlUpdate = New System.Windows.Forms.Panel()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.txtNewPW2 = New System.Windows.Forms.TextBox()
        Me.txtNewPW1 = New System.Windows.Forms.TextBox()
        Me.txtOldPW = New System.Windows.Forms.TextBox()
        Me.lblNewPW2 = New System.Windows.Forms.Label()
        Me.lblNewPW1 = New System.Windows.Forms.Label()
        Me.lblOldPass = New System.Windows.Forms.Label()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.cbxRole = New System.Windows.Forms.ComboBox()
        Me.lblError = New System.Windows.Forms.Label()
        Me.pnlUpdate.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(209, 132)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(65, 31)
        Me.btnLogin.TabIndex = 0
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(280, 132)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 31)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.ForeColor = System.Drawing.Color.Maroon
        Me.lblUserName.Location = New System.Drawing.Point(128, 69)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(93, 20)
        Me.lblUserName.TabIndex = 2
        Me.lblUserName.Text = "UserName"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(128, 104)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(86, 20)
        Me.lblPassword.TabIndex = 3
        Me.lblPassword.Text = "Password"
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtUsername.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtUsername.Location = New System.Drawing.Point(233, 71)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(141, 20)
        Me.txtUsername.TabIndex = 4
        Me.txtUsername.Text = "CS281-0735/2011"
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtPassword.Location = New System.Drawing.Point(232, 106)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(142, 20)
        Me.txtPassword.TabIndex = 5
        Me.txtPassword.Text = "CS281-0735/2011"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(135, -3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Login"
        '
        'btnUpdatePw
        '
        Me.btnUpdatePw.Location = New System.Drawing.Point(268, 121)
        Me.btnUpdatePw.Name = "btnUpdatePw"
        Me.btnUpdatePw.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdatePw.TabIndex = 7
        Me.btnUpdatePw.Text = "Update"
        Me.btnUpdatePw.UseVisualStyleBackColor = True
        '
        'lnkUpdatePW
        '
        Me.lnkUpdatePW.AutoSize = True
        Me.lnkUpdatePW.Location = New System.Drawing.Point(206, 191)
        Me.lnkUpdatePW.Name = "lnkUpdatePW"
        Me.lnkUpdatePW.Size = New System.Drawing.Size(91, 13)
        Me.lnkUpdatePW.TabIndex = 8
        Me.lnkUpdatePW.TabStop = True
        Me.lnkUpdatePW.Text = "Update Password"
        '
        'pnlUpdate
        '
        Me.pnlUpdate.Controls.Add(Me.txtUser)
        Me.pnlUpdate.Controls.Add(Me.lblUser)
        Me.pnlUpdate.Controls.Add(Me.txtNewPW2)
        Me.pnlUpdate.Controls.Add(Me.txtNewPW1)
        Me.pnlUpdate.Controls.Add(Me.btnUpdatePw)
        Me.pnlUpdate.Controls.Add(Me.txtOldPW)
        Me.pnlUpdate.Controls.Add(Me.lblNewPW2)
        Me.pnlUpdate.Controls.Add(Me.lblNewPW1)
        Me.pnlUpdate.Controls.Add(Me.lblOldPass)
        Me.pnlUpdate.Location = New System.Drawing.Point(12, 207)
        Me.pnlUpdate.Name = "pnlUpdate"
        Me.pnlUpdate.Size = New System.Drawing.Size(362, 147)
        Me.pnlUpdate.TabIndex = 9
        '
        'txtUser
        '
        Me.txtUser.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtUser.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtUser.Location = New System.Drawing.Point(220, 15)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(123, 20)
        Me.txtUser.TabIndex = 9
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(126, 18)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(63, 13)
        Me.lblUser.TabIndex = 8
        Me.lblUser.Text = "Username"
        '
        'txtNewPW2
        '
        Me.txtNewPW2.BackColor = System.Drawing.SystemColors.GrayText
        Me.txtNewPW2.Location = New System.Drawing.Point(220, 95)
        Me.txtNewPW2.Name = "txtNewPW2"
        Me.txtNewPW2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPW2.Size = New System.Drawing.Size(123, 20)
        Me.txtNewPW2.TabIndex = 5
        '
        'txtNewPW1
        '
        Me.txtNewPW1.BackColor = System.Drawing.SystemColors.GrayText
        Me.txtNewPW1.Location = New System.Drawing.Point(221, 69)
        Me.txtNewPW1.Name = "txtNewPW1"
        Me.txtNewPW1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPW1.Size = New System.Drawing.Size(123, 20)
        Me.txtNewPW1.TabIndex = 4
        '
        'txtOldPW
        '
        Me.txtOldPW.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtOldPW.Location = New System.Drawing.Point(220, 43)
        Me.txtOldPW.Name = "txtOldPW"
        Me.txtOldPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtOldPW.Size = New System.Drawing.Size(123, 20)
        Me.txtOldPW.TabIndex = 3
        '
        'lblNewPW2
        '
        Me.lblNewPW2.AutoSize = True
        Me.lblNewPW2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewPW2.Location = New System.Drawing.Point(124, 95)
        Me.lblNewPW2.Name = "lblNewPW2"
        Me.lblNewPW2.Size = New System.Drawing.Size(90, 13)
        Me.lblNewPW2.TabIndex = 2
        Me.lblNewPW2.Text = "New Password"
        '
        'lblNewPW1
        '
        Me.lblNewPW1.AutoSize = True
        Me.lblNewPW1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewPW1.Location = New System.Drawing.Point(125, 73)
        Me.lblNewPW1.Name = "lblNewPW1"
        Me.lblNewPW1.Size = New System.Drawing.Size(90, 13)
        Me.lblNewPW1.TabIndex = 1
        Me.lblNewPW1.Text = "New Password"
        '
        'lblOldPass
        '
        Me.lblOldPass.AutoSize = True
        Me.lblOldPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOldPass.Location = New System.Drawing.Point(125, 46)
        Me.lblOldPass.Name = "lblOldPass"
        Me.lblOldPass.Size = New System.Drawing.Size(84, 13)
        Me.lblOldPass.TabIndex = 0
        Me.lblOldPass.Text = "Old Password"
        '
        'lblRole
        '
        Me.lblRole.AutoSize = True
        Me.lblRole.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRole.Location = New System.Drawing.Point(137, 27)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(46, 20)
        Me.lblRole.TabIndex = 10
        Me.lblRole.Text = "Role"
        '
        'cbxRole
        '
        Me.cbxRole.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.cbxRole.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxRole.ForeColor = System.Drawing.Color.Black
        Me.cbxRole.Items.AddRange(New Object() {"ADMIN", "DEPARTMENT HEAD", "LECTURER", "STUDENT", "CLASS"})
        Me.cbxRole.Location = New System.Drawing.Point(232, 26)
        Me.cbxRole.Name = "cbxRole"
        Me.cbxRole.Size = New System.Drawing.Size(142, 21)
        Me.cbxRole.TabIndex = 11
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Location = New System.Drawing.Point(71, 341)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(0, 13)
        Me.lblError.TabIndex = 12
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(386, 374)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.cbxRole)
        Me.Controls.Add(Me.lblRole)
        Me.Controls.Add(Me.pnlUpdate)
        Me.Controls.Add(Me.lnkUpdatePW)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnLogin)
        Me.ForeColor = System.Drawing.Color.DarkRed
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Transparent
        Me.pnlUpdate.ResumeLayout(False)
        Me.pnlUpdate.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnUpdatePw As System.Windows.Forms.Button
    Friend WithEvents lnkUpdatePW As System.Windows.Forms.LinkLabel
    Friend WithEvents pnlUpdate As System.Windows.Forms.Panel
    Friend WithEvents txtNewPW2 As System.Windows.Forms.TextBox
    Friend WithEvents txtNewPW1 As System.Windows.Forms.TextBox
    Friend WithEvents txtOldPW As System.Windows.Forms.TextBox
    Friend WithEvents lblNewPW2 As System.Windows.Forms.Label
    Friend WithEvents lblNewPW1 As System.Windows.Forms.Label
    Friend WithEvents lblOldPass As System.Windows.Forms.Label
    Friend WithEvents lblRole As System.Windows.Forms.Label
    Friend WithEvents cbxRole As System.Windows.Forms.ComboBox
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents lblUser As System.Windows.Forms.Label
End Class
