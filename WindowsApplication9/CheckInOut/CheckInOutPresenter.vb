Public Class CheckInOutPresenter
    ReadOnly View As ICheckInOutView

    Public Sub New(View As ICheckInOutView)
        Me.View = View
    End Sub

    Sub Init()
        Dim viewModel = GetVievModel()

    End Sub

    Function GetVievModel() As CheckInOutVM
        Dim model = New CheckInOutVM
        Return model
    End Function


End Class
