Imports BASD.Helper

Imports System.Configuration
Imports System.Data.SqlClient


Public Class OrderRepository
    Inherits BaseRepository

    Public Sub New()
        MyBase.New(ConfigurationManager.ConnectionStrings("PizzaOrderConnectionString").ConnectionString.Decrypt)
    End Sub

    Public Overrides Function GetData(ByVal entity As IEntity) As BASD.Helper.IEntity
        Dim _tempParamList = New List(Of SqlParameter)()
        _tempParamList.Add(New SqlParameter("OrderID", entity.Id))

        Dim _tempOrderList = MyBase.List("uspOrderList", _tempParamList.ToArray())

        Return _tempOrderList.SingleMapToEntity(Of Orders)().SingleOrDefault()

    End Function

    Public Overrides Function GetListData() As System.Collections.Generic.IEnumerable(Of BASD.Helper.IEntity)
        Dim _tempOrderList = MyBase.List("uspOrderList", Nothing)
        Return _tempOrderList.SingleMapToEntity(Of Orders)()


    End Function

End Class
