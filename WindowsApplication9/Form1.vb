Public Class Form1

    Private Sub TabbedView1_QueryControl(sender As Object, e As DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs) Handles TabbedView1.QueryControl

        If e.Document.ControlName = "CheckInOutDocument" Then
            e.Control = New CheckInOutControl()


        End If

        If e.Document.ControlName = "RegisterTravelInfoDocument" Then
            e.Control = New RegisterTravelInfoControl()

        End If

        If e.Document.ControlName = "PresencePreviewDocument" Then

            e.Control = New PresencePreviewControl()
        End If
        If e.Document.ControlName = "ReportsDocument" Then

            e.Control = New ReportsControl()
        End If



    End Sub
End Class
