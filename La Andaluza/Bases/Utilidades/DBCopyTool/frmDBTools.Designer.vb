<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDBTools
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
        Me.txtDefaultLogDir = New System.Windows.Forms.TextBox()
        Me.tabControl1 = New System.Windows.Forms.TabControl()
        Me.tabPage1 = New System.Windows.Forms.TabPage()
        Me.groupBox6 = New System.Windows.Forms.GroupBox()
        Me.txtFromServerPassword = New System.Windows.Forms.TextBox()
        Me.chkFromServerIntegrated = New System.Windows.Forms.CheckBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.txtFromServerUser = New System.Windows.Forms.TextBox()
        Me.label10 = New System.Windows.Forms.Label()
        Me.groupBox7 = New System.Windows.Forms.GroupBox()
        Me.txtToServerPassword = New System.Windows.Forms.TextBox()
        Me.chkToServerIntegrated = New System.Windows.Forms.CheckBox()
        Me.label11 = New System.Windows.Forms.Label()
        Me.txtToServerUser = New System.Windows.Forms.TextBox()
        Me.label9 = New System.Windows.Forms.Label()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.groupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtDestLogDir = New System.Windows.Forms.TextBox()
        Me.label20 = New System.Windows.Forms.Label()
        Me.txtDestBackupDir = New System.Windows.Forms.TextBox()
        Me.label18 = New System.Windows.Forms.Label()
        Me.txtSourceDir = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.txtDestDir = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.cmbFromDatabase = New System.Windows.Forms.ComboBox()
        Me.groupBox4 = New System.Windows.Forms.GroupBox()
        Me.cmbToDatabase = New System.Windows.Forms.ComboBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.cmbToServer = New System.Windows.Forms.ComboBox()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.cmbFromServer = New System.Windows.Forms.ComboBox()
        Me.tabPage2 = New System.Windows.Forms.TabPage()
        Me.groupBox8 = New System.Windows.Forms.GroupBox()
        Me.groupBox9 = New System.Windows.Forms.GroupBox()
        Me.btnGetDefaultLogDir = New System.Windows.Forms.Button()
        Me.label19 = New System.Windows.Forms.Label()
        Me.groupBox10 = New System.Windows.Forms.GroupBox()
        Me.btnTestConnection = New System.Windows.Forms.Button()
        Me.label15 = New System.Windows.Forms.Label()
        Me.txtServerPassword = New System.Windows.Forms.TextBox()
        Me.chkServerUseIntegratedSecurity = New System.Windows.Forms.CheckBox()
        Me.label12 = New System.Windows.Forms.Label()
        Me.txtServerUser = New System.Windows.Forms.TextBox()
        Me.label17 = New System.Windows.Forms.Label()
        Me.label16 = New System.Windows.Forms.Label()
        Me.btnSaveChanges = New System.Windows.Forms.Button()
        Me.btnGetDefaultDatadir = New System.Windows.Forms.Button()
        Me.btnGetDefaultBackupdir = New System.Windows.Forms.Button()
        Me.txtDefaultDatadir = New System.Windows.Forms.TextBox()
        Me.txtDefaultbackupDir = New System.Windows.Forms.TextBox()
        Me.label14 = New System.Windows.Forms.Label()
        Me.label13 = New System.Windows.Forms.Label()
        Me.lblServer = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.lbServers = New System.Windows.Forms.ListBox()
        Me.btnAddServersFromNetwork = New System.Windows.Forms.Button()
        Me.btnRemoveSelected = New System.Windows.Forms.Button()
        Me.btnAddServer = New System.Windows.Forms.Button()
        Me.dateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.beendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.tsStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.pbCopy = New System.Windows.Forms.ToolStripProgressBar()
        Me.tabControl1.SuspendLayout()
        Me.tabPage1.SuspendLayout()
        Me.groupBox6.SuspendLayout()
        Me.groupBox7.SuspendLayout()
        Me.groupBox5.SuspendLayout()
        Me.groupBox3.SuspendLayout()
        Me.groupBox4.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.tabPage2.SuspendLayout()
        Me.groupBox8.SuspendLayout()
        Me.groupBox9.SuspendLayout()
        Me.groupBox10.SuspendLayout()
        Me.menuStrip1.SuspendLayout()
        Me.statusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDefaultLogDir
        '
        Me.txtDefaultLogDir.Location = New System.Drawing.Point(95, 226)
        Me.txtDefaultLogDir.Name = "txtDefaultLogDir"
        Me.txtDefaultLogDir.Size = New System.Drawing.Size(312, 20)
        Me.txtDefaultLogDir.TabIndex = 16
        '
        'tabControl1
        '
        Me.tabControl1.Controls.Add(Me.tabPage1)
        Me.tabControl1.Controls.Add(Me.tabPage2)
        Me.tabControl1.Location = New System.Drawing.Point(-1, 27)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New System.Drawing.Size(544, 465)
        Me.tabControl1.TabIndex = 3
        '
        'tabPage1
        '
        Me.tabPage1.Controls.Add(Me.groupBox6)
        Me.tabPage1.Controls.Add(Me.groupBox7)
        Me.tabPage1.Controls.Add(Me.btnCopy)
        Me.tabPage1.Controls.Add(Me.groupBox5)
        Me.tabPage1.Controls.Add(Me.groupBox3)
        Me.tabPage1.Controls.Add(Me.groupBox4)
        Me.tabPage1.Controls.Add(Me.groupBox2)
        Me.tabPage1.Controls.Add(Me.groupBox1)
        Me.tabPage1.Location = New System.Drawing.Point(4, 22)
        Me.tabPage1.Name = "tabPage1"
        Me.tabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage1.Size = New System.Drawing.Size(536, 439)
        Me.tabPage1.TabIndex = 0
        Me.tabPage1.Text = "Copy database"
        Me.tabPage1.UseVisualStyleBackColor = True
        '
        'groupBox6
        '
        Me.groupBox6.Controls.Add(Me.txtFromServerPassword)
        Me.groupBox6.Controls.Add(Me.chkFromServerIntegrated)
        Me.groupBox6.Controls.Add(Me.label8)
        Me.groupBox6.Controls.Add(Me.txtFromServerUser)
        Me.groupBox6.Controls.Add(Me.label10)
        Me.groupBox6.Location = New System.Drawing.Point(8, 70)
        Me.groupBox6.Name = "groupBox6"
        Me.groupBox6.Size = New System.Drawing.Size(253, 108)
        Me.groupBox6.TabIndex = 14
        Me.groupBox6.TabStop = False
        Me.groupBox6.Text = "Login information"
        '
        'txtFromServerPassword
        '
        Me.txtFromServerPassword.Enabled = False
        Me.txtFromServerPassword.Location = New System.Drawing.Point(64, 45)
        Me.txtFromServerPassword.Name = "txtFromServerPassword"
        Me.txtFromServerPassword.Size = New System.Drawing.Size(169, 20)
        Me.txtFromServerPassword.TabIndex = 8
        Me.txtFromServerPassword.UseSystemPasswordChar = True
        '
        'chkFromServerIntegrated
        '
        Me.chkFromServerIntegrated.AutoSize = True
        Me.chkFromServerIntegrated.Enabled = False
        Me.chkFromServerIntegrated.Location = New System.Drawing.Point(18, 71)
        Me.chkFromServerIntegrated.Name = "chkFromServerIntegrated"
        Me.chkFromServerIntegrated.Size = New System.Drawing.Size(132, 17)
        Me.chkFromServerIntegrated.TabIndex = 7
        Me.chkFromServerIntegrated.Text = "use integrated security"
        Me.chkFromServerIntegrated.UseVisualStyleBackColor = True
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(17, 48)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(33, 13)
        Me.label8.TabIndex = 6
        Me.label8.Text = "Pass:"
        '
        'txtFromServerUser
        '
        Me.txtFromServerUser.Enabled = False
        Me.txtFromServerUser.Location = New System.Drawing.Point(64, 19)
        Me.txtFromServerUser.Name = "txtFromServerUser"
        Me.txtFromServerUser.Size = New System.Drawing.Size(169, 20)
        Me.txtFromServerUser.TabIndex = 5
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Location = New System.Drawing.Point(17, 22)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(32, 13)
        Me.label10.TabIndex = 1
        Me.label10.Text = "User:"
        '
        'groupBox7
        '
        Me.groupBox7.Controls.Add(Me.txtToServerPassword)
        Me.groupBox7.Controls.Add(Me.chkToServerIntegrated)
        Me.groupBox7.Controls.Add(Me.label11)
        Me.groupBox7.Controls.Add(Me.txtToServerUser)
        Me.groupBox7.Controls.Add(Me.label9)
        Me.groupBox7.Location = New System.Drawing.Point(267, 70)
        Me.groupBox7.Name = "groupBox7"
        Me.groupBox7.Size = New System.Drawing.Size(253, 108)
        Me.groupBox7.TabIndex = 13
        Me.groupBox7.TabStop = False
        Me.groupBox7.Text = "Login information"
        '
        'txtToServerPassword
        '
        Me.txtToServerPassword.Enabled = False
        Me.txtToServerPassword.Location = New System.Drawing.Point(64, 45)
        Me.txtToServerPassword.Name = "txtToServerPassword"
        Me.txtToServerPassword.Size = New System.Drawing.Size(169, 20)
        Me.txtToServerPassword.TabIndex = 8
        Me.txtToServerPassword.UseSystemPasswordChar = True
        '
        'chkToServerIntegrated
        '
        Me.chkToServerIntegrated.AutoSize = True
        Me.chkToServerIntegrated.Enabled = False
        Me.chkToServerIntegrated.Location = New System.Drawing.Point(18, 71)
        Me.chkToServerIntegrated.Name = "chkToServerIntegrated"
        Me.chkToServerIntegrated.Size = New System.Drawing.Size(132, 17)
        Me.chkToServerIntegrated.TabIndex = 7
        Me.chkToServerIntegrated.Text = "use integrated security"
        Me.chkToServerIntegrated.UseVisualStyleBackColor = True
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Location = New System.Drawing.Point(17, 48)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(33, 13)
        Me.label11.TabIndex = 6
        Me.label11.Text = "Pass:"
        '
        'txtToServerUser
        '
        Me.txtToServerUser.Enabled = False
        Me.txtToServerUser.Location = New System.Drawing.Point(64, 19)
        Me.txtToServerUser.Name = "txtToServerUser"
        Me.txtToServerUser.Size = New System.Drawing.Size(169, 20)
        Me.txtToServerUser.TabIndex = 5
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(17, 22)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(32, 13)
        Me.label9.TabIndex = 1
        Me.label9.Text = "User:"
        '
        'btnCopy
        '
        Me.btnCopy.Location = New System.Drawing.Point(8, 410)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(511, 23)
        Me.btnCopy.TabIndex = 11
        Me.btnCopy.Text = "Copy"
        Me.btnCopy.UseVisualStyleBackColor = True
        '
        'groupBox5
        '
        Me.groupBox5.Controls.Add(Me.txtDestLogDir)
        Me.groupBox5.Controls.Add(Me.label20)
        Me.groupBox5.Controls.Add(Me.txtDestBackupDir)
        Me.groupBox5.Controls.Add(Me.label18)
        Me.groupBox5.Controls.Add(Me.txtSourceDir)
        Me.groupBox5.Controls.Add(Me.label6)
        Me.groupBox5.Controls.Add(Me.txtDestDir)
        Me.groupBox5.Controls.Add(Me.label5)
        Me.groupBox5.Location = New System.Drawing.Point(9, 259)
        Me.groupBox5.Name = "groupBox5"
        Me.groupBox5.Size = New System.Drawing.Size(511, 145)
        Me.groupBox5.TabIndex = 10
        Me.groupBox5.TabStop = False
        Me.groupBox5.Text = "Settings"
        '
        'txtDestLogDir
        '
        Me.txtDestLogDir.Enabled = False
        Me.txtDestLogDir.Location = New System.Drawing.Point(124, 105)
        Me.txtDestLogDir.Name = "txtDestLogDir"
        Me.txtDestLogDir.Size = New System.Drawing.Size(367, 20)
        Me.txtDestLogDir.TabIndex = 7
        '
        'label20
        '
        Me.label20.AutoSize = True
        Me.label20.Location = New System.Drawing.Point(7, 111)
        Me.label20.Name = "label20"
        Me.label20.Size = New System.Drawing.Size(94, 13)
        Me.label20.TabIndex = 6
        Me.label20.Text = "Destination log dir:"
        '
        'txtDestBackupDir
        '
        Me.txtDestBackupDir.Enabled = False
        Me.txtDestBackupDir.Location = New System.Drawing.Point(124, 51)
        Me.txtDestBackupDir.Name = "txtDestBackupDir"
        Me.txtDestBackupDir.Size = New System.Drawing.Size(367, 20)
        Me.txtDestBackupDir.TabIndex = 5
        '
        'label18
        '
        Me.label18.AutoSize = True
        Me.label18.Location = New System.Drawing.Point(7, 58)
        Me.label18.Name = "label18"
        Me.label18.Size = New System.Drawing.Size(116, 13)
        Me.label18.TabIndex = 4
        Me.label18.Text = "Destination backup dir:"
        '
        'txtSourceDir
        '
        Me.txtSourceDir.Enabled = False
        Me.txtSourceDir.Location = New System.Drawing.Point(124, 23)
        Me.txtSourceDir.Name = "txtSourceDir"
        Me.txtSourceDir.Size = New System.Drawing.Size(367, 20)
        Me.txtSourceDir.TabIndex = 3
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(7, 30)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(97, 13)
        Me.label6.TabIndex = 2
        Me.label6.Text = "Source backup dir:"
        '
        'txtDestDir
        '
        Me.txtDestDir.Enabled = False
        Me.txtDestDir.Location = New System.Drawing.Point(124, 79)
        Me.txtDestDir.Name = "txtDestDir"
        Me.txtDestDir.Size = New System.Drawing.Size(367, 20)
        Me.txtDestDir.TabIndex = 1
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(7, 86)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(101, 13)
        Me.label5.TabIndex = 0
        Me.label5.Text = "Destination data dir:"
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.label3)
        Me.groupBox3.Controls.Add(Me.cmbFromDatabase)
        Me.groupBox3.Location = New System.Drawing.Point(8, 184)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(253, 69)
        Me.groupBox3.TabIndex = 8
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = "from Database"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(20, 30)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(41, 13)
        Me.label3.TabIndex = 1
        Me.label3.Text = "Source"
        '
        'cmbFromDatabase
        '
        Me.cmbFromDatabase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFromDatabase.FormattingEnabled = True
        Me.cmbFromDatabase.Location = New System.Drawing.Point(78, 27)
        Me.cmbFromDatabase.Name = "cmbFromDatabase"
        Me.cmbFromDatabase.Size = New System.Drawing.Size(152, 21)
        Me.cmbFromDatabase.TabIndex = 0
        '
        'groupBox4
        '
        Me.groupBox4.Controls.Add(Me.cmbToDatabase)
        Me.groupBox4.Controls.Add(Me.label4)
        Me.groupBox4.Location = New System.Drawing.Point(267, 184)
        Me.groupBox4.Name = "groupBox4"
        Me.groupBox4.Size = New System.Drawing.Size(253, 69)
        Me.groupBox4.TabIndex = 9
        Me.groupBox4.TabStop = False
        Me.groupBox4.Text = "to Database"
        '
        'cmbToDatabase
        '
        Me.cmbToDataBase.FormattingEnabled = True
        Me.cmbToDataBase.Location = New System.Drawing.Point(81, 27)
        Me.cmbToDataBase.Name = "cmbToDatabase"
        Me.cmbToDataBase.Size = New System.Drawing.Size(152, 21)
        Me.cmbToDataBase.TabIndex = 4
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(15, 30)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(60, 13)
        Me.label4.TabIndex = 3
        Me.label4.Text = "Destination"
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.label2)
        Me.groupBox2.Controls.Add(Me.cmbToServer)
        Me.groupBox2.Location = New System.Drawing.Point(267, 6)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(253, 59)
        Me.groupBox2.TabIndex = 7
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "to Server"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(15, 22)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(60, 13)
        Me.label2.TabIndex = 3
        Me.label2.Text = "Destination"
        '
        'cmbToServer
        '
        Me.cmbToServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbToServer.FormattingEnabled = True
        Me.cmbToServer.Location = New System.Drawing.Point(81, 19)
        Me.cmbToServer.Name = "cmbToServer"
        Me.cmbToServer.Size = New System.Drawing.Size(152, 21)
        Me.cmbToServer.TabIndex = 2
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.cmbFromServer)
        Me.groupBox1.Location = New System.Drawing.Point(8, 6)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(253, 59)
        Me.groupBox1.TabIndex = 6
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "from Server"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(20, 22)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(41, 13)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Source"
        '
        'cmbFromServer
        '
        Me.cmbFromServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFromServer.FormattingEnabled = True
        Me.cmbFromServer.Location = New System.Drawing.Point(78, 19)
        Me.cmbFromServer.Name = "cmbFromServer"
        Me.cmbFromServer.Size = New System.Drawing.Size(152, 21)
        Me.cmbFromServer.TabIndex = 0
        '
        'tabPage2
        '
        Me.tabPage2.Controls.Add(Me.groupBox8)
        Me.tabPage2.Controls.Add(Me.btnAddServersFromNetwork)
        Me.tabPage2.Controls.Add(Me.btnRemoveSelected)
        Me.tabPage2.Controls.Add(Me.btnAddServer)
        Me.tabPage2.Location = New System.Drawing.Point(4, 22)
        Me.tabPage2.Name = "tabPage2"
        Me.tabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage2.Size = New System.Drawing.Size(536, 439)
        Me.tabPage2.TabIndex = 1
        Me.tabPage2.Text = "Servers"
        Me.tabPage2.UseVisualStyleBackColor = True
        '
        'groupBox8
        '
        Me.groupBox8.Controls.Add(Me.groupBox9)
        Me.groupBox8.Controls.Add(Me.lbServers)
        Me.groupBox8.Location = New System.Drawing.Point(8, 6)
        Me.groupBox8.Name = "groupBox8"
        Me.groupBox8.Size = New System.Drawing.Size(517, 398)
        Me.groupBox8.TabIndex = 7
        Me.groupBox8.TabStop = False
        Me.groupBox8.Text = "Choose server"
        '
        'groupBox9
        '
        Me.groupBox9.Controls.Add(Me.btnGetDefaultLogDir)
        Me.groupBox9.Controls.Add(Me.label19)
        Me.groupBox9.Controls.Add(Me.txtDefaultLogDir)
        Me.groupBox9.Controls.Add(Me.groupBox10)
        Me.groupBox9.Controls.Add(Me.label16)
        Me.groupBox9.Controls.Add(Me.btnSaveChanges)
        Me.groupBox9.Controls.Add(Me.btnGetDefaultDatadir)
        Me.groupBox9.Controls.Add(Me.btnGetDefaultBackupdir)
        Me.groupBox9.Controls.Add(Me.txtDefaultDatadir)
        Me.groupBox9.Controls.Add(Me.txtDefaultbackupDir)
        Me.groupBox9.Controls.Add(Me.label14)
        Me.groupBox9.Controls.Add(Me.label13)
        Me.groupBox9.Controls.Add(Me.lblServer)
        Me.groupBox9.Controls.Add(Me.label7)
        Me.groupBox9.Location = New System.Drawing.Point(6, 107)
        Me.groupBox9.Name = "groupBox9"
        Me.groupBox9.Size = New System.Drawing.Size(500, 285)
        Me.groupBox9.TabIndex = 1
        Me.groupBox9.TabStop = False
        Me.groupBox9.Text = "Selected server details"
        '
        'btnGetDefaultLogDir
        '
        Me.btnGetDefaultLogDir.Enabled = False
        Me.btnGetDefaultLogDir.Location = New System.Drawing.Point(413, 224)
        Me.btnGetDefaultLogDir.Name = "btnGetDefaultLogDir"
        Me.btnGetDefaultLogDir.Size = New System.Drawing.Size(75, 23)
        Me.btnGetDefaultLogDir.TabIndex = 18
        Me.btnGetDefaultLogDir.Text = "get it"
        Me.btnGetDefaultLogDir.UseVisualStyleBackColor = True
        '
        'label19
        '
        Me.label19.AutoSize = True
        Me.label19.Location = New System.Drawing.Point(6, 229)
        Me.label19.Name = "label19"
        Me.label19.Size = New System.Drawing.Size(42, 13)
        Me.label19.TabIndex = 17
        Me.label19.Text = "Log dir:"
        '
        'groupBox10
        '
        Me.groupBox10.Controls.Add(Me.btnTestConnection)
        Me.groupBox10.Controls.Add(Me.label15)
        Me.groupBox10.Controls.Add(Me.txtServerPassword)
        Me.groupBox10.Controls.Add(Me.chkServerUseIntegratedSecurity)
        Me.groupBox10.Controls.Add(Me.label12)
        Me.groupBox10.Controls.Add(Me.txtServerUser)
        Me.groupBox10.Controls.Add(Me.label17)
        Me.groupBox10.Location = New System.Drawing.Point(9, 32)
        Me.groupBox10.Name = "groupBox10"
        Me.groupBox10.Size = New System.Drawing.Size(479, 136)
        Me.groupBox10.TabIndex = 15
        Me.groupBox10.TabStop = False
        Me.groupBox10.Text = "Login information"
        '
        'btnTestConnection
        '
        Me.btnTestConnection.Enabled = False
        Me.btnTestConnection.Location = New System.Drawing.Point(111, 99)
        Me.btnTestConnection.Name = "btnTestConnection"
        Me.btnTestConnection.Size = New System.Drawing.Size(143, 23)
        Me.btnTestConnection.TabIndex = 10
        Me.btnTestConnection.Text = "Test it"
        Me.btnTestConnection.UseVisualStyleBackColor = True
        '
        'label15
        '
        Me.label15.AutoSize = True
        Me.label15.Location = New System.Drawing.Point(18, 104)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(87, 13)
        Me.label15.TabIndex = 9
        Me.label15.Text = "Test connection:"
        '
        'txtServerPassword
        '
        Me.txtServerPassword.Enabled = False
        Me.txtServerPassword.Location = New System.Drawing.Point(64, 45)
        Me.txtServerPassword.Name = "txtServerPassword"
        Me.txtServerPassword.Size = New System.Drawing.Size(409, 20)
        Me.txtServerPassword.TabIndex = 8
        Me.txtServerPassword.UseSystemPasswordChar = True
        '
        'chkServerUseIntegratedSecurity
        '
        Me.chkServerUseIntegratedSecurity.AutoSize = True
        Me.chkServerUseIntegratedSecurity.Enabled = False
        Me.chkServerUseIntegratedSecurity.Location = New System.Drawing.Point(20, 76)
        Me.chkServerUseIntegratedSecurity.Name = "chkServerUseIntegratedSecurity"
        Me.chkServerUseIntegratedSecurity.Size = New System.Drawing.Size(132, 17)
        Me.chkServerUseIntegratedSecurity.TabIndex = 7
        Me.chkServerUseIntegratedSecurity.Text = "use integrated security"
        Me.chkServerUseIntegratedSecurity.UseVisualStyleBackColor = True
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Location = New System.Drawing.Point(17, 48)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(33, 13)
        Me.label12.TabIndex = 6
        Me.label12.Text = "Pass:"
        '
        'txtServerUser
        '
        Me.txtServerUser.Enabled = False
        Me.txtServerUser.Location = New System.Drawing.Point(64, 19)
        Me.txtServerUser.Name = "txtServerUser"
        Me.txtServerUser.Size = New System.Drawing.Size(409, 20)
        Me.txtServerUser.TabIndex = 5
        '
        'label17
        '
        Me.label17.AutoSize = True
        Me.label17.Location = New System.Drawing.Point(17, 22)
        Me.label17.Name = "label17"
        Me.label17.Size = New System.Drawing.Size(32, 13)
        Me.label17.TabIndex = 1
        Me.label17.Text = "User:"
        '
        'label16
        '
        Me.label16.AutoSize = True
        Me.label16.Location = New System.Drawing.Point(6, 261)
        Me.label16.Name = "label16"
        Me.label16.Size = New System.Drawing.Size(74, 13)
        Me.label16.TabIndex = 12
        Me.label16.Text = "Save settings:"
        '
        'btnSaveChanges
        '
        Me.btnSaveChanges.Enabled = False
        Me.btnSaveChanges.Location = New System.Drawing.Point(95, 256)
        Me.btnSaveChanges.Name = "btnSaveChanges"
        Me.btnSaveChanges.Size = New System.Drawing.Size(143, 23)
        Me.btnSaveChanges.TabIndex = 11
        Me.btnSaveChanges.Text = "Save serversettings"
        Me.btnSaveChanges.UseVisualStyleBackColor = True
        '
        'btnGetDefaultDatadir
        '
        Me.btnGetDefaultDatadir.Enabled = False
        Me.btnGetDefaultDatadir.Location = New System.Drawing.Point(413, 198)
        Me.btnGetDefaultDatadir.Name = "btnGetDefaultDatadir"
        Me.btnGetDefaultDatadir.Size = New System.Drawing.Size(75, 23)
        Me.btnGetDefaultDatadir.TabIndex = 10
        Me.btnGetDefaultDatadir.Text = "get it"
        Me.btnGetDefaultDatadir.UseVisualStyleBackColor = True
        '
        'btnGetDefaultBackupdir
        '
        Me.btnGetDefaultBackupdir.Enabled = False
        Me.btnGetDefaultBackupdir.Location = New System.Drawing.Point(413, 172)
        Me.btnGetDefaultBackupdir.Name = "btnGetDefaultBackupdir"
        Me.btnGetDefaultBackupdir.Size = New System.Drawing.Size(75, 23)
        Me.btnGetDefaultBackupdir.TabIndex = 9
        Me.btnGetDefaultBackupdir.Text = "get it"
        Me.btnGetDefaultBackupdir.UseVisualStyleBackColor = True
        '
        'txtDefaultDatadir
        '
        Me.txtDefaultDatadir.Location = New System.Drawing.Point(95, 200)
        Me.txtDefaultDatadir.Name = "txtDefaultDatadir"
        Me.txtDefaultDatadir.Size = New System.Drawing.Size(312, 20)
        Me.txtDefaultDatadir.TabIndex = 8
        '
        'txtDefaultbackupDir
        '
        Me.txtDefaultbackupDir.Location = New System.Drawing.Point(95, 174)
        Me.txtDefaultbackupDir.Name = "txtDefaultbackupDir"
        Me.txtDefaultbackupDir.Size = New System.Drawing.Size(312, 20)
        Me.txtDefaultbackupDir.TabIndex = 7
        '
        'label14
        '
        Me.label14.AutoSize = True
        Me.label14.Location = New System.Drawing.Point(6, 203)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(47, 13)
        Me.label14.TabIndex = 3
        Me.label14.Text = "Data dir:"
        '
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.Location = New System.Drawing.Point(6, 177)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(61, 13)
        Me.label13.TabIndex = 2
        Me.label13.Text = "Backup dir:"
        '
        'lblServer
        '
        Me.lblServer.AutoSize = True
        Me.lblServer.Location = New System.Drawing.Point(92, 16)
        Me.lblServer.Name = "lblServer"
        Me.lblServer.Size = New System.Drawing.Size(94, 13)
        Me.lblServer.TabIndex = 1
        Me.lblServer.Text = "no server selected"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(6, 16)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(82, 13)
        Me.label7.TabIndex = 0
        Me.label7.Text = "Servername/IP:"
        '
        'lbServers
        '
        Me.lbServers.FormattingEnabled = True
        Me.lbServers.Location = New System.Drawing.Point(6, 19)
        Me.lbServers.Name = "lbServers"
        Me.lbServers.Size = New System.Drawing.Size(505, 82)
        Me.lbServers.TabIndex = 0
        '
        'btnAddServersFromNetwork
        '
        Me.btnAddServersFromNetwork.Location = New System.Drawing.Point(182, 410)
        Me.btnAddServersFromNetwork.Name = "btnAddServersFromNetwork"
        Me.btnAddServersFromNetwork.Size = New System.Drawing.Size(165, 23)
        Me.btnAddServersFromNetwork.TabIndex = 6
        Me.btnAddServersFromNetwork.Text = "Add servers from network"
        Me.btnAddServersFromNetwork.UseVisualStyleBackColor = True
        '
        'btnRemoveSelected
        '
        Me.btnRemoveSelected.Enabled = False
        Me.btnRemoveSelected.Location = New System.Drawing.Point(353, 410)
        Me.btnRemoveSelected.Name = "btnRemoveSelected"
        Me.btnRemoveSelected.Size = New System.Drawing.Size(161, 23)
        Me.btnRemoveSelected.TabIndex = 5
        Me.btnRemoveSelected.Text = "Remove selected"
        Me.btnRemoveSelected.UseVisualStyleBackColor = True
        '
        'btnAddServer
        '
        Me.btnAddServer.Location = New System.Drawing.Point(11, 410)
        Me.btnAddServer.Name = "btnAddServer"
        Me.btnAddServer.Size = New System.Drawing.Size(165, 23)
        Me.btnAddServer.TabIndex = 4
        Me.btnAddServer.Text = "Add server"
        Me.btnAddServer.UseVisualStyleBackColor = True
        '
        'dateiToolStripMenuItem
        '
        Me.dateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.beendenToolStripMenuItem})
        Me.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem"
        Me.dateiToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.dateiToolStripMenuItem.Text = "&File"
        '
        'beendenToolStripMenuItem
        '
        Me.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem"
        Me.beendenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.beendenToolStripMenuItem.Text = "&Quit"
        '
        'menuStrip1
        '
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.dateiToolStripMenuItem})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Size = New System.Drawing.Size(543, 24)
        Me.menuStrip1.TabIndex = 4
        Me.menuStrip1.Text = "menuStrip1"
        '
        'tsStatus
        '
        Me.tsStatus.Name = "tsStatus"
        Me.tsStatus.Size = New System.Drawing.Size(29, 19)
        Me.tsStatus.Text = "Idle."
        '
        'statusStrip1
        '
        Me.statusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsStatus, Me.pbCopy})
        Me.statusStrip1.Location = New System.Drawing.Point(0, 493)
        Me.statusStrip1.Name = "statusStrip1"
        Me.statusStrip1.Size = New System.Drawing.Size(543, 24)
        Me.statusStrip1.TabIndex = 5
        Me.statusStrip1.Text = "statusStrip1"
        '
        'pbCopy
        '
        Me.pbCopy.Name = "pbCopy"
        Me.pbCopy.Size = New System.Drawing.Size(300, 18)
        '
        'frmDBTools
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 517)
        Me.Controls.Add(Me.tabControl1)
        Me.Controls.Add(Me.menuStrip1)
        Me.Controls.Add(Me.statusStrip1)
        Me.MainMenuStrip = Me.menuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmDBTools"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DB Copy Tool"
        Me.tabControl1.ResumeLayout(False)
        Me.tabPage1.ResumeLayout(False)
        Me.groupBox6.ResumeLayout(False)
        Me.groupBox6.PerformLayout()
        Me.groupBox7.ResumeLayout(False)
        Me.groupBox7.PerformLayout()
        Me.groupBox5.ResumeLayout(False)
        Me.groupBox5.PerformLayout()
        Me.groupBox3.ResumeLayout(False)
        Me.groupBox3.PerformLayout()
        Me.groupBox4.ResumeLayout(False)
        Me.groupBox4.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.tabPage2.ResumeLayout(False)
        Me.groupBox8.ResumeLayout(False)
        Me.groupBox9.ResumeLayout(False)
        Me.groupBox9.PerformLayout()
        Me.groupBox10.ResumeLayout(False)
        Me.groupBox10.PerformLayout()
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        Me.statusStrip1.ResumeLayout(False)
        Me.statusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents txtDefaultLogDir As System.Windows.Forms.TextBox
    Private WithEvents tabControl1 As System.Windows.Forms.TabControl
    Private WithEvents tabPage1 As System.Windows.Forms.TabPage
    Private WithEvents groupBox6 As System.Windows.Forms.GroupBox
    Private WithEvents txtFromServerPassword As System.Windows.Forms.TextBox
    Private WithEvents chkFromServerIntegrated As System.Windows.Forms.CheckBox
    Private WithEvents label8 As System.Windows.Forms.Label
    Private WithEvents txtFromServerUser As System.Windows.Forms.TextBox
    Private WithEvents label10 As System.Windows.Forms.Label
    Private WithEvents groupBox7 As System.Windows.Forms.GroupBox
    Private WithEvents txtToServerPassword As System.Windows.Forms.TextBox
    Private WithEvents chkToServerIntegrated As System.Windows.Forms.CheckBox
    Private WithEvents label11 As System.Windows.Forms.Label
    Private WithEvents txtToServerUser As System.Windows.Forms.TextBox
    Private WithEvents label9 As System.Windows.Forms.Label
    Private WithEvents btnCopy As System.Windows.Forms.Button
    Private WithEvents groupBox5 As System.Windows.Forms.GroupBox
    Private WithEvents txtDestLogDir As System.Windows.Forms.TextBox
    Private WithEvents label20 As System.Windows.Forms.Label
    Private WithEvents txtDestBackupDir As System.Windows.Forms.TextBox
    Private WithEvents label18 As System.Windows.Forms.Label
    Private WithEvents txtSourceDir As System.Windows.Forms.TextBox
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents txtDestDir As System.Windows.Forms.TextBox
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents groupBox3 As System.Windows.Forms.GroupBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents cmbFromDatabase As System.Windows.Forms.ComboBox
    Private WithEvents groupBox4 As System.Windows.Forms.GroupBox
    Private WithEvents cmbToDatabase As System.Windows.Forms.ComboBox
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents cmbToServer As System.Windows.Forms.ComboBox
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents cmbFromServer As System.Windows.Forms.ComboBox
    Private WithEvents tabPage2 As System.Windows.Forms.TabPage
    Private WithEvents groupBox8 As System.Windows.Forms.GroupBox
    Private WithEvents groupBox9 As System.Windows.Forms.GroupBox
    Private WithEvents btnGetDefaultLogDir As System.Windows.Forms.Button
    Private WithEvents label19 As System.Windows.Forms.Label
    Private WithEvents groupBox10 As System.Windows.Forms.GroupBox
    Private WithEvents btnTestConnection As System.Windows.Forms.Button
    Private WithEvents label15 As System.Windows.Forms.Label
    Private WithEvents txtServerPassword As System.Windows.Forms.TextBox
    Private WithEvents chkServerUseIntegratedSecurity As System.Windows.Forms.CheckBox
    Private WithEvents label12 As System.Windows.Forms.Label
    Private WithEvents txtServerUser As System.Windows.Forms.TextBox
    Private WithEvents label17 As System.Windows.Forms.Label
    Private WithEvents label16 As System.Windows.Forms.Label
    Private WithEvents btnSaveChanges As System.Windows.Forms.Button
    Private WithEvents btnGetDefaultDatadir As System.Windows.Forms.Button
    Private WithEvents btnGetDefaultBackupdir As System.Windows.Forms.Button
    Private WithEvents txtDefaultDatadir As System.Windows.Forms.TextBox
    Private WithEvents txtDefaultbackupDir As System.Windows.Forms.TextBox
    Private WithEvents label14 As System.Windows.Forms.Label
    Private WithEvents label13 As System.Windows.Forms.Label
    Private WithEvents lblServer As System.Windows.Forms.Label
    Private WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents lbServers As System.Windows.Forms.ListBox
    Private WithEvents btnAddServersFromNetwork As System.Windows.Forms.Button
    Private WithEvents btnRemoveSelected As System.Windows.Forms.Button
    Private WithEvents btnAddServer As System.Windows.Forms.Button
    Private WithEvents dateiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents beendenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents menuStrip1 As System.Windows.Forms.MenuStrip
    Private WithEvents tsStatus As System.Windows.Forms.ToolStripStatusLabel
    Private WithEvents statusStrip1 As System.Windows.Forms.StatusStrip
    Private WithEvents pbCopy As System.Windows.Forms.ToolStripProgressBar
End Class
