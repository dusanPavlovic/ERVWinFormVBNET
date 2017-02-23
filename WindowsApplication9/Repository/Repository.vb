Public Class Repository
    Implements IRepository



    Public Function ListAll() As IEnumerable(Of Employee) Implements IRepository.ListAll
        Dim Employeelist = New ObjectSource
        Return Employeelist.GetEmployees()
    End Function


    Public Sub SaveCheckInTime(time As String, id As Integer) Implements IRepository.SaveCheckInTime
        Dim EmployecCheckInTime = New ObjectSource
        EmployecCheckInTime.SaveCheckInTime(time, id)
    End Sub

    'Public Function UserTimes() As List(Of RegisterTimes)
    '    Dim EmployecCheckInTime = New ObjectSource
    '    Return EmployecCheckInTime.Times()
    'End Function

End Class
