﻿Public Class class_placeholder
    Private cPlaceholder As String
    Private t As New TextBox
    Private cCombobox As New ComboBox
    Private cAutocomplete As Object
    Private cIcon As System.Drawing.Bitmap
    Private cThemeColor As String = "White"
    Private cDtp As New DateTimePicker
    Private cBg_label As New Label
    Private cToolTipMessage As String

    'GET SET
    Public ReadOnly Property tbox As TextBox
        Get
            Return t
        End Get

    End Property

    Public ReadOnly Property cBox As ComboBox
        Get
            Return cCombobox
        End Get

    End Property

    Public ReadOnly Property placeHolder As String
        Get
            Return cPlaceholder
        End Get
    End Property
    Private Sub txt_TextChanged(sender As Object, e As EventArgs)
        Dim tt As TextBox = sender

        If tt.Text = "" Then
            tt.ForeColor = Color.Gray
        Else
            tt.ForeColor = set_theme_color(1)
        End If
    End Sub

    Private Sub cmb_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim cmb As ComboBox = sender

        If cmb.Text = "" Then
            cmb.ForeColor = Color.Gray
        Else
            cmb.ForeColor = set_theme_color(1)
        End If
    End Sub

    Public Sub king_placeholder_textbox(caption As String, txt As TextBox, Optional autocomplete As List(Of String) = Nothing, Optional form As Object = Nothing, Optional icon As System.Drawing.Bitmap = Nothing, Optional numbersonly As Boolean = False, Optional theme_color As String = "White", Optional toolTipMsg As String = "")

        Dim tt As TextBox
        Dim panel As New Panel
        Dim forms As New Form
        Dim groupbox As New GroupBox


        cThemeColor = theme_color
        cToolTipMessage = toolTipMsg

        If TypeOf form Is Panel Then
            panel = form
            tt = _initialize_textbox(caption, autocomplete, txt.Location, txt, panel, icon, numbersonly)
            AddHandler tt.TextChanged, AddressOf txt_TextChanged


        ElseIf TypeOf form Is Form Then
            forms = form
            tt = _initialize_textbox(caption, autocomplete, txt.Location, txt, forms, icon)
            AddHandler tt.TextChanged, AddressOf txt_TextChanged

        ElseIf TypeOf form Is GroupBox Then
            groupbox = form
            tt = _initialize_textbox(caption, autocomplete, txt.Location, txt, groupbox, icon, numbersonly)
            AddHandler tt.TextChanged, AddressOf txt_TextChanged

        End If

    End Sub

    Public Sub king_placeholder_combobox(caption As String, combobox As ComboBox, Optional autocomplete As List(Of String) = Nothing, Optional form As Object = Nothing, Optional icon As System.Drawing.Bitmap = Nothing, Optional theme_color As String = "White", Optional toolTipMsg As String = "")

        Dim cmb As ComboBox
        Dim panel As New Panel
        Dim forms As New Form
        Dim groupbox As New GroupBox
        cThemeColor = theme_color

        cToolTipMessage = toolTipMsg

        If TypeOf form Is Panel Then
            panel = form
            cmb = _initialize_combobox(caption, autocomplete, combobox.Location, combobox, panel, icon)
            AddHandler cmb.SelectedIndexChanged, AddressOf cmb_SelectedIndexChanged

        ElseIf TypeOf form Is Form Then
            forms = form
            cmb = _initialize_combobox(caption, autocomplete, combobox.Location, combobox, forms, icon)
            AddHandler cmb.SelectedIndexChanged, AddressOf cmb_SelectedIndexChanged

        ElseIf TypeOf form Is GroupBox Then
            groupbox = form
            cmb = _initialize_combobox(caption, autocomplete, combobox.Location, combobox, groupbox, icon)
            AddHandler cmb.SelectedIndexChanged, AddressOf cmb_SelectedIndexChanged

        End If

    End Sub

    Public Sub king_placeholder_datepicker(caption As String, dtp As DateTimePicker, Optional form As Object = Nothing, Optional icon As System.Drawing.Bitmap = Nothing, Optional theme_color As String = "White")

        Dim dtpicker As DateTimePicker
        Dim panel As New Panel
        Dim forms As New Form
        cThemeColor = theme_color

        If TypeOf form Is Panel Then
            panel = form
            dtpicker = _initialize_datepicker(caption, Nothing, dtp.Location, dtp, panel, icon)
        ElseIf TypeOf form Is Form Then
            forms = form
            dtpicker = _initialize_datepicker(caption, Nothing, dtp.Location, dtp, forms, icon)
        End If

    End Sub

    Public Function _initialize_textbox(placeholder As String, Optional autocomplete As Object = Nothing, Optional loc As Drawing.Point = Nothing, Optional txt As TextBox = Nothing, Optional form As Object = Nothing, Optional icon As System.Drawing.Bitmap = Nothing, Optional numbersonly As Boolean = False)

        t = txt
        t.Location = loc
        cPlaceholder = placeholder
        t.Text = cPlaceholder
        cAutocomplete = autocomplete
        t.BorderStyle = BorderStyle.None
        t.Font = New Font("Century Gothic", 10, FontStyle.Regular)
        cIcon = icon

        'THEME COLOR
        t.BackColor = set_theme_color(0)
        t.ForeColor = Color.White 'set_theme_color(1)


        'AUTOCOMPLETE
        If autocomplete Is Nothing Then
        Else
            set_autocomplete()
        End If

        'TEXTBOX LOCATION
        If loc = Nothing Then
        Else
            t.Location = loc
        End If

        'ADD DESIGN
        If TypeOf form Is Panel Then
            Dim panel As New Panel
            panel = form

            Dim label1 As New Label
            label1 = textbox_design()

            panel.Controls.Add(label1)
            t.BringToFront()

        ElseIf TypeOf form Is GroupBox Then
            Dim panel As New GroupBox
            panel = form

            Dim label1 As New Label
            label1 = textbox_design()

            panel.Controls.Add(label1)
            t.BringToFront()
        End If

        AddHandler t.GotFocus, AddressOf gotfocus
        AddHandler t.Leave, AddressOf leave

        'this function is for set textbox input numbers only | default value: False
        set_numbers_only(numbersonly)

        'AddHandler t.KeyPress, AddressOf textbox_KeyPress

        'Add ToolTip
        Dim toolTip1 As New ToolTip()

        toolTip1.AutoPopDelay = 5000
        toolTip1.InitialDelay = 500
        toolTip1.ReshowDelay = 500

        toolTip1.ShowAlways = True
        toolTip1.SetToolTip(t, cToolTipMessage)

        Return t
    End Function

    Public Function _initialize_combobox(placeholder As String, Optional autocomplete As Object = Nothing, Optional loc As Drawing.Point = Nothing, Optional combobox As ComboBox = Nothing, Optional form As Object = Nothing, Optional icon As System.Drawing.Bitmap = Nothing)

        cCombobox = combobox
        With cCombobox
            .Location = loc
            cPlaceholder = placeholder
            .Text = cPlaceholder
            cAutocomplete = autocomplete

            .Font = New Font("Century Gothic", 10, FontStyle.Regular)
            cIcon = icon


            'COMBOBOX LOCATION
            If loc = Nothing Then
            Else
                .Location = loc
            End If

            'THEME COLOR
            .BackColor = set_theme_color(0)
            .ForeColor = set_theme_color(1)

            'ADD DESIGN
            If TypeOf form Is Panel Then
                Dim panel As New Panel
                panel = form
                panel.Controls.Add(combobox_design())
            ElseIf TypeOf form Is GroupBox Then
                Dim panel As New GroupBox
                panel = form
                panel.Controls.Add(combobox_design())
            Else

            End If


            AddHandler .GotFocus, AddressOf cmb_gotfocus
            AddHandler .Leave, AddressOf cmb_leave


        End With

        Dim toolTip1 As New ToolTip()
        toolTip1.AutoPopDelay = 5000
        toolTip1.InitialDelay = 500
        toolTip1.ReshowDelay = 500

        toolTip1.ShowAlways = True
        toolTip1.SetToolTip(cCombobox, cToolTipMessage)

        Return cCombobox
    End Function

    Public Function _initialize_datepicker(placeholder As String, Optional autocomplete As Object = Nothing, Optional loc As Drawing.Point = Nothing, Optional dtp As DateTimePicker = Nothing, Optional form As Object = Nothing, Optional icon As System.Drawing.Bitmap = Nothing)

        cDtp = dtp

        With cDtp
            .Location = loc
            .Font = New Font("Century Gothic", 10, FontStyle.Regular)
            cIcon = icon


            'DATETIMEPICKER LOCATION
            If loc = Nothing Then
            Else
                .Location = loc
            End If

            'THEME COLOR
            .BackColor = set_theme_color(0)
            .ForeColor = set_theme_color(1)

            'ADD DESIGN
            If TypeOf form Is Panel Then
                Dim panel As New Panel
                panel = form

                'Dim combobox1 As New ComboBox
                'combobox1 = combobox_design()
                cBg_label = datetimepicker_design()
                panel.Controls.Add(cBg_label)
            Else

            End If


            AddHandler .GotFocus, AddressOf cmb_gotfocus
            AddHandler .Leave, AddressOf cmb_leave
        End With

        Return cDtp
    End Function

    Public Function textbox_design()

        Dim label As New Label

        label.Name = "label_" & t.Name
        label.Text = ""
        label.Size = New Size(266, 30)
        label.BorderStyle = BorderStyle.FixedSingle
        label.Location = New Point(t.Location.X - 35, t.Location.Y - 5)
        label.Image = cIcon
        label.ImageAlign = ContentAlignment.MiddleLeft
        label.Width = t.Width + 38
        label.BackColor = set_theme_color(0)

        Return label
    End Function

    Public Function datetimepicker_design()

        Dim label As New Label

        label.Name = "label_" & cDtp.Name
        label.Text = ""
        label.Size = New Size(266, 30)
        label.BorderStyle = BorderStyle.FixedSingle
        label.Location = New Point(cDtp.Location.X - 35, cDtp.Location.Y - 3)
        label.Image = cIcon
        label.ImageAlign = ContentAlignment.MiddleLeft
        label.Width = cDtp.Width + 38
        label.BackColor = set_theme_color(0)
        Return label

    End Function

    Private Function set_theme_color(n As Integer) As Color
        If n = 0 Then
            'for backcolor 
            Select Case cThemeColor
                Case "Gray"
                    set_theme_color = Color.Gray
                Case "White"
                    set_theme_color = Color.White
                Case "Black"
                    set_theme_color = Color.Black
                Case "Orange"
                    set_theme_color = Color.Orange
                Case "Green"
                    set_theme_color = Color.Green
                Case "Yellow"
                    set_theme_color = Color.Yellow
                Case "Purple"
                    set_theme_color = Color.Purple
                Case "Custom1"
                    set_theme_color = ColorTranslator.FromHtml("#1C2837")
            End Select
        End If

        If n = 1 Then
            'for forecolor
            Select Case cThemeColor
                Case "White", "Orange", "Yellow"
                    set_theme_color = Color.Gray
                Case "Black", "Green", "Gray", "Purple"
                    set_theme_color = Color.White
                Case "Custom1"
                    set_theme_color = ColorTranslator.FromHtml("#E9E7E9")
            End Select
        End If

        If n = 3 Then
            'for placeholder color 
            Select Case cThemeColor
                Case "Gray", "Black"
                    set_theme_color = Color.LightGray
                Case "White"
                    set_theme_color = Color.Gray
                Case "Orange"
                    set_theme_color = Color.Yellow
                Case "Green"
                    set_theme_color = Color.LightYellow
                Case "Yellow"
                    set_theme_color = Color.Red
                Case "Purple"
                    set_theme_color = Color.LightBlue
                Case "Custom1"
                    set_theme_color = ColorTranslator.FromHtml("#E9E7E9")
            End Select
        End If

    End Function

    Public Function combobox_design()

        Dim label As New Label

        label.Name = "label_" & cCombobox.Name
        label.Text = ""
        label.Size = New Size(266, 30)
        label.BorderStyle = BorderStyle.FixedSingle
        label.Location = New Point(cCombobox.Location.X - 35, cCombobox.Location.Y - 3)
        label.Image = cIcon
        label.ImageAlign = ContentAlignment.MiddleLeft
        label.Width = cCombobox.Width + 38
        label.BackColor = set_theme_color(0)
        Return label

    End Function
    Private Sub set_autocomplete()
        Dim searchlist As New AutoCompleteStringCollection

        Dim cListOfData = cAutocomplete
        For Each row In cListOfData
            searchlist.Add(row)
        Next

        t.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        t.AutoCompleteSource = AutoCompleteSource.CustomSource
        t.AutoCompleteCustomSource = searchlist
    End Sub
    Private Sub gotfocus()
        If t.Text = cPlaceholder Then
            t.Clear()
            t.ForeColor = set_theme_color(1)

        End If
    End Sub
    Private Sub cmb_gotfocus()
        If cCombobox.Text = cPlaceholder Then
            cCombobox.Text = ""
            cCombobox.ForeColor = set_theme_color(1)
        End If
    End Sub

    Private Sub leave()
        If t.Text = "" Then
            t.Text = cPlaceholder
            t.ForeColor = set_theme_color(3)

        End If
    End Sub

    Private Sub cmb_leave()
        If cCombobox.Text = "" Then
            cCombobox.Text = cPlaceholder
            cCombobox.ForeColor = set_theme_color(3)

        End If
    End Sub
    Public Function blank_textbox() As Boolean
        If t.Text.ToUpper = cPlaceholder.ToUpper Or t.Text = "" Then
            blank_textbox = True

            Dim newMessage As New FMessageForm
            With newMessage
                .title = "PCMBS Administrator Message:"
                .message = $"textbox '{cPlaceholder }' must not be blank!"
                .status = "error"
                .ShowDialog()
            End With

            'MessageBox.Show("textbox '" & cPlaceholder & "' must not be blank...", "SUPPLY INFO:", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            t.Focus()
        End If

        Return blank_textbox
    End Function
    Public Function blank_combobox() As Boolean
        If cCombobox.Text.ToUpper = cPlaceholder.ToUpper Or cCombobox.Text = "" Then
            blank_combobox = True
            Dim newMessage As New FMessageForm
            With newMessage
                .title = "PCMBS Administrator Message:"
                .message = $"combobox '{cPlaceholder }' must not be blank!"
                .status = "error"
                .ShowDialog()
            End With
            cCombobox.Focus()
        End If

        Return blank_combobox
    End Function
    Public Sub set_numbers_only(trigger As Boolean)
        If trigger = True Then
            AddHandler t.KeyPress, AddressOf textbox_KeyPress
        ElseIf trigger = False Then
            RemoveHandler t.KeyPress, AddressOf textbox_KeyPress
        End If
    End Sub
    Private Sub textbox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        ' Allow only numbers, backspace and decimal point
        If (Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not e.KeyChar = ControlChars.Back) Then
            e.Handled = True
        End If
    End Sub

    Public Function ifBlankTexbox() As Boolean
        If t.Text.ToUpper = cPlaceholder.ToUpper Then
            Return True
        End If
    End Function
    Public Function ifBlankCombobox() As Boolean
        If cCombobox.Text.ToUpper = cPlaceholder.ToUpper Then
            Return True
        End If
    End Function


End Class
