Public Interface IRepository
    Function ListAll() As IEnumerable(Of Employee)

    Sub SaveCheckInTime(time As String, id As Integer)




End Interface

