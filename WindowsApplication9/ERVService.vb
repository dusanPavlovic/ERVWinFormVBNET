Imports RestSharp

Public Class ERVService
    Implements IERVService


    Dim _servis As IERVService

    Sub New(servis As IERVService)
        Me._servis = servis
    End Sub


    Public Sub ListAllEmployees() Implements IERVService.ListAllEmployees
        Dim client = New RestClient()
        client.BaseUrl = New Uri("")

        Dim request = New RestRequest("Employee", Method.GET)

        Dim response As IRestResponse(Of List(Of Employee)) = client.Execute(request)

    End Sub

    Public Sub SaveTime() Implements IERVService.SaveTime

    End Sub
End Class
