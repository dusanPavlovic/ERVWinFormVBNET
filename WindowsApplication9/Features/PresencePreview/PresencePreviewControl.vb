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


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim presentEmp = presenter.ShowAbsenceEmployees()


        'Dim present = 

        ' present = presenter.ShowAbsenceEmployees()

        ListBox2.DataSource = presentEmp
        ListBox2.DisplayMember = "EmployeeName"

    End Sub





    Private Sub ShowEmpTimesButton_Click(sender As Object, e As EventArgs) Handles ShowEmpTimesButton.Click
        'Dim dateEmp As String
        'dateEmp = DateEdit1.EditValue.ToString()

        Dim dateEmp As Date = Nothing
        dateEmp = DateEdit1.EditValue

    End Sub
End Class
