Public Class spLotes
    inherits BasesParaCompatibilidad.sp
    Public Sub New()
        MyBase.New("", "", "", "", "", "")
    End Sub

    Public Function comprobar(ByVal dbo As DBO_Lotes1) As Boolean
        dtb.PrepararConsulta("SELECT count(*) " & _
   "     FROM dbo.Lotes " & _
  "WHERE LoteID = @LoteId " & _
      ",Referencia = @Referencia " & _
      ",Descripcion = @Descripcion " & _
      ",Fecha = @Fecha " & _
      ",CantidadRestante = @CantidadRestante " & _
      ",Observacion = @Observacion " & _
      ",LoteProveedor = @LoteProveedor " & _
      ",Botellas = @Botellas " & _
      ",CantidadID = @CantidadID " & _
      ",MedidaID = @MedidaID " & _
      ",EspecificacionID = @EspecificacionID " & _
      ",TipoLoteID = @TipoLoteID " & _
      ",TipoProductoID = @TipoProductoID " & _
      ",CorredorID = @CorredorID " & _
      ",ProveedorID = @ProveedorID " & _
      ",LoteConjuntoCompraID = @LoteConjuntoCompraID " & _
      ",CodigoLote = @CodigoLote " & _
      ",DepositoID = @DepositoID " & _
      ",DepositoPrevioID = @DepositoPrevioID " & _
      ",Revisar = @Revisar " & _
      ",RecipienteSalidaID = @RecipienteSalidaID")


        dtb.AñadirParametroConsulta("@LoteId", dbo.LoteID)
        dtb.AñadirParametroConsulta("@Referencia", dbo.Referencia)
        dtb.AñadirParametroConsulta("@Descripcion", dbo.Descripcion)
        dtb.AñadirParametroConsulta("@Fecha", dbo.Fecha)
        dtb.AñadirParametroConsulta("@CantidadRestante", dbo.CantidadRestante)
        dtb.AñadirParametroConsulta("@Observacion", dbo.Observacion)
        dtb.AñadirParametroConsulta("@LoteProveedor", dbo.LoteProveedor)
        dtb.AñadirParametroConsulta("@Botellas", dbo.Botellas)
        dtb.AñadirParametroConsulta("@CantidadID", dbo.CantidadID)
        dtb.AñadirParametroConsulta("@MedidaID", dbo.MedidaID)
        dtb.AñadirParametroConsulta("@EspecificacionID", dbo.EspecificacionID)
        dtb.AñadirParametroConsulta("@TipoLoteID", dbo.TipoLoteID)
        dtb.AñadirParametroConsulta("@TipoProductoID", dbo.TipoProductoID)
        dtb.AñadirParametroConsulta("@CorredorID", dbo.CorredorID)
        dtb.AñadirParametroConsulta("@ProveedorID", dbo.ProveedorID)
        dtb.AñadirParametroConsulta("@LoteConjuntoCompraID", dbo.LoteConjuntoCompraID)
        dtb.AñadirParametroConsulta("@CodigoLote", dbo.CodigoLote)
        dtb.AñadirParametroConsulta("@DepositoID", dbo.DepositoID)
        dtb.AñadirParametroConsulta("@DepositoPrevioID", dbo.DepositoPrevioID)
        dtb.AñadirParametroConsulta("@Revisar", dbo.Revisar)
        dtb.AñadirParametroConsulta("@RecipienteSalidaID", dbo.RecipienteSalidaID)

        Try
            Dim dt As DataTable = dtb.Consultar()
            If dt Is Nothing Then Return False
            If dt.Rows.Count = 0 Then Return False
            If dt.Rows(0).Item(0) = 0 Then Return False
        Catch ex As Exception
            Return False
        End Try

        Return True

    End Function
End Class
