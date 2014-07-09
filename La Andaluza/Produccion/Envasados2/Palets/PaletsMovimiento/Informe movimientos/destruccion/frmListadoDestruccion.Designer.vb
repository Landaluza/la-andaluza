<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadoDestruccion
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
        Me.panFiltros = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tpfFinal = New System.Windows.Forms.DateTimePicker()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbfFinal = New System.Windows.Forms.CheckBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.tpfInicial = New System.Windows.Forms.DateTimePicker()
        Me.pantitulo = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbfInicial = New System.Windows.Forms.CheckBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.cbMovimiento = New System.Windows.Forms.CheckBox()
        Me.cbArticulo = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboMovimiento = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboArticulo = New System.Windows.Forms.ComboBox()
        Me.PanDgv = New System.Windows.Forms.Panel()
        Me.dgvListado = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.panFiltros.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.pantitulo.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.PanDgv.SuspendLayout()
        CType(Me.dgvListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panFiltros
        '
        Me.panFiltros.Controls.Add(Me.Panel1)
        Me.panFiltros.Controls.Add(Me.Panel4)
        Me.panFiltros.Controls.Add(Me.Panel7)
        Me.panFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.panFiltros.Location = New System.Drawing.Point(0, 0)
        Me.panFiltros.Name = "panFiltros"
        Me.panFiltros.Size = New System.Drawing.Size(905, 132)
        Me.panFiltros.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.tpfFinal)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(731, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(174, 56)
        Me.Panel1.TabIndex = 10
        '
        'tpfFinal
        '
        Me.tpfFinal.CustomFormat = "yyyy/MM/dd"
        Me.tpfFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tpfFinal.Location = New System.Drawing.Point(59, 23)
        Me.tpfFinal.Name = "tpfFinal"
        Me.tpfFinal.Size = New System.Drawing.Size(95, 22)
        Me.tpfFinal.TabIndex = 0
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Controls.Add(Me.cbfFinal)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(174, 17)
        Me.Panel6.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(18, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha final"
        '
        'cbfFinal
        '
        Me.cbfFinal.AutoSize = True
        Me.cbfFinal.Dock = System.Windows.Forms.DockStyle.Left
        Me.cbfFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbfFinal.Location = New System.Drawing.Point(0, 0)
        Me.cbfFinal.Name = "cbfFinal"
        Me.cbfFinal.Size = New System.Drawing.Size(18, 17)
        Me.cbfFinal.TabIndex = 0
        Me.cbfFinal.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.tpfInicial)
        Me.Panel4.Controls.Add(Me.pantitulo)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(210, 56)
        Me.Panel4.TabIndex = 9
        '
        'tpfInicial
        '
        Me.tpfInicial.CustomFormat = "yyyy/MM/dd"
        Me.tpfInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tpfInicial.Location = New System.Drawing.Point(62, 23)
        Me.tpfInicial.Name = "tpfInicial"
        Me.tpfInicial.Size = New System.Drawing.Size(95, 22)
        Me.tpfInicial.TabIndex = 0
        '
        'pantitulo
        '
        Me.pantitulo.Controls.Add(Me.Label1)
        Me.pantitulo.Controls.Add(Me.cbfInicial)
        Me.pantitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pantitulo.Location = New System.Drawing.Point(0, 0)
        Me.pantitulo.Name = "pantitulo"
        Me.pantitulo.Size = New System.Drawing.Size(210, 17)
        Me.pantitulo.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(18, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Fecha Inicial"
        '
        'cbfInicial
        '
        Me.cbfInicial.AutoSize = True
        Me.cbfInicial.Dock = System.Windows.Forms.DockStyle.Left
        Me.cbfInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbfInicial.Location = New System.Drawing.Point(0, 0)
        Me.cbfInicial.Name = "cbfInicial"
        Me.cbfInicial.Size = New System.Drawing.Size(18, 17)
        Me.cbfInicial.TabIndex = 0
        Me.cbfInicial.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.cbMovimiento)
        Me.Panel7.Controls.Add(Me.cbArticulo)
        Me.Panel7.Controls.Add(Me.Label4)
        Me.Panel7.Controls.Add(Me.cboMovimiento)
        Me.Panel7.Controls.Add(Me.Label3)
        Me.Panel7.Controls.Add(Me.cboArticulo)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(0, 56)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(905, 76)
        Me.Panel7.TabIndex = 0
        '
        'cbMovimiento
        '
        Me.cbMovimiento.AutoSize = True
        Me.cbMovimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMovimiento.Location = New System.Drawing.Point(3, 47)
        Me.cbMovimiento.Name = "cbMovimiento"
        Me.cbMovimiento.Size = New System.Drawing.Size(18, 17)
        Me.cbMovimiento.TabIndex = 3
        Me.cbMovimiento.UseVisualStyleBackColor = True
        '
        'cbArticulo
        '
        Me.cbArticulo.AutoSize = True
        Me.cbArticulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbArticulo.Location = New System.Drawing.Point(3, 17)
        Me.cbArticulo.Name = "cbArticulo"
        Me.cbArticulo.Size = New System.Drawing.Size(18, 17)
        Me.cbArticulo.TabIndex = 0
        Me.cbArticulo.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Movimiento"
        '
        'cboMovimiento
        '
        Me.cboMovimiento.FormattingEnabled = True
        Me.cboMovimiento.Location = New System.Drawing.Point(115, 42)
        Me.cboMovimiento.Name = "cboMovimiento"
        Me.cboMovimiento.Size = New System.Drawing.Size(770, 24)
        Me.cboMovimiento.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Articulo"
        '
        'cboArticulo
        '
        Me.cboArticulo.FormattingEnabled = True
        Me.cboArticulo.Location = New System.Drawing.Point(115, 12)
        Me.cboArticulo.Name = "cboArticulo"
        Me.cboArticulo.Size = New System.Drawing.Size(770, 24)
        Me.cboArticulo.TabIndex = 2
        '
        'PanDgv
        '
        Me.PanDgv.Controls.Add(Me.dgvListado)
        Me.PanDgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanDgv.Location = New System.Drawing.Point(0, 132)
        Me.PanDgv.Name = "PanDgv"
        Me.PanDgv.Size = New System.Drawing.Size(905, 464)
        Me.PanDgv.TabIndex = 1
        '
        'dgvListado
        '
        Me.dgvListado.AllowUserToAddRows = False
        Me.dgvListado.AllowUserToDeleteRows = False
        Me.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListado.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgvListado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvListado.Location = New System.Drawing.Point(0, 0)
        Me.dgvListado.Name = "dgvListado"
        Me.dgvListado.ReadOnly = True
        Me.dgvListado.RowHeadersVisible = False
        Me.dgvListado.RowTemplate.Height = 24
        Me.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListado.Size = New System.Drawing.Size(905, 464)
        Me.dgvListado.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImprimirToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(153, 50)
        '
        'ImprimirToolStripMenuItem
        '
        Me.ImprimirToolStripMenuItem.Image = Global.La_Andaluza.My.Resources.Resources.imprimir_16
        Me.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        Me.ImprimirToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.ImprimirToolStripMenuItem.Text = "Imprimir"
        '
        'frmListadoDestruccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(905, 596)
        Me.Controls.Add(Me.PanDgv)
        Me.Controls.Add(Me.panFiltros)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MinimizeBox = False
        Me.Name = "frmListadoDestruccion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmListadoDestruccion"
        Me.panFiltros.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.pantitulo.ResumeLayout(False)
        Me.pantitulo.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.PanDgv.ResumeLayout(False)
        CType(Me.dgvListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents panFiltros As System.Windows.Forms.Panel
    Private WithEvents PanDgv As System.Windows.Forms.Panel
    Private WithEvents dgvListado As System.Windows.Forms.DataGridView
    Private WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents cbfFinal As System.Windows.Forms.CheckBox
    Private WithEvents Panel6 As System.Windows.Forms.Panel
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents Panel4 As System.Windows.Forms.Panel
    Private WithEvents tpfInicial As System.Windows.Forms.DateTimePicker
    Private WithEvents cbfInicial As System.Windows.Forms.CheckBox
    Private WithEvents pantitulo As System.Windows.Forms.Panel
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents Panel7 As System.Windows.Forms.Panel
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents cboMovimiento As System.Windows.Forms.ComboBox
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents cboArticulo As System.Windows.Forms.ComboBox
    Private WithEvents tpfFinal As System.Windows.Forms.DateTimePicker
    Private WithEvents cbMovimiento As System.Windows.Forms.CheckBox
    Private WithEvents cbArticulo As System.Windows.Forms.CheckBox
    Private WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Private WithEvents ImprimirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
