Public Enum ScreenState

    Visible
    Hidden
    Closed

End Enum

Public MustInherit Class Screen

    Inherits Panel

    Public state As ScreenState = ScreenState.Hidden

    Public Sub New()

        Me.DoubleBuffered = True

        Me.Size = New Size(frmHomescreen._WIDTH, frmHomescreen._HEIGHT)

    End Sub

    Public MustOverride Sub Screen_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
    Public MustOverride Sub keyUpHandler(ByVal sender As Object, ByVal e As KeyEventArgs)
    Public MustOverride Sub keyDownHandler(ByVal sender As Object, ByVal e As KeyEventArgs)
    Public MustOverride Sub updateScreen()
    Public MustOverride Sub hideScreen()
    Public MustOverride Sub showScreen()
End Class