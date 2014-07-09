Public Class DBO_Clientes

   Private m_ClienteID As Int32
   Private m_Nombre As String
   Private m_CodigoQS As Int32

   Public Sub New()

   End Sub

   Public Property ClienteID() As Int32
       Get
           Return m_ClienteID
       End Get
       Set(ByVal value As Int32)
           m_ClienteID = value
       End Set
   End Property

   Public Property Nombre() As String
       Get
           Return m_Nombre
       End Get
       Set(ByVal value As String)
           m_Nombre = value
       End Set
   End Property

   Public Property CodigoQS() As Int32
       Get
           Return m_CodigoQS
       End Get
       Set(ByVal value As Int32)
           m_CodigoQS = value
       End Set
   End Property

End Class
