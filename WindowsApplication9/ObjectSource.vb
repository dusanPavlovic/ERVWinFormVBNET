Public Class ObjectSource
    Private _employees As List(Of Employee)

    Private _times As List(Of RegisterTime)

    Public Sub New()
        _employees = New List(Of Employee)
        _employees.Add(New Employee(1, "Adam", True))
        _employees.Add(New Employee(2, "Pera", True))
        _employees.Add(New Employee(3, "Sima", True))
        _employees.Add(New Employee(4, "Ceda", True))
        _employees.Add(New Employee(5, "Jova", True))
        _employees.Add(New Employee(3, "Ema", False))
        _employees.Add(New Employee(4, "Paja", False))
        _employees.Add(New Employee(5, "Milos", False))
    End Sub


    Public Function GetEmployees() As List(Of Employee)
        Return _employees
    End Function



    Sub SaveCheckInTime(time As String, id As Integer)
        _times = New List(Of RegisterTime)
        Dim regTimes = New RegisterTime(time, id)
        _times.Add(regTimes)

    End Sub

    Function Times() As List(Of RegisterTime)
        Return _times

    End Function

End Class
