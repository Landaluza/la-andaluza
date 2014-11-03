Imports BasesParaCompatibilidad.DataGridViewExtension


Public Class frmProveedores
    Inherits BasesParaCompatibilidad.GridSimpleForm


    Private dboProveedores As DBO_Proveedores
    Private tsInactivos As ToolStripButton
    Private tsCarpeta As ToolStripButton
    Private tsInformacion As ToolStripButton
    Private tsInforme As ToolStripButton
    Private tsBorradoLogico As ToolStripButton


    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spProveedores(MaestroID), MaestroID)
        InitializeComponent()
    
        dboProveedores = New DBO_Proveedores


        MyBase.newRegForm = New frmEntProveedores(ACCION_INSERTAR, sp)


        tsBorradoLogico = Me.bdnGeneral.Items.Add("Marcar como inactivo")
        tsBorradoLogico.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsBorradoLogico.ToolTipText = "Marcar como inactivo"
        tsBorradoLogico.Image = My.Resources.application_exit_4
        tsBorradoLogico.TextDirection = ToolStripTextDirection.Horizontal
        tsBorradoLogico.TextAlign = ContentAlignment.MiddleRight
        AddHandler tsBorradoLogico.Click, AddressOf EliminadoLogico

        If Me.m_MaestroID = "" Then

            tsInactivos = Me.bdnGeneral.Items.Add("Mostrar los proveedores inactivos")
            tsInactivos.DisplayStyle = ToolStripItemDisplayStyle.Image
            tsInactivos.CheckOnClick = True
            tsInactivos.Image = My.Resources.agenda
            tsInactivos.TextDirection = ToolStripTextDirection.Horizontal
            tsInactivos.TextAlign = ContentAlignment.MiddleRight
            AddHandler tsInactivos.Click, AddressOf dgvFill
            AddHandler tsInactivos.CheckStateChanged, AddressOf state_changed
        End If

        tsCarpeta = Me.bdnGeneral.Items.Add("Navegar a la carpeta del proveedor")
        tsCarpeta.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsCarpeta.ToolTipText = "Navegar a la carpeta del proveedor"
        tsCarpeta.Image = My.Resources.open
        tsCarpeta.TextDirection = ToolStripTextDirection.Horizontal
        tsCarpeta.TextAlign = ContentAlignment.MiddleRight
        AddHandler tsCarpeta.Click, AddressOf abrirCarpeta

        tsInformacion = Me.bdnGeneral.Items.Add("Información general")
        tsInformacion.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsInformacion.ToolTipText = "Información general"
        tsInformacion.Image = My.Resources.page_white_word_16
        tsInformacion.TextDirection = ToolStripTextDirection.Horizontal
        tsInformacion.TextAlign = ContentAlignment.MiddleRight
        AddHandler tsInformacion.Click, AddressOf abrirArchivo

        tsInforme = Me.bdnGeneral.Items.Add("Informe de proveedores")
        tsInforme.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsInforme.ToolTipText = "Informe de proveedores"
        tsInforme.Image = My.Resources.page_excel_16
        tsInforme.TextDirection = ToolStripTextDirection.Horizontal
        tsInforme.TextAlign = ContentAlignment.MiddleRight
        AddHandler tsInforme.Click, AddressOf InformeProveedores


    End Sub




    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        dboProveedores = New DBO_Proveedores
        If m_MaestroID <> "" Then dboProveedores.Nombre = m_MaestroID
        MyBase.newRegForm = New frmEntProveedores(ACCION_INSERTAR, sp, Me.dboProveedores)
        'newRegForm.SetDataBussinesObject(Me.dboProveedores)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        Dim dtb As New BasesParaCompatibilidad.DataBase
        dboProveedores = CType(sp, spProveedores).Select_Record(dgvGeneral.CurrentRow.Cells("ProveedorID").Value, dtb)
        If Not dboProveedores Is Nothing Then
            MyBase.newRegForm = New frmEntProveedores(ACCION_MODIFICAR, sp, Me.dboProveedores)
            ''newRegForm.SetDataBussinesObject(Me.dboProveedores)
        Else
            MyBase.EventHandeld = True
            MessageBox.Show("No se pudo recuperar los datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub state_changed()
        If Me.tsInactivos.CheckState Then
            Me.tsInactivos.Text = "Mostrar proveedores activos"
        Else
            Me.tsInactivos.Text = "Mostrar proveedores inactivos"
        End If
    End Sub
    Protected Overrides Sub cargar_datos()
        Dim dtb As New BasesParaCompatibilidad.DataBase
        If Not Me.tsInactivos Is Nothing Then
            If Me.tsInactivos.CheckState Then
                dataSource = dtb.Consultar(CType(sp, spProveedores).DataGridViewStoredProcedure2, True)
            Else
                dataSource = dtb.Consultar(Me.sp.DataGridViewStoredProcedure, True)
            End If
        Else
            dataSource = dtb.Consultar(Me.sp.DataGridViewStoredProcedure, True)
        End If
    End Sub
    Protected Overrides Sub BindDataSource()
        If Not dataSource Is Nothing Then
            GeneralBindingSource.DataSource = dataSource
            With dgvGeneral
                .DataSource = GeneralBindingSource

                .Columns("ProveedorID").Visible = False
                .Columns("Ruta").Visible = False
                .Columns("InformacionGeneral").Visible = False
                .Columns("QS").Visible = False
                .FormatoColumna("Nombre", BasesParaCompatibilidad.TiposColumna.Referencia, True, 2, 328)
                .Columns("ProveedorCero").DisplayIndex = 1

            End With
        End If

        'If dgvGeneral.RowCount > 0 Then
        '    If Not Me.dgvGeneral.Columns.Contains("+") Then
        '        Dim buttonColumn As New DataGridViewImageColumn()
        '        buttonColumn.HeaderText = ""
        '        buttonColumn.Name = "+"
        '        buttonColumn.Image = My.Resources.open
        '        buttonColumn.Width = 30
        '        dgvGeneral.Columns.Add(buttonColumn)
        '    End If
        'End If


        'Me.butEliminar.Visible = False

    End Sub


    Private Sub abrirCarpeta()

        If Not IsDBNull(Me.dgvGeneral.CurrentRow.Cells("Ruta").Value) Then
            Process.Start(Me.dgvGeneral.CurrentRow.Cells("Ruta").Value)
        Else
            Dim resp As DialogResult = messagebox.show("El proveedor no tiene una carpeta asignada, ¿asignar una?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resp = DialogResult.Yes Then
                Dim FolderBrowserDialog1 As New FolderBrowserDialog

                With FolderBrowserDialog1
                    .RootFolder = Environment.SpecialFolder.MyComputer
                    .SelectedPath = "Z:\Compras\Proveedores\1&1 Internet España\"
                    .Description = "Selecciona la carpeta del proveedor"
                    .ShowNewFolderButton = True

                    If .ShowDialog = DialogResult.OK Then
                        Dim dtb As New BasesParaCompatibilidad.DataBase
                        dtb.PrepararConsulta("update proveedores set ruta= @ruta where proveedorID= @id")
                        dtb.AñadirParametroConsulta("@ruta", .SelectedPath)
                        dtb.AñadirParametroConsulta("@id", Me.dgvGeneral.CurrentRow.Cells("ProveedorID").Value)
                        If dtb.Consultar(True) Then
                            Me.dgvFill()
                        Else
                            MessageBox.Show("no se pudo actualizar el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        End If
                    End If
                End With
            End If
        End If

    End Sub

    Private Sub abrirArchivo()
        If Not IsDBNull(Me.dgvGeneral.CurrentRow.Cells("InformacionGeneral").Value) Then
            Dim f As New BasesParaCompatibilidad.File(Me.dgvGeneral.CurrentRow.Cells("InformacionGeneral").Value)
            f.open()
        End If
    End Sub

    Public Overrides Sub Eliminar(Optional ByVal campoId As String = "Id")
        Dim response As DialogResult
        response = messagebox.show(" ¿Desea dejar el proveedor seleccionado como inactivo? ", _
                          "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = DialogResult.Yes Then
            Dim dtb As New BasesParaCompatibilidad.DataBase
            If CType(Me.sp, spProveedores).MarcarInactivo(dtb, Me.dboProveedores.ProveedorID) Then
                Me.dgvFill()
            End If
        End If
    End Sub

    Public Sub EliminadoLogico()
        Dim response As DialogResult
        response = MessageBox.Show(" ¿Desea dejar el proveedor seleccionado como inactivo? ", _
                          "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = DialogResult.Yes Then
            Dim dtb As New BasesParaCompatibilidad.DataBase
            If CType(Me.sp, spProveedores).MarcarInactivo(dtb, Me.dboProveedores.ProveedorID) Then
                Me.dgvFill()
            End If
        End If
    End Sub

    Private Sub InformeProveedores()
        Dim frm As New frmInformeProveedores
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm)
    End Sub
End Class
