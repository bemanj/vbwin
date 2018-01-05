Module MainModule
    Private _names As String() = New String(10) { _
        "Juan", "Maria", "Claudia", _
        "Jose", "Simeon", "Rapael", _
        "Carlos", "Trinidad", "Susan", _
        "Gabriel", "Allan"}

    Sub Main()
        Dim _arrayClass As New ArrayClass

        For i As Integer = 0 To _names.Length - 1
            _arrayClass.AddName(i, _names(i))
            _arrayClass.AddName(_names(i))
        Next
    End Sub

End Module
