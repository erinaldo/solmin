Module mMainSDSW

#Region " VariablesGlobales "
    '-- Constantes Datos Servicios
    'Public Const GLOBAL_COMPANIA = "EZ"
    'Public Const GLOBAL_DIVISION = "R"
    ''-- Variables Publicas
    'Public pblnAcceso As Boolean = False                        ' Status de Acceso
    'Public GLOBAL_EMRESA = "RANSA COMERCIAL"                    ' Nombre de la Empresa
    Public GLOBAL_PCUSUARIO = System.Net.Dns.GetHostName()      ' Nombre de la PC de Usuario
    '  Public objSeguridadBN As clsSeguridad = Nothing             ' Objeto de la Seguridad

    ' Agregado para Almaceneras
    Public Compania_Usuario As String = ""                      ' Compañia asignada al Usuario
    Public Division_Usuario As String = ""                      ' División asignada al Usuario

#End Region
End Module
