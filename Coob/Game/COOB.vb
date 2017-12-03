Public Class frmHomescreen

    Public screenManager As ScreenManager
    Public instructionScreen As InstructionScreen
    Public mainScreen As MainScreen
    Public gameScreen As GameScreen
    Public lamescreen As LameScreen
    Public winscreen As WinScreen
    Public WithEvents gameTick As Timer

    Public _WIDTH As Integer = SystemInformation.PrimaryMonitorSize.Width
    Public _HEIGHT As Integer = SystemInformation.PrimaryMonitorSize.Height

    Private Sub frmCoob_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BringToFront()
        screenManager = New ScreenManager(Me)
        instructionScreen = New InstructionScreen()
        mainScreen = New MainScreen()
        gameScreen = New GameScreen()
        lamescreen = New LameScreen()
        winscreen = New WinScreen
        screenManager.addScreen(mainScreen)
        screenManager.addScreen(instructionScreen)
        screenManager.addScreen(gameScreen)
        screenManager.addScreen(lamescreen)
        screenManager.addScreen(winscreen)
        gameTick = New Timer()
        gameTick.Enabled = True
        gameTick.Interval = 1

        screenManager.setActiveScreen(mainScreen)

        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None

        Me.Width = _WIDTH
        Me.Height = _HEIGHT

    End Sub
    Public Sub gameLoop() Handles gameTick.Tick

        'calls all screens updates
        screenManager.updateScreens()

    End Sub

End Class
