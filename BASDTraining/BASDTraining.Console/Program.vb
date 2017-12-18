
Imports BASD.Helper

Public Class Program
    Shared Sub Main(ByVal args As String())
        Dim _program As New Program()
        Dim _valueOne, _valueTwo As Integer

        _valueOne = CInt(System.Console.ReadLine())
        _valueTwo = CInt(System.Console.ReadLine())

        System.Console.WriteLine(_program.GetSum(_valueOne, _valueTwo))
        System.Console.ReadKey()
    End Sub

    Public Function GetSum(ByVal paramOne As Integer, ByVal paramTwo As Integer) As Integer
        
        Return paramOne + paramTwo

    End Function

    Public Function GetCollection(ByVal paramOne As String, _
                                  ByVal paramTwo As String) _
                              As Dictionary(Of String, String)
        Dim _tempParamCollection = New Dictionary(Of String, String)
        _tempParamCollection.Add("Name", paramOne)
        _tempParamCollection.Add("Address", paramTwo)
        Return _tempParamCollection
    End Function

    Public Function GetString(ByVal paramOne As String) As String
        Return "This is my string: " & paramOne
    End Function
    'Public Function GetMinutes(ByVal seconds As Integer) As Integer
    '    'Return seconds * 60
    'End Function

End Class


