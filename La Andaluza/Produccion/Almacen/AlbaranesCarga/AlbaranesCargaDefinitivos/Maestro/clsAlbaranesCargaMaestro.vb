public class clsAlbaranesCargaMaestro

#Region "Atributos"
   private AlbaranCargaMaestroID as Integer
   private AlbaranCargaProMaestroID as Integer
   private Fecha as DateTime
   private ClienteID as Integer
   private SerieQSID as Integer
   private NumeroQS as Integer
   private AlmacenSalidaQSID as Integer
   private AgenciaID as Integer
   private PorteFormaPagoID as Integer
   private PorteImporte as Integer
   private Matricula as String
   private Conductor as String
   private ConductorDNI as String
   private ResponsableCargaID as Integer
   private ResponsableAdministracionID as Integer
   private HoraLlegada as DateTime
   private HoraSalida as DateTime
   private Observaciones as String
   private Reserva1 as String
   private Reserva2 as String
   private Reserva3 as String
#End Region

#Region "Propiedades"
   public property _AlbaranCargaMaestroID() as Integer
       get
           return AlbaranCargaMaestroID
       end get

       set(byval value as Integer)
           AlbaranCargaMaestroID = value
       end set
   end property

   public property _AlbaranCargaProMaestroID() as Integer
       get
           return AlbaranCargaProMaestroID
       end get

       set(byval value as Integer)
           AlbaranCargaProMaestroID = value
       end set
   end property

   public property _Fecha() as DateTime
       get
           return Fecha
       end get

       set(byval value as DateTime)
           Fecha = value
       end set
   end property

   public property _ClienteID() as Integer
       get
           return ClienteID
       end get

       set(byval value as Integer)
           ClienteID = value
       end set
   end property

   public property _SerieQSID() as Integer
       get
           return SerieQSID
       end get

       set(byval value as Integer)
           SerieQSID = value
       end set
   end property

   public property _NumeroQS() as Integer
       get
           return NumeroQS
       end get

       set(byval value as Integer)
           NumeroQS = value
       end set
   end property

   public property _AlmacenSalidaQSID() as Integer
       get
           return AlmacenSalidaQSID
       end get

       set(byval value as Integer)
           AlmacenSalidaQSID = value
       end set
   end property

   public property _AgenciaID() as Integer
       get
           return AgenciaID
       end get

       set(byval value as Integer)
           AgenciaID = value
       end set
   end property

   public property _PorteFormaPagoID() as Integer
       get
           return PorteFormaPagoID
       end get

       set(byval value as Integer)
           PorteFormaPagoID = value
       end set
   end property

   public property _PorteImporte() as Integer
       get
           return PorteImporte
       end get

       set(byval value as Integer)
           PorteImporte = value
       end set
   end property

   public property _Matricula() as String
       get
           return Matricula
       end get

       set(byval value as String)
           Matricula = value
       end set
   end property

   public property _Conductor() as String
       get
           return Conductor
       end get

       set(byval value as String)
           Conductor = value
       end set
   end property

   public property _ConductorDNI() as String
       get
           return ConductorDNI
       end get

       set(byval value as String)
           ConductorDNI = value
       end set
   end property

   public property _ResponsableCargaID() as Integer
       get
           return ResponsableCargaID
       end get

       set(byval value as Integer)
           ResponsableCargaID = value
       end set
   end property

   public property _ResponsableAdministracionID() as Integer
       get
           return ResponsableAdministracionID
       end get

       set(byval value as Integer)
           ResponsableAdministracionID = value
       end set
   end property

   public property _HoraLlegada() as DateTime
       get
           return HoraLlegada
       end get

       set(byval value as DateTime)
           HoraLlegada = value
       end set
   end property

   public property _HoraSalida() as DateTime
       get
           return HoraSalida
       end get

       set(byval value as DateTime)
           HoraSalida = value
       end set
   end property

   public property _Observaciones() as String
       get
           return Observaciones
       end get

       set(byval value as String)
           Observaciones = value
       end set
   end property

   public property _Reserva1() as String
       get
           return Reserva1
       end get

       set(byval value as String)
           Reserva1 = value
       end set
   end property

   public property _Reserva2() as String
       get
           return Reserva2
       end get

       set(byval value as String)
           Reserva2 = value
       end set
   end property

   public property _Reserva3() as String
       get
           return Reserva3
       end get

       set(byval value as String)
           Reserva3 = value
       end set
   end property

#End Region

#Region "Metodos"

