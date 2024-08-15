Public Class class_pcmbs

    Private cListOfLinkLabel As New List(Of LinkLabel)
    Private cFlowLayoutPanel As FlowLayoutPanel
    Private cCustomButton As Panel
    Private cPanel As Panel
    Private cCustomFunction As customFunctionDelegate


    Public Sub _addToPanel(Optional form As Form = Nothing, Optional panel As Panel = Nothing, Optional link As LinkLabel = Nothing)
        With form
            .TopLevel = False
            .FormBorderStyle = FormBorderStyle.None
            .Dock = DockStyle.Fill
            .Width = panel.Width
            .AutoSize = False
            .Anchor = AnchorStyles.Left Or AnchorStyles.Right
            panel.Controls.Add(form)
            .BringToFront()

            .Show()
        End With


    End Sub

    Public Sub _initialize_linkLabel(Optional form As Form = Nothing, Optional flowLayoutPanel As FlowLayoutPanel = Nothing)
        Dim link As New LinkLabel

        link.Text = form.Text.ToUpper()
        link.LinkBehavior = LinkBehavior.NeverUnderline
        link.LinkColor = Color.Orange
        link.AutoSize = True

        link.Font = New Font(link.Font.FontFamily, 8.0F, link.Font.Style)
        link.Height = flowLayoutPanel.Height
        link.TextAlign = ContentAlignment.MiddleCenter


        'ADD HANDLER
        AddHandler link.Click,
            Sub(sender As Object, e As EventArgs)
                link_clicked(sender, e, form)
            End Sub

        cListOfLinkLabel.Add(link)
        cFlowLayoutPanel = flowLayoutPanel

    End Sub

    Public Function check_form_if_exist_in_flowLayoutPanel(Optional form As Form = Nothing) As Boolean
        check_form_if_exist_in_flowLayoutPanel = False
        For Each link As LinkLabel In cListOfLinkLabel
            If link.Text.ToLower() = form.Text.ToLower() Then
                check_form_if_exist_in_flowLayoutPanel = True
                Exit For
            End If
        Next
    End Function

    Public Sub _addLinkToFlowLayoutPanel(Optional myFlowLayOutPanel As FlowLayoutPanel = Nothing)

        For Each link As LinkLabel In cListOfLinkLabel
            myFlowLayOutPanel.Controls.Add(link)
        Next
    End Sub

    Public Sub remove_link(Optional form As Form = Nothing)
        Dim n As Integer = 0
        Dim listoflabel As New List(Of LinkLabel)

        For Each link As LinkLabel In cListOfLinkLabel
            listoflabel.Add(link)
        Next


        For Each link As LinkLabel In listoflabel
            If form.Text.ToLower() = link.Text.ToLower() Then
                cListOfLinkLabel.Remove(link)
                refresh_links(link.Text.ToLower())
            End If
        Next
    End Sub

    Public Sub refresh_links(link As String)

        Dim c As New Control
        For Each ctr As Control In cFlowLayoutPanel.Controls
            If ctr.Text.ToLower() = link Then
                c = ctr
                Exit For
            End If
        Next

        cFlowLayoutPanel.Controls.Remove(c)
    End Sub

#Region "HANDLER"
    Private Sub link_clicked(sender As Object, e As EventArgs, Optional form As Form = Nothing)
        form.Visible = True
        form.BringToFront()
    End Sub

#End Region

#Region "DELEGATES"
    Public Delegate Function myFunctionDelegate()

#End Region

#Region "Message Form"
    Public Sub messageForm(Optional title As String = "", Optional status As String = "", Optional message As String = "", Optional fn As myFunctionDelegate = Nothing)
        Dim newMessage As New FMessageForm

        With newMessage
            .title = title
            .status = status
            .message = message
            .ShowDialog()
        End With
    End Sub
#End Region

#Region "Custom Button"

    Public Delegate Function customFunctionDelegate()


    Public Sub CustomButton(Optional panel As Panel = Nothing, Optional fn As customFunctionDelegate = Nothing)
        cCustomButton = panel
        cCustomFunction = fn

        AddHandler cCustomButton.MouseEnter, AddressOf customButtonMouseEnter
        AddHandler cCustomButton.MouseLeave, AddressOf customButtonMouseLeave
        AddHandler cCustomButton.Click, AddressOf customButtonMouseClick

        For Each ctr As Control In panel.Controls
            AddHandler ctr.MouseEnter, AddressOf customButtonMouseEnter
            AddHandler ctr.MouseLeave, AddressOf customButtonMouseLeave
            AddHandler ctr.Click, AddressOf customButtonMouseClick
        Next
    End Sub

    Private Sub customButtonMouseEnter(sender As Object, e As EventArgs)
        cCustomButton.BackgroundImage = My.Resources.box_bg_14
    End Sub

    Private Sub customButtonMouseLeave(sender As Object, e As EventArgs)
        cCustomButton.BackgroundImage = My.Resources.box_bg_12
    End Sub

    Private Sub customButtonMouseClick(sender As Object, e As EventArgs)
        cCustomFunction()
    End Sub

#End Region

#Region "BORDER ON PANEL"

    Private Sub border_panel(sender As Object, e As PaintEventArgs)
        ControlPaint.DrawBorder(e.Graphics, cPanel.ClientRectangle, Color.Black, ButtonBorderStyle.Solid)
    End Sub
    Public Sub borderOnPanel(Optional panel As Panel = Nothing)
        cPanel = panel

        AddHandler panel.Paint, AddressOf border_panel
    End Sub
#End Region

#Region "Custom Datagridview"

    Public Sub customDataGridviewCheckBox(Optional dgv As DataGridView = Nothing)

        Dim checkboxColumn As New DataGridViewCheckBoxColumn()
        checkboxColumn.HeaderText = "Select"
        checkboxColumn.Name = "CheckBoxColumn"
        dgv.Columns.Add(checkboxColumn)

    End Sub
    Public Sub customDatagridview(Optional dgv As DataGridView = Nothing, Optional hexColor As String = "#1B2838")

        ' Set some properties of the DataGridView
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv.RowTemplate.Height = 28
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv.MultiSelect = False
        dgv.RowHeadersVisible = False
        dgv.BackgroundColor = ColorTranslator.FromHtml(hexColor)

    End Sub

    Public Sub subcustomDatagridviewSettings(Optional changeType As String = "",
                                             Optional dgv As DataGridView = Nothing,
                                             Optional columIndex As Integer = 0,
                                             Optional width As Integer = 0,
                                             Optional headerText As String = "",
                                             Optional format As String = "",
                                             Optional defaultCellStyleBg As String = "#8d9da0",
                                             Optional defaultCellStyleForeColor As String = "#fff",
                                             Optional alternateRowDefaultStyleBg As String = "#B6C3C7",
                                             Optional alternateRowDefaultForeColor As String = "#000")

        Select Case changeType
            Case "headerText"
                dgv.Columns(columIndex).HeaderText = headerText
                dgv.Columns(columIndex).Width = width

                dgv.Columns(columIndex).DefaultCellStyle.Format = format ' Format date column

            Case "defaultCellStyle"

                dgv.DefaultCellStyle.BackColor = ColorTranslator.FromHtml(defaultCellStyleBg)
                dgv.DefaultCellStyle.ForeColor = ColorTranslator.FromHtml(defaultCellStyleForeColor)

            Case "alternateRowStyle"
                dgv.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml(alternateRowDefaultStyleBg)
                dgv.AlternatingRowsDefaultCellStyle.ForeColor = ColorTranslator.FromHtml(alternateRowDefaultForeColor)
        End Select



    End Sub

#End Region
End Class
