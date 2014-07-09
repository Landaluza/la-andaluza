Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmAsignarArticuloAarticulo
    Private id_articulo As Integer
    Public id As Integer
    Public descripcion As String
    Private AsignarSecundario As Boolean
    Private guardar As Boolean

    Public Sub New(ByVal id As Integer, Optional asignaciondeprimario As Boolean = False, Optional ByVal guardar As Boolean = True)

        InitializeComponent()

        id_articulo = id
        Me.AsignarSecundario = Not asignaciondeprimario
        Me.guardar = guardar
    End Sub


    Private Sub frmAsignarSecundario_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim dtb As New BasesParaCompatibilidad.DataBase(BasesParaCompatibilidad.Config.Server)
        Dim dt As DataTable

        If Me.AsignarSecundario Then
            'dt = dtb.Consultar("select descripcionLa, articulos1.articuloid, envasesecundarioID from articulos1, articulosenvasessecundarios where articulosenvasessecundarios.articuloid = articulos1.articuloID and articulotpoid = 9 and articulos1.articuloid not in(select articuloid from articulosenvasessecundarios where envasesecundarioid in (select id_articuloenvasesecundario from articulosenvasesterciarios))", False)
            dt = dtb.Consultar("select descripcionLa, articulos1.articuloid, envasesecundarioID from articulos1, articulosenvasessecundarios where articulosenvasessecundarios.articuloid = articulos1.articuloID and articulotpoid = 9 ", False)
        Else
            'dt = dtb.Consultar("select descripcionLa, articulos1.articuloid from articulos1 where articulotpoid = 8 and articulos1.articuloid not in(select isnull(id_articuloPrimario, 0) from articulosenvasessecundarios)", False)
            dt = dtb.Consultar("select descripcionLa, articulos1.articuloid from articulos1 where articulotpoid = 8 ", False)
        End If

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

        Dim dtb As New BasesParaCompatibilidad.DataBase(BasesParaCompatibilidad.Config.Server)
        dtb.EmpezarTransaccion()
        Try
            If Me.AsignarSecundario Then

                dtb.ConsultaAlteraciones("delete from articulos1_articulos1_compuestopor where id_articulo=" & id_articulo & " and id_articuloCompuestopor in (select articuloId from articulos1 where articulotpoid = 9)")
                dtb.ConsultaAlteraciones("insert into articulos1_articulos1_compuestopor(id_articulo, id_articuloCompuestopor) values(" & id_articulo & "," & id & ")")

                Dim spArticulosEnvasesSecundarios As New spArticulosEnvasesSecundarios
                Dim m_aux As DBO_ArticulosEnvasesSecundarios = spArticulosEnvasesSecundarios.Select_RecordByArticuloID(id, dtb.Transaccion)
                Me.id = m_aux.ID

                dtb.ConsultaAlteraciones("update articulosenvasessecundarios set id_articuloPrimario =" & m_aux.ID & " where articuloid = " & id_articulo)
            Else
                If Me.guardar Then
                    dtb.ConsultaAlteraciones("delete from articulos1_articulos1_compuestopor where id_articulo=" & id_articulo & " and id_articuloCompuestopor =" & id)
                    dtb.ConsultaAlteraciones("insert into articulos1_articulos1_compuestopor(id_articulo, id_articuloCompuestopor) values(" & id_articulo & "," & id & ")")

                    dtb.ConsultaAlteraciones("update articulosenvasessecundarios set id_articuloPrimario =" & id & " where articuloid = " & id_articulo)
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