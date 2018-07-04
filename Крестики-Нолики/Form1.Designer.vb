<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PCBall = New System.Windows.Forms.Label()
        Me.MyBall = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.ButtonNewGame = New System.Windows.Forms.Button()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox0 = New System.Windows.Forms.PictureBox()
        Me.Доска = New System.Windows.Forms.PictureBox()
        Me.DrawBall = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Доска, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PCBall
        '
        Me.PCBall.AutoSize = True
        Me.PCBall.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.PCBall.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PCBall.Location = New System.Drawing.Point(389, 32)
        Me.PCBall.MaximumSize = New System.Drawing.Size(64, 46)
        Me.PCBall.MinimumSize = New System.Drawing.Size(64, 46)
        Me.PCBall.Name = "PCBall"
        Me.PCBall.Size = New System.Drawing.Size(64, 46)
        Me.PCBall.TabIndex = 38
        Me.PCBall.Text = "0"
        Me.PCBall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MyBall
        '
        Me.MyBall.AutoSize = True
        Me.MyBall.BackColor = System.Drawing.SystemColors.Control
        Me.MyBall.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.MyBall.ForeColor = System.Drawing.Color.Navy
        Me.MyBall.Location = New System.Drawing.Point(310, 32)
        Me.MyBall.MaximumSize = New System.Drawing.Size(64, 46)
        Me.MyBall.MinimumSize = New System.Drawing.Size(64, 46)
        Me.MyBall.Name = "MyBall"
        Me.MyBall.Size = New System.Drawing.Size(64, 46)
        Me.MyBall.TabIndex = 37
        Me.MyBall.Text = "0"
        Me.MyBall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(355, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 20)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Счет"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(320, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 17)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Уровень игры ПК"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ComboBox1.Items.AddRange(New Object() {"Легкий", "Средний", "Сложный"})
        Me.ComboBox1.Location = New System.Drawing.Point(310, 182)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(143, 24)
        Me.ComboBox1.TabIndex = 34
        Me.ComboBox1.Text = "Легкий"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(342, 254)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(75, 21)
        Me.RadioButton2.TabIndex = 33
        Me.RadioButton2.Text = "Нолики"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(339, 207)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 17)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Вы играете за"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(342, 231)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(88, 21)
        Me.RadioButton1.TabIndex = 31
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Крестики"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'ButtonNewGame
        '
        Me.ButtonNewGame.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButtonNewGame.Location = New System.Drawing.Point(310, 277)
        Me.ButtonNewGame.Name = "ButtonNewGame"
        Me.ButtonNewGame.Size = New System.Drawing.Size(143, 26)
        Me.ButtonNewGame.TabIndex = 30
        Me.ButtonNewGame.Text = "Новая игра"
        Me.ButtonNewGame.UseVisualStyleBackColor = True
        '
        'PictureBox8
        '
        Me.PictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox8.Enabled = False
        Me.PictureBox8.Location = New System.Drawing.Point(206, 210)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(93, 93)
        Me.PictureBox8.TabIndex = 29
        Me.PictureBox8.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox7.Enabled = False
        Me.PictureBox7.Location = New System.Drawing.Point(107, 210)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(93, 93)
        Me.PictureBox7.TabIndex = 28
        Me.PictureBox7.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox6.Enabled = False
        Me.PictureBox6.Location = New System.Drawing.Point(8, 210)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(93, 93)
        Me.PictureBox6.TabIndex = 27
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox5.Enabled = False
        Me.PictureBox5.Location = New System.Drawing.Point(206, 111)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(93, 93)
        Me.PictureBox5.TabIndex = 26
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Enabled = False
        Me.PictureBox4.Location = New System.Drawing.Point(107, 111)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(93, 93)
        Me.PictureBox4.TabIndex = 25
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Enabled = False
        Me.PictureBox3.Location = New System.Drawing.Point(8, 111)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(93, 93)
        Me.PictureBox3.TabIndex = 24
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Enabled = False
        Me.PictureBox2.Location = New System.Drawing.Point(206, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(93, 93)
        Me.PictureBox2.TabIndex = 23
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Enabled = False
        Me.PictureBox1.Location = New System.Drawing.Point(107, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(93, 93)
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'PictureBox0
        '
        Me.PictureBox0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox0.Enabled = False
        Me.PictureBox0.Location = New System.Drawing.Point(8, 12)
        Me.PictureBox0.Name = "PictureBox0"
        Me.PictureBox0.Size = New System.Drawing.Size(93, 93)
        Me.PictureBox0.TabIndex = 21
        Me.PictureBox0.TabStop = False
        '
        'Доска
        '
        Me.Доска.BackgroundImage = CType(resources.GetObject("Доска.BackgroundImage"), System.Drawing.Image)
        Me.Доска.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Доска.InitialImage = Nothing
        Me.Доска.Location = New System.Drawing.Point(4, 7)
        Me.Доска.Name = "Доска"
        Me.Доска.Size = New System.Drawing.Size(300, 300)
        Me.Доска.TabIndex = 20
        Me.Доска.TabStop = False
        '
        'DrawBall
        '
        Me.DrawBall.AutoSize = True
        Me.DrawBall.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.DrawBall.ForeColor = System.Drawing.Color.Black
        Me.DrawBall.Location = New System.Drawing.Point(351, 98)
        Me.DrawBall.MaximumSize = New System.Drawing.Size(64, 46)
        Me.DrawBall.MinimumSize = New System.Drawing.Size(64, 46)
        Me.DrawBall.Name = "DrawBall"
        Me.DrawBall.Size = New System.Drawing.Size(64, 46)
        Me.DrawBall.TabIndex = 39
        Me.DrawBall.Text = "0"
        Me.DrawBall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label5.Location = New System.Drawing.Point(355, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 20)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Ничьи"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 319)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DrawBall)
        Me.Controls.Add(Me.PCBall)
        Me.Controls.Add(Me.MyBall)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.ButtonNewGame)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox0)
        Me.Controls.Add(Me.Доска)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Доска, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PCBall As System.Windows.Forms.Label
    Friend WithEvents MyBall As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents ButtonNewGame As System.Windows.Forms.Button
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox0 As System.Windows.Forms.PictureBox
    Friend WithEvents Доска As System.Windows.Forms.PictureBox
    Friend WithEvents DrawBall As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
