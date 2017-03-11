
Public Class frmFaculties
    Implements InterfaceSys

    Dim modDepartment As String = "QUERY"
    ''Dim autoNo3 As Integer
    Private tp As New TabPage("Faculties")
    Private pForm As frmMain
    Private Sub frmFaculties_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        pForm = Me.ParentForm
        pForm.AddTabPage(tp)
        LoadSpreadFaculty()
        grpbxFaculties.Enabled = False
    End Sub

    Private Sub ClearItems()
        txtFacCode.Text = ""
        txtFacHead.Text = ""
        txtFacName.Text = ""

    End Sub

    Private Sub SaveItems()
        'GenerateItemNo()
        conn.BeginTrans()
        Me.Cursor = Cursors.WaitCursor
        Try
            If mode = "NEW" Then
                sql = "select * from t_Faculty where pv_FacultyCode='" & txtFacCode.Text & "'"
                'rs("pv_FacultyCode").Value = txtFacCode.Text
                rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                If Not rs.EOF Then
                    conn.RollbackTrans()
                    Me.Cursor = Cursors.Arrow
                    MsgBox("Faculty code exist,please enter different name", MsgBoxStyle.Information, "faculty code")
                    rs.Close()
                    Exit Sub
                Else
                    rs.AddNew()
                    rs("pv_FacultyCode").Value = txtFacCode.Text
                    rs("v_FacultyName").Value = txtFacName.Text


                End If
            ElseIf mode = "EDIT" Then
                spreadFaculty.Row = spreadFaculty.ActiveRow
                spreadFaculty.Col = 1
                sql = "select * from t_Faculty where pv_FacultyCode='" & txtFacCode.Text & "'"
                rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                If rs.EOF Then
                    conn.RollbackTrans()
                    Me.Cursor = Cursors.Arrow
                    MsgBox("Item name does not exist", MsgBoxStyle.Information, "Item")
                    rs.Close()
                    Exit Sub
                End If
            End If

            rs("pv_FacultyCode").Value = txtFacCode.Text


            rs("v_FacultyName").Value = txtFacName.Text
            rs("fv_DepHead").Value = txtFacHead.Text

            rs.Update()

            conn.CommitTrans()
            Me.Cursor = Cursors.Arrow
            MsgBox("Saved successfully", MsgBoxStyle.Information, "Item")
            ClearItems()
            rs.Close()
            LoadSpreadFaculty()
            frmMain.ToggleControls(True)

            modDepartment = "QUERY"

        Catch ex As Exception
            conn.RollbackTrans()
            Me.Cursor = Cursors.Arrow
            MsgBox(ex.Message, MsgBoxStyle.Information, "User")

        End Try

    End Sub


    Private Sub LoadSpreadFaculty()
        spreadFaculty.MaxRows = 0
        rs = New ADODB.Recordset
        sql = "Select * from t_Faculty "
        'where pv_FacultyCode='" & txtFacCode.Text & "' "
        '& _
        '            "AND fn_Category_No='" & txtCatNo.Text & "'"
        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        If Not rs.EOF Then
            Do Until rs.EOF
                spreadFaculty.MaxRows = spreadFaculty.MaxRows + 1
                spreadFaculty.Row = spreadFaculty.MaxRows
                spreadFaculty.Col = 1
                spreadFaculty.TypeButtonText = "Edit"
                spreadFaculty.Col = 1
                spreadFaculty.Text = rs("pv_FacultyCode").Value
                spreadFaculty.Col = 2
                spreadFaculty.Text = rs("v_FacultyName").Value

                spreadFaculty.Col = 3
                spreadFaculty.Text = rs("fv_DepHead").Value
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
        grpbxFaculties.Enabled = True
    End Sub

    Public Sub FormNew() Implements InterfaceSys.FormNew
        mode = "NEW"
        ClearItems()
        frmMain.ToggleControls(False)
        grpbxFaculties.Enabled = True
    End Sub

    Public Sub FormSave() Implements InterfaceSys.FormSave
        SaveItems()
    End Sub

    Public Sub FormSubmit() Implements InterfaceSys.FormSubmit

    End Sub

    Private Sub spreadFaculty_ClickEvent(sender As System.Object, e As AxFPSpread._DSpreadEvents_ClickEvent) Handles spreadFaculty.ClickEvent
        spreadFaculty.Row = spreadFaculty.ActiveRow
        spreadFaculty.Col = 1
        sql = "SELECT * FROM t_Faculty where pv_FacultyCode= '" & spreadFaculty.Text & "'"
        Try
            rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        If Not rs.EOF Then
            txtFacCode.Text = rs("pv_FacultyCode").Value
            txtFacName.Text = rs("v_FacultyName").Value
            txtFacHead.Text = rs("fv_DepHead").Value

        Else
            MsgBox("No Faculty. Add new")
        End If
        rs.Close()
        'grpbxFaculties.Enabled = False
    End Sub
    'End Sub

    Private Sub frmFaculties_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Enabled = False
    End Sub

    Private Sub frmFaculties_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        pForm.RemoveTabPage(tp)
    End Sub
End Class