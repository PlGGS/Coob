Public Class GameScreen
    Inherits Screen

    Dim level1 As Levels
    Dim activelevel As Integer = 1

    Public Sub New()

        level1 = New Levels

    End Sub

    Public Overrides Sub keyDownHandler(sender As Object, e As KeyEventArgs)

        Select Case activelevel

            Case 1

                level1.keyDownHandler(sender, e)

            Case 2

        End Select

    End Sub

    Public Overrides Sub keyUpHandler(sender As Object, e As KeyEventArgs)

        Select Case activelevel

            Case 1

                level1.keyUpHandler(sender, e)

            Case 2

        End Select
    End Sub

    Public Overrides Sub Screen_Paint(sender As Object, e As PaintEventArgs)
        Select Case activelevel

            Case 1

                level1.Screen_Paint(sender, e)

            Case 2

        End Select

    End Sub

    Public Overrides Sub showScreen()

    End Sub

    Public Overrides Sub hideScreen()

    End Sub

    Public Overrides Sub updateScreen()

        Select Case activelevel

            Case 1
                level1.updateScreen()
            Case 2

        End Select

        Me.Invalidate()

    End Sub

End Class
