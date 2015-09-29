Imports System.Data.SqlClient
Public Class frm_main

#Region "Variable"
    Dim intStep As Integer
    Dim clscon As New clsProcedure
    Dim strSQL As String
#End Region

#Region "User Difination"

#Region "Enum"

    Private Enum optionQuery
        append_update = 0
        select_Query = 1
        insert_Query = 2
        update_Query = 3
        Delete_Query = 4
    End Enum

    Private Enum ErrorNo
        NoCheck = 0
        SelectLang = 1
        NoPrimary = 2
    End Enum

    Private Enum Language
        vb = 0
        csharp = 1
    End Enum

#End Region

#Region "Generate T-SQL String"

   

    ''' <summary>
    ''' Has Error
    ''' </summary>
    ''' <param name="errornoo"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function HasError(ByVal errornoo As ErrorNo) As Boolean
        HasError = True

        Select Case errornoo

            Case ErrorNo.NoCheck
                For Each row As DataGridViewRow In dgdetails.Rows
                    If row.IsNewRow = False Then
                        If row.Cells(0).Value = 1 Then
                            HasError = False
                        End If
                    End If
                Next

            Case ErrorNo.SelectLang
                If Not rdc.Checked And Not rdvb.Checked Then
                    MsgBox("Select Class Language!", MsgBoxStyle.Information, "Prompt")
                End If

            Case ErrorNo.NoPrimary
                For Each row As DataGridViewRow In dgdetails.Rows
                    If row.IsNewRow = False Then
                        If row.Cells(6).Value.ToString = "YES" Then
                            HasError = False
                        End If
                    End If
                Next
        End Select

    End Function


    ''' <summary>
    ''' Not check
    ''' </summary>
    ''' <returns>return boolean</returns>
    ''' <remarks></remarks>
    Private Function notcheck() As Boolean
        For Each row As DataGridViewRow In dgdetails.Rows
            If row.IsNewRow = False Then
                If row.Cells(0).Value = 0 Then
                    notcheck = True
                End If
            End If
        Next
    End Function



    ''' <summary>
    ''' CheckEnable
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CheckEnable()
        If dgdetails.RowCount = 0 Then
            btncheck.Enabled = False
        Else
            btncheck.Enabled = True
        End If
        btncheck.Text = "&Check All"
    End Sub

    Private Sub setConnectionString()
        If ckctrusted.Checked Then
            clscon.ConnectionString = "Server=" & cboserver.Text & ";Database=" & cbodatabase.Text & ";Trusted_Connection=True;"
        Else
            clscon.ConnectionString = "Server=" & cboserver.Text & ";Database=" & cbodatabase.Text & ";User ID=" & txtusername.Text & ";Password=" & txtpassword.Text & ";Trusted_Connection=False;"
        End If
    End Sub

    Public Sub FillTable(ByVal cboCombo As ComboBox, ByVal dbname As Object)

        Try
            cboCombo.Items.Clear()

            Call setConnectionString()

            Using sqlConn As New SqlConnection(clscon.ConnectionString)
                sqlConn.Open()

                Dim str_sql = "select name FROM sys.sysobjects WHERE     (xtype = 'U')  ORDER BY xtype, name"
                Dim da As New SqlDataAdapter(str_sql, sqlConn)
                Dim tblDatabases As DataTable = New DataTable("name")
                da.Fill(tblDatabases)

                For Each row As DataRow In tblDatabases.Rows
                    Dim strDatabaseName As [String] = row("name").ToString()
                    cboCombo.Items.Add(strDatabaseName)
                Next
                sqlConn.Close()
            End Using

        Catch ex As Exception
            MsgBox("Error : FillCombobox " & ex.Message, MsgBoxStyle.Critical)
        Finally
            cboCombo.Text = String.Empty
        End Try

    End Sub

    Sub Filldatabase(ByVal srcComboBox As ComboBox, ByVal srcServerName As String)
        Try
            srcComboBox.Items.Clear()

            If cboserver.Text = "" Then

            Else
                Cursor = Cursors.WaitCursor
                If ckctrusted.Checked Then
                    clscon.ConnectionString = "Server=" & cboserver.Text & ";Database=master;Trusted_Connection=True;"
                Else
                    clscon.ConnectionString = "Server=" & cboserver.Text & ";Database=master;User ID=" & txtusername.Text & ";Password=" & txtpassword.Text & ";Trusted_Connection=False;"
                End If

                Using sqlConn As New SqlConnection(clscon.ConnectionString)
                    sqlConn.Open()
                    Dim tblDatabases As DataTable = sqlConn.GetSchema("Databases")
                    sqlConn.Close()

                    For Each row As DataRow In tblDatabases.Rows
                        Dim strDatabaseName As [String] = row("database_name").ToString()
                        srcComboBox.Items.Add(strDatabaseName)
                    Next
                End Using
            End If
        Catch ex As Exception
            MsgBox("Error : Please contact your network administrator." & vbCrLf & ex.Message, MsgBoxStyle.Exclamation, "Error")
        Finally
            Cursor = Cursors.Default

        End Try

    End Sub

    Private Sub FillGridview(ByVal paramstr As String)
        Try

            Dim strSQL As String


            strSQL = "SELECT     c.column_id, c.name AS 'Column Name', t.name AS 'Data type', isnull((derivedtbl_1.CHARACTER_MAXIMUM_LENGTH),0) as max_length, " & _
                     "CASE WHEN c.is_nullable = 0 THEN 'NO' ELSE 'YES' END AS is_null, CASE WHEN ISNULL(i.is_primary_key, 0) = 1 THEN 'YES' ELSE 'NO' END AS 'Primary Key' " & _
                     "FROM         sys.columns AS c INNER JOIN " & _
                     "sys.types AS t ON c.system_type_id = t.system_type_id INNER JOIN " & _
                     "(SELECT     COLUMN_NAME, DATA_TYPE, CHARACTER_MAXIMUM_LENGTH, IS_NULLABLE, TABLE_NAME " & _
                     "FROM INFORMATION_SCHEMA.COLUMNS " & _
                     "WHERE      (TABLE_NAME = '" & paramstr & "')) AS derivedtbl_1 ON c.name = derivedtbl_1.COLUMN_NAME LEFT OUTER JOIN " & _
                     "sys.index_columns AS ic ON ic.object_id = c.object_id AND ic.column_id = c.column_id LEFT OUTER JOIN " & _
                     "sys.indexes AS i ON ic.object_id = i.object_id AND ic.index_id = i.index_id " & _
                     "WHERE     (c.object_id = OBJECT_ID('" & paramstr & "')) AND (t.name <> N'sysname') " & _
                     "ORDER BY c.column_id"

            clscon.FillDataGrid(dgdetails, strSQL, 1, 6)



        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Exclamation, "Prompt")
        End Try

    End Sub

    Private Sub FillServer()
        Try


            Cursor = Cursors.WaitCursor

            Dim SqlEnumerator As System.Data.Sql.SqlDataSourceEnumerator
            SqlEnumerator = System.Data.Sql.SqlDataSourceEnumerator.Instance
            Dim dTable As System.Data.DataTable
            dTable = SqlEnumerator.GetDataSources()

            Me.cboserver.Items.Clear()

            For Each row As DataRow In dTable.Rows
                Dim serverName As String = row(0).ToString
                Dim instanceName As String = row(1).ToString

                If String.IsNullOrEmpty(instanceName) Then
                    Me.cboserver.Items.Add(serverName)
                Else
                    Me.cboserver.Items.Add(serverName & "\" & instanceName)
                End If

            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Fill Server Error")
        Finally
            Cursor = Cursors.Default
        End Try

    End Sub

    Private Function GetLen(ByVal datatype As String, Optional ByVal length As Integer = 0) As String
        Select Case datatype

            Case "nvarchar", "varchar", "nchar"
                If length = -1 Then
                    GetLen = datatype & "(Max)"
                Else
                    GetLen = datatype & "(" & length & ")"
                End If

            Case "datetime", "int", "float", "date", "bit", "ntext", "text"
                GetLen = datatype

        End Select
    End Function

    ''' <summary>
    ''' Get Primary Key
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GetPrimary() As String
        Dim primary As String = String.Empty

        For Each row As DataGridViewRow In dgdetails.Rows
            If row.IsNewRow = False Then
                If row.Cells(0).Value = 1 Then
                    If row.Cells(6).Value = "YES" Then
                        primary += "AND (" & row.Cells(2).Value & "=@" & row.Cells(2).Value & ") "
                    End If
                End If
            End If
        Next
        If primary <> String.Empty Then
            primary = "WHERE " & primary.Remove(0, 3)
        End If

        GetPrimary = primary
    End Function

    ''' <summary>
    ''' Update Query
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GetUpdate_Query() As String

        Dim strupdate As String

        strupdate += vbTab & vbTab & vbTab & "UPDATE " & cbotable.Text & vbNewLine
        strupdate += vbTab & vbTab & vbTab & vbTab & "SET "

        For Each row As DataGridViewRow In dgdetails.Rows
            If row.IsNewRow = False Then
                If row.Cells(0).Value = 1 Then
                    If row.Cells(6).Value = "NO" Then
                        strupdate += row.Cells(2).Value & "=@" & row.Cells(2).Value & "," & vbNewLine & vbTab & vbTab & vbTab & vbTab
                    End If
                End If
            End If
        Next
        strupdate = strupdate.Remove(strupdate.Length - 7)
        strupdate += vbNewLine & vbTab & vbTab & vbTab & GetPrimary()
        GetUpdate_Query = strupdate & vbNewLine & vbNewLine
    End Function

    ''' <summary>
    ''' Insert Query
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GetInsert_Query() As String
        Dim strinsert As String


        strinsert += "INSERT INTO  " & cbotable.Text & vbNewLine & vbTab & vbTab & vbTab & vbTab & vbTab & "( "
        For Each row As DataGridViewRow In dgdetails.Rows
            If row.IsNewRow = False Then
                If row.Cells(0).Value = 1 Then

                    strinsert += row.Cells(2).Value & " ," & vbNewLine & vbTab & vbTab & vbTab & vbTab & vbTab

                End If
            End If
        Next
        strinsert = strinsert.Remove(strinsert.Length - 9)
        strinsert += " )" & vbNewLine & vbTab & vbTab & vbTab & vbTab
        strinsert += "VALUES ("

        For Each row As DataGridViewRow In dgdetails.Rows
            If row.IsNewRow = False Then
                If row.Cells(0).Value = 1 Then

                    strinsert += "@" & row.Cells(2).Value & " ," & vbNewLine & vbTab & vbTab & vbTab & vbTab & vbTab

                End If
            End If
        Next

        strinsert = strinsert.Remove(strinsert.Length - 9)
        strinsert += " )"
        GetInsert_Query = strinsert
    End Function

    ''' <summary>
    ''' Get Parameter
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GetVar_Query() As String
        Try
            Dim var As String
            For Each row As DataGridViewRow In dgdetails.Rows
                If row.IsNewRow = False Then
                    If row.Cells(0).Value = 1 Then
                        var += vbTab & vbTab & "@" & row.Cells(2).Value & vbTab & vbTab & GetLen(row.Cells(3).Value, row.Cells(4).Value) & "," & vbNewLine
                    End If
                End If
            Next
            If Not var = Nothing Or Not var = "" Then
                var = var.Remove(var.Length - 3)
            End If

            GetVar_Query = var & vbNewLine
        Catch ex As Exception
            MsgBox("Error: GetVar_Query " & ex.Message, MsgBoxStyle.Exclamation, "Prompt")
        End Try

    End Function

    ''' <summary>
    ''' Select Query
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GetSelect_Query() As String
        Dim sel As String

        sel += vbTab & "SELECT " & vbNewLine
        For Each row As DataGridViewRow In dgdetails.Rows
            If row.IsNewRow = False Then
                If row.Cells(0).Value = 1 Then
                    sel += vbTab & vbTab & row.Cells(2).Value & "," & vbNewLine
                End If
            End If
        Next
        sel = sel.Remove(sel.Length - 3) & vbNewLine
        sel += vbTab & "FROM " & cbotable.Text

        GetSelect_Query = sel
    End Function

    ''' <summary>
    ''' Delete Query
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GetDelete_Query() As String
        Dim strdel As String

        strdel += vbTab & vbTab & "DELETE FROM " & cbotable.Text & vbNewLine

        If Not HasError(ErrorNo.NoCheck) Then
            strdel += vbTab & vbTab & "WHERE "
            For Each row As DataGridViewRow In dgdetails.Rows
                If row.IsNewRow = False Then
                    If row.Cells(0).Value = 1 Then
                        strdel += "( " & row.Cells(2).Value & "=@" & row.Cells(2).Value & " ) AND" & vbNewLine & vbTab & vbTab & vbTab
                    End If
                End If
            Next
        End If

        strdel = strdel.Remove(strdel.Length - 9)
        GetDelete_Query = strdel
    End Function

    ''' <summary>
    ''' Generate Query String
    ''' </summary>
    ''' <param name="opt"></param>
    ''' <remarks></remarks>
    Private Sub GenerateQuery(ByVal opt As optionQuery)
        strSQL = "-- =============================================" & vbNewLine
        strSQL += "-- Author:	    SQL Generator" & vbNewLine
        strSQL += "-- Description:	<Enter your description here>" & vbNewLine
        strSQL += "-- Date:     	" & Now.Date & vbNewLine
        strSQL += "-- More info:	contact gronel@ymail.com" & vbNewLine
        strSQL += "-- =============================================" & vbNewLine


        Select Case opt

            Case optionQuery.append_update '' append_update
          
                strSQL += "Create Procedure sp_save_" & cbotable.Text & vbNewLine & vbNewLine

                strSQL += GetVar_Query()

                strSQL += "AS" & vbNewLine
                strSQL += vbTab & vbTab & "IF EXISTS ( SELECT 'TRUE' FROM " & cbotable.Text & " WHERE " & GetPrimary() & ")" & vbNewLine
                strSQL += vbTab & vbTab & vbTab & "BEGIN" & vbNewLine & vbNewLine
                strSQL += GetUpdate_Query()
                strSQL += vbTab & vbTab & vbTab & "END" & vbNewLine
                strSQL += vbTab & vbTab & "ELSE" & vbNewLine
                strSQL += vbTab & vbTab & vbTab & "BEGIN" & vbNewLine & vbNewLine
                strSQL += vbTab & vbTab & vbTab & vbTab & GetInsert_Query() & vbNewLine
                strSQL += vbTab & vbTab & vbTab & "END" & vbNewLine & vbNewLine

            Case optionQuery.select_Query  '' Select Query

                strSQL += "Create Procedure sp_select_" & cbotable.Text & vbNewLine & vbNewLine & vbNewLine
                strSQL += "AS" & vbNewLine
                strSQL += GetSelect_Query()


            Case optionQuery.insert_Query  '' Insert Query

                strSQL += "Create Procedure sp_APPEND_" & cbotable.Text & vbNewLine & vbNewLine
                strSQL += GetVar_Query()
                strSQL += "AS" & vbNewLine
                strSQL += vbTab & vbTab & vbTab & vbTab & GetInsert_Query() & vbNewLine
            Case optionQuery.update_Query  '' Update Query
                strSQL += "Create Procedure sp_UPDATE_" & cbotable.Text & vbNewLine & vbNewLine
                strSQL += GetVar_Query()
                strSQL += "AS" & vbNewLine
                strSQL += GetUpdate_Query() & vbNewLine


            Case optionQuery.Delete_Query  '' Delete Query
                strSQL += "Create Procedure sp_DELETE_" & cbotable.Text & vbNewLine & vbNewLine
                strSQL += GetVar_Query()
                strSQL += "AS" & vbNewLine & vbNewLine
                strSQL += GetDelete_Query() & vbNewLine

        End Select
        rmytxt.Text = strSQL
    End Sub

    ''' <summary>
    ''' Generate Option
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub GenerateOption()


        If rd1.Checked Then '' append_update
            If HasError(ErrorNo.NoCheck) Then MsgBox("Select Table Fields First!", MsgBoxStyle.Exclamation, "Prompt") : Exit Sub
            If HasError(ErrorNo.NoPrimary) Then MsgBox("Invalid to used this function the table is no primary key", MsgBoxStyle.Exclamation, "Prompt") : Exit Sub
            Call GenerateQuery(optionQuery.append_update)
        ElseIf rd2.Checked Then '' select
            If HasError(ErrorNo.NoCheck) Then MsgBox("Select Table Fields First!", MsgBoxStyle.Exclamation, "Prompt") : Exit Sub
            Call GenerateQuery(optionQuery.select_Query)
        ElseIf rd3.Checked Then '' insert
            If HasError(ErrorNo.NoCheck) Then MsgBox("Select Table Fields First!", MsgBoxStyle.Exclamation, "Prompt") : Exit Sub
            Call GenerateQuery(optionQuery.insert_Query)
        ElseIf rd4.Checked Then '' update
            If HasError(ErrorNo.NoCheck) Then MsgBox("Select Table Fields First!", MsgBoxStyle.Exclamation, "Prompt") : Exit Sub
            Call GenerateQuery(optionQuery.update_Query)
        ElseIf rd5.Checked Then '' DELETE
            Call GenerateQuery(optionQuery.Delete_Query)
        End If
    End Sub






