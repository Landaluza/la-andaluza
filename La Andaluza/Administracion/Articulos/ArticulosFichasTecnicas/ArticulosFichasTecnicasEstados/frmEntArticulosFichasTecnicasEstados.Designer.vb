<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntArticulosFichasTecnicasEstados
    Inherits BasesParaCompatibilidad.FrmAHeredarEntOld

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
        Me.txtArticuloFichaTecnicaEstadoID = New BasesParaCompatibilidad.CuadroDeTexto
        Me.txtDescripcion = New BasesParaCompatibilidad.CuadroDeTexto
        Me.txtObservaciones = New BasesParaCompatibilidad.CuadroDeTexto
        Me.lblArticuloFichaTecnicaEstadoID = New System.Windows.Forms.Label
        Me.lblDescripcion = New System.Windows.Forms.Label
        Me.lblObservaciones = New System.Windows.Forms.Label
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel
        Me.tlpMiddle.SuspendLayout()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtArticuloFichaTecnicaEstadoID
        '
        Me.txtArticuloFichaTecnicaEstadoID.Dock = System.Windows.Forms.DockStyle.None
        Me.txtArticuloFichaTecnicaEstadoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArticuloFichaTecnicaEstadoID.Name = "txtArticuloFichaTecnicaEstadoID"
        Me.txtArticuloFichaTecnicaEstadoID.TabIndex = 0
        Me.txtArticuloFichaTecnicaEstadoID.BackColor = System.Drawing.SystemColors.Window
        Me.txtArticuloFichaTecnicaEstadoID.MaxLength = 9
        Me.txtArticuloFichaTecnicaEstadoID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtArticuloFichaTecnicaEstadoID.Size = New System.Drawing.Size(56, 21)
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Dock = System.Windows.Forms.DockStyle.None
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.TabIndex = 1
        Me.txtDescripcion.BackColor = System.Drawing.SystemColors.Window
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.Size = New System.Drawing.Size(200, 42)
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Dock = System.Windows.Forms.DockStyle.None
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.TabIndex = 2
        Me.txtObservaciones.Obligatorio = True
        Me.txtObservaciones.BackColor = System.Drawing.SystemColors.Window
        Me.txtObservaciones.MaxLength = 500
        Me.txtObservaciones.Size = New System.Drawing.Size(200, 42)
        '
        'lblArticuloFichaTecnicaEstadoID
        '
        Me.lblArticuloFichaTecnicaEstadoID.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblArticuloFichaTecnicaEstadoID.Name = "lblArticuloFichaTecnicaEstadoID"
        Me.lblArticuloFichaTecnicaEstadoID.Text = "ArticuloFichaTecnicaEstadoID"
        Me.lblArticuloFichaTecnicaEstadoID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblArticuloFichaTecnicaEstadoID.Size = New System.Drawing.Size(160, 21)
        Me.lblArticuloFichaTecnicaEstadoID.Location = New System.Drawing.Point(20, 40)
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Text = "Descripcion"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDescripcion.Size = New System.Drawing.Size(160, 21)
        Me.lblDescripcion.Location = New System.Drawing.Point(20, 40)
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblObservaciones.Size = New System.Drawing.Size(160, 21)
        Me.lblObservaciones.Location = New System.Drawing.Point(20, 40)
        '
        'tlpMiddle
        '
        Me.tlpMiddle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpMiddle.ColumnCount = 4
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlpMiddle.Controls.Add(Me.lblArticuloFichaTecnicaEstadoID, 1, 0)
        Me.tlpMiddle.Controls.Add(Me.txtArticuloFichaTecnicaEstadoID, 2, 0)
        Me.tlpMiddle.Controls.Add(Me.lblDescripcion, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.txtDescripcion, 2, 1)
        Me.tlpMiddle.Controls.Add(Me.lblObservaciones, 1, 2)
        Me.tlpMiddle.Controls.Add(Me.txtObservaciones, 2, 2)
        Me.tlpMiddle.Location = New System.Drawing.Point(0, 40)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.RowCount = 4
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(410, 81)
        '
        '
        '
        'frmEntArticulosFichasTecnicasEstados
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(410, 161)
        Me.Controls.Add(Me.tlpMiddle)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmEntArticulosFichasTecnicasEstados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ArticulosFichasTecnicasEstados"
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.PerformLayout()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents txtArticuloFichaTecnicaEstadoID As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtDescripcion As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtObservaciones As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents lblArticuloFichaTecnicaEstadoID As System.Windows.Forms.Label
    Private WithEvents lblDescripcion As System.Windows.Forms.Label
    Private WithEvents lblObservaciones As System.Windows.Forms.Label
    Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel
End Class
