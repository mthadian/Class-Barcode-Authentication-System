Public Class frmClass
    Implements InterfaceSys
    Dim modClassForm As String = "QUERY"
    Dim counter As Integer = 0
    Dim CounterLec As Integer = 0
    Dim perAttendance As Single = 0
    Dim lecAttendance As Integer = 0
    Private tp As New TabPage("Class")
    Private pform As frmMain


    Private Sub frmClass_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        pform = Me.ParentForm
        pform.AddTabPage(tp)
        lblUnitName.Visible = False
        txtReadBar.Select()
        txtReadBar.Hide()
        txtStudName.Hide()
        lblTime.Text = System.DateTime.Now.ToString(("dd-MM-yyyy"))
        'txtReadBar.Visible = False
        Me.lblUser.Text = frmLogin.txtUsername.Text
        loadLecUnits()


    End Sub
    Private Sub loadLecUnits()
        Dim rs As ADODB.Recordset
        rs = New ADODB.Recordset
        sql = "SELECT dbo.t_Lecturers.*,dbo.t_LecUnits.* " & _
        "FROM dbo.t_Lecturers INNER JOIN dbo.t_LecUnits " & _
        "ON dbo.t_Lecturers.pv_LecId = dbo.t_LecUnits.fv_LecId " & _
        "WHERE dbo.t_LecUnits.fv_LecId='" & lblUser.Text & "'"
        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        Do While Not rs.EOF
            cbxSelectUnit.Items.Add(rs("fv_UnitCode").Value)
            lblLecName.Text = rs("v_LecName").Value
            rs.MoveNext()
        Loop
        rs = Nothing
    End Sub
    Public Sub FormCancel() Implements InterfaceSys.FormCancel

    End Sub

    Public Sub FormEdit() Implements InterfaceSys.FormEdit

    End Sub

    Public Sub FormNew() Implements InterfaceSys.FormNew

    End Sub

    Public Sub FormSave() Implements InterfaceSys.FormSave

    End Sub

    Public Sub FormSubmit() Implements InterfaceSys.FormSubmit

    End Sub

    Private Sub cbxSelectUnit_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbxSelectUnit.SelectedIndexChanged
        sql = "Select * from t_Units where pv_UnitCode='" & cbxSelectUnit.Text & "'"
        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        If Not rs.EOF Then
            txtUnitName.Text = rs("v_UnitName").Value
            lblUnitName.Text = rs("v_UnitName").Value
        End If
        rs.Close()
        lblUnitName.Visible = True
        btnStart.Enabled = True

    End Sub
    Private Sub loadStudents()
        spreadUnitStudents.MaxRows = 0
        rs = New ADODB.Recordset

        sql = "SELECT dbo.t_StudUnits.*,dbo.t_Students.* ,dbo.t_LecUnits.* " & _
        "FROM dbo.t_StudUnits INNER JOIN dbo.t_Students " & _
        "ON dbo.t_StudUnits.fv_StudReg = dbo.t_Students.pv_StudRegNo " & _
        "INNER JOIN dbo.t_LecUnits " & _
        "ON dbo.t_StudUnits.pv_UnitCode = dbo.t_LecUnits.fv_UnitCode " & _
        "WHERE dbo.t_StudUnits.pv_UnitCode ='" & cbxSelectUnit.Text & "' AND dbo.t_LecUnits.fv_LecId='" & lblUser.Text & " '"
       
        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)

        If Not rs.EOF Then
            Do Until rs.EOF
                perAttendance = (rs("in_Attendance").Value / rs("in_MaxAttendance").Value) * 100
                Dim result = Math.Round(perAttendance, 2)
                spreadUnitStudents.MaxRows = spreadUnitStudents.MaxRows + 1
                spreadUnitStudents.Row = spreadUnitStudents.MaxRows
                spreadUnitStudents.Col = 1
                spreadUnitStudents.TypeButtonText = "Edit"
                spreadUnitStudents.Col = 1
                spreadUnitStudents.Text = rs("pv_StudRegNo").Value
                spreadUnitStudents.Col = 2
                spreadUnitStudents.Text = rs("v_StudName").Value

                spreadUnitStudents.Col = 3
                spreadUnitStudents.Text = rs("fv_CourseName").Value
                spreadUnitStudents.Col = 4
                spreadUnitStudents.Text = rs("fv_DepName").Value



                rs.MoveNext()
            Loop

        End If
        rs.Close()
    End Sub
    Private Sub Attendance()
        conn.BeginTrans()

        Me.Cursor = Cursors.WaitCursor

        rs = New ADODB.Recordset
        'If mode = "NEW" Then
        Try

            'sql = "select * from t_StudUnits where pv_UnitCode='" & cbxSelectUnit.Text & "'AND fv_StudReg='" & txtReadBar.Text & "'"

            sql = "SELECT dbo.t_StudUnits.*,dbo.t_LecUnits.* ,dbo.t_Students.* " & _
       "FROM dbo.t_StudUnits INNER JOIN dbo.t_LecUnits " & _
       "ON dbo.t_StudUnits.pv_UnitCode = dbo.t_LecUnits.fv_UnitCode " & _
       "INNER JOIN dbo.t_Students " & _
       "ON dbo.t_StudUnits.fv_StudReg=dbo.t_Students.pv_StudRegNo " & _
       "WHERE dbo.t_StudUnits.pv_UnitCode ='" & cbxSelectUnit.Text & " 'AND dbo.t_StudUnits.fv_StudReg='" & txtReadBar.Text & " ' "

            rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            If Not rs.EOF And lblTime.Text = rs("d_dateNow").Value And txtReadBar.Text = rs("fv_StudReg").Value And cbxSelectUnit.Text = rs("pv_UnitCode").Value Then
                conn.CommitTrans()
                Me.Cursor = Cursors.Arrow
                MsgBox("ALREADY SCANNED ID!", MsgBoxStyle.Exclamation, "" & txtStudName.Text)
                rs.Close()
                Exit Sub
            End If


            counter = rs("in_Attendance").Value + 1
            If rs.EOF Then
                
                conn.RollbackTrans()
                Me.Cursor = Cursors.Arrow
                MsgBox("This Student Is not of this Class", MsgBoxStyle.Information, "INVALID STUDENT!")
                rs.Close()
                Exit Sub
            Else

              
                rs("in_Attendance").Value = counter
                rs("d_dateNow").Value = lblTime.Text
                rs.Update()
                txtAttend.Text = rs("in_Attendance").Value
                txtTotalAttend.Text = rs("in_MaxAttendance").Value
                perAttendance = (txtAttend.Text / txtTotalAttend.Text) * 100
                ''perAttendance = (rs("in_Attendance").Value / rs("in_MaxAttendance").Value) * 100
                'txtPerAttend.Text = perAttendance.ToString
                txtStudName.Text = rs("v_StudName").Value
            End If

            conn.CommitTrans()
            Me.Cursor = Cursors.Arrow
            MsgBox("WELCOME TO CLASS!", MsgBoxStyle.Information, "" & txtStudName.Text)
            rs.Close()

        Catch ex As Exception

            conn.RollbackTrans()
            Me.Cursor = Cursors.Arrow
            MsgBox(txtReadBar.Text & "   Is not a member of this class!", MsgBoxStyle.Exclamation, "INVALID STUDENT!")
            rs.Close()

        End Try

        rs = Nothing

    End Sub
    Private Sub lecAttend()
        sql = "Select * from t_LecUnits where fv_UnitCode='" & cbxSelectUnit.Text & "'"
        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        lecAttendance = rs("in_MaxAttendance").Value + 1
        If Not rs.EOF Then

            rs("in_MaxAttendance").Value = lecAttendance
            rs.Update()
        End If
        rs.Close()


    End Sub

    'Private Sub calcAttendance()
    '    conn.BeginTrans()

    '    Me.Cursor = Cursors.WaitCursor
    '    'Dim rs As New ADODB.Recordset
    '    rs = New ADODB.Recordset
    '    Try
    '        sql = "SELECT dbo.t_StudUnits.*,dbo.t_LecUnits.* ,dbo.t_Attendance.* " & _
    '   "FROM dbo.t_StudUnits INNER JOIN dbo.t_LecUnits " & _
    '   "ON dbo.t_StudUnits.pv_UnitCode = dbo.t_LecUnits.fv_UnitCode " & _
    '   "INNER JOIN dbo.t_Attendance " & _
    '   "ON dbo.t_StudUnits.pv_UnitCode = dbo.t_Attendance.fv_UnitCode " & _
    '   "WHERE dbo.t_StudUnits.pv_UnitCode ='" & cbxSelectUnit.Text & " '"

    '        'sql = "Select * from t_Units where v_UnitName='" & cbxUnitName.Text & "'"
    '        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)

    '        'counter = rs("in_Attendance").Value + 1
    '        If rs.EOF Then
    '            conn.RollbackTrans()
    '            Me.Cursor = Cursors.Arrow
    '            MsgBox("This Student Is not of this Class", MsgBoxStyle.Information, "INVALID STUDENT!")

    '            rs("v_Attendance").Value = "0"
    '            rs.Close()
    '            Exit Sub
    '        Else



    '            rs("v_Attendance").Value = counter

    '            rs.Update()
    '            txtAttend.Text = rs("in_Attendance").Value
    '            txtTotalAttend.Text = rs("in_MaxAttendance").Value
    '            perAttendance = (txtAttend.Text / txtTotalAttend.Text) * 100
    '            'perAttendance = (rs("in_Attendance").Value / rs("in_MaxAttendance").Value) * 100
    '            txtPerAttend.Text = perAttendance.ToString

    '        End If
    '        conn.CommitTrans()
    '        Me.Cursor = Cursors.Arrow
    '        MsgBox("Welcome to class !", MsgBoxStyle.Information, "Valid Student")
    '        rs.Close()
    '    Catch ex As Exception
    '        conn.RollbackTrans()
    '        Me.Cursor = Cursors.Arrow
    '        MsgBox(txtReadBar.Text & "   Is not a member of this class!", MsgBoxStyle.Information, "INVALID STUDENT!")
    '        rs.Close()

    '    End Try

    '    rs = Nothing


    'End Sub



    Private Sub txtReadBar_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtReadBar.KeyDown
        If e.KeyCode = Keys.Enter Then
            Attendance()
            txtReadBar.Clear()
            txtStudName.Clear()
            loadStudents()
        End If
    End Sub

    Private Sub frmClass_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        pform.RemoveTabPage(tp)
    End Sub

    Private Sub frmClass_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Enabled = False
    End Sub

    Private Sub btnStart_Click(sender As System.Object, e As System.EventArgs) Handles btnStart.Click
        txtReadBar.Show()
        txtReadBar.Select()
        'calcAttendance()
        lecAttend()
        loadStudents()
        btnStart.Enabled = False
    End Sub
End Class