Public Function Devolver() As DataTable
        Return BasesParaCompatibilidad.BD.ConsultaVer("AlbaranesCargaMaestro.AlbaranCargaMaestroID,AlbaranesCargaMaestro.AlbaranCargaProMaestroID,AlbaranesCargaMaestro.Fecha,AlbaranesCargaMaestro.ClienteID,AlbaranesCargaMaestro.SerieQSID,AlbaranesCargaMaestro.NumeroQS,AlbaranesCargaMaestro.AlmacenSalidaQSID,AlbaranesCargaMaestro.AgenciaID,AlbaranesCargaMaestro.PorteFormaPagoID,AlbaranesCargaMaestro.PorteImporte,AlbaranesCargaMaestro.Matricula,AlbaranesCargaMaestro.Conductor,AlbaranesCargaMaestro.ConductorDNI,AlbaranesCargaMaestro.ResponsableCargaID,AlbaranesCargaMaestro.ResponsableAdministracionID,AlbaranesCargaMaestro.HoraLlegada,AlbaranesCargaMaestro.HoraSalida,AlbaranesCargaMaestro.Observaciones,AlbaranesCargaMaestro.Reserva1,AlbaranesCargaMaestro.Reserva2,AlbaranesCargaMaestro.Reserva3", "AlbaranesCargaMaestro")
    End Function

Public Function Modificar() As Integer
        Try            
            BasesParaCompatibilidad.BD.ConsultaModificar("AlbaranesCargaMaestro", _
                       "AlbaranCargaProMaestroID=" & Convert.ToString(AlbaranCargaProMaestroID) & "," & _
                       "Fecha='" & BasesParaCompatibilidad.Calendar.ArmarFecha(Fecha) & "'," & _
                       "ClienteID=" & Convert.ToString(ClienteID) & "," & _
                       "SerieQSID=" & Convert.ToString(SerieQSID) & "," & _
                       "NumeroQS=" & Convert.ToString(NumeroQS) & "," & _
                       "AlmacenSalidaQSID=" & Convert.ToString(AlmacenSalidaQSID) & "," & _
                       "AgenciaID=" & Convert.ToString(AgenciaID) & "," & _
                       "PorteFormaPagoID=" & Convert.ToString(PorteFormaPagoID) & "," & _
                       "PorteImporte=" & Convert.ToString(PorteImporte) & "," & _
                       "Matricula='" & Matricula & "'," & _
                       "Conductor='" & Conductor & "'," & _
                       "ConductorDNI='" & ConductorDNI & "'," & _
                       "ResponsableCargaID=" & Convert.ToString(ResponsableCargaID) & "," & _
                       "ResponsableAdministracionID=" & Convert.ToString(ResponsableAdministracionID) & "," & _
                       "HoraLlegada='" & BasesParaCompatibilidad.Calendar.ArmarFecha(HoraLlegada) & "'," & _
                       "HoraSalida='" & BasesParaCompatibilidad.Calendar.ArmarFecha(HoraSalida) & "'," & _
                       "Observaciones='" & Observaciones & "'," & _
                       "Reserva1='" & Reserva1 & "'," & _
                       "Reserva2='" & Reserva2 & "'," & _
                       "Reserva3='" & Reserva3 & "'", _
                       "AlbaranCargaMaestroID=" & Convert.ToString(AlbaranCargaMaestroID))
            Return 1
        Catch ex As Exception            
            Return 0
        End Try
End Function

Public Function Insertar() As Integer
Try
            BasesParaCompatibilidad.BD.ConsultaInsertar( _
                       "" & Convert.ToString(AlbaranCargaProMaestroID) & "," & _
                       "'" & BasesParaCompatibilidad.Calendar.ArmarFecha(Fecha) & "'," & _
                       "" & Convert.ToString(ClienteID) & "," & _
                       "" & Convert.ToString(SerieQSID) & "," & _
                       "" & Convert.ToString(NumeroQS) & "," & _
                       "" & Convert.ToString(AlmacenSalidaQSID) & "," & _
                       "" & Convert.ToString(AgenciaID) & "," & _
                       "" & Convert.ToString(PorteFormaPagoID) & "," & _
                       "" & Convert.ToString(PorteImporte) & "," & _
                       "'" & Matricula & "'," & _
                       "'" & Conductor & "'," & _
                       "'" & ConductorDNI & "'," & _
                       "" & Convert.ToString(ResponsableCargaID) & "," & _
                       "" & Convert.ToString(ResponsableAdministracionID) & "," & _
                       "'" & BasesParaCompatibilidad.Calendar.ArmarFecha(HoraLlegada) & "'," & _
                       "'" & BasesParaCompatibilidad.Calendar.ArmarFecha(HoraSalida) & "'," & _
                       "'" & Observaciones & "'," & _
                       "'" & Reserva1 & "'," & _
                       "'" & Reserva2 & "'," & _
                       "'" & Reserva3 & "'", _
                       "AlbaranesCargaMaestro")
AlbaranCargaMaestroID = BasesParaCompatibilidad.BD.ConsultaVer("max(AlbaranCargaMaestroID)","AlbaranesCargaMaestro").Rows(0).Item(0)
Return AlbaranCargaMaestroID
 Catch ex As Exception
Return 0
End Try
End Function

Public Function Eliminar() As Integer
Try
            If (BasesParaCompatibilidad.BD.ConsultaEliminar("AlbaranesCargaMaestro", "AlbaranCargaMaestroID = " & Convert.ToString(AlbaranCargaMaestroID)) = 0) Then
                MessageBox.Show("no se puede eliminar AlbaranCargaMaestro, se encuentra en uso", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
Return 1
Catch ex As Exception
 Return 0
End Try
End Function

#End Region
end class
