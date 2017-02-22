Public Class PresencePresenter
    ReadOnly view As IPresenceView

    Sub New(view As IPresenceView)
        Me.view = view
    End Sub

    Sub Init()
        Dim viewModel = GetViewModel()

        view.Show(viewModel)
    End Sub



    Function GetViewModel() As PresenceVM
        Dim repo = New Repository
        Dim vm = New PresenceVM()
        vm._employees = repo.ListAll()
        Return vm
    End Function


End Class
