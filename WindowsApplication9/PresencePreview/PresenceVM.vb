Public Class PresenceVM



    Private tittle As String
    Public Property Title() As String
        Get
            Return tittle
        End Get
        Set(ByVal value As String)
            tittle = value
        End Set
    End Property

    Public _employees As List(Of Employee)



End Class
