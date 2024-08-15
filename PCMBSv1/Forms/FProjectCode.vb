Imports System.Data
Imports System.Data.SqlClient
Public Class FProjectCode
    Private UIprojectCode, UIprojectName, UIcontractID, UIcontractClass, UIprojectLocation As New class_placeholder
    Private pcmbs As New class_pcmbs
    Public userProfiles As New List(Of PROJECT_CODE_FIELD)()



    Private Class ComboboxField
        Public Property id As Integer
        Public Property combobox_desc As String
    End Class

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If InsertProject(projectCode.Text, projectName.Text, contractId.Text, contractClassification.Text, projectLocation.Text) Then

        End If


        'Dim exist As Boolean = True

        'If exist = True Then
        '    Dim newMessage As New FMessageForm

        '    With newMessage
        '        .title = "Administrator Message"
        '        .status = "warning"
        '        .myFunction(, AddressOf display_ex)
        '        .message = $"{FQuantityTakeOff.Text  } has already open!"
        '        .ShowDialog()
        '    End With
        '    Exit Sub
        'End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Public Class PROJECT_CODE_FIELD
        'Public Property project_id As String
        Public Property project_code As String
        Public Property project_name As String
        Public Property contract_id As String
        Public Property contract_classification As String
        Public Property project_location As String

    End Class
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        FMain.pcmbs.remove_link(Me)
        Me.Dispose()
    End Sub

    Private Sub FProjectCode_Load(sender As Object, e As EventArgs) Handles Me.Load
        DataGridView1.Rows.Clear()
        'SAMPLE FOR LIST INSIDE TEXTBOX 

        'DUMMY ONLY
        Dim l As New List(Of ComboboxField)
        l.Add(New ComboboxField With {.id = 1, .combobox_desc = "dummy1"})
        l.Add(New ComboboxField With {.id = 2, .combobox_desc = "dummy2"})
        l.Add(New ComboboxField With {.id = 3, .combobox_desc = "dummy3"})



        'CONVERT TO LIST OF STRING
        Dim l1 As New List(Of String)
        For Each row As ComboboxField In l
            l1.Add(row.combobox_desc)
        Next



        'UI FOR TEXTBOX/COMBOBOX/DATETIMEPICKER

        UIprojectCode.king_placeholder_textbox("Project Code...", projectCode, Nothing, panel_left, My.Resources.received1, False, "Custom1", "")
        UIprojectName.king_placeholder_textbox("Project Name...", projectName, Nothing, panel_left, My.Resources.received1, False, "Custom1", "")
        UIcontractID.king_placeholder_textbox("Contract ID...", contractId, Nothing, panel_left, My.Resources.received1, False, "Custom1", "")
        UIcontractClass.king_placeholder_textbox("Contract Classification...", contractClassification, Nothing, panel_left, My.Resources.received1, False, "Custom1", "")
        UIprojectLocation.king_placeholder_textbox("Project Location...", projectLocation, Nothing, panel_left, My.Resources.received1, False, "Custom1", "")
        'UIDate.king_placeholder_datepicker("date picker...", DateTimePicker1, panel_left, My.Resources.received1, "Custom1")


        'DUMMY DATA RANI
        'userProfiles.Add(New PROJECT_CODE_FIELD With {.project_code = "AAAA", .project_name = "BBBBBB", .contract_id = "CCCCCC", .contract_classification = "DDDDD", .project_location = "EEEEE"})

        ' Bind the list to the DataGridView
        'DataGridView1.DataSource = userProfiles


        ' Set some properties of the DataGridView
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.MultiSelect = False
        DataGridView1.RowHeadersVisible = False
        DataGridView1.BackgroundColor = ColorTranslator.FromHtml("#1B2838")


        ' Column settings
        'DataGridView1.Columns(0).HeaderText = "PROJECT CODE"
        ''DataGridView1.Columns(0).Width = 50

        'DataGridView1.Columns(1).HeaderText = "PROJECT NAME"
        'DataGridView1.Columns(2).HeaderText = "CONTRACT ID"

        ''DataGridView1.Columns(3).DefaultCellStyle.Format = "yyyy-MM-dd" ' Format date column
        'DataGridView1.Columns(3).HeaderText = "CONTRACT CLASSIFICATION"
        'DataGridView1.Columns(4).HeaderText = "PROJECT LOCATION"

        DataGridView1.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#8d9da0")
        DataGridView1.DefaultCellStyle.ForeColor = Color.Black

        'Alternating row style
        DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#B6C3C7")
        DataGridView1.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black


        Button1.BackColor = ColorTranslator.FromHtml("#1C2837")

        viewProjectCodes()
    End Sub



    'Public Sub selects()
    '    Dim sql1 As New SQLcon
    '    Dim sqlcommand As New SqlCommand
    '    Dim dr As SqlDataReader
    '    DataGridView1.Rows.Clear()

    '    Dim a(5) As String
    '    Try
    '        sql1.connection_pcm.Open()
    '        sqlcommand.Connection = sql1.connection_pcm
    '        sqlcommand.CommandText = "pcm_select_stored"
    '        sqlcommand.CommandType = CommandType.StoredProcedure
    '        sqlcommand.Parameters.AddWithValue("@n", 1)
    '        sqlcommand.CommandTimeout = 0
    '        dr = sqlcommand.ExecuteReader
    '        While dr.Read
    '            a(0) = dr.Item(1).ToString
    '            a(1) = dr.Item(2).ToString
    '            a(2) = dr.Item(3).ToString
    '            a(3) = dr.Item(4).ToString
    '            a(4) = dr.Item(5).ToString
    '            DataGridView1.Rows.Add(a)
    '            'FProjectCode.userProfiles.Add(New FProjectCode.PROJECT_CODE_FIELD With {.project_code = dr.Item(1).ToString,
    '            '                 .project_name = dr.Item(2).ToString,
    '            '                 .contract_id = dr.Item(3).ToString,
    '            '                 .contract_classification = dr.Item(4).ToString,
    '            '                 .project_location = dr.Item(5).ToString})
    '            'FProjectCode.DataGridView1.DataSource = FProjectCode.userProfiles
    '        End While

    '        dr.Close()
    '    Catch ex As Exception
    '        pcmbs.messageForm("Administrator", "error", $"Failed to Add Data {ex.Message}")
    '    Finally
    '        sql1.connection_pcm.Close()
    '    End Try
    'End Sub
End Class