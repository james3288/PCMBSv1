Imports System.Drawing.Drawing2D
Public Class FMain

    Private small_left_panel As Integer = 160
    Private parameter As String
    Public pcmbs As New class_pcmbs

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click

        Dim exist As Boolean = pcmbs.check_form_if_exist_in_flowLayoutPanel(FRequisitionSlip)

        If exist = True Then

            Dim message As String = $"{FRequisitionSlip.Text  } has already open!"
            pcmbs.messageForm("Administrator Message", "question", message)

            Exit Sub
        End If

        pcmbs._addToPanel(FRequisitionSlip, pMain)
        pcmbs._initialize_linkLabel(FRequisitionSlip, FlowLayoutPanel1)
        pcmbs._addLinkToFlowLayoutPanel(FlowLayoutPanel1)

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles leftPanel.Paint
        ControlPaint.DrawBorder(e.Graphics, leftPanel.ClientRectangle, Color.Black, ButtonBorderStyle.Solid)
    End Sub

    Private Sub pMain_Paint(sender As Object, e As PaintEventArgs) Handles pMain.Paint
        ControlPaint.DrawBorder(e.Graphics, pMain.ClientRectangle, Color.Black, ButtonBorderStyle.Solid)
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint
        ControlPaint.DrawBorder(e.Graphics, Panel3.ClientRectangle, Color.Black, ButtonBorderStyle.Solid)
    End Sub
    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Dim exist As Boolean = pcmbs.check_form_if_exist_in_flowLayoutPanel(FQuantityTakeOff)

        If exist = True Then
            Dim newMessage As New FMessageForm

            With newMessage
                .title = "Administrator Message"
                .status = "warning"
                .myFunction(, AddressOf paramFunction)
                .message = $"{FQuantityTakeOff.Text  } has already open!"
                .ShowDialog()
            End With
            Exit Sub
        End If

        pcmbs._addToPanel(FQuantityTakeOff, pMain)
        pcmbs._initialize_linkLabel(FQuantityTakeOff, FlowLayoutPanel1)
        pcmbs._addLinkToFlowLayoutPanel(FlowLayoutPanel1)

    End Sub



    Private Sub FMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'change fore color

        'event handler for custom button panel
        Dim customButton1, customButton2 As New class_pcmbs

        customButton1.CustomButton(Panel5, AddressOf test1)
        customButton2.CustomButton(Panel6, AddressOf test2)



        'add controls
        For Each ctr As ToolStripButton In ToolStrip1.Items
            cListOfControl.Add(ctr)
        Next

        cListOfControl.Add(llblHome)
        cListOfControl.Add(llblLogin)
        cListOfControl.Add(llblMaintenance)
        cListOfControl.Add(llblUserAccess)

    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblHome.LinkClicked
        For Each ctr In pMain.Controls
            If TypeOf ctr Is Form Then
                ctr.hide()
            End If
        Next
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblLogin.LinkClicked

        Dim exist As Boolean = pcmbs.check_form_if_exist_in_flowLayoutPanel(FLogin)

        If exist = True Then

            Dim message As String = $"{FLogin.Text  } has already open!"
            pcmbs.messageForm("Administrator Message", "question", message)

            Exit Sub
        End If

        pcmbs._addToPanel(FLogin, pMain)
        pcmbs._initialize_linkLabel(FLogin, FlowLayoutPanel1)
        pcmbs._addLinkToFlowLayoutPanel(FlowLayoutPanel1)
    End Sub

    Private Sub LinkLabel8_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblUserAccess.LinkClicked

        Dim exist As Boolean = pcmbs.check_form_if_exist_in_flowLayoutPanel(FUserAccess)

        If exist = True Then

            Dim message As String = $"{FUserAccess.Text  } has already open!"
            pcmbs.messageForm("Administrator Message", "question", message)

            Exit Sub
        End If

        pcmbs._addToPanel(FUserAccess, pMain)
        pcmbs._initialize_linkLabel(FUserAccess, FlowLayoutPanel1)
        pcmbs._addLinkToFlowLayoutPanel(FlowLayoutPanel1)
    End Sub

    '#Region "Main Button 1"
    '    Private Sub Panel5_MouseEnter(sender As Object, e As EventArgs) Handles Panel5.MouseEnter,
    '        LinkLabel6.MouseEnter, LinkLabel4.MouseEnter, PictureBox5.MouseEnter, PictureBox6.MouseEnter

    '        Panel5.BackgroundImage = My.Resources.box_bg_14

    '    End Sub

    '    Private Sub Panel5_MouseLeave(sender As Object, e As EventArgs) Handles Panel5.MouseLeave, LinkLabel6.MouseLeave,
    '        LinkLabel4.MouseLeave, LinkLabel5.MouseLeave

    '        LinkLabel6.BackColor = Color.Transparent
    '        Panel5.BackgroundImage = My.Resources.box_bg_12

    '    End Sub

    '#End Region

    '#Region "Main Button 2"
    '    Private Sub Panel6_MouseEnter(sender As Object, e As EventArgs) Handles Panel6.MouseEnter,
    '        LinkLabel6.MouseEnter, LinkLabel4.MouseEnter, PictureBox5.MouseEnter

    '        Panel5.BackgroundImage = My.Resources.box_bg_14

    '    End Sub

    '    Private Sub Panel6_MouseLeave(sender As Object, e As EventArgs) Handles Panel6.MouseLeave, LinkLabel5.MouseLeave,
    '        LinkLabel7.MouseLeave, LinkLabel5.MouseLeave

    '        LinkLabel6.BackColor = Color.Transparent
    '        Panel5.BackgroundImage = My.Resources.box_bg_12

    '    End Sub

    '#End Region
End Class


