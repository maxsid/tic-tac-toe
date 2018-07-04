Public Class Form1
    Public pole(0 To 3, 0 To 3) As String
    Public zn, znS As String
    Public b As Integer
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
        If pole(1, 1) = "X" Then PictureBox0.Image = Крестики_Нолики.My.Resources.Resources.X
        If pole(1, 1) = "O" Then PictureBox0.Image = Крестики_Нолики.My.Resources.Resources._0

        If pole(1, 2) = "X" Then PictureBox1.Image = Крестики_Нолики.My.Resources.Resources.X
        If pole(1, 2) = "O" Then PictureBox1.Image = Крестики_Нолики.My.Resources.Resources._0

        If pole(1, 3) = "X" Then PictureBox2.Image = Крестики_Нолики.My.Resources.Resources.X
        If pole(1, 3) = "O" Then PictureBox2.Image = Крестики_Нолики.My.Resources.Resources._0

        If pole(2, 1) = "X" Then PictureBox3.Image = Крестики_Нолики.My.Resources.Resources.X
        If pole(2, 1) = "O" Then PictureBox3.Image = Крестики_Нолики.My.Resources.Resources._0

        If pole(2, 2) = "X" Then PictureBox4.Image = Крестики_Нолики.My.Resources.Resources.X
        If pole(2, 2) = "O" Then PictureBox4.Image = Крестики_Нолики.My.Resources.Resources._0

        If pole(2, 3) = "X" Then PictureBox5.Image = Крестики_Нолики.My.Resources.Resources.X
        If pole(2, 3) = "O" Then PictureBox5.Image = Крестики_Нолики.My.Resources.Resources._0

        If pole(3, 1) = "X" Then PictureBox6.Image = Крестики_Нолики.My.Resources.Resources.X
        If pole(3, 1) = "O" Then PictureBox6.Image = Крестики_Нолики.My.Resources.Resources._0

        If pole(3, 2) = "X" Then PictureBox7.Image = Крестики_Нолики.My.Resources.Resources.X
        If pole(3, 2) = "O" Then PictureBox7.Image = Крестики_Нолики.My.Resources.Resources._0

        If pole(3, 3) = "X" Then PictureBox8.Image = Крестики_Нолики.My.Resources.Resources.X
        If pole(3, 3) = "O" Then PictureBox8.Image = Крестики_Нолики.My.Resources.Resources._0

    End Sub 'Обновляет поле в соответсвии с массивом pole
    Public Sub II()
        Dim a, b, i As Integer
        If ComboBox1.Text = "Легкий" Then 'При легком уровне сложности
