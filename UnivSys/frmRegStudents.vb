'Imports System.Configuration
'Imports System.Data.SqlClient
Imports System.IO
Public Class frmRegStudents
    Implements InterfaceSys
    Dim imgName As String
    Dim modStudents As String = "QUERY"
    ''Dim autoNo3 As Integer
    Dim myStream As New ADODB.Stream
    Private tp As New TabPage("Add Students")
    Private pForm As frmMain


    Private Sub frmRegStudents_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        pForm = Me.ParentForm
        pForm.AddTabPage(tp)
        loadFaculty()
        loadSex()
        'loadSpreadMain()
    End Sub
    Private Sub loadSex()

        If RBMale.Checked = True Then

            txtSex.Text = "Male"
        ElseIf RBFemale.Checked = True Then

            txtSex.Text = "Female"
        End If

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

    Private Sub loadCourse()

        cbxCourse.Items.Clear()

        Dim rs As ADODB.Recordset
        rs = New ADODB.Recordset
        sql = "Select v_CourseName from t_Courses where fv_DepName='" & cbxDepartment.Text & "'"
        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        Do While Not rs.EOF
            cbxCourse.Items.Add(rs("v_CourseName").Value)
            rs.MoveNext()
        Loop
        rs = Nothing

    End Sub
    Private Sub clearItems()

    End Sub
    Private Sub addRole()
        Dim val As DBNull
        val = DBNull.Value


        conn.BeginTrans()
        Me.Cursor = Cursors.WaitCursor
        Try
            If mode = "NEW" Then

                sql = "select * from t_Users where fv_StudRegNo='" & txtStudRegNo.Text & "'"
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

                    rs("v_role").Value = "STUDENT"
                    rs("v_UserName").Value = txtStudRegNo.Text
                    rs("v_Password").Value = txtStudRegNo.Text
                    rs("fv_LecId").Value = txtStudRegNo.Text




                End If
                'rs = Nothing

            ElseIf mode = "EDIT" Then
               

                sql = "select * from t_Users where fv_StudRegNo='" & txtStudRegNo.Text & "'"
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

            rs("v_role").Value = "STUDENT"
            rs("v_UserName").Value = txtStudRegNo.Text
            rs("v_Password").Value = txtStudRegNo.Text
            rs("fv_LecId").Value = txtStudRegNo.Text
            rs.Update()

            conn.CommitTrans()
            Me.Cursor = Cursors.Arrow
            MsgBox("Saved successfully", MsgBoxStyle.Information, "Units")
            clearItems()
            rs.Close()

            frmMain.ToggleControls(True)

            modStudents = "QUERY"

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

                sql = "select * from t_Students where pv_StudRegNo='" & txtStudRegNo.Text & "'"
                'rs("pv_FacultyCode").Value = txtFacCode.Text
                rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

                If Not rs.EOF Then
                    conn.RollbackTrans()
                    Me.Cursor = Cursors.Arrow
                    MsgBox("Student Reg exists,please enter different Code", MsgBoxStyle.Information, "Registration Number")
                    rs.Close()
                    Exit Sub
                Else
                    rs.AddNew()
                    myStream.Open()
                    rs("pv_StudRegNo").Value = txtStudRegNo.Text
                    'rs("im_StudPic").Value = picStude.Image
                    rs("v_StudName").Value = txtStudName.Text
                    rs("fv_CourseName").Value = cbxCourse.Text
                    rs("fv_CourseCode").Value = txtCourseCode.Text
                    rs("fv_DepCode").Value = txtDepCode.Text
                    rs("fv_FacCode").Value = txtFacCode.Text
                    rs("fv_DepName").Value = cbxDepartment.Text
                    rs("fv_FacName").Value = cbxFaculty.Text

                    rs("n_Sex").Value = txtSex.Text

                    'If Not val.Equals(rs("im_StudPic").Value) Then
                    '    myStream.Open()
                    '    Dim data As Byte() = DirectCast(rs("im_StudPic").Value, Byte())
                    '    Dim ms As New MemoryStream(data)
                    '    picStude.Image = Image.FromStream(ms)
                    'Else
                    '    picStude.Image = Nothing
                    'End If

                    If picStude.Image Is Nothing Then
                    Else
                        If imgName = "" Then
                        Else
                            myStream.LoadFromFile(imgName)
                            rs("im_StudPic").Value = myStream.Read
                        End If
                    End If

                End If
                'rs = Nothing
                myStream = Nothing
            ElseIf mode = "EDIT" Then
                spreadStud.Row = spreadStud.ActiveRow
                spreadStud.Col = 1
                sql = "select * from t_Students where pv_StudRegNo='" & txtStudRegNo.Text & "'"
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
            rs("pv_StudRegNo").Value = txtStudRegNo.Text
            'rs("im_StudPic").Value = picStude.Image
            rs("v_StudName").Value = txtStudName.Text
            rs("fv_CourseName").Value = cbxCourse.Text
            rs("fv_CourseCode").Value = txtCourseCode.Text
            rs("fv_DepCode").Value = txtDepCode.Text
            rs("fv_FacCode").Value = txtFacCode.Text
            rs("fv_DepName").Value = cbxDepartment.Text
            rs("fv_FacName").Value = cbxFaculty.Text

            rs("n_Sex").Value = txtSex.Text

            rs.Update()

            conn.CommitTrans()
            Me.Cursor = Cursors.Arrow
            MsgBox("Saved successfully", MsgBoxStyle.Information, "Units")
            clearItems()
            rs.Close()
            loadSpreadStud()
            frmMain.ToggleControls(True)

            modStudents = "QUERY"

        Catch ex As Exception
            conn.RollbackTrans()
            Me.Cursor = Cursors.Arrow
            MsgBox(ex.Message, MsgBoxStyle.Information, "User")

        End Try

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
    End Sub

    Public Sub FormSubmit() Implements InterfaceSys.FormSubmit

    End Sub

    Private Sub loadSpreadStud()
        spreadStud.MaxRows = 0
        rs = New ADODB.Recordset
        sql = "Select * from t_Students where fv_CourseCode='" & txtCourseCode.Text & "' "

        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        If Not rs.EOF Then
            Do Until rs.EOF
                spreadStud.MaxRows = spreadStud.MaxRows + 1
                spreadStud.Row = spreadStud.MaxRows
                spreadStud.Col = 1
                spreadStud.TypeButtonText = "Edit"
                spreadStud.Col = 1
                spreadStud.Text = rs("pv_StudRegNo").Value
                spreadStud.Col = 2
                spreadStud.Text = rs("v_StudName").Value
                spreadStud.Col = 3
                spreadStud.Text = rs("n_Sex").Value
                spreadStud.Col = 4
                spreadStud.Text = rs("fv_CourseName").Value
                spreadStud.Col = 5
                spreadStud.Text = rs("fv_DepName").Value
                spreadStud.Col = 6
                spreadStud.Text = rs("fv_FacName").Value



                rs.MoveNext()
            Loop

        End If
        rs.Close()
    End Sub

    Private Sub cbxDepartment_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbxDepartment.SelectedIndexChanged
        sql = "Select * from t_Department where v_DepName='" & cbxDepartment.Text & "'"
        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        If Not rs.EOF Then
            txtDepCode.Text = rs("pv_DepCode").Value
        End If
        rs.Close()
        'txtUnitCode.Text = ""
        'txtUnitName.Text = ""
        'loadSpreadUnits()
        loadCourse()
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
        'txtUnitCode.Text = ""
        'txtUnitName.Text = ""
        'txtDescri.Text = ""
        loadDep()
    End Sub

    Private Sub cbxCourse_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbxCourse.SelectedIndexChanged
        sql = "Select * from t_Courses where v_CourseName='" & cbxCourse.Text & "'"
        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        'rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        If Not rs.EOF Then
            txtCourseCode.Text = rs("pv_CourseCode").Value
        End If
        rs.Close()
        'txtUnitCode.Text = ""
        'txtUnitName.Text = ""
        loadSpreadStud()
        'loadCourse()
    End Sub
    Dim img As Image
    Private Sub btnPicBrowse_Click(sender As System.Object, e As System.EventArgs) Handles btnPicBrowse.Click
        Dim dlgImage As FileDialog = New OpenFileDialog()
        dlgImage.Filter = "Image File (*.jpg;*.bmp;*.gif)|*.jpg;*.bmp;*.gif"

        If dlgImage.ShowDialog() = DialogResult.OK Then
            imgname = dlgImage.FileName

            Dim newimg As New Bitmap(imgname)

            picStude.SizeMode = PictureBoxSizeMode.StretchImage
            picStude.Image = DirectCast(newimg, Image)

        End If

        dlgImage = Nothing
        'MsgBox(imgname)

        'Dim OpenFileDialog1 As New OpenFileDialog
        'OpenFileDialog1.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg;*.jpeg"
        'If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
        '    picStude.Image = Image.FromFile(OpenFileDialog1.FileName)
        '    Dim newsize As New Size(200, 200)
        '    img = New Bitmap(picStude.Image, newsize)

        '    picStude.Image = img
        'End If

    End Sub

    Private Sub RBMale_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RBMale.CheckedChanged
        txtSex.Text = "Male"
    End Sub

    Private Function rbvalue() As Object
        Throw New NotImplementedException
    End Function

    Private Sub RBFemale_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RBFemale.CheckedChanged
        txtSex.Text = "Female"
    End Sub

    Private Sub pnlMain_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles pnlMain.Paint

    End Sub

    Private Sub spreadStud_ClickEvent(sender As System.Object, e As AxFPSpread._DSpreadEvents_ClickEvent) Handles spreadStud.ClickEvent
        spreadStud.Row = spreadStud.ActiveRow
        spreadStud.Col = 1
        Dim val As DBNull
        val = DBNull.Value

        myStream = New ADODB.Stream
        myStream.Type = ADODB.StreamTypeEnum.adTypeBinary

        sql = "SELECT * FROM t_Students where pv_StudRegNo= '" & spreadStud.Text & "'"
        Try
            rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        If Not rs.EOF Then
            txtCourseCode.Text = rs("fv_CourseCode").Value
            txtDepCode.Text = rs("fv_DepCode").Value
            cbxDepartment.Text = rs("fv_DepName").Value
            txtFacCode.Text = rs("fv_FacCode").Value
            cbxFaculty.Text = rs("fv_FacName").Value
            txtStudName.Text = rs("v_StudName").Value
            txtStudRegNo.Text = rs("pv_StudRegNo").Value
            txtSex.Text = rs("n_Sex").Value


            If Not Val.Equals(rs("im_StudPic").Value) Then
                myStream.Open()
                Dim data As Byte() = DirectCast(rs("im_StudPic").Value, Byte())
                Dim ms As New MemoryStream(data)
                picStude.Image = Image.FromStream(ms)
            Else
                picStude.Image = Nothing
            End If


            myStream = Nothing

        Else
            MsgBox("No Student. Add new")
        End If
            rs.Close()
    End Sub

    Private Sub picStude_Click(sender As System.Object, e As System.EventArgs) Handles picStude.Click

    End Sub

    Private Sub frmRegStudents_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Enabled = False
    End Sub

    Private Sub frmRegStudents_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        pForm.RemoveTabPage(tp)
    End Sub
End Class