Imports PCMBSv1.Public_Types


Public Class FUserAccess


    Private Sub FUserAccess_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim pcmbs As New class_pcmbs

        ' Set some properties of the DataGridView
        pcmbs.customDatagridview(DataGridView1)
        pcmbs.customDatagridview(DataGridView2)

        'BORDER PANEL
        Dim borderPanel As New class_pcmbs
        Dim borderForm As New class_pcmbs

        borderPanel.borderOnPanel(PHeader)
        borderForm.borderOnPanel(PMain)


#Region "LIST OF CONTROL TO BE ACCESS"
        Dim l As New List(Of ControlAccess)
        For Each ctr As Object In cListOfControl
            Dim a As New ControlAccess

            With a

                a.control_name = ctr.name
                a.controls = ctr.text.ToString.ToUpper()
                Dim cut() As String = ctr.GetType.ToString.Split(".")
                a.type = cut(3)

            End With

            l.Add(a)

        Next

        DataGridView1.DataSource = l
#End Region

#Region "LIST OF USERS"
        Dim users As New List(Of UserAccessType)

        Dim u1 As New UserAccessType With {.user_id = 1, .firstName = "Mc Johnson", .lastName = "Manolo", .position = "IT", .username = "mak2x"}
        Dim u2 As New UserAccessType With {.user_id = 2, .firstName = "Ian Gil", .lastName = "Arendain", .position = "IT", .username = "ian"}
        Dim u3 As New UserAccessType With {.user_id = 2, .firstName = "Ian Gil", .lastName = "Arendain", .position = "IT", .username = "ian"}

        users.AddRange({u1, u2, u3})

        DataGridView2.DataSource = users
#End Region

        'add checkbox in datagridview 
        pcmbs.customDataGridviewCheckBox(DataGridView1)
        pcmbs.subcustomDatagridviewSettings("headerText", DataGridView1, 3, 50, "select",,,,,)

        pcmbs.subcustomDatagridviewSettings("alternateRowStyle", DataGridView2, ,,)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        FMain.pcmbs.remove_link(Me)
        Me.Dispose()
    End Sub

    Private Sub SearchByRSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchByRSToolStripMenuItem.Click

        FUserAcess_Search.ShowDialog()

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        For Each row As DataGridViewRow In DataGridView1.Rows
            row.Cells(0).Value = True
        Next
    End Sub

    Private Sub UnselectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnselectToolStripMenuItem.Click
        For Each row As DataGridViewRow In DataGridView1.Rows
            row.Cells(0).Value = False
        Next
    End Sub
End Class