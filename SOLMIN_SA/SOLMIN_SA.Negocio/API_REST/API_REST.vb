Imports Newtonsoft
Imports RestSharp
Imports System.Text
Imports System.Net

Public Class API_REST


    Public Function Post(url As String, json As String, usuario As String, psw As String) As Object

        Dim client As New RestSharp.RestClient(url)
        Dim request As New RestSharp.RestRequest(Method.POST)
        request.AddHeader("content-type", "application/json")
        request.AddParameter("application/json", json, ParameterType.RequestBody)
        If usuario <> "" Then
            Dim usu_psw As String
            Dim CadenaBase64 As String
            usu_psw = usuario + ":" + psw
            Dim byt As Byte() = System.Text.Encoding.UTF8.GetBytes(usu_psw)
            CadenaBase64 = Convert.ToBase64String(byt)
            request.AddHeader("Authorization", "Basic " & CadenaBase64)
        End If
        Dim response As IRestResponse = client.Execute(request)
        Dim datos As Object = Newtonsoft.Json.JsonConvert.DeserializeObject(response.Content)
        Return datos

        'Dim authData As String = ""
        'authData = String.Format("{0}:{1}", usuario, psw)
        'Dim CadenaBase64 As String = ""
        'CadenaBase64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(authData))
        'request.AddHeader(HttpRequestHeader.Authorization, "Basic " & CadenaBase64)
        'client.Authenticator = New HttpBasicAuthenticator(usuario, psw)
        ' client.Authenticator = New SimpleAuthenticator("username", usuario, "password", psw)
        'wc.Headers.Add(HttpRequestHeader.Authorization, "Basic " & CadenaBase64)
        '    var authData = string.Format ("{0}:{1}", Constants.Username, Constants.Password);
        'var authHeaderValue = Convert.ToBase64String (Encoding.UTF8.GetBytes (authData));
        '_client = new HttpClient ();
        '_client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue ("Basic", authHeaderValue);


    End Function

    'Function sendJson(ruta As String, usuario As String, password As String, token As String, json As String) As String
    '    Using wc As New WebClient
    '        Try
    '            Dim CadA As String
    '            Dim CadenaBase64 As String
    '            CadA = usuario + ":" + password
    '            Dim byt As Byte() = System.Text.Encoding.UTF8.GetBytes(CadA)
    '            CadenaBase64 = Convert.ToBase64String(byt)
    '            wc.Headers.Add(HttpRequestHeader.ContentType, "application/json; charset=utf-8;")
    '            wc.Headers.Add(HttpRequestHeader.Authorization, "Basic " & CadenaBase64)
    '            Dim respuesta = wc.UploadString(ruta, "POST", json)
    '            Return respuesta
    '        Catch x As WebException
    '            Return ""
    '        End Try
    '    End Using
    'End Function



End Class
