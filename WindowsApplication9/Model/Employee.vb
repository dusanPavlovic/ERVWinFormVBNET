Public Class Employee

    Public Property EmployeeId As Integer
    Public Property EmployeeName As String
    Public Property IsPresent As Boolean

    Public Sub New()
        Me.Times = New List(Of RegisterTime)
    End Sub


    Public Sub New(id As Integer, name As String, presence As Boolean)
        Me.EmployeeId = id
        Me.EmployeeName = name
        Me.IsPresent = presence
    End Sub

    Public Overridable Property Times As ICollection(Of RegisterTime)


End Class
