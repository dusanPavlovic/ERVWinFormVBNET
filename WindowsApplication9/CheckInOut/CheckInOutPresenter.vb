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


    Sub SaveCheckInTime(time As String, id As Integer)
        Dim repo = New Repository(New ERVContext)
        repo.SaveCheckInTime(time, id)
    End Sub



End Class