1:
            a = Int(Rnd() * 4)
            b = Int(Rnd() * 4)
            If pole(a, b) = "" And a <> 0 And b <> 0 Then
                pole(a, b) = znS
            Else
                GoTo 1
            End If
        End If
        If ComboBox1.Text = "Средний" Then 'При среднем уровне сложности
            a = 0
            For i = 1 To 3
                If ((pole(1, i) = znS And pole(2, i) = znS) Or (pole(1, i) = zn And pole(2, i) = zn)) And pole(3, i) = "" Then
                    pole(3, i) = znS
                    a = 1
                    Exit Sub
                End If
                If ((pole(1, i) = znS And pole(3, i) = znS) Or (pole(1, i) = zn And pole(3, i) = zn)) And pole(2, i) = "" Then
                    pole(2, i) = znS
                    a = 1
                    Exit Sub
                End If
                If ((pole(2, i) = znS And pole(3, i) = znS) Or (pole(2, i) = zn And pole(3, i) = zn)) And pole(1, i) = "" Then
                    pole(1, i) = znS
                    a = 1
                    Exit Sub
                End If
                If ((pole(i, 1) = znS And pole(i, 2) = znS) Or (pole(i, 1) = zn And pole(i, 2) = zn)) And pole(i, 3) = "" Then
                    pole(i, 3) = znS
                    a = 1
                    Exit Sub
                End If
                If ((pole(i, 1) = znS And pole(i, 3) = znS) Or (pole(i, 1) = zn And pole(i, 3) = zn)) And pole(i, 2) = "" Then
                    pole(i, 2) = znS
                    a = 1
                    Exit Sub
                End If
                If ((pole(i, 2) = znS And pole(i, 3) = znS) Or (pole(i, 2) = zn And pole(i, 3) = zn)) And pole(i, 1) = "" Then
                    pole(i, 1) = znS
                    a = 1
                    Exit Sub
                End If
            Next
            'Проверка диагоналей
            If ((pole(1, 1) = znS And pole(2, 2) = znS) Or (pole(1, 1) = zn And pole(2, 2) = zn)) And pole(3, 3) = "" Then
                pole(3, 3) = znS
                Exit Sub
            End If
            If ((pole(1, 1) = znS And pole(3, 3) = znS) Or (pole(1, 1) = zn And pole(3, 3) = zn)) And pole(2, 2) = "" Then
                pole(2, 2) = znS
                Exit Sub
            End If
            If ((pole(3, 3) = znS And pole(2, 2) = znS) Or (pole(3, 3) = zn And pole(2, 2) = zn)) And pole(1, 1) = "" Then
                pole(1, 1) = znS
                Exit Sub
            End If
            If ((pole(1, 3) = znS And pole(2, 2) = znS) Or (pole(1, 3) = zn And pole(2, 2) = zn)) And pole(3, 1) = "" Then
                pole(3, 1) = znS
                Exit Sub
            End If
            If ((pole(3, 1) = znS And pole(2, 2) = znS) Or (pole(3, 1) = zn And pole(2, 2) = zn)) And pole(1, 3) = "" Then
                pole(1, 3) = znS
                Exit Sub
            End If
            If ((pole(1, 3) = znS And pole(3, 1) = znS) Or (pole(1, 3) = zn And pole(3, 1) = zn)) And pole(2, 2) = "" Then
                pole(2, 2) = znS
                Exit Sub
            End If
2:
            a = Int(Rnd() * 4)
            b = Int(Rnd() * 4)
            If pole(a, b) = "" And a <> 0 And b <> 0 Then
                pole(a, b) = znS
            Else
                GoTo 2
            End If
        End If
        If ComboBox1.Text = "Сложный" Then 'При сложном уровне сложности
            For i = 1 To 3 'Закрывает свое
                If pole(1, i) = znS And pole(2, i) = znS And pole(3, i) = "" Then
                    pole(3, i) = znS
                    Exit Sub
                End If
                If pole(1, i) = znS And pole(3, i) = znS And pole(2, i) = "" Then
                    pole(2, i) = znS
                    Exit Sub
                End If
                If pole(3, i) = znS And pole(2, i) = znS And pole(1, i) = "" Then
                    pole(1, i) = znS
                    Exit Sub
                End If
                If pole(i, 1) = znS And pole(i, 2) = znS And pole(i, 3) = "" Then
                    pole(i, 3) = znS
                    Exit Sub
                End If
                If pole(i, 1) = znS And pole(i, 3) = znS And pole(i, 2) = "" Then
                    pole(i, 2) = znS
                    Exit Sub
                End If
                If pole(i, 3) = znS And pole(i, 2) = znS And pole(i, 1) = "" Then
                    pole(i, 1) = znS
                    Exit Sub
                End If
            Next
            If pole(1, 1) = znS And pole(2, 2) = znS And pole(3, 3) = "" Then
                pole(3, 3) = znS
                Exit Sub
            End If
            If pole(1, 1) = znS And pole(3, 3) = znS And pole(2, 2) = "" Then
                pole(2, 2) = znS
                Exit Sub
            End If
            If pole(3, 3) = znS And pole(2, 2) = znS And pole(1, 1) = "" Then
                pole(1, 1) = znS
                Exit Sub
            End If
            If pole(3, 1) = znS And pole(2, 2) = znS And pole(1, 3) = "" Then
                pole(1, 3) = znS
                Exit Sub
            End If
            If pole(3, 1) = znS And pole(1, 3) = znS And pole(2, 2) = "" Then
                pole(2, 2) = znS
                Exit Sub
            End If
            If pole(1, 3) = znS And pole(2, 2) = znS And pole(3, 1) = "" Then
                pole(3, 1) = znS
                Exit Sub
            End If
            For i = 1 To 3 'Закрывает соперника
                If pole(1, i) = zn And pole(2, i) = zn And pole(3, i) = "" Then
                    pole(3, i) = znS
                    Exit Sub
                End If
                If pole(1, i) = zn And pole(3, i) = zn And pole(2, i) = "" Then
                    pole(2, i) = znS
                    Exit Sub
                End If
                If pole(3, i) = zn And pole(2, i) = zn And pole(1, i) = "" Then
                    pole(1, i) = znS
                    Exit Sub
                End If
                If pole(i, 1) = zn And pole(i, 2) = zn And pole(i, 3) = "" Then
                    pole(i, 3) = znS
                    Exit Sub
                End If
                If pole(i, 1) = zn And pole(i, 3) = zn And pole(i, 2) = "" Then
                    pole(i, 2) = znS
                    Exit Sub
                End If
                If pole(i, 3) = zn And pole(i, 2) = zn And pole(i, 1) = "" Then
                    pole(i, 1) = znS
                    Exit Sub
                End If
            Next
            If pole(1, 1) = zn And pole(2, 2) = zn And pole(3, 3) = "" Then
                pole(3, 3) = znS
                Exit Sub
            End If
            If pole(1, 1) = zn And pole(3, 3) = zn And pole(2, 2) = "" Then
                pole(2, 2) = znS
                Exit Sub
            End If
            If pole(3, 3) = zn And pole(2, 2) = zn And pole(1, 1) = "" Then
                pole(1, 1) = znS
                Exit Sub
            End If
            If pole(3, 1) = zn And pole(2, 2) = zn And pole(1, 3) = "" Then
                pole(1, 3) = znS
                Exit Sub
            End If
            If pole(3, 1) = zn And pole(1, 3) = zn And pole(2, 2) = "" Then
                pole(2, 2) = znS
                Exit Sub
            End If
            If pole(1, 3) = zn And pole(2, 2) = zn And pole(3, 1) = "" Then
                pole(3, 1) = znS
                Exit Sub
            End If
            'как лучше ходить
