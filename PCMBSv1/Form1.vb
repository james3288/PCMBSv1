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

    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub Panel5_MouseEnter(sender As Object, e As EventArgs) Handles Panel5.MouseEnter, Panel6.MouseEnter, LinkLabel6.MouseEnter, LinkLabel4.MouseEnter
        Panel5.BackgroundImage = My.Resources.box_bg_14

    End Sub

    Private Sub Panel5_MouseLeave(sender As Object, e As EventArgs) Handles Panel5.MouseLeave, Panel6.MouseLeave, LinkLabel6.MouseLeave, LinkLabel4.MouseLeave
        Panel5.BackgroundImage = My.Resources.box_bg_12

    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked

    End Sub
End Class


