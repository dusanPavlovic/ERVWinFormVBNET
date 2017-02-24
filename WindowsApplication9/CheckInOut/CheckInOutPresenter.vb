Public Class CheckInOutPresenter
    ReadOnly View As ICheckInOutView

    Public Sub New(View As ICheckInOutView)
        Me.View = View
    End Sub

    Sub Init()
        Dim viewModel = GetVievModel()

        View.Show(viewModel)

    End Sub

    Function GetVievModel() As CheckInOutVM
        Dim vm = New CheckInOutVM
        Return vm
    End Function


    Sub SaveCheckTime(time As String, id As Integer, checkType As CheckType)
        Dim repo = New Repository(New ERVContext)
        repo.SaveCheckTime(time, id, checkType)
    End Sub

  


End Class
