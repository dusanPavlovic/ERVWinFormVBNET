Imports System.Data.Entity

Public Class Repository
    Implements IRepository


    Private db As ERVContext
    Sub New(context As DbContext)
        Me.db = context
    End Sub



    Public Function ListAll() As IEnumerable(Of Employee) Implements IRepository.ListAll
        Dim Employeelist = New ObjectSource
        Return Employeelist.GetEmployees()
    End Function


    Public Sub SaveCheckTime(time As String, id As Integer, checkType As CheckType) Implements IRepository.SaveCheckTime
        Using db As New ERVContext
            db.RegisterTimes.Add(New RegisterTime(time, id, checkType))
            db.SaveChanges()
        End Using

    End Sub

    'Public Function UserTimes() As List(Of RegisterTimes)
    '    Dim EmployecCheckInTime = New ObjectSource
    '    Return EmployecCheckInTime.Times()
    'End Function

   
End Class
