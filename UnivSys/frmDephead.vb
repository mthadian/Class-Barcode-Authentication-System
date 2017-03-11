Public Class frmDephead
    Implements InterfaceSys
    Dim modDepHead As String = "QUERY"
    Dim perAttendance As Single = 0
    ''Dim autoNo3 As Integer
    Dim result As Single
    Private tp As New TabPage("Department Head")
    Private pForm As frmMain
    Private Sub frmDephead_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        pForm = Me.ParentForm
        pForm.AddTabPage(tp)
        lblDepHead.Text = frmLogin.txtUsername.Text
        loadSpreadLecs()
        loadByCourse()


    End Sub
    




    Private Sub loadSpreadUnitAttendance()
        spreadUnitAttendance.MaxRows = 0
        rs = New ADODB.Recordset

        sql = "SELECT dbo.t_StudUnits.*,dbo.t_Students.* ,dbo.t_LecUnits.* " & _
       "FROM dbo.t_StudUnits INNER JOIN dbo.t_Students " & _
       "ON dbo.t_StudUnits.fv_StudReg = dbo.t_Students.pv_StudRegNo " & _
       "INNER JOIN dbo.t_LecUnits " & _
       "ON dbo.t_StudUnits.fv_Time=dbo.t_LecUnits.v_Time " & _
       "WHERE dbo.t_StudUnits.fv_StudReg ='" & lblCode.Text & " '"

        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)

        If Not rs.EOF Then
            Do Until rs.EOF
                perAttendance = (rs("in_Attendance").Value / rs("in_MaxAttendance").Value) * 100
                If rs("in_Attendance").Value = "0" And rs("in_MaxAttendance").Value = "0" Then
                    result = "0"
                Else
                    result = Math.Round(perAttendance, 2)
                End If
                spreadUnitAttendance.MaxRows = spreadUnitAttendance.MaxRows + 1
                spreadUnitAttendance.Row = spreadUnitAttendance.MaxRows
                spreadUnitAttendance.Col = 1
                spreadUnitAttendance.TypeButtonText = "Edit"
                spreadUnitAttendance.Col = 1
                spreadUnitAttendance.Text = rs("pv_UnitCode").Value
                spreadUnitAttendance.Col = 2
                spreadUnitAttendance.Text = rs("v_UnitName").Value

                spreadUnitAttendance.Col = 3
                spreadUnitAttendance.Text = rs("in_Attendance").Value
                spreadUnitAttendance.Col = 4
                spreadUnitAttendance.Text = result



                rs.MoveNext()
            Loop

        End If

        rs.Close()
    End Sub
    Private Sub loadByCourse()
        Dim rs As ADODB.Recordset
        rs = New ADODB.Recordset
        'sql = "Select * from dbo.t_LecUnits where dbo.t_LecUnits.fv_LecId='" & lblUser.Text & "'"
        sql = "SELECT * FROM dbo.t_Courses WHERE fv_DepName ='" & lblDepName.Text & " '"
        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        Do While Not rs.EOF
            cbxSortCourse.Items.Add(rs("v_CourseName").Value)
            'lblLecName.Text = rs("v_LecName").Value
            rs.MoveNext()
        Loop
        rs = Nothing
    End Sub
    Private Sub loadSpreadByCourse()
        spreadUnitStudents.MaxRows = 0
        rs = New ADODB.Recordset

        sql = "SELECT * FROM dbo.t_Students WHERE fv_CourseName ='" & cbxSortCourse.Text & " '"

        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)

        If Not rs.EOF Then
            Do Until rs.EOF

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




                rs.MoveNext()


            Loop

        End If
        rs.Close()
    End Sub
    Private Sub loadSpreadUnitsCourse()
        spreadUnitStudents.MaxRows = 0
        rs = New ADODB.Recordset

        sql = "SELECT * FROM dbo.t_Students WHERE fv_DepName ='" & lblDepName.Text & " '"

        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)

        If Not rs.EOF Then
            Do Until rs.EOF
                
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




                rs.MoveNext()


            Loop

        End If
        rs.Close()
    End Sub

    Private Sub loadSpreadLecs()
        spreadLecs.MaxRows = 0
        rs = New ADODB.Recordset

        sql = "SELECT dbo.t_Department.*,dbo.t_Lecturers.*  " & _
        "FROM dbo.t_Department INNER JOIN dbo.t_Lecturers " & _
        "ON dbo.t_Department.pv_DepCode = dbo.t_Lecturers.fv_DepCode " & _
        "WHERE dbo.t_Department.v_DepHeadID='" & lblDepHead.Text & " '"

        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)

        If Not rs.EOF Then
            Do Until rs.EOF


                spreadLecs.MaxRows = spreadLecs.MaxRows + 1
                spreadLecs.Row = spreadLecs.MaxRows
                spreadLecs.Col = 1
                spreadLecs.TypeButtonText = "Edit"
                spreadLecs.Col = 1
                spreadLecs.Text = rs("pv_LecId").Value
                spreadLecs.Col = 2
                spreadLecs.Text = rs("v_LecName").Value

                'spreadUnitStudents.Col = 3
                'spreadUnitStudents.Text = rs("fv_CourseName").Value
                'spreadUnitStudents.Col = 4
                'spreadUnitStudents.Text = rs("fv_DepName").Value

                lblDepName.Text = rs("v_DepName").Value

                rs.MoveNext()

            Loop

        End If
        rs.Close()
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

    Private Sub frmDephead_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Enabled = False
    End Sub

    Private Sub frmDephead_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        pForm.RemoveTabPage(tp)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        loadSpreadUnitsCourse()
    End Sub

    Private Sub cbxSortCourse_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbxSortCourse.SelectedIndexChanged
        loadSpreadByCourse()
    End Sub

    Private Sub spreadUnitStudents_ClickEvent(sender As System.Object, e As AxFPSpread._DSpreadEvents_ClickEvent) Handles spreadUnitStudents.ClickEvent
        spreadUnitStudents.Row = spreadUnitStudents.ActiveRow
        spreadUnitStudents.Col = 1


        sql = "SELECT * FROM dbo.t_Students where pv_StudRegNo= '" & spreadUnitStudents.Text & "'"
        Try
            rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        If Not rs.EOF Then
            'txtSearchStud.Text = rs("pv_StudRegNo").Value
            lblCode.Text = rs("pv_StudRegNo").Value

            lblName.Text = rs("v_StudName").Value

        Else
            MsgBox("No Student. Add new")
        End If

        rs.Close()
        loadSpreadUnitAttendance()
    End Sub

    Private Sub spreadLecs_ClickEvent(sender As System.Object, e As AxFPSpread._DSpreadEvents_ClickEvent) Handles spreadLecs.ClickEvent
        spreadLecs.Row = spreadLecs.ActiveRow
        spreadLecs.Col = 1


        sql = "SELECT * FROM dbo.t_Lecturers where pv_LecId= '" & spreadLecs.Text & "'"
        Try
            rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        If Not rs.EOF Then
            'txtSearchStud.Text = rs("pv_StudRegNo").Value
            lblLecName.Text = rs("v_LecName").Value

            lblLecId.Text = rs("pv_LecId").Value

        Else
            MsgBox("No Lecturer. Add new")
        End If

        rs.Close()
        loadSpreadLecUnits()
    End Sub
    Private Sub loadSpreadLecUnits()
        spreadLecUnits.MaxRows = 0
        rs = New ADODB.Recordset
        'sql = "Select * from t_Units where fv_DepCode='" & txtDepCode.Text & "' "
        sql = "SELECT dbo.t_LecUnits.*,dbo.t_Department.* ,dbo.t_Units.* " & _
        "FROM dbo.t_LecUnits INNER JOIN dbo.t_Department " & _
        "ON dbo.t_LecUnits.fv_DepCode = dbo.t_Department.pv_DepCode " & _
        "INNER JOIN dbo.t_Units " & _
        "ON dbo.t_LecUnits.fv_UnitCode=dbo.t_Units.pv_UnitCode " & _
        "WHERE dbo.t_LecUnits.fv_LecId ='" & lblLecId.Text & "' "

        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        If Not rs.EOF Then
            Do Until rs.EOF
                spreadLecUnits.MaxRows = spreadLecUnits.MaxRows + 1
                spreadLecUnits.Row = spreadLecUnits.MaxRows
                spreadLecUnits.Col = 1
                spreadLecUnits.TypeButtonText = "Edit"
                spreadLecUnits.Col = 1
                spreadLecUnits.Text = rs("fv_UnitCode").Value
                spreadLecUnits.Col = 2
                spreadLecUnits.Text = rs("v_UnitName").Value
                spreadLecUnits.Col = 3
                spreadLecUnits.Text = rs("v_Day").Value
                spreadLecUnits.Col = 4
                spreadLecUnits.Text = rs("v_Time").Value

                'spreadLecUnits.Col = 3
                'spreadLecUnits.Text = rs("v_DepName").Value



                rs.MoveNext()
            Loop

        End If
        rs.Close()
    End Sub

    Private Sub spreadLecUnits_ClickEvent(sender As System.Object, e As AxFPSpread._DSpreadEvents_ClickEvent) Handles spreadLecUnits.ClickEvent
        spreadLecUnits.Row = spreadLecUnits.ActiveRow
        spreadLecUnits.Col = 1

        sql = "SELECT dbo.t_LecUnits.*,dbo.t_Units.* " & _
        "FROM dbo.t_LecUnits INNER JOIN dbo.t_Units " & _
        "ON dbo.t_LecUnits.fv_UnitCode = dbo.t_Units.pv_UnitCode " & _
        "WHERE dbo.t_LecUnits.fv_UnitCode ='" & spreadLecUnits.Text & " '"

        'sql = "SELECT * FROM dbo.t_Lecturers where pv_LecId= '" & spreadLecUnits.Text & "'"
        Try
            rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        If Not rs.EOF Then
            'txtSearchStud.Text = rs("pv_StudRegNo").Value
            lblCode.Text = rs("pv_UnitCode").Value

            lblName.Text = rs("v_UnitName").Value


        Else
            MsgBox("No Lecturer. Add new")
        End If

        rs.Close()
        loadSpreadLecUnitStud()

    End Sub
    Private Sub loadSpreadLecUnitStud()
        spreadUnitAttendance.MaxRows = 0
        rs = New ADODB.Recordset

        ' sql = "SELECT dbo.t_StudUnits.*,dbo.t_Students.* ,dbo.t_LecUnits.* " & _
        '"FROM dbo.t_StudUnits INNER JOIN dbo.t_Students " & _
        '"ON dbo.t_StudUnits.fv_StudReg = dbo.t_Students.pv_StudRegNo " & _
        '"INNER JOIN dbo.t_LecUnits " & _
        '"ON dbo.t_StudUnits.pv_UnitCode=dbo.t_LecUnits.fv_UnitCode" & _
        '"WHERE dbo.t_LecUnits.fv_UnitCode ='" & lblCode.Text & " '"
        sql = "SELECT dbo.t_StudUnits.*,dbo.t_Students.* ,dbo.t_LecUnits.* " & _
      "FROM dbo.t_StudUnits INNER JOIN dbo.t_Students " & _
      "ON dbo.t_StudUnits.fv_StudReg = dbo.t_Students.pv_StudRegNo " & _
      "INNER JOIN dbo.t_LecUnits " & _
      "ON dbo.t_StudUnits.fv_Time=dbo.t_LecUnits.v_Time " & _
      "WHERE dbo.t_LecUnits.fv_UnitCode ='" & lblCode.Text & " '"


        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)

        If Not rs.EOF Then
            Do Until rs.EOF
                perAttendance = (rs("in_Attendance").Value / rs("in_MaxAttendance").Value) * 100
                If rs("in_Attendance").Value = "0" And rs("in_MaxAttendance").Value = "0" Then
                    result = "0"
                Else
                    result = Math.Round(perAttendance, 2)
                End If
                spreadUnitAttendance.MaxRows = spreadUnitAttendance.MaxRows + 1
                spreadUnitAttendance.Row = spreadUnitAttendance.MaxRows
                spreadUnitAttendance.Col = 1
                spreadUnitAttendance.TypeButtonText = "Edit"
                spreadUnitAttendance.Col = 1
                spreadUnitAttendance.Text = rs("pv_StudRegNo").Value
                spreadUnitAttendance.Col = 2
                spreadUnitAttendance.Text = rs("v_StudName").Value

                spreadUnitAttendance.Col = 3
                spreadUnitAttendance.Text = rs("in_Attendance").Value
                spreadUnitAttendance.Col = 4
                spreadUnitAttendance.Text = result



                rs.MoveNext()
            Loop

        End If

        rs.Close()
    End Sub
    Private Sub searchStudent()
        spreadUnitStudents.MaxRows = 0
        rs = New ADODB.Recordset

        'sql = "SELECT * FROM dbo.t_Students WHERE fv_DepName ='" & lblDepName.Text & " '"
        sql = "select * from dbo.t_Students where pv_StudRegNo like '" & txtSearchStud.Text & "%' OR " & _
              "v_StudName like '" & txtSearchStud.Text & "%'"

        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)

        If Not rs.EOF Then
            Do Until rs.EOF

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




                rs.MoveNext()


            Loop

        End If
        rs.Close()
    End Sub

    Private Sub txtSearchStud_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtSearchStud.TextChanged
        searchStudent()
    End Sub
End Class