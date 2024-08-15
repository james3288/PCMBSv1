Public Class FMessageForm
#Region "MOVABLE VARIABLES"
    Dim IsFormBeingDragged As Boolean
    Dim drag As Boolean
    Dim MouseDownX As Integer
    Dim MouseDownY As Integer
#End Region

#Region "PUBLIC VARIABLES"
    Public status As String
    Public message As String
    Public title As String
    Public cFn As myFunctionDelegate
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
#End Region

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Dispose()

    End Sub

    Private Sub FMessageForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If status = "warning" Then
            picStatus.Image = My.Resources.warning
            lblMessage.ForeColor = Color.Orange
            lblTitle.ForeColor = Color.Orange

            btnOk.BackColor = Color.Orange
            btnOk.Text = "OK"
            btnCancel.Text = "Cancel"

        ElseIf status = "error" Then
            picStatus.Image = My.Resources._error
            lblMessage.ForeColor = ColorTranslator.FromHtml("#A7504D")
            lblTitle.ForeColor = ColorTranslator.FromHtml("#A7504D")
            btnOk.BackColor = ColorTranslator.FromHtml("#641217")
            btnOk.Text = "OK"
            btnCancel.Text = "Cancel"

        ElseIf status = "info" Then

            picStatus.Image = My.Resources.info
            lblMessage.ForeColor = Color.LightBlue
            lblTitle.ForeColor = Color.LightBlue
            btnOk.BackColor = Color.LightBlue
            btnOk.Text = "OK"
            btnCancel.Text = "Cancel"

        ElseIf status = "question" Then

            picStatus.Image = My.Resources.question
            lblMessage.ForeColor = Color.Yellow
            lblTitle.ForeColor = Color.Yellow
            btnOk.BackColor = Color.Yellow
            btnOk.ForeColor = Color.Black
            btnOk.Text = "Yes"
            btnCancel.Text = "No"

        End If

        lblMessage.Text = message
        lblTitle.Text = title

        lblStatus.Text = status.ToUpper()

    End Sub

    Private Sub FMessageForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        ElseIf e.KeyCode = Keys.Space Then
            btnOk.PerformClick()
        End If
    End Sub

#Region "DELEGATES"

    Public Delegate Function myFunctionDelegate()

#End Region

    Public Sub myFunction(Optional param As String = "", Optional fn As myFunctionDelegate = Nothing)
        cFn = fn
    End Sub


    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If Not cFn Is Nothing Then
            Dim n As Integer = cFn()
            MsgBox(n)
        Else
            Me.Dispose()
        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()

    End Sub

End Class