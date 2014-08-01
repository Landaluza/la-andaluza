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
        Me.chbJR2 = New System.Windows.Forms.CheckBox()
        Me.panJR2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.err1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.err2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.err3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.panJR2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbMonth
        '
        Me.cbMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbMonth.FormattingEnabled = True
        Me.cbMonth.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cbMonth.Location = New System.Drawing.Point(82, 18)
        Me.cbMonth.Name = "cbMonth"
        Me.cbMonth.Size = New System.Drawing.Size(121, 21)
        Me.cbMonth.TabIndex = 1
        '
        'btnImport
        '
        Me.btnImport.FlatAppearance.BorderSize = 0
        Me.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImport.Image = Global.La_Andaluza.My.Resources.Resources.document_save_5_32
        Me.btnImport.Location = New System.Drawing.Point(610, 276)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(97, 48)
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
        Me.btnChooseFile.Location = New System.Drawing.Point(406, 119)
        Me.btnChooseFile.Name = "btnChooseFile"
        Me.btnChooseFile.Size = New System.Drawing.Size(31, 29)
        Me.btnChooseFile.TabIndex = 4
        Me.btnChooseFile.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Mes"
        '
        'txtPath
        '
        Me.txtPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPath.Cursor = System.Windows.Forms.Cursors.No
        Me.txtPath.Enabled = False
        Me.txtPath.Location = New System.Drawing.Point(82, 124)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(319, 20)
        Me.txtPath.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Ruta (JR)"
        '
        'btnEliminar
        '
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Image = Global.La_Andaluza.My.Resources.Resources.edit_remove_3
        Me.btnEliminar.Location = New System.Drawing.Point(208, 15)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(27, 23)
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
        Me.btnManual.Location = New System.Drawing.Point(242, 15)
        Me.btnManual.Name = "btnManual"
        Me.btnManual.Size = New System.Drawing.Size(25, 23)
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
        Me.txtPath2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPath2.Cursor = System.Windows.Forms.Cursors.No
        Me.txtPath2.Enabled = False
        Me.txtPath2.Location = New System.Drawing.Point(64, 9)
        Me.txtPath2.Name = "txtPath2"
        Me.txtPath2.Size = New System.Drawing.Size(319, 20)
        Me.txtPath2.TabIndex = 6
        '
        'btnChooseFile2
        '
        Me.btnChooseFile2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChooseFile2.FlatAppearance.BorderSize = 0
        Me.btnChooseFile2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChooseFile2.Image = CType(resources.GetObject("btnChooseFile2.Image"), System.Drawing.Image)
        Me.btnChooseFile2.Location = New System.Drawing.Point(388, 3)
        Me.btnChooseFile2.Name = "btnChooseFile2"
        Me.btnChooseFile2.Size = New System.Drawing.Size(31, 29)
        Me.btnChooseFile2.TabIndex = 7
        Me.btnChooseFile2.UseVisualStyleBackColor = True
        '
        'txtPath3
        '
        Me.txtPath3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPath3.Cursor = System.Windows.Forms.Cursors.No
        Me.txtPath3.Enabled = False
        Me.txtPath3.Location = New System.Drawing.Point(82, 197)
        Me.txtPath3.Name = "txtPath3"
        Me.txtPath3.Size = New System.Drawing.Size(319, 20)
        Me.txtPath3.TabIndex = 9
        '
        'btnChooseFile3
        '
        Me.btnChooseFile3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChooseFile3.FlatAppearance.BorderSize = 0
        Me.btnChooseFile3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChooseFile3.Image = CType(resources.GetObject("btnChooseFile3.Image"), System.Drawing.Image)
        Me.btnChooseFile3.Location = New System.Drawing.Point(406, 193)
        Me.btnChooseFile3.Name = "btnChooseFile3"
        Me.btnChooseFile3.Size = New System.Drawing.Size(31, 29)
        Me.btnChooseFile3.TabIndex = 10
        Me.btnChooseFile3.UseVisualStyleBackColor = True
        '
        'txtPath4
        '
        Me.txtPath4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPath4.Cursor = System.Windows.Forms.Cursors.No
        Me.txtPath4.Enabled = False
        Me.txtPath4.Location = New System.Drawing.Point(82, 235)
        Me.txtPath4.Name = "txtPath4"
        Me.txtPath4.Size = New System.Drawing.Size(319, 20)
        Me.txtPath4.TabIndex = 12
        '
        'btnChooseFile4
        '
        Me.btnChooseFile4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChooseFile4.FlatAppearance.BorderSize = 0
        Me.btnChooseFile4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChooseFile4.Image = CType(resources.GetObject("btnChooseFile4.Image"), System.Drawing.Image)
        Me.btnChooseFile4.Location = New System.Drawing.Point(406, 230)
        Me.btnChooseFile4.Name = "btnChooseFile4"
        Me.btnChooseFile4.Size = New System.Drawing.Size(31, 29)
        Me.btnChooseFile4.TabIndex = 13
        Me.btnChooseFile4.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Ruta (JR)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(28, 201)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 13)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Ruta (VLA)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(28, 238)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 13)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Ruta (VLA)"
        '
        'err
        '
        Me.err.Image = Global.La_Andaluza.My.Resources.Resources.emblem_important_3
        Me.err.Location = New System.Drawing.Point(443, 124)
        Me.err.Name = "err"
        Me.err.Size = New System.Drawing.Size(24, 21)
        Me.err.TabIndex = 27
        Me.err.TabStop = False
        Me.err.Visible = False
        '
        'err1
        '
        Me.err1.Image = Global.La_Andaluza.My.Resources.Resources.emblem_important_3
        Me.err1.Location = New System.Drawing.Point(425, 8)
        Me.err1.Name = "err1"
        Me.err1.Size = New System.Drawing.Size(24, 21)
        Me.err1.TabIndex = 28
        Me.err1.TabStop = False
        Me.err1.Visible = False
        '
        'err2
        '
        Me.err2.Image = Global.La_Andaluza.My.Resources.Resources.emblem_important_3
        Me.err2.Location = New System.Drawing.Point(443, 197)
        Me.err2.Name = "err2"
        Me.err2.Size = New System.Drawing.Size(24, 21)
        Me.err2.TabIndex = 29
        Me.err2.TabStop = False
        Me.err2.Visible = False
        '
        'err3
        '
        Me.err3.Image = Global.La_Andaluza.My.Resources.Resources.emblem_important_3
        Me.err3.Location = New System.Drawing.Point(443, 234)
        Me.err3.Name = "err3"
        Me.err3.Size = New System.Drawing.Size(24, 21)
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
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.chbJR2)
        Me.Panel1.Controls.Add(Me.panJR2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnManual)
        Me.Panel1.Controls.Add(Me.err3)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.err2)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.err)
        Me.Panel1.Controls.Add(Me.txtPath3)
        Me.Panel1.Controls.Add(Me.btnChooseFile4)
        Me.Panel1.Controls.Add(Me.txtPath4)
        Me.Panel1.Controls.Add(Me.btnEliminar)
        Me.Panel1.Controls.Add(Me.cbMonth)
        Me.Panel1.Controls.Add(Me.btnImport)
        Me.Panel1.Controls.Add(Me.btnChooseFile)
        Me.Panel1.Controls.Add(Me.btnChooseFile3)
        Me.Panel1.Controls.Add(Me.txtPath)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(23, 10)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(734, 338)
        Me.Panel1.TabIndex = 32
        '
        'chbJR2
        '
        Me.chbJR2.AutoSize = True
        Me.chbJR2.Location = New System.Drawing.Point(31, 101)
        Me.chbJR2.Name = "chbJR2"
        Me.chbJR2.Size = New System.Drawing.Size(222, 17)
        Me.chbJR2.TabIndex = 33
        Me.chbJR2.Text = "Las ventas de JR vienen en dos archivos"
        Me.chbJR2.UseVisualStyleBackColor = True
        '
        'panJR2
        '
        Me.panJR2.Controls.Add(Me.txtPath2)
        Me.panJR2.Controls.Add(Me.btnChooseFile2)
        Me.panJR2.Controls.Add(Me.err1)
        Me.panJR2.Controls.Add(Me.Label8)
        Me.panJR2.Enabled = False
        Me.panJR2.Location = New System.Drawing.Point(18, 150)
        Me.panJR2.Name = "panJR2"
        Me.panJR2.Size = New System.Drawing.Size(461, 32)
        Me.panJR2.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(79, 258)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 9)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Si solo hay un archivo ignorar este campo"
        '
        'frmImportarExcel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 390)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MinimizeBox = False
        Me.Name = "frmImportarExcel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form1"
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.err1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.err2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.err3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.panJR2.ResumeLayout(False)
        Me.panJR2.PerformLayout()
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
    Private WithEvents btnEliminar As System.Windows.Forms.Button
    Private WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Private WithEvents ToolTip2 As System.Windows.Forms.ToolTip
    Private WithEvents txtPath2 As System.Windows.Forms.TextBox
    Private WithEvents btnChooseFile2 As System.Windows.Forms.Button
    Private WithEvents txtPath3 As System.Windows.Forms.TextBox
    Private WithEvents btnChooseFile3 As System.Windows.Forms.Button
    Private WithEvents txtPath4 As System.Windows.Forms.TextBox
    Private WithEvents btnChooseFile4 As System.Windows.Forms.Button
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
    Friend WithEvents panJR2 As System.Windows.Forms.Panel
    Private WithEvents chbJR2 As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
