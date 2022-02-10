
Imports Db2Manager.RansaData.iSeries.DataObjects
Imports Ransa.TypeDef
Public Class blProveedor_BL
    Private daProveedor As New Proveedor_DAL
    Public Function fblnRegistrar_Proveedor_de_ABB(ByVal obeProveedor As TypeDef.beProveedor) As TypeDef.beProveedor

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
        If (obeProveedor.PSTDRDST.Length > 70) Then
            obeProveedor.PSTDRDST = obeProveedor.PSTDRDST.Substring(0, 70)
        End If
        Return New Proveedor_DAL().fblnRegistrar_Proveedor_de_ABB(obeProveedor)
    End Function
    Public Function ListarClienteTercero_x_Cliente(ByVal obeProveedor As TypeDef.beProveedor) As List(Of TypeDef.beProveedor)
        Return New Proveedor_DAL().ListarClienteTercero_x_Cliente(obeProveedor)
    End Function
    Public Function RegistrarRelacionTercero_x_Cliente(ByVal obeProveedor As TypeDef.beProveedor) As beProveedor
        Return New Proveedor_DAL().RegistrarRelacionTercero_x_Cliente(obeProveedor)
    End Function
    Public Function EliminarRelacionTercero_x_Cliente(ByVal obeProveedor As TypeDef.beProveedor) As Int32
        Return New Proveedor_DAL().EliminarRelacionTercero_x_Cliente(obeProveedor)
    End Function

    Public Function GrabarProveedorDeCliente(ByVal obeProveedor As beProveedor) As Integer
        Return New Proveedor_DAL().GrabarProveedorDeCliente(obeProveedor)
    End Function

    Public Function GrabarProveedorDeCliente_v2(ByVal obeProveedor As beProveedor) As Integer
        Return New Proveedor_DAL().GrabarProveedorDeCliente_v2(obeProveedor)
    End Function

    Public Function flistTipoClienteTercero(ByVal obeProveedor As TypeDef.beProveedor) As List(Of TypeDef.beProveedor)
        Return New Proveedor_DAL().flistTipoClienteTercero(obeProveedor)
    End Function


    Public Function ObtenerCodigoProveedorPorCodCliente(ByVal obeProveedor As beProveedor) As Decimal
        Dim odaProveedores As New Proveedor_DAL
        Return odaProveedores.ObtenerCodigoProveedorPorCodCliente(obeProveedor)
    End Function

 

    Public Function Listar_proveedor_X_RUC(PSNRUCPR As String) As DataTable
        Dim odaProveedores As New Proveedor_DAL
        Return odaProveedores.Listar_proveedor_X_RUC(PSNRUCPR)
    End Function


    'Public Function Listar_proveedor_X_RUC(PSNRUCPR As String) As DataTable
    '    Dim odaProveedores As New Proveedor_DAL
    '    Return odaProveedores.Listar_proveedor_X_RUC(PSNRUCPR)
    'End Function
    'Public Function Listar_proveedor_X_RUC(PSNRUCPR As String) As DataTable
    '    Dim odaProveedores As New Proveedor_DAL
    '    Return odaProveedores.Listar_proveedor_X_RUC(PSNRUCPR)
    'End Function

End Class
