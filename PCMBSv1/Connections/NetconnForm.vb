﻿Public Class NetconnForm
    Dim iniFile, iniFile1, iniFile2, iniFile3 As String
    Public boolean_not_proceed As Boolean
    Private UIcombo, UIipServer, UIdatabaseName, UIserverUser, UIpassword As New class_placeholder

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private pcmbs As New class_pcmbs

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        boolean_not_proceed = False
        'Dim filter As New FilterError

        If boolean_not_proceed = False Then
            If cmbsource.Text = "SUPPLY" Then
                Dim thisfile As String = Application.StartupPath & "\syscon.ini"

                If FileIO.FileSystem.FileExists(thisfile) Then ' if exist
                    MessageBox.Show("This source already configured...", "SUPPLY INFO:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Else
                    save(1)
                End If

            ElseIf cmbsource.Text = "EUS" Then
                Dim thisfile As String = Application.StartupPath & "\syscon1.ini"

                If FileIO.FileSystem.FileExists(thisfile) Then ' if exist
                    MessageBox.Show("This source already configured...", "SUPPLY INFO:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Else
                    save(2)
                End If

            ElseIf cmbsource.Text = "BIOMETRIC" Then
                Dim thisfile As String = Application.StartupPath & "\syscon2.ini"

                If FileIO.FileSystem.FileExists(thisfile) Then ' if exist
                    MessageBox.Show("This source already configured...", "SUPPLY INFO:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Else
                    save(3)
                End If
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        boolean_not_proceed = False
        'Dim filter As New FilterError

        If boolean_not_proceed = False Then
            If cmbsource.Text = "SUPPLY" Then
                Dim thisfile As String = Application.StartupPath & "\syscon.ini"

                If FileIO.FileSystem.FileExists(thisfile) Then ' if exist
                    MessageBox.Show("This source already configured...", "SUPPLY INFO:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Else
                    save(1)

                End If


            ElseIf cmbsource.Text = "EUS" Then
                Dim thisfile As String = Application.StartupPath & "\syscon1.ini"

                If FileIO.FileSystem.FileExists(thisfile) Then ' if exist
                    MessageBox.Show("This source already configured...", "SUPPLY INFO:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Else
                    save(2)

                End If

            ElseIf cmbsource.Text = "HRMS" Then
                Dim thisfile As String = Application.StartupPath & "\syscon2.ini"

                If FileIO.FileSystem.FileExists(thisfile) Then ' if exist
                    MessageBox.Show("This source already configured...", "SUPPLY INFO:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Else
                    save(3)

                End If

            ElseIf cmbsource.Text = "PCM" Then
                Dim thisfile As String = Application.StartupPath & "\syscon3.ini"

                If FileIO.FileSystem.FileExists(thisfile) Then ' if exist
                    MessageBox.Show("This source already configured...", "SUPPLY INFO:", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Else
                    save(4)

                End If

            End If
        End If
    End Sub

    Private Sub NetconnForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UIcombo.king_placeholder_combobox("Select Database Name...", cmbsource, Nothing, Panel2, My.Resources.info, "White", "")
        UIipServer.king_placeholder_textbox("Input Server IP...", txtServer, Nothing, Panel2, My.Resources.server2, False, "White", "")
        UIdatabaseName.king_placeholder_textbox("Input Database Name...", txtDatabaseName, Nothing, Panel2, My.Resources.info, False, "White", "")
        UIserverUser.king_placeholder_textbox("Input Server UserName...", txtUsername, Nothing, Panel2, My.Resources.info, False, "White", "")
        UIpassword.king_placeholder_textbox("Input Server Password...", txtPassword, Nothing, Panel2, My.Resources.info, False, "White", "")
    End Sub

    Public Sub save(ByVal n As Integer)
        Dim Settings As String
        Dim settings1 As String
        Dim settings2 As String
        Dim settings3 As String

        Try

            If n = 1 Then
                iniFile = Application.StartupPath & "\syscon.ini"

                Settings = txtServer.Text & ";" & txtDatabaseName.Text & ";" & txtUsername.Text & ";" & txtPassword.Text

                FileIO.FileSystem.WriteAllText(iniFile, Settings, True)

                FMain.Show()

            ElseIf n = 2 Then
                iniFile1 = Application.StartupPath & "\syscon1.ini"
                settings1 = txtServer.Text & ";" & txtDatabaseName.Text & ";" & txtUsername.Text & ";" & txtPassword.Text

                FileIO.FileSystem.WriteAllText(iniFile1, settings1, True)

                FMain.Show()

            ElseIf n = 3 Then
                iniFile2 = Application.StartupPath & "\syscon2.ini"
                settings2 = txtServer.Text & ";" & txtDatabaseName.Text & ";" & txtUsername.Text & ";" & txtPassword.Text

                FileIO.FileSystem.WriteAllText(iniFile2, settings2, True)

                FMain.Show()
            ElseIf n = 4 Then
                iniFile3 = Application.StartupPath & "\syscon3.ini"
                settings3 = txtServer.Text & ";" & txtDatabaseName.Text & ";" & txtUsername.Text & ";" & txtPassword.Text

                FileIO.FileSystem.WriteAllText(iniFile3, settings3, True)

                FMain.Show()
            End If

        Catch ex As Exception
            MessageBox.Show("ERROR MESSAGE: " & vbCrLf & vbCrLf & ex.StackTrace() & vbCrLf & ex.Message & vbCrLf & vbCrLf, "EUS INFO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        End
    End Sub
End Class