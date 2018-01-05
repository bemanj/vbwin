Public Class ArrayClass

    Private _nameArray As String()
    Private _nameList As List(Of String)
    Private _test As Integer()

    Public Sub New()
        _nameArray = New String(9) {}
        _nameList = New List(Of String)
        _test = New Integer(9) {"s", "", "", "", "", "", "", "", "", ""}
    End Sub

    Public Sub AddName(ByVal index As Integer, ByVal name As String)
        _nameArray(index) = name
    End Sub

    Public Sub AddName(ByVal name As String)
        _nameList.Add(name)
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

End Class
