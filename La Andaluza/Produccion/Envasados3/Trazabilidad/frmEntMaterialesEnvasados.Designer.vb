<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntMaterialesEnvasados
    Inherits BasesParaCompatibilidad.DetailedSimpleForm

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
        Me.dtpHoraInicio = New System.Windows.Forms.DateTimePicker()
        Me.dtpHoraFin = New System.Windows.Forms.DateTimePicker()
        Me.txtObservaciones = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtLote = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtCantidad = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.cboTipoMaterial = New System.Windows.Forms.ComboBox()
        Me.butVerTipoMaterialID = New System.Windows.Forms.Button()
        Me.butAddTipoMaterialID = New System.Windows.Forms.Button()
        Me.cboProveedor = New System.Windows.Forms.ComboBox()
        Me.butVerProveedorID = New System.Windows.Forms.Button()
        Me.butAddProveedorID = New System.Windows.Forms.Button()
        Me.cboFormatoEnvasado = New System.Windows.Forms.ComboBox()
        Me.butVerFormatoEnvasadoID = New System.Windows.Forms.Button()
        Me.butAddFormatoEnvasadoID = New System.Windows.Forms.Button()
        Me.lblHoraInicio = New System.Windows.Forms.Label
        Me.lblHoraFin = New System.Windows.Forms.Label
        Me.lblObservaciones = New System.Windows.Forms.Label
        Me.lblLote = New System.Windows.Forms.Label
        Me.lblCantidad = New System.Windows.Forms.Label
        Me.lblTipoMaterialID = New System.Windows.Forms.Label
        Me.lblProveedorID = New System.Windows.Forms.Label
        Me.lblFormatoEnvasadoID = New System.Windows.Forms.Label
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel
        Me.tlpMiddle.SuspendLayout()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpHoraInicio
        '
        Me.dtpHoraInicio.Dock = System.Windows.Forms.DockStyle.None
        Me.dtpHoraInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHoraInicio.Name = "dtpHoraInicio"
        Me.dtpHoraInicio.TabIndex = 0
        Me.dtpHoraInicio.BackColor = System.Drawing.SystemColors.Window
        Me.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHoraInicio.ShowUpDown = True
        Me.dtpHoraInicio.Size = New System.Drawing.Size(95, 21)
        '
        'dtpHoraFin
        '
        Me.dtpHoraFin.Dock = System.Windows.Forms.DockStyle.None
        Me.dtpHoraFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHoraFin.Name = "dtpHoraFin"
        Me.dtpHoraFin.TabIndex = 1
        Me.dtpHoraFin.BackColor = System.Drawing.SystemColors.Window
        Me.dtpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHoraFin.ShowUpDown = True
        Me.dtpHoraFin.Size = New System.Drawing.Size(95, 21)
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.TabIndex = 2
        Me.txtObservaciones.BackColor = System.Drawing.SystemColors.Window
        Me.txtObservaciones.MaxLength = 500
        Me.txtObservaciones.Size = New System.Drawing.Size(280, 42)
        Me.tlpMiddle.SetColumnSpan(Me.txtObservaciones, 4)
        '
        'txtLote
        '
        Me.txtLote.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLote.Name = "txtLote"
        Me.txtLote.TabIndex = 3
        Me.txtLote.BackColor = System.Drawing.SystemColors.Window
        Me.txtLote.MaxLength = 100
        Me.txtLote.Size = New System.Drawing.Size(200, 42)
        '
        'txtCantidad
        '
        Me.txtCantidad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.TabIndex = 4
        Me.txtCantidad.BackColor = System.Drawing.SystemColors.Window
        Me.txtCantidad.MaxLength = 9
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCantidad.Size = New System.Drawing.Size(56, 21)
        '
        'cboTipoMaterial
        '
        Me.cboTipoMaterial.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboTipoMaterial.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTipoMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.cboTipoMaterial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboTipoMaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoMaterial.Name = "cboTipoMaterial"
        Me.cboTipoMaterial.TabIndex = 5
        Me.cboTipoMaterial.Size = New System.Drawing.Size(200, 21)
        '
        'butVerTipoMaterialID
        '
        Me.butVerTipoMaterialID.Dock = System.Windows.Forms.DockStyle.None
        Me.butVerTipoMaterialID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerTipoMaterialID.Name = "butVerTipoMaterialID"
        Me.butVerTipoMaterialID.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerTipoMaterialID.TabStop = False
        Me.butVerTipoMaterialID.Size = New System.Drawing.Size(20, 20)
        'butAddTipoMaterialID
        '
        Me.butAddTipoMaterialID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butAddTipoMaterialID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddTipoMaterialID.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddTipoMaterialID.Name = "butAddTipoMaterialID"
        Me.butAddTipoMaterialID.TabStop = False
        Me.butAddTipoMaterialID.Size = New System.Drawing.Size(20, 20)
        '
        '
        'cboProveedor
        '
        Me.cboProveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboProveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.cboProveedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProveedor.Name = "cboProveedor"
        Me.cboProveedor.TabIndex = 6
        Me.cboProveedor.Size = New System.Drawing.Size(200, 21)
        '
        'butVerProveedorID
        '
        Me.butVerProveedorID.Dock = System.Windows.Forms.DockStyle.None
        Me.butVerProveedorID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerProveedorID.Name = "butVerProveedorID"
        Me.butVerProveedorID.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerProveedorID.TabStop = False
        Me.butVerProveedorID.Size = New System.Drawing.Size(20, 20)
        'butAddProveedorID
        '
        Me.butAddProveedorID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butAddProveedorID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddProveedorID.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddProveedorID.Name = "butAddProveedorID"
        Me.butAddProveedorID.TabStop = False
        Me.butAddProveedorID.Size = New System.Drawing.Size(20, 20)
        '
        '
        'cboFormatoEnvasado
        '
        Me.cboFormatoEnvasado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboFormatoEnvasado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboFormatoEnvasado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.cboFormatoEnvasado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboFormatoEnvasado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFormatoEnvasado.Name = "cboFormatoEnvasado"
        Me.cboFormatoEnvasado.TabIndex = 7
        Me.cboFormatoEnvasado.Size = New System.Drawing.Size(200, 21)
        '
        'butVerFormatoEnvasadoID
        '
        Me.butVerFormatoEnvasadoID.Dock = System.Windows.Forms.DockStyle.None
        Me.butVerFormatoEnvasadoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerFormatoEnvasadoID.Name = "butVerFormatoEnvasadoID"
        Me.butVerFormatoEnvasadoID.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerFormatoEnvasadoID.TabStop = False
        Me.butVerFormatoEnvasadoID.Size = New System.Drawing.Size(20, 20)
        'butAddFormatoEnvasadoID
        '
        Me.butAddFormatoEnvasadoID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butAddFormatoEnvasadoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddFormatoEnvasadoID.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddFormatoEnvasadoID.Name = "butAddFormatoEnvasadoID"
        Me.butAddFormatoEnvasadoID.TabStop = False
        Me.butAddFormatoEnvasadoID.Size = New System.Drawing.Size(20, 20)
        '
        '
        'lblHoraInicio
        '
        Me.lblHoraInicio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblHoraInicio.Name = "lblHoraInicio"
        Me.lblHoraInicio.Text = "HoraInicio"
        Me.lblHoraInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblHoraInicio.Size = New System.Drawing.Size(110, 21)
        Me.lblHoraInicio.Location = New System.Drawing.Point(20, 40)
        '
        'lblHoraFin
        '
        Me.lblHoraFin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblHoraFin.Name = "lblHoraFin"
        Me.lblHoraFin.Text = "HoraFin"
        Me.lblHoraFin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblHoraFin.Size = New System.Drawing.Size(110, 21)
        Me.lblHoraFin.Location = New System.Drawing.Point(20, 40)
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblObservaciones.Size = New System.Drawing.Size(110, 21)
        Me.lblObservaciones.Location = New System.Drawing.Point(20, 40)
        '
        'lblLote
        '
        Me.lblLote.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblLote.Name = "lblLote"
        Me.lblLote.Text = "Lote"
        Me.lblLote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblLote.Size = New System.Drawing.Size(110, 21)
        Me.lblLote.Location = New System.Drawing.Point(20, 40)
        '
        'lblCantidad
        '
        Me.lblCantidad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Text = "Cantidad"
        Me.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCantidad.Size = New System.Drawing.Size(110, 21)
        Me.lblCantidad.Location = New System.Drawing.Point(20, 40)
        '
        'lblTipoMaterialID
        '
        Me.lblTipoMaterialID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTipoMaterialID.Name = "lblTipoMaterialID"
        Me.lblTipoMaterialID.Text = "TipoMaterial"
        Me.lblTipoMaterialID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTipoMaterialID.Size = New System.Drawing.Size(110, 21)
        Me.lblTipoMaterialID.Location = New System.Drawing.Point(20, 40)
        '
        'lblProveedorID
        '
        Me.lblProveedorID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblProveedorID.Name = "lblProveedorID"
        Me.lblProveedorID.Text = "Proveedor"
        Me.lblProveedorID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblProveedorID.Size = New System.Drawing.Size(110, 21)
        Me.lblProveedorID.Location = New System.Drawing.Point(20, 40)
        '
        'lblFormatoEnvasadoID
        '
        Me.lblFormatoEnvasadoID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblFormatoEnvasadoID.Name = "lblFormatoEnvasadoID"
        Me.lblFormatoEnvasadoID.Text = "FormatoEnvasado"
        Me.lblFormatoEnvasadoID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblFormatoEnvasadoID.Size = New System.Drawing.Size(110, 21)
        Me.lblFormatoEnvasadoID.Location = New System.Drawing.Point(20, 40)
        '
        'tlpMiddle
        '
        Me.tlpMiddle.ColumnCount = 8
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMiddle.Controls.Add(Me.lblHoraInicio, 1, 0)
        Me.tlpMiddle.Controls.Add(Me.dtpHoraInicio, 2, 0)
        Me.tlpMiddle.Controls.Add(Me.lblHoraFin, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.dtpHoraFin, 2, 1)
        Me.tlpMiddle.Controls.Add(Me.lblObservaciones, 1, 2)
        Me.tlpMiddle.Controls.Add(Me.txtObservaciones, 2, 2)
        Me.tlpMiddle.Controls.Add(Me.lblLote, 1, 3)
        Me.tlpMiddle.Controls.Add(Me.txtLote, 2, 3)
        Me.tlpMiddle.Controls.Add(Me.lblCantidad, 1, 4)
        Me.tlpMiddle.Controls.Add(Me.txtCantidad, 2, 4)
        Me.tlpMiddle.Controls.Add(Me.lblTipoMaterialID, 1, 5)
        Me.tlpMiddle.Controls.Add(Me.cboTipoMaterial, 2, 5)
        Me.tlpMiddle.Controls.Add(Me.butVerTipoMaterialID, 3, 5)
        Me.tlpMiddle.Controls.Add(Me.butAddTipoMaterialID, 4, 5)
        Me.tlpMiddle.Controls.Add(Me.lblProveedorID, 1, 6)
        Me.tlpMiddle.Controls.Add(Me.cboProveedor, 2, 6)
        Me.tlpMiddle.Controls.Add(Me.butVerProveedorID, 3, 6)
        Me.tlpMiddle.Controls.Add(Me.butAddProveedorID, 4, 6)
        Me.tlpMiddle.Controls.Add(Me.lblFormatoEnvasadoID, 1, 7)
        Me.tlpMiddle.Controls.Add(Me.cboFormatoEnvasado, 2, 7)
        Me.tlpMiddle.Controls.Add(Me.butVerFormatoEnvasadoID, 3, 7)
        Me.tlpMiddle.Controls.Add(Me.butAddFormatoEnvasadoID, 4, 7)
        Me.tlpMiddle.Location = New System.Drawing.Point(0, 25)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.RowCount = 9
        Me.tlpMiddle.Padding = New System.Windows.Forms.Padding(0, 15, 0, 0)
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(469, 222)
        '
        'tlpTop
        '




        '
        'frmEntMaterialesEnvasados
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Controls.Add(Me.tlpMiddle)
        Me.ClientSize = New System.Drawing.Size(469, 302)
        Me.MinimumSize = New System.Drawing.Size(469, 302)
        Me.Name = "frmEntMaterialesEnvasados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "MaterialesEnvasados"
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMiddle.PerformLayout()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents dtpHoraInicio As System.Windows.Forms.DateTimePicker
    Private WithEvents dtpHoraFin As System.Windows.Forms.DateTimePicker
    Private WithEvents txtObservaciones As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtLote As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtCantidad As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents cboTipoMaterial As System.Windows.Forms.ComboBox
    Private WithEvents butVerTipoMaterialID As System.Windows.Forms.Button
    Private WithEvents butAddTipoMaterialID As System.Windows.Forms.Button
    Private WithEvents cboProveedor As System.Windows.Forms.ComboBox
    Private WithEvents butVerProveedorID As System.Windows.Forms.Button
    Private WithEvents butAddProveedorID As System.Windows.Forms.Button
    Private WithEvents cboFormatoEnvasado As System.Windows.Forms.ComboBox
    Private WithEvents butVerFormatoEnvasadoID As System.Windows.Forms.Button
    Private WithEvents butAddFormatoEnvasadoID As System.Windows.Forms.Button
    Private WithEvents lblHoraInicio As System.Windows.Forms.Label
    Private WithEvents lblHoraFin As System.Windows.Forms.Label
    Private WithEvents lblObservaciones As System.Windows.Forms.Label
    Private WithEvents lblLote As System.Windows.Forms.Label
    Private WithEvents lblCantidad As System.Windows.Forms.Label
    Private WithEvents lblTipoMaterialID As System.Windows.Forms.Label
    Private WithEvents lblProveedorID As System.Windows.Forms.Label
    Private WithEvents lblFormatoEnvasadoID As System.Windows.Forms.Label
    Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel

End Class
