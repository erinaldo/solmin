Imports RANSA.DATA
Imports RANSA.TypeDef
Public Class blProveedor
    Public Function fblnRegistrar_Proveedor_de_ABB(ByVal obeProveedor As beProveedor) As beProveedor

        If (obeProveedor.TPRVCL_DesClieTercero.Length > 30) Then
            obeProveedor.TPRVCL_DesClieTercero = obeProveedor.TPRVCL_DesClieTercero.Substring(0, 30)
        End If

        If (obeProveedor.TPRCL1_DesProvCliente.Length > 30) Then
            obeProveedor.TPRCL1_DesProvCliente = obeProveedor.TPRCL1_DesProvCliente.Substring(0, 30)
        End If

        If (obeProveedor.TNACPR_DesProvDistProveedor.Length > 30) Then
            obeProveedor.TNACPR_DesProvDistProveedor = obeProveedor.TNACPR_DesProvDistProveedor.Substring(0, 15)
        End If

        If (obeProveedor.TDRPRC_DirecCliTercero.Length > 35) Then
            obeProveedor.TDRPRC_DirecCliTercero = obeProveedor.TDRPRC_DirecCliTercero.Substring(0, 35)
        End If

        If (obeProveedor.TNROFX_NroFax.Length > 40) Then
            obeProveedor.TNROFX_NroFax = obeProveedor.TNROFX_NroFax.Substring(0, 40)
        End If

        If (obeProveedor.TLFN01_Telefono.Length > 15) Then
            obeProveedor.TLFN01_Telefono = obeProveedor.TLFN01_Telefono.Substring(0, 40)
        End If
        If (obeProveedor.TEMAI2_NombreEmail.Length > 40) Then
            obeProveedor.TEMAI2_NombreEmail = obeProveedor.TEMAI2_NombreEmail.Substring(0, 40)
        End If

        If (obeProveedor.TPRSCN_PersonaContacto.Length > 40) Then
            obeProveedor.TPRSCN_PersonaContacto = obeProveedor.TPRSCN_PersonaContacto.Substring(0, 40)
        End If
        If (obeProveedor.TLFN02_FonoContacto.Length > 15) Then
            obeProveedor.TLFN02_FonoContacto = obeProveedor.TLFN02_FonoContacto.Substring(0, 40)
        End If
        If (obeProveedor.TMAI03_EmailContacto.Length > 40) Then
            obeProveedor.TMAI03_EmailContacto = obeProveedor.TMAI03_EmailContacto.Substring(0, 40)
        End If
        Return New daProveedor().fblnRegistrar_Proveedor_de_ABB(obeProveedor)
    End Function
    Public Function ListarClienteTercero_x_Cliente(ByVal obeProveedor As TypeDef.beProveedor) As List(Of TypeDef.beProveedor)
        Return New daProveedor().ListarClienteTercero_x_Cliente(obeProveedor)
    End Function
    Public Function RegistrarRelacionTercero_x_Cliente(ByVal obeProveedor As TYPEDEF.beProveedor) As beProveedor
        Return New daProveedor().RegistrarRelacionTercero_x_Cliente(obeProveedor)
    End Function
    Public Function EliminarRelacionTercero_x_Cliente(ByVal obeProveedor As TYPEDEF.beProveedor) As Int32
        Return New daProveedor().EliminarRelacionTercero_x_Cliente(obeProveedor)
    End Function

End Class
