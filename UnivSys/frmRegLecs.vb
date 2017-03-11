Imports System.IO
Public Class frmRegLecs
    Implements InterfaceSys
    Dim imgName As String
    Dim myStream As New ADODB.Stream
    Dim modLecturers As String = "QUERY"
    ''Dim autoNo3 As Integer
    Private tp As New TabPage("Add Lecturers")
    Private pForm As frmMain
    Private Sub frmRegLecs_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        pForm = Me.ParentForm
        pForm.AddTabPage(tp)
        loadFaculty()
        loadSex()
        loadSpreadAll()
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
    Private Sub loadDep()
        cbxDep.Items.Clear()

        Dim rs As ADODB.Recordset
        rs = New ADODB.Recordset
        sql = "Select v_DepName from t_Department where v_FacultyName='" & cbxFaculty.Text & "'"
        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        Do While Not rs.EOF
            cbxDep.Items.Add(rs("v_DepName").Value)
            rs.MoveNext()
        Loop
        rs = Nothing
    End Sub
    Private Sub loadSex()

        If RBMale.Checked = True Then

            txtSex.Text = "Male"
        ElseIf RBFemale.Checked = True Then

            txtSex.Text = "Female"
        End If

    End Sub
    Private Sub clearItems()

    End Sub
    Private Sub loadSpreadAll()
        spreadLecUnits.MaxRows = 0
        rs = New ADODB.Recordset
        'sql = "Select * from t_Students where fv_CourseCode='" & txtCourseCode.Text & "' "
        sql = "SELECT dbo.t_Lecturers.*,dbo.t_Department.* ,dbo.t_Faculty.* " & _
        "FROM dbo.t_Lecturers INNER JOIN dbo.t_Department " & _
        "ON dbo.t_Lecturers.fv_DepCode = dbo.t_Department.pv_DepCode " & _
        "INNER JOIN dbo.t_Faculty " & _
        "ON dbo.t_Lecturers.fv_FacCode=dbo.t_Faculty.pv_FacultyCode "

        '"WHERE t_StudUnits.pv_UnitCode ='" & txtUnitCode.Text & "' "
        '"dbo.t_Lecturers INNER JOIN dbo.t_Faculty" & _
        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        If Not rs.EOF Then
            Do Until rs.EOF
                spreadLecUnits.MaxRows = spreadLecUnits.MaxRows + 1
                spreadLecUnits.Row = spreadLecUnits.MaxRows
                spreadLecUnits.Col = 1
                spreadLecUnits.TypeButtonText = "Edit"
                spreadLecUnits.Col = 1
                spreadLecUnits.Text = rs("pv_LecId").Value
                spreadLecUnits.Col = 2
                spreadLecUnits.Text = rs("v_LecName").Value
                spreadLecUnits.Col = 3
                spreadLecUnits.Text = rs("n_Sex").Value
                spreadLecUnits.Col = 4
                spreadLecUnits.Text = rs("v_DepName").Value
                spreadLecUnits.Col = 5
                spreadLecUnits.Text = rs("v_FacultyName").Value
                'spreadLecUnits.Col = 6
                'spreadLecUnits.Text = rs("fv_FacName").Value



                rs.MoveNext()
            Loop

        End If
        rs.Close()
    End Sub


    Private Sub loadSpreadLecUnits()
        spreadLecUnits.MaxRows = 0
        rs = New ADODB.Recordset
        'sql = "Select * from t_Students where fv_CourseCode='" & txtCourseCode.Text & "' "
        sql = "SELECT dbo.t_Lecturers.*,dbo.t_Department.* ,dbo.t_Faculty.* " & _
        "FROM dbo.t_Lecturers INNER JOIN dbo.t_Department " & _
        "ON dbo.t_Lecturers.fv_DepCode = dbo.t_Department.pv_DepCode " & _
        "INNER JOIN dbo.t_Faculty " & _
        "ON dbo.t_Lecturers.fv_FacCode=dbo.t_Faculty.pv_FacultyCode " & _
        "WHERE dbo.t_Lecturers.pv_LecId ='" & txtLecId.Text & "' "
        '"WHERE t_StudUnits.pv_UnitCode ='" & txtUnitCode.Text & "' "
        '"dbo.t_Lecturers INNER JOIN dbo.t_Faculty" & _
        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        If Not rs.EOF Then
            Do Until rs.EOF
                spreadLecUnits.MaxRows = spreadLecUnits.MaxRows + 1
                spreadLecUnits.Row = spreadLecUnits.MaxRows
                spreadLecUnits.Col = 1
                spreadLecUnits.TypeButtonText = "Edit"
                spreadLecUnits.Col = 1
                spreadLecUnits.Text = rs("pv_LecId").Value
                spreadLecUnits.Col = 2
                spreadLecUnits.Text = rs("v_LecName").Value
                spreadLecUnits.Col = 3
                spreadLecUnits.Text = rs("n_Sex").Value
                spreadLecUnits.Col = 4
                spreadLecUnits.Text = rs("v_DepName").Value
                spreadLecUnits.Col = 5
                spreadLecUnits.Text = rs("v_FacultyName").Value
                'spreadLecUnits.Col = 6
                'spreadLecUnits.Text = rs("fv_FacName").Value



                rs.MoveNext()
            Loop

        End If
        rs.Close()
    End Sub

    Public Sub FormCancel() Implements InterfaceSys.FormCancel
        clearItems()
        frmMain.ToggleControls(True)
    End Sub
    Public Sub FormEdit() Implements InterfaceSys.FormEdit
        mode = "EDIT"
        frmMain.ToggleControls(False)
        'grpboxAddUnits.Enabled = True
    End Sub

    Public Sub FormNew() Implements InterfaceSys.FormNew
        mode = "NEW"
        clearItems()
        'grpboxAddUnits.Enabled = True
        frmMain.ToggleControls(False)
    End Sub

    Public Sub FormSave() Implements InterfaceSys.FormSave
        saveItems()
        addRole()
        addClassRole()
    End Sub

    Private Sub addClassRole()

        Dim val As DBNull
        val = DBNull.Value


        conn.BeginTrans()
        Me.Cursor = Cursors.WaitCursor
        Try
            If mode = "NEW" Then

                sql = "select * from t_Users where fv_LecId='" & txtLecId.Text & "' and v_role='" & "CLASS" & "'"
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
                    rs("v_UserName").Value = txtLecId.Text
                    rs("v_Password").Value = txtLecId.Text
                    rs("fv_LecId").Value = txtLecId.Text





                End If
                'rs = Nothing
                myStream = Nothing
            ElseIf mode = "EDIT" Then
                spreadLecUnits.Row = spreadLecUnits.ActiveRow
                spreadLecUnits.Col = 1

                sql = "select * from t_Users where fv_LecId='" & txtLecId.Text & "'"
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
            rs("v_UserName").Value = txtLecId.Text
            rs("v_Password").Value = txtLecId.Text
            rs("fv_LecId").Value = txtLecId.Text
            rs.Update()

            conn.CommitTrans()
            Me.Cursor = Cursors.Arrow
            MsgBox("Saved successfully", MsgBoxStyle.Information, "Units")
            clearItems()
            rs.Close()
            loadSpreadLecUnits()
            frmMain.ToggleControls(True)

            modLecturers = "QUERY"

        Catch ex As Exception
            conn.RollbackTrans()
            Me.Cursor = Cursors.Arrow
            MsgBox(ex.Message, MsgBoxStyle.Information, "User")

        End Try

    End Sub

    Public Sub FormSubmit() Implements InterfaceSys.FormSubmit

    End Sub
    Private Sub addRole()
        Dim val As DBNull
        val = DBNull.Value


        conn.BeginTrans()
        Me.Cursor = Cursors.WaitCursor
        Try
            If mode = "NEW" Then
              
                sql = "select * from t_Users where fv_LecId='" & txtLecId.Text & "'"
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

                    
                    rs("v_role").Value = "LECTURER"
                    rs("v_UserName").Value = txtLecId.Text
                    rs("v_Password").Value = txtLecId.Text
                    rs("fv_LecId").Value = txtLecId.Text
                    


                   

                End If
                'rs = Nothing
                myStream = Nothing
            ElseIf mode = "EDIT" Then
                spreadLecUnits.Row = spreadLecUnits.ActiveRow
                spreadLecUnits.Col = 1

                sql = "select * from t_Users where fv_LecId='" & txtLecId.Text & "'"
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

            rs("v_role").Value = "LECTURER"
            rs("v_UserName").Value = txtLecId.Text
            rs("v_Password").Value = txtLecId.Text
            rs("fv_LecId").Value = txtLecId.Text
            rs.Update()

            conn.CommitTrans()
            Me.Cursor = Cursors.Arrow
            MsgBox("Saved successfully", MsgBoxStyle.Information, "Units")
            clearItems()
            rs.Close()
            loadSpreadLecUnits()
            frmMain.ToggleControls(True)

            modLecturers = "QUERY"

        Catch ex As Exception
            conn.RollbackTrans()
            Me.Cursor = Cursors.Arrow
            MsgBox(ex.Message, MsgBoxStyle.Information, "User")

        End Try

    End Sub


    Private Sub saveItems()
        Dim val As DBNull
        val = DBNull.Value

        myStream = New ADODB.Stream
        myStream.Type = ADODB.StreamTypeEnum.adTypeBinary
        conn.BeginTrans()
        Me.Cursor = Cursors.WaitCursor
        Try
            If mode = "NEW" Then
        

                sql = "select * from t_Lecturers where pv_LecId='" & txtLecId.Text & "'"
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
                    myStream.Open()
                    rs("pv_LecId").Value = txtLecId.Text

                    rs("v_LecName").Value = txtLecName.Text
                   
                    rs("fv_DepCode").Value = txtDepCode.Text
                    rs("fv_FacCode").Value = txtFacCode.Text
                    
                    rs("n_sex").Value = txtSex.Text
                    

                    If PicLec.Image Is Nothing Then
                    Else
                        If imgName = "" Then
                        Else
                            myStream.LoadFromFile(imgName)
                            rs("im_lecPic").Value = myStream.Read
                        End If
                    End If

                End If
                'rs = Nothing
                myStream = Nothing
            ElseIf mode = "EDIT" Then
                spreadLecUnits.Row = spreadLecUnits.ActiveRow
                spreadLecUnits.Col = 1


                sql = "select * from t_Lecturers where pv_LecId='" & txtLecId.Text & "'"
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

            'myStream.Open()
            rs("pv_LecId").Value = txtLecId.Text
            'rs("im_StudPic").Value = picStude.Image
            rs("v_LecName").Value = txtLecName.Text
            'rs("fv_UnitName").Value = cbxUnitName.Text
            'rs("fv_UnitCode").Value = cbxUnitCode.Text
            rs("fv_DepCode").Value = txtDepCode.Text
            rs("fv_FacCode").Value = txtFacCode.Text
            'rs("fv_DepName").Value = cbxDepartment.Text
            'rs("fv_FacName").Value = cbxFaculty.Text

            rs("n_sex").Value = txtSex.Text



            'If PicLec.Image Is Nothing Then
            'Else
            '    If imgName = "" Then
            '    Else
            '        myStream.LoadFromFile(imgName)
            '        rs("im_lecPic").Value = myStream.Read
            '    End If
            'End If
            rs.Update()

            conn.CommitTrans()
            Me.Cursor = Cursors.Arrow
            MsgBox("Saved successfully", MsgBoxStyle.Information, "Units")
            clearItems()
            rs.Close()
            loadSpreadLecUnits()
            frmMain.ToggleControls(True)

            modLecturers = "QUERY"

        Catch ex As Exception
            conn.RollbackTrans()
            Me.Cursor = Cursors.Arrow
            MsgBox(ex.Message, MsgBoxStyle.Information, "User")

        End Try

    End Sub
    Dim img As Image
    Private Sub btnPicBrowse_Click(sender As System.Object, e As System.EventArgs) Handles btnPicBrowse.Click
        Dim dlgImage As FileDialog = New OpenFileDialog()
        dlgImage.Filter = "Image File (*.jpg;*.bmp;*.gif)|*.jpg;*.bmp;*.gif"

        If dlgImage.ShowDialog() = DialogResult.OK Then
            imgName = dlgImage.FileName

            Dim newimg As New Bitmap(imgName)

            PicLec.SizeMode = PictureBoxSizeMode.StretchImage
            PicLec.Image = DirectCast(newimg, Image)

        End If

        dlgImage = Nothing
    End Sub

    Private Sub RBMale_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RBMale.CheckedChanged
        txtSex.Text = "Male"

    End Sub

    Private Sub RBFemale_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RBFemale.CheckedChanged
        txtSex.Text = "Female"
    End Sub

    Private Sub cbxFaculty_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbxFaculty.SelectedIndexChanged
        sql = "Select * from t_Faculty where v_FacultyName='" & cbxFaculty.Text & "'"
        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        If Not rs.EOF Then
            txtFacCode.Text = rs("pv_FacultyCode").Value

        End If
        rs.Close()
        cbxDep.Text = ""
        txtDepCode.Text = ""

        loadDep()
    End Sub

    Private Sub cbxDep_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbxDep.SelectedIndexChanged
        sql = "Select * from t_Department where v_DepName='" & cbxDep.Text & "'"
        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        If Not rs.EOF Then
            txtDepCode.Text = rs("pv_DepCode").Value
        End If
        rs.Close()
        'txtUnitCode.Text = ""
        'txtUnitName.Text = ""
        'loadSpreadLecUnits()

    End Sub

    Private Sub spreadLecUnits_ClickEvent(sender As System.Object, e As AxFPSpread._DSpreadEvents_ClickEvent) Handles spreadLecUnits.ClickEvent
        spreadLecUnits.Row = spreadLecUnits.ActiveRow
        spreadLecUnits.Col = 1
        Dim val As DBNull
        val = DBNull.Value

        myStream = New ADODB.Stream
        myStream.Type = ADODB.StreamTypeEnum.adTypeBinary

        'sql = "SELECT * FROM t_Students where pv_StudRegNo= '" & spreadStud.Text & "'"
        sql = "SELECT dbo.t_Lecturers.*,dbo.t_Department.* ,dbo.t_Faculty.* " & _
        "FROM dbo.t_Lecturers INNER JOIN dbo.t_Department " & _
        "ON dbo.t_Lecturers.fv_DepCode = dbo.t_Department.pv_DepCode " & _
        "INNER JOIN dbo.t_Faculty " & _
        "ON dbo.t_Lecturers.fv_FacCode=dbo.t_Faculty.pv_FacultyCode " & _
        "WHERE dbo.t_Lecturers.pv_LecId ='" & spreadLecUnits.Text & "' "
        Try
            rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        If Not rs.EOF Then

            txtDepCode.Text = rs("fv_DepCode").Value
            'cbxDep.Text = rs("v_DepName").Value
            txtFacCode.Text = rs("fv_FacCode").Value
            'cbxFaculty.Text = rs("v_FacultyName").Value
            txtLecName.Text = rs("v_LecName").Value
            txtLecId.Text = rs("pv_LecId").Value
            txtSex.Text = rs("n_sex").Value



            If Not val.Equals(rs("im_lecPic").Value) Then
                myStream.Open()
                Dim data As Byte() = DirectCast(rs("im_lecPic").Value, Byte())
                Dim ms As New MemoryStream(data)
                PicLec.Image = Image.FromStream(ms)
            Else
                PicLec.Image = Nothing
            End If


            myStream = Nothing

        Else
            MsgBox("No Student. Add new")
        End If
        rs.Close()
    End Sub

    Private Sub pnlDetails_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles pnlDetails.Paint

    End Sub

    Private Sub frmRegLecs_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Enabled = False
    End Sub

    Private Sub frmRegLecs_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        pForm.RemoveTabPage(tp)
    End Sub
End Class