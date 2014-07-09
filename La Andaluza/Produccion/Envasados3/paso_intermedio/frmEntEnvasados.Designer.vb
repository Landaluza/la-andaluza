<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntEnvasados
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
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtEfectividad = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtObservacionesEnvasado = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblFecha = New System.Windows.Forms.Label
        Me.lblEfectividad = New System.Windows.Forms.Label
        Me.lblObservacionesEnvasado = New System.Windows.Forms.Label
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel
        Me.tlpMiddle.SuspendLayout()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpFecha
        '
        Me.dtpFecha.Dock = System.Windows.Forms.DockStyle.None
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.TabIndex = 0
        Me.dtpFecha.BackColor = System.Drawing.SystemColors.Window
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Size = New System.Drawing.Size(95, 21)
        '
        'txtEfectividad
        '
        Me.txtEfectividad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtEfectividad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEfectividad.Name = "txtEfectividad"
        Me.txtEfectividad.TabIndex = 1
        Me.txtEfectividad.BackColor = System.Drawing.SystemColors.Window
        Me.txtEfectividad.MaxLength = 9
        Me.txtEfectividad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtEfectividad.Size = New System.Drawing.Size(92, 21)
        '
        'txtObservacionesEnvasado
        '
        Me.txtObservacionesEnvasado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtObservacionesEnvasado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacionesEnvasado.Name = "txtObservacionesEnvasado"
        Me.txtObservacionesEnvasado.TabIndex = 2
        Me.txtObservacionesEnvasado.BackColor = System.Drawing.SystemColors.Window
        Me.txtObservacionesEnvasado.MaxLength = 255
        Me.txtObservacionesEnvasado.Size = New System.Drawing.Size(200, 42)
        '
        'lblFecha
        '
        Me.lblFecha.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Text = "Fecha"
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblFecha.Size = New System.Drawing.Size(135, 21)
        Me.lblFecha.Location = New System.Drawing.Point(20, 40)
        '
        'lblEfectividad
        '
        Me.lblEfectividad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblEfectividad.Name = "lblEfectividad"
        Me.lblEfectividad.Text = "Efectividad"
        Me.lblEfectividad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblEfectividad.Size = New System.Drawing.Size(135, 21)
        Me.lblEfectividad.Location = New System.Drawing.Point(20, 40)
        '
        'lblObservacionesEnvasado
        '
        Me.lblObservacionesEnvasado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblObservacionesEnvasado.Name = "lblObservacionesEnvasado"
        Me.lblObservacionesEnvasado.Text = "ObservacionesEnvasado"
        Me.lblObservacionesEnvasado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblObservacionesEnvasado.Size = New System.Drawing.Size(135, 21)
        Me.lblObservacionesEnvasado.Location = New System.Drawing.Point(20, 40)
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
        Me.tlpMiddle.Controls.Add(Me.lblFecha, 1, 0)
        Me.tlpMiddle.Controls.Add(Me.dtpFecha, 2, 0)
        Me.tlpMiddle.Controls.Add(Me.lblEfectividad, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.txtEfectividad, 2, 1)
        Me.tlpMiddle.Controls.Add(Me.lblObservacionesEnvasado, 1, 2)
        Me.tlpMiddle.Controls.Add(Me.txtObservacionesEnvasado, 2, 2)
        Me.tlpMiddle.Location = New System.Drawing.Point(0, 25)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.RowCount = 4
        Me.tlpMiddle.Padding = New System.Windows.Forms.Padding(0, 15, 0, 0)
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(465, 81)
        '
        'tlpTop
        '




        '
        'frmEntEnvasados
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Controls.Add(Me.tlpMiddle)
        Me.ClientSize = New System.Drawing.Size(465, 161)
        Me.MinimumSize = New System.Drawing.Size(465, 161)
        Me.Name = "frmEntEnvasados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Envasados"
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMiddle.PerformLayout()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

   Private WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Private WithEvents txtEfectividad As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtObservacionesEnvasado As BasesParaCompatibilidad.CuadroDeTexto
   Private WithEvents lblFecha As System.Windows.Forms.Label
   Private WithEvents lblEfectividad As System.Windows.Forms.Label
   Private WithEvents lblObservacionesEnvasado As System.Windows.Forms.Label
   Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel

End Class
