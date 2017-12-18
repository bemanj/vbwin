Imports BASD.Helper
Imports System.Configuration

Public Class LibraryRepository
    Inherits BaseRepository

    Public Sub New()
        MyBase.New(ConfigurationManager.ConnectionStrings("PizzaOrderConnectionString").ConnectionString.Decrypt)
    End Sub


    Public Function GetAggregate() As LibraryAggregate

        Dim _tempLibraryAggregateDataSet = MyBase.Aggregate("[uspGetLibrary]", Nothing)
        Dim _tempLibraryAggregateEntity As New LibraryAggregate

        _tempLibraryAggregateEntity.PizzaTypeLibrary = _tempLibraryAggregateDataSet.Tables(0) _
            .SingleMapToEntity(Of PizzaType)()

        Return _tempLibraryAggregateEntity

    End Function

End Class
