Imports System.IO
Imports System.Security
Imports Microsoft.Win32

' Configuring the emulation mode of an Internet Explorer WebBrowser control
' http://cyotek.com/blog/configuring-the-emulation-mode-of-an-internet-explorer-webbrowser-control

' Additional Resources:
' http://msdn.microsoft.com/en-us/library/ee330730%28v=vs.85%29.aspx#browser_emulation

    ''' <summary>
    ''' Internet Explorer browser emulation versions
    ''' </summary>
    Public Enum BrowserEmulationVersion
        ''' <summary>
        ''' Default
        ''' </summary>
        [Default] = 0

        ''' <summary>
        ''' Interner Explorer 7 Standards Mode
        ''' </summary>
        Version7 = 7000

        ''' <summary>
        ''' Interner Explorer 8
        ''' </summary>
        Version8 = 8000

        ''' <summary>
        ''' Interner Explorer 8 Standards Mode
        ''' </summary>
        Version8Standards = 8888

        ''' <summary>
        ''' Interner Explorer 9
        ''' </summary>
        Version9 = 9000

        ''' <summary>
        ''' Interner Explorer 9 Standards Mode
        ''' </summary>
        Version9Standards = 9999

        ''' <summary>
        ''' Interner Explorer 10
        ''' </summary>
        Version10 = 10000

        ''' <summary>
        ''' Interner Explorer 10 Standards Mode
        ''' </summary>
        Version10Standards = 10001

        ''' <summary>
        ''' Interner Explorer 11
        ''' </summary>
        Version11 = 11000

        ''' <summary>
        ''' Interner Explorer 11 Edge Mode
        ''' </summary>
        Version11Edge = 11001
    End Enum

    ''' <summary>
    ''' Helper methods for working with Internet Explorer browser emulation
    ''' </summary>
Friend NotInheritable Class IExplorer
    Private Sub New()
    End Sub
#Region "Constants"

    Private Const InternetExplorerRootKey As String = "Software\Microsoft\Internet Explorer"

    Private Const BrowserEmulationKey As String = InternetExplorerRootKey + "\Main\FeatureControl\FEATURE_BROWSER_EMULATION"

#End Region

#Region "Public Class Members"

    ''' <summary>
    ''' Gets the browser emulation version for the application.
    ''' </summary>
    ''' <returns>The browser emulation version for the application.</returns>
    Public Shared Function GetBrowserEmulationVersion() As BrowserEmulationVersion
        Dim result As BrowserEmulationVersion

        result = BrowserEmulationVersion.[Default]

        Try
            Dim key As RegistryKey

            key = Registry.CurrentUser.OpenSubKey(BrowserEmulationKey, True)
            If key IsNot Nothing Then
                Dim programName As String
                Dim value As Object

                programName = Path.GetFileName(Environment.GetCommandLineArgs()(0))
                value = key.GetValue(programName, Nothing)

                If value IsNot Nothing Then
                    result = CType(Convert.ToInt32(value), BrowserEmulationVersion)
                End If
            End If
            ' The user does not have the permissions required to read from the registry key.
        Catch generatedExceptionName As SecurityException
            ' The user does not have the necessary registry rights.
        Catch generatedExceptionName As UnauthorizedAccessException
        End Try

        Return result
    End Function

    ''' <summary>
    ''' Gets the major Internet Explorer version
    ''' </summary>
    ''' <returns>The major digit of the Internet Explorer version</returns>
    Public Shared Function GetInternetExplorerMajorVersion() As Integer
        Dim result As Integer

        result = 0

        Try
            Dim key As RegistryKey

            key = Registry.LocalMachine.OpenSubKey(InternetExplorerRootKey)

            If key IsNot Nothing Then
                Dim value As Object


                If key.GetValue("svcVersion", Nothing) Is Nothing Then
                    value = key.GetValue("Version", Nothing)
                Else
                    value = key.GetValue("svcVersion", Nothing)
                End If

                If value IsNot Nothing Then
                    Dim version As String
                    Dim separator As Integer

                    version = value.ToString()
                    separator = version.IndexOf("."c)
                    If separator <> -1 Then
                        Integer.TryParse(version.Substring(0, separator), result)
                    End If
                End If
            End If
            ' The user does not have the permissions required to read from the registry key.
        Catch generatedExceptionName As SecurityException
            ' The user does not have the necessary registry rights.
        Catch generatedExceptionName As UnauthorizedAccessException
        End Try

        Return result
    End Function

    ''' <summary>
    ''' Determines whether a browser emulation version is set for the application.
    ''' </summary>
    ''' <returns><c>true</c> if a specific browser emulation version has been set for the application; otherwise, <c>false</c>.</returns>
    Public Shared Function IsBrowserEmulationSet() As Boolean
        Return GetBrowserEmulationVersion() <> BrowserEmulationVersion.[Default]
    End Function

    ''' <summary>
    ''' Sets the browser emulation version for the application.
    ''' </summary>
    ''' <param name="browserEmulationVersion">The browser emulation version.</param>
    ''' <returns><c>true</c> the browser emulation version was updated, <c>false</c> otherwise.</returns>
    Public Shared Function SetBrowserEmulationVersion(ByVal browserEmulationVersion__1 As BrowserEmulationVersion) As Boolean
        Dim result As Boolean

        result = False

        Try
            Dim key As RegistryKey

            key = Registry.CurrentUser.OpenSubKey(BrowserEmulationKey, True)

            If key IsNot Nothing Then
                Dim programName As String

                programName = Path.GetFileName(Environment.GetCommandLineArgs()(0))

                If browserEmulationVersion__1 <> BrowserEmulationVersion.[Default] Then
                    ' if it's a valid value, update or create the value
                    key.SetValue(programName, CInt(browserEmulationVersion__1), RegistryValueKind.DWord)
                Else
                    ' otherwise, remove the existing value
                    key.DeleteValue(programName, False)
                End If

                result = True
            End If
            ' The user does not have the permissions required to read from the registry key.
        Catch generatedExceptionName As SecurityException
            ' The user does not have the necessary registry rights.
        Catch generatedExceptionName As UnauthorizedAccessException
        End Try

        Return result
    End Function

    ''' <summary>
    ''' Sets the browser emulation version for the application to the highest default mode for the version of Internet Explorer installed on the system
    ''' </summary>
    ''' <returns><c>true</c> the browser emulation version was updated, <c>false</c> otherwise.</returns>
    Public Shared Function SetBrowserEmulationVersion() As Boolean
        Dim ieVersion As Integer
        Dim emulationCode As BrowserEmulationVersion

        ieVersion = GetInternetExplorerMajorVersion()

        If ieVersion >= 11 Then
            emulationCode = BrowserEmulationVersion.Version11
        Else
            Select Case ieVersion
                Case 10
                    emulationCode = BrowserEmulationVersion.Version10
                    Exit Select
                Case 9
                    emulationCode = BrowserEmulationVersion.Version9
                    Exit Select
                Case 8
                    emulationCode = BrowserEmulationVersion.Version8
                    Exit Select
                Case Else
                    emulationCode = BrowserEmulationVersion.Version7
                    Exit Select
            End Select
        End If

        Return SetBrowserEmulationVersion(emulationCode)
    End Function

#End Region
End Class

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================
