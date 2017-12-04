Imports System.Runtime.CompilerServices
Imports System.Data.SqlClient
Imports System.Reflection
Imports System

Module EntityExtensions

    <Extension()>
    Sub MapParameters(ByVal command As SqlCommand, ByVal paramList As SqlParameter())
        If paramList Is Nothing Then Return
        If paramList.Length = 0 Then Return
        If command.CommandType <> CommandType.StoredProcedure Then Throw New Exception("Cannot derive parameters, stored procedure is required.")
        SqlCommandBuilder.DeriveParameters(command)
        For Each parameter As SqlParameter In command.Parameters
            If (parameter.Direction = ParameterDirection.Input) OrElse (parameter.Direction = ParameterDirection.InputOutput) Then
                Dim param = paramList.Where(Function(x) x.ParameterName = parameter.ParameterName).FirstOrDefault()
                parameter.Value = If(param IsNot Nothing, param.Value, Nothing)
            End If
        Next
    End Sub

    <Extension()>
    Function SingleMapToEntity(Of T As New)(ByVal table As DataTable) As List(Of T)
        Dim _targetType As Type = GetType(T)
        Dim _columns As DataColumn() = table.Columns.Cast(Of DataColumn)().ToArray()
        Dim _list As List(Of T) = New List(Of T)()
        For Each dr As DataRow In table.Rows
            Dim _data As T = New T()
            For Each col As DataColumn In _columns
                Dim _info As PropertyInfo = _targetType.GetProperty(If(_columns.First().Equals(col), "Id", col.ColumnName))
                If _info IsNot Nothing Then
                    Dim _value As Object = Nothing
                    If dr(col.ColumnName).[GetType]() = GetType(DateTime) AndAlso _info.PropertyType = GetType(String) Then
                        _value = String.Format("{0: " & System.Configuration.ConfigurationManager.AppSettings("AppDateFormat").ToString() & "}", dr(col.ColumnName))
                    Else
                        _value = If(dr(col.ColumnName).[GetType]() = GetType(DBNull), Nothing, dr(col.ColumnName))
                    End If
                    _info.SetValue(_data, IIf(dr(col.ColumnName).GetType() = GetType(DBNull), Nothing, _value), Nothing)
                    '_info.SetValue(_data, If(dr(col.ColumnName).GetType() = GetType(DBNull), Nothing, _value))
                End If
            Next

            _list.Add(_data)
        Next

        Return _list
    End Function

    <Extension()>
    Function SingleMapToEntity(Of T As New)(ByVal table As DataTable, ByVal primaryKey As String) As List(Of T)
        Dim _targetType As Type = GetType(T)
        Dim _columns As DataColumn() = table.Columns.Cast(Of DataColumn)().ToArray()
        Dim _list As List(Of T) = New List(Of T)()
        For Each dr As DataRow In table.Rows
            Dim _data As T = New T()
            For Each col As DataColumn In _columns
                Dim _info As PropertyInfo = _targetType.GetProperty(If(primaryKey.Equals(col.ColumnName), "Id", col.ColumnName))
                If _info IsNot Nothing Then
                    Dim _value As Object = Nothing
                    If dr(col.ColumnName).[GetType]() = GetType(DateTime) AndAlso _info.PropertyType = GetType(String) Then
                        _value = String.Format("{0: " & System.Configuration.ConfigurationManager.AppSettings("AppDateFormat").ToString() & "}", dr(col.ColumnName))
                    Else
                        _value = If(dr(col.ColumnName).[GetType]() = GetType(DBNull), Nothing, dr(col.ColumnName))
                    End If
                    
                    _info.SetValue(_data, IIf(dr(col.ColumnName).GetType() = GetType(DBNull), Nothing, _value), Nothing)
                End If
            Next

            _list.Add(_data)
        Next

        Return _list
    End Function

    '<Extension()>
    'Function EntityToSingleMap(ByVal entities As IEnumerable(Of IEntity), ByVal tableType As TableType) As DataTable
    '    Dim dt As DataTable = New DataTable()
    '    Dim dataColumns = tableType.GetDataTableColumns()
    '    dt.Columns.AddRange(dataColumns)
    '    For Each entity In entities
    '        Dim dataRow = dt.NewRow()
    '        For Each column As DataColumn In dataColumns
    '            dataRow(column.ColumnName) = entity.GetType().GetProperty(column.ColumnName).GetValue(entity, Nothing)
    '        Next

    '        If dt.Rows.IndexOf(dataRow) = -1 Then dt.Rows.Add(dataRow)
    '    Next

    '    Return dt
    'End Function

    '<Extension()>
    'Private Function GetDataTableColumns(ByVal tableType As TableType) As DataColumn()
    '    If tableType = tableType.TopTask Then Return New DataColumn() {New DataColumn("top_task_no"), New DataColumn("budget_centre"), New DataColumn("biennium"), New DataColumn("category"), New DataColumn("programme"), New DataColumn("priority"), New DataColumn("output"), New DataColumn("deliverable"), New DataColumn("products_and_services"), New DataColumn("planned_cost"), New DataColumn("created_by")}
    '    If tableType = tableType.LowerTask Then Return New DataColumn() {New DataColumn("top_task_id"), New DataColumn("lower_task_no"), New DataColumn("lower_task_name"), New DataColumn("partner"), New DataColumn("donors"), New DataColumn("other_donor"), New DataColumn("ccs_strategic_priority"), New DataColumn("assistance_type"), New DataColumn("target_country"), New DataColumn("target_date"), New DataColumn("cross_cutting_programmes"), New DataColumn("estimate_cost"), New DataColumn("notes"), New DataColumn("created_by")}
    '    If tableType = tableType.TaskLinkage Then
    '        Return New DataColumn() {New DataColumn("task_linkage_id"), New DataColumn("lower_task_id"), New DataColumn("linkage_type"), New DataColumn("linkage_group_id"), New DataColumn("linkage_id"), New DataColumn("created_by"), New DataColumn("updated_by"), New DataColumn("action")}
    '    End If

    '    Return New DataColumn() {}
    'End Function

    Function InsertColumn(ByVal name As String, ByVal type As String, ByVal length As String, ByVal notNull As Boolean) As String
        Return String.Format("[{0}]   [{1}]{2}    {3} NULL,", name, type, If(Not String.IsNullOrEmpty(length), String.Format("({0})", length), String.Empty), If(notNull, "NOT", String.Empty))
    End Function

    Public Enum TableType
        TopTask
        LowerTask
        TaskLinkage
    End Enum
End Module
