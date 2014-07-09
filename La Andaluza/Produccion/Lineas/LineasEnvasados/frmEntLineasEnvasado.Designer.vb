<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntLineasEnvasado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntLineasEnvasado))
        Me.txtDescripcion = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtVelocidadMaxima = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblVelocidadMaxima = New System.Windows.Forms.Label()

        Me.panTop = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.tbLineas = New System.Windows.Forms.TabControl()
        Me.tpEmpleados = New System.Windows.Forms.TabPage()
        Me.tpTareas = New System.Windows.Forms.TabPage()
        Me.tpMaquinas = New System.Windows.Forms.TabPage()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panTop.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.tbLineas.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.SystemColors.Window
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.EsUnicoCampo = ""
        Me.txtDescripcion.EsUnicoCampoID = ""
        Me.txtDescripcion.EsUnicoID = 0
        Me.txtDescripcion.EsUnicoTabla = ""
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(152, 12)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.Minimo = 0
        Me.txtDescripcion.Modificado = False
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Numerico_EsNumerico = False
        Me.txtDescripcion.Numerico_NumeroDoublees = 0
        Me.txtDescripcion.Numerico_SeparadorMiles = False
        Me.txtDescripcion.Obligatorio = False
        Me.txtDescripcion.ParametroID = 0
        Me.txtDescripcion.Size = New System.Drawing.Size(224, 21)
        Me.txtDescripcion.TabIndex = 0
        Me.txtDescripcion.ValorMaximo = 0.0R
        Me.txtDescripcion.ValorMinimo = 0.0R
        '
        'txtVelocidadMaxima
        '
        Me.txtVelocidadMaxima.BackColor = System.Drawing.SystemColors.Window
        Me.txtVelocidadMaxima.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVelocidadMaxima.EsUnicoCampo = ""
        Me.txtVelocidadMaxima.EsUnicoCampoID = ""
        Me.txtVelocidadMaxima.EsUnicoID = 0
        Me.txtVelocidadMaxima.EsUnicoTabla = ""
        Me.txtVelocidadMaxima.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVelocidadMaxima.Location = New System.Drawing.Point(152, 41)
        Me.txtVelocidadMaxima.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtVelocidadMaxima.MaxLength = 9
        Me.txtVelocidadMaxima.Minimo = 0
        Me.txtVelocidadMaxima.Modificado = False
        Me.txtVelocidadMaxima.Name = "txtVelocidadMaxima"
        Me.txtVelocidadMaxima.Numerico_EsNumerico = False
        Me.txtVelocidadMaxima.Numerico_NumeroDoublees = 0
        Me.txtVelocidadMaxima.Numerico_SeparadorMiles = False
        Me.txtVelocidadMaxima.Obligatorio = False
        Me.txtVelocidadMaxima.ParametroID = 0
        Me.txtVelocidadMaxima.Size = New System.Drawing.Size(224, 21)
        Me.txtVelocidadMaxima.TabIndex = 1
        Me.txtVelocidadMaxima.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtVelocidadMaxima.ValorMaximo = 0.0R
        Me.txtVelocidadMaxima.ValorMinimo = 0.0R
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Location = New System.Drawing.Point(58, 10)
        Me.lblDescripcion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(88, 28)
        Me.lblDescripcion.TabIndex = 0
        Me.lblDescripcion.Text = "Descripcion"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVelocidadMaxima
        '
        Me.lblVelocidadMaxima.Location = New System.Drawing.Point(58, 38)
        Me.lblVelocidadMaxima.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblVelocidadMaxima.Name = "lblVelocidadMaxima"
        Me.lblVelocidadMaxima.Size = New System.Drawing.Size(88, 28)
        Me.lblVelocidadMaxima.TabIndex = 1
        Me.lblVelocidadMaxima.Text = "Velocidad máxima"
        Me.lblVelocidadMaxima.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpTop
        '




        '
        'panTop
        '
        Me.panTop.Controls.Add(Me.txtVelocidadMaxima)
        Me.panTop.Controls.Add(Me.lblVelocidadMaxima)
        Me.panTop.Controls.Add(Me.lblDescripcion)
        Me.panTop.Controls.Add(Me.txtDescripcion)
        Me.panTop.Location = New System.Drawing.Point(73, 23)
        Me.panTop.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.panTop.Name = "panTop"
        Me.panTop.Size = New System.Drawing.Size(437, 75)
        Me.panTop.TabIndex = 1000000001
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 25)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.panTop)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.tbLineas)
        Me.SplitContainer1.Size = New System.Drawing.Size(578, 393)
        Me.SplitContainer1.SplitterDistance = 107
        Me.SplitContainer1.SplitterWidth = 3
        Me.SplitContainer1.TabIndex = 1000000003
        '
        'tbLineas
        '
        Me.tbLineas.Controls.Add(Me.tpEmpleados)
        Me.tbLineas.Controls.Add(Me.tpTareas)
        Me.tbLineas.Controls.Add(Me.tpMaquinas)
        Me.tbLineas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbLineas.Location = New System.Drawing.Point(0, 0)
        Me.tbLineas.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tbLineas.Name = "tbLineas"
        Me.tbLineas.SelectedIndex = 0
        Me.tbLineas.Size = New System.Drawing.Size(578, 283)
        Me.tbLineas.TabIndex = 0
        '
        'tpEmpleados
        '
        Me.tpEmpleados.Location = New System.Drawing.Point(4, 22)
        Me.tpEmpleados.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tpEmpleados.Name = "tpEmpleados"
        Me.tpEmpleados.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tpEmpleados.Size = New System.Drawing.Size(570, 257)
        Me.tpEmpleados.TabIndex = 0
        Me.tpEmpleados.Text = "Empleados"
        Me.tpEmpleados.UseVisualStyleBackColor = True
        '
        'tpTareas
        '
        Me.tpTareas.Location = New System.Drawing.Point(4, 22)
        Me.tpTareas.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tpTareas.Name = "tpTareas"
        Me.tpTareas.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tpTareas.Size = New System.Drawing.Size(570, 259)
        Me.tpTareas.TabIndex = 1
        Me.tpTareas.Text = "Tareas"
        Me.tpTareas.UseVisualStyleBackColor = True
        '
        'tpMaquinas
        '
        Me.tpMaquinas.Location = New System.Drawing.Point(4, 22)
        Me.tpMaquinas.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tpMaquinas.Name = "tpMaquinas"
        Me.tpMaquinas.Size = New System.Drawing.Size(570, 259)
        Me.tpMaquinas.TabIndex = 2
        Me.tpMaquinas.Text = "Maquinas"
        Me.tpMaquinas.UseVisualStyleBackColor = True
        '
        'frmEntLineasEnvasado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(578, 418)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(390, 132)
        Me.Name = "frmEntLineasEnvasado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "LineasEnvasado"
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panTop.ResumeLayout(False)
        Me.panTop.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.tbLineas.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtDescripcion As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtVelocidadMaxima As BasesParaCompatibilidad.CuadroDeTexto
   Private WithEvents lblDescripcion As System.Windows.Forms.Label
   Private WithEvents lblVelocidadMaxima As System.Windows.Forms.Label

   Private WithEvents tpEmpleados As System.Windows.Forms.TabPage
   Private WithEvents tpTareas As System.Windows.Forms.TabPage
    Private WithEvents panTop As System.Windows.Forms.Panel
    Private WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Private WithEvents tbLineas As System.Windows.Forms.TabControl
   Private WithEvents tpMaquinas As System.Windows.Forms.TabPage
End Class
