<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModDetExtras
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tbpFichasTecnicas = New System.Windows.Forms.TabPage()
        Me.tbpFichasCondiciones = New System.Windows.Forms.TabPage()
        Me.tbpFichasSeguridad = New System.Windows.Forms.TabPage()
        Me.tbpImagen = New System.Windows.Forms.TabPage()
        Me.tbpProveedores = New System.Windows.Forms.TabPage()
        Me.tbpPedidos = New System.Windows.Forms.TabPage()
        Me.dgvPedidos = New System.Windows.Forms.DataGridView()
        Me.tbpStocks = New System.Windows.Forms.TabPage()
        Me.tbpDocumentacion = New System.Windows.Forms.TabPage()
        Me.tbpLegislacion = New System.Windows.Forms.TabPage()
        Me.tbpProductos = New System.Windows.Forms.TabPage()
        Me.tbpNoConformidades = New System.Windows.Forms.TabPage()
        Me.tbpRetenidos = New System.Windows.Forms.TabPage()
        Me.tbpEvolucionPrecios = New System.Windows.Forms.TabPage()
        Me.tbpGestionesCompra = New System.Windows.Forms.TabPage()
        Me.tpComposicion = New System.Windows.Forms.TabPage()
        Me.panComposicion = New System.Windows.Forms.Panel()
        Me.TimerAutorizacion = New System.Windows.Forms.Timer(Me.components)
        Me.tpAvisos = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.tbpPedidos.SuspendLayout()
        CType(Me.dgvPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpComposicion.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tbpFichasTecnicas)
        Me.TabControl1.Controls.Add(Me.tbpFichasCondiciones)
        Me.TabControl1.Controls.Add(Me.tbpFichasSeguridad)
        Me.TabControl1.Controls.Add(Me.tbpImagen)
        Me.TabControl1.Controls.Add(Me.tbpProveedores)
        Me.TabControl1.Controls.Add(Me.tbpPedidos)
        Me.TabControl1.Controls.Add(Me.tbpStocks)
        Me.TabControl1.Controls.Add(Me.tbpDocumentacion)
        Me.TabControl1.Controls.Add(Me.tbpLegislacion)
        Me.TabControl1.Controls.Add(Me.tbpProductos)
        Me.TabControl1.Controls.Add(Me.tbpNoConformidades)
        Me.TabControl1.Controls.Add(Me.tbpRetenidos)
        Me.TabControl1.Controls.Add(Me.tbpEvolucionPrecios)
        Me.TabControl1.Controls.Add(Me.tbpGestionesCompra)
        Me.TabControl1.Controls.Add(Me.tpComposicion)
        Me.TabControl1.Controls.Add(Me.tpAvisos)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1213, 513)
        Me.TabControl1.TabIndex = 1000000004
        '
        'tbpFichasTecnicas
        '
        Me.tbpFichasTecnicas.BackColor = System.Drawing.SystemColors.Control
        Me.tbpFichasTecnicas.Location = New System.Drawing.Point(4, 22)
        Me.tbpFichasTecnicas.Name = "tbpFichasTecnicas"
        Me.tbpFichasTecnicas.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tbpFichasTecnicas.Size = New System.Drawing.Size(1205, 487)
        Me.tbpFichasTecnicas.TabIndex = 0
        Me.tbpFichasTecnicas.Text = "Fichas técnicas"
        '
        'tbpFichasCondiciones
        '
        Me.tbpFichasCondiciones.Location = New System.Drawing.Point(4, 22)
        Me.tbpFichasCondiciones.Name = "tbpFichasCondiciones"
        Me.tbpFichasCondiciones.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tbpFichasCondiciones.Size = New System.Drawing.Size(831, 487)
        Me.tbpFichasCondiciones.TabIndex = 1
        Me.tbpFichasCondiciones.Text = "Fichas condiciones"
        Me.tbpFichasCondiciones.UseVisualStyleBackColor = True
        '
        'tbpFichasSeguridad
        '
        Me.tbpFichasSeguridad.Location = New System.Drawing.Point(4, 22)
        Me.tbpFichasSeguridad.Name = "tbpFichasSeguridad"
        Me.tbpFichasSeguridad.Size = New System.Drawing.Size(831, 487)
        Me.tbpFichasSeguridad.TabIndex = 2
        Me.tbpFichasSeguridad.Text = "Fichas seguridad"
        Me.tbpFichasSeguridad.UseVisualStyleBackColor = True
        '
        'tbpImagen
        '
        Me.tbpImagen.Location = New System.Drawing.Point(4, 22)
        Me.tbpImagen.Name = "tbpImagen"
        Me.tbpImagen.Size = New System.Drawing.Size(831, 487)
        Me.tbpImagen.TabIndex = 5
        Me.tbpImagen.Text = "Imagen"
        Me.tbpImagen.UseVisualStyleBackColor = True
        '
        'tbpProveedores
        '
        Me.tbpProveedores.Location = New System.Drawing.Point(4, 22)
        Me.tbpProveedores.Name = "tbpProveedores"
        Me.tbpProveedores.Size = New System.Drawing.Size(831, 487)
        Me.tbpProveedores.TabIndex = 3
        Me.tbpProveedores.Text = "Proveedores"
        Me.tbpProveedores.UseVisualStyleBackColor = True
        '
        'tbpPedidos
        '
        Me.tbpPedidos.Controls.Add(Me.dgvPedidos)
        Me.tbpPedidos.Location = New System.Drawing.Point(4, 22)
        Me.tbpPedidos.Name = "tbpPedidos"
        Me.tbpPedidos.Size = New System.Drawing.Size(831, 487)
        Me.tbpPedidos.TabIndex = 13
        Me.tbpPedidos.Text = "Pedidos"
        Me.tbpPedidos.UseVisualStyleBackColor = True
        '
        'dgvPedidos
        '
        Me.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPedidos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPedidos.Location = New System.Drawing.Point(0, 0)
        Me.dgvPedidos.Name = "dgvPedidos"
        Me.dgvPedidos.RowTemplate.Height = 24
        Me.dgvPedidos.Size = New System.Drawing.Size(831, 487)
        Me.dgvPedidos.TabIndex = 0
        '
        'tbpStocks
        '
        Me.tbpStocks.Location = New System.Drawing.Point(4, 22)
        Me.tbpStocks.Name = "tbpStocks"
        Me.tbpStocks.Size = New System.Drawing.Size(831, 487)
        Me.tbpStocks.TabIndex = 4
        Me.tbpStocks.Text = "Stocks"
        Me.tbpStocks.UseVisualStyleBackColor = True
        '
        'tbpDocumentacion
        '
        Me.tbpDocumentacion.Location = New System.Drawing.Point(4, 22)
        Me.tbpDocumentacion.Name = "tbpDocumentacion"
        Me.tbpDocumentacion.Size = New System.Drawing.Size(831, 487)
        Me.tbpDocumentacion.TabIndex = 6
        Me.tbpDocumentacion.Text = "Documentación"
        Me.tbpDocumentacion.UseVisualStyleBackColor = True
        '
        'tbpLegislacion
        '
        Me.tbpLegislacion.Location = New System.Drawing.Point(4, 22)
        Me.tbpLegislacion.Name = "tbpLegislacion"
        Me.tbpLegislacion.Size = New System.Drawing.Size(831, 487)
        Me.tbpLegislacion.TabIndex = 7
        Me.tbpLegislacion.Text = "Legislacion aplicable"
        Me.tbpLegislacion.UseVisualStyleBackColor = True
        '
        'tbpProductos
        '
        Me.tbpProductos.Location = New System.Drawing.Point(4, 22)
        Me.tbpProductos.Name = "tbpProductos"
        Me.tbpProductos.Size = New System.Drawing.Size(831, 487)
        Me.tbpProductos.TabIndex = 8
        Me.tbpProductos.Text = "Productos en los que se usa"
        Me.tbpProductos.UseVisualStyleBackColor = True
        '
        'tbpNoConformidades
        '
        Me.tbpNoConformidades.Location = New System.Drawing.Point(4, 22)
        Me.tbpNoConformidades.Name = "tbpNoConformidades"
        Me.tbpNoConformidades.Size = New System.Drawing.Size(831, 487)
        Me.tbpNoConformidades.TabIndex = 9
        Me.tbpNoConformidades.Text = "No Conformidades"
        Me.tbpNoConformidades.UseVisualStyleBackColor = True
        '
        'tbpRetenidos
        '
        Me.tbpRetenidos.Location = New System.Drawing.Point(4, 22)
        Me.tbpRetenidos.Name = "tbpRetenidos"
        Me.tbpRetenidos.Size = New System.Drawing.Size(831, 487)
        Me.tbpRetenidos.TabIndex = 10
        Me.tbpRetenidos.Text = "Retenidos"
        Me.tbpRetenidos.UseVisualStyleBackColor = True
        '
        'tbpEvolucionPrecios
        '
        Me.tbpEvolucionPrecios.Location = New System.Drawing.Point(4, 22)
        Me.tbpEvolucionPrecios.Name = "tbpEvolucionPrecios"
        Me.tbpEvolucionPrecios.Size = New System.Drawing.Size(831, 487)
        Me.tbpEvolucionPrecios.TabIndex = 11
        Me.tbpEvolucionPrecios.Text = "Evolucion precios"
        Me.tbpEvolucionPrecios.UseVisualStyleBackColor = True
        '
        'tbpGestionesCompra
        '
        Me.tbpGestionesCompra.Location = New System.Drawing.Point(4, 22)
        Me.tbpGestionesCompra.Name = "tbpGestionesCompra"
        Me.tbpGestionesCompra.Size = New System.Drawing.Size(831, 487)
        Me.tbpGestionesCompra.TabIndex = 12
        Me.tbpGestionesCompra.Text = "Gestiones compra"
        Me.tbpGestionesCompra.UseVisualStyleBackColor = True
        '
        'tpComposicion
        '
        Me.tpComposicion.Controls.Add(Me.panComposicion)
        Me.tpComposicion.Location = New System.Drawing.Point(4, 22)
        Me.tpComposicion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tpComposicion.Name = "tpComposicion"
        Me.tpComposicion.Size = New System.Drawing.Size(831, 487)
        Me.tpComposicion.TabIndex = 14
        Me.tpComposicion.Text = "Composición"
        Me.tpComposicion.UseVisualStyleBackColor = True
        '
        'panComposicion
        '
        Me.panComposicion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panComposicion.Location = New System.Drawing.Point(0, 0)
        Me.panComposicion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.panComposicion.Name = "panComposicion"
        Me.panComposicion.Size = New System.Drawing.Size(831, 487)
        Me.panComposicion.TabIndex = 0
        '
        'TimerAutorizacion
        '
        Me.TimerAutorizacion.Interval = 40000
        '
        'tpAvisos
        '
        Me.tpAvisos.Location = New System.Drawing.Point(4, 22)
        Me.tpAvisos.Name = "tpAvisos"
        Me.tpAvisos.Padding = New System.Windows.Forms.Padding(3)
        Me.tpAvisos.Size = New System.Drawing.Size(1205, 487)
        Me.tpAvisos.TabIndex = 15
        Me.tpAvisos.Text = "Avisos"
        Me.tpAvisos.UseVisualStyleBackColor = True
        '
        'frmModDetExtras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1213, 513)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmModDetExtras"
        Me.Text = "frmModDetExtras"
        Me.TabControl1.ResumeLayout(False)
        Me.tbpPedidos.ResumeLayout(False)
        CType(Me.dgvPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpComposicion.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents TabControl1 As System.Windows.Forms.TabControl
    Private WithEvents tpComposicion As System.Windows.Forms.TabPage
    Private WithEvents panComposicion As System.Windows.Forms.Panel
    Private WithEvents tbpFichasTecnicas As System.Windows.Forms.TabPage
    Private WithEvents tbpFichasCondiciones As System.Windows.Forms.TabPage
    Private WithEvents tbpFichasSeguridad As System.Windows.Forms.TabPage
    Private WithEvents tbpImagen As System.Windows.Forms.TabPage
    Private WithEvents tbpProveedores As System.Windows.Forms.TabPage
    Private WithEvents tbpPedidos As System.Windows.Forms.TabPage
    Private WithEvents dgvPedidos As System.Windows.Forms.DataGridView
    Private WithEvents tbpStocks As System.Windows.Forms.TabPage
    Private WithEvents tbpDocumentacion As System.Windows.Forms.TabPage
    Private WithEvents tbpLegislacion As System.Windows.Forms.TabPage
    Private WithEvents tbpProductos As System.Windows.Forms.TabPage
    Private WithEvents tbpNoConformidades As System.Windows.Forms.TabPage
    Private WithEvents tbpRetenidos As System.Windows.Forms.TabPage
    Private WithEvents tbpEvolucionPrecios As System.Windows.Forms.TabPage
    Private WithEvents tbpGestionesCompra As System.Windows.Forms.TabPage
    Private WithEvents TimerAutorizacion As System.Windows.Forms.Timer
    Public WithEvents tpAvisos As System.Windows.Forms.TabPage
End Class
