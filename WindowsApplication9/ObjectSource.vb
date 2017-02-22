Public Class ObjectSource
    Private _employees As List(Of Employee)

    Public Sub New()
        _employees = New List(Of Employee)
        _employees.Add(New Employee(1, "Adam"))
        _employees.Add(New Employee(2, "Pera"))
        _employees.Add(New Employee(3, "Sima"))
        _employees.Add(New Employee(4, "Ceda"))
        _employees.Add(New Employee(5, "Jova"))
    End Sub


    Public Function GetEmployees() As List(Of Employee)
        Return _employees
    End Function


End Class
