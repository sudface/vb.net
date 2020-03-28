'This app introduces Panels (View the actual app design)
'And For Each (see below)

Private Sub ButtonDisable_Click(sender As Object, e As EventArgs) Handles ButtonDisable.Click
	For Each btn As Button In Panel1.Controls.OfType(Of Button)()
		btn.Enabled = False
	Next
End Sub

Private Sub ButtonEnable_Click(sender As Object, e As EventArgs) Handles ButtonEnable.Click
	For Each btn As Button In Panel1.Controls.OfType(Of Button)()
		btn.Enabled = True
	Next
End Sub

Private Sub ButtonHello_Click(sender As Object, e As EventArgs) Handles ButtonHello.Click
	For Each btn As Button In Panel1.Controls.OfType(Of Button)()
		btn.Text = "HELLO"
	Next
End Sub