Public Class FMain

    Private small_left_panel As Integer = 160
    Private parameter As String
    Public pcmbs As New class_pcmbs

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        'For Each ctrl In Me.FlowLayoutPanel1.Controls
        '    If ctrl.text = FRequisitionSlip.Text Then
        '        MsgBox($"{FRequisitionSlip.Name } has already open!")
        '        Exit Sub
        '    End If
        'Next
        Dim exist As Boolean = pcmbs.check_form_if_exist_in_flowLayoutPanel(FRequisitionSlip)

        If exist = True Then
            'MsgBox($"{FRequisitionSlip.Name } has already open!")
            Dim newMessage As New FMessageForm

            With newMessage
                .title = "Administrator Message"
                .status = "warning"
                .message = $"{FRequisitionSlip.Text  } has already open!"
                .ShowDialog()
            End With

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





    Private Sub pMain_Resize(sender As Object, e As EventArgs) Handles pMain.Resize
        FRequisitionSlip.Width = pMain.Width
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

    Public Function paramFunction()
        Return 2
    End Function
End Class
