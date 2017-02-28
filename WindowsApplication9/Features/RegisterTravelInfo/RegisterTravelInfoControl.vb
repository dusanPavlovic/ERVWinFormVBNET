Imports DevExpress.XtraEditors.Controls

Public Class RegisterTravelInfoControl
    Implements IRegisterTravelView

    Dim presenter As RegisterTravelPresenter


    Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        presenter = New RegisterTravelPresenter(Me)
        ' Add any initialization after the InitializeComponent() call.
        presenter.Init()
    End Sub



    Private Sub SaveTravelInfoButton_Click(sender As Object, e As EventArgs) Handles SaveTravelInfoButton.Click
        Dim dateFrom As Date
        dateFrom = DateEditFrom.EditValue

        Dim dateTo As Date
        dateTo = DateEditTo.EditValue


        'Dim coll As ComboBoxItemCollection = ProjectNameComboBoxEdit.Properties.Items

        'coll.BeginUpdate()
        'Try
        '    coll.Add("Leatus")
        '    coll.Add("Katana")
        '    coll.Add("Relax")
        'Catch ex As Exception

        'End Try
        'coll.EndUpdate()

        'Controls.Add(ProjectNameComboBoxEdit)

        Dim ProjectNameComboBox As String
        ProjectNameComboBox = ProjectNameComboBoxEdit.SelectedText

    End Sub

    Public Sub Show1(viewModel As RegisterTravelVM) Implements IRegisterTravelView.Show

    End Sub
End Class
