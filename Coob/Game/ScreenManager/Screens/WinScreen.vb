Public Class WinScreen
    Inherits Screen

    Dim lbl As New Label

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
        Me.BackColor = Color.Green

        lbl = New Label
        lbl.Text = "YOU WIN!"
        lbl.TextAlign = ContentAlignment.MiddleCenter
        lbl.AutoSize = True
        lbl.Font = New Font("Impact", 100, FontStyle.Regular, GraphicsUnit.Pixel)
        lbl.Size = New Size(300, 100)

        lbl.Left = ClientRectangle.Width / 2 - lbl.Width / 2
        lbl.Top = ClientRectangle.Height / 2 - lbl.Height - 200
        Controls.Add(lbl)

    End Sub
End Class