4:          b = Int(Rnd() * 100) + 1
            If pole(1, 1) <> "" And pole(1, 3) <> "" And pole(3, 1) <> "" And pole(3, 3) <> "" Then
                GoTo 3
            End If
            Select Case b
                Case 1 To 12
                    If pole(1, 1) = "" Then
                        pole(1, 1) = znS
                        Exit Sub
                    Else
                        GoTo 4
                    End If
                Case 13 To 24
                    If pole(1, 3) = "" Then
                        pole(1, 3) = znS
                        Exit Sub
                    Else
                        GoTo 4
                    End If
                Case 25 To 37
                    If pole(3, 1) = "" Then
                        pole(3, 1) = znS
                        Exit Sub
                    Else
                        GoTo 4
                    End If
                Case 38 To 50
                    If pole(3, 3) = "" Then
                        pole(3, 3) = znS
                        Exit Sub
                    Else
                        GoTo 4
                    End If
                Case 51 To 100
                    If pole(2, 2) = "" Then
                        pole(2, 2) = znS
                        Exit Sub
                    Else
                        GoTo 4
                    End If
                Case Else
                    GoTo 3
            End Select

3:          a = Int(Rnd() * 4)
            b = Int(Rnd() * 4)
            If pole(a, b) = "" And a <> 0 And b <> 0 Then
                pole(a, b) = znS
            Else
                GoTo 3
            End If
        End If
    End Sub  'Поведение ИИ
    Public Sub pob()
        Dim i, j, n As Integer
        For i = 1 To 3
            If pole(i, 1) <> "" And pole(i, 1) = pole(i, 2) And pole(i, 2) = pole(i, 3) Then
                If pole(i, 1) = zn Then
                    MsgBox("You win!")
                    MyBall.Text = Val(MyBall.Text) + 1
                    xod()
                    n = n + 100
                    Exit For
                Else
                    MsgBox("You lose!")
                    PCBall.Text = Val(PCBall.Text) + 1
                    xod()
                    n = n + 100
                    Exit For
                End If
            End If
            If pole(1, i) <> "" And pole(1, i) = pole(2, i) And pole(2, i) = pole(3, i) Then
                If pole(1, i) = zn Then
                    MsgBox("You win!")
                    MyBall.Text = Val(MyBall.Text) + 1
                    xod()
                    n = n + 100
                    Exit For
                Else
                    MsgBox("You lose!")
                    PCBall.Text = Val(PCBall.Text) + 1
                    xod()
                    n = n + 100
                    Exit For
                End If
            End If
        Next
        If pole(1, 1) <> "" And pole(2, 2) = pole(1, 1) And pole(2, 2) = pole(3, 3) Then
            If pole(1, 1) = zn Then
                MsgBox("You win!")
                MyBall.Text = Val(MyBall.Text) + 1
                xod()
                n = n + 100
            Else
                MsgBox("You lose!")
                PCBall.Text = Val(PCBall.Text) + 1
                xod()
                n = n + 100
            End If
        End If
        If pole(1, 3) <> "" And pole(2, 2) = pole(1, 3) And pole(2, 2) = pole(3, 1) Then
            If pole(1, 3) = zn Then
                MsgBox("You win!")
                MyBall.Text = Val(MyBall.Text) + 1
                xod()
                n = n + 100
            Else
                MsgBox("You lose!")
                PCBall.Text = Val(PCBall.Text) + 1
                xod()
                n = n + 100
            End If
        End If
        For i = 1 To 3
            For j = 1 To 3
                If pole(i, j) <> "" Then
                    n = n + 1
                End If
            Next
        Next
        If n = 9 Then
            MsgBox("Ничья")
            DrawBall.Text = Val(DrawBall.Text) + 1
            xod()
        End If
    End Sub 'Проверка на победу или ничью
    Public Sub StopGame()
        ButtonNewGame.Text = "Новая игра"
        RadioButton1.Enabled = True
        RadioButton2.Enabled = True
        ComboBox1.Enabled = True
        For i = 1 To 3
            For j = 1 To 3
                pole(i, j) = ""
            Next
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
        If b = MyBall.Text & PCBall.Text & DrawBall.Text Then
            II()
            obn()
            pob()
        End If

    End Sub 'При нажатии на кнопку



    Private Sub ButtonNewGame_Click(sender As Object, e As EventArgs) Handles ButtonNewGame.Click
        If ButtonNewGame.Text = "Новая игра" Then
            b = MyBall.Text & PCBall.Text & DrawBall.Text
            RadioButton1.Enabled = False
            RadioButton2.Enabled = False
            ComboBox1.Enabled = False
            ButtonNewGame.Text = "Закончить игру"
            If RadioButton1.Checked = True Then
                zn = "X"
                znS = "O"
                xod()
                MyBall.ForeColor = Color.Red
                PCBall.ForeColor = Color.Blue
            Else
                MyBall.ForeColor = Color.Blue
                PCBall.ForeColor = Color.Red
                zn = "O"
                znS = "X"
                II()
                obn()
                xod()
            End If
        Else
            StopGame()
            xod()
        End If

    End Sub
    Private Sub PictureBox0_Click_1(sender As Object, e As EventArgs) Handles PictureBox0.Click
        If pole(1, 1) = "" Then
            pole(1, 1) = zn
            Press()

        End If

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If pole(1, 2) = "" Then
            pole(1, 2) = zn
            Press()
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If pole(1, 3) = "" Then
            pole(1, 3) = zn
            Press()
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If pole(2, 1) = "" Then
            pole(2, 1) = zn
            Press()
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If pole(2, 2) = "" Then
            pole(2, 2) = zn
            Press()
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        If pole(2, 3) = "" Then
            pole(2, 3) = zn
            Press()
        End If
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        If pole(3, 1) = "" Then
            pole(3, 1) = zn
            Press()
        End If
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        If pole(3, 2) = "" Then
            pole(3, 2) = zn
            Press()
        End If
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        If pole(3, 3) = "" Then
            pole(3, 3) = zn
            Press()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Text = "Средний"
        Randomize()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        MsgBox("Крестики-нолики" & vbNewLine & "Сделано на Visual Studio Express 2012" & vbNewLine & "Разработчик - Максим Сидоров")
    End Sub
End Class
