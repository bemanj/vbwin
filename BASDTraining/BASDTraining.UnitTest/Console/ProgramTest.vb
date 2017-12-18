Imports System.Text
Imports BASDTraining.Console

<TestClass()>
Public Class ProgramTest

    Private testContextInstance As TestContext

    '''<summary>
    '''Gets or sets the test context which provides
    '''information about and functionality for the current test run.
    '''</summary>
    Public Property TestContext() As TestContext
        Get
            Return testContextInstance
        End Get
        Set(ByVal value As TestContext)
            testContextInstance = Value
        End Set
    End Property

#Region "Additional test attributes"
    '
    ' You can use the following additional attributes as you write your tests:
    '
    ' Use ClassInitialize to run code before running the first test in the class
    ' <ClassInitialize()> Public Shared Sub MyClassInitialize(ByVal testContext As TestContext)
    ' End Sub
    '
    ' Use ClassCleanup to run code after all tests in a class have run
    ' <ClassCleanup()> Public Shared Sub MyClassCleanup()
    ' End Sub
    '
    ' Use TestInitialize to run code before running each test
    ' <TestInitialize()> Public Sub MyTestInitialize()
    ' End Sub
    '
    ' Use TestCleanup to run code after each test has run
    ' <TestCleanup()> Public Sub MyTestCleanup()
    ' End Sub
    '
#End Region

    <TestMethod()>
    Public Sub TestGetSum2()
        ' TODO: Add test logic here
        Dim _program As New Program()
        'Dim _valueOne = "1"
        'Dim _valueTwo = "2"

        'StringAssert.Matches(_program.GetString("Rainier"), "")

        Assert.AreEqual(_program.GetString("Rainier"), _
        "This is my string: Rainier")

    End Sub


    'Dim _expectedCollection As Dictionary(Of String, String) = _
    '    New Dictionary(Of String, String)
    '_expectedCollection.Add("Name", _valueOne)
    '_expectedCollection.Add("Address", _valueTwo)
    'CollectionAssert. _
    '   _program.GetCollection(_valueOne, _valueTwo), _
    '   New KeyValuePair(Of String, String)("Name", _valueOne))

    'Dim _sample As List(Of Dictionary(Of String, List(Of String)))
    'Dim _test = New Dictionary(Of String, List(Of String))

    ''_test.Add(New Dictionary(Of String, List(Of String)))
    '_test.Add("Names", New List(Of String))
    '_test("Names").Add("Rainier")
    '_test("Names").Add("Robert")

    '_sample.Add(_test)
    '<TestMethod()>
    'Public Sub TestGetSum()

    '    Dim _program As New Program()
    '    Dim _valueOne = 2
    '    Dim _valueTwo = 3

    '    Assert.IsTrue(_program.GetSum(_valueOne, _valueTwo) = 5)

    '    Microsoft.VisualStudio.TestTools.UnitTesting.Assert()
    '    StringAssert()
    '    CollectionAssert()
    'End Sub

End Class
