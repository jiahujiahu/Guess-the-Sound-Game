Public Class Form1

    Dim TG As Integer
   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TG = 0
        My.Computer.Audio.Play(My.Resources.Introduction, AudioPlayMode.Background)
    End Sub

    Private Sub pic1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic1.Click
        picQ1.Visible = True
        lblMessage2.Visible = False
        picQ2.Visible = False
        picQ3.Visible = False
        picQ4.Visible = False
        picQ5.Visible = False
        picQ6.Visible = False
        picQ7.Visible = False
        picQ8.Visible = False
        picQ9.Visible = False
        TG = 1
        My.Computer.Audio.Play(My.Resources.Chopper, AudioPlayMode.Background)
    End Sub

    Private Sub pic2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic2.Click
        pic2.Visible = True
        lblMessage2.Visible = False
        picQ1.Visible = False
        picQ3.Visible = False
        picQ4.Visible = False
        picQ5.Visible = False
        picQ6.Visible = False
        picQ7.Visible = False
        picQ8.Visible = False
        picQ9.Visible = False
        TG = 2
        My.Computer.Audio.Play(My.Resources.Franky, AudioPlayMode.Background)
    End Sub

    Private Sub pic3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic3.Click
        picQ3.Visible = True
        lblMessage2.Visible = False
        picQ2.Visible = False
        picQ1.Visible = False
        picQ4.Visible = False
        picQ5.Visible = False
        picQ6.Visible = False
        picQ7.Visible = False
        picQ8.Visible = False
        picQ9.Visible = False
        TG = 3
        My.Computer.Audio.Play(My.Resources.Nami, AudioPlayMode.Background)
    End Sub

    Private Sub pic4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic4.Click
        picQ4.Visible = True
        lblMessage2.Visible = False
        picQ2.Visible = False
        picQ3.Visible = False
        picQ1.Visible = False
        picQ5.Visible = False
        picQ6.Visible = False
        picQ7.Visible = False
        picQ8.Visible = False
        picQ9.Visible = False
        TG = 4
        My.Computer.Audio.Play(My.Resources.Robin, AudioPlayMode.Background)
    End Sub

    Private Sub pic5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic5.Click
        picQ5.Visible = True
        lblMessage2.Visible = False
        picQ2.Visible = False
        picQ3.Visible = False
        picQ4.Visible = False
        picQ1.Visible = False
        picQ6.Visible = False
        picQ7.Visible = False
        picQ8.Visible = False
        picQ9.Visible = False
        TG = 5
        My.Computer.Audio.Play(My.Resources.Zoro, AudioPlayMode.Background)
    End Sub

    Private Sub pic6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic6.Click
        picQ6.Visible = True
        lblMessage2.Visible = False
        picQ2.Visible = False
        picQ3.Visible = False
        picQ4.Visible = False
        picQ5.Visible = False
        picQ1.Visible = False
        picQ7.Visible = False
        picQ8.Visible = False
        picQ9.Visible = False
        TG = 6
        My.Computer.Audio.Play(My.Resources.Luffy, AudioPlayMode.Background)
    End Sub

    Private Sub pic7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic7.Click
        picQ7.Visible = True
        lblMessage2.Visible = False
        picQ2.Visible = False
        picQ3.Visible = False
        picQ4.Visible = False
        picQ5.Visible = False
        picQ6.Visible = False
        picQ1.Visible = False
        picQ8.Visible = False
        picQ9.Visible = False
        TG = 7
        My.Computer.Audio.Play(My.Resources.Brook, AudioPlayMode.Background)
    End Sub

    Private Sub pic8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic8.Click
        picQ8.Visible = True
        lblMessage2.Visible = False
        picQ2.Visible = False
        picQ3.Visible = False
        picQ4.Visible = False
        picQ5.Visible = False
        picQ6.Visible = False
        picQ7.Visible = False
        picQ1.Visible = False
        picQ9.Visible = False
        TG = 8
        My.Computer.Audio.Play(My.Resources.Usopp, AudioPlayMode.Background)
    End Sub

    Private Sub pic9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic9.Click
        picQ9.Visible = True
        lblMessage2.Visible = False
        picQ2.Visible = False
        picQ3.Visible = False
        picQ4.Visible = False
        picQ5.Visible = False
        picQ6.Visible = False
        picQ7.Visible = False
        picQ8.Visible = False
        picQ1.Visible = False
        TG = 9
        My.Computer.Audio.Play(My.Resources.Sanji_2, AudioPlayMode.Background)
    End Sub

    Private Sub picBrook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picBrook.Click
        If TG = 0 Then
            lblMessage2.Visible = True
            My.Computer.Audio.Play(My.Resources.Introduction1, AudioPlayMode.Background)
        ElseIf picBrook.Tag = TG Then
            My.Computer.Audio.Play(My.Resources.chime_up, AudioPlayMode.Background)
            picBrook.Visible = False
            pic7.Visible = False
        Else
            My.Computer.Audio.Play(My.Resources.peeeooop_x, AudioPlayMode.Background)
        End If
        TG = 0
        picQ1.Visible = False
        picQ2.Visible = False
        picQ3.Visible = False
        picQ4.Visible = False
        picQ5.Visible = False
        picQ6.Visible = False
        picQ7.Visible = False
        picQ8.Visible = False
        picQ9.Visible = False

        If pic1.Visible = False And pic2.Visible = False And pic3.Visible = False And pic4.Visible = False And pic5.Visible = False And pic6.Visible = False And pic7.Visible = False And pic8.Visible = False And pic9.Visible = False Then
            Me.Hide()
            Form3.Show()
        End If

    End Sub

    Private Sub picNami_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picNami.Click
        If TG = 0 Then
            lblMessage2.Visible = True
            My.Computer.Audio.Play(My.Resources.Introduction1, AudioPlayMode.Background)
        ElseIf picNami.Tag = TG Then
            My.Computer.Audio.Play(My.Resources.chime_up, AudioPlayMode.Background)
            picNami.Visible = False
            pic3.Visible = False
        Else
            My.Computer.Audio.Play(My.Resources.peeeooop_x, AudioPlayMode.Background)
        End If
        TG = 0
        picQ1.Visible = False
        picQ2.Visible = False
        picQ3.Visible = False
        picQ4.Visible = False
        picQ5.Visible = False
        picQ6.Visible = False
        picQ7.Visible = False
        picQ8.Visible = False
        picQ9.Visible = False

        If pic1.Visible = False And pic2.Visible = False And pic3.Visible = False And pic4.Visible = False And pic5.Visible = False And pic6.Visible = False And pic7.Visible = False And pic8.Visible = False And pic9.Visible = False Then
            Me.Hide()
            Form3.Show()
        End If

    End Sub

    Private Sub picUsopp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picUsopp.Click
        If TG = 0 Then
            lblMessage2.Visible = True
            My.Computer.Audio.Play(My.Resources.Introduction1, AudioPlayMode.Background)
        ElseIf picUsopp.Tag = TG Then
            My.Computer.Audio.Play(My.Resources.chime_up, AudioPlayMode.Background)
            picUsopp.Visible = False
            pic8.Visible = False
        Else
            My.Computer.Audio.Play(My.Resources.peeeooop_x, AudioPlayMode.Background)
        End If
        TG = 0
        picQ1.Visible = False
        picQ2.Visible = False
        picQ3.Visible = False
        picQ4.Visible = False
        picQ5.Visible = False
        picQ6.Visible = False
        picQ7.Visible = False
        picQ8.Visible = False
        picQ9.Visible = False

        If pic1.Visible = False And pic2.Visible = False And pic3.Visible = False And pic4.Visible = False And pic5.Visible = False And pic6.Visible = False And pic7.Visible = False And pic8.Visible = False And pic9.Visible = False Then
            Me.Hide()
            Form3.Show()
        End If

    End Sub

    Private Sub picZoro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picZoro.Click
        If TG = 0 Then
            lblMessage2.Visible = True
            My.Computer.Audio.Play(My.Resources.Introduction1, AudioPlayMode.Background)
        ElseIf picZoro.Tag = TG Then
            My.Computer.Audio.Play(My.Resources.chime_up, AudioPlayMode.Background)
            picZoro.Visible = False
            pic5.Visible = False
        Else
            My.Computer.Audio.Play(My.Resources.peeeooop_x, AudioPlayMode.Background)
        End If
        TG = 0
        picQ1.Visible = False
        picQ2.Visible = False
        picQ3.Visible = False
        picQ4.Visible = False
        picQ5.Visible = False
        picQ6.Visible = False
        picQ7.Visible = False
        picQ8.Visible = False
        picQ9.Visible = False

        If pic1.Visible = False And pic2.Visible = False And pic3.Visible = False And pic4.Visible = False And pic5.Visible = False And pic6.Visible = False And pic7.Visible = False And pic8.Visible = False And pic9.Visible = False Then
            Me.Hide()
            Form3.Show()
        End If

    End Sub

    Private Sub picLuffy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picLuffy.Click
        If TG = 0 Then
            lblMessage2.Visible = True
            My.Computer.Audio.Play(My.Resources.Introduction1, AudioPlayMode.Background)
        ElseIf picLuffy.Tag = TG Then
            My.Computer.Audio.Play(My.Resources.chime_up, AudioPlayMode.Background)
            picLuffy.Visible = False
            pic6.Visible = False
        Else
            My.Computer.Audio.Play(My.Resources.peeeooop_x, AudioPlayMode.Background)
        End If
        TG = 0
        picQ1.Visible = False
        picQ2.Visible = False
        picQ3.Visible = False
        picQ4.Visible = False
        picQ5.Visible = False
        picQ6.Visible = False
        picQ7.Visible = False
        picQ8.Visible = False
        picQ9.Visible = False

        If pic1.Visible = False And pic2.Visible = False And pic3.Visible = False And pic4.Visible = False And pic5.Visible = False And pic6.Visible = False And pic7.Visible = False And pic8.Visible = False And pic9.Visible = False Then
            Me.Hide()
            Form3.Show()
        End If

    End Sub

    Private Sub picSanji_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picSanji.Click
        If TG = 0 Then
            lblMessage2.Visible = True
            My.Computer.Audio.Play(My.Resources.Introduction1, AudioPlayMode.Background)
        ElseIf picSanji.Tag = TG Then
            My.Computer.Audio.Play(My.Resources.chime_up, AudioPlayMode.Background)
            picSanji.Visible = False
            pic9.Visible = False
        Else
            My.Computer.Audio.Play(My.Resources.peeeooop_x, AudioPlayMode.Background)
        End If
        TG = 0
        picQ1.Visible = False
        picQ2.Visible = False
        picQ3.Visible = False
        picQ4.Visible = False
        picQ5.Visible = False
        picQ6.Visible = False
        picQ7.Visible = False
        picQ8.Visible = False
        picQ9.Visible = False

        If pic1.Visible = False And pic2.Visible = False And pic3.Visible = False And pic4.Visible = False And pic5.Visible = False And pic6.Visible = False And pic7.Visible = False And pic8.Visible = False And pic9.Visible = False Then
            Me.Hide()
            Form3.Show()
        End If

    End Sub

    Private Sub picRobin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picRobin.Click
        If TG = 0 Then
            lblMessage2.Visible = True
            My.Computer.Audio.Play(My.Resources.Introduction1, AudioPlayMode.Background)
        ElseIf picRobin.Tag = TG Then
            My.Computer.Audio.Play(My.Resources.chime_up, AudioPlayMode.Background)
            picRobin.Visible = False
            pic4.Visible = False
        Else
            My.Computer.Audio.Play(My.Resources.peeeooop_x, AudioPlayMode.Background)
        End If
        TG = 0
        picQ1.Visible = False
        picQ2.Visible = False
        picQ3.Visible = False
        picQ4.Visible = False
        picQ5.Visible = False
        picQ6.Visible = False
        picQ7.Visible = False
        picQ8.Visible = False
        picQ9.Visible = False

        If pic1.Visible = False And pic2.Visible = False And pic3.Visible = False And pic4.Visible = False And pic5.Visible = False And pic6.Visible = False And pic7.Visible = False And pic8.Visible = False And pic9.Visible = False Then
            Me.Hide()
            Form3.Show()
        End If

    End Sub

    Private Sub picChopper_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picChopper.Click
        If TG = 0 Then
            lblMessage2.Visible = True
            My.Computer.Audio.Play(My.Resources.Introduction1, AudioPlayMode.Background)
        ElseIf picChopper.Tag = TG Then
            My.Computer.Audio.Play(My.Resources.chime_up, AudioPlayMode.Background)
            picChopper.Visible = False
            pic1.Visible = False
        Else
            My.Computer.Audio.Play(My.Resources.peeeooop_x, AudioPlayMode.Background)
        End If
        TG = 0
        picQ1.Visible = False
        picQ2.Visible = False
        picQ3.Visible = False
        picQ4.Visible = False
        picQ5.Visible = False
        picQ6.Visible = False
        picQ7.Visible = False
        picQ8.Visible = False
        picQ9.Visible = False

        If pic1.Visible = False And pic2.Visible = False And pic3.Visible = False And pic4.Visible = False And pic5.Visible = False And pic6.Visible = False And pic7.Visible = False And pic8.Visible = False And pic9.Visible = False Then
            Me.Hide()
            Form3.Show()
        End If

    End Sub

    Private Sub picFranky_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picFranky.Click
        If TG = 0 Then
            lblMessage2.Visible = True
            My.Computer.Audio.Play(My.Resources.Introduction1, AudioPlayMode.Background)
        ElseIf picFranky.Tag = TG Then
            My.Computer.Audio.Play(My.Resources.chime_up, AudioPlayMode.Background)
            picFranky.Visible = False
            pic2.Visible = False
        Else
            My.Computer.Audio.Play(My.Resources.peeeooop_x, AudioPlayMode.Background)
        End If
        TG = 0
        picQ1.Visible = False
        picQ2.Visible = False
        picQ3.Visible = False
        picQ4.Visible = False
        picQ5.Visible = False
        picQ6.Visible = False
        picQ7.Visible = False
        picQ8.Visible = False
        picQ9.Visible = False

        If pic1.Visible = False And pic2.Visible = False And pic3.Visible = False And pic4.Visible = False And pic5.Visible = False And pic6.Visible = False And pic7.Visible = False And pic8.Visible = False And pic9.Visible = False Then
            Me.Hide()
            Form3.Show()
        End If

    End Sub
End Class
