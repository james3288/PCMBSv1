Module PublicFunctions
    'Public Class PROJECT_CODE_FIELD
    '    'Public Property project_id As String
    '    Public Property project_code As String
    '    Public Property project_name As String
    '    Public Property contract_id As String
    '    Public Property contract_classification As String
    '    Public Property project_location As String

    'End Class
    Public Function display_ex()
        Return 2
    End Function


    Public Sub PFunction_ClearTextboxes(ParamArray textboxes() As TextBox)
        For Each txt As TextBox In textboxes
            txt.Clear()
        Next
    End Sub



    Public Sub PFunctionMoveProjectToView()
        Dim newProject As New FProjectCode.PROJECT_CODE_FIELD With {
        .project_code = FProjectCode.projectCode.Text,
        .project_name = FProjectCode.projectName.Text,
        .contract_id = FProjectCode.contractId.Text,
        .contract_classification = FProjectCode.contractClassification.Text,
        .project_location = FProjectCode.projectLocation.Text
    }

        FProjectCode.userProfiles.Add(newProject)

        FProjectCode.DataGridView1.DataSource = Nothing
        FProjectCode.DataGridView1.DataSource = FProjectCode.userProfiles
    End Sub




End Module
