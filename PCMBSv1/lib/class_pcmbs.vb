﻿Public Class class_pcmbs

    Private cListOfLinkLabel As New List(Of LinkLabel)
    Private cFlowLayoutPanel As FlowLayoutPanel

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

        Dim c As Control
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
        form.BringToFront()
    End Sub

#End Region
End Class
