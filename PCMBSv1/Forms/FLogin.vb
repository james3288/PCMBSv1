﻿Public Class FLogin


    Private UIuserName, UIPassword As New class_placeholder

    Private Sub FLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim borderPanel As New class_pcmbs

        borderPanel.borderOnPanel(PHeader)

        'UI
        UIuserName.king_placeholder_textbox("username...", txtUserName, Nothing, PMain, My.Resources.id_card, False, "Custom1", "")
        UIPassword.king_placeholder_textbox("password...", txtPassword, Nothing, PMain, My.Resources.padlock, False, "Custom1", "")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        FMain.pcmbs.remove_link(Me)
        Me.Dispose()
    End Sub
End Class