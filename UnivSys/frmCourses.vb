Public Class frmCourses
    Implements InterfaceSys
    Dim modCourses As String = "QUERY"
    ''Dim autoNo3 As Integer
    Private tp As New TabPage("Courses")
    Private pForm As frmMain
    Private Sub frmCourses_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        pForm = Me.ParentForm
        pForm.AddTabPage(tp)
        loadSpreadMain()
        'LoadSpreadCourses()
        loadFaculty()
        'loadDep()
        GroupBoxCourses.Enabled = False
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


    Private Sub loadSpreadMain()
        spreadUnits.MaxRows = 0
        rs = New ADODB.Recordset
        sql = "Select * from t_Courses "
        'where fv_FacultyCode='" & txtFacCode.Text & "' "
        '& _
        '            "AND fn_Category_No='" & txtCatNo.Text & "'"
        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        If Not rs.EOF Then
            Do Until rs.EOF
                spreadUnits.MaxRows = spreadUnits.MaxRows + 1
                spreadUnits.Row = spreadUnits.MaxRows
                spreadUnits.Col = 1
                spreadUnits.TypeButtonText = "Edit"
                spreadUnits.Col = 1
                spreadUnits.Text = rs("pv_CourseCode").Value
                spreadUnits.Col = 2
                spreadUnits.Text = rs("v_CourseName").Value

                spreadUnits.Col = 3
                spreadUnits.Text = rs("fv_DepName").Value

                

                rs.MoveNext()
            Loop

        End If
        rs.Close()
    End Sub
    Private Sub loadSpreadCourses()
        spreadUnits.MaxRows = 0
        rs = New ADODB.Recordset
        sql = "Select * from t_Courses where fv_DepCode='" & txtDepCode.Text & "' "
        'where fv_FacultyCode='" & txtFacCode.Text & "' "
        '& _
        '            "AND fn_Category_No='" & txtCatNo.Text & "'"
        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        If Not rs.EOF Then
            Do Until rs.EOF
                spreadUnits.MaxRows = spreadUnits.MaxRows + 1
                spreadUnits.Row = spreadUnits.MaxRows
                spreadUnits.Col = 1
                spreadUnits.TypeButtonText = "Edit"
                spreadUnits.Col = 1
                spreadUnits.Text = rs("pv_CourseCode").Value
                spreadUnits.Col = 2
                spreadUnits.Text = rs("v_CourseName").Value

                spreadUnits.Col = 3
                spreadUnits.Text = rs("fv_DepName").Value



                rs.MoveNext()
            Loop

        End If
        rs.Close()
    End Sub

    Public Sub FormCancel() Implements InterfaceSys.FormCancel
        ClearItems()
        frmMain.ToggleControls(True)
    End Sub
    Public Sub FormEdit() Implements InterfaceSys.FormEdit
        mode = "EDIT"
        frmMain.ToggleControls(False)
        GroupBoxCourses.Enabled = True
    End Sub

    Public Sub FormNew() Implements InterfaceSys.FormNew
        mode = "NEW"
        clearItems()
        GroupBoxCourses.Enabled = True
        frmMain.ToggleControls(False)
    End Sub

    Public Sub FormSave() Implements InterfaceSys.FormSave
        SaveItems()
    End Sub

    Public Sub FormSubmit() Implements InterfaceSys.FormSubmit

    End Sub

    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCourseCode.TextChanged

    End Sub
    Private Sub clearItems()
        txtCourseCode.Text = ""
        txtCourseName.Text = ""
        txtFacCode.Text = ""
        txtDepCode.Text = ""
        cbxDepartment.Text = ""
        cbxFaculty.Text = ""
    End Sub
    Private Sub saveItems()
        conn.BeginTrans()
        Me.Cursor = Cursors.WaitCursor
        Try
            If mode = "NEW" Then
                sql = "select * from t_Courses where pv_CourseCode='" & txtCourseCode.Text & "'"
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
                    rs("pv_CourseCode").Value = txtCourseCode.Text
                    rs("v_CourseName").Value = txtCourseName.Text
                    rs("fv_DepName").Value = cbxDepartment.Text
                    'rs("v_FacultyName").Value = cbxFaculty.Text
                    rs("fv_DepCode").Value = txtDepCode.Text


                End If
            ElseIf mode = "EDIT" Then
                spreadUnits.Row = spreadUnits.ActiveRow
                spreadUnits.Col = 1
                sql = "select * from t_Courses where pv_CourseCode='" & txtCourseCode.Text & "'"
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

            rs("pv_CourseCode").Value = txtCourseCode.Text
            rs("v_CourseName").Value = txtCourseName.Text
            rs("fv_DepName").Value = cbxDepartment.Text
            'rs("v_FacultyName").Value = cbxFaculty.Text
            rs("fv_DepCode").Value = txtDepCode.Text

            rs.Update()

            conn.CommitTrans()
            Me.Cursor = Cursors.Arrow
            MsgBox("Saved successfully", MsgBoxStyle.Information, "Courses")
            clearItems()
            rs.Close()
            loadSpreadCourses()
            frmMain.ToggleControls(True)

            modCourses = "QUERY"

        Catch ex As Exception
            conn.RollbackTrans()
            Me.Cursor = Cursors.Arrow
            MsgBox(ex.Message, MsgBoxStyle.Information, "User")

        End Try

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
        txtCourseCode.Text = ""
        txtCourseName.Text = ""
        loadDep()


        'loadSpreadCourses()
    End Sub

    Private Sub cbxDepartment_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbxDepartment.SelectedIndexChanged
        sql = "Select * from t_Department where v_DepName='" & cbxDepartment.Text & "'"
        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        If Not rs.EOF Then
            txtDepCode.Text = rs("pv_DepCode").Value
        End If
        rs.Close()
        txtCourseCode.Text = ""
        txtCourseName.Text = ""
        loadSpreadCourses()
    End Sub

    Private Sub spreadUnits_ClickEvent(sender As System.Object, e As AxFPSpread._DSpreadEvents_ClickEvent) Handles spreadUnits.ClickEvent
        spreadUnits.Row = spreadUnits.ActiveRow
        spreadUnits.Col = 1


        sql = "SELECT * FROM t_Courses where pv_CourseCode= '" & spreadUnits.Text & "'"
        Try
            rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        If Not rs.EOF Then
            txtCourseCode.Text = rs("pv_CourseCode").Value
            txtCourseName.Text = rs("v_CourseName").Value
            cbxDepartment.Text = rs("fv_DepName").Value
            

        Else
            MsgBox("No Department. Add new")
        End If
        'GroupBoxCourses.Enabled = False
        rs.Close()
    End Sub

    Private Sub btnLoad_Click(sender As System.Object, e As System.EventArgs) Handles btnLoad.Click
        loadSpreadMain()
    End Sub

    Private Sub txtFacCode_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtFacCode.TextChanged

    End Sub

    Private Sub GroupBoxCourses_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBoxCourses.Enter

    End Sub

    Private Sub frmCourses_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Enabled = False
    End Sub

    Private Sub frmCourses_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        pForm.RemoveTabPage(tp)
    End Sub
End Class