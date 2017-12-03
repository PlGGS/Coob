Public Class frmHomescreen

    Dim WithEvents btnPlay As Button
    Dim WithEvents btnInstruction As Button
    Dim WithEvents btnExit As Button

    Public _WIDTH As Integer = SystemInformation.PrimaryMonitorSize.Width
    Public _HEIGHT As Integer = SystemInformation.PrimaryMonitorSize.Height

    Private Sub frmCoob_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblTitle.Font = New Font("Showcard Gothic", 100, GraphicsUnit.Pixel, GraphicsUnit.Pixel)

        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None

        Me.Width = _WIDTH
        Me.Height = _HEIGHT

        lblTitle.Left = ClientRectangle.Width / 2 - lblTitle.Width / 2
        lblTitle.Top = ClientRectangle.Height / 2 - lblTitle.Height - 200

        'below is creation of btnPlay

        btnPlay = New Button

        btnPlay.FlatStyle = FlatStyle.Flat

        btnPlay.Height = 70
        btnPlay.Width = 500

        btnPlay.Text = "Play"
        btnPlay.Font = New Font("Halo", 70, FontStyle.Regular, GraphicsUnit.Pixel)

        btnPlay.Left = ClientRectangle.Width / 2 - btnPlay.Width / 2
        btnPlay.Top = ClientRectangle.Height / 2 - btnPlay.Height - 90

        Controls.Add(btnPlay)

        'below is cration of btnInstructions

        btnInstruction = New Button

        btnInstruction.FlatStyle = FlatStyle.Flat

        btnInstruction.Height = 70
        btnInstruction.Width = 500

        btnInstruction.Text = "Instructions"
        btnInstruction.Font = New Font("Halo", 70, FontStyle.Regular, GraphicsUnit.Pixel)

        btnInstruction.Left = ClientRectangle.Width / 2 - btnInstruction.Width / 2
        btnInstruction.Top = ClientRectangle.Height / 2 - btnInstruction.Height

        Controls.Add(btnInstruction)

        'below is creation of btnExit

        btnExit = New Button

        btnExit.FlatStyle = FlatStyle.Flat

        btnExit.Height = 70
        btnExit.Width = 500

        btnExit.Text = "Exit"
        btnExit.Font = New Font("Halo", 70, FontStyle.Regular, GraphicsUnit.Pixel)

        btnExit.Left = ClientRectangle.Width / 2 - btnExit.Width / 2
        btnExit.Top = ClientRectangle.Height / 2 - btnExit.Height + 90

        Controls.Add(btnExit)

    End Sub

    Dim lastNumber As Single = -1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles timHomescreen.Tick

        Dim titleNumber As Single = Int(Rnd() * 5) + 1
        Dim Title As String

        While titleNumber = lastNumber
            titleNumber = Int(Rnd() * 5) + 1
        End While

        If titleNumber = 1 Then

            Title = "Coob!"
            lblTitle.Font = New Font("Times New Roman", 100, FontStyle.Regular, GraphicsUnit.Pixel)

        End If

        If titleNumber = 2 Then

            Title = "Coob..."
            lblTitle.Font = New Font("Snap ITC", 100, FontStyle.Regular, GraphicsUnit.Pixel)

        End If

        If titleNumber = 3 Then

            Title = "Cooob"
            lblTitle.Font = New Font("Wide Latin", 100, FontStyle.Regular, GraphicsUnit.Pixel)

        End If

        If titleNumber = 4 Then

            Title = "C008!"
            lblTitle.Font = New Font("Comic Sans MS", 100, FontStyle.Regular, GraphicsUnit.Pixel)

        End If

        If titleNumber = 5 Then

            Title = "</coob>"
            lblTitle.Font = New Font("Rockwell", 100, FontStyle.Regular, GraphicsUnit.Pixel)

        End If

        'lblTitle.Font = New Font("Mjnbk", 100)

        lastNumber = titleNumber
        lblTitle.Text = Title

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Application.Exit()

    End Sub
End Class
