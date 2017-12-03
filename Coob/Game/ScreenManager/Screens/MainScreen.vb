Public Class MainScreen
    Inherits Screen

    Dim WithEvents btnPlay As Button
    Dim WithEvents btnInstruction As Button
    Dim WithEvents btnSettings As Button
    Dim WithEvents btnExit As Button

    Dim WithEvents timHomescreen As Timer

    Dim WithEvents lblTitle As Label

    Public Sub New()

        timHomescreen = New Timer
        timHomescreen.Interval = 1000
        timHomescreen.Start()

        lblTitle = New Label
        lblTitle.Text = "Coob!"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Impact", 100, FontStyle.Regular, GraphicsUnit.Pixel)
        lblTitle.Size = New Size(300, 100)

        lblTitle.Left = ClientRectangle.Width / 2 - lblTitle.Width / 2
        lblTitle.Top = ClientRectangle.Height / 2 - lblTitle.Height - 200
        Controls.Add(lblTitle)

        'below is creation of btnPlay

        btnPlay = New Button

        btnPlay.FlatStyle = FlatStyle.Flat

        btnPlay.Height = 68
        btnPlay.Width = 325

        btnPlay.Text = "Play"
        btnPlay.Font = New Font("Impact", 50, FontStyle.Regular, GraphicsUnit.Pixel)

        btnPlay.Left = ClientRectangle.Width / 2 - btnPlay.Width / 2
        btnPlay.Top = ClientRectangle.Height / 2 - btnPlay.Height - 90

        Controls.Add(btnPlay)

        'below is cration of btnInstructions

        btnInstruction = New Button

        btnInstruction.FlatStyle = FlatStyle.Flat

        btnInstruction.Height = 68
        btnInstruction.Width = 325

        btnInstruction.Text = "Instructions"
        btnInstruction.Font = New Font("Impact", 50, FontStyle.Regular, GraphicsUnit.Pixel)

        btnInstruction.Left = ClientRectangle.Width / 2 - btnInstruction.Width / 2
        btnInstruction.Top = ClientRectangle.Height / 2 - btnInstruction.Height

        Controls.Add(btnInstruction)

        'below is creation of btnSettings

        btnSettings = New Button

        btnSettings.FlatStyle = FlatStyle.Flat

        btnSettings.Height = 68
        btnSettings.Width = 325

        btnSettings.Text = "Settings"
        btnSettings.Font = New Font("Impact", 50, FontStyle.Regular, GraphicsUnit.Pixel)

        btnSettings.Left = ClientRectangle.Width / 2 - btnSettings.Width / 2
        btnSettings.Top = ClientRectangle.Height / 2 - btnSettings.Height + 90

        Controls.Add(btnSettings)

        'below is creation of btnExit

        btnExit = New Button

        btnExit.FlatStyle = FlatStyle.Flat

        btnExit.Height = 68
        btnExit.Width = 325

        btnExit.Text = "Exit"
        btnExit.Font = New Font("Impact", 50, FontStyle.Regular, GraphicsUnit.Pixel)

        btnExit.Left = ClientRectangle.Width / 2 - btnExit.Width / 2
        btnExit.Top = ClientRectangle.Height / 2 - btnExit.Height + 180

        Controls.Add(btnExit)

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Application.Exit()

    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        frmHomescreen.screenManager.setActiveScreen(frmHomescreen.gameScreen)
    End Sub

    Private Sub btnInstruction_Click(sender As Object, e As EventArgs) Handles btnInstruction.Click
        frmHomescreen.screenManager.setActiveScreen(frmHomescreen.instructionScreen)
    End Sub

    Public Overrides Sub hideScreen()
        
    End Sub

    Public Overrides Sub keyDownHandler(sender As Object, e As KeyEventArgs)
    
    End Sub

    Public Overrides Sub keyUpHandler(sender As Object, e As KeyEventArgs)

    End Sub

    Public Overrides Sub Screen_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Public Overrides Sub showScreen()

    End Sub

    Public Overrides Sub updateScreen()

        Me.Invalidate()

    End Sub

End Class
