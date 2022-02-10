Imports System.Reflection
Public Class CloneObject(Of T)
    Public Function CloneObject(ByVal p As T) As T
        Dim newObject As T = Activator.CreateInstance(Of T)()
        Dim fis() As FieldInfo
        fis = p.GetType().GetFields(System.Reflection.BindingFlags.Instance OrElse System.Reflection.BindingFlags.Public OrElse System.Reflection.BindingFlags.NonPublic)
        For Each fi As FieldInfo In fis
            fi.SetValue(newObject, fi.GetValue(p))
        Next
        Return newObject
    End Function
    Public Function CloneListObject(ByVal oList As List(Of T)) As List(Of T)
        Dim oLista As List(Of T) = New List(Of T)
        For Each item As T In oList
            oLista.Add(CloneObject(item))
        Next
        Return oLista
    End Function
End Class
