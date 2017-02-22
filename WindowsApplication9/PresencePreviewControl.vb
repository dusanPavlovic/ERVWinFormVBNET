Public Class PresencePreviewControl
    Implements IPresenceView

    Dim presenter As PresencePresenter

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        presenter = New PresencePresenter(Me)
        ' Add any initialization after the InitializeComponent() call.
        presenter.Init()

    End Sub



    Public Sub Show1(viewModel As PresenceVM) Implements IPresenceView.Show

        ListBox1.DataSource = viewModel._employees
        ListBox1.DisplayMember = "EmployeeName"

    End Sub


End Class
