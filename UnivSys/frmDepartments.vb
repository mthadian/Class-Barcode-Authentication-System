Public Class frmDepartments
    Implements InterfaceSys
    Dim modDepartment As String = "QUERY"
    ''Dim autoNo3 As Integer
    Private tp As New TabPage("Departments")
    Private pForm As frmMain
    Private Sub frmDepartments_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        pForm = Me.ParentForm
        pForm.AddTabPage(tp)
        loadSpreadMain()
        LoadFaculty()
        grpbxDep.Enabled = False
    End Sub

    Private Sub ClearItems()
        txtDepCode.Text = ""
        cbxFaculty.Text = ""
        txtDepHead.Text = ""
        txtDepName.Text = ""
        txtFacCode.Text = ""
    End Sub
    Private Sub loadSpreadMain()
        spreadDep.MaxRows = 0
        rs = New ADODB.Recordset
        sql = "Select * from t_Department "
        'where fv_FacultyCode='" & txtFacCode.Text & "' "
        '& _
        '            "AND fn_Category_No='" & txtCatNo.Text & "'"
        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        If Not rs.EOF Then
            Do Until rs.EOF
                spreadDep.MaxRows = spreadDep.MaxRows + 1
                spreadDep.Row = spreadDep.MaxRows
                spreadDep.Col = 1
                spreadDep.TypeButtonText = "Edit"
                spreadDep.Col = 1
                spreadDep.Text = rs("pv_DepCode").Value
                spreadDep.Col = 2
                spreadDep.Text = rs("v_DepName").Value

                spreadDep.Col = 3
                spreadDep.Text = rs("v_DepHead").Value

                spreadDep.Col = 4
                spreadDep.Text = rs("v_FacultyName").Value

                rs.MoveNext()
            Loop

        End If
        rs.Close()
    End Sub


    Private Sub LoadSpreadDep()
        spreadDep.MaxRows = 0
        rs = New ADODB.Recordset
        sql = "Select * from t_Department where fv_FacultyCode='" & txtFacCode.Text & "' "
        '& _
        '            "AND fn_Category_No='" & txtCatNo.Text & "'"
        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        If Not rs.EOF Then
            Do Until rs.EOF
                spreadDep.MaxRows = spreadDep.MaxRows + 1
                spreadDep.Row = spreadDep.MaxRows
                spreadDep.Col = 1
                spreadDep.TypeButtonText = "Edit"
                spreadDep.Col = 1
                spreadDep.Text = rs("pv_DepCode").Value
                spreadDep.Col = 2
                spreadDep.Text = rs("v_DepName").Value

                spreadDep.Col = 3
                spreadDep.Text = rs("v_DepHead").Value

                spreadDep.Col = 4
                spreadDep.Text = rs("v_FacultyName").Value

                rs.MoveNext()
            Loop

        End If
        rs.Close()
    End Sub


    Private Sub SaveItems()
        'GenerateItemNo()
        conn.BeginTrans()
        Me.Cursor = Cursors.WaitCursor
        Try
            If mode = "NEW" Then
                sql = "select * from t_Department where pv_DepCode='" & txtDepCode.Text & "'"
                'rs("pv_FacultyCode").Value = txtFacCode.Text
                rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                If Not rs.EOF Then
                    conn.RollbackTrans()
                    Me.Cursor = Cursors.Arrow
                    MsgBox("Faculty code exist,please enter different name", MsgBoxStyle.Information, "Department code")
                    rs.Close()
                    Exit Sub
                Else
                    rs.AddNew()
                    rs("pv_DepCode").Value = txtDepCode.Text
                    rs("v_DepName").Value = txtDepName.Text
                    rs("v_DepHead").Value = txtDepHead.Text
                    rs("v_FacultyName").Value = cbxFaculty.Text
                    rs("fv_FacultyCode").Value = txtFacCode.Text
                    rs("v_DepHeadID").Value = txtDepHeadID.Text


                End If
            ElseIf mode = "EDIT" Then
                spreadDep.Row = spreadDep.ActiveRow
                spreadDep.Col = 1
                sql = "select * from t_Department where pv_DepCode='" & txtDepCode.Text & "'"
                rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                If rs.EOF Then
                    'Update()
                    conn.RollbackTrans()
                    Me.Cursor = Cursors.Arrow
                    MsgBox("Item name does not exist", MsgBoxStyle.Information, "Item")
                    rs.Close()
                    Exit Sub
                End If
            End If

            rs("fv_FacultyCode").Value = txtFacCode.Text

            rs("pv_DepCode").Value = txtDepCode.Text
            rs("v_DepName").Value = txtDepName.Text
            rs("v_DepHead").Value = txtDepHead.Text
            rs("v_FacultyName").Value = cbxFaculty.Text
            rs("v_DepHeadID").Value = txtDepHeadID.Text
            'rs("fv_DepHead").Value = txtFacHead.Text

            rs.Update()

            conn.CommitTrans()
            Me.Cursor = Cursors.Arrow
            MsgBox("Saved successfully", MsgBoxStyle.Information, "Item")
            ClearItems()
            rs.Close()
            LoadSpreadDep()
            frmMain.ToggleControls(True)

            modDepartment = "QUERY"

        Catch ex As Exception
            conn.RollbackTrans()
            Me.Cursor = Cursors.Arrow
            MsgBox(ex.Message, MsgBoxStyle.Information, "User")

        End Try

    End Sub


    Public Sub FormCancel() Implements InterfaceSys.FormCancel
        ClearItems()
        frmMain.ToggleControls(True)
    End Sub
    Public Sub FormEdit() Implements InterfaceSys.FormEdit
        mode = "EDIT"
        frmMain.ToggleControls(False)
        grpbxDep.Enabled = True
    End Sub

    Public Sub FormNew() Implements InterfaceSys.FormNew
        mode = "NEW"
        ClearItems()
        frmMain.ToggleControls(False)
        grpbxDep.Enabled = True
    End Sub

    Public Sub FormSave() Implements InterfaceSys.FormSave
        SaveItems()
        addRoles()
    End Sub

    Public Sub FormSubmit() Implements InterfaceSys.FormSubmit

    End Sub

    Private Sub AxvaSpread1_Advance(sender As System.Object, e As AxFPSpread._DSpreadEvents_AdvanceEvent)

    End Sub

    Private Sub LoadFaculty()
        cbxFaculty.Items.Clear()

        Dim rs As ADODB.Recordset
        rs = New ADODB.Recordset
        sql = "select v_FacultyName from t_Faculty"
        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        Do While Not rs.EOF
            cbxFaculty.Items.Add(rs("v_FacultyName").Value)
            rs.MoveNext()
        Loop
        rs = Nothing
    End Sub
    Private Sub cbxFaculty_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbxFaculty.SelectedIndexChanged
        sql = "Select * from t_Faculty where v_FacultyName='" & cbxFaculty.Text & " ' "
        'UNION ALL SELECT * FROM t_Department where pv_DepCode= '" & spreadDep.Text & "' "
        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        If Not rs.EOF Then
            txtFacCode.Text = rs("pv_FacultyCode").Value
            'cbxFaculty.Items.Add(rs("v_FacultyName").Value)
            'cbxFaculty.Text = txtFacCode.Text
        End If
        rs.Close()

        LoadSpreadDep()
    End Sub
    Private Sub LoadDepartment()
        '    cbxFaculty.Items.Clear()

        '    Dim rs As ADODB.Recordset
        '    rs = New ADODB.Recordset
        '    sql = "Select v_DepName from t_Department where fv_FacultyCode='" & txtFacCode.Text & "'"
        '    rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        '    Do While Not rs.EOF
        '        cmbItCat.Items.Add(rs("v_Category_Name").Value)
        '        rs.MoveNext()
        '    Loop
        '    rs = Nothing
    End Sub


    Private Sub spreadDep_ClickEvent(sender As System.Object, e As AxFPSpread._DSpreadEvents_ClickEvent) Handles spreadDep.ClickEvent
        spreadDep.Row = spreadDep.ActiveRow
        spreadDep.Col = 1
        

        sql = "SELECT * FROM t_Department where pv_DepCode= '" & spreadDep.Text & "'"
        Try
            rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        If Not rs.EOF Then
            txtDepCode.Text = rs("pv_DepCode").Value
            txtDepName.Text = rs("v_DepName").Value
            txtDepHead.Text = rs("v_DepHead").Value
            txtDepHeadID.Text = rs("v_DepHeadID").Value
            ' ''cbxFaculty.Text = rs("v_FacultyName").Value
            ' ''txtFacCode.Text = rs("fv_FacultyCode").Value

        Else
            MsgBox("No Department. Add new")
        End If
        rs.Close()
        'grpbxDep.Enabled = False
    End Sub

    Private Sub btnLoad_Click(sender As System.Object, e As System.EventArgs) Handles btnLoad.Click
        cbxFaculty.Text = ""
        txtFacCode.Text = ""

        loadSpreadMain()
    End Sub

    Private Sub frmDepartments_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        pForm.RemoveTabPage(tp)
    End Sub

    Private Sub frmDepartments_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Enabled = False
    End Sub
    Private Sub addRoles()
        Dim val As DBNull
        val = DBNull.Value


        conn.BeginTrans()
        Me.Cursor = Cursors.WaitCursor
        Try
            If mode = "NEW" Then

                sql = "select * from t_Users where fv_Dephead='" & txtDepHeadID.Text & "'"
                'rs("pv_FacultyCode").Value = txtFacCode.Text
                rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                If Not rs.EOF Then
                    conn.RollbackTrans()
                    Me.Cursor = Cursors.Arrow
                    MsgBox("Lecturer already exists,please enter different Lecturer details", MsgBoxStyle.Information, "Add New Lecturer")
                    rs.Close()
                    Exit Sub
                Else
                    rs.AddNew()

                    rs("v_role").Value = "DEPARTMENT HEAD"
                    rs("v_UserName").Value = txtDepHeadID.Text
                    rs("v_Password").Value = txtDepHeadID.Text
                    rs("fv_LecId").Value = txtDepHeadID.Text




                End If
                'rs = Nothing

            ElseIf mode = "EDIT" Then

sql = "select * from t_Users where fv_Dephead='" & txtDepHeadID.Text & "'"
                rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                If rs.EOF Then
                    'Update()
                    conn.RollbackTrans()
                    Me.Cursor = Cursors.Arrow
                    MsgBox("Item name does not exist", MsgBoxStyle.Information, "Item")
                    rs.Close()
                    Exit Sub
                End If
            End If

            rs("v_role").Value = "DEPARTMENT HEAD"
            rs("v_UserName").Value = txtDepHeadID.Text
            rs("v_Password").Value = txtDepHeadID.Text
            rs("fv_LecId").Value = txtDepHeadID.Text


            conn.CommitTrans()
            Me.Cursor = Cursors.Arrow
            MsgBox("Saved successfully", MsgBoxStyle.Information, "Units")
            ClearItems()
            rs.Close()

            frmMain.ToggleControls(True)

            modDepartment = "QUERY"

        Catch ex As Exception
            conn.RollbackTrans()
            Me.Cursor = Cursors.Arrow
            MsgBox(ex.Message, MsgBoxStyle.Information, "User")

        End Try

    End Sub
End Class