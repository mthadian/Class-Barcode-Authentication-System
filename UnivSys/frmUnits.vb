Public Class frmUnits
    Implements InterfaceSys

    Dim modUnits As String = "QUERY"
    ''Dim autoNo3 As Integer
    Private tp As New TabPage("Units")
    Private pForm As frmMain
    Private Sub frmUnits_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        pForm = Me.ParentForm
        pForm.AddTabPage(tp)
        'loadDep()
        loadFaculty()
        loadSpreadMain()
        grpboxAddUnits.Enabled = False
    End Sub
    Private Sub addRole()
        Dim val As DBNull
        val = DBNull.Value


        conn.BeginTrans()
        Me.Cursor = Cursors.WaitCursor
        Try
            If mode = "NEW" Then

                sql = "select * from t_Users where fv_UnitCode='" & txtUnitCode.Text & "'"
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

                    rs("v_role").Value = "CLASS"
                    rs("v_UserName").Value = txtUnitCode.Text
                    rs("v_Password").Value = txtUnitCode.Text
                    rs("fv_LecId").Value = txtUnitCode.Text




                End If
                '
            ElseIf mode = "EDIT" Then


                sql = "select * from t_Users where fv_UnitCode='" & txtUnitCode.Text & "'"
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

            rs("v_role").Value = "CLASS"
            rs("v_UserName").Value = txtUnitCode.Text
            rs("v_Password").Value = txtUnitCode.Text
            rs("fv_LecId").Value = txtUnitCode.Text
            rs.Update()

            conn.CommitTrans()
            Me.Cursor = Cursors.Arrow
            MsgBox("Saved successfully", MsgBoxStyle.Information, "Units")
            clearItems()
            rs.Close()

            frmMain.ToggleControls(True)

            modUnits = "QUERY"

        Catch ex As Exception
            conn.RollbackTrans()
            Me.Cursor = Cursors.Arrow
            MsgBox(ex.Message, MsgBoxStyle.Information, "User")

        End Try

    End Sub
    Private Sub loadDep()
        cbxDepartment.Items.Clear()

        Dim rs As ADODB.Recordset
        rs = New ADODB.Recordset
        sql = "Select v_DepName from t_Department where v_FacultyName='" & cbxFaculty.Text & "'"
        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        Do While Not rs.EOF
            cbxDepartment.Items.Add(rs("v_DepName").Value)
            rs.MoveNext()
        Loop
        rs = Nothing
    End Sub

    Private Sub loadFaculty()
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
    Public Sub FormCancel() Implements InterfaceSys.FormCancel
        ClearItems()
        frmMain.ToggleControls(True)
    End Sub
    Public Sub FormEdit() Implements InterfaceSys.FormEdit
        mode = "EDIT"
        frmMain.ToggleControls(False)
        grpboxAddUnits.Enabled = True
    End Sub

    Public Sub FormNew() Implements InterfaceSys.FormNew
        mode = "NEW"
        clearItems()
        grpboxAddUnits.Enabled = True
        frmMain.ToggleControls(False)
    End Sub

    Public Sub FormSave() Implements InterfaceSys.FormSave
        saveItems()
        'addRole()
    End Sub

    Public Sub FormSubmit() Implements InterfaceSys.FormSubmit

    End Sub
    Private Sub saveItems()
        conn.BeginTrans()
        Me.Cursor = Cursors.WaitCursor
        Try
            If mode = "NEW" Then
                sql = "select * from t_Units where pv_UnitCode='" & txtUnitCode.Text & "'"
                'rs("pv_FacultyCode").Value = txtFacCode.Text
                rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                If Not rs.EOF Then
                    conn.RollbackTrans()
                    Me.Cursor = Cursors.Arrow
                    MsgBox("Course code exist,please enter different Code", MsgBoxStyle.Information, "Course code")
                    rs.Close()
                    Exit Sub
                Else
                    rs.AddNew()

                    rs("pv_UnitCode").Value = txtUnitCode.Text
                    rs("v_UnitName").Value = txtUnitName.Text
                    rs("fv_DepName").Value = cbxDepartment.Text
                    'rs("v_FacultyName").Value = cbxFaculty.Text
                    rs("fv_DepCode").Value = txtDepCode.Text
                    rs("v_Description").Value = txtDescri.Text

                End If
            ElseIf mode = "EDIT" Then
                spreadAddUnits.Row = spreadAddUnits.ActiveRow
                spreadAddUnits.Col = 1
                sql = "select * from t_Units where pv_UnitCode='" & txtUnitCode.Text & "'"
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

            rs("pv_UnitCode").Value = txtUnitCode.Text
            rs("v_UnitName").Value = txtUnitName.Text
            rs("fv_DepName").Value = cbxDepartment.Text
            'rs("v_FacultyName").Value = cbxFaculty.Text
            rs("fv_DepCode").Value = txtDepCode.Text
            rs("v_Description").Value = txtDescri.Text
            rs.Update()

            conn.CommitTrans()
            Me.Cursor = Cursors.Arrow
            MsgBox("Saved successfully", MsgBoxStyle.Information, "Units")
            clearItems()
            rs.Close()
            loadSpreadUnits()
            frmMain.ToggleControls(True)

            modUnits = "QUERY"

        Catch ex As Exception
            conn.RollbackTrans()
            Me.Cursor = Cursors.Arrow
            MsgBox(ex.Message, MsgBoxStyle.Information, "User")

        End Try

    End Sub
    Private Sub clearItems()
        
        txtFacCode.Text = ""
        txtDepCode.Text = ""
        cbxDepartment.Text = ""
        cbxFaculty.Text = ""
        txtDescri.Text = ""
        txtUnitCode.Text = ""
        txtUnitName.Text = ""
    End Sub

    Private Sub loadSpreadUnits()
        spreadAddUnits.MaxRows = 0
        rs = New ADODB.Recordset
        sql = "Select * from t_Units where fv_DepCode='" & txtDepCode.Text & "' "
        
        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        If Not rs.EOF Then
            Do Until rs.EOF
                spreadAddUnits.MaxRows = spreadAddUnits.MaxRows + 1
                spreadAddUnits.Row = spreadAddUnits.MaxRows
                spreadAddUnits.Col = 1
                spreadAddUnits.TypeButtonText = "Edit"
                spreadAddUnits.Col = 1
                spreadAddUnits.Text = rs("pv_UnitCode").Value
                spreadAddUnits.Col = 2
                spreadAddUnits.Text = rs("v_UnitName").Value

                spreadAddUnits.Col = 3
                spreadAddUnits.Text = rs("fv_DepName").Value



                rs.MoveNext()
            Loop

        End If
        rs.Close()
    End Sub
    Private Sub loadSpreadMain()
        spreadAddUnits.MaxRows = 0
        rs = New ADODB.Recordset
        sql = "Select * from t_Units "
        
        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        If Not rs.EOF Then
            Do Until rs.EOF
                spreadAddUnits.MaxRows = spreadAddUnits.MaxRows + 1
                spreadAddUnits.Row = spreadAddUnits.MaxRows
                spreadAddUnits.Col = 1
                spreadAddUnits.TypeButtonText = "Edit"
                spreadAddUnits.Col = 1
                spreadAddUnits.Text = rs("pv_UnitCode").Value
                spreadAddUnits.Col = 2
                spreadAddUnits.Text = rs("v_UnitName").Value

                spreadAddUnits.Col = 3
                spreadAddUnits.Text = rs("fv_DepName").Value



                rs.MoveNext()
            Loop

        End If
        rs.Close()
    End Sub
    Private Sub cbxFaculty_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbxFaculty.SelectedIndexChanged
        sql = "Select * from t_Faculty where v_FacultyName='" & cbxFaculty.Text & "'"
        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        If Not rs.EOF Then
            txtFacCode.Text = rs("pv_FacultyCode").Value
            'cbxFaculty.Items.Add(rs("v_FacultyName").Value)
            'cbxFaculty.Text = txtFacCode.Text
        End If
        rs.Close()
        cbxDepartment.Text = ""
        txtDepCode.Text = ""
        txtUnitCode.Text = ""
        txtUnitName.Text = ""
        txtDescri.Text = ""
        loadDep()
    End Sub

    Private Sub cbxDepartment_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbxDepartment.SelectedIndexChanged
       sql = "Select * from t_Department where v_DepName='" & cbxDepartment.Text & "'"
        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        If Not rs.EOF Then
            txtDepCode.Text = rs("pv_DepCode").Value
        End If
        rs.Close()
        txtUnitCode.Text = ""
        txtUnitName.Text = ""
        loadSpreadUnits()
    End Sub

    Private Sub spreadAddUnits_ClickEvent(sender As System.Object, e As AxFPSpread._DSpreadEvents_ClickEvent) Handles spreadAddUnits.ClickEvent
        spreadAddUnits.Row = spreadAddUnits.ActiveRow
        spreadAddUnits.Col = 1


        sql = "SELECT * FROM t_Units where pv_UnitCode= '" & spreadAddUnits.Text & "'"
        Try
            rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        If Not rs.EOF Then
            txtUnitCode.Text = rs("pv_UnitCode").Value
            txtUnitName.Text = rs("v_UnitName").Value
            cbxDepartment.Text = rs("fv_DepName").Value
            txtDescri.Text = rs("v_Description").Value

            'grpboxAddUnits.Enabled = False


        Else
            MsgBox("No Unit. Add new")
        End If
        rs.Close()
    End Sub

    Private Sub Panel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub frmUnits_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Enabled = False
    End Sub

    Private Sub frmUnits_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        pForm.RemoveTabPage(tp)
    End Sub
End Class
