Public Class DBO_Camiones
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_AgenciaTransporteID As BasesParaCompatibilidad.DataBussinesParameter
   Private m_ConductorHabitualID As BasesParaCompatibilidad.DataBussinesParameter
   Private m_CamionTipoID As BasesParaCompatibilidad.DataBussinesParameter
   Private m_MatriculaCabeza As BasesParaCompatibilidad.DataBussinesParameter
   Private m_MatriculaRemolque As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Tara As BasesParaCompatibilidad.DataBussinesParameter
   Private m_PesoMaximo As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Observaciones As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@CamionID","CamionID")
       m_AgenciaTransporteID= New BasesParaCompatibilidad.DataBussinesParameter("@AgenciaTransporteID","AgenciaTransporteID")
       m_ConductorHabitualID= New BasesParaCompatibilidad.DataBussinesParameter("@ConductorHabitualID","ConductorHabitualID")
       m_CamionTipoID= New BasesParaCompatibilidad.DataBussinesParameter("@CamionTipoID","CamionTipoID")
       m_MatriculaCabeza= New BasesParaCompatibilidad.DataBussinesParameter("@MatriculaCabeza","MatriculaCabeza")
       m_MatriculaRemolque= New BasesParaCompatibilidad.DataBussinesParameter("@MatriculaRemolque","MatriculaRemolque")
       m_Tara= New BasesParaCompatibilidad.DataBussinesParameter("@Tara","Tara")
       m_PesoMaximo= New BasesParaCompatibilidad.DataBussinesParameter("@PesoMaximo","PesoMaximo")
       m_Observaciones= New BasesParaCompatibilidad.DataBussinesParameter("@Observaciones","Observaciones")
       MyBase.primaryKey = m_Id
       añadirParametros()
   End Sub

   Public Property ID() As Int32
       Get
           if m_id.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_id.value,int32)
       End Get
       Set(ByVal value As Int32)
           Me.primaryKey.value = value
           m_id.value = value
       End Set
   End Property

   Public Property AgenciaTransporteID() As Int32
       Get
           if m_AgenciaTransporteID.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_AgenciaTransporteID.value,int32)
       End Get
       Set(ByVal value As Int32)
           m_AgenciaTransporteID.value = value
       End Set
   End Property

   Public Property ConductorHabitualID() As Int32
       Get
           if m_ConductorHabitualID.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_ConductorHabitualID.value,int32)
       End Get
       Set(ByVal value As Int32)
           m_ConductorHabitualID.value = value
       End Set
   End Property

   Public Property CamionTipoID() As Int32
       Get
           if m_CamionTipoID.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_CamionTipoID.value,int32)
       End Get
       Set(ByVal value As Int32)
           m_CamionTipoID.value = value
       End Set
   End Property

   Public Property MatriculaCabeza() As String
       Get
           if m_MatriculaCabeza.value is convert.dbnull then
             Return string.empty
           End if
           Return ctype(m_MatriculaCabeza.value,string)
       End Get
       Set(ByVal value As String)
           m_MatriculaCabeza.value = value
       End Set
   End Property

   Public Property MatriculaRemolque() As String
       Get
           if m_MatriculaRemolque.value is convert.dbnull then
             Return string.empty
           End if
           Return ctype(m_MatriculaRemolque.value,string)
       End Get
       Set(ByVal value As String)
           m_MatriculaRemolque.value = value
       End Set
   End Property

   Public Property Tara() As Int32
       Get
           if m_Tara.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_Tara.value,int32)
       End Get
       Set(ByVal value As Int32)
           m_Tara.value = value
       End Set
   End Property

   Public Property PesoMaximo() As Int32
       Get
           if m_PesoMaximo.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_PesoMaximo.value,int32)
       End Get
       Set(ByVal value As Int32)
           m_PesoMaximo.value = value
       End Set
   End Property

   Public Property Observaciones() As String
       Get
           if m_Observaciones.value is convert.dbnull then
             Return string.empty
           End if
           Return ctype(m_Observaciones.value,string)
       End Get
       Set(ByVal value As String)
           m_Observaciones.value = value
       End Set
   End Property

   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_AgenciaTransporteID, m_AgenciaTransporteID.sqlName)
       MyBase.atributos.Add(m_ConductorHabitualID, m_ConductorHabitualID.sqlName)
       MyBase.atributos.Add(m_CamionTipoID, m_CamionTipoID.sqlName)
       MyBase.atributos.Add(m_MatriculaCabeza, m_MatriculaCabeza.sqlName)
       MyBase.atributos.Add(m_MatriculaRemolque, m_MatriculaRemolque.sqlName)
       MyBase.atributos.Add(m_Tara, m_Tara.sqlName)
       MyBase.atributos.Add(m_PesoMaximo, m_PesoMaximo.sqlName)
       MyBase.atributos.Add(m_Observaciones, m_Observaciones.sqlName)
   End Sub
End Class
