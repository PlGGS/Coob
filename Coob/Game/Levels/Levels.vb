'Booleans as timers

Public Class Levels
    Inherits Screen

    Dim k_left As Boolean
    Dim k_right As Boolean

    Dim coobImg As Image = My.Resources.CoobCharacterFront
    Dim coobBounds As Rectangle
    Dim recGround1 As Rectangle
    Dim recGround2 As Rectangle
    Dim recGround3 As Rectangle
    Dim recGround4 As Rectangle
    Dim recGround5 As Rectangle
    Dim recGround6 As Rectangle
    Dim recGround7 As Rectangle
    Dim recGround8 As Rectangle
    Dim recGround9 As Rectangle
    Dim recGround10 As Rectangle
    Dim recGround11 As Rectangle
    Dim recGround12 As Rectangle
    Dim recGround13 As Rectangle

    Dim spike1 As Rectangle
    Dim spike2 As Rectangle
    Dim spike3 As Rectangle
    Dim spike4 As Rectangle
    Dim spike5 As Rectangle
    Dim spike6 As Rectangle
    Dim spike7 As Rectangle
    Dim spike8 As Rectangle
    Dim spike9 As Rectangle
    Dim spike10 As Rectangle

    Dim Door As Rectangle

    Dim lazer1 As Rectangle

    Dim Key As Rectangle

    Dim hasKey As Boolean

    Dim OnGround As Boolean

    Dim lblWin As Label

    Dim Heart1 As Boolean = True
    Dim Heart2 As Boolean = True
    Dim Heart3 As Boolean = True

    Dim WithEvents timJumped As Timer
    Dim WithEvents timOnGround As Timer
    Dim WithEvents timGravity As Timer

    Dim jumpTime As Single


    Public Sub New()

        timGravity = New Timer

        timGravity.Interval = 1
        timGravity.Enabled = False

        timJumped = New Timer

        timJumped.Interval = 1

        timJumped.Enabled = False

        timOnGround = New Timer

        timOnGround.Interval = 1

        timOnGround.Enabled = False

        coobBounds = New Rectangle(460, 100, 74, 64)

        Me.DoubleBuffered = True

    End Sub

    Public Overrides Sub hideScreen()

    End Sub

    Public Overrides Sub keyDownHandler(sender As Object, e As KeyEventArgs)

        If e.KeyCode = Keys.A Then

            k_left = True

        End If

        If e.KeyCode = Keys.D Then

            k_right = True

        End If

        If e.KeyCode = Keys.F Then

            If timGravity.Enabled = False Then

                timGravity.Start()

            Else

                timGravity.Stop()

            End If

        End If

        If e.KeyCode = Keys.Space And OnGround = True Then

            timJumped.Start()

        End If

    End Sub

    Public Overrides Sub keyUpHandler(sender As Object, e As KeyEventArgs)

        If e.KeyCode = Keys.A Then

            k_left = False

        End If

        If e.KeyCode = Keys.D Then

            k_right = False

        End If

    End Sub

    Public Overrides Sub showScreen()

    End Sub

    Public Overrides Sub Screen_Paint(sender As Object, e As PaintEventArgs)

        e.Graphics.DrawImage(My.Resources.level1Image, 0, 0, Me.Width, Me.Height)

        'below is creation of blocks n' stoof

        recGround1 = New Rectangle(0, 186, 652, 72)
        e.Graphics.DrawRectangle(Pens.DarkSlateBlue, recGround1)

        recGround2 = New Rectangle(652, 218, 165, 40)
        e.Graphics.DrawRectangle(Pens.DarkSlateBlue, recGround2)

        recGround3 = New Rectangle(817, 186, 672, 72)
        e.Graphics.DrawRectangle(Pens.DarkSlateBlue, recGround3)

        recGround4 = New Rectangle(1248, 438, 672, 60)
        e.Graphics.DrawRectangle(Pens.DarkSlateBlue, recGround4)

        recGround5 = New Rectangle(1709, 498, 67, 424)
        e.Graphics.DrawRectangle(Pens.DarkSlateBlue, recGround5)

        recGround6 = New Rectangle(1046, 849, 663, 73)
        e.Graphics.DrawRectangle(Pens.DarkSlateBlue, recGround6)

        recGround7 = New Rectangle(0, 630, 1335, 73)
        e.Graphics.DrawRectangle(Pens.DarkSlateBlue, recGround7)

        recGround8 = New Rectangle(496, 454, 212, 40)
        e.Graphics.DrawRectangle(Pens.DarkSlateBlue, recGround8)

        recGround9 = New Rectangle(581, 494, 38, 136)
        e.Graphics.DrawRectangle(Pens.DarkSlateBlue, recGround9)

        recGround10 = New Rectangle(202, 494, 38, 136)
        e.Graphics.DrawRectangle(Pens.DarkSlateBlue, recGround10)

        recGround11 = New Rectangle(0, 454, 240, 40)
        e.Graphics.DrawRectangle(Pens.DarkSlateBlue, recGround11)

        recGround12 = New Rectangle(548, 849, 356, 73)
        e.Graphics.DrawRectangle(Pens.DarkSlateBlue, recGround12)

        recGround13 = New Rectangle(0, 1040, 1920, 40)
        e.Graphics.DrawRectangle(Pens.DarkSlateBlue, recGround13)

        'below is creation of key

        Key = New Rectangle(103, 413, 34, 30)

        If hasKey = False Then

            e.Graphics.DrawImage(My.Resources.Gold_Key, 103, 413, 34, 30)

        End If

        'below is creation of spikes

        spike1 = New Rectangle(652, 184, 34, 34)
        e.Graphics.DrawImage(My.Resources.Red_Spike, 652, 184, 34, 34)

        spike2 = New Rectangle(686, 184, 34, 34)
        e.Graphics.DrawImage(My.Resources.Red_Spike, 686, 184, 34, 34)

        spike3 = New Rectangle(720, 184, 34, 34)
        e.Graphics.DrawImage(My.Resources.Red_Spike, 720, 184, 34, 34)

        spike4 = New Rectangle(754, 184, 34, 34)
        e.Graphics.DrawImage(My.Resources.Red_Spike, 754, 184, 34, 34)

        spike5 = New Rectangle(788, 184, 29, 34)
        e.Graphics.DrawImage(My.Resources.Red_Spike, 788, 184, 34, 34)

        spike6 = New Rectangle(907, 888, 34, 34)
        e.Graphics.DrawImage(My.Resources.Red_Spike, 907, 888, 34, 34)

        spike7 = New Rectangle(941, 888, 34, 34)
        e.Graphics.DrawImage(My.Resources.Red_Spike, 941, 888, 34, 34)

        spike8 = New Rectangle(975, 888, 34, 34)
        e.Graphics.DrawImage(My.Resources.Red_Spike, 975, 888, 34, 34)

        spike9 = New Rectangle(1009, 888, 34, 34)
        e.Graphics.DrawImage(My.Resources.Red_Spike, 1009, 888, 34, 34)

        'below is creation of lazers

        lazer1 = New Rectangle(240, 601, 341, 10)
        e.Graphics.DrawImage(My.Resources.Red_Lazer, 240, 601, 350, 10)

        'below is creation of door

        Door = New Rectangle(1820, 953, 57, 87)
        e.Graphics.DrawImage(My.Resources.Da_Door, 1820, 953, 57, 87)

        'below is creation of Coob

        e.Graphics.DrawImage(coobImg, coobBounds)

        coobBounds = New Rectangle(coobBounds.X, coobBounds.Y, coobImg.Width, coobImg.Height)

        'below is creation of hearts

        If Heart1 = True Then

            e.Graphics.DrawImage(My.Resources.coobing, New Rectangle(35, 30, 38, 32), New Rectangle(302, 281, 19, 16), GraphicsUnit.Pixel)

        End If

        If Heart2 = True Then

            e.Graphics.DrawImage(My.Resources.coobing, New Rectangle(75, 30, 38, 32), New Rectangle(302, 281, 19, 16), GraphicsUnit.Pixel)

        End If

        If Heart3 = True Then

            e.Graphics.DrawImage(My.Resources.coobing, New Rectangle(115, 30, 38, 32), New Rectangle(302, 281, 19, 16), GraphicsUnit.Pixel)

        End If

        If coobBounds.IntersectsWith(Key) And hasKey = False Then

            hasKey = True

        End If

        If hasKey = True Then

            e.Graphics.DrawImage(My.Resources.Gold_Key, 35, 70, 34, 30)

        End If

    End Sub

    Public Overrides Sub updateScreen()

        'below is colliding with door

        If coobBounds.IntersectsWith(Door) And hasKey = True Then

            frmHomescreen.screenManager.hideScreen(Me)
            frmHomescreen.screenManager.setActiveScreen(frmHomescreen.winscreen)

        End If

        If Heart1 = False And Heart2 = False And Heart3 = False Then

            frmHomescreen.screenManager.hideScreen(Me)
            frmHomescreen.screenManager.setActiveScreen(frmHomescreen.lamescreen)

        End If

        'below is colliding with lasers

        If coobBounds.IntersectsWith(lazer1) Then

            coobBounds.Y = 100
            coobBounds.X = 460

            hasKey = False

            If Heart1 = True And Heart2 = False And Heart3 = False Then

                Heart1 = False

            End If

            If Heart1 = True And Heart2 = True And Heart3 = False Then

                Heart2 = False

            End If

            If Heart1 = True And Heart2 = True And Heart3 = True Then

                Heart3 = False

            End If

        End If

        If coobBounds.IntersectsWith(spike1) Then

            coobBounds.Y = 100
            coobBounds.X = 460

            hasKey = False

            If Heart1 = True And Heart2 = False And Heart3 = False Then

                Heart1 = False

            End If

            If Heart1 = True And Heart2 = True And Heart3 = False Then

                Heart2 = False

            End If

            If Heart1 = True And Heart2 = True And Heart3 = True Then

                Heart3 = False

            End If

        End If

        'if heart 3 is there and you collide then heart 3 is no more


        If coobBounds.IntersectsWith(spike2) Then

            coobBounds.Y = 100
            coobBounds.X = 460

            hasKey = False

            If Heart1 = True And Heart2 = False And Heart3 = False Then

                Heart1 = False

            End If

            If Heart1 = True And Heart2 = True And Heart3 = False Then

                Heart2 = False

            End If

            If Heart1 = True And Heart2 = True And Heart3 = True Then

                Heart3 = False

            End If

        End If


        If coobBounds.IntersectsWith(spike3) Then

            coobBounds.Y = 100
            coobBounds.X = 460

            hasKey = False

            If Heart1 = True And Heart2 = False And Heart3 = False Then

                Heart1 = False

            End If

            If Heart1 = True And Heart2 = True And Heart3 = False Then

                Heart2 = False

            End If

            If Heart1 = True And Heart2 = True And Heart3 = True Then

                Heart3 = False

            End If

        End If

        If coobBounds.IntersectsWith(spike4) Then

            coobBounds.Y = 100
            coobBounds.X = 460

            hasKey = False

            If Heart1 = True And Heart2 = False And Heart3 = False Then

                Heart1 = False

            End If

            If Heart1 = True And Heart2 = True And Heart3 = False Then

                Heart2 = False

            End If

            If Heart1 = True And Heart2 = True And Heart3 = True Then

                Heart3 = False

            End If

        End If

        If coobBounds.IntersectsWith(spike5) Then

            coobBounds.Y = 100
            coobBounds.X = 460

            hasKey = False

            If Heart1 = True And Heart2 = False And Heart3 = False Then

                Heart1 = False

            End If

            If Heart1 = True And Heart2 = True And Heart3 = False Then

                Heart2 = False

            End If

            If Heart1 = True And Heart2 = True And Heart3 = True Then

                Heart3 = False

            End If

        End If

        If coobBounds.IntersectsWith(spike6) Then

            coobBounds.Y = 100
            coobBounds.X = 460

            hasKey = False

            If Heart1 = True And Heart2 = False And Heart3 = False Then

                Heart1 = False

            End If

            If Heart1 = True And Heart2 = True And Heart3 = False Then

                Heart2 = False

            End If

            If Heart1 = True And Heart2 = True And Heart3 = True Then

                Heart3 = False

            End If

        End If

        If coobBounds.IntersectsWith(spike7) Then

            coobBounds.Y = 100
            coobBounds.X = 460

            hasKey = False

            If Heart1 = True And Heart2 = False And Heart3 = False Then

                Heart1 = False

            End If

            If Heart1 = True And Heart2 = True And Heart3 = False Then

                Heart2 = False

            End If

            If Heart1 = True And Heart2 = True And Heart3 = True Then

                Heart3 = False

            End If

        End If

        If coobBounds.IntersectsWith(spike8) Then

            coobBounds.Y = 100
            coobBounds.X = 460

            hasKey = False

            If Heart1 = True And Heart2 = False And Heart3 = False Then

                Heart1 = False

            End If

            If Heart1 = True And Heart2 = True And Heart3 = False Then

                Heart2 = False

            End If

            If Heart1 = True And Heart2 = True And Heart3 = True Then

                Heart3 = False

            End If

        End If

        If coobBounds.IntersectsWith(spike9) Then

            coobBounds.Y = 100
            coobBounds.X = 460

            hasKey = False

            If Heart1 = True And Heart2 = False And Heart3 = False Then

                Heart1 = False

            End If

            If Heart1 = True And Heart2 = True And Heart3 = False Then

                Heart2 = False

            End If

            If Heart1 = True And Heart2 = True And Heart3 = True Then

                Heart3 = False

            End If

        End If

        If k_left = True Then

            coobBounds.X -= 15
            coobImg = My.Resources.CoobCharacterLeft

        End If

        If k_right = True Then

            coobBounds.X += 15
            coobImg = My.Resources.CoobCharacterRight

        End If

        checkCollision()

    End Sub

    Public Sub checkCollision()

        'below is jumping on blocks

        If coobBounds.IntersectsWith(recGround1) Then

            If coobBounds.Y + (coobBounds.Height) >= recGround1.Top Then

                OnGround = True
                timOnGround.Start()
                timGravity.Stop()

            End If

            If coobBounds.X >= recGround1.Right - 20 And k_left = True Then

                coobBounds.X = coobBounds.X + 15
                k_left = False

            ElseIf coobBounds.X > recGround1.Left + coobBounds.Width And coobBounds.X < recGround1.Right - coobBounds.Width And coobBounds.Y > recGround1.Top Then

                coobBounds.Y = recGround1.Bottom + coobBounds.Height + 1
                timJumped.Stop()

            End If

        End If

        If coobBounds.IntersectsWith(recGround2) Then

            If coobBounds.Y + (coobBounds.Height) >= recGround2.Top Then

                OnGround = True
                timOnGround.Start()
                timGravity.Stop()

            End If

            If coobBounds.X >= recGround2.Right - 20 And k_left = True Then

                coobBounds.X = coobBounds.X + 15
                k_left = False

            ElseIf coobBounds.X > recGround2.Left + coobBounds.Width And coobBounds.X < recGround2.Right - coobBounds.Width And coobBounds.Y > recGround2.Top Then

                coobBounds.Y = recGround2.Bottom + coobBounds.Height + 1
                timJumped.Stop()

            End If

            OnGround = True
            timOnGround.Start()
            timGravity.Stop()

        End If

        If coobBounds.IntersectsWith(recGround3) Then

            If coobBounds.Y + (coobBounds.Height) >= recGround3.Top Then

                OnGround = True
                timOnGround.Start()
                timGravity.Stop()

            End If

            If coobBounds.X >= recGround3.Right - 20 And k_left = True Then

                coobBounds.X += 15
                k_left = False

            ElseIf coobBounds.X + coobBounds.Width <= recGround3.Left + 20 And k_right = True Then

                coobBounds.X -= 15
                k_right = False

            ElseIf coobBounds.X > recGround3.Left + coobBounds.Width And coobBounds.X < recGround3.Right - coobBounds.Width And coobBounds.Y > recGround3.Top Then

                coobBounds.Y = recGround3.Bottom + coobBounds.Height + 1
                timJumped.Stop()

            End If

            OnGround = True
            timOnGround.Start()
            timGravity.Stop()

        End If

        If coobBounds.IntersectsWith(recGround4) Then

            If coobBounds.Y + (coobBounds.Height) >= recGround4.Top Then

                OnGround = True
                timOnGround.Start()
                timGravity.Stop()

            End If

            If coobBounds.X >= recGround4.Right - 20 And k_left = True Then

                coobBounds.X = coobBounds.X + 15
                k_left = False

            ElseIf coobBounds.X + coobBounds.Width <= recGround4.Left + 20 And k_right = True Then

                coobBounds.X -= 15
                k_right = False

            ElseIf coobBounds.X > recGround4.Left + coobBounds.Width And coobBounds.X < recGround4.Right - coobBounds.Width And coobBounds.Y > recGround4.Top Then

                coobBounds.Y = recGround4.Bottom + coobBounds.Height + 1
                timJumped.Stop()

            End If

            OnGround = True
            timOnGround.Start()
            timGravity.Stop()

        End If

        If coobBounds.IntersectsWith(recGround5) Then

            If coobBounds.Y + (coobBounds.Height) >= recGround5.Top Then

                OnGround = True
                timOnGround.Start()
                timGravity.Stop()

            End If

            If coobBounds.X >= recGround5.Right - 20 And k_left = True Then

                coobBounds.X = coobBounds.X + 15
                k_left = False

            ElseIf coobBounds.X + coobBounds.Width <= recGround5.Left + 20 And k_right = True Then

                coobBounds.X -= 15
                k_right = False

            ElseIf coobBounds.X > recGround5.Left + coobBounds.Width And coobBounds.X < recGround5.Right - coobBounds.Width And coobBounds.Y > recGround5.Top Then

                coobBounds.Y = recGround5.Bottom + coobBounds.Height + 1
                timJumped.Stop()

            End If

            OnGround = True
            timOnGround.Start()
            timGravity.Stop()

        End If

        If coobBounds.IntersectsWith(recGround6) Then

            If coobBounds.Y + (coobBounds.Height) >= recGround6.Top Then

                OnGround = True
                timOnGround.Start()
                timGravity.Stop()

            End If

            If coobBounds.X >= recGround6.Right - 20 And k_left = True Then

                coobBounds.X = coobBounds.X + 15
                k_left = False

            ElseIf coobBounds.X + coobBounds.Width <= recGround6.Left + 20 And k_right = True Then

                coobBounds.X -= 15
                k_right = False

            ElseIf coobBounds.X > recGround6.Left + coobBounds.Width And coobBounds.X < recGround6.Right - coobBounds.Width And coobBounds.Y > recGround6.Top Then

                coobBounds.Y = recGround6.Bottom + coobBounds.Height + 1
                timJumped.Stop()

            End If

            OnGround = True
            timOnGround.Start()
            timGravity.Stop()

        End If

        If coobBounds.IntersectsWith(recGround7) Then

            If coobBounds.Y + (coobBounds.Height) >= recGround7.Top Then

                OnGround = True
                timOnGround.Start()
                timGravity.Stop()

            End If

            If coobBounds.X >= recGround7.Right - 20 And k_left = True Then

                coobBounds.X = coobBounds.X + 15
                k_left = False

            ElseIf coobBounds.X + coobBounds.Width <= recGround7.Left + 20 And k_right = True Then

                coobBounds.X -= 15
                k_right = False

            ElseIf coobBounds.X > recGround7.Left + coobBounds.Width And coobBounds.X < recGround7.Right - coobBounds.Width And coobBounds.Y > recGround7.Top Then

                coobBounds.Y = recGround7.Bottom + coobBounds.Height + 1
                timJumped.Stop()

            End If

            OnGround = True
            timOnGround.Start()
            timGravity.Stop()

        End If

        If coobBounds.IntersectsWith(recGround8) Then

            If coobBounds.Y + (coobBounds.Height) >= recGround8.Top Then

                OnGround = True
                timOnGround.Start()
                timGravity.Stop()

            End If

            If coobBounds.X >= recGround8.Right - 20 And k_left = True Then

                coobBounds.X = coobBounds.X + 15
                k_left = False

            ElseIf coobBounds.X + coobBounds.Width <= recGround8.Left + 20 And k_right = True Then

                coobBounds.X -= 15
                k_right = False

            ElseIf coobBounds.X > recGround8.Left + coobBounds.Width And coobBounds.X < recGround8.Right - coobBounds.Width And coobBounds.Y > recGround8.Top Then

                coobBounds.Y = recGround8.Bottom + coobBounds.Height + 1
                timJumped.Stop()

            End If

            OnGround = True
            timOnGround.Start()
            timGravity.Stop()

        End If

        If coobBounds.IntersectsWith(recGround9) Then

            If coobBounds.Y + (coobBounds.Height) >= recGround9.Top Then

                OnGround = True
                timOnGround.Start()
                timGravity.Stop()

            End If

            If coobBounds.X >= recGround9.Right - 20 And k_left = True Then

                coobBounds.X = coobBounds.X + 15
                k_left = False

            ElseIf coobBounds.X + coobBounds.Width <= recGround9.Left + 20 And k_right = True Then

                coobBounds.X -= 15
                k_right = False

            ElseIf coobBounds.X > recGround9.Left + coobBounds.Width And coobBounds.X < recGround9.Right - coobBounds.Width And coobBounds.Y > recGround9.Top Then

                coobBounds.Y = recGround9.Bottom + coobBounds.Height + 1
                timJumped.Stop()

            End If

            OnGround = True
            timOnGround.Start()
            timGravity.Stop()

        End If

        If coobBounds.IntersectsWith(recGround10) Then

            If coobBounds.Y + (coobBounds.Height) >= recGround10.Top Then

                OnGround = True
                timOnGround.Start()
                timGravity.Stop()

            End If

            If coobBounds.X >= recGround10.Right - 20 And k_left = True Then

                coobBounds.X = coobBounds.X + 15
                k_left = False

            ElseIf coobBounds.X + coobBounds.Width <= recGround10.Left + 20 And k_right = True Then

                coobBounds.X -= 15
                k_right = False

            ElseIf coobBounds.X > recGround10.Left + coobBounds.Width And coobBounds.X < recGround10.Right - coobBounds.Width And coobBounds.Y > recGround10.Top Then

                coobBounds.Y = recGround10.Bottom + coobBounds.Height + 1
                timJumped.Stop()

            End If

            OnGround = True
            timOnGround.Start()
            timGravity.Stop()

        End If

        If coobBounds.IntersectsWith(recGround11) Then

            If coobBounds.Y + (coobBounds.Height) >= recGround11.Top Then

                OnGround = True
                timOnGround.Start()
                timGravity.Stop()

            End If

            If coobBounds.X >= recGround11.Right - 20 And k_left = True Then

                coobBounds.X = coobBounds.X + 15
                k_left = False

            ElseIf coobBounds.X + coobBounds.Width <= recGround11.Left + 20 And k_right = True Then

                coobBounds.X -= 15
                k_right = False

            ElseIf coobBounds.X > recGround11.Left + coobBounds.Width And coobBounds.X < recGround11.Right - coobBounds.Width And coobBounds.Y > recGround11.Top Then

                coobBounds.Y = recGround11.Bottom + coobBounds.Height + 1
                timJumped.Stop()

            End If

            OnGround = True
            timOnGround.Start()
            timGravity.Stop()

        End If

        If coobBounds.IntersectsWith(recGround12) Then

            If coobBounds.Y + (coobBounds.Height) >= recGround12.Top Then

                OnGround = True
                timOnGround.Start()
                timGravity.Stop()

            End If

            If coobBounds.X >= recGround12.Right - 20 And k_left = True Then

                coobBounds.X = coobBounds.X + 15
                k_left = False

            ElseIf coobBounds.X + coobBounds.Width <= recGround12.Left + 20 And k_right = True Then

                coobBounds.X -= 15
                k_right = False

            ElseIf coobBounds.X > recGround12.Left + coobBounds.Width And coobBounds.X < recGround12.Right - coobBounds.Width And coobBounds.Y > recGround12.Top Then

                coobBounds.Y = recGround12.Bottom + coobBounds.Height + 1
                timJumped.Stop()

            End If

            OnGround = True
            timOnGround.Start()
            timGravity.Stop()

        End If

        If coobBounds.IntersectsWith(recGround13) Then

            If coobBounds.Y + (coobBounds.Height) >= recGround13.Top Then

                OnGround = True
                timOnGround.Start()
                timGravity.Stop()

            End If

            If coobBounds.X >= recGround13.Right - 20 And k_left = True Then

                coobBounds.X = coobBounds.X + 15
                k_left = False

            ElseIf coobBounds.X + coobBounds.Width <= recGround13.Left + 20 And k_right = True Then

                coobBounds.X -= 15
                k_right = False

            ElseIf coobBounds.X > recGround13.Left + coobBounds.Width And coobBounds.X < recGround13.Right - coobBounds.Width And coobBounds.Y > recGround13.Top Then

                coobBounds.Y = recGround13.Bottom + coobBounds.Height + 1
                timJumped.Stop()

            End If

            OnGround = True
            timOnGround.Start()
            timGravity.Stop()

        End If

        If OnGround = False Then

            coobBounds.Y += 20

        End If

        'below is hitting head on blocks

    End Sub

    Private Sub timJumped_Tick(sender As Object, e As EventArgs) Handles timJumped.Tick

        coobBounds.Y -= 40

        jumpTime += 1

        If jumpTime = 12 Then

            jumpTime = 0

            timJumped.Enabled = False

        End If

        If coobBounds.IntersectsWith(recGround1) Then
            timJumped.Enabled = False
            coobBounds.Y = recGround1.Bottom + 1
        End If

        If coobBounds.X = recGround1.Right And coobBounds.IntersectsWith(recGround1) Then
            coobBounds.X = recGround1.Right + 1
        End If

    End Sub

    Private Sub timOnGround_Tick(sender As Object, e As EventArgs) Handles timOnGround.Tick

        If coobBounds.IntersectsWith(recGround1) = False Then

            OnGround = False
            timGravity.Start()
            timOnGround.Stop()

        End If

        If coobBounds.IntersectsWith(recGround2) = False Then

            OnGround = False
            timGravity.Start()
            timOnGround.Stop()

        End If

        If coobBounds.IntersectsWith(recGround3) = False Then

            OnGround = False
            timGravity.Start()
            timOnGround.Stop()

        End If

        If coobBounds.IntersectsWith(recGround4) = False Then

            OnGround = False
            timGravity.Start()
            timOnGround.Stop()

        End If

        If coobBounds.IntersectsWith(recGround5) = False Then

            OnGround = False
            timGravity.Start()
            timOnGround.Stop()

        End If

        If coobBounds.IntersectsWith(recGround6) = False Then

            OnGround = False
            timGravity.Start()
            timOnGround.Stop()

        End If

    End Sub

End Class