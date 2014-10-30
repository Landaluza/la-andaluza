<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntPaletsContenidos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntPaletsContenidos))
        Me.dtpHoraInicio = New System.Windows.Forms.DateTimePicker()
        Me.dtpHoraFin = New System.Windows.Forms.DateTimePicker()
        Me.txtCantidadCajas = New System.Windows.Forms.TextBox()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.lblHoraInicio = New System.Windows.Forms.Label()
        Me.lblHoraFin = New System.Windows.Forms.Label()
        Me.lblCantidadCajas = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lCajasSuperiores = New System.Windows.Forms.Label()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtpHoraInicio
        '
        Me.dtpHoraInicio.BackColor = System.Drawing.SystemColors.Window
        Me.dtpHoraInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHoraInicio.Location = New System.Drawing.Point(57, 12)
        Me.dtpHoraInicio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpHoraInicio.Name = "dtpHoraInicio"
        Me.dtpHoraInicio.ShowUpDown = True
        Me.dtpHoraInicio.Size = New System.Drawing.Size(86, 21)
        Me.dtpHoraInicio.TabIndex = 0
        '
        'dtpHoraFin
        '
        Me.dtpHoraFin.BackColor = System.Drawing.SystemColors.Window
        Me.dtpHoraFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHoraFin.Location = New System.Drawing.Point(57, 41)
        Me.dtpHoraFin.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpHoraFin.Name = "dtpHoraFin"
        Me.dtpHoraFin.ShowUpDown = True
        Me.dtpHoraFin.Size = New System.Drawing.Size(86, 21)
        Me.dtpHoraFin.TabIndex = 1
        '
        'txtCantidadCajas
        '
        Me.txtCantidadCajas.BackColor = System.Drawing.SystemColors.Window
        Me.txtCantidadCajas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCantidadCajas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidadCajas.Location = New System.Drawing.Point(279, 14)
        Me.txtCantidadCajas.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCantidadCajas.MaxLength = 9
        Me.txtCantidadCajas.Name = "txtCantidadCajas"
        Me.txtCantidadCajas.Size = New System.Drawing.Size(101, 21)
        Me.txtCantidadCajas.TabIndex = 2
        Me.txtCantidadCajas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.SystemColors.Window
        Me.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(13, 98)
        Me.txtObservaciones.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtObservaciones.MaxLength = 400
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(367, 50)
        Me.txtObservaciones.TabIndex = 4
        '
        'lblHoraInicio
        '
        Me.lblHoraInicio.Location = New System.Drawing.Point(10, 11)
        Me.lblHoraInicio.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHoraInicio.Name = "lblHoraInicio"
        Me.lblHoraInicio.Size = New System.Drawing.Size(42, 28)
        Me.lblHoraInicio.TabIndex = 0
        Me.lblHoraInicio.Text = "Inicio"
        Me.lblHoraInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblHoraFin
        '
        Me.lblHoraFin.Location = New System.Drawing.Point(10, 39)
        Me.lblHoraFin.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHoraFin.Name = "lblHoraFin"
        Me.lblHoraFin.Size = New System.Drawing.Size(42, 28)
        Me.lblHoraFin.TabIndex = 1
        Me.lblHoraFin.Text = "Fin"
        Me.lblHoraFin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCantidadCajas
        '
        Me.lblCantidadCajas.Location = New System.Drawing.Point(241, 11)
        Me.lblCantidadCajas.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCantidadCajas.Name = "lblCantidadCajas"
        Me.lblCantidadCajas.Size = New System.Drawing.Size(39, 28)
        Me.lblCantidadCajas.TabIndex = 2
        Me.lblCantidadCajas.Text = "Cajas"
        Me.lblCantidadCajas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Location = New System.Drawing.Point(10, 72)
        Me.lblObservaciones.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(83, 28)
        Me.lblObservaciones.TabIndex = 6
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lCajasSuperiores)
        Me.Panel1.Controls.Add(Me.txtObservaciones)
        Me.Panel1.Controls.Add(Me.lblHoraInicio)
        Me.Panel1.Controls.Add(Me.lblObservaciones)
        Me.Panel1.Controls.Add(Me.dtpHoraInicio)
        Me.Panel1.Controls.Add(Me.txtCantidadCajas)
        Me.Panel1.Controls.Add(Me.lblCantidadCajas)
        Me.Panel1.Controls.Add(Me.lblHoraFin)
        Me.Panel1.Controls.Add(Me.dtpHoraFin)
        Me.Panel1.Location = New System.Drawing.Point(21, 32)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(391, 159)
        Me.Panel1.TabIndex = 1000000001
        '
        'lCajasSuperiores
        '
        Me.lCajasSuperiores.AutoSize = True
        Me.lCajasSuperiores.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lCajasSuperiores.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lCajasSuperiores.Location = New System.Drawing.Point(277, 39)
        Me.lCajasSuperiores.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lCajasSuperiores.Name = "lCajasSuperiores"
        Me.lCajasSuperiores.Size = New System.Drawing.Size(100, 9)
        Me.lCajasSuperiores.TabIndex = 7
        Me.lCajasSuperiores.Text = "Las cajas superan lo normal"
        Me.lCajasSuperiores.Visible = False
        '
        'frmEntPaletsContenidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(433, 210)
        Me.Controls.Add(Me.Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(431, 237)
        Me.Name = "frmEntPaletsContenidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = " "
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents dtpHoraInicio As System.Windows.Forms.DateTimePicker
    Private WithEvents dtpHoraFin As System.Windows.Forms.DateTimePicker
    Private WithEvents txtCantidadCajas As System.windows.Forms.TextBox
    Private WithEvents txtObservaciones As System.windows.Forms.TextBox
    Private WithEvents lblHoraInicio As System.Windows.Forms.Label
    Private WithEvents lblHoraFin As System.Windows.Forms.Label
    Private WithEvents lblCantidadCajas As System.Windows.Forms.Label
    Private WithEvents lblObservaciones As System.Windows.Forms.Label

    Private WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents lCajasSuperiores As System.Windows.Forms.Label
End Class
