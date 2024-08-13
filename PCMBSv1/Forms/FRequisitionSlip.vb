﻿Public Class FRequisitionSlip

    Private UIRsNo, UIDescription, UIcombobox, UIDate, UIMak As New class_placeholder

    Public Class RSField
        Public Property rs_id As String
        Public Property rs_no As String
        Public Property rs_date As DateTime
        Public Property description As String
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'filter empty textbox 

        If UIRsNo.blank_textbox() Then
            Exit Sub
        ElseIf UIcombobox.blank_combobox() Then
            Exit Sub
        End If


        'get the data from textbox or combobox 
        MsgBox(UIRsNo.tbox.Text)
        MsgBox(UIcombobox.cBox.Text)
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
        UIRsNo.king_placeholder_textbox("RS No...", TextBox1, Nothing, panel_left, My.Resources.received1, False, "White", "")
        UIDescription.king_placeholder_textbox("Description...", TextBox2, l1, panel_left, My.Resources.received1, False, "White", "")
        UIcombobox.king_placeholder_combobox("combobox here...", ComboBox1, Nothing, panel_left, My.Resources.received1, "White", "")
        UIDate.king_placeholder_datepicker("date picker...", DateTimePicker1, panel_left, My.Resources.received1, "White")


        'DUMMY DATA RANI
        Dim userProfiles As New List(Of RSField)() From {
            New RSField With {.rs_id = "001", .rs_no = "RS123", .rs_date = Date.Now, .description = "Description for RS123"},
            New RSField With {.rs_id = "002", .rs_no = "RS124", .rs_date = Date.Now, .description = "Description for RS124"},
            New RSField With {.rs_id = "003", .rs_no = "RS125", .rs_date = Date.Now, .description = "Description for RS125"},
            New RSField With {.rs_id = "004", .rs_no = "RS126", .rs_date = Date.Now, .description = "Description for RS126"},
            New RSField With {.rs_id = "002", .rs_no = "RS124", .rs_date = Date.Now, .description = "Description for RS124"},
            New RSField With {.rs_id = "003", .rs_no = "RS125", .rs_date = Date.Now, .description = "Description for RS125"},
            New RSField With {.rs_id = "004", .rs_no = "RS126", .rs_date = Date.Now, .description = "Description for RS126"},
            New RSField With {.rs_id = "002", .rs_no = "RS124", .rs_date = Date.Now, .description = "Description for RS124"},
            New RSField With {.rs_id = "003", .rs_no = "RS125", .rs_date = Date.Now, .description = "Description for RS125"},
            New RSField With {.rs_id = "004", .rs_no = "RS126", .rs_date = Date.Now, .description = "Description for RS126"},
            New RSField With {.rs_id = "002", .rs_no = "RS124", .rs_date = Date.Now, .description = "Description for RS124"},
            New RSField With {.rs_id = "003", .rs_no = "RS125", .rs_date = Date.Now, .description = "Description for RS125"},
            New RSField With {.rs_id = "004", .rs_no = "RS126", .rs_date = Date.Now, .description = "Description for RS126"}
       }

        ' Bind the list to the DataGridView
        DataGridView1.DataSource = userProfiles

        ' Set some properties of the DataGridView
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.MultiSelect = False
        DataGridView1.RowHeadersVisible = False

        ' Alternating row style
        DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray

        ' Column settings
        DataGridView1.Columns(0).HeaderText = "RS ID"
        DataGridView1.Columns(0).Width = 50

        DataGridView1.Columns(1).HeaderText = "RS No"
        DataGridView1.Columns(2).HeaderText = "RS Date"
        DataGridView1.Columns(2).DefaultCellStyle.Format = "yyyy-MM-dd" ' Format date column
        DataGridView1.Columns(3).HeaderText = "Description"


    End Sub

    Private Sub FRequisitionSlip_Shown(sender As Object, e As EventArgs) Handles Me.Shown

    End Sub
End Class