Public Class FUserAcess_Search

    Private UIRsSearch, UIDetails As New class_placeholder

#Region "MOVABLE VARIABLES"
    Dim IsFormBeingDragged As Boolean
    Dim drag As Boolean
    Dim MouseDownX As Integer
    Dim MouseDownY As Integer
#End Region

#Region "DROP SHADOW EFFECT"
    ' this is code is for dropshadow on form
    Protected Overrides ReadOnly Property CreateParams() As System.Windows.Forms.CreateParams
        Get
            Const DROPSHADOW = &H20000
            Dim cParam As CreateParams = MyBase.CreateParams
            cParam.ClassStyle = cParam.ClassStyle Or DROPSHADOW
            Return cParam
        End Get

    End Property
#End Region

#Region "MOVABLE FORM FUNCTIONS"
    Private Sub panelHeader_MouseDown(sender As Object, e As MouseEventArgs) Handles panelHeader.MouseDown
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub

    Private Sub panelHeader_MouseMove(sender As Object, e As MouseEventArgs) Handles panelHeader.MouseMove

        If IsFormBeingDragged Then
            Dim temp As Point = New Point()

            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = temp
            temp = Nothing
        End If
    End Sub

    Private Sub panelHeader_MouseUp(sender As Object, e As MouseEventArgs) Handles panelHeader.MouseUp
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Dispose()
    End Sub

    Private Sub FUserAcess_Search_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = ColorTranslator.FromHtml("#0C0F16")

        panelHeader.BackColor = ColorTranslator.FromHtml("#1A293A")
        btnSearch.BackColor = ColorTranslator.FromHtml("#326EBD")

        UIRsSearch.king_placeholder_textbox("Search Rs Here...", txtSearch, Nothing, Panel1, My.Resources.search1, False, "Custom1", "")
        UIDetails.king_placeholder_textbox("Search Details Here...", txtDetails, Nothing, Panel1, My.Resources.search1, False, "Custom1", "")
    End Sub
#End Region


End Class