
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            lblResult.Text = String.Empty
        End If
    End Sub

    Protected Sub btnCheck_Click(sender As Object, e As EventArgs)
        Dim number As Integer
        If Integer.TryParse(txtInput.Text, number) AndAlso number >= 0 Then
            If IsPalindrome(number) Then
                lblResult.Text = "It's a palindrome!"
            Else
                lblResult.Text = "It is not a palindrome."
            End If
        Else
            lblResult.Text = "Please enter a positive integer."
        End If
    End Sub

    Private Function IsPalindrome(number As Integer) As Boolean
        Dim str As String = $"{number}"
        Dim reversed As New String(str.Reverse().ToArray())
        Return str = reversed
    End Function
End Class
