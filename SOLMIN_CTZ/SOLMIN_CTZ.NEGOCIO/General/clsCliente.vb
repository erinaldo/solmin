Imports SOLMIN_CTZ.DATOS
Imports SOLMIN_CTZ.Entidades

Public Class clsCliente
    Private oCliente As SOLMIN_CTZ.DATOS.clsCliente
    Private oDt As DataTable
    Private oDtGrupo As DataTable

    Sub New()
        oCliente = New SOLMIN_CTZ.DATOS.clsCliente
    End Sub

    Property Lista() As DataTable
        Get
            Return oDt
        End Get
        Set(ByVal value As DataTable)
            oDt = value
        End Set
    End Property

    Property ListaGrupo() As DataTable
        Get
            Return oDtGrupo
        End Get
        Set(ByVal value As DataTable)
            oDtGrupo = value
        End Set
    End Property

    Private Sub Lista_Grupo_Cliente(ByVal poDt As DataTable)
        Dim intCont As Integer

        oDtGrupo = poDt.Copy
        For intCont = oDtGrupo.Rows.Count - 1 To 1 Step -1
            With oDtGrupo
                If .Rows(intCont).Item("NRCTCL") = .Rows(intCont - 1).Item("NRCTCL") And .Rows(intCont).Item("CPLNDV") = .Rows(intCont - 1).Item("CPLNDV") Then
                    .Rows.RemoveAt(intCont)
                End If
            End With
        Next intCont
        oDtGrupo.Columns.Remove("CCLNT")
        oDtGrupo.Columns.Remove("CLIENTE")
    End Sub

    Private Sub Lista_Cliente(ByVal poDt As DataTable)
        oDt = poDt.Copy
        oDt.Columns.Remove("NRCTCL")
        oDt.Columns.Remove("GRUPO")
    End Sub

    Public Sub Crea_Lista()
        Dim oDtNew As DataTable

        oDtNew = oCliente.Lista_Cliente_X_Usuario()
        Lista_Cliente(oDtNew)
        Lista_Grupo_Cliente(oDtNew)
    End Sub

    Public Sub Lista_Cliente_Cartera()
        oDt = oCliente.Lista_Cliente_Cartera()
    End Sub
    Public Function Lista_Cliente_Cartera_Relacion(ByVal codigoCliente As String) As DataTable
        Dim oDtRelacion As DataTable
        oDtRelacion = oCliente.Lista_Cliente_Cartera_Relacion()
        Dim objDr As DataRow
        Dim lintCont As Integer
        Dim objListaDr As DataRow()
        If codigoCliente = "-1" Then
            Return oDtRelacion
            Exit Function
        End If
        objListaDr = oDtRelacion.Select("NRCTCL = '" & codigoCliente.Trim & "'", "NRCTCL ASC")
        oDtRelacion = oDtRelacion.Copy
        oDtRelacion.Rows.Clear()
        For lintCont = 0 To objListaDr.Length - 1
            objDr = oDtRelacion.NewRow
            objDr(0) = objListaDr(lintCont).Item(0)
            objDr(1) = objListaDr(lintCont).Item(1)
            objDr(2) = objListaDr(lintCont).Item(2)
            objDr(3) = objListaDr(lintCont).Item(3)
            objDr(4) = objListaDr(lintCont).Item(4)
            objDr(5) = objListaDr(lintCont).Item(5)
            objDr(6) = objListaDr(lintCont).Item(6)
            oDtRelacion.Rows.Add(objDr)
        Next lintCont

        Return oDtRelacion
    End Function
    Public Function Lista_Cliente_Cartera_Seleccion(Optional ByVal filtro As Integer = 0, Optional ByVal pCodigo As String = "", Optional ByVal pNombre As String = "") As DataTable
        'Filtro-------------------------------------------------
        Dim objDr As DataRow
        Dim lintCont As Integer
        Dim objDt As New DataTable
        Dim objListaDr As DataRow()
        objDt = oDt.Copy
        If filtro = 0 Then
            objListaDr = objDt.Select("DESCAR like '%'", "NRCTCL ASC")
            objDt = objDt.Copy
            objDt.Rows.Clear()
            For lintCont = 0 To objListaDr.Length - 1
                objDr = objDt.NewRow
                objDr(0) = objListaDr(lintCont).Item(0)
                objDr(1) = objListaDr(lintCont).Item(1)
                objDr(2) = objListaDr(lintCont).Item(2)
                objDr(3) = objListaDr(lintCont).Item(3)
                objDr(4) = objListaDr(lintCont).Item(4)
                objDr(5) = objListaDr(lintCont).Item(5)
                objDr(6) = objListaDr(lintCont).Item(6)
                objDr(7) = objListaDr(lintCont).Item(7)
                objDr(8) = objListaDr(lintCont).Item(8)
                objDr(9) = objListaDr(lintCont).Item(9)
                objDr(10) = objListaDr(lintCont).Item(10)
                objDt.Rows.Add(objDr)
            Next lintCont
        Else
            If pCodigo.Trim = "" Then
                objListaDr = objDt.Select("DESCAR like '%" & pNombre.Trim & "%'", "NRCTCL ASC")
            Else
                objListaDr = objDt.Select("NRCTCL = '" & pCodigo.Trim & "'", "NRCTCL ASC")
            End If
            objDt = objDt.Copy
            objDt.Rows.Clear()
            For lintCont = 0 To objListaDr.Length - 1
                objDr = objDt.NewRow
                objDr(0) = objListaDr(lintCont).Item(0)
                objDr(1) = objListaDr(lintCont).Item(1)
                objDr(2) = objListaDr(lintCont).Item(2)
                objDr(3) = objListaDr(lintCont).Item(3)
                objDr(4) = objListaDr(lintCont).Item(4)
                objDr(5) = objListaDr(lintCont).Item(5)
                objDr(6) = objListaDr(lintCont).Item(6)
                objDr(7) = objListaDr(lintCont).Item(7)
                objDr(8) = objListaDr(lintCont).Item(8)
                objDr(9) = objListaDr(lintCont).Item(9)
                objDr(10) = objListaDr(lintCont).Item(10)
                objDt.Rows.Add(objDr)
            Next lintCont
        End If
        Return objDt
    End Function

    Public Sub Actualizar_Cliente_Cartera(ByVal oClienteEnt As SOLMIN_CTZ.Entidades.Cliente)
        'Try
        oCliente.Actualizar_Cliente_Cartera(oClienteEnt)
        'Catch ex As Exception
        '    Throw New Exception(ex.Message)
        'End Try
    End Sub
    Public Sub Agregar_Cliente_Cartera(ByVal oClienteEnt As SOLMIN_CTZ.Entidades.Cliente)
        'Try
        oCliente.Agregar_Cliente_Cartera(oClienteEnt)
        'Catch ex As Exception
        '    Throw New Exception(ex.Message)
        'End Try
    End Sub
    'Public Function Eliminar_Cliente_Cartera(ByVal oClienteEnt As SOLMIN_CTZ.Entidades.Cliente) As Integer
    Public Function Eliminar_Cliente_Cartera(ByVal oClienteEnt As SOLMIN_CTZ.Entidades.Cliente) As String
        'Try
        Return oCliente.Eliminar_Cliente_Cartera(oClienteEnt)
        'Catch ex As Exception
        '    Throw New Exception(ex.Message)
        'End Try
    End Function

    Public Function Eliminar_Cliente_Cartera_Relacion_V2(ByVal oClienteEnt As SOLMIN_CTZ.Entidades.Cliente) As String
        'Try
        Dim msg As String = ""
        msg = oCliente.Eliminar_Cliente_Cartera_Relacion_V2(oClienteEnt)
        'Catch ex As Exception
        '    Throw New Exception(ex.Message)
        'End Try
        Return msg
    End Function
    Public Sub Agregar_Cliente_Cartera_Relacion(ByVal oClienteEnt As SOLMIN_CTZ.Entidades.Cliente)
        'Try
        oCliente.Agregar_Cliente_Cartera_Relacion(oClienteEnt)
        'Catch ex As Exception
        '    Throw New Exception(ex.Message)
        'End Try
    End Sub

    Public Function Lista_Grupo_X_Planta(Optional ByVal pdblCodplanta As String = "-1", Optional ByVal pintFlag As Integer = 0) As DataTable
        Dim objDr As DataRow
        Dim objDt As DataTable
        Dim intCont As Integer

        objDt = oDtGrupo.Copy
        If objDt.Rows.Count > 0 And pintFlag > 0 Then
            objDr = objDt.NewRow
            objDr(0) = "-1"
            objDr(1) = "-1"
            objDr(2) = "TODOS"
            objDt.Rows.InsertAt(objDr, 0)
        End If
        If objDt.Rows.Count > 0 And pintFlag = -1 And pdblCodplanta = -1 Then
            For intCont = objDt.Rows.Count - 1 To 0 Step -1
                If objDt.Rows(intCont).Item("NRCTCL").ToString = "0" Then
                    objDt.Rows.RemoveAt(intCont)
                    Exit For
                End If
            Next intCont
        Else
            If objDt.Rows.Count > 0 And pintFlag = -1 Then
                For intCont = objDt.Rows.Count - 1 To 0 Step -1
                    If objDt.Rows(intCont).Item("NRCTCL").ToString = "0" Or objDt.Rows(intCont).Item("CPLNDV").ToString.Trim <> pdblCodplanta Then
                        objDt.Rows.RemoveAt(intCont)
                    End If
                Next intCont
            End If
        End If

        Return objDt
    End Function

    Public Function Lista_Cliente_X_Planta(ByVal pdblCodplanta As String, Optional ByVal pintFlag As Integer = 0) As DataTable
        Dim objDr As DataRow
        Dim objDt As DataTable
        Dim intCont As Integer

        objDt = oDt.Copy
        If objDt.Rows.Count > 0 And pintFlag > 0 Then
            objDr = objDt.NewRow
            objDr(0) = "-1"
            objDr(1) = "-1"
            objDr(2) = "TODOS"
            objDt.Rows.InsertAt(objDr, 0)
        End If
        If objDt.Rows.Count > 0 And pintFlag = -1 Then
            For intCont = objDt.Rows.Count - 1 To 0 Step -1
                If objDt.Rows(intCont).Item("CCLNT").ToString = "0" Or objDt.Rows(intCont).Item("CPLNDV").ToString.Trim <> pdblCodplanta Then
                    objDt.Rows.RemoveAt(intCont)
                End If
            Next intCont
        End If
        Return objDt
    End Function

    Public Function Busca_Cliente_Grupo(ByVal CodigoGrupo As String) As DataTable
        Return oCliente.Busca_Cliente_Grupo(CodigoGrupo)
    End Function

    Public Function floListaCarteCliente(ByVal obeCliente As Cliente, ByRef TotalPag As Decimal) As List(Of Cliente)
        Return oCliente.floListaCarteCliente(obeCliente, TotalPag)
    End Function

    Public Function floListaClienteXGrupo(ByVal obeCliente As Cliente) As List(Of Cliente)
        Return oCliente.floListaClienteXGrupo(obeCliente)
    End Function

    Public Function ListaCarteraAsociadoxCliente(ByVal PNNRCTCL As Decimal, ByVal PNCCLNT As Decimal, ByVal PSCCMPN As String) As DataTable
        Return oCliente.ListaCarteraAsociadoxCliente(PNNRCTCL, PNCCLNT, PSCCMPN)
    End Function

    '<[AHM]>
    Public Function PerteneceASalmon(ByVal PSCMCPN As String) As Boolean
        If oCliente.PerteneceASalmon(PSCMCPN).Rows.Count > 0 Then
            Return True
        End If
        Return False
    End Function
    '</[AHM]>

