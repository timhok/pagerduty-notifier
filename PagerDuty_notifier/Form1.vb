


Public Class Form1

    Protected Overloads Overrides ReadOnly Property ShowWithoutActivation() As Boolean
        Get
            Return True
        End Get
    End Property

    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width - Me.Width - 30, Screen.PrimaryScreen.WorkingArea.Height - Me.Height)
        up.Start()
    End Sub

    Private Sub up_Tick(sender As Object, e As EventArgs) Handles up.Tick
        With Me
            If .Opacity >= 1 Then
                .up.Stop()
                .timeout.Start()
            End If
            .Opacity = .Opacity + 0.1
        End With
    End Sub

    Private Sub timeout_Tick(sender As Object, e As EventArgs) Handles timeout.Tick
        timeout.Stop()
        down.Start()
    End Sub

    Private Sub down_Tick(sender As Object, e As EventArgs) Handles down.Tick
        With Me
            If .Opacity < 0.1 Then
                .down.Stop()
                .Hide()
                .Opacity = 1
                .Close()
            End If
            .Opacity = .Opacity - 0.1
        End With
    End Sub
End Class

