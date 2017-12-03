Public Class Level1
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
    Dim cooblocation As Point

    Dim OnGround As Boolean

    Dim WithEvents timJumped As Timer
    Dim WithEvents timOnGround As Timer
    Dim WithEvents timGravity As Timer

    Public Sub New()

        timGravity = New Timer

        timGravity.Interval = 1
        timGravity.Enabled = False

        timJumped = New Timer

        'hai

        timJumped.Interval = 1

        timJumped.Enabled = False

        timOnGround = New Timer

        timOnGround.Interval = 1

        timOnGround.Enabled = False

        cooblocation = New Point(460, 100)

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

        'below is drawing background

        e.Graphics.DrawImage(My.Resources.backgrounds, New Rectangle(0, 0, Me.Width, Me.Height), New Rectangle(0, 0, 230, 62), GraphicsUnit.Pixel)

        'below is "drawing" coobBounds

        coobBounds = New Rectangle(cooblocation.X, cooblocation.Y, coobImg.Width, coobImg.Height)

        'below is drawing hearts

        e.Graphics.DrawImage(My.Resources.coobing, New Rectangle(35, 30, 38, 32), New Rectangle(302, 281, 19, 16), GraphicsUnit.Pixel)

        e.Graphics.DrawImage(My.Resources.coobing, New Rectangle(75, 30, 38, 32), New Rectangle(302, 281, 19, 16), GraphicsUnit.Pixel)

        e.Graphics.DrawImage(My.Resources.coobing, New Rectangle(115, 30, 38, 32), New Rectangle(302, 281, 19, 16), GraphicsUnit.Pixel)

        e.Graphics.DrawImage(coobImg, cooblocation.X, cooblocation.Y, 74, 64)

        'below is creation of blocks n' stoof

        recGround1 = New Rectangle(100, 500, 1000, 200)
        e.Graphics.DrawRectangle(Pens.DarkSlateBlue, recGround1)

        recGround2 = New Rectangle(100, 300, 100, 200)
        e.Graphics.DrawRectangle(Pens.DarkSlateBlue, recGround2)

        recGround3 = New Rectangle(200, 300, 100, 200)
        e.Graphics.DrawRectangle(Pens.DarkSlateBlue, recGround3)

        recGround4 = New Rectangle(300, 300, 100, 200)
        e.Graphics.DrawRectangle(Pens.DarkSlateBlue, recGround4)

        recGround5 = New Rectangle(400, 300, 100, 200)
        e.Graphics.DrawRectangle(Pens.DarkSlateBlue, recGround5)

        recGround6 = New Rectangle(500, 300, 100, 200)
        e.Graphics.DrawRectangle(Pens.DarkSlateBlue, recGround6)

    End Sub

    Public Overrides Sub updateScreen()

        If k_left = True Then

            cooblocation.X -= 12.5
            coobImg = My.Resources.CoobCharacterLeft

        End If

        If k_right = True Then

            cooblocation.X += 12.5
            coobImg = My.Resources.CoobCharacterRight

        End If

    End Sub

    Private Sub timGravity_Tick(sender As Object, e As EventArgs) Handles timGravity.Tick

        If coobBounds.IntersectsWith(recGround6) Then

            k_left = False
            cooblocation.X += 5

        End If

        'below is jumping on blocks

        If coobBounds.IntersectsWith(recGround1) Then

            OnGround = True
            timOnGround.Start()
            timGravity.Stop()

        End If

        If coobBounds.IntersectsWith(recGround2) Then

            OnGround = True
            timOnGround.Start()
            timGravity.Stop()

        End If

        If coobBounds.IntersectsWith(recGround3) Then

            OnGround = True
            timOnGround.Start()
            timGravity.Stop()

        End If

        If coobBounds.IntersectsWith(recGround4) Then

            OnGround = True
            timOnGround.Start()
            timGravity.Stop()

        End If

        If coobBounds.IntersectsWith(recGround5) Then

            OnGround = True
            timOnGround.Start()
            timGravity.Stop()

        End If

        If coobBounds.IntersectsWith(recGround6) Then

            OnGround = True
            timOnGround.Start()
            timGravity.Stop()

        End If

        If OnGround = False Then

            cooblocation.Y += 10

        End If

    End Sub

    Private Sub timJumped_Tick(sender As Object, e As EventArgs) Handles timJumped.Tick

        Static jumpTime As Single

        cooblocation.Y -= 20

        jumpTime += 1

        If jumpTime = 10 Then

            jumpTime = 0

            timJumped.Enabled = False

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