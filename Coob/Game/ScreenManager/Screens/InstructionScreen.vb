Public Class InstructionScreen
    Inherits Screen

    Dim WithEvents lblInstructions As Label
    Dim WithEvents btnBack As Button

    Public Sub New()

        'below is creation of lblInstructions

        lblInstructions = New Label
        lblInstructions.Text = "Coob is a platformer all about" & vbNewLine & "eating pigs."
        lblInstructions.TextAlign = ContentAlignment.MiddleCenter
        lblInstructions.AutoSize = True
        lblInstructions.Font = New Font("Impact", 100, FontStyle.Regular, GraphicsUnit.Pixel)
        lblInstructions.Size = New Size(300, 100)

        lblInstructions.Left = ClientRectangle.Width / 2 - lblInstructions.Width * 2
        lblInstructions.Top = ClientRectangle.Height / 2 - lblInstructions.Height - 200

        Controls.Add(lblInstructions)

        'below is creation of btnBack

        btnBack = New Button

        btnBack.FlatStyle = FlatStyle.Flat

        btnBack.Size = New Size(325, 68)

        btnBack.Text = "Back"
        btnBack.Font = New Font("Impact", 50, FontStyle.Regular, GraphicsUnit.Pixel)
        btnBack.TextAlign = ContentAlignment.MiddleCenter

        btnBack.Left = ClientRectangle.Width / 2 - btnBack.Width / 2
        btnBack.Top = ClientRectangle.Height / 2 - btnBack.Height + 300

        Controls.Add(btnBack)

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

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        frmHomescreen.screenManager.setActiveScreen(frmHomescreen.mainScreen)

    End Sub

End Class