<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntPartesTrabajosDiariosMaestros
    Inherits BasesParaCompatibilidad.FrmAheredarEntOld

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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cboEmpleadoID = New System.Windows.Forms.ComboBox()
        Me.butVerEmpleadoID = New System.Windows.Forms.Button()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtObservaciones = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblEmpleadoID = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tbpTareas = New System.Windows.Forms.TabPage()
        Me.panTareas = New System.Windows.Forms.Panel()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMiddle.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tbpTareas.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTodoCorrecto
        '
        Me.txtTodoCorrecto.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        '
        'cboEmpleadoID
        '
        Me.cboEmpleadoID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboEmpleadoID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.tlpMiddle.SetColumnSpan(Me.cboEmpleadoID, 4)
        Me.cboEmpleadoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEmpleadoID.Location = New System.Drawing.Point(240, 4)
        Me.cboEmpleadoID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboEmpleadoID.Name = "cboEmpleadoID"
        Me.cboEmpleadoID.Size = New System.Drawing.Size(597, 26)
        Me.cboEmpleadoID.TabIndex = 1
        '
        'butVerEmpleadoID
        '
        Me.butVerEmpleadoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerEmpleadoID.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerEmpleadoID.Location = New System.Drawing.Point(879, 4)
        Me.butVerEmpleadoID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.butVerEmpleadoID.Name = "butVerEmpleadoID"
        Me.butVerEmpleadoID.Size = New System.Drawing.Size(27, 25)
        Me.butVerEmpleadoID.TabIndex = 2
        Me.butVerEmpleadoID.TabStop = False
        '
        'dtpFecha
        '
        Me.dtpFecha.BackColor = System.Drawing.SystemColors.Window
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(240, 38)
        Me.dtpFecha.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(125, 24)
        Me.dtpFecha.TabIndex = 2
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.SystemColors.Window
        Me.tlpMiddle.SetColumnSpan(Me.txtObservaciones, 4)
        Me.txtObservaciones.EsUnicoCampo = ""
        Me.txtObservaciones.EsUnicoCampoID = ""
        Me.txtObservaciones.EsUnicoID = 0
        Me.txtObservaciones.EsUnicoTabla = ""
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(240, 70)
        Me.txtObservaciones.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtObservaciones.MaxLength = 500
        Me.txtObservaciones.Minimo = 0
        Me.txtObservaciones.Modificado = False
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Numerico_EsNumerico = False
        Me.txtObservaciones.Numerico_NumeroDoublees = 0
        Me.txtObservaciones.Numerico_SeparadorMiles = False
        Me.txtObservaciones.Obligatorio = False
        Me.txtObservaciones.ParametroID = 0
        Me.txtObservaciones.Size = New System.Drawing.Size(631, 24)
        Me.txtObservaciones.TabIndex = 3
        Me.txtObservaciones.ValorMaximo = 0.0!
        Me.txtObservaciones.ValorMinimo = 0.0!
        '
        'lblEmpleadoID
        '
        Me.lblEmpleadoID.Location = New System.Drawing.Point(20, 0)
        Me.lblEmpleadoID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmpleadoID.Name = "lblEmpleadoID"
        Me.lblEmpleadoID.Size = New System.Drawing.Size(212, 26)
        Me.lblEmpleadoID.TabIndex = 1
        Me.lblEmpleadoID.Text = "Empleado"
        Me.lblEmpleadoID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFecha
        '
        Me.lblFecha.Location = New System.Drawing.Point(20, 34)
        Me.lblFecha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(212, 26)
        Me.lblFecha.TabIndex = 3
        Me.lblFecha.Text = "Fecha"
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Location = New System.Drawing.Point(20, 66)
        Me.lblObservaciones.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(212, 26)
        Me.lblObservaciones.TabIndex = 4
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpMiddle
        '
        Me.tlpMiddle.ColumnCount = 8
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 216.0!))
        Me.tlpMiddle.Controls.Add(Me.lblEmpleadoID, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.cboEmpleadoID, 2, 1)
        Me.tlpMiddle.Controls.Add(Me.lblFecha, 1, 2)
        Me.tlpMiddle.Controls.Add(Me.dtpFecha, 2, 2)
        Me.tlpMiddle.Controls.Add(Me.lblObservaciones, 1, 3)
        Me.tlpMiddle.Controls.Add(Me.txtObservaciones, 2, 3)
        Me.tlpMiddle.Controls.Add(Me.butVerEmpleadoID, 7, 1)
        Me.tlpMiddle.Location = New System.Drawing.Point(0, 49)
        Me.tlpMiddle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.RowCount = 5
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(917, 135)
        Me.tlpMiddle.TabIndex = 1000000001
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tbpTareas)
        Me.TabControl1.Location = New System.Drawing.Point(0, 192)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1184, 638)
        Me.TabControl1.TabIndex = 1000000002
        '
        'tbpTareas
        '
        Me.tbpTareas.Controls.Add(Me.panTareas)
        Me.tbpTareas.Location = New System.Drawing.Point(4, 25)
        Me.tbpTareas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbpTareas.Name = "tbpTareas"
        Me.tbpTareas.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbpTareas.Size = New System.Drawing.Size(1176, 609)
        Me.tbpTareas.TabIndex = 0
        Me.tbpTareas.Text = "Tareas"
        Me.tbpTareas.UseVisualStyleBackColor = True
        '
        'panTareas
        '
        Me.panTareas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panTareas.Location = New System.Drawing.Point(4, 4)
        Me.panTareas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.panTareas.Name = "panTareas"
        Me.panTareas.Size = New System.Drawing.Size(1168, 601)
        Me.panTareas.TabIndex = 0
        '
        'frmEntPartesTrabajosDiariosMaestros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(1184, 830)
        Me.Controls.Add(Me.tlpMiddle)
        Me.Controls.Add(Me.TabControl1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmEntPartesTrabajosDiariosMaestros"
        Me.Text = "PartesTrabajosDiariosMaestros"
        Me.Controls.SetChildIndex(Me.TabControl1, 0)
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        Me.Controls.SetChildIndex(Me.txtTodoCorrecto, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tbpTareas.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

   Private WithEvents tbpTareas As System.Windows.Forms.TabPage
    Private WithEvents cboEmpleadoID As System.Windows.Forms.ComboBox
    Private WithEvents butVerEmpleadoID As System.Windows.Forms.Button
    Private WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Private WithEvents txtObservaciones As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents lblEmpleadoID As System.Windows.Forms.Label
    Private WithEvents lblFecha As System.Windows.Forms.Label
    Private WithEvents lblObservaciones As System.Windows.Forms.Label
    Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel
    Private WithEvents TabControl1 As System.Windows.Forms.TabControl
    Private WithEvents panTareas As System.Windows.Forms.Panel
End Class
