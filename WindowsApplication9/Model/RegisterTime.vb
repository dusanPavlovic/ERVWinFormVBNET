Public Class RegisterTime
    Property RegisterTimeId As Integer
    Property TimeChecked As String
    Property EmployeeId As Integer
    Property CheckType As CheckType
    Public Overridable Property Employee As Employee

    Sub New(time As String, empId As Integer, checkType As CheckType)
        Me.TimeChecked = time
        Me.EmployeeId = empId
        Me.CheckType = checkType
    End Sub


End Class
