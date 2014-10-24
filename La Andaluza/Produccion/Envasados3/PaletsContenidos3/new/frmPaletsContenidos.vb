Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmPaletsContenidos
    Inherits BasesParaCompatibilidad.gridsimpleform
    Implements BasesParaCompatibilidad.Queriable

    Private dboPaletsContenidos As DBO_PaletsContenidos
    Private m_maestro2 As Integer
    Private monodosis As DispensadorMonodosis
    Private spMovimientos As spPaletsMovimiento
    Private mLinea As Integer
    Private mTipoFormatoEnvasadoID As Integer
    'Private mFecha As Date
    Private envasadoid As Integer
    Public Event completado()
    'Public WriteOnly Property Linea As Integer
    '    Set(value As Integer)
    '        Me.mLinea = value
    '    End Set
    'End Property

    'Public WriteOnly Property Tipo_formato_envasado As Integer
    '    Set(value As Integer)
    '        Me.mTipoFormatoEnvasadoID = value
    '    End Set
    'End Property

    'Public WriteOnly Property Fecha_envasado As Date
    '    Set(value As Date)
    '        Me.mFecha = value
    '    End Set
    'End Property

    Public WriteOnly Property Palet As Integer
        Set(value As Integer)
            Me.m_MaestroID = value
            Me.dboPaletsContenidos.PaletProducidoID = value

        End Set
    End Property

    Public WriteOnly Property Formato As Integer
        Set(value As Integer)
            Me.m_maestro2 = value
        End Set
    End Property

    Public ReadOnly Property Contenidos As Integer
        Get
            Return dgvGeneral.Rows.Count
        End Get
    End Property

    Public Sub New(ByVal lineaEnvasado As Integer, ByVal tipoformato As Integer, ByVal envasado As Integer, ByVal MaestroID As Integer)
        MyBase.New(New spPaletsContenidos, MaestroID)
        InitializeComponent()

        dboPaletsContenidos = New DBO_PaletsContenidos


        MyBase.newRegForm = Nothing 'New frmEntPaletsContenidos()

        Me.spMovimientos = New spPaletsMovimiento
        Me.monodosis = New DispensadorMonodosis
        Me.mLinea = lineaEnvasado
        Me.mTipoFormatoEnvasadoID = tipoformato
        Me.envasadoid = envasado
        'Me.mFecha = fechaEnvasado

        If Me.spMovimientos.comprobarFormatoEncajado(Me.mTipoFormatoEnvasadoID, dtb) Then
            Me.butModificar.Visible = False
        Else
            Me.butModificar.Visible = True
        End If
        butExcel.Visible = True
    End Sub

    'Public Overrides Sub Action(TipoAction As String)
    '    If Me.m_MaestroID <> Nothing Then
    '        MyBase.newRegForm.ModoDeAperturaCadena = TipoAction
    '        'AddHandler MyBase.newRegForm.afterSave, AddressOf dgvFill
    '        GUImain.añadirPestaña(MyBase.newRegForm)
    '    End If
    'End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        dboPaletsContenidos = New DBO_PaletsContenidos

        If m_MaestroID <> 0 Then
            dboPaletsContenidos.PaletProducidoID = m_MaestroID
            dboPaletsContenidos.id_formatoEnvasado = m_maestro2
        End If

        If Me.spMovimientos.comprobarFormatoEncajado(Me.mTipoFormatoEnvasadoID, dtb) Then
            If Not Me.monodosis.EsDoyPack(mTipoFormatoEnvasadoID, dtb) Then
                Dim frm As New frmEntPaletsContenidosMonodosis(Me.mLinea, Me.mTipoFormatoEnvasadoID, Me.envasadoid, BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp, Me.dboPaletsContenidos)
                AddHandler frm.afterSave, AddressOf Me.dgvFill
                AddHandler frm.afterSave, AddressOf Me.is_complete
                MyBase.newRegForm = frm
            Else
                Dim frm As New frmEntPaletsContenidosDoypack(Me.m_MaestroID, Me.mLinea, Me.mTipoFormatoEnvasadoID, Me.envasadoid, BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp, Me.dboPaletsContenidos)
                AddHandler frm.afterSave, AddressOf Me.dgvFill
                AddHandler frm.afterSave, AddressOf Me.is_complete
                MyBase.newRegForm = frm
            End If
        Else
            Dim frm As New frmEntPaletsContenidos(Me.mLinea, Me.mTipoFormatoEnvasadoID, Me.envasadoid, BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp, Me.dboPaletsContenidos)
            AddHandler frm.afterSave, AddressOf Me.dgvFill
            AddHandler frm.afterSave, AddressOf Me.is_complete
            MyBase.newRegForm = frm
        End If

    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboPaletsContenidos = CType(sp, spPaletsContenidos).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value, dtb)
        If Not dboPaletsContenidos Is Nothing Then

            If Me.spMovimientos.comprobarFormatoEncajado(mTipoFormatoEnvasadoID, dtb) Then
                MessageBox.Show("No se puede modificar un encajado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'If Not Me.monodosis.EsDoyPack(mTipoFormatoEnvasadoID) Then
                'MyBase.newRegForm = New frmEntPaletsContenidosMonodosis(BasesParaCompatibilidad.GridSimpleForm.ACCION_MODIFICAR, sp, Me.dboPaletsContenidos)
                ' Else
                ' MyBase.newRegForm = New frmEntPaletsContenidosDoypack(BasesParaCompatibilidad.GridSimpleForm.ACCION_MODIFICAR, sp, Me.dboPaletsContenidos)
                ' End If
            Else
                MyBase.newRegForm = New frmEntPaletsContenidos(Me.mLinea, Me.mTipoFormatoEnvasadoID, Me.envasadoid, BasesParaCompatibilidad.gridsimpleform.ACCION_MODIFICAR, sp, Me.dboPaletsContenidos)
                AddHandler MyBase.newRegForm.afterSave, AddressOf Me.dgvFill
            End If

            'newRegForm.SetDataBussinesObject(CType(Me.dboPaletsContenidos, BasesParaCompatibilidad.databussines))
        Else
            MyBase.EventHandeld = True
            MessageBox.Show("No se pudo recuperar los datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Protected Overrides Sub BindDataSource() Implements BasesParaCompatibilidad.Queriable.dataGridViewFill
        'Dim dt As DataTable = DataTableFill(Me.sp.DataGridViewStoredProcedure)

        If Not dataSource Is Nothing Then
            GeneralBindingSource.DataSource = dataSource
            With dgvGeneral
                .DataSource = GeneralBindingSource
                '.Columns("Id").Visible = False
                '.FormatoColumna("HoraInicio", BasesParaCompatibilidad.TiposColumna.FechaCorta, 80)
                '.FormatoColumna("HoraFin", BasesParaCompatibilidad.TiposColumna.FechaCorta, 80)
                '.FormatoColumna("CantidadCajas", BasesParaCompatibilidad.TiposColumna.Miles, 50)

                If .Columns.Contains("PaletContenidoID") Then .Columns("PaletContenidoID").Name = "Id"
                .Columns("Id").Visible = False
                .Columns("PaletProducidoID").Visible = False
                .Columns("EnAlmacen").Visible = False
                .Columns("Completo").Visible = False
                .Columns("gregoriano").Visible = False
                .FormatoColumna("Fecha", BasesParaCompatibilidad.TiposColumna.FechaCorta, 75)
                .FormatoColumna("Inicio", BasesParaCompatibilidad.TiposColumna.Hora, 48)
                .FormatoColumna("Fin", BasesParaCompatibilidad.TiposColumna.Hora, 44)
                .FormatoColumna("Cajas", BasesParaCompatibilidad.TiposColumna.Miles, 45)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Observaciones, True)

            End With
        End If



    End Sub

    Public Sub is_complete(sender As System.Object, e As Object)
        Dim frm As PaletContenido
        frm = sender
        If frm.Completado Then RaiseEvent completado()
    End Sub
End Class

