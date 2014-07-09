Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spplantillasBoletines
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
        MyBase.New("[dbo].[plantillasBoletinesSelect]", "[dbo].[plantillasBoletinesInsert]", "[dbo].[plantillasBoletinesUpdate]", "[dbo].[plantillasBoletinesDelete]", "[dbo].[plantillasBoletinesSelectDgv]", "[dbo].[plantillasBoletinesSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_plantillasBoletines
       Dim dbo As New DBO_plantillasBoletines
       dbo.searchKey = dbo.item("id")
       dbo.searchKey.value = id
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
        Dim dbo As New DBO_plantillasBoletines        

       dbo.searchKey = dbo.item("id")
        dbo.searchKey.value = id
        If trans Is Nothing Then
            BasesParaCompatibilidad.BD.EmpezarTransaccion()            
        End If

        If deleteParameters(id, BasesParaCompatibilidad.BD.transaction) And MyBase.DeleteProcedure(dbo, BasesParaCompatibilidad.BD.transaction) Then
            If trans Is Nothing Then BasesParaCompatibilidad.BD.TerminarTransaccion()
            Return True
        Else
            If trans Is Nothing Then BasesParaCompatibilidad.BD.CancelarTransaccion()
            Return False
        End If
    End Function

   Public Sub cargar_ComboBox(ByRef cbo As ComboBox)
       cbo.mam_DataSource("plantillasBoletinesSelectCbo", False)
   End Sub

    Public Function GrabarBoletin(ByVal m_dbo As DBO_plantillasBoletines, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
        Dim retorno As Boolean = True
        If trans Is Nothing Then BasesParaCompatibilidad.BD.EmpezarTransaccion()
        Try
            If m_dbo.id = Nothing Then
                retorno = retorno And MyBase.InsertProcedure(m_dbo, BasesParaCompatibilidad.BD.transaction)
                m_dbo.id = BasesParaCompatibilidad.BD.ConsultaVer("top 1 id", "PlantillasBoletines", String.Empty, "id desc").Rows(0).Item(0) 'BasesParaCompatibilidad.BD.ConsultaVer("IDENT_CURRENT('plantillasboletines')", String.Empty).Rows(0).Item(0) '("max(id)", "PlantillasBoletines").Rows(0).Item(0) + 1            
            Else
                retorno = retorno And MyBase.UpdateProcedure(m_dbo, BasesParaCompatibilidad.BD.transaction)
                retorno = retorno And deleteParameters(m_dbo, BasesParaCompatibilidad.BD.transaction)
            End If

            retorno = retorno And insertParametros(m_dbo, BasesParaCompatibilidad.BD.transaction)

            If retorno Then
                If trans Is Nothing Then BasesParaCompatibilidad.BD.TerminarTransaccion()
            Else
                If trans Is Nothing Then BasesParaCompatibilidad.BD.CancelarTransaccion()
            End If
        Catch ex As Exception
            If trans Is Nothing Then BasesParaCompatibilidad.BD.CancelarTransaccion()
            retorno = False
            messagebox.show("No se pudo guardar. Detalles: " & Environment.NewLine & Environment.NewLine & ex.Message, "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return retorno
    End Function

    Private Function insertParametros(ByVal m_dbo As DBO_plantillasBoletines, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
        Dim m_aux As New Dbo_BoletinesParametros
        If trans Is Nothing Then BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection = BasesParaCompatibilidad.BD.Cnx

        Try
            For Each m_aux In m_dbo.Parametros

                Dim insertProcedure As String = "[dbo].[PlantillasBoletinesInsertParametros]"
                Dim insertCommand As New System.Data.SqlClient.SqlCommand(insertProcedure, connection)
                insertCommand.CommandType = CommandType.StoredProcedure
                If Not trans Is Nothing Then insertCommand.Transaction = trans

                insertCommand.Parameters.AddWithValue("@IdBoletin", m_dbo.ID)
                insertCommand.Parameters.AddWithValue("@IdParametro", m_aux.IdParametro)
                insertCommand.Parameters.AddWithValue("@FechaModificacion", If(m_aux.FechaModificacion.HasValue, m_aux.FechaModificacion, Today))
                insertCommand.Parameters.AddWithValue("@UsuarioModificacion", If(m_aux.UsuarioModificacion.HasValue, m_aux.UsuarioModificacion, BasesParaCompatibilidad.Config.User))

                insertCommand.ExecuteNonQuery()
            Next

            Return True
        Catch ex As System.Data.SqlClient.SqlException
            Return False
        Finally
            If trans Is Nothing Then connection.Close()
        End Try
    End Function

    Private Function deleteParameters(ByVal m_dbo As DBO_plantillasBoletines, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
        'Dim m_aux As New Dbo_BoletinesParametros
        'If trans Is Nothing Then BasesParaCompatibilidad.BD.Conectar()
        'Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        'TO DO: EDITAR
        Return deleteParameters(m_dbo.id, trans)
        'Try
        '    For Each m_aux In m_dbo.Parametros

        '        Dim deleteProcedure As String = "[dbo].[PlantillasBoletinesDeleteParametros]"
        '        Dim deleteCommand As New System.Data.SqlClient.SqlCommand(deleteProcedure, connection)
        '        deleteCommand.CommandType = CommandType.StoredProcedure
        '        If Not trans Is Nothing Then deleteCommand.Transaction = trans

        '        deleteCommand.Parameters.AddWithValue("@Id", m_dbo.id)

        '        deleteCommand.ExecuteNonQuery()
        '    Next

        '    Return True
        'Catch ex As System.Data.SqlClient.SqlException
        '    Return False
        'Finally
        '    If trans Is Nothing Then connection.Close()
        'End Try
    End Function

    Private Function deleteParameters(ByVal id As String, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
        If trans Is Nothing Then BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection = BasesParaCompatibilidad.BD.Cnx
        'TO DO: EDITAR
        Try
            Dim deleteProcedure As String = "[dbo].[PlantillasBoletinesDeleteParametros]"
            Dim deleteCommand As New System.Data.SqlClient.SqlCommand(deleteProcedure, connection)
            deleteCommand.CommandType = CommandType.StoredProcedure
            If Not trans Is Nothing Then deleteCommand.Transaction = trans

            deleteCommand.Parameters.AddWithValue("@Id", id)

            deleteCommand.ExecuteNonQuery()

            Return True
        Catch ex As System.Data.SqlClient.SqlException
            Return False
        Finally
            If trans Is Nothing Then connection.Close()
        End Try
    End Function

    Public Sub cargarCboTiposProducto(ByRef cbo As System.Windows.Forms.ComboBox)
        cargarCombo(cbo, "TiposProductosSelectCbo")
    End Sub

    Public Sub cargarCboLotesPorTipoProducto(ByRef cbo As System.Windows.Forms.ComboBox, ByVal tipoProducto As Integer)
        cargarCombo(cbo, "LotesAnalizadosByTipoProducto " & tipoProducto)
        'cbo.mam_DataSource(spLotes1.DgvFillLotesTerminadosPorTipoProducto(tipoProducto), False)
    End Sub

    Public Sub cargarCboPlantillasPorlotesCompatibles(ByRef cbo As System.Windows.Forms.ComboBox, ByVal lote As Integer)
        cargarCombo(cbo, "PlantillasSelectCboPorLote " & lote)
    End Sub

    Private Sub cargarCombo(ByRef cbo As System.Windows.Forms.ComboBox, ByVal sp As String)
        cbo.mam_DataSource(dtb.Consultar(sp), False)
    End Sub

    Public Sub cargaComboAnalistas(ByRef cbo As System.Windows.Forms.ComboBox)
        'Dim ctlPer As New ctlPersonal
        'RellenarComboBox(cbo, ctlPer.devolverAnalistas(), False)
        Dim spAux As New spEmpleados
        spAux.cargar_Empleados_Analistas(cbo)
    End Sub

    Public Function cargo(ByVal personalId As Integer) As String
        'Dim ctlPer As New ctlPersonal
        'Return ctlPer.devolverCargo(personalId)
        Try
            Dim spAux As New spempleados_contratos
            Dim spPuestosTrabajos As New spPuestosTrabajos
            Dim dbo As DBO_empleados_contratos = spAux.select_ultimo_contrato(personalId)
            Dim dbo_puesto As DBO_PuestosTrabajos = spPuestosTrabajos.Select_Record(dbo.id_puestoTrabajo)
            Return dbo_puesto.Descripcion
        Catch ex As Exception
            Return String.Empty
        End Try
    End Function

    Public Function SeleccionarTodos() As DataTable
        Return dtb.Consultar("SelectAllBoletinesPlantillas")
    End Function
End Class
