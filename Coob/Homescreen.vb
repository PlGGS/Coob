Public Class frmHomescreen

    Public _WIDTH As Integer = SystemInformation.PrimaryMonitorSize.Width
    Public _HEIGHT As Integer = SystemInformation.PrimaryMonitorSize.Height

    Private Sub frmCoob_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblTitle.Font = New Font("Showcard Gothic", 75, GraphicsUnit.Pixel, GraphicsUnit.Pixel)

        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None

        Me.Width = _WIDTH
        Me.Height = _HEIGHT

        Select Case lblTitle.Text

            Case lblTitle.Text = "Coob!"

            Case lblTitle.Text = "Coob..."

            Case lblTitle.Text = "Cooob"

        End Select

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
            lblTitle.Font = New Font("Times New Roman", 75, FontStyle.Regular, GraphicsUnit.Pixel)

        End If

        If titleNumber = 2 Then

            Title = "Coob..."

        End If

        If titleNumber = 3 Then

            Title = "Cooob"

        End If

        If titleNumber = 4 Then

            Title = "C008!"

        End If

        If titleNumber = 5 Then

            Title = "</coob>"

        End If

        'lblTitle.Font = New Font("Mjnbk", 75)

        lastNumber = titleNumber
        lblTitle.Text = Title

    End Sub
End Class
