Imports System.Data.OleDb
Public Class FrmList

    Dim constr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Admin\Documents\stdentdb.accdb"

    Private Sub FrmList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con = New OleDbConnection(constr)
        Dim query = "SELECT * FROM students"
        Dim adapter = New OleDbDataAdapter(query, con)
        Dim dataset = New DataSet()
        adapter.Fill(dataset)
        DataGridView1.DataSource = dataset.Tables(0)
    End Sub
End Class