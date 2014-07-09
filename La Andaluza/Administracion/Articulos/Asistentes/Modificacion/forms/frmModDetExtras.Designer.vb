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
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1119, 631)
        Me.TabControl1.TabIndex = 1000000004
        '
        'tbpFichasTecnicas
        '
        Me.tbpFichasTecnicas.BackColor = System.Drawing.SystemColors.Control
        Me.tbpFichasTecnicas.Location = New System.Drawing.Point(4, 25)
        Me.tbpFichasTecnicas.Margin = New System.Windows.Forms.Padding(4)
        Me.tbpFichasTecnicas.Name = "tbpFichasTecnicas"
        Me.tbpFichasTecnicas.Padding = New System.Windows.Forms.Padding(4)
        Me.tbpFichasTecnicas.Size = New System.Drawing.Size(1111, 602)
        Me.tbpFichasTecnicas.TabIndex = 0
        Me.tbpFichasTecnicas.Text = "Fichas técnicas"
        '
        'tbpFichasCondiciones
        '
        Me.tbpFichasCondiciones.Location = New System.Drawing.Point(4, 25)
        Me.tbpFichasCondiciones.Margin = New System.Windows.Forms.Padding(4)
        Me.tbpFichasCondiciones.Name = "tbpFichasCondiciones"
        Me.tbpFichasCondiciones.Padding = New System.Windows.Forms.Padding(4)
        Me.tbpFichasCondiciones.Size = New System.Drawing.Size(1111, 602)
        Me.tbpFichasCondiciones.TabIndex = 1
        Me.tbpFichasCondiciones.Text = "Fichas condiciones"
        Me.tbpFichasCondiciones.UseVisualStyleBackColor = True
        '
        'tbpFichasSeguridad
        '
        Me.tbpFichasSeguridad.Location = New System.Drawing.Point(4, 25)
        Me.tbpFichasSeguridad.Margin = New System.Windows.Forms.Padding(4)
        Me.tbpFichasSeguridad.Name = "tbpFichasSeguridad"
        Me.tbpFichasSeguridad.Size = New System.Drawing.Size(1111, 602)
        Me.tbpFichasSeguridad.TabIndex = 2
        Me.tbpFichasSeguridad.Text = "Fichas seguridad"
        Me.tbpFichasSeguridad.UseVisualStyleBackColor = True
        '
        'tbpImagen
        '
        Me.tbpImagen.Location = New System.Drawing.Point(4, 25)
        Me.tbpImagen.Margin = New System.Windows.Forms.Padding(4)
        Me.tbpImagen.Name = "tbpImagen"
        Me.tbpImagen.Size = New System.Drawing.Size(1111, 602)
        Me.tbpImagen.TabIndex = 5
        Me.tbpImagen.Text = "Imagen"
        Me.tbpImagen.UseVisualStyleBackColor = True
        '
        'tbpProveedores
        '
        Me.tbpProveedores.Location = New System.Drawing.Point(4, 25)
        Me.tbpProveedores.Margin = New System.Windows.Forms.Padding(4)
        Me.tbpProveedores.Name = "tbpProveedores"
        Me.tbpProveedores.Size = New System.Drawing.Size(1111, 602)
        Me.tbpProveedores.TabIndex = 3
        Me.tbpProveedores.Text = "Proveedores"
        Me.tbpProveedores.UseVisualStyleBackColor = True
        '
        'tbpPedidos
        '
        Me.tbpPedidos.Controls.Add(Me.dgvPedidos)
        Me.tbpPedidos.Location = New System.Drawing.Point(4, 25)
        Me.tbpPedidos.Margin = New System.Windows.Forms.Padding(4)
        Me.tbpPedidos.Name = "tbpPedidos"
        Me.tbpPedidos.Size = New System.Drawing.Size(1111, 602)
        Me.tbpPedidos.TabIndex = 13
        Me.tbpPedidos.Text = "Pedidos"
        Me.tbpPedidos.UseVisualStyleBackColor = True
        '
        'dgvPedidos
        '
        Me.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPedidos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPedidos.Location = New System.Drawing.Point(0, 0)
        Me.dgvPedidos.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvPedidos.Name = "dgvPedidos"
        Me.dgvPedidos.RowTemplate.Height = 24
        Me.dgvPedidos.Size = New System.Drawing.Size(1111, 602)
        Me.dgvPedidos.TabIndex = 0
        '
        'tbpStocks
        '
        Me.tbpStocks.Location = New System.Drawing.Point(4, 25)
        Me.tbpStocks.Margin = New System.Windows.Forms.Padding(4)
        Me.tbpStocks.Name = "tbpStocks"
        Me.tbpStocks.Size = New System.Drawing.Size(1111, 602)
        Me.tbpStocks.TabIndex = 4
        Me.tbpStocks.Text = "Stocks"
        Me.tbpStocks.UseVisualStyleBackColor = True
        '
        'tbpDocumentacion
        '
        Me.tbpDocumentacion.Location = New System.Drawing.Point(4, 25)
        Me.tbpDocumentacion.Margin = New System.Windows.Forms.Padding(4)
        Me.tbpDocumentacion.Name = "tbpDocumentacion"
        Me.tbpDocumentacion.Size = New System.Drawing.Size(1111, 602)
        Me.tbpDocumentacion.TabIndex = 6
        Me.tbpDocumentacion.Text = "Documentación"
        Me.tbpDocumentacion.UseVisualStyleBackColor = True
        '
        'tbpLegislacion
        '
        Me.tbpLegislacion.Location = New System.Drawing.Point(4, 25)
        Me.tbpLegislacion.Margin = New System.Windows.Forms.Padding(4)
        Me.tbpLegislacion.Name = "tbpLegislacion"
        Me.tbpLegislacion.Size = New System.Drawing.Size(1111, 602)
        Me.tbpLegislacion.TabIndex = 7
        Me.tbpLegislacion.Text = "Legislacion aplicable"
        Me.tbpLegislacion.UseVisualStyleBackColor = True
        '
        'tbpProductos
        '
        Me.tbpProductos.Location = New System.Drawing.Point(4, 25)
        Me.tbpProductos.Margin = New System.Windows.Forms.Padding(4)
        Me.tbpProductos.Name = "tbpProductos"
        Me.tbpProductos.Size = New System.Drawing.Size(1111, 602)
        Me.tbpProductos.TabIndex = 8
        Me.tbpProductos.Text = "Productos en los que se usa"
        Me.tbpProductos.UseVisualStyleBackColor = True
        '
        'tbpNoConformidades
        '
        Me.tbpNoConformidades.Location = New System.Drawing.Point(4, 25)
        Me.tbpNoConformidades.Margin = New System.Windows.Forms.Padding(4)
        Me.tbpNoConformidades.Name = "tbpNoConformidades"
        Me.tbpNoConformidades.Size = New System.Drawing.Size(1111, 602)
        Me.tbpNoConformidades.TabIndex = 9
        Me.tbpNoConformidades.Text = "No Conformidades"
        Me.tbpNoConformidades.UseVisualStyleBackColor = True
        '
        'tbpRetenidos
        '
        Me.tbpRetenidos.Location = New System.Drawing.Point(4, 25)
        Me.tbpRetenidos.Margin = New System.Windows.Forms.Padding(4)
        Me.tbpRetenidos.Name = "tbpRetenidos"
        Me.tbpRetenidos.Size = New System.Drawing.Size(1111, 602)
        Me.tbpRetenidos.TabIndex = 10
        Me.tbpRetenidos.Text = "Retenidos"
        Me.tbpRetenidos.UseVisualStyleBackColor = True
        '
        'tbpEvolucionPrecios
        '
        Me.tbpEvolucionPrecios.Location = New System.Drawing.Point(4, 25)
        Me.tbpEvolucionPrecios.Margin = New System.Windows.Forms.Padding(4)
        Me.tbpEvolucionPrecios.Name = "tbpEvolucionPrecios"
        Me.tbpEvolucionPrecios.Size = New System.Drawing.Size(1111, 602)
        Me.tbpEvolucionPrecios.TabIndex = 11
        Me.tbpEvolucionPrecios.Text = "Evolucion precios"
        Me.tbpEvolucionPrecios.UseVisualStyleBackColor = True
        '
        'tbpGestionesCompra
        '
        Me.tbpGestionesCompra.Location = New System.Drawing.Point(4, 25)
        Me.tbpGestionesCompra.Margin = New System.Windows.Forms.Padding(4)
        Me.tbpGestionesCompra.Name = "tbpGestionesCompra"
        Me.tbpGestionesCompra.Size = New System.Drawing.Size(1111, 602)
        Me.tbpGestionesCompra.TabIndex = 12
        Me.tbpGestionesCompra.Text = "Gestiones compra"
        Me.tbpGestionesCompra.UseVisualStyleBackColor = True
        '
        'tpComposicion
        '
        Me.tpComposicion.Controls.Add(Me.panComposicion)
        Me.tpComposicion.Location = New System.Drawing.Point(4, 25)
        Me.tpComposicion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tpComposicion.Name = "tpComposicion"
        Me.tpComposicion.Size = New System.Drawing.Size(1111, 602)
        Me.tpComposicion.TabIndex = 14
        Me.tpComposicion.Text = "Composición"
        Me.tpComposicion.UseVisualStyleBackColor = True
        '
        'panComposicion
        '
        Me.panComposicion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panComposicion.Location = New System.Drawing.Point(0, 0)
        Me.panComposicion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panComposicion.Name = "panComposicion"
        Me.panComposicion.Size = New System.Drawing.Size(1111, 602)
        Me.panComposicion.TabIndex = 0
        '
        'TimerAutorizacion
        '
        Me.TimerAutorizacion.Interval = 40000
        '
        'frmModDetExtras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1119, 631)
        Me.Controls.Add(Me.TabControl1)
        Me.Margin = New System.Windows.Forms.Padding(4)
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
End Class
