Imports BASD.Helper
Imports System.Configuration
Imports System.Data.SqlClient

Public Class EmployeeRepository
    Inherits BaseRepository

    Public Sub New()
        MyBase.New(ConfigurationManager.ConnectionStrings("RainierDBConnnectionString").ConnectionString)
    End Sub

    Public Overrides Function InsertData(ByVal entity As BASD.Helper.IEntity) As Integer
        Dim _tempParamList = New List(Of SqlParameter)
        Dim _employeeEntity = CType(entity, Employee)
        _tempParamList.Add(New SqlParameter("@Id", _employeeEntity.Id))
        _tempParamList.Add(New SqlParameter("@Firstname", _employeeEntity.Firstname))
        _tempParamList.Add(New SqlParameter("@Lastname", _employeeEntity.Lastname))
        _tempParamList.Add(New SqlParameter("@Rate", _employeeEntity.Rate))
        _tempParamList.Add(New SqlParameter("@EmployeeType", _employeeEntity.EmployeeType))

        Dim _tempResult = MyBase.Update("[uspSaveEmployee]", _tempParamList.ToArray())

        Return _tempResult
    End Function

    Public Overrides Function GetListData() As System.Collections.Generic.IEnumerable(Of BASD.Helper.IEntity)

        Dim _tempEmployeeList = MyBase.List("[uspGetEmployeeList]")
        Return _tempEmployeeList.SingleMapToEntity(Of Employee)().ToList()

    End Function


    Public Overrides Function GetData(ByVal entity As BASD.Helper.IEntity) As BASD.Helper.IEntity
        Dim _tempParamList = New List(Of SqlParameter)
        _tempParamList.Add(New SqlParameter("@Id", entity.Id))

        Dim _tempEmployee = MyBase.List("[uspGetEmployee]", _tempParamList.ToArray())

        Return _tempEmployee.SingleMapToEntity(Of Employee).FirstOrDefault()

    End Function

    Public Overrides Sub DeleteData(ByVal entity As BASD.Helper.IEntity)
        Dim _tempParamList = New List(Of SqlParameter)
        _tempParamList.Add(New SqlParameter("@Id", entity.Id))
        MyBase.Execute("[uspDeleteEmployee]", _tempParamList.ToArray())


        Dim _tempEmployee = MyBase.List("[uspGetEmployee]", _tempParamList.ToArray())
        Dim _tempEmployeeEntity = _tempEmployee.SingleMapToEntity(Of Employee).FirstOrDefault()

        If _tempEmployeeEntity Is Nothing Then
            MessageBox.Show("Successfully deleted.")
        End If

    End Sub



End Class
