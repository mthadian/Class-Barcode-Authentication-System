<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Faculties")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Departments")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Courses")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Students")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Lecturers")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Units")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("University Settings", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4, TreeNode5, TreeNode6})
        Me.pnlHead = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NewToolStripMenuItemNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItemEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItemSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelToolStripMenuItemCancel = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlLeft = New System.Windows.Forms.Panel()
        Me.treeSideMenu = New System.Windows.Forms.TreeView()
        Me.pnlHead.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.pnlLeft.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHead
        '
        Me.pnlHead.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pnlHead.Controls.Add(Me.Label1)
        Me.pnlHead.Controls.Add(Me.btnLogOut)
        Me.pnlHead.Controls.Add(Me.btnClose)
        Me.pnlHead.Controls.Add(Me.TabControl1)
        Me.pnlHead.Controls.Add(Me.MenuStrip1)
        Me.pnlHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHead.Location = New System.Drawing.Point(0, 0)
        Me.pnlHead.Name = "pnlHead"
        Me.pnlHead.Size = New System.Drawing.Size(1333, 56)
        Me.pnlHead.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(306, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(310, 24)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "CLASS ATTENDANCE SYSTEM"
        '
        'btnLogOut
        '
        Me.btnLogOut.Location = New System.Drawing.Point(1174, 30)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(75, 23)
        Me.btnLogOut.TabIndex = 20
        Me.btnLogOut.Text = "LogOut"
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(1255, 30)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 19
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(251, 31)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(766, 25)
        Me.TabControl1.TabIndex = 18
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItemNew, Me.EditToolStripMenuItemEdit, Me.SaveToolStripMenuItemSave, Me.CancelToolStripMenuItemCancel})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 31)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(255, 25)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NewToolStripMenuItemNew
        '
        Me.NewToolStripMenuItemNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.NewToolStripMenuItemNew.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewToolStripMenuItemNew.ForeColor = System.Drawing.Color.Maroon
        Me.NewToolStripMenuItemNew.Image = CType(resources.GetObject("NewToolStripMenuItemNew.Image"), System.Drawing.Image)
        Me.NewToolStripMenuItemNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewToolStripMenuItemNew.Name = "NewToolStripMenuItemNew"
        Me.NewToolStripMenuItemNew.Size = New System.Drawing.Size(63, 21)
        Me.NewToolStripMenuItemNew.Text = "New"
        '
        'EditToolStripMenuItemEdit
        '
        Me.EditToolStripMenuItemEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.EditToolStripMenuItemEdit.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditToolStripMenuItemEdit.ForeColor = System.Drawing.Color.Maroon
        Me.EditToolStripMenuItemEdit.Image = Global.UnivSys.My.Resources.Resources.application24
        Me.EditToolStripMenuItemEdit.Name = "EditToolStripMenuItemEdit"
        Me.EditToolStripMenuItemEdit.Size = New System.Drawing.Size(60, 21)
        Me.EditToolStripMenuItemEdit.Text = "Edit"
        '
        'SaveToolStripMenuItemSave
        '
        Me.SaveToolStripMenuItemSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SaveToolStripMenuItemSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SaveToolStripMenuItemSave.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveToolStripMenuItemSave.ForeColor = System.Drawing.Color.Maroon
        Me.SaveToolStripMenuItemSave.Image = Global.UnivSys.My.Resources.Resources.sav
        Me.SaveToolStripMenuItemSave.Name = "SaveToolStripMenuItemSave"
        Me.SaveToolStripMenuItemSave.Size = New System.Drawing.Size(48, 21)
        Me.SaveToolStripMenuItemSave.Text = "Save"
        '
        'CancelToolStripMenuItemCancel
        '
        Me.CancelToolStripMenuItemCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CancelToolStripMenuItemCancel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelToolStripMenuItemCancel.ForeColor = System.Drawing.Color.Maroon
        Me.CancelToolStripMenuItemCancel.Image = CType(resources.GetObject("CancelToolStripMenuItemCancel.Image"), System.Drawing.Image)
        Me.CancelToolStripMenuItemCancel.Name = "CancelToolStripMenuItemCancel"
        Me.CancelToolStripMenuItemCancel.Size = New System.Drawing.Size(76, 21)
        Me.CancelToolStripMenuItemCancel.Text = "Cancel"
        '
        'pnlLeft
        '
        Me.pnlLeft.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pnlLeft.Controls.Add(Me.treeSideMenu)
        Me.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLeft.Location = New System.Drawing.Point(0, 56)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Size = New System.Drawing.Size(245, 638)
        Me.pnlLeft.TabIndex = 12
        '
        'treeSideMenu
        '
        Me.treeSideMenu.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.treeSideMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.treeSideMenu.Location = New System.Drawing.Point(0, 0)
        Me.treeSideMenu.Name = "treeSideMenu"
        TreeNode1.Name = "ndFaculty"
        TreeNode1.Text = "Faculties"
        TreeNode2.Name = "ndDepartment"
        TreeNode2.Text = "Departments"
        TreeNode3.Name = "ndCourses"
        TreeNode3.Text = "Courses"
        TreeNode4.Name = "ndStudents"
        TreeNode4.Text = "Students"
        TreeNode5.Name = "ndLecturers"
        TreeNode5.Text = "Lecturers"
        TreeNode6.Name = "ndUnits"
        TreeNode6.Text = "Units"
        TreeNode7.Name = "ndUniSettings"
        TreeNode7.Text = "University Settings"
        Me.treeSideMenu.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode7})
        Me.treeSideMenu.Size = New System.Drawing.Size(245, 638)
        Me.treeSideMenu.TabIndex = 0
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.UnivSys.My.Resources.Resources.background_learner1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1333, 694)
        Me.Controls.Add(Me.pnlLeft)
        Me.Controls.Add(Me.pnlHead)
        Me.IsMdiContainer = True
        Me.Name = "frmMain"
        Me.pnlHead.ResumeLayout(False)
        Me.pnlHead.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.pnlLeft.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlHead As System.Windows.Forms.Panel
    Friend WithEvents pnlLeft As System.Windows.Forms.Panel
    Friend WithEvents treeSideMenu As System.Windows.Forms.TreeView
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents NewToolStripMenuItemNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItemEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItemSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CancelToolStripMenuItemCancel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnLogOut As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
