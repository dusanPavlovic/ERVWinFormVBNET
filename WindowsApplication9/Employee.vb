Public Class Employee

    Public Property EmployeeId As Integer
    Public Property EmployeeName As String
    Public Property IsPresent As Boolean

    Public Sub New(id As Integer, name As String)
        Me.EmployeeId = id
        Me.EmployeeName = name
    End Sub

End Class
