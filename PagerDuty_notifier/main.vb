Public Class main
    Dim incedent_need As String = "triggered,acknowledged"
    Dim okstatus As String = "{""incidents"":[],""limit"":100,""offset"":0,""total"":0}"
    Dim oldresp As String
    Dim resp As String
    Dim objHttp As Object = CreateObject("Msxml2.ServerXMLHTTP.6.0")

    Function checkpg() As String
        'objHttp.setProxy(2, "127.0.0.1:8888", "")
        If tx_token.Text = "" Or tx_token.Text = "" Then Return "" : Exit Function
        With objHttp
            Call .Open("GET", "https://" & tx_org.Text & ".pagerduty.com/api/v1/incidents?status=" & incedent_need, False)
            Call .setRequestHeader("Cookie", "remember_user_token=" & tx_token.Text & "; subdomain=" & tx_org.Text)
            Call .Send("")
            Return .Responsetext
        End With
    End Function

    Sub notif(text As String, color As Color)
        With Form1
            .Label1.Text = text
            .BackColor = color
            .Show()
        End With
    End Sub

    Function defaults(val, def)
        Return IIf(val <> vbNullString, val, def)
    End Function

    Private Sub update_Tick(sender As Object, e As EventArgs) Handles dupdate.Tick
        Label1.Text = "Last checked: " & Date.Now
        resp = checkpg()
        If resp <> oldresp Then
            If resp = okstatus Then
                notif("All problems resolved", Color.ForestGreen)
            ElseIf InStr(resp, "trigger_summary_data") > 1 Then
                Dim xspl As Array = Split(resp, "trigger_summary_data"":{""description"":""")
                notif(Split(xspl(UBound(xspl)), """},")(0), Color.Brown)
                If ch_wav.Checked Then My.Computer.Audio.Play(tx_wav.Text)
                Dim inc_count As String = Val(Split(resp, """total"":")(1))
                If inc_count > 1 Then
                    Form1.cnt.Visible = True
                    Form1.cnt.Text = inc_count
                Else
                    Form1.cnt.Visible = False
                End If

            Else
                notif("Unknown status recieved", Color.DimGray)
            End If
        Else
            Label1.Text = Label1.Text & " [no changes]"
        End If
        oldresp = resp
    End Sub

    Private Sub main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        oldresp = okstatus

        tx_org.Text = GetSetting("pd_notify", "s", "org")
        tx_token.Text = GetSetting("pd_notify", "s", "token")
        tx_freq.Text = defaults(GetSetting("pd_notify", "s", "freq"), "5000")
        tx_nf_stay.Text = defaults(GetSetting("pd_notify", "s", "nf_stay"), "3000")
        tx_wav.Text = defaults(GetSetting("pd_notify", "s", "wav"), "alert.wav")

        dupdate.Interval = Val(tx_freq.Text)
        Form1.timeout.Interval = Val(tx_nf_stay.Text)
    End Sub


    Private Sub set_org_Click(sender As Object, e As EventArgs) Handles set_org.Click
        SaveSetting("pd_notify", "s", "org", tx_org.Text)
    End Sub
    Private Sub set_token_Click(sender As Object, e As EventArgs) Handles set_token.Click
        SaveSetting("pd_notify", "s", "token", tx_token.Text)
    End Sub
    Private Sub set_freq_Click(sender As Object, e As EventArgs) Handles set_freq.Click
        tx_freq.Text = IIf(Val(tx_freq.Text) > 100, Val(tx_freq.Text), 100)
        SaveSetting("pd_notify", "s", "freq", tx_freq.Text)
    End Sub
    Private Sub set_nf_stay_Click(sender As Object, e As EventArgs) Handles set_nf_stay.Click
        tx_nf_stay.Text = IIf(Val(tx_nf_stay.Text) > 100, Val(tx_nf_stay.Text), 100)
        SaveSetting("pd_notify", "s", "nf_stay", tx_nf_stay.Text)
    End Sub
    Private Sub set_wav_Click(sender As Object, e As EventArgs) Handles set_wav.Click
        SaveSetting("pd_notify", "s", "wav", tx_wav.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.Audio.Play(tx_wav.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        notif("Test!", Color.MediumPurple)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox(checkpg())
    End Sub
End Class