Namespace Proveedores
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class guiAVisoPedido
        Inherits System.Windows.Forms.Form

        'Form reemplaza a Dispose para limpiar la lista de componentes.
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

        'Requerido por el Diseñador de Windows Forms
        Private components As System.ComponentModel.IContainer

        'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
        'Se puede modificar usando el Diseñador de Windows Forms.  
        'No lo modifique con el editor de código.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.barraNavegacion = New System.Windows.Forms.Panel()
            Me.lResultados = New System.Windows.Forms.Label()
            Me.btnAvanzar = New System.Windows.Forms.Button()
            Me.btnAtras = New System.Windows.Forms.Button()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.btnSalir = New System.Windows.Forms.Button()
            Me.btnMarcarTodos = New System.Windows.Forms.Button()
            Me.btnMarcar = New System.Windows.Forms.Button()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.lFecha = New System.Windows.Forms.Label()
            Me.lCabecera = New System.Windows.Forms.Label()
            Me.lDetalle = New System.Windows.Forms.Label()
            Me.barraNavegacion.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'barraNavegacion
            '
            Me.barraNavegacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.barraNavegacion.Controls.Add(Me.lResultados)
            Me.barraNavegacion.Controls.Add(Me.btnAvanzar)
            Me.barraNavegacion.Controls.Add(Me.btnAtras)
            Me.barraNavegacion.Dock = System.Windows.Forms.DockStyle.Top
            Me.barraNavegacion.Location = New System.Drawing.Point(0, 0)
            Me.barraNavegacion.Name = "barraNavegacion"
            Me.barraNavegacion.Size = New System.Drawing.Size(483, 49)
            Me.barraNavegacion.TabIndex = 0
            '
            'lResultados
            '
            Me.lResultados.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lResultados.Location = New System.Drawing.Point(75, 0)
            Me.lResultados.Name = "lResultados"
            Me.lResultados.Size = New System.Drawing.Size(329, 45)
            Me.lResultados.TabIndex = 2
            Me.lResultados.Text = "Aviso 1/1"
            Me.lResultados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'btnAvanzar
            '
            Me.btnAvanzar.Dock = System.Windows.Forms.DockStyle.Right
            Me.btnAvanzar.FlatAppearance.BorderSize = 0
            Me.btnAvanzar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnAvanzar.Image = Global.La_Andaluza.My.Resources.Resources.go_next_5
            Me.btnAvanzar.Location = New System.Drawing.Point(404, 0)
            Me.btnAvanzar.Name = "btnAvanzar"
            Me.btnAvanzar.Size = New System.Drawing.Size(75, 45)
            Me.btnAvanzar.TabIndex = 1
            Me.btnAvanzar.UseVisualStyleBackColor = True
            '
            'btnAtras
            '
            Me.btnAtras.Dock = System.Windows.Forms.DockStyle.Left
            Me.btnAtras.FlatAppearance.BorderSize = 0
            Me.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnAtras.Image = Global.La_Andaluza.My.Resources.Resources.go_previous_5
            Me.btnAtras.Location = New System.Drawing.Point(0, 0)
            Me.btnAtras.Name = "btnAtras"
            Me.btnAtras.Size = New System.Drawing.Size(75, 45)
            Me.btnAtras.TabIndex = 0
            Me.btnAtras.UseVisualStyleBackColor = True
            '
            'Panel1
            '
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Panel1.Controls.Add(Me.btnSalir)
            Me.Panel1.Controls.Add(Me.btnMarcarTodos)
            Me.Panel1.Controls.Add(Me.btnMarcar)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Panel1.Location = New System.Drawing.Point(0, 424)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(483, 43)
            Me.Panel1.TabIndex = 1
            '
            'btnSalir
            '
            Me.btnSalir.Dock = System.Windows.Forms.DockStyle.Left
            Me.btnSalir.FlatAppearance.BorderSize = 0
            Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSalir.Image = Global.La_Andaluza.My.Resources.Resources.glyphicons_221_unshare
            Me.btnSalir.Location = New System.Drawing.Point(0, 0)
            Me.btnSalir.Name = "btnSalir"
            Me.btnSalir.Size = New System.Drawing.Size(75, 39)
            Me.btnSalir.TabIndex = 2
            Me.ToolTip1.SetToolTip(Me.btnSalir, "Salir sin marcar los avisos")
            Me.btnSalir.UseVisualStyleBackColor = True
            '
            'btnMarcarTodos
            '
            Me.btnMarcarTodos.Dock = System.Windows.Forms.DockStyle.Right
            Me.btnMarcarTodos.FlatAppearance.BorderSize = 0
            Me.btnMarcarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnMarcarTodos.Image = Global.La_Andaluza.My.Resources.Resources.glyphicons_157_show_thumbnails_with_lines
            Me.btnMarcarTodos.Location = New System.Drawing.Point(329, 0)
            Me.btnMarcarTodos.Name = "btnMarcarTodos"
            Me.btnMarcarTodos.Size = New System.Drawing.Size(75, 39)
            Me.btnMarcarTodos.TabIndex = 1
            Me.ToolTip1.SetToolTip(Me.btnMarcarTodos, "Marcar todos los avisos como leidos")
            Me.btnMarcarTodos.UseVisualStyleBackColor = True
            '
            'btnMarcar
            '
            Me.btnMarcar.Dock = System.Windows.Forms.DockStyle.Right
            Me.btnMarcar.FlatAppearance.BorderSize = 0
            Me.btnMarcar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnMarcar.Image = Global.La_Andaluza.My.Resources.Resources.glyphicons_206_ok_2
            Me.btnMarcar.Location = New System.Drawing.Point(404, 0)
            Me.btnMarcar.Name = "btnMarcar"
            Me.btnMarcar.Size = New System.Drawing.Size(75, 39)
            Me.btnMarcar.TabIndex = 0
            Me.ToolTip1.SetToolTip(Me.btnMarcar, "Marcar el aviso actual como leido")
            Me.btnMarcar.UseVisualStyleBackColor = True
            '
            'lFecha
            '
            Me.lFecha.AutoSize = True
            Me.lFecha.Dock = System.Windows.Forms.DockStyle.Top
            Me.lFecha.Location = New System.Drawing.Point(0, 49)
            Me.lFecha.Name = "lFecha"
            Me.lFecha.Padding = New System.Windows.Forms.Padding(0, 20, 0, 0)
            Me.lFecha.Size = New System.Drawing.Size(65, 33)
            Me.lFecha.TabIndex = 2
            Me.lFecha.Text = "18/12/2014"
            '
            'lCabecera
            '
            Me.lCabecera.Dock = System.Windows.Forms.DockStyle.Top
            Me.lCabecera.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lCabecera.Location = New System.Drawing.Point(0, 82)
            Me.lCabecera.Name = "lCabecera"
            Me.lCabecera.Padding = New System.Windows.Forms.Padding(10, 20, 10, 0)
            Me.lCabecera.Size = New System.Drawing.Size(483, 104)
            Me.lCabecera.TabIndex = 3
            Me.lCabecera.Text = "Cabecera"
            '
            'lDetalle
            '
            Me.lDetalle.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lDetalle.Location = New System.Drawing.Point(0, 186)
            Me.lDetalle.Name = "lDetalle"
            Me.lDetalle.Padding = New System.Windows.Forms.Padding(0, 10, 0, 15)
            Me.lDetalle.Size = New System.Drawing.Size(483, 238)
            Me.lDetalle.TabIndex = 4
            Me.lDetalle.Text = "Detalle"
            '
            'guiAVisoPedido
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(483, 467)
            Me.Controls.Add(Me.lDetalle)
            Me.Controls.Add(Me.lCabecera)
            Me.Controls.Add(Me.lFecha)
            Me.Controls.Add(Me.Panel1)
            Me.Controls.Add(Me.barraNavegacion)
            Me.Name = "guiAVisoPedido"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Aviso"
            Me.barraNavegacion.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Private WithEvents barraNavegacion As System.Windows.Forms.Panel
        Private WithEvents Panel1 As System.Windows.Forms.Panel
        Private WithEvents ToolTip1 As System.Windows.Forms.ToolTip
        Public WithEvents btnAvanzar As System.Windows.Forms.Button
        Public WithEvents btnAtras As System.Windows.Forms.Button
        Public WithEvents lResultados As System.Windows.Forms.Label
        Public WithEvents btnMarcarTodos As System.Windows.Forms.Button
        Public WithEvents btnMarcar As System.Windows.Forms.Button
        Public WithEvents btnSalir As System.Windows.Forms.Button
        Public WithEvents lFecha As System.Windows.Forms.Label
        Public WithEvents lCabecera As System.Windows.Forms.Label
        Public WithEvents lDetalle As System.Windows.Forms.Label
    End Class
End Namespace