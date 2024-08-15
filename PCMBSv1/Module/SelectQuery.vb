Imports System.Data
Imports System.Data.SqlClient
Module SelectQuery

    Private pcmbs As New class_pcmbs
    'Public userProfiles As New List(Of PROJECT_CODE_FIELD)()
    'Public Class PROJECT_CODE_FIELD
    '    'Public Property project_id As String
    '    Public Property project_code As String
    '    Public Property project_name As String
    '    Public Property contract_id As String
    '    Public Property contract_classification As String
    '    Public Property project_location As String

    'End Class

    Public Function viewProjectCodes()
        FProjectCode.DataGridView1.Rows.Clear()
        Dim sqlcommand As New SqlCommand
        Dim sql1 As New SQLcon
        Dim dr As SqlDataReader
        Dim a(5) As String

        Try
            sql1.connection_pcm.Open()
            sqlcommand.Connection = sql1.connection_pcm
            sqlcommand.CommandText = "pcm_select_stored"
            sqlcommand.CommandType = CommandType.StoredProcedure
            sqlcommand.Parameters.AddWithValue("@n", 1)
            sqlcommand.CommandTimeout = 0
            dr = sqlcommand.ExecuteReader
            While dr.Read
                a(0) = dr.Item(1).ToString
                a(1) = dr.Item(2).ToString
                a(2) = dr.Item(3).ToString
                a(3) = dr.Item(4).ToString
                a(4) = dr.Item(5).ToString
                FProjectCode.DataGridView1.Rows.Add(a)
                'FProjectCode.userProfiles.Add(New FProjectCode.PROJECT_CODE_FIELD With {.project_code = dr.Item(1).ToString,
                '                 .project_name = dr.Item(2).ToString,
                '                 .contract_id = dr.Item(3).ToString,
                '                 .contract_classification = dr.Item(4).ToString,
                '                 .project_location = dr.Item(5).ToString})
                'FProjectCode.DataGridView1.DataSource = FProjectCode.userProfiles
            End While


        Catch ex As Exception
            pcmbs.messageForm("Administrator", "error", $"Failed to Add Data {ex.Message}")
            'dr.Close()
        Finally
            sql1.connection_pcm.Close()
        End Try
    End Function

End Module
