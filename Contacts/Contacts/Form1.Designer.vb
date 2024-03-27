<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbl_firstName = New System.Windows.Forms.Label()
        Me.lbl_lastName = New System.Windows.Forms.Label()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.firstName = New System.Windows.Forms.TextBox()
        Me.lastName = New System.Windows.Forms.TextBox()
        Me.email = New System.Windows.Forms.TextBox()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.birthDate = New System.Windows.Forms.DateTimePicker()
        Me.lbl_birthDate = New System.Windows.Forms.Label()
        Me.zodiac = New System.Windows.Forms.ComboBox()
        Me.lbl_zodiac = New System.Windows.Forms.Label()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.search = New System.Windows.Forms.TextBox()
        Me.lbl_search = New System.Windows.Forms.Label()
        Me.id = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_refresh = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_firstName
        '
        Me.lbl_firstName.AutoSize = True
        Me.lbl_firstName.Location = New System.Drawing.Point(9, 53)
        Me.lbl_firstName.Name = "lbl_firstName"
        Me.lbl_firstName.Size = New System.Drawing.Size(57, 13)
        Me.lbl_firstName.TabIndex = 0
        Me.lbl_firstName.Text = "First Name"
        '
        'lbl_lastName
        '
        Me.lbl_lastName.AutoSize = True
        Me.lbl_lastName.Location = New System.Drawing.Point(9, 95)
        Me.lbl_lastName.Name = "lbl_lastName"
        Me.lbl_lastName.Size = New System.Drawing.Size(58, 13)
        Me.lbl_lastName.TabIndex = 1
        Me.lbl_lastName.Text = "Last Name"
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Location = New System.Drawing.Point(12, 139)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(36, 13)
        Me.lbl_email.TabIndex = 2
        Me.lbl_email.Text = "E-Mail"
        '
        'firstName
        '
        Me.firstName.Location = New System.Drawing.Point(12, 69)
        Me.firstName.Name = "firstName"
        Me.firstName.Size = New System.Drawing.Size(192, 20)
        Me.firstName.TabIndex = 1
        '
        'lastName
        '
        Me.lastName.Location = New System.Drawing.Point(12, 111)
        Me.lastName.Name = "lastName"
        Me.lastName.Size = New System.Drawing.Size(192, 20)
        Me.lastName.TabIndex = 2
        '
        'email
        '
        Me.email.Location = New System.Drawing.Point(12, 155)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(192, 20)
        Me.email.TabIndex = 3
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(12, 282)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(60, 23)
        Me.btn_save.TabIndex = 21
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'birthDate
        '
        Me.birthDate.Location = New System.Drawing.Point(12, 199)
        Me.birthDate.Name = "birthDate"
        Me.birthDate.Size = New System.Drawing.Size(192, 20)
        Me.birthDate.TabIndex = 4
        '
        'lbl_birthDate
        '
        Me.lbl_birthDate.AutoSize = True
        Me.lbl_birthDate.Location = New System.Drawing.Point(9, 183)
        Me.lbl_birthDate.Name = "lbl_birthDate"
        Me.lbl_birthDate.Size = New System.Drawing.Size(54, 13)
        Me.lbl_birthDate.TabIndex = 8
        Me.lbl_birthDate.Text = "Birth Date"
        '
        'zodiac
        '
        Me.zodiac.FormattingEnabled = True
        Me.zodiac.Items.AddRange(New Object() {"Aries", "Taurus", "Gemini", "Cancer", "Leo", "Virgo", "Libra", "Scorpio", "Sagittarius", "Capricorn", "Aquarius", "Pisces"})
        Me.zodiac.Location = New System.Drawing.Point(12, 244)
        Me.zodiac.Name = "zodiac"
        Me.zodiac.Size = New System.Drawing.Size(192, 21)
        Me.zodiac.TabIndex = 5
        '
        'lbl_zodiac
        '
        Me.lbl_zodiac.AutoSize = True
        Me.lbl_zodiac.Location = New System.Drawing.Point(13, 228)
        Me.lbl_zodiac.Name = "lbl_zodiac"
        Me.lbl_zodiac.Size = New System.Drawing.Size(40, 13)
        Me.lbl_zodiac.TabIndex = 10
        Me.lbl_zodiac.Text = "Zodiac"
        '
        'btn_edit
        '
        Me.btn_edit.Location = New System.Drawing.Point(78, 282)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(60, 23)
        Me.btn_edit.TabIndex = 22
        Me.btn_edit.Text = "Update"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(144, 282)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(60, 23)
        Me.btn_delete.TabIndex = 23
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.Location = New System.Drawing.Point(12, 311)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(60, 23)
        Me.btn_clear.TabIndex = 24
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.DataGridView1.Location = New System.Drawing.Point(223, 67)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(349, 263)
        Me.DataGridView1.TabIndex = 25
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 43
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.HeaderText = "First Name"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 82
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column3.HeaderText = "Last Name"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 83
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "E-Mail"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 61
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "Birth Date"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 79
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "Zodiac"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 65
        '
        'search
        '
        Me.search.Location = New System.Drawing.Point(223, 25)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(349, 20)
        Me.search.TabIndex = 27
        '
        'lbl_search
        '
        Me.lbl_search.AutoSize = True
        Me.lbl_search.Location = New System.Drawing.Point(220, 9)
        Me.lbl_search.Name = "lbl_search"
        Me.lbl_search.Size = New System.Drawing.Size(41, 13)
        Me.lbl_search.TabIndex = 26
        Me.lbl_search.Text = "Search"
        '
        'id
        '
        Me.id.Location = New System.Drawing.Point(12, 25)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(192, 20)
        Me.id.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "ID"
        '
        'btn_refresh
        '
        Me.btn_refresh.Location = New System.Drawing.Point(78, 311)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(60, 23)
        Me.btn_refresh.TabIndex = 30
        Me.btn_refresh.Text = "Refresh"
        Me.btn_refresh.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 361)
        Me.Controls.Add(Me.btn_refresh)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.lbl_search)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.lbl_zodiac)
        Me.Controls.Add(Me.zodiac)
        Me.Controls.Add(Me.lbl_birthDate)
        Me.Controls.Add(Me.birthDate)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.lastName)
        Me.Controls.Add(Me.firstName)
        Me.Controls.Add(Me.lbl_email)
        Me.Controls.Add(Me.lbl_lastName)
        Me.Controls.Add(Me.lbl_firstName)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "My Contacts"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_firstName As Label
    Friend WithEvents lbl_lastName As Label
    Friend WithEvents lbl_email As Label
    Friend WithEvents firstName As TextBox
    Friend WithEvents lastName As TextBox
    Friend WithEvents email As TextBox
    Friend WithEvents btn_save As Button
    Friend WithEvents birthDate As DateTimePicker
    Friend WithEvents lbl_birthDate As Label
    Friend WithEvents zodiac As ComboBox
    Friend WithEvents lbl_zodiac As Label
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents search As TextBox
    Friend WithEvents lbl_search As Label
    Friend WithEvents id As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents btn_refresh As Button
End Class
