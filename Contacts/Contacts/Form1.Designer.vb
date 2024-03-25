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
        Me.dateOfBirth = New System.Windows.Forms.DateTimePicker()
        Me.lbl_birthDate = New System.Windows.Forms.Label()
        Me.zodiac = New System.Windows.Forms.ComboBox()
        Me.lbl_zodiac = New System.Windows.Forms.Label()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.search = New System.Windows.Forms.TextBox()
        Me.lbl_search = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_firstName
        '
        Me.lbl_firstName.AutoSize = True
        Me.lbl_firstName.Location = New System.Drawing.Point(9, 28)
        Me.lbl_firstName.Name = "lbl_firstName"
        Me.lbl_firstName.Size = New System.Drawing.Size(57, 13)
        Me.lbl_firstName.TabIndex = 0
        Me.lbl_firstName.Text = "First Name"
        '
        'lbl_lastName
        '
        Me.lbl_lastName.AutoSize = True
        Me.lbl_lastName.Location = New System.Drawing.Point(9, 70)
        Me.lbl_lastName.Name = "lbl_lastName"
        Me.lbl_lastName.Size = New System.Drawing.Size(58, 13)
        Me.lbl_lastName.TabIndex = 1
        Me.lbl_lastName.Text = "Last Name"
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Location = New System.Drawing.Point(12, 114)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(36, 13)
        Me.lbl_email.TabIndex = 2
        Me.lbl_email.Text = "E-Mail"
        '
        'firstName
        '
        Me.firstName.Location = New System.Drawing.Point(12, 44)
        Me.firstName.Name = "firstName"
        Me.firstName.Size = New System.Drawing.Size(192, 20)
        Me.firstName.TabIndex = 1
        '
        'lastName
        '
        Me.lastName.Location = New System.Drawing.Point(12, 86)
        Me.lastName.Name = "lastName"
        Me.lastName.Size = New System.Drawing.Size(192, 20)
        Me.lastName.TabIndex = 2
        '
        'email
        '
        Me.email.Location = New System.Drawing.Point(12, 130)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(192, 20)
        Me.email.TabIndex = 3
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(12, 257)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(60, 23)
        Me.btn_save.TabIndex = 21
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'dateOfBirth
        '
        Me.dateOfBirth.Location = New System.Drawing.Point(12, 174)
        Me.dateOfBirth.Name = "dateOfBirth"
        Me.dateOfBirth.Size = New System.Drawing.Size(192, 20)
        Me.dateOfBirth.TabIndex = 4
        '
        'lbl_birthDate
        '
        Me.lbl_birthDate.AutoSize = True
        Me.lbl_birthDate.Location = New System.Drawing.Point(9, 158)
        Me.lbl_birthDate.Name = "lbl_birthDate"
        Me.lbl_birthDate.Size = New System.Drawing.Size(54, 13)
        Me.lbl_birthDate.TabIndex = 8
        Me.lbl_birthDate.Text = "Birth Date"
        '
        'zodiac
        '
        Me.zodiac.FormattingEnabled = True
        Me.zodiac.Location = New System.Drawing.Point(12, 219)
        Me.zodiac.Name = "zodiac"
        Me.zodiac.Size = New System.Drawing.Size(192, 21)
        Me.zodiac.TabIndex = 5
        '
        'lbl_zodiac
        '
        Me.lbl_zodiac.AutoSize = True
        Me.lbl_zodiac.Location = New System.Drawing.Point(13, 203)
        Me.lbl_zodiac.Name = "lbl_zodiac"
        Me.lbl_zodiac.Size = New System.Drawing.Size(40, 13)
        Me.lbl_zodiac.TabIndex = 10
        Me.lbl_zodiac.Text = "Zodiac"
        '
        'btn_update
        '
        Me.btn_update.Location = New System.Drawing.Point(78, 257)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(60, 23)
        Me.btn_update.TabIndex = 22
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(144, 257)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(60, 23)
        Me.btn_delete.TabIndex = 23
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.Location = New System.Drawing.Point(12, 286)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(60, 23)
        Me.btn_clear.TabIndex = 24
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(223, 86)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(349, 263)
        Me.DataGridView1.TabIndex = 25
        '
        'search
        '
        Me.search.Location = New System.Drawing.Point(223, 44)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(349, 20)
        Me.search.TabIndex = 27
        '
        'lbl_search
        '
        Me.lbl_search.AutoSize = True
        Me.lbl_search.Location = New System.Drawing.Point(220, 28)
        Me.lbl_search.Name = "lbl_search"
        Me.lbl_search.Size = New System.Drawing.Size(41, 13)
        Me.lbl_search.TabIndex = 26
        Me.lbl_search.Text = "Search"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 361)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.lbl_search)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.lbl_zodiac)
        Me.Controls.Add(Me.zodiac)
        Me.Controls.Add(Me.lbl_birthDate)
        Me.Controls.Add(Me.dateOfBirth)
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
    Friend WithEvents dateOfBirth As DateTimePicker
    Friend WithEvents lbl_birthDate As Label
    Friend WithEvents zodiac As ComboBox
    Friend WithEvents lbl_zodiac As Label
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents search As TextBox
    Friend WithEvents lbl_search As Label
End Class
