' This app makes use of IF/THEN/ELSE loops.
' It has 3 input textboxes (TextBox1, 2 and 3)
' And stores them to variables (value1, 2 and 3)
' The IF loop checks if value1 is bigger than value2 AND value3.
' If so, then stores the RESULT as value1
' And so on, so forth
	
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim value1 As Double = TextBox1.Text ' Dim can also have a shortcut as shown here
        Dim value2 As Double = TextBox2.Text
        Dim value3 As Double = TextBox3.Text
        Dim result

        If value1 > value2 And value1 > value3 Then
            result = value1
        ElseIf value2 > value1 And value2 > value3 Then
            result = value2
        Else
            result = value3
        End If

        LabelOutput.Text = "The largest number from " & value1 & ", " & value2 & " and " & value3 & " is: " & result
		' The 
		' &
		' symbol joins multiple strings or variables together, and outputs them as one.
		' As is used here, it joins a few words, followed by the respective values
		' along with some commas and spaces.
    End Sub
