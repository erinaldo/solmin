Public Module MainModuleDeploy

    Private _HasGetParamDeploy As New Hashtable
    Public Property HasGetParamDeploy() As Hashtable
        Get
            Return _HasGetParamDeploy
        End Get
        Set(ByVal value As Hashtable)
            _HasGetParamDeploy = value
        End Set
    End Property

    Private _CodVarCompaniaDeploy As String = "IDCOMPANIA"
    Private _CodVarErrorDeploy As String = "IDERROR"
   
    Private _IdCompaniaDeploy As String = ""
    Public Property IdCompaniaDeploy() As String
        Get
            Return _IdCompaniaDeploy
        End Get
        Set(ByVal value As String)
            _IdCompaniaDeploy = value
        End Set
    End Property

    Private _IdErrorDeploy As String = ""
    Public Property IdErrorDeploy() As String
        Get
            Return _IdErrorDeploy
        End Get
        Set(ByVal value As String)
            _IdErrorDeploy = value
        End Set
    End Property

    Public Sub SetQueryStringParametersDeploy()
        _HasGetParamDeploy = New Hashtable
        Try
            If (Deployment.Application.ApplicationDeployment.IsNetworkDeployed = True) Then
                Dim objQueryString As String = Deployment.Application.ApplicationDeployment.CurrentDeployment.ActivationUri.Query
                Dim objInputParameters As Specialized.NameValueCollection = System.Web.HttpUtility.ParseQueryString(objQueryString)
                For Each obj As String In objInputParameters.AllKeys
                    _HasGetParamDeploy.Add(obj, objInputParameters(obj))
                Next
            End If
            If _HasGetParamDeploy.Contains(_CodVarCompaniaDeploy) Then
                _IdCompaniaDeploy = _HasGetParamDeploy(_CodVarCompaniaDeploy)
            End If
        Catch ex As Exception
            _HasGetParamDeploy(_CodVarErrorDeploy) = ex.Message
            _IdErrorDeploy = _HasGetParamDeploy(_CodVarErrorDeploy)
        End Try
    End Sub


End Module
