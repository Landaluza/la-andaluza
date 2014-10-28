Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spplantillasBoletines
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
        MyBase.New("[dbo].[plantillasBoletinesSelect]", "[dbo].[plantillasBoletinesInsert]", "[dbo].[plantillasBoletinesUpdate]", "[dbo].[plantillasBoletinesDelete]", "[dbo].[plantillasBoletinesSelectDgv]", "[dbo].[plantillasBoletinesSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_plantillasBoletines
        Dim dbo As New DBO_plantillasBoletines
        dbo.searchKey = dbo.item("id")
        dbo.searchKey.value = id
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_plantillasBoletines
        Dim terminar As Boolean

        dbo.searchKey = dbo.item("id")
        dbo.searchKey.value = id
        If dtb.Transaccion Is Nothing Then
            dtb.EmpezarTransaccion()
        End If

        If deleteParameters(id, dtb) And MyBase.DeleteProcedure(dbo, dtb) Then
            If terminar Then dtb.TerminarTransaccion()
            Return True
        Else
            If terminar Then dtb.CancelarTransaccion()
            Return False
        End If
    End Function

    Public Sub cargar_ComboBox(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("plantillasBoletinesSelectCbo", False, dtb)
    End Sub

    Public Function GrabarBoletin(ByRef dtb As BasesParaCompatibilidad.DataBase, ByVal m_dbo As DBO_plantillasBoletines) As Boolean
        Dim retorno As Boolean = True
        Dim terminar As Boolean
        If dtb.Transaccion Is Nothing Then
            dtb.EmpezarTransaccion()
            terminar = True
        Else
            terminar = False
        End If
        Try
            If m_dbo.id = Nothing Then
                retorno = retorno And MyBase.InsertProcedure(m_dbo, dtb)
                dtb.PrepararConsulta("select top 1 id from PlantillasBoletines order by id desc")
                m_dbo.id = dtb.Consultar().Rows(0).Item(0) 'Deprecated.ConsultaVer("IDENT_CURRENT('plantillasboletines')", String.Empty).Rows(0).Item(0) '("max(id)", "PlantillasBoletines").Rows(0).Item(0) + 1            
            Else
                retorno = retorno And MyBase.UpdateProcedure(m_dbo, dtb)
                retorno = retorno And deleteParameters(m_dbo, dtb)
            End If

            retorno = retorno And insertParametros(m_dbo, dtb)

            If retorno Then
                If terminar Then dtb.TerminarTransaccion()
            Else
                If terminar Then dtb.CancelarTransaccion()
            End If
        Catch ex As Exception
            If terminar Then dtb.CancelarTransaccion()
            retorno = False
            MessageBox.Show("No se pudo guardar. Detalles: " & Environment.NewLine & Environment.NewLine & ex.Message, "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            dtb.Desconectar()
        End Try

        Return retorno
    End Function

    Private Function insertParametros(ByVal m_dbo As DBO_plantillasBoletines, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim m_aux As New Dbo_BoletinesParametros
        dtb.Conectar()


        Try
            For Each m_aux In m_dbo.Parametros

                Dim insertProcedure As String = "[dbo].[PlantillasBoletinesInsertParametros]"
                Dim insertCommand As System.Data.SqlClient.SqlCommand = dtb.comando(insertProcedure)
                insertCommand.CommandType = CommandType.StoredProcedure


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
            dtb.Desconectar()
        End Try
    End Function

    Private Function deleteParameters(ByVal m_dbo As DBO_plantillasBoletines, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        'Dim m_aux As New Dbo_BoletinesParametros
        'dtb.Conectar 
        'Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        'TO DO: EDITAR
        Return deleteParameters(m_dbo.id, dtb)
        'Try
        '    For Each m_aux In m_dbo.Parametros

        '        Dim deleteProcedure As String = "[dbo].[PlantillasBoletinesDeleteParametros]"
        '        Dim deleteCommand As  System.Data.SqlClient.SqlCommand = dtb.comando(deleteProcedure)
        '        deleteCommand.CommandType = CommandType.StoredProcedure
        '        

        '        deleteCommand.Parameters.AddWithValue("@Id", m_dbo.id)

        '        deleteCommand.ExecuteNonQuery()
        '    Next

        '    Return True
        'Catch ex As System.Data.SqlClient.SqlException
        '    Return False
        'Finally
        '    dtb.Desconectar 
        'End Try
    End Function

    Private Function deleteParameters(ByVal id As String, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        'TO DO: EDITAR
        Try
            Dim deleteProcedure As String = "[dbo].[PlantillasBoletinesDeleteParametros]"
            Dim deleteCommand As System.Data.SqlClient.SqlCommand = dtb.comando(deleteProcedure)
            deleteCommand.CommandType = CommandType.StoredProcedure


            deleteCommand.Parameters.AddWithValue("@Id", id)

            deleteCommand.ExecuteNonQuery()

            Return True
        Catch ex As System.Data.SqlClient.SqlException
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Sub cargarCboTiposProducto(ByRef cbo As System.Windows.Forms.ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cargarCombo(cbo, "TiposProductosSelectCbo", dtb)
    End Sub

    Public Sub cargarCboLotesPorTipoProducto(ByRef cbo As System.Windows.Forms.ComboBox, ByVal tipoProducto As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cargarCombo(cbo, "LotesAnalizadosByTipoProducto " & tipoProducto, dtb)
        'cbo.mam_DataSource(spLotes1.DgvFillLotesTerminadosPorTipoProducto(tipoProducto), False)
    End Sub

    Public Sub cargarCboPlantillasPorlotesCompatibles(ByRef cbo As System.Windows.Forms.ComboBox, ByVal lote As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cargarCombo(cbo, "PlantillasSelectCboPorLote " & lote, dtb)
    End Sub

    Private Sub cargarCombo(ByRef cbo As System.Windows.Forms.ComboBox, ByVal sp As String, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource(sp, False, dtb)
    End Sub

    Public Sub cargaComboAnalistas(ByRef cbo As System.Windows.Forms.ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        'Dim ctlPer As New ctlPersonal
        'RellenarComboBox(cbo, ctlPer.devolverAnalistas(), False)
        Dim spAux As New spEmpleados
        spAux.cargar_Empleados_Analistas(cbo, dtb)
    End Sub

    Public Function cargo(ByVal personalId As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As String
        'Dim ctlPer As New ctlPersonal
        'Return ctlPer.devolverCargo(personalId)
        Try
            Dim spAux As New spempleados_contratos
            Dim spPuestosTrabajos As New spPuestosTrabajos
            Dim dbo As DBO_empleados_contratos = spAux.select_ultimo_contrato(personalId, dtb)
            Dim dbo_puesto As DBO_PuestosTrabajos = spPuestosTrabajos.Select_Record(dbo.id_puestoTrabajo, dtb)
            Return dbo_puesto.Descripcion
        Catch ex As Exception
            Return String.Empty
        End Try
    End Function

    Public Function SeleccionarTodos(ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable
        Return dtb.Consultar("SelectAllBoletinesPlantillas", True)
    End Function
End Class
