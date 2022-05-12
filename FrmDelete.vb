Imports System.Data.OleDb

Public Class FrmDelete

    Dim constr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Admin\Documents\stdentdb.accdb"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con = New OleDbConnection(constr)
        Dim query As String = "DELETE FROM students WHERE rollno  = " + txtRollNo.Text
        con.Open()
        Dim cmd = New OleDbCommand(query, con)
        cmd.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Delete successful")
        Me.Close()
    End Sub
End Class