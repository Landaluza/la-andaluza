Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmArticulosIngredientesTipos
    Inherits BasesParaCompatibilidad.FrmAheredarOld

    Private m_VerID As Boolean = True

    Private m_ArticuloIngredienteTipo As DBO_ArticulosIngredientesTipos
    Private frmEnt As frmEntArticulosIngredientesTipos
    Public Sub New(ByVal MaestroID As Integer)
        MyBase.New(New spArticulosIngredientesTipos, MaestroID)
        InitializeComponent()

        spSelectDgv = "ArticulosIngredientesTiposSelectDgvByID '" & MaestroID & "'"
        m_VerID = False
    End Sub

    Public Sub New()
        MyBase.New(New spArticulosIngredientesTipos, 0)
        InitializeComponent()
        spSelectDgv = "ArticulosIngredientesTiposSelectDgv"
    End Sub



    Overrides Sub Eliminar()
        If MessageBox.Show(" ¿Realmente quieres eliminar este registro ? ", _
                          "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim dtb As New BasesParaCompatibilidad.DataBase
            If CType(sp, spArticulosIngredientesTipos).ArticulosIngredientesTiposDelete(dgvGeneral.CurrentRow.Cells("IngredienteTipoID").Value, dtb) Then
                dgvFill()
            End If
        End If
    End Sub



    Overrides Sub Action(ByVal TipoAction As String)
        m_ArticuloIngredienteTipo = New DBO_ArticulosIngredientesTipos
        Dim m_Pos As Integer = GeneralBindingSource.Position

        If TipoAction = ACCION_INSERTAR Then

            If m_MaestroID <> 0 Then m_ArticuloIngredienteTipo.Descripcion = m_MaestroID
        Else
            Dim dtb As New BasesParaCompatibilidad.DataBase
            m_ArticuloIngredienteTipo = CType(sp, spArticulosIngredientesTipos).Select_Record(GeneralBindingSource(m_Pos).Item("IngredienteTipoID"), dtb)
        End If

        frmEnt = New frmEntArticulosIngredientesTipos(m_ArticuloIngredienteTipo, m_Pos, m_VerID)
        frmEnt.Text = String.Format("{0} {1}", TipoAction, Me.Text)
        AddHandler frmEnt.FormClosed, AddressOf dgvFill
        GUImain.añadirPestaña(frmEnt)

    End Sub


    Protected Overrides Sub cargar_datos()
        Dim dtb As New BasesParaCompatibilidad.DataBase
        dtb.PrepararConsulta(spSelectDgv)
        dataSource = dtb.Consultar()
    End Sub
    Protected Overrides Sub BindDataSource()
        If Not dataSource Is Nothing Then
            GeneralBindingSource.DataSource = dataSource


            butExcel.Visible = True

            With dgvGeneral
                .DataSource = GeneralBindingSource

                .Columns("IngredienteTipoID").Visible = False
                .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, True, 1)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True, 2)
                .FormatoGeneral()
            End With
        End If
    End Sub

End Class
