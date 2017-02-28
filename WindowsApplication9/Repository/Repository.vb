Imports System.Data.Entity
Imports DevExpress.XtraEditors.Controls

Public Class Repository
    Implements IRepository



    Private _servis As IERVService

    ' da li mi treba ovaj construktor? tj ovaj dependecy
    'Sub New(servis As IERVService)
    '    Me._servis = servis
    'End Sub





    Public Function ListAll() As IEnumerable(Of Employee) Implements IRepository.ListAll

        ' _servis.ListAllEmployees()

    End Function


    Public Sub SaveCheckTime(time As String, id As Integer, checkType As CheckType) Implements IRepository.SaveCheckTime
        'Using db As New ERVContext
        '    db.RegisterTimes.Add(New RegisterTime(time, id, checkType))
        '    db.SaveChanges()
        'End Using
        _servis.SaveTime()
    End Sub

    'Public Function UserTimes() As List(Of RegisterTimes)
    '    Dim EmployecCheckInTime = New ObjectSource
    '    Return EmployecCheckInTime.Times()
    'End Function


    Public Function ListAllProjects() As IEnumerable(Of Project) Implements IRepository.ListAllProjects

        
    End Function
End Class
