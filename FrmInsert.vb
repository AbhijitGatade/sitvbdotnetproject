Imports System.Data.OleDb

Public Class FrmInsert

    Dim constr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Admin\Documents\stdentdb.accdb"

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim con = New OleDbConnection(constr)
        Dim likeprogramming As String = ""

        If chkLike.Checked Then
            likeprogramming = "Yes"
        Else
            likeprogramming = "No"
        End If

        Dim query As String = "INSERT INTO students(rollno, sname, mobileno, likeprogramming) "
        query += "VALUES(" + txtRollNo.Text + ", '" + txtName.Text + "', '" + txtMobileNo.Text + "', '" + likeprogramming + "')"
        con.Open()
        Dim cmd = New OleDbCommand(query, con)
        cmd.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Insert successful")
        Me.Close()
    End Sub

    Private Sub FrmInsert_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class