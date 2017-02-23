Public Class RegisterTime
    Property RegisterTimeId As Integer
    Property TimeChecked As String
    Property EmployeeId As Integer
    Property CheckType As CheckType
    Public Overridable Property Employee As Employee

    Sub New(time As String, empId As Integer)
        Me.TimeChecked = time
        Me.EmployeeId = empId
    End Sub


End Class
