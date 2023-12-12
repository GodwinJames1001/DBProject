<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Save = New System.Windows.Forms.Button()
        Me.TextBox_eID = New System.Windows.Forms.TextBox()
        Me.TextBox_Name = New System.Windows.Forms.TextBox()
        Me.TextBox_Surname = New System.Windows.Forms.TextBox()
        Me.TextBox_Age = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ButtonLoad_table = New System.Windows.Forms.Button()
        Me.Search_txt = New System.Windows.Forms.TextBox()
        Me.Load_Chart = New System.Windows.Forms.Button()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.RadioButton_Female = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Male = New System.Windows.Forms.RadioButton()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DOB = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "eID"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(4, 536)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(190, 34)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Sign Out"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 29)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 29)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Surname"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 29)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Age"
        '
        'Save
        '
        Me.Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Save.Location = New System.Drawing.Point(3, 298)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(191, 42)
        Me.Save.TabIndex = 5
        Me.Save.Text = "Save"
        Me.Save.UseVisualStyleBackColor = True
        '
        'TextBox_eID
        '
        Me.TextBox_eID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_eID.Location = New System.Drawing.Point(138, 62)
        Me.TextBox_eID.Name = "TextBox_eID"
        Me.TextBox_eID.Size = New System.Drawing.Size(177, 36)
        Me.TextBox_eID.TabIndex = 6
        '
        'TextBox_Name
        '
        Me.TextBox_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Name.Location = New System.Drawing.Point(138, 101)
        Me.TextBox_Name.Name = "TextBox_Name"
        Me.TextBox_Name.Size = New System.Drawing.Size(177, 36)
        Me.TextBox_Name.TabIndex = 7
        '
        'TextBox_Surname
        '
        Me.TextBox_Surname.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Surname.Location = New System.Drawing.Point(138, 139)
        Me.TextBox_Surname.Name = "TextBox_Surname"
        Me.TextBox_Surname.Size = New System.Drawing.Size(177, 36)
        Me.TextBox_Surname.TabIndex = 8
        '
        'TextBox_Age
        '
        Me.TextBox_Age.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Age.Location = New System.Drawing.Point(138, 177)
        Me.TextBox_Age.Name = "TextBox_Age"
        Me.TextBox_Age.Size = New System.Drawing.Size(177, 36)
        Me.TextBox_Age.TabIndex = 9
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(3, 346)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(191, 42)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(3, 394)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(191, 42)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(15, 16)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(300, 37)
        Me.ComboBox1.TabIndex = 12
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 29
        Me.ListBox1.Location = New System.Drawing.Point(556, 13)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(170, 33)
        Me.ListBox1.TabIndex = 13
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(330, 59)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(396, 228)
        Me.DataGridView1.TabIndex = 14
        '
        'ButtonLoad_table
        '
        Me.ButtonLoad_table.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLoad_table.Location = New System.Drawing.Point(3, 442)
        Me.ButtonLoad_table.Name = "ButtonLoad_table"
        Me.ButtonLoad_table.Size = New System.Drawing.Size(191, 41)
        Me.ButtonLoad_table.TabIndex = 15
        Me.ButtonLoad_table.Text = "Load Table"
        Me.ButtonLoad_table.UseVisualStyleBackColor = True
        '
        'Search_txt
        '
        Me.Search_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search_txt.Location = New System.Drawing.Point(330, 12)
        Me.Search_txt.Name = "Search_txt"
        Me.Search_txt.Size = New System.Drawing.Size(220, 36)
        Me.Search_txt.TabIndex = 16
        '
        'Load_Chart
        '
        Me.Load_Chart.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Load_Chart.Location = New System.Drawing.Point(3, 489)
        Me.Load_Chart.Name = "Load_Chart"
        Me.Load_Chart.Size = New System.Drawing.Size(191, 42)
        Me.Load_Chart.TabIndex = 18
        Me.Load_Chart.Text = "Load_Chart"
        Me.Load_Chart.UseVisualStyleBackColor = True
        '
        'Chart1
        '
        ChartArea2.AxisX.Interval = 1.0R
        ChartArea2.AxisX.IsLabelAutoFit = False
        ChartArea2.AxisX.LabelStyle.Angle = -90
        ChartArea2.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend2)
        Me.Chart1.Location = New System.Drawing.Point(209, 298)
        Me.Chart1.Name = "Chart1"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Name_VS._Age"
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(516, 272)
        Me.Chart1.TabIndex = 19
        Me.Chart1.Text = "Chart1"
        '
        'RadioButton_Female
        '
        Me.RadioButton_Female.AutoSize = True
        Me.RadioButton_Female.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_Female.Location = New System.Drawing.Point(15, 216)
        Me.RadioButton_Female.Name = "RadioButton_Female"
        Me.RadioButton_Female.Size = New System.Drawing.Size(104, 29)
        Me.RadioButton_Female.TabIndex = 20
        Me.RadioButton_Female.TabStop = True
        Me.RadioButton_Female.Text = "Female"
        Me.RadioButton_Female.UseVisualStyleBackColor = True
        '
        'RadioButton_Male
        '
        Me.RadioButton_Male.AutoSize = True
        Me.RadioButton_Male.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_Male.Location = New System.Drawing.Point(138, 216)
        Me.RadioButton_Male.Name = "RadioButton_Male"
        Me.RadioButton_Male.Size = New System.Drawing.Size(80, 29)
        Me.RadioButton_Male.TabIndex = 21
        Me.RadioButton_Male.TabStop = True
        Me.RadioButton_Male.Text = "Male"
        Me.RadioButton_Male.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(108, 260)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(156, 27)
        Me.DateTimePicker1.TabIndex = 22
        '
        'DOB
        '
        Me.DOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DOB.Location = New System.Drawing.Point(12, 251)
        Me.DOB.Name = "DOB"
        Me.DOB.Size = New System.Drawing.Size(90, 40)
        Me.DOB.TabIndex = 23
        Me.DOB.Text = "DOB"
        Me.DOB.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(737, 582)
        Me.Controls.Add(Me.DOB)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.RadioButton_Male)
        Me.Controls.Add(Me.RadioButton_Female)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Load_Chart)
        Me.Controls.Add(Me.Search_txt)
        Me.Controls.Add(Me.ButtonLoad_table)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox_Age)
        Me.Controls.Add(Me.TextBox_Surname)
        Me.Controls.Add(Me.TextBox_Name)
        Me.Controls.Add(Me.TextBox_eID)
        Me.Controls.Add(Me.Save)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Save As Button
    Friend WithEvents TextBox_eID As TextBox
    Friend WithEvents TextBox_Name As TextBox
    Friend WithEvents TextBox_Surname As TextBox
    Friend WithEvents TextBox_Age As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ButtonLoad_table As Button
    Friend WithEvents Search_txt As TextBox
    Friend WithEvents Load_Chart As Button
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents RadioButton_Female As RadioButton
    Friend WithEvents RadioButton_Male As RadioButton
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DOB As Button
End Class