#Region "Resumen Mensual Almacens"
    'SP_SOLCT_LISTA_CLIENTE_SOMIN
    Public Function fodtListaClientesSOLMIN(ByVal obeCliente As Cliente) As DataTable
        Return oCliente.fodtListaClientesSOLMIN(obeCliente)
    End Function
#End Region

    'RCS-HUNDRED-INICIO
    Public Function Validar_Cliente_Interno(ByVal CCMPN As String, ByVal PNNRCTSL As Decimal) As List(Of Cliente)
        Return oCliente.Validar_Cliente_Interno(CCMPN, PNNRCTSL)
    End Function

    Public Function Validar_Cliente_Interno_Factura(ByVal PSCCMPN As String, ByVal PNCCLNT As Decimal) As List(Of Cliente)
        Return oCliente.Validar_Cliente_Interno(PSCCMPN, PNCCLNT)
    End Function
    'RCS-HUNDRED-FIN


    'JM  09-11-2015
    Public Function Validar_Cliente_Interno_v2(ByVal CCMPN As String, ByVal PNNRCTSL As Decimal) As List(Of Cliente)
        Return oCliente.Validar_Cliente_Interno_v2(CCMPN, PNNRCTSL)
    End Function

    Public Function Lista_Cliente() As List(Of Cliente)
        Return oCliente.Lista_Cliente()
    End Function
End Class

