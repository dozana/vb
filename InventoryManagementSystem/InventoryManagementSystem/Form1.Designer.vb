<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        cmbAccStatus = New ComboBox()
        btnEnd = New Button()
        btnDelete = New Button()
        btnPrevious = New Button()
        btnNext = New Button()
        btnSave = New Button()
        btnAdd = New Button()
        Label16 = New Label()
        txtWeb = New TextBox()
        Label15 = New Label()
        txtEmail = New TextBox()
        Label14 = New Label()
        txtFax = New TextBox()
        Label13 = New Label()
        txtTelephone = New TextBox()
        Label12 = New Label()
        txtMobile = New TextBox()
        Label11 = New Label()
        txtBalance = New TextBox()
        Label10 = New Label()
        txtVatNumber = New TextBox()
        Label9 = New Label()
        txtContactName = New TextBox()
        txtPostCode = New TextBox()
        txtAddress = New TextBox()
        txtFullName = New TextBox()
        txtAC = New TextBox()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        TabPage2 = New TabPage()
        TabPage3 = New TabPage()
        GroupBox1 = New GroupBox()
        btnExit = New Button()
        btnReset = New Button()
        btnPassword = New Button()
        txtPassword = New TextBox()
        txtUsername = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Location = New Point(12, 12)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(530, 503)
        TabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = SystemColors.Control
        TabPage1.Controls.Add(DataGridView1)
        TabPage1.Controls.Add(cmbAccStatus)
        TabPage1.Controls.Add(btnEnd)
        TabPage1.Controls.Add(btnDelete)
        TabPage1.Controls.Add(btnPrevious)
        TabPage1.Controls.Add(btnNext)
        TabPage1.Controls.Add(btnSave)
        TabPage1.Controls.Add(btnAdd)
        TabPage1.Controls.Add(Label16)
        TabPage1.Controls.Add(txtWeb)
        TabPage1.Controls.Add(Label15)
        TabPage1.Controls.Add(txtEmail)
        TabPage1.Controls.Add(Label14)
        TabPage1.Controls.Add(txtFax)
        TabPage1.Controls.Add(Label13)
        TabPage1.Controls.Add(txtTelephone)
        TabPage1.Controls.Add(Label12)
        TabPage1.Controls.Add(txtMobile)
        TabPage1.Controls.Add(Label11)
        TabPage1.Controls.Add(txtBalance)
        TabPage1.Controls.Add(Label10)
        TabPage1.Controls.Add(txtVatNumber)
        TabPage1.Controls.Add(Label9)
        TabPage1.Controls.Add(txtContactName)
        TabPage1.Controls.Add(txtPostCode)
        TabPage1.Controls.Add(txtAddress)
        TabPage1.Controls.Add(txtFullName)
        TabPage1.Controls.Add(txtAC)
        TabPage1.Controls.Add(Label8)
        TabPage1.Controls.Add(Label7)
        TabPage1.Controls.Add(Label6)
        TabPage1.Controls.Add(Label5)
        TabPage1.Controls.Add(Label4)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(522, 475)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Customer Details"
        ' 
        ' cmbAccStatus
        ' 
        cmbAccStatus.FormattingEnabled = True
        cmbAccStatus.Location = New Point(380, 170)
        cmbAccStatus.Name = "cmbAccStatus"
        cmbAccStatus.Size = New Size(121, 23)
        cmbAccStatus.TabIndex = 32
        ' 
        ' btnEnd
        ' 
        btnEnd.Location = New Point(426, 240)
        btnEnd.Name = "btnEnd"
        btnEnd.Size = New Size(75, 23)
        btnEnd.TabIndex = 31
        btnEnd.Text = "End"
        btnEnd.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(183, 240)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(75, 23)
        btnDelete.TabIndex = 30
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnPrevious
        ' 
        btnPrevious.Location = New Point(345, 240)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(75, 23)
        btnPrevious.TabIndex = 29
        btnPrevious.Text = "Previous"
        btnPrevious.UseVisualStyleBackColor = True
        ' 
        ' btnNext
        ' 
        btnNext.Location = New Point(264, 240)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(75, 23)
        btnNext.TabIndex = 28
        btnNext.Text = "Next"
        btnNext.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(102, 240)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(75, 23)
        btnSave.TabIndex = 27
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(21, 240)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(75, 23)
        btnAdd.TabIndex = 26
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(312, 173)
        Label16.Name = "Label16"
        Label16.Size = New Size(62, 15)
        Label16.TabIndex = 24
        Label16.Text = "Acc Status"
        ' 
        ' txtWeb
        ' 
        txtWeb.Location = New Point(380, 141)
        txtWeb.Name = "txtWeb"
        txtWeb.Size = New Size(121, 23)
        txtWeb.TabIndex = 23
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(343, 146)
        Label15.Name = "Label15"
        Label15.Size = New Size(31, 15)
        Label15.TabIndex = 22
        Label15.Text = "Web"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(380, 112)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(121, 23)
        txtEmail.TabIndex = 21
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(333, 115)
        Label14.Name = "Label14"
        Label14.Size = New Size(41, 15)
        Label14.TabIndex = 20
        Label14.Text = "E-Mail"
        ' 
        ' txtFax
        ' 
        txtFax.Location = New Point(380, 83)
        txtFax.Name = "txtFax"
        txtFax.Size = New Size(121, 23)
        txtFax.TabIndex = 19
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(349, 86)
        Label13.Name = "Label13"
        Label13.Size = New Size(25, 15)
        Label13.TabIndex = 18
        Label13.Text = "Fax"
        ' 
        ' txtTelephone
        ' 
        txtTelephone.Location = New Point(380, 54)
        txtTelephone.Name = "txtTelephone"
        txtTelephone.Size = New Size(121, 23)
        txtTelephone.TabIndex = 17
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(313, 57)
        Label12.Name = "Label12"
        Label12.Size = New Size(61, 15)
        Label12.TabIndex = 16
        Label12.Text = "Telephone"
        ' 
        ' txtMobile
        ' 
        txtMobile.Location = New Point(380, 22)
        txtMobile.Name = "txtMobile"
        txtMobile.Size = New Size(121, 23)
        txtMobile.TabIndex = 15
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(330, 25)
        Label11.Name = "Label11"
        Label11.Size = New Size(44, 15)
        Label11.TabIndex = 14
        Label11.Text = "Mobile"
        ' 
        ' txtBalance
        ' 
        txtBalance.Location = New Point(100, 201)
        txtBalance.Name = "txtBalance"
        txtBalance.Size = New Size(121, 23)
        txtBalance.TabIndex = 13
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(46, 204)
        Label10.Name = "Label10"
        Label10.Size = New Size(48, 15)
        Label10.TabIndex = 12
        Label10.Text = "Balance"
        ' 
        ' txtVatNumber
        ' 
        txtVatNumber.Location = New Point(100, 172)
        txtVatNumber.Name = "txtVatNumber"
        txtVatNumber.Size = New Size(121, 23)
        txtVatNumber.TabIndex = 11
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(21, 175)
        Label9.Name = "Label9"
        Label9.Size = New Size(73, 15)
        Label9.TabIndex = 10
        Label9.Text = "VAT Number"
        ' 
        ' txtContactName
        ' 
        txtContactName.Location = New Point(100, 143)
        txtContactName.Name = "txtContactName"
        txtContactName.Size = New Size(121, 23)
        txtContactName.TabIndex = 9
        ' 
        ' txtPostCode
        ' 
        txtPostCode.Location = New Point(100, 114)
        txtPostCode.Name = "txtPostCode"
        txtPostCode.Size = New Size(121, 23)
        txtPostCode.TabIndex = 8
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(100, 83)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(121, 23)
        txtAddress.TabIndex = 7
        ' 
        ' txtFullName
        ' 
        txtFullName.Location = New Point(100, 51)
        txtFullName.Name = "txtFullName"
        txtFullName.Size = New Size(121, 23)
        txtFullName.TabIndex = 6
        ' 
        ' txtAC
        ' 
        txtAC.Location = New Point(100, 19)
        txtAC.Name = "txtAC"
        txtAC.Size = New Size(121, 23)
        txtAC.TabIndex = 5
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(10, 146)
        Label8.Name = "Label8"
        Label8.Size = New Size(84, 15)
        Label8.TabIndex = 4
        Label8.Text = "Contact Name"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(33, 117)
        Label7.Name = "Label7"
        Label7.Size = New Size(61, 15)
        Label7.TabIndex = 3
        Label7.Text = "Post Code"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(45, 86)
        Label6.Name = "Label6"
        Label6.Size = New Size(49, 15)
        Label6.TabIndex = 2
        Label6.Text = "Address"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(33, 54)
        Label5.Name = "Label5"
        Label5.Size = New Size(61, 15)
        Label5.TabIndex = 1
        Label5.Text = "Full Name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(66, 22)
        Label4.Name = "Label4"
        Label4.Size = New Size(28, 15)
        Label4.TabIndex = 0
        Label4.Text = "A/C"
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = SystemColors.Control
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(553, 318)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Default Settings"
        ' 
        ' TabPage3
        ' 
        TabPage3.BackColor = SystemColors.Control
        TabPage3.Location = New Point(4, 24)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(553, 318)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Credit Control"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnExit)
        GroupBox1.Controls.Add(btnReset)
        GroupBox1.Controls.Add(btnPassword)
        GroupBox1.Controls.Add(txtPassword)
        GroupBox1.Controls.Add(txtUsername)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(606, 24)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(530, 366)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(314, 240)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(75, 23)
        btnExit.TabIndex = 7
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(233, 240)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(75, 23)
        btnReset.TabIndex = 6
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' btnPassword
        ' 
        btnPassword.Location = New Point(152, 240)
        btnPassword.Name = "btnPassword"
        btnPassword.Size = New Size(75, 23)
        btnPassword.TabIndex = 5
        btnPassword.Text = "Password"
        btnPassword.UseVisualStyleBackColor = True
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(215, 199)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(174, 23)
        txtPassword.TabIndex = 4
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(215, 167)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(174, 23)
        txtUsername.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(152, 202)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 15)
        Label3.TabIndex = 2
        Label3.Text = "Password"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(149, 170)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 15)
        Label2.TabIndex = 1
        Label2.Text = "Username"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F)
        Label1.Location = New Point(97, 82)
        Label1.Name = "Label1"
        Label1.Size = New Size(348, 32)
        Label1.TabIndex = 0
        Label1.Text = "Inventory Management System"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(21, 282)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(480, 179)
        DataGridView1.TabIndex = 33
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1352, 661)
        Controls.Add(GroupBox1)
        Controls.Add(TabControl1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Inventory Management System"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnPassword As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtContactName As TextBox
    Friend WithEvents txtPostCode As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents txtAC As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtMobile As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtBalance As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtVatNumber As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtFax As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtTelephone As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtWeb As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents btnEnd As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents cmbAccStatus As ComboBox
    Friend WithEvents DataGridView1 As DataGridView

End Class
