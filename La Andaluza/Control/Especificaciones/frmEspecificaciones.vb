Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmEspecificaciones
    Inherits BasesParaCompatibilidad.FrmAheredarOld

    Private ctlEsp As ctlEspecificaciones
    Private dtsEsp As dtsEspecificaciones.EspecificacionesDataTable

    Public Sub New()
        MyBase.New()
        InitializeComponent()

        ctlEsp = New ctlEspecificaciones
        dtsEsp = New dtsEspecificaciones.EspecificacionesDataTable
    End Sub

    Protected Overrides Sub cargar_datos()
        Dim dtb As New BasesParaCompatibilidad.DataBase
        ctlEsp.mostrarTodasEspecificaciones(dtb, dtsEsp)
    End Sub

    Protected Overrides Sub BindDataSource()
        GeneralBindingSource.DataMember = "Especificaciones"
        GeneralBindingSource.DataSource = dtsEsp
        dgvGeneral.DataSource = GeneralBindingSource


        dgvGeneral.Columns(0).Visible = False
        dgvGeneral.Columns(6).Visible = False
        dgvGeneral.Columns(1).ReadOnly = True
        dgvGeneral.Columns(1).HeaderText = "Codigo QS"
        dgvGeneral.Columns(2).ReadOnly = True
        dgvGeneral.Columns(2).HeaderText = "Descripcion"
        dgvGeneral.Columns(3).ReadOnly = True
        Me.dgvGeneral.FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Descripcion, True)
        dgvGeneral.Columns(3).HeaderText = "Fecha Revisado"
        dgvGeneral.Columns(4).ReadOnly = True
        dgvGeneral.Columns(4).HeaderText = "Tipo de Lote"
        dgvGeneral.Columns(5).ReadOnly = True
        dgvGeneral.Columns(5).HeaderText = "TipoProducto"
        Me.dgvGeneral.FormatoColumna("TipoProducto", BasesParaCompatibilidad.TiposColumna.Descripcion, True)
        dgvGeneral.Columns(5).HeaderText = "Tipo de Producto"
    End Sub

#Region "Sobrecargas BindingNavigator"
    Overrides Sub Insertar()
        Dim FrmEnt As New frmEntEspecificaciones
        FrmEnt.Text = "Insertar Especificacion"
        FrmEnt.CargarDatos(0, dgvGeneral, 0, "", "", Today, "", "")
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim dtb As New BasesParaCompatibilidad.DataBase
        ctlEsp.mostrarTodasEspecificaciones(dtb, dtsEsp)
        GeneralBindingSource.Position = 1
        GeneralBindingSource.Position = 0
    End Sub

    Overrides Sub Modificar()
        Dim Posicion As Integer = GeneralBindingSource.Position
        If Posicion >= 0 Then
            Dim FrmEnt As New frmEntEspecificaciones
            FrmEnt.Text = "Modificar Especificacion"
            FrmEnt.CargarDatos(Posicion, dgvGeneral, dgvGeneral.Rows(Posicion).Cells(0).Value, _
                               dgvGeneral.Rows(Posicion).Cells(1).Value, dgvGeneral.Rows(Posicion).Cells(2).Value, _
                               dgvGeneral.Rows(Posicion).Cells(3).Value, dgvGeneral.Rows(Posicion).Cells(4).Value, _
                               dgvGeneral.Rows(Posicion).Cells(5).Value, dgvGeneral.Rows(Posicion).Cells("LegislacionID").Value)
            BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
            Dim dtb As New BasesParaCompatibilidad.DataBase
            ctlEsp.mostrarTodasEspecificaciones(dtb, dtsEsp)
            GeneralBindingSource.Position = 1
            GeneralBindingSource.Position = Posicion
        End If
    End Sub

    Overrides Sub Ver()
        Dim Posicion As Integer = GeneralBindingSource.Position
        If Posicion >= 0 Then
            Dim FrmEn As New frmEntEspecificaciones
            FrmEn.Text = "Ver Especificacion"
            FrmEn.CargarDatos(Posicion, dgvGeneral, dgvGeneral.Rows(Posicion).Cells(0).Value, dgvGeneral.Rows(Posicion).Cells(1).Value, dgvGeneral.Rows(Posicion).Cells(2).Value, dgvGeneral.Rows(Posicion).Cells(3).Value, dgvGeneral.Rows(Posicion).Cells(4).Value, dgvGeneral.Rows(Posicion).Cells(5).Value)
            FrmEn.ShowDialog()
        End If
    End Sub

    Overrides Sub Eliminar()
        Dim Posicion As Integer = GeneralBindingSource.Position
        If Posicion >= 0 Then
            Dim response As DialogResult
            response = MessageBox.Show(" ¿Realmente desea eliminar este registro? ", " Eliminar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = DialogResult.Yes Then
                ctlEsp.setEspecificacionID(dgvGeneral.Rows(Posicion).Cells(0).Value)
                Dim dtb As New BasesParaCompatibilidad.DataBase
                dtb.EmpezarTransaccion()
                Try
                    ctlEsp.EliminarEspecificacion(dtb)
                    dtb.TerminarTransaccion()
                Catch ex As Exception
                    dtb.CancelarTransaccion()
                    MessageBox.Show("Error " & ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

                ctlEsp.mostrarTodasEspecificaciones(dtb, dtsEsp)
                If Posicion >= 0 Then
                    GeneralBindingSource.Position = Posicion - 1
                Else
                    GeneralBindingSource.Position = 0
                End If
            End If
        End If
    End Sub
#End Region

End Class