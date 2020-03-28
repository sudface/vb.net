'This app introduces Select Case


Dim damage As Integer = 0

Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

	'the variable "damage" goes up everytime the button is clicked
	damage += 1

	Select Case damage
		'If damage = 1 then Label2.Visible = true
		Case 1
			Label2.Visible = True
		'If damage = 2 then Label3.Visible = true
		Case 2
			Label3.Visible = True
		'etc.
		Case 3
			Label4.Visible = True
		Case 4
			Label5.Visible = True
		Case 5
			Label6.Visible = True
		Case 6
			Label7.Visible = True
		Case 7
		'If damage = 7 then Game Over
			Label8.Visible = True
			LabelOutcome.Text = "All things are shown"
			Button1.Enabled = False
			Button2.Visible = True
	End Select

End Sub

Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
	'Button2 is the reset button, which when clicked will disappear, and re-enable the damage button
	Button2.visible = False
	Button1.Enabled = True
	LabelOutcome.Text = ""
	'Refer to Lesson 7 for more on "For Each"
	For Each lbl In Panel1.Controls.OfType(Of Label)
		lbl.Visible = False
	Next
	Label1.Visible = True
	damage = 0
End Sub
