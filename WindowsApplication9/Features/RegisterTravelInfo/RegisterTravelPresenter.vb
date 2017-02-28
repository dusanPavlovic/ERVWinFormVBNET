Public Class RegisterTravelPresenter
    ReadOnly view As IRegisterTravelView

    Sub New(view As IRegisterTravelView)
        Me.view = view
    End Sub

    Sub Init()
        Dim viewModel As RegisterTravelVM = GetViewModel()
        view.Show(viewModel)
    End Sub

    Function GetViewModel() As RegisterTravelVM
        Dim repo = New Repository()

    End Function
End Class
