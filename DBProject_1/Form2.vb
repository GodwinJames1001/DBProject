Imports System.Diagnostics.Eventing
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Public Class Form2
    Dim gender As String
    Dim MySqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim dbDataSet As New DataTable

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost;username=root;database=mydb"
        Dim READER As MySqlDataReader

        Try
            MySqlConn.Open()
            Dim QUERY As String
            QUERY = "insert into mydb.user (eID, Name, Surname, Age, Gender, DOB) 
                values ('" & TextBox_eID.Text & "', '" & TextBox_Name.Text & "', '" & TextBox_Surname.Text & "', '" & TextBox_Age.Text & "', '" & gender & "', '" & DateTimePicker1.Text & "')"
            COMMAND = New MySqlCommand(QUERY, MySqlConn)
            READER = COMMAND.ExecuteReader

            MessageBox.Show("Data Saved")
            MySqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Dispose()
        End Try

        load_table()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost;username=root;database=mydb"
        Dim READER As MySqlDataReader

        Try
            MySqlConn.Open()
            Dim QUERY As String
            QUERY = "update mydb.user set eID='" & TextBox_eID.Text & "', name='" & TextBox_Name.Text & "', surname='" & TextBox_Surname.Text & "', age='" & TextBox_Age.Text & "' where eID='" & TextBox_eID.Text & "'"
            COMMAND = New MySqlCommand(QUERY, MySqlConn)
            READER = COMMAND.ExecuteReader

            MessageBox.Show("Data Updated!")
            MySqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Dispose()
        End Try

        load_table()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost;username=root;database=mydb"
        Dim READER As MySqlDataReader

        Try
            MySqlConn.Open()
            Dim QUERY As String
            QUERY = "Delete from mydb.user where eID='" & TextBox_eID.Text & "'"
            COMMAND = New MySqlCommand(QUERY, MySqlConn)
            READER = COMMAND.ExecuteReader

            MessageBox.Show("Data Successfully Deleted!")
            MySqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Dispose()
        End Try

        load_table()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_table()

        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost;username=root;database=mydb"
        Dim READER As MySqlDataReader

        Try
            MySqlConn.Open()
            Dim QUERY As String
            QUERY = "Select * from mydb.user"
            COMMAND = New MySqlCommand(QUERY, MySqlConn)
            READER = COMMAND.ExecuteReader
            While READER.Read
                Dim sName = READER.GetString("name")
                ComboBox1.Items.Add(sName)
                ListBox1.Items.Add(sName)

            End While

            MySqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost;username=root;database=mydb"
        Dim READER As MySqlDataReader

        Try
            MySqlConn.Open()
            Dim QUERY As String
            QUERY = "Select * from mydb.user where name= '" & ComboBox1.Text & "'"
            COMMAND = New MySqlCommand(QUERY, MySqlConn)
            READER = COMMAND.ExecuteReader
            While READER.Read
                TextBox_eID.Text = READER.GetInt32("eID")
                TextBox_Name.Text = READER.GetString("Name")
                TextBox_Surname.Text = READER.GetString("Surname")
                TextBox_Age.Text = READER.GetInt32("Age")

            End While
            MySqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost;username=root;database=mydb"
        Dim READER As MySqlDataReader

        Try
            MySqlConn.Open()
            Dim QUERY As String
            QUERY = "Select * from mydb.user where name= '" & ListBox1.Text & "'"
            COMMAND = New MySqlCommand(QUERY, MySqlConn)
            READER = COMMAND.ExecuteReader
            While READER.Read
                TextBox_eID.Text = READER.GetInt32("eID")
                TextBox_Name.Text = READER.GetString("Name")
                TextBox_Surname.Text = READER.GetString("Surname")
                TextBox_Age.Text = READER.GetInt32("Age")

            End While
            MySqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub

    Private Sub load_table()
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost;username=root;database=mydb"
        Dim SDA As New MySqlDataAdapter
        Dim bSource As New BindingSource

        Try
            MySqlConn.Open()
            Dim QUERY As String
            QUERY = "select eID as 'Employee ID',name as 'First Name',surname as 'Last Name',age as 'Age' from mydb.user"
            COMMAND = New MySqlCommand(QUERY, MySqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            DataGridView1.DataSource = bSource
            SDA.Update(dbDataSet)

            MySqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub

    Private Sub ButtonLoad_table_Click(sender As Object, e As EventArgs) Handles ButtonLoad_table.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost;username=root;database=mydb"
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource

        Try
            MySqlConn.Open()
            Dim QUERY As String
            QUERY = "select eID,name,surname,age from mydb.user"
            COMMAND = New MySqlCommand(QUERY, MySqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            DataGridView1.DataSource = bSource
            SDA.Update(dbDataSet)

            MySqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)

            TextBox_eID.Text = row.Cells("eID").Value.ToString
            TextBox_Name.Text = row.Cells("name").Value.ToString
            TextBox_Surname.Text = row.Cells("surname").Value.ToString
            TextBox_Age.Text = row.Cells("age").Value.ToString

        End If
    End Sub

    Private Sub Search_txt_TextChanged(sender As Object, e As EventArgs) Handles Search_txt.TextChanged
        Dim DV As New DataView(dbDataSet)
        DV.RowFilter = String.Format("name like '%{0}%'", Search_txt.Text)
        DataGridView1.DataSource = DV

    End Sub

    Private Sub Load_Chart_Click(sender As Object, e As EventArgs) Handles Load_Chart.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost;username=root;database=mydb"
        Dim READER As MySqlDataReader

        Try
            MySqlConn.Open()
            Dim QUERY As String
            QUERY = "select * from mydb.user"
            COMMAND = New MySqlCommand(QUERY, MySqlConn)
            READER = COMMAND.ExecuteReader
            While READER.Read
                Chart1.Series("Name_VS._Age").Points.AddXY(READER.GetString("name"), READER.GetInt32("age"))

            End While
            MySqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Do you want to leave?", "Exit", MessageBoxButtons.YesNo)
        If dialog = DialogResult.No Then
            e.Cancel = True

        Else
            Application.ExitThread()
        End If
    End Sub

    Private Sub RadioButton_Male_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_Male.CheckedChanged
        gender = "Male"
    End Sub

    Private Sub RadioButton_Female_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_Female.CheckedChanged
        gender = "Female"
    End Sub

End Class