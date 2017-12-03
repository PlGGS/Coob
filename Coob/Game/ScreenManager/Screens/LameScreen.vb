Public Class LameScreen
    Inherits Screen
    Dim lbl As New Label
    Dim WithEvents but As Button

    Public Sub New()

        Me.BackColor = Color.Red

        but = New Button
        but.FlatStyle = FlatStyle.Flat
        but.Height = 75
        but.Width = 200
        but.Text = "Main Menu"
        but.Font = New Font("Impact", 30, FontStyle.Regular, GraphicsUnit.Pixel)
        but.Left = ClientRectangle.Width / 2 - but.Width / 2
        but.Top = ClientRectangle.Height / 2 - but.Height + 90
        Controls.Add(but)

        lbl.Text = "YOU LOSE!"
        lbl.TextAlign = ContentAlignment.MiddleCenter
        lbl.AutoSize = True
        lbl.Font = New Font("Impact", 100, FontStyle.Regular, GraphicsUnit.Pixel)
        lbl.Size = New Size(300, 100)

        lbl.Left = ClientRectangle.Width / 2 - lbl.Width / 2
        lbl.Top = ClientRectangle.Height / 2 - lbl.Height - 200
        Controls.Add(lbl)

    End Sub

    Private Sub but_MouseHover(sender As Object, e As EventArgs) Handles but.MouseHover
        frmHomescreen.screenManager.setActiveScreen(frmHomescreen.mainScreen)
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

    End Sub
End Class
