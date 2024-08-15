Imports System.Data
Imports System.Data.SqlClient
Module InsertQueryvb
    Private pcmbs As New class_pcmbs
    Function add_data(ByVal cmdtxt As String) As Boolean
        Dim sql As New SQLcon
        Dim cmd As New SqlCommand
        sql.connection_supply.Open()
        Try
            cmd.Connection = sql.connection_supply
            cmd.CommandText = cmdtxt
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
        sql.connection_supply.Close()
    End Function


    Public Function InsertProject(ByVal Projectcode As String,
                                  ByVal ProjectName As String,
                                  ByVal ContractId As String,
                                  ByVal ContractClassification As String,
                                  ByVal ProjectLocation As String) As Boolean
        Dim sql1 As New SQLcon
        Try
            sql1.connection_pcm.Open()
            Dim sqlcomm As New SqlCommand()

            sqlcomm.Connection = sql1.connection_pcm
            sqlcomm.CommandText = "pcm_insert_stored"
            sqlcomm.CommandType = CommandType.StoredProcedure
            sqlcomm.Parameters.AddWithValue("@n", 1)
            sqlcomm.Parameters.AddWithValue("@projectCode", Projectcode)
            sqlcomm.Parameters.AddWithValue("@projectName", ProjectName)
            sqlcomm.Parameters.AddWithValue("@contractId", ContractId)
            sqlcomm.Parameters.AddWithValue("@contractClass", ContractClassification)
            sqlcomm.Parameters.AddWithValue("@projectLocation", ProjectLocation)
            sqlcomm.ExecuteScalar()
            pcmbs.messageForm("Administrator", "info", "Succesfully save")

            PFunctionMoveProjectToView()
            PFunction_ClearTextboxes(FProjectCode.projectCode, FProjectCode.projectName, FProjectCode.contractId, FProjectCode.contractClassification, FProjectCode.projectLocation)
            Return True
        Catch ex As Exception
            pcmbs.messageForm("Administrator", "error", $"Failed to Add Data {ex.Message}")

            Return False
        Finally
            sql1.connection_pcm.Close()
        End Try
    End Function

End Module
