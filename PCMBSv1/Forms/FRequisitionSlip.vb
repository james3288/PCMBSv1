Public Class FRequisitionSlip

    Private UIRsNo, UIDescription, UIcombobox, UIDate, UIMak As New class_placeholder
    Private pcmbs As New class_pcmbs

    Public Class RSField
        Public Property rs_id As String
        Public Property rs_no As String
        Public Property description As String
        Public Property rs_date As DateTime

    End Class

    Private Class ComboboxField
        Public Property id As Integer
        Public Property combobox_desc As String
    End Class
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        FMain.pcmbs.remove_link(Me)

        Me.Dispose()

    End Sub

    Private Sub panel_left_Paint(sender As Object, e As PaintEventArgs) Handles panel_left.Paint
        ControlPaint.DrawBorder(e.Graphics, panel_left.ClientRectangle, Color.Black, ButtonBorderStyle.Solid)
    End Sub

    Private Sub SearchByRSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchByRSToolStripMenuItem.Click
        FRS_Search.ShowDialog()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Save()
        MsgBox("Successfully Saved")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'filter empty textbox 

        If UIRsNo.blank_textbox() Then
            Exit Sub
        ElseIf UIcombobox.blank_combobox() Then
            Exit Sub
        End If


        pcmbs.messageForm("Administrator", "question", "Are you sure you want to save this data?")


    End Sub

    Private Sub panel_right_Paint(sender As Object, e As PaintEventArgs) Handles panel_right.Paint
        ControlPaint.DrawBorder(e.Graphics, panel_right.ClientRectangle, Color.Black, ButtonBorderStyle.Solid)
    End Sub

    Private Sub FRequisitionSlip_Load(sender As Object, e As EventArgs) Handles Me.Load

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
        UIRsNo.king_placeholder_textbox("RS No...", TextBox1, Nothing, panel_left, My.Resources.received1, False, "Custom1", "")
        UIDescription.king_placeholder_textbox("Description...", TextBox2, l1, panel_left, My.Resources.received1, False, "Custom1", "")
        UIcombobox.king_placeholder_combobox("combobox here...", ComboBox1, Nothing, panel_left, My.Resources.received1, "Custom1", "")
        UIDate.king_placeholder_datepicker("date picker...", DateTimePicker1, panel_left, My.Resources.received1, "Custom1")


        'DUMMY DATA RANI
        Dim userProfiles As New List(Of RSField)() From {
            New RSField With {.rs_id = "001", .rs_no = "RS123", .description = "Description for RS123", .rs_date = Date.Now},
            New RSField With {.rs_id = "002", .rs_no = "RS124", .description = "Description for RS124", .rs_date = Date.Now},
            New RSField With {.rs_id = "003", .rs_no = "RS125", .description = "Description for RS125", .rs_date = Date.Now},
            New RSField With {.rs_id = "004", .rs_no = "RS126", .description = "Description for RS126", .rs_date = Date.Now},
            New RSField With {.rs_id = "002", .rs_no = "RS124", .description = "Description for RS124", .rs_date = Date.Now},
            New RSField With {.rs_id = "003", .rs_no = "RS125", .description = "Description for RS125", .rs_date = Date.Now},
            New RSField With {.rs_id = "004", .rs_no = "RS126", .description = "Description for RS126", .rs_date = Date.Now},
            New RSField With {.rs_id = "002", .rs_no = "RS124", .description = "Description for RS124", .rs_date = Date.Now},
            New RSField With {.rs_id = "003", .rs_no = "RS125", .description = "Description for RS125", .rs_date = Date.Now},
            New RSField With {.rs_id = "004", .rs_no = "RS126", .description = "Description for RS126", .rs_date = Date.Now},
            New RSField With {.rs_id = "002", .rs_no = "RS124", .description = "Description for RS124", .rs_date = Date.Now},
            New RSField With {.rs_id = "003", .rs_no = "RS125", .description = "Description for RS125", .rs_date = Date.Now},
            New RSField With {.rs_id = "004", .rs_no = "RS126", .description = "Description for RS126", .rs_date = Date.Now}
       }

        ' Bind the list to the DataGridView
        DataGridView1.DataSource = userProfiles

        ' Set some properties of the DataGridView
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.MultiSelect = False
        DataGridView1.RowHeadersVisible = False
        DataGridView1.BackgroundColor = ColorTranslator.FromHtml("#1B2838")


        ' Column settings
        DataGridView1.Columns(0).HeaderText = "RS ID"
        DataGridView1.Columns(0).Width = 50

        DataGridView1.Columns(1).HeaderText = "RS No"
        DataGridView1.Columns(2).HeaderText = "Description"

        DataGridView1.Columns(3).DefaultCellStyle.Format = "yyyy-MM-dd" ' Format date column
        DataGridView1.Columns(3).HeaderText = "RS Date"

        DataGridView1.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#8d9da0")
        DataGridView1.DefaultCellStyle.ForeColor = Color.Black

        'Alternating row style
        DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#B6C3C7")
        DataGridView1.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black


        Button1.BackColor = ColorTranslator.FromHtml("#1C2837")
    End Sub


End Class