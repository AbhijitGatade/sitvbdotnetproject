Public Class Form1

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Dim frm = New FrmInsert()
        frm.ShowDialog()

    End Sub

    Private Sub btnList_Click(sender As Object, e As EventArgs) Handles btnList.Click
        Dim frm = New FrmList()
        frm.ShowDialog()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim frm = New FrmDelete()
        frm.ShowDialog()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim frm = New FrmUpdate()
        frm.ShowDialog()
    End Sub
End Class
