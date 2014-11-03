Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmAsignarArticuloAarticulo
    Private id_articulo As Integer
    Public id As Integer
    Public descripcion As String
    Private AsignarSecundario As Boolean
    Private guardar As Boolean
    Private dtb As BasesParaCompatibilidad.DataBase
    Public Sub New(ByVal id As Integer, Optional asignaciondeprimario As Boolean = False, Optional ByVal guardar As Boolean = True)

        InitializeComponent()
        dtb = New BasesParaCompatibilidad.DataBase
        id_articulo = id
        Me.AsignarSecundario = Not asignaciondeprimario
        Me.guardar = guardar
    End Sub


    Private Sub frmAsignarSecundario_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim dt As DataTable

        If Me.AsignarSecundario Then
            dtb.PrepararConsulta("select descripcionLa, articulos1.articuloid, envasesecundarioID from articulos1, articulosenvasessecundarios where articulosenvasessecundarios.articuloid = articulos1.articuloID and articulotpoid = 9 ")
        Else
            dtb.PrepararConsulta("select descripcionLa, articulos1.articuloid from articulos1 where articulotpoid = 8 ")
        End If

        dt = dtb.Consultar()

        If Not dt Is Nothing Then
            Me.DataGridView1.DataSource = dt
            Me.DataGridView1.Columns("articuloid").Visible = False
            Me.DataGridView1.FormatoColumna("descripcionla", BasesParaCompatibilidad.TiposColumna.Descripcion, True)
        End If

        Dim filterManager As New DgvFilterPopup.DgvFilterManager(DataGridView1)
    End Sub


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        terminar()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        terminar()
    End Sub

    Private Sub terminar()
        Dim id As Integer = Me.DataGridView1.CurrentRow.Cells("articuloid").Value

        Me.id = Me.DataGridView1.CurrentRow.Cells("articuloid").Value
        Me.descripcion = Me.DataGridView1.CurrentRow.Cells("descripcionLa").Value

        dtb.EmpezarTransaccion()
        Try
            If Me.AsignarSecundario Then
                dtb.PrepararConsulta("delete from articulos1_articulos1_compuestopor where id_articulo= @id and id_articuloCompuestopor in (select articuloId from articulos1 where articulotpoid = 9)")
                dtb.AñadirParametroConsulta("@id", id_articulo)
                If Not dtb.Consultar(True) Then Throw New Exception("No se pudo borrar la composicion")

                dtb.PrepararConsulta("insert into articulos1_articulos1_compuestopor(id_articulo, id_articuloCompuestopor) values(@id,@idc)")
                dtb.AñadirParametroConsulta("@id", id_articulo)
                dtb.AñadirParametroConsulta("@idc", id)
                If Not dtb.Consultar(True) Then Throw New Exception("No se pudo guardar la composicion")

                Dim spArticulosEnvasesSecundarios As New spArticulosEnvasesSecundarios
                Dim m_aux As DBO_ArticulosEnvasesSecundarios = spArticulosEnvasesSecundarios.Select_RecordByArticuloID(id, dtb)
                Me.id = m_aux.ID

                dtb.PrepararConsulta("update articulosenvasessecundarios set id_articuloPrimario = @pri where articuloid = @art")
                dtb.AñadirParametroConsulta("@pri", m_aux.ID)
                dtb.AñadirParametroConsulta("@art", id_articulo)
                If Not dtb.Consultar(True) Then Throw New Exception("Error al actualziar el articulo")

            Else
                If Me.guardar Then
                    dtb.PrepararConsulta("delete from articulos1_articulos1_compuestopor where id_articulo= @ar and id_articuloCompuestopor = @com")
                    dtb.AñadirParametroConsulta("@ar", id_articulo)
                    dtb.AñadirParametroConsulta("@com", id)
                    If Not dtb.Consultar(True) Then Throw New Exception("Error borrando composicion")

                    dtb.PrepararConsulta("insert into articulos1_articulos1_compuestopor(id_articulo, id_articuloCompuestopor) values( @ar , @com)")
                    dtb.AñadirParametroConsulta("@ar", id_articulo)
                    dtb.AñadirParametroConsulta("@com", id)
                    If Not dtb.Consultar(True) Then Throw New Exception("Error guardando composicion")


                    dtb.PrepararConsulta("update articulosenvasessecundarios set id_articuloPrimario = @pri where articuloid = @art")
                    dtb.AñadirParametroConsulta("@art", id_articulo)
                    dtb.AñadirParametroConsulta("@pri", id)
                    If Not dtb.Consultar(True) Then Throw New Exception("Error borrando composicion")
                End If
            End If

            dtb.TerminarTransaccion()
        Catch ex As Exception
            dtb.CancelarTransaccion()
            MessageBox.Show("Error al relacionar los articulos. Detalles: " & Environment.NewLine & ex.Message)
        End Try
        Me.Close()
    End Sub
End Class