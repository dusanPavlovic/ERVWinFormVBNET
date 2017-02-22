Public Class Repository
    Implements IRepository


    Public Function ListAll() As IEnumerable(Of Employee) Implements IRepository.ListAll
        Dim Employeelist = New ObjectSource
        Return Employeelist.GetEmployees()
    End Function

    Public Sub Save() Implements IRepository.Save

    End Sub
End Class
