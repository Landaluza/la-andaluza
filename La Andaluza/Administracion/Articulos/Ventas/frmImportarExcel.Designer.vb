<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImportarExcel
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImportarExcel))
        Me.cbMonth = New System.Windows.Forms.ComboBox()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnChooseFile = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtResultados = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanHelp = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnManual = New System.Windows.Forms.Button()
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtPath2 = New System.Windows.Forms.TextBox()
        Me.btnChooseFile2 = New System.Windows.Forms.Button()
        Me.txtPath3 = New System.Windows.Forms.TextBox()
        Me.btnChooseFile3 = New System.Windows.Forms.Button()
        Me.txtPath4 = New System.Windows.Forms.TextBox()
        Me.btnChooseFile4 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.err = New System.Windows.Forms.PictureBox()
        Me.err1 = New System.Windows.Forms.PictureBox()
        Me.err2 = New System.Windows.Forms.PictureBox()
        Me.err3 = New System.Windows.Forms.PictureBox()
        Me.ToolTip3 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip4 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanHelp.SuspendLayout()
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.err1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.err2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.err3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbMonth
        '
        Me.cbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMonth.FormattingEnabled = True
        Me.cbMonth.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cbMonth.Location = New System.Drawing.Point(109, 22)
        Me.cbMonth.Margin = New System.Windows.Forms.Padding(4)
        Me.cbMonth.Name = "cbMonth"
        Me.cbMonth.Size = New System.Drawing.Size(160, 24)
        Me.cbMonth.TabIndex = 1
        '
        'btnImport
        '
        Me.btnImport.Image = Global.La_Andaluza.My.Resources.Resources.document_save_5_32
        Me.btnImport.Location = New System.Drawing.Point(731, 275)
        Me.btnImport.Margin = New System.Windows.Forms.Padding(4)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(129, 59)
        Me.btnImport.TabIndex = 15
        Me.btnImport.Text = "&Importar"
        Me.btnImport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "ventas.xls"
        Me.OpenFileDialog1.InitialDirectory = "Z:\Comercial\Estadisticas\"
        '
        'btnChooseFile
        '
        Me.btnChooseFile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChooseFile.FlatAppearance.BorderSize = 0
        Me.btnChooseFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChooseFile.Image = CType(resources.GetObject("btnChooseFile.Image"), System.Drawing.Image)
        Me.btnChooseFile.Location = New System.Drawing.Point(542, 70)
        Me.btnChooseFile.Margin = New System.Windows.Forms.Padding(4)
        Me.btnChooseFile.Name = "btnChooseFile"
        Me.btnChooseFile.Size = New System.Drawing.Size(41, 36)
        Me.btnChooseFile.TabIndex = 4
        Me.btnChooseFile.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 26)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Mes"
        '
        'txtPath
        '
        Me.txtPath.Cursor = System.Windows.Forms.Cursors.No
        Me.txtPath.Enabled = False
        Me.txtPath.Location = New System.Drawing.Point(109, 76)
        Me.txtPath.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(424, 22)
        Me.txtPath.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 81)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Ruta (JR)"
        '
        'txtResultados
        '
        Me.txtResultados.Location = New System.Drawing.Point(719, 77)
        Me.txtResultados.Margin = New System.Windows.Forms.Padding(4)
        Me.txtResultados.Name = "txtResultados"
        Me.txtResultados.Size = New System.Drawing.Size(140, 22)
        Me.txtResultados.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(617, 85)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Resultados"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.La_Andaluza.My.Resources.Resources.excelHelp
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(336, 196)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'PanHelp
        '
        Me.PanHelp.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PanHelp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanHelp.Controls.Add(Me.Label4)
        Me.PanHelp.Controls.Add(Me.PictureBox1)
        Me.PanHelp.Location = New System.Drawing.Point(41, 70)
        Me.PanHelp.Margin = New System.Windows.Forms.Padding(4)
        Me.PanHelp.Name = "PanHelp"
        Me.PanHelp.Size = New System.Drawing.Size(338, 228)
        Me.PanHelp.TabIndex = 10
        Me.PanHelp.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Image = Global.La_Andaluza.My.Resources.Resources.emblem_notice
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Location = New System.Drawing.Point(3, 204)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(338, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "      Introduce el el valor de fila anterior al ultimo total"
        '
        'btnEliminar
        '
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Image = Global.La_Andaluza.My.Resources.Resources.edit_remove_3
        Me.btnEliminar.Location = New System.Drawing.Point(278, 19)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(36, 28)
        Me.btnEliminar.TabIndex = 2
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Elimina los resultados del mes seleccionado"
        '
        'btnManual
        '
        Me.btnManual.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnManual.FlatAppearance.BorderSize = 0
        Me.btnManual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManual.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.btnManual.Location = New System.Drawing.Point(322, 19)
        Me.btnManual.Margin = New System.Windows.Forms.Padding(4)
        Me.btnManual.Name = "btnManual"
        Me.btnManual.Size = New System.Drawing.Size(33, 28)
        Me.btnManual.TabIndex = 31
        Me.btnManual.Text = "  "
        Me.btnManual.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnManual.UseVisualStyleBackColor = True
        '
        'ToolTip2
        '
        Me.ToolTip2.IsBalloon = True
        Me.ToolTip2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip2.ToolTipTitle = "Resultados"
        '
        'txtPath2
        '
        Me.txtPath2.Cursor = System.Windows.Forms.Cursors.No
        Me.txtPath2.Enabled = False
        Me.txtPath2.Location = New System.Drawing.Point(109, 122)
        Me.txtPath2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPath2.Name = "txtPath2"
        Me.txtPath2.Size = New System.Drawing.Size(424, 22)
        Me.txtPath2.TabIndex = 6
        '
        'btnChooseFile2
        '
        Me.btnChooseFile2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChooseFile2.FlatAppearance.BorderSize = 0
        Me.btnChooseFile2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChooseFile2.Image = CType(resources.GetObject("btnChooseFile2.Image"), System.Drawing.Image)
        Me.btnChooseFile2.Location = New System.Drawing.Point(542, 115)
        Me.btnChooseFile2.Margin = New System.Windows.Forms.Padding(4)
        Me.btnChooseFile2.Name = "btnChooseFile2"
        Me.btnChooseFile2.Size = New System.Drawing.Size(41, 36)
        Me.btnChooseFile2.TabIndex = 7
        Me.btnChooseFile2.UseVisualStyleBackColor = True
        '
        'txtPath3
        '
        Me.txtPath3.Cursor = System.Windows.Forms.Cursors.No
        Me.txtPath3.Enabled = False
        Me.txtPath3.Location = New System.Drawing.Point(109, 168)
        Me.txtPath3.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPath3.Name = "txtPath3"
        Me.txtPath3.Size = New System.Drawing.Size(424, 22)
        Me.txtPath3.TabIndex = 9
        '
        'btnChooseFile3
        '
        Me.btnChooseFile3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChooseFile3.FlatAppearance.BorderSize = 0
        Me.btnChooseFile3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChooseFile3.Image = CType(resources.GetObject("btnChooseFile3.Image"), System.Drawing.Image)
        Me.btnChooseFile3.Location = New System.Drawing.Point(542, 162)
        Me.btnChooseFile3.Margin = New System.Windows.Forms.Padding(4)
        Me.btnChooseFile3.Name = "btnChooseFile3"
        Me.btnChooseFile3.Size = New System.Drawing.Size(41, 36)
        Me.btnChooseFile3.TabIndex = 10
        Me.btnChooseFile3.UseVisualStyleBackColor = True
        '
        'txtPath4
        '
        Me.txtPath4.Cursor = System.Windows.Forms.Cursors.No
        Me.txtPath4.Enabled = False
        Me.txtPath4.Location = New System.Drawing.Point(109, 214)
        Me.txtPath4.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPath4.Name = "txtPath4"
        Me.txtPath4.Size = New System.Drawing.Size(424, 22)
        Me.txtPath4.TabIndex = 12
        '
        'btnChooseFile4
        '
        Me.btnChooseFile4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChooseFile4.FlatAppearance.BorderSize = 0
        Me.btnChooseFile4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChooseFile4.Image = CType(resources.GetObject("btnChooseFile4.Image"), System.Drawing.Image)
        Me.btnChooseFile4.Location = New System.Drawing.Point(542, 208)
        Me.btnChooseFile4.Margin = New System.Windows.Forms.Padding(4)
        Me.btnChooseFile4.Name = "btnChooseFile4"
        Me.btnChooseFile4.Size = New System.Drawing.Size(41, 36)
        Me.btnChooseFile4.TabIndex = 13
        Me.btnChooseFile4.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(617, 125)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 17)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Resultados"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(719, 122)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(140, 22)
        Me.TextBox1.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(617, 172)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 17)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Resultados"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(719, 168)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(140, 22)
        Me.TextBox2.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(617, 218)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 17)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Resultados"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(719, 214)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(140, 22)
        Me.TextBox3.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(37, 125)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 17)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Ruta (JR)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(37, 172)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 17)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Ruta (VLA)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(37, 218)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 17)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Ruta (VLA)"
        '
        'err
        '
        Me.err.Image = Global.La_Andaluza.My.Resources.Resources.emblem_important_3
        Me.err.Location = New System.Drawing.Point(875, 76)
        Me.err.Margin = New System.Windows.Forms.Padding(4)
        Me.err.Name = "err"
        Me.err.Size = New System.Drawing.Size(32, 26)
        Me.err.TabIndex = 27
        Me.err.TabStop = False
        Me.err.Visible = False
        '
        'err1
        '
        Me.err1.Image = Global.La_Andaluza.My.Resources.Resources.emblem_important_3
        Me.err1.Location = New System.Drawing.Point(875, 120)
        Me.err1.Margin = New System.Windows.Forms.Padding(4)
        Me.err1.Name = "err1"
        Me.err1.Size = New System.Drawing.Size(32, 26)
        Me.err1.TabIndex = 28
        Me.err1.TabStop = False
        Me.err1.Visible = False
        '
        'err2
        '
        Me.err2.Image = Global.La_Andaluza.My.Resources.Resources.emblem_important_3
        Me.err2.Location = New System.Drawing.Point(875, 168)
        Me.err2.Margin = New System.Windows.Forms.Padding(4)
        Me.err2.Name = "err2"
        Me.err2.Size = New System.Drawing.Size(32, 26)
        Me.err2.TabIndex = 29
        Me.err2.TabStop = False
        Me.err2.Visible = False
        '
        'err3
        '
        Me.err3.Image = Global.La_Andaluza.My.Resources.Resources.emblem_important_3
        Me.err3.Location = New System.Drawing.Point(875, 213)
        Me.err3.Margin = New System.Windows.Forms.Padding(4)
        Me.err3.Name = "err3"
        Me.err3.Size = New System.Drawing.Size(32, 26)
        Me.err3.TabIndex = 30
        Me.err3.TabStop = False
        Me.err3.Visible = False
        '
        'ToolTip3
        '
        Me.ToolTip3.IsBalloon = True
        Me.ToolTip3.ShowAlways = True
        Me.ToolTip3.ToolTipIcon = System.Windows.Forms.ToolTipIcon.[Error]
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PanHelp)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnManual)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.err3)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.err2)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.err1)
        Me.Panel1.Controls.Add(Me.txtPath2)
        Me.Panel1.Controls.Add(Me.err)
        Me.Panel1.Controls.Add(Me.txtPath3)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.btnChooseFile4)
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.txtPath4)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.btnEliminar)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.cbMonth)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.btnImport)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.btnChooseFile)
        Me.Panel1.Controls.Add(Me.btnChooseFile3)
        Me.Panel1.Controls.Add(Me.txtPath)
        Me.Panel1.Controls.Add(Me.btnChooseFile2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtResultados)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(31, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(973, 380)
        Me.Panel1.TabIndex = 32
        '
        'frmImportarExcel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1029, 424)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimizeBox = False
        Me.Name = "frmImportarExcel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanHelp.ResumeLayout(False)
        Me.PanHelp.PerformLayout()
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.err1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.err2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.err3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents ToolTip3 As System.Windows.Forms.ToolTip
    Private WithEvents cbMonth As System.Windows.Forms.ComboBox
    Private WithEvents btnImport As System.Windows.Forms.Button
    Private WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Private WithEvents btnChooseFile As System.Windows.Forms.Button
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents txtPath As System.Windows.Forms.TextBox
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents txtResultados As System.Windows.Forms.TextBox
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Private WithEvents PanHelp As System.Windows.Forms.Panel
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents btnEliminar As System.Windows.Forms.Button
    Private WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Private WithEvents ToolTip2 As System.Windows.Forms.ToolTip
    Private WithEvents txtPath2 As System.Windows.Forms.TextBox
    Private WithEvents btnChooseFile2 As System.Windows.Forms.Button
    Private WithEvents txtPath3 As System.Windows.Forms.TextBox
    Private WithEvents btnChooseFile3 As System.Windows.Forms.Button
    Private WithEvents txtPath4 As System.Windows.Forms.TextBox
    Private WithEvents btnChooseFile4 As System.Windows.Forms.Button
    Private WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents TextBox1 As System.Windows.Forms.TextBox
    Private WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents TextBox2 As System.Windows.Forms.TextBox
    Private WithEvents Label7 As System.Windows.Forms.Label
    Private WithEvents TextBox3 As System.Windows.Forms.TextBox
    Private WithEvents Label8 As System.Windows.Forms.Label
    Private WithEvents Label9 As System.Windows.Forms.Label
    Private WithEvents Label10 As System.Windows.Forms.Label
    Private WithEvents err As System.Windows.Forms.PictureBox
    Private WithEvents err1 As System.Windows.Forms.PictureBox
    Private WithEvents err2 As System.Windows.Forms.PictureBox
    Private WithEvents err3 As System.Windows.Forms.PictureBox
    Private WithEvents btnManual As System.Windows.Forms.Button
    Private WithEvents ToolTip4 As System.Windows.Forms.ToolTip
    Private WithEvents Panel1 As System.Windows.Forms.Panel
End Class
