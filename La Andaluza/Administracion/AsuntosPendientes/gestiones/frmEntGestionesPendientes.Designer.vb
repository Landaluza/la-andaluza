<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntGestionesPendientes
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
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtPersonaContactada = New System.Windows.Forms.TextBox()
        Me.txtMedioContacto = New System.Windows.Forms.TextBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblPersonaContactada = New System.Windows.Forms.Label()
        Me.lblMedioContacto = New System.Windows.Forms.Label()
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMiddle.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.SystemColors.Window
        Me.txtDescripcion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(196, 18)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(240, 24)
        Me.txtDescripcion.TabIndex = 0
        '
        'dtpFecha
        '
        Me.dtpFecha.BackColor = System.Drawing.SystemColors.Window
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(196, 53)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(114, 24)
        Me.dtpFecha.TabIndex = 1
        '
        'txtPersonaContactada
        '
        Me.txtPersonaContactada.BackColor = System.Drawing.SystemColors.Window
        Me.txtPersonaContactada.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPersonaContactada.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPersonaContactada.Location = New System.Drawing.Point(196, 88)
        Me.txtPersonaContactada.MaxLength = 50
        Me.txtPersonaContactada.Name = "txtPersonaContactada"
        Me.txtPersonaContactada.Size = New System.Drawing.Size(240, 24)
        Me.txtPersonaContactada.TabIndex = 2
        '
        'txtMedioContacto
        '
        Me.txtMedioContacto.BackColor = System.Drawing.SystemColors.Window
        Me.txtMedioContacto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtMedioContacto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMedioContacto.Location = New System.Drawing.Point(196, 122)
        Me.txtMedioContacto.MaxLength = 30
        Me.txtMedioContacto.Name = "txtMedioContacto"
        Me.txtMedioContacto.Size = New System.Drawing.Size(240, 24)
        Me.txtMedioContacto.TabIndex = 3
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDescripcion.Location = New System.Drawing.Point(60, 15)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(130, 35)
        Me.lblDescripcion.TabIndex = 0
        Me.lblDescripcion.Text = "Descripcion"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFecha
        '
        Me.lblFecha.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblFecha.Location = New System.Drawing.Point(60, 50)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(130, 35)
        Me.lblFecha.TabIndex = 1
        Me.lblFecha.Text = "Fecha"
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPersonaContactada
        '
        Me.lblPersonaContactada.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPersonaContactada.Location = New System.Drawing.Point(60, 85)
        Me.lblPersonaContactada.Name = "lblPersonaContactada"
        Me.lblPersonaContactada.Size = New System.Drawing.Size(130, 34)
        Me.lblPersonaContactada.TabIndex = 2
        Me.lblPersonaContactada.Text = "Persona Contacto"
        Me.lblPersonaContactada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMedioContacto
        '
        Me.lblMedioContacto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMedioContacto.Location = New System.Drawing.Point(60, 119)
        Me.lblMedioContacto.Name = "lblMedioContacto"
        Me.lblMedioContacto.Size = New System.Drawing.Size(130, 35)
        Me.lblMedioContacto.TabIndex = 3
        Me.lblMedioContacto.Text = "Medio contacto"
        Me.lblMedioContacto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpMiddle
        '
        Me.tlpMiddle.ColumnCount = 8
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88.0!))
        Me.tlpMiddle.Controls.Add(Me.lblDescripcion, 1, 0)
        Me.tlpMiddle.Controls.Add(Me.txtDescripcion, 2, 0)
        Me.tlpMiddle.Controls.Add(Me.lblFecha, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.dtpFecha, 2, 1)
        Me.tlpMiddle.Controls.Add(Me.lblPersonaContactada, 1, 2)
        Me.tlpMiddle.Controls.Add(Me.txtPersonaContactada, 2, 2)
        Me.tlpMiddle.Controls.Add(Me.lblMedioContacto, 1, 3)
        Me.tlpMiddle.Controls.Add(Me.txtMedioContacto, 2, 3)
        Me.tlpMiddle.Location = New System.Drawing.Point(0, 29)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.Padding = New System.Windows.Forms.Padding(0, 15, 0, 0)
        Me.tlpMiddle.RowCount = 6
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(527, 210)
        Me.tlpMiddle.TabIndex = 8
        '
        'frmEntGestionesPendientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(594, 301)
        Me.Controls.Add(Me.tlpMiddle)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.MinimumSize = New System.Drawing.Size(527, 250)
        Me.Name = "frmEntGestionesPendientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "GestionesPendientes"
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Private WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Private WithEvents txtPersonaContactada As System.Windows.Forms.TextBox
    Private WithEvents txtMedioContacto As System.Windows.Forms.TextBox
    Private WithEvents lblDescripcion As System.Windows.Forms.Label
    Private WithEvents lblFecha As System.Windows.Forms.Label
    Private WithEvents lblPersonaContactada As System.Windows.Forms.Label
    Private WithEvents lblMedioContacto As System.Windows.Forms.Label
    Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel
End Class
