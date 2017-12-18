Imports BASD.Helper

Imports System.Configuration
Imports System.Data.SqlClient

Public Class LoginRepository
    Inherits BaseRepository

    Public Sub New()
        MyBase.New(ConfigurationManager.ConnectionStrings("PizzaOrderConnectionString").ConnectionString.Decrypt)
    End Sub

    Public Overrides Function GetData(ByVal entity As BASD.Helper.IEntity) As BASD.Helper.IEntity
        Dim _tempEntity = CType(entity, User)

        Dim _tempParamList = New List(Of SqlParameter)()
        _tempParamList.Add(New SqlParameter("@username", _tempEntity.Username))
        '_tempParamList.Add(New SqlParameter("@password", _tempEntity.Password))

        Dim _tempOrderList = MyBase.List("uspGetUser", _tempParamList.ToArray())

        Return _tempOrderList.SingleMapToEntity(Of User)().SingleOrDefault()

    End Function
End Class
