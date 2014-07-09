<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntCompuestoPor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntCompuestoPor))
        Me.cboLoteFinal = New System.Windows.Forms.ComboBox()
        Me.cboLotePartida = New System.Windows.Forms.ComboBox()
        Me.cboMovimientoID = New System.Windows.Forms.ComboBox()
        Me.txtCantidad = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblLoteFinal = New System.Windows.Forms.Label()
        Me.lblLotePartida = New System.Windows.Forms.Label()
        Me.lblMovimientoID = New System.Windows.Forms.Label()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel()

        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMiddle.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboLoteFinal
        '
        Me.cboLoteFinal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboLoteFinal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboLoteFinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboLoteFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLoteFinal.Location = New System.Drawing.Point(106, 3)
        Me.cboLoteFinal.Name = "cboLoteFinal"
        Me.cboLoteFinal.Size = New System.Drawing.Size(200, 23)
        Me.cboLoteFinal.TabIndex = 0
        '
        'cboLotePartida
        '
        Me.cboLotePartida.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboLotePartida.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboLotePartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboLotePartida.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLotePartida.Location = New System.Drawing.Point(106, 32)
        Me.cboLotePartida.Name = "cboLotePartida"
        Me.cboLotePartida.Size = New System.Drawing.Size(200, 23)
        Me.cboLotePartida.TabIndex = 1
        '
        'cboMovimientoID
        '
        Me.cboMovimientoID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboMovimientoID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboMovimientoID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboMovimientoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMovimientoID.Location = New System.Drawing.Point(106, 61)
        Me.cboMovimientoID.Name = "cboMovimientoID"
        Me.cboMovimientoID.Size = New System.Drawing.Size(200, 23)
        Me.cboMovimientoID.TabIndex = 2
        '
        'txtCantidad
        '
        Me.txtCantidad.BackColor = System.Drawing.SystemColors.Window
        Me.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCantidad.EsUnicoCampo = ""
        Me.txtCantidad.EsUnicoCampoID = ""
        Me.txtCantidad.EsUnicoID = 0
        Me.txtCantidad.EsUnicoTabla = ""
        Me.txtCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.Location = New System.Drawing.Point(106, 90)
        Me.txtCantidad.MaxLength = 9
        Me.txtCantidad.Minimo = 0
        Me.txtCantidad.Modificado = False
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Numerico_EsNumerico = False
        Me.txtCantidad.Numerico_NumeroDoublees = 0
        Me.txtCantidad.Numerico_SeparadorMiles = False
        Me.txtCantidad.Obligatorio = False
        Me.txtCantidad.ParametroID = 0
        Me.txtCantidad.Size = New System.Drawing.Size(56, 21)
        Me.txtCantidad.TabIndex = 3
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCantidad.ValorMaximo = 0.0R
        Me.txtCantidad.ValorMinimo = 0.0R
        '
        'lblLoteFinal
        '
        Me.lblLoteFinal.Location = New System.Drawing.Point(23, 0)
        Me.lblLoteFinal.Name = "lblLoteFinal"
        Me.lblLoteFinal.Size = New System.Drawing.Size(77, 21)
        Me.lblLoteFinal.TabIndex = 0
        Me.lblLoteFinal.Text = "LoteFinal"
        Me.lblLoteFinal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLotePartida
        '
        Me.lblLotePartida.Location = New System.Drawing.Point(23, 29)
        Me.lblLotePartida.Name = "lblLotePartida"
        Me.lblLotePartida.Size = New System.Drawing.Size(77, 21)
        Me.lblLotePartida.TabIndex = 1
        Me.lblLotePartida.Text = "LotePartida"
        Me.lblLotePartida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMovimientoID
        '
        Me.lblMovimientoID.Location = New System.Drawing.Point(23, 58)
        Me.lblMovimientoID.Name = "lblMovimientoID"
        Me.lblMovimientoID.Size = New System.Drawing.Size(77, 21)
        Me.lblMovimientoID.TabIndex = 2
        Me.lblMovimientoID.Text = "MovimientoID"
        Me.lblMovimientoID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblMovimientoID.Visible = False
        '
        'lblCantidad
        '
        Me.lblCantidad.Location = New System.Drawing.Point(23, 87)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(77, 21)
        Me.lblCantidad.TabIndex = 3
        Me.lblCantidad.Text = "Cantidad"
        Me.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98.0!))
        Me.tlpMiddle.Controls.Add(Me.lblLoteFinal, 1, 0)
        Me.tlpMiddle.Controls.Add(Me.cboLoteFinal, 2, 0)
        Me.tlpMiddle.Controls.Add(Me.lblLotePartida, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.cboLotePartida, 2, 1)
        Me.tlpMiddle.Controls.Add(Me.lblMovimientoID, 1, 2)
        Me.tlpMiddle.Controls.Add(Me.cboMovimientoID, 2, 2)
        Me.tlpMiddle.Controls.Add(Me.lblCantidad, 1, 3)
        Me.tlpMiddle.Controls.Add(Me.txtCantidad, 2, 3)
        Me.tlpMiddle.Location = New System.Drawing.Point(0, 40)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.RowCount = 5
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(407, 114)
        Me.tlpMiddle.TabIndex = 1000000001
        '
        'tlpTop
        '




        '
        'frmEntCompuestoPor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(407, 194)
        Me.Controls.Add(Me.tlpMiddle)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(407, 194)
        Me.Name = "frmEntCompuestoPor"
        Me.Text = "CompuestoPor"
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        Me.Controls.SetChildIndex(Me.txtTodoCorrecto, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

   Private WithEvents cboLoteFinal As System.Windows.Forms.ComboBox
   Private WithEvents cboLotePartida As System.Windows.Forms.ComboBox
   Private WithEvents cboMovimientoID As System.Windows.Forms.ComboBox
    Private WithEvents txtCantidad As BasesParaCompatibilidad.CuadroDeTexto
   Private WithEvents lblLoteFinal As System.Windows.Forms.Label
   Private WithEvents lblLotePartida As System.Windows.Forms.Label
   Private WithEvents lblMovimientoID As System.Windows.Forms.Label
   Private WithEvents lblCantidad As System.Windows.Forms.Label
   Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel

End Class
