Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmArticulosFichasPaletizados1
    Inherits BasesParaCompatibilidad.FrmAheredarOld


    Private m_VerID As Boolean = True
    Private frmEnt As frmEntArticulosFichasPaletizados1

    Public Sub New(ByVal MaestroID As Integer)
        MyBase.New(New spArticulosFichasPaletizados1, MaestroID)
        InitializeComponent()

        spSelectDgv = "ArticulosFichasPaletizados1SelectDgvByArticuloID '" & MaestroID & "'"

        m_VerID = False
    End Sub

    Public Sub New()
        MyBase.New(New spArticulosFichasPaletizados1, 0)
        InitializeComponent()
        spSelectDgv = "ArticulosFichasPaletizados1SelectDgv"
    End Sub

    Overrides Sub Eliminar()
        If MessageBox.Show(" ¿Realmente quieres eliminar este registro ? ", _
                           "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim dtb As New BasesParaCompatibilidad.DataBase
            If CType(sp, spArticulosFichasPaletizados1).ArticulosFichasPaletizados1Delete(dgvGeneral.CurrentRow.Cells("ArticuloFichaPaletizadoID").Value, dtb) Then
                dgvFill()
            End If
        End If

    End Sub



    Overrides Sub Action(ByVal TipoAction As String)
        Dim m_ArticulosFichasPaletizados1 As New DBO_ArticulosFichasPaletizados1
        Dim m_Pos As Integer = GeneralBindingSource.Position

        If TipoAction = ACCION_INSERTAR Then

            If m_MaestroID <> 0 Then m_ArticulosFichasPaletizados1.ArticuloID = m_MaestroID
        Else
            Dim dtb As New BasesParaCompatibilidad.DataBase
            m_ArticulosFichasPaletizados1 = CType(sp, spArticulosFichasPaletizados1).Select_Record(GeneralBindingSource(m_Pos).Item("ArticuloFichaPaletizadoID"), dtb)
        End If

        frmEnt = New frmEntArticulosFichasPaletizados1(m_ArticulosFichasPaletizados1, m_Pos, m_VerID)
        frmEnt.Text = String.Format("{0} {1}", TipoAction, Me.Text)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)


        dgvFill()
    End Sub

    Protected Overrides Sub cargar_datos()
        Dim dtb As New BasesParaCompatibilidad.DataBase
        dataSource = dtb.Consultar(spSelectDgv, True)
    End Sub

    Protected Overrides Sub BindDataSource()
        If Not dataSource Is Nothing Then
            GeneralBindingSource.DataSource = dataSource

            butExcel.Visible = True

            With dgvGeneral
                .DataSource = GeneralBindingSource

                .Columns("ArticuloFichaPaletizadoID").Visible = False
                .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, True, 2)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True, 7)
                .FormatoGeneral()
            End With
        End If
    End Sub


End Class
