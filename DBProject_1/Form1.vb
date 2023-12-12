Imports MySql.Data.MySqlClient
Public Class Form1
    Dim MySqlConn As MySqlConnection
    Dim COMMNAND As MySqlCommand

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost;username=root;database=dbtest"

        Try
            MySqlConn.Open()
            MessageBox.Show("Connection Successful")
            MySqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub

    Private Sub LogIn_Click(sender As Object, e As EventArgs) Handles LogIn.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost;username=root;database=mydb"
        Dim READER As MySqlDataReader

        Try
            MySqlConn.Open()
            Dim QUERY As String
            QUERY = "select * from mydb.user where username='" & TextBox_Username.Text & "' 
                and password= '" & TextBox_Password.Text & "'"
            COMMNAND = New MySqlCommand(QUERY, MySqlConn)
            READER = COMMNAND.ExecuteReader
            Dim count As Integer
            count = 0
            While READER.Read
                count = count + 1
            End While

            If count = 1 Then
                MessageBox.Show("Username and Password are Correct")
                Form2.Show()
                Me.Hide()

            ElseIf count > 1 Then
                MessageBox.Show("Username and Password are Duplicate")
            Else
                MessageBox.Show("Username and Password are Incorrect")
            End If

            MySqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub

End Class
