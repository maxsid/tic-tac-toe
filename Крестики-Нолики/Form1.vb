Public Class Form1
    Public pole(0 To 8) As String
    Public zn, znS, w As String
    Public Sub xod()
        If PictureBox0.Enabled = False Then
            PictureBox0.Enabled = True
            PictureBox1.Enabled = True
            PictureBox2.Enabled = True
            PictureBox3.Enabled = True
            PictureBox4.Enabled = True
            PictureBox5.Enabled = True
            PictureBox6.Enabled = True
            PictureBox7.Enabled = True
            PictureBox8.Enabled = True
        Else
            PictureBox0.Enabled = False
            PictureBox1.Enabled = False
            PictureBox2.Enabled = False
            PictureBox3.Enabled = False
            PictureBox4.Enabled = False
            PictureBox5.Enabled = False
            PictureBox6.Enabled = False
            PictureBox7.Enabled = False
            PictureBox8.Enabled = False

        End If
    End Sub 'Блокирует/разблокирует постановку знака на поле
    Public Sub obn()
        If pole(0) = "X" Then PictureBox0.Image = Крестики_Нолики.My.Resources.Resources.X
        If pole(0) = "O" Then PictureBox0.Image = Крестики_Нолики.My.Resources.Resources._0

        If pole(1) = "X" Then PictureBox1.Image = Крестики_Нолики.My.Resources.Resources.X
        If pole(1) = "O" Then PictureBox1.Image = Крестики_Нолики.My.Resources.Resources._0

        If pole(2) = "X" Then PictureBox2.Image = Крестики_Нолики.My.Resources.Resources.X
        If pole(2) = "O" Then PictureBox2.Image = Крестики_Нолики.My.Resources.Resources._0

        If pole(3) = "X" Then PictureBox3.Image = Крестики_Нолики.My.Resources.Resources.X
        If pole(3) = "O" Then PictureBox3.Image = Крестики_Нолики.My.Resources.Resources._0

        If pole(4) = "X" Then PictureBox4.Image = Крестики_Нолики.My.Resources.Resources.X
        If pole(4) = "O" Then PictureBox4.Image = Крестики_Нолики.My.Resources.Resources._0

        If pole(5) = "X" Then PictureBox5.Image = Крестики_Нолики.My.Resources.Resources.X
        If pole(5) = "O" Then PictureBox5.Image = Крестики_Нолики.My.Resources.Resources._0

        If pole(6) = "X" Then PictureBox6.Image = Крестики_Нолики.My.Resources.Resources.X
        If pole(6) = "O" Then PictureBox6.Image = Крестики_Нолики.My.Resources.Resources._0

        If pole(7) = "X" Then PictureBox7.Image = Крестики_Нолики.My.Resources.Resources.X
        If pole(7) = "O" Then PictureBox7.Image = Крестики_Нолики.My.Resources.Resources._0

        If pole(8) = "X" Then PictureBox8.Image = Крестики_Нолики.My.Resources.Resources.X
        If pole(8) = "O" Then PictureBox8.Image = Крестики_Нолики.My.Resources.Resources._0

    End Sub 'Обновляет поле в соответсвии с массивом pole
    Public Sub II()
        Dim a As Integer
