Public Class frmMain
    Public MdiChildForms() As Form = Me.MdiChildren
    Public k As Integer = MdiChildForms.Length
    Public x As Integer

    Friend Sub AddTabPage(ByVal tp As TabPage)
        With TabControl1
            .TabPages.Add(tp)
            .SelectedTab = tp
        End With
    End Sub

    Friend Sub RemoveTabPage(ByVal tp As TabPage)
        TabControl1.TabPages.Remove(tp)
    End Sub

    Public Sub ToggleControls(ByVal val As Boolean)
        NewToolStripMenuItemNew.Enabled = val
        EditToolStripMenuItemEdit.Enabled = val
        SaveToolStripMenuItemSave.Enabled = Not val
        CancelToolStripMenuItemCancel.Enabled = Not val
    End Sub

    Private Sub frmMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'treeSideMenu.Visible = False
        frmLogin.Show()
        frmStudentForm.MdiParent = Me
        frmStudentForm.Dock = DockStyle.Fill
        frmLecForm.MdiParent = Me
        frmLecForm.Dock = DockStyle.Fill
        frmDephead.MdiParent = Me
        frmDephead.Dock = DockStyle.Fill
        frmClass.MdiParent = Me
        frmClass.Dock = DockStyle.Fill


        MenuStrip1.Enabled = False
        conn.Open(cnStr)
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As System.Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs)

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        Dim i As Integer

        If TabControl1.TabPages.Count > 0 Then
            For i = 0 To Me.MdiChildren.Length - 1

                If i = TabControl1.SelectedIndex Then
                    Me.MdiChildren(i).WindowState = FormWindowState.Normal

                Else
                    Me.MdiChildren(i).WindowState = FormWindowState.Minimized

                End If
            Next
        End If
    End Sub

    Private Sub EditToolStripMenuItemEdit_Click(sender As System.Object, e As System.EventArgs) Handles EditToolStripMenuItemEdit.Click
        Try
            Dim activeMdi = Me.MdiChildren
            If activeMdi.Length = 0 Then
                MsgBox("Please load a form", MsgBoxStyle.Information, "University System")
            Else
                DirectCast(DirectCast(Me, Form).ActiveMdiChild, InterfaceSys).FormEdit()
                'ToggleControls(False)
            End If

        Catch ex As Exception
            'MessageBox.Show("Re-open the Form", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub NewToolStripMenuItemNew_Click(sender As System.Object, e As System.EventArgs) Handles NewToolStripMenuItemNew.Click
        Try
            Dim activeMdi = Me.MdiChildren
            If activeMdi.Length = 0 Then
                MsgBox("Please load a form", MsgBoxStyle.Information, "School System")
            Else
                If ActiveMdiChild.Name = "frmLockAccess" Then
                    NewToolStripMenuItemNew.Enabled = False
                    'NewToolStripMenuItem.Visible = False
                    MsgBox("Click on Edit to make changes", MsgBoxStyle.Information, "Access Lock")
                Else
                    DirectCast(DirectCast(Me, Form).ActiveMdiChild, InterfaceSys).FormNew()
                    'ToggleControls(False)
                End If
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub CancelToolStripMenuItemCancel_Click(sender As System.Object, e As System.EventArgs) Handles CancelToolStripMenuItemCancel.Click
        Try
            DirectCast(DirectCast(Me, Form).ActiveMdiChild, InterfaceSys).FormCancel()
            ToggleControls(True)
        Catch
        End Try

    End Sub

    Private Sub SaveToolStripMenuItemSave_Click(sender As System.Object, e As System.EventArgs) Handles SaveToolStripMenuItemSave.Click
        Try
            Dim activeMdi = Me.MdiChildren
            If activeMdi.Length = 0 Then
                MsgBox("Please load a form", MsgBoxStyle.Information, "School System")

            Else
                DirectCast(DirectCast(Me, Form).ActiveMdiChild, InterfaceSys).FormSave()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub treeSideMenu_AfterSelect(sender As System.Object, e As System.Windows.Forms.TreeViewEventArgs) Handles treeSideMenu.AfterSelect
        MenuStrip1.Enabled = True
        If treeSideMenu.SelectedNode.Name = "ndFaculty" Then
            frmFaculties.MdiParent = Me
            frmFaculties.Dock = DockStyle.Fill
            frmFaculties.Show()

        ElseIf treeSideMenu.SelectedNode.Name = "ndDepartment" Then
            frmDepartments.MdiParent = Me
            frmDepartments.Dock = DockStyle.Fill
            frmDepartments.Show()

        ElseIf treeSideMenu.SelectedNode.Name = "ndCourses" Then
            frmCourses.MdiParent = Me
            frmCourses.Dock = DockStyle.Fill
            frmCourses.Show()

        ElseIf treeSideMenu.SelectedNode.Name = "ndStudents" Then
            frmRegStudents.MdiParent = Me
            frmRegStudents.Dock = DockStyle.Fill
            frmRegStudents.Show()

        ElseIf treeSideMenu.SelectedNode.Name = "ndLecturers" Then
            frmRegLecs.MdiParent = Me
            frmRegLecs.Dock = DockStyle.Fill
            frmRegLecs.Show()

            'ElseIf treeSideMenu.SelectedNode.Name = "ndLecDetails" Then
            '    frmLecForm.MdiParent = Me
            '    frmLecForm.Dock = DockStyle.Fill
            '    'frmLogin.Show()
            '    'frmLecLogin.Show()
            '    frmLecForm.Show()

            'ElseIf treeSideMenu.SelectedNode.Name = "ndStudentDetails" Then
            '    frmStudentForm.MdiParent = Me
            '    frmStudentForm.Dock = DockStyle.Fill
            '    frmLecForm.MdiParent = Me
            '    frmLecForm.Dock = DockStyle.Fill
            '    frmLogin.Show()
            '    MenuStrip1.Enabled = False

        ElseIf treeSideMenu.SelectedNode.Name = "ndUnits" Then
            frmUnits.MdiParent = Me
            frmUnits.Dock = DockStyle.Fill
            frmUnits.Show()

            'ElseIf treeSideMenu.SelectedNode.Name = "ndClassStart" Then
            '    frmClass.MdiParent = Me
            '    frmClass.Dock = DockStyle.Fill

            '    frmClassLogin.Show()
            '    MenuStrip1.Enabled = False
            'ElseIf treeSideMenu.SelectedNode.Name = "ndDepHead" Then
            '    frmDephead.MdiParent = Me
            '    frmDephead.Dock = DockStyle.Fill

            '    frmDephead.Show()
            '    MenuStrip1.Enabled = False



        End If
    End Sub

    Private Sub pnlLeft_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles pnlLeft.Paint

    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click

        Try
            ActiveMdiChild.Close()
        Catch
            MsgBox("No Tab page is open!")
        End Try

    End Sub

    Private Sub btnLogin_Click(sender As System.Object, e As System.EventArgs)
        frmStudentForm.MdiParent = Me
        frmStudentForm.Dock = DockStyle.Fill
        frmLecForm.MdiParent = Me
        frmLecForm.Dock = DockStyle.Fill
        frmLogin.Show()
    End Sub

    Private Sub lblLogOut_Click(sender As System.Object, e As System.EventArgs) Handles btnLogOut.Click

        Try
            'Dim tp As New TabPage
            ActiveMdiChild.Close()
            'RemoveTabPage(tp)
            'ActiveMdiChild.Close()
        Catch
            MsgBox("No Tab page is open!")
        End Try
        frmLogin.Show()
        
    End Sub
End Class