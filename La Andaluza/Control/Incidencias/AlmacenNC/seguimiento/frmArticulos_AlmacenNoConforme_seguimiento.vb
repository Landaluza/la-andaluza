Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmArticulos_AlmacenNoConforme_seguimiento
    Inherits BasesParaCompatibilidad.gridsimpleform

    Private dboArticulos_AlmacenNoConforme_seguimiento As DBO_Articulos_AlmacenNoConforme_seguimiento

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spArticulos_AlmacenNoConforme_seguimiento, MaestroID)
        InitializeComponent()

        dboArticulos_AlmacenNoConforme_seguimiento = New DBO_Articulos_AlmacenNoConforme_seguimiento


        MyBase.newRegForm = New frmEntArticulos_AlmacenNoConforme_seguimiento(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub




    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        If m_MaestroID <> 0 Then
            dboArticulos_AlmacenNoConforme_seguimiento = New DBO_Articulos_AlmacenNoConforme_seguimiento
            dboArticulos_AlmacenNoConforme_seguimiento.Id_Articulos_AlmacenNoConforme = m_MaestroID
        End If
        newRegForm.SetDataBussinesObject(Me.dboArticulos_AlmacenNoConforme_seguimiento)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboArticulos_AlmacenNoConforme_seguimiento = CType(sp, spArticulos_AlmacenNoConforme_seguimiento).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value)
        If Not dboArticulos_AlmacenNoConforme_seguimiento Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboArticulos_AlmacenNoConforme_seguimiento)
        Else
            MyBase.EventHandeld = True
            MessageBox.Show("No se pudo recuperar los datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Protected Overrides Sub cargar_datos()
        dataSource = sp.select_DgvBy(Me.m_MaestroID)
    End Sub

    Protected Overrides Sub BindDataSource()
        'Dim dt As DataTable = sp.select_DgvBy(Me.m_MaestroID) 'DataTableFill(Me.sp.DataGridViewStoredProcedure)

        If Not dataSource Is Nothing Then
            GeneralBindingSource.DataSource = dataSource
            With dgvGeneral
                .DataSource = GeneralBindingSource
                .Columns("Id").Visible = False
                .FormatoColumna("Fecha", BasesParaCompatibilidad.TiposColumna.FechaCorta, 90)
                .FormatoColumna("observaciones", "Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If

        BindingNavigatorSinRegistros()
        butEliminar.Visible = True
        '

    End Sub

    Public Sub refrescar(ByVal mestro As Integer)
        Me.m_MaestroID = mestro
        dgvFill()
    End Sub


End Class