1:      Randomize()
        a = Int(Rnd() * 8)
        If pole(a) = "" Then
            pole(a) = znS
        Else
            GoTo 1
        End If
    End Sub  'Поведение ИИ
    Public Sub pob()
        Dim b, i As Integer
        b = 0
            If pole(0) <> "" And pole(0) = pole(1) And pole(1) = pole(2) Then
                If pole(1) = zn Then
                    MsgBox("You Win!")
                    MyBall.Text = Val(MyBall.Text) + 1
                Else
                    MsgBox("You lose!")
                    PCBall.Text = Val(PCBall.Text) + 1
                End If
                w = 1
            End If
            If pole(3) <> "" And pole(3) = pole(4) And pole(4) = pole(5) Then
                If pole(3) = zn Then
                    MsgBox("You Win!")
                    MyBall.Text = Val(MyBall.Text) + 1
                Else
                    MsgBox("You lose!")
                    PCBall.Text = Val(PCBall.Text) + 1
                End If
                w = 1
            End If
            If pole(6) <> "" And pole(6) = pole(7) And pole(7) = pole(8) Then
                If pole(6) = zn Then
                    MsgBox("You Win!")
                    MyBall.Text = Val(MyBall.Text) + 1
                Else
                    MsgBox("You lose!")
                    PCBall.Text = Val(PCBall.Text) + 1
                End If
                w = 1
            End If
            If pole(0) <> "" And pole(0) = pole(3) And pole(3) = pole(6) Then
                If pole(0) = zn Then
                    MsgBox("You Win!")
                    MyBall.Text = Val(MyBall.Text) + 1
                Else
                    MsgBox("You lose!")
                    PCBall.Text = Val(PCBall.Text) + 1
                End If
                w = 1
            End If
            If pole(1) <> "" And pole(1) = pole(4) And pole(4) = pole(7) Then
                If pole(1) = zn Then
                    MsgBox("You Win!")
                    MyBall.Text = Val(MyBall.Text) + 1
                Else
                    MsgBox("You lose!")
                    PCBall.Text = Val(PCBall.Text) + 1
                End If
                w = 1
            End If
            If pole(2) <> "" And pole(2) = pole(5) And pole(5) = pole(8) Then
                If pole(2) = zn Then
                    MsgBox("You Win!")
                    MyBall.Text = Val(MyBall.Text) + 1
                Else
                    MsgBox("You lose!")
                    PCBall.Text = Val(PCBall.Text) + 1
                End If
                w = 1
            End If
            If pole(0) <> "" And pole(0) = pole(4) And pole(4) = pole(8) Then
                If pole(0) = zn Then
                    MsgBox("You Win!")
                    MyBall.Text = Val(MyBall.Text) + 1
                Else
                    MsgBox("You lose!")
                    PCBall.Text = Val(PCBall.Text) + 1
                End If
                w = 1
            End If
            If pole(2) <> "" And pole(2) = pole(4) And pole(4) = pole(6) Then
                If pole(2) = zn Then
                    MsgBox("You Win!")
                    MyBall.Text = Val(MyBall.Text) + 1
                Else
                    MsgBox("You lose!")
                    PCBall.Text = Val(PCBall.Text) + 1
                End If
                w = 1
            End If
        For i = 0 To 8 ' Количество свободных полей
            If pole(i) = "" Then b = b + 1
        Next
        If b = 0 Then
            If w <> 1 Then
                MsgBox("Ничья")
                DrawBall.Text = Val(DrawBall.Text) + 1
            End If
        End If

    End Sub 'Проверка на победу или ничью
    Public Sub StopGame()
        ButtonNewGame.Text = "Новая игра"
        RadioButton1.Enabled = True
        RadioButton2.Enabled = True
        ComboBox1.Enabled = True
        For i = 0 To 8
            pole(i) = ""
        Next
        xod()
        PictureBox0.Image = Nothing
        PictureBox1.Image = Nothing
        PictureBox2.Image = Nothing
        PictureBox3.Image = Nothing
        PictureBox4.Image = Nothing
        PictureBox5.Image = Nothing
        PictureBox6.Image = Nothing
        PictureBox7.Image = Nothing
        PictureBox8.Image = Nothing
    End Sub 'Останавливает игру
    Public Sub Press()
        obn()
        pob()
        If w <> 1 Then
            II()
            obn()
            pob()
        End If

    End Sub
    Private Sub ButtonNewGame_Click(sender As Object, e As EventArgs) Handles ButtonNewGame.Click
        If ButtonNewGame.Text = "Новая игра" Then
            RadioButton1.Enabled = False
            RadioButton2.Enabled = False
            ComboBox1.Enabled = False
            ButtonNewGame.Text = "Закончить игру"
            If RadioButton1.Checked = True Then
                zn = "X"
                znS = "O"
                xod()
            Else
                zn = "O"
                znS = "X"
                II()
                obn()
                xod()
            End If
        Else
            StopGame()
        End If

    End Sub
    Private Sub PictureBox0_Click_1(sender As Object, e As EventArgs) Handles PictureBox0.Click
        If pole(0) = "" Then
            pole(0) = zn
            obn()
            pob()
            II()
            obn()
            pob()
        End If

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If pole(1) = "" Then
            pole(1) = zn
            Press()
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If pole(2) = "" Then
            pole(2) = zn
            Press()
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If pole(3) = "" Then
            pole(3) = zn
            Press()
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If pole(4) = "" Then
            pole(4) = zn
            Press()
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        If pole(5) = "" Then
            pole(5) = zn
            Press()
        End If
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        If pole(6) = "" Then
            pole(6) = zn
            Press()
        End If
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        If pole(7) = "" Then
            pole(7) = zn
            Press()
        End If
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        If pole(8) = "" Then
            pole(8) = zn
            Press()
        End If
    End Sub
End Class
