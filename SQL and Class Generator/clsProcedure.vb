Imports System.Data
Imports System.Data.SqlClient
Public Class clsProcedure

    Public ConnectionString As String
    Private con As SqlConnection
    Public Sub OpenDB()
        con = New SqlConnection(ConnectionString)

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
    End Sub


    Public Sub FillDataGrid(ByVal dgView As DataGridView, ByVal strSQL As String, ByVal colStart As Integer, ByVal colEnd As Integer)

        Dim intRow As Integer
        Dim i As Integer
        Dim intCol As Integer

        OpenDB()

        Dim cmdCust As New SqlCommand

        dgView.Rows.Clear()
        cmdCust.Connection = con
        cmdCust.CommandText = strSQL
        Dim dr As SqlDataReader = cmdCust.ExecuteReader()


        While dr.Read()
            i = 0
            intRow = dgView.Rows.Add()
            For intCol = colStart To colEnd
                dgView.Item(intCol, intRow).Value = dr(i)
                i = i + 1
            Next
        End While
        dr.Close()
        con.Close()

    End Sub



    Public Function CountGridRows(ByVal dg As DataGridView) As Integer
        Try
            If dg.AllowUserToAddRows Then
                CountGridRows = dg.RowCount - 1
            Else
                CountGridRows = dg.RowCount
            End If
        Catch ex As Exception

        End Try
    End Function

    Public Property name() As String
        Get
            Return ConnectionString
        End Get
        Set(ByVal value As String)
            ConnectionString = value
        End Set
    End Property

End Class
