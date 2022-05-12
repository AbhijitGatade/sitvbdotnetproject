Imports System.Data.OleDb

Public Class FrmUpdate

    Dim constr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Admin\Documents\stdentdb.accdb"

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim con = New OleDbConnection(constr)
        Dim likeprogramming As String = ""

        If chkLike.Checked Then
            likeprogramming = "Yes"
        Else
            likeprogramming = "No"
        End If


        Dim query As String = "UPDATE students SET sname = '" + txtName.Text + "', "
        query += "mobileno = '" + txtMobileNo.Text + "', likeprogramming = '" + likeprogramming + "' "
        query += "WHERE rollno = " + txtRollNo.Text

        con.Open()
        Dim cmd = New OleDbCommand(query, con)
        cmd.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Update successful")
        Me.Close()
    End Sub
End Class