#End Region

#Region "Generate Class and Method"

    ''' <summary>
    ''' convert sql type to language type
    ''' </summary>
    ''' <param name="lang">Language</param>
    ''' <param name="datatype">sql Datatype</param>
    ''' <returns>converted datatype</returns>
    ''' <remarks></remarks>
    Private Function ConType(ByVal lang As Language, ByVal datatype As String) As String

        Dim dtype As String


        Select Case lang

            Case Language.vb '' convert into vb datatype

                Select Case datatype ''get type
                    Case "float"
                        dtype = "Double"
                    Case "varchar", "nvarchar", "nchar", "ntext", "text"
                        dtype = "String"
                    Case "datetime"
                        dtype = "Date"
                    Case "int"
                        dtype = "Integer"
                    Case "bit"
                        dtype = "Boolean"
                    Case "decimal"
                        dtype = "Decimal"
                    Case "image"
                        dtype = "Byte"

                End Select


            Case Language.csharp  '' convert into c# datatype

                Select Case datatype '' get type
                    Case "float"
                        dtype = "double"
                    Case "varchar", "nvarchar", "nchar", "ntext", "text"
                        dtype = "string"
                    Case "datetime"
                        dtype = "DateTime"
                    Case "int"
                        dtype = "int"
                    Case "bit"
                        dtype = "Boolean"
                    Case "decimal"
                        dtype = "Decimal"
                    Case "image"
                        dtype = "Byte"
                End Select

        End Select

        ConType = dtype
    End Function

    ''' <summary>
    ''' Create private variable for class
    ''' Convert sql parameter into developer parameter
    ''' </summary>
    ''' <param name="lang">language name</param>
    ''' <param name="param">sql parameter</param>
    ''' <param name="datatype">sql datatype</param>
    ''' <returns>converted parameter</returns>
    ''' <remarks></remarks>
    Private Function LangDataType(ByVal lang As Language, ByVal param As String, ByVal datatype As String) As String

        Dim var As String

        Select Case lang

            Case Language.vb '' vb language
                Select Case datatype

                    Case "float"
                        var = "_" & param & " As " & "Double"
                    Case "varchar", "nvarchar", "nchar", "ntext", "text"
                        var = "_" & param & " As " & "String"
                    Case "datetime"
                        var = "_" & param & " As " & "Date"
                    Case "int"
                        var = "_" & param & " As " & "Integer"
                    Case "bit"
                        var = "_" & param & " As " & "Boolean"
                    Case "numeric"
                    Case "decimal"
                        var = "_" & param & " As " & "Decimal"
                    Case "image"
                        var = "_" & param & " As " & "Byte"

                End Select



            Case Language.csharp '' c# language

                var = ConType(lang, datatype) & "  _" & param & ";"

        End Select


        LangDataType = var

    End Function


    ''' <summary>
    ''' Get variable
    ''' </summary>
    ''' <param name="lang">language name</param>
    ''' <returns>variable</returns>
    ''' <remarks></remarks>
    Private Function GetVariable(ByVal lang As Language) As String

        Dim var As String

        Select Case lang

            Case Language.vb ''For vb language
                For Each row As DataGridViewRow In dgdetails.Rows
                    If row.IsNewRow = False Then
                        If row.Cells(0).Value = 1 Then
                            var += vbTab & "Private " & LangDataType(lang, row.Cells(2).Value, row.Cells(3).Value) & vbNewLine
                        End If
                    End If
                Next

            Case Language.csharp ''For csharp language
                For Each row As DataGridViewRow In dgdetails.Rows
                    If row.IsNewRow = False Then
                        If row.Cells(0).Value = 1 Then
                            var += vbTab & LangDataType(lang, row.Cells(2).Value, row.Cells(3).Value) & vbNewLine
                        End If
                    End If
                Next
        End Select


        GetVariable = var
    End Function

    ''' <summary>
    ''' Generate Property
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GenerateProperty(ByVal lang As Language) As String

        Dim prop As String

        Select Case lang

            Case Language.vb  ''vb language
                For Each row As DataGridViewRow In dgdetails.Rows
                    If row.IsNewRow = False Then
                        If row.Cells(0).Value = 1 Then
                            prop += vbNewLine & vbTab & "Public Property " & row.Cells(2).Value & "() As " & ConType(Language.vb, row.Cells(3).Value) & vbNewLine
                            prop += vbTab & vbTab & "Get" & vbNewLine
                            prop += vbTab & vbTab & vbTab & "Return _" & row.Cells(2).Value & vbNewLine
                            prop += vbTab & vbTab & "End Get" & vbNewLine
                            prop += vbTab & vbTab & "Set(ByVal value As " & ConType(Language.vb, row.Cells(3).Value) & ")" & vbNewLine
                            prop += vbTab & vbTab & vbTab & "_" & row.Cells(2).Value & "=value" & vbNewLine
                            prop += vbTab & vbTab & "End Set" & vbNewLine
                            prop += vbTab & "End Property" & vbNewLine
                        End If
                    End If
                Next

            Case Language.csharp '' c# language
                For Each row As DataGridViewRow In dgdetails.Rows
                    If row.IsNewRow = False Then
                        If row.Cells(0).Value = 1 Then
                            prop += vbNewLine & vbTab & "public " & ConType(lang, row.Cells(3).Value) & " " & row.Cells(2).Value & vbNewLine & vbTab
                            prop += "{" & vbNewLine & vbTab & vbTab
                            prop += "get{ return _" & row.Cells(2).Value & ";}" & vbNewLine & vbTab & vbTab
                            prop += "set{  _" & row.Cells(2).Value & "=value;}" & vbNewLine & vbTab
                            prop += "}" & vbNewLine & vbTab

                        End If
                    End If
                Next
        End Select

        GenerateProperty = prop

    End Function


    ''' <summary>
    ''' Generate Save code for development
    ''' </summary>
    ''' <param name="lang">language name</param>
    ''' <returns>Return Save code</returns>
    ''' <remarks></remarks>
    Private Function GenerateSave(ByVal lang As Language) As String
        Dim strsave As String

        ''case language
        Select Case lang
            '' case language is vb
            Case Language.vb
                strsave += "Public Function Save() As Boolean" & vbNewLine & vbTab & vbTab
                strsave += "Try" & vbNewLine & vbTab & vbTab
                strsave += "Dim con as new SqlConnection('ConnectionString')" & vbNewLine & vbTab & vbTab
                strsave += "Using cmd As New SqlCommand(""sp_save" & cbotable.Text & """,con)" & vbNewLine & vbTab & vbTab & vbTab
                strsave += "with cmd" & vbNewLine & vbTab & vbTab & vbTab & vbTab
                strsave += ".CommandType = CommandType.StoredProcedure" & vbNewLine & vbTab & vbTab & vbTab & vbTab

                For Each row As DataGridViewRow In dgdetails.Rows
                    If row.IsNewRow = False Then
                        If row.Cells(0).Value = 1 Then
                            strsave += ".Parameters.Add(New SqlParameter(""@" & row.Cells(2).Value & """, _" & row.Cells(2).Value & "))" & vbNewLine & vbTab & vbTab & vbTab & vbTab
                        End If
                    End If
                Next

                strsave += ".ExecuteNonQuery()" & vbNewLine & vbTab & vbTab & vbTab
                strsave += "End with" & vbNewLine & vbTab & vbTab
                strsave += "End Using" & vbNewLine & vbTab & vbTab
                strsave += "Catch ex As Exception" & vbNewLine & vbTab & vbTab
                strsave += "Throw ex" & vbNewLine & vbTab & vbTab
                strsave += "End Try" & vbNewLine & vbTab
                '' case language is csharp
            Case Language.csharp
                strsave += "public Boolean Save()" & vbNewLine & vbTab & "{" & vbNewLine & vbTab & vbTab
                strsave += "SqlConnection con=new SqlConnection(UrConnectionStringHere);" & vbNewLine & vbNewLine & vbTab & vbTab
                strsave += "try" & vbNewLine & vbTab & vbTab
                strsave += "{" & vbNewLine & vbTab & vbTab & vbTab
                strsave += "if (con.State == ConnectionState.Closed)" & vbNewLine & vbTab & vbTab & vbTab & "{" _
                & vbNewLine & vbTab & vbTab & vbTab & vbTab & "con.Open();" & vbNewLine & vbTab & vbTab & vbTab & "}" & vbNewLine & vbNewLine & vbTab & vbTab & vbTab
                strsave += "using (SqlCommand cmd=new SqlCommand(""sp_save_" & cbotable.Text & """,con))" & vbNewLine & vbTab & vbTab & vbTab & "{" _
                & vbNewLine & vbTab & vbTab & vbTab & vbTab & "cmd.CommandType = CommandType.StoredProcedure;"

                For Each row As DataGridViewRow In dgdetails.Rows
                    If row.IsNewRow = False Then
                        If row.Cells(0).Value = 1 Then
                            strsave += vbNewLine & vbTab & vbTab & vbTab & vbTab & "cmd.Parameters.Add(new SqlParameter(""@" & row.Cells(2).Value & """,_" & row.Cells(2).Value & "));"
                        End If
                    End If
                Next

                strsave += vbNewLine & vbTab & vbTab & vbTab & vbTab & "cmd.ExecuteNonQuery();"
                strsave += vbNewLine & vbTab & vbTab & vbTab & "}"
                strsave += vbNewLine & vbNewLine & vbTab & vbTab & vbTab & "return true;"
                strsave += vbNewLine & vbTab & vbTab & "}"
                strsave += vbNewLine & vbTab & vbTab & "catch (Exception ex)" & vbNewLine & vbTab & vbTab & "{ return false;" & vbNewLine & vbTab & vbTab & "}"
                strsave += vbNewLine & vbTab & vbTab & "finally" & vbNewLine & vbTab & vbTab & "{" & vbNewLine & vbTab & vbTab & vbTab & "con.Close();" & vbNewLine & vbTab & vbTab & "}" _
                & vbNewLine & vbTab & "}"
        End Select


        Return strsave
    End Function

    ''' <summary>
    ''' Generate Class
    ''' </summary>
    ''' <param name="lang">language name</param>
    ''' <remarks></remarks>
    Private Sub GenerateClass(ByVal lang As Language)

        Dim strclass As String=String.Empty

        Select Case lang

            Case Language.vb '' generate vb language

                strclass += "Public Class cls_" & cbotable.Text & vbNewLine & vbNewLine
                strclass += GetVariable(lang)
                strclass += GenerateProperty(lang) & vbNewLine & vbTab
                strclass += GenerateSave(Language.vb)
                strclass += "End Function"

            Case Language.csharp ''generate c# language

                strclass += "public class cls_" & cbotable.Text & vbNewLine & vbNewLine
                strclass += "{" & vbNewLine
                strclass += GetVariable(lang)
                '' strclass += GenerateProperty(lang)
                '' strclass += GenerateSave(Language.csharp) & vbNewLine
                strclass += "}"

        End Select

        rmytxt.Text = strclass

    End Sub


    Private Sub GenerateClassOption()
        If HasError(ErrorNo.NoCheck) Then MsgBox("Select Table Fields First!", MsgBoxStyle.Exclamation, "Prompt") : Exit Sub
        If rdvb.Checked Then
            Call GenerateClass(Language.vb) '' call generate class in vb
        ElseIf rdc.Checked Then
            Call GenerateClass(Language.csharp) '' call generate class in csharp
        End If

    End Sub


#End Region

#End Region


#Region "GUI"

    Private Sub frm_main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Version
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Call FillServer()
    End Sub

    Private Sub ckctrusted_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckctrusted.CheckedChanged
        If ckctrusted.Checked Then
            txtusername.Enabled = False
            txtpassword.Enabled = False
        Else
            txtusername.Enabled = True
            txtpassword.Enabled = True
        End If
    End Sub



    Private Sub rchtxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rmytxt.TextChanged
        lbllength.Text = "length:" & rmytxt.Text.Length.ToString
    End Sub


    Private Sub OpenNewWindowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenNewWindowToolStripMenuItem.Click
        With frm_rch
            .rchtxt.Text = Me.rmytxt.Text
            .lbllength.Text = "length:" & .rchtxt.Text.Length.ToString
            .Show()
            .Focus()
        End With
    End Sub


    Private Sub btnconnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconnect.Click
        Call Filldatabase(cbodatabase, cboserver.Text)
    End Sub

    Private Sub cbodatabase_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbodatabase.TextChanged
        Call FillTable(cbotable, cbodatabase.Text)
    End Sub

    Private Sub cbotable_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbotable.TextChanged
        Call FillGridview(cbotable.Text)
        Call CheckEnable()
    End Sub

    Private Sub btncheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncheck.Click
        If btncheck.Text = "&Check All" Then
            For Each row As DataGridViewRow In dgdetails.Rows
                If row.IsNewRow = False Then
                    row.Cells(0).Value = 1
                End If
            Next
            btncheck.Text = "&Uncheck All"

        ElseIf btncheck.Text = "&Uncheck All" Then
            For Each row As DataGridViewRow In dgdetails.Rows
                If row.IsNewRow = False Then
                    row.Cells(0).Value = 0
                End If
            Next
            btncheck.Text = "&Check All"
        End If



    End Sub


    Private Sub dgdetails_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgdetails.CellValueChanged
        If notcheck() Then
            btncheck.Text = "&Check All"
        Else
            btncheck.Text = "&Uncheck All"
        End If
    End Sub

    Private Sub dgdetails_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles dgdetails.RowsAdded
        lblCountSub.Text = clscon.CountGridRows(dgdetails)
    End Sub

    Private Sub dgdetails_RowsRemoved(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles dgdetails.RowsRemoved
        lblCountSub.Text = clscon.CountGridRows(dgdetails)
    End Sub

    Private Sub btnprocedure_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprocedure.Click
        Call GenerateOption()
    End Sub

    Private Sub btnclass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclass.Click
        Call GenerateClassOption()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        With frm_about
            .ShowDialog()
        End With
    End Sub

#End Region



End Class
