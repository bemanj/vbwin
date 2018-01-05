Public Class Contractual
    Inherits EmployeeBase

    Private _lateDeduction As Decimal
    Public Property LastDeduction() As Decimal
        Get
            Return _lateDeduction
        End Get
        Set(ByVal value As Decimal)
            _lateDeduction = value
        End Set
    End Property

    Public Overrides Function GetSalary() As Decimal
        Return Math.Round(MyBase.GetSalary() - _lateDeduction, 2)
    End Function

End Class
