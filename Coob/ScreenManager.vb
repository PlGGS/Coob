Public Class ScreenManager
    Private game As Form

    Public activeScreen
    Public screens As List(Of Screen)

    Public Sub New(ByRef game As Form)
        activeScreen = Nothing
        screens = New List(Of Screen)
        Me.game = game
    End Sub

    Public Sub addScreen(ByVal screen As Screen)
        screens.Add(screen)
        game.Controls.Add(screen)
        AddHandler game.KeyDown, AddressOf screen.keyDownHandler
        AddHandler game.KeyUp, AddressOf screen.keyUpHandler
    End Sub

    Public Sub removeScreen(ByVal screen As Screen)
        screens.Remove(screen)
        game.Controls.Remove(screen)
    End Sub

    Public Sub hideScreen(ByVal screen As Screen)
        screen.hideScreen()
        screen.state = ScreenState.Hidden
        screen.SendToBack()
    End Sub

    Public Sub showScreen(ByVal screen As Screen)
        screen.showScreen()
        screen.state = ScreenState.Visible
        screen.BringToFront()
    End Sub

    Public Sub setActiveScreen(ByVal screen As Screen)
        activeScreen = screen
        screen.BringToFront()
        screen.state = ScreenState.Visible
        game.ActiveControl = screen
    End Sub

    Public Sub updateScreens()
        For Each Screen In screens
            If Screen.state = ScreenState.Closed Then
                removeScreen(Screen)
                Exit For
            End If
            If Screen.state = ScreenState.Hidden Then
                Screen.Visible = False
            End If
            If Screen.state = ScreenState.Visible Then
                Screen.Visible = True
            End If
            Screen.updateScreen()
        Next
    End Sub
End Class