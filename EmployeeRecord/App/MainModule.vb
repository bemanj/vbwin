Imports DL
Module MainModule

    Sub Main()

        Dim _contractual As New Contractual
        Dim _regular As New Regular

        Dim _employeeList As New List(Of EmployeeBase)

        Console.WriteLine("Please enter contractual employee")
        Console.Write("Firstname: ")
        _contractual.Firstname = Console.ReadLine()
        Console.Write("Lastname: ")
        _contractual.Lastname = Console.ReadLine()
        Console.Write("Date hire: ")
        _contractual.DateHire = Console.ReadLine()
        Console.Write("Age: ")
        _contractual.Age = Console.ReadLine()
        Console.Write("Rate: ")
        _contractual.Rate = Console.ReadLine()
        _contractual.LastDeduction = 1000

        Console.WriteLine("Please enter regular employee")
        Console.Write("Firstname: ")
        _regular.Firstname = Console.ReadLine()
        Console.Write("Lastname: ")
        _regular.Lastname = Console.ReadLine()
        Console.Write("Age: ")
        _regular.Age = Console.ReadLine()
        Console.Write("Date hire: ")
        _regular.DateHire = Console.ReadLine()
        Console.Write("Rate: ")
        _regular.Rate = Console.ReadLine()

        _employeeList.Add(_regular)
        _employeeList.Add(_contractual)

        Console.WriteLine("")
        Console.WriteLine("===================")
        Console.WriteLine("REGULAR EMPLOYEE")
        Console.WriteLine("NAME: " & _employeeList(0).Firstname & " " & _employeeList(0).Lastname)
        Console.WriteLine("AGE: " & _employeeList(0).Age.ToString)
        Console.WriteLine("RATE: " & _employeeList(0).GetSalary())
        Console.WriteLine("DATE HIRED: " & _employeeList(0).DateHire)
        Console.WriteLine("")
        Console.WriteLine("===================")
        Console.WriteLine("CONTRACTUAL EMPLOYEE")
        Console.WriteLine("NAME: " & _employeeList(1).Firstname & " " & _employeeList(1).Lastname)
        Console.WriteLine("AGE: " & _employeeList(1).Age.ToString)
        Console.WriteLine("RATE: " & _employeeList(1).GetSalary())
        Console.WriteLine("DATE HIRED: " & _employeeList(1).DateHire)
        ' Console.WriteLine(_contractual.Firstname & " " & _contractual.Lastname & " SALARY IS " & _contractual.GetSalary() & ", DATE HIRED " & _contractual.DateHire)
        Console.ReadKey()
    End Sub

End Module
