Public Class FUserAccess

    Private Class Access
        Property control_name As String
        Property controls As Object
        Property type As String
    End Class

    Private Sub FUserAccess_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'BORDER PANEL
        Dim borderPanel As New class_pcmbs
        Dim borderForm As New class_pcmbs

        borderPanel.borderOnPanel(PHeader)
        borderForm.borderOnPanel(PMain)


        Dim l As New List(Of Access)
        For Each ctr As Object In cListOfControl
            Dim a As New Access
            With a

                Dim cut() As String = ctr.GetType.ToString.Split(".")
                a.control_name = ctr.name
                a.controls = ctr
                a.type = cut(3)
            End With

            l.Add(a)
        Next

        DataGridView1.DataSource = l


        ' Set some properties of the DataGridView
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.MultiSelect = False
        DataGridView1.RowHeadersVisible = False
        DataGridView1.BackgroundColor = ColorTranslator.FromHtml("#1B2838")

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        FMain.pcmbs.remove_link(Me)
        Me.Dispose()
    End Sub
End Class