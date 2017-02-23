Public Class PresencePresenter
    ReadOnly view As IPresenceView

    Sub New(view As IPresenceView)
        Me.view = view
    End Sub

    Sub Init()
        Dim viewModel = GetViewModel()

        view.Show(viewModel)
    End Sub

    Function ShowAbsenceEmployees() As List(Of Employee)

        Dim employees As PresenceVM = GetViewModel()

        Dim presentEmp = From emp In employees._employees
                   Where emp.IsPresent = False
                   Select emp

        Return presentEmp.ToList()
    End Function


    ' what about this approach?
    'Sub ShowAbsenceEmployees()
    '    Dim vm = GetViewModel()
    '    vm._employees = vm._employees.Where(Function(w) w.IsPresent = False)
    '    view.Show(vm)
    'End Sub





    'Function ShowCheckInTime(employeeId As Integer) As String
    '    Dim repo = New Repository
    '    Dim times = repo.UserTimes()

    '    Dim time = From e In times
    '               Where e.EmployeeId = employeeId
    '               Select e.CheckInTime

    '    Return time

    'End Function





    Function GetViewModel() As PresenceVM
        Dim repo = New Repository(New ERVContext)
        Dim vm = New PresenceVM()
        vm._employees = repo.ListAll()

        Return vm
    End Function


End Class
