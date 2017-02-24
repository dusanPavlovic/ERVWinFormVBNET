Public Interface IRepository
    Function ListAll() As IEnumerable(Of Employee)

    Sub SaveCheckTime(time As String, id As Integer, checkType As CheckType)




End Interface

