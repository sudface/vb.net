'-------!IMPORTANT!-------
'Read the What is an Array file first
'-------!IMPORTANT!-------

Dim word_array() As String
Private Sub ButtonSend_Click(sender As Object, e As EventArgs) Handles ButtonSend.Click
	'This is the "Send them to an array" button

	Dim del() As String = {Environment.NewLine}
	'sets "del" as newline so that ".split" can break every newline into a different item in the array


	If TextBoxInput.Text <> "" Then
		'Enlarge form from (209,489) to see hidden stuff
		Me.Size = New Size(659, 489)

		'set word_array to contents of TextBox1
		word_array = TextBoxInput.Text.Split(del, StringSplitOptions.RemoveEmptyEntries)
	Else
	End If

End Sub

Private Sub ButtonRWord_Click(sender As Object, e As EventArgs) Handles ButtonRWord.Click
	'give random word
	Dim r As New Random 'Random Number generator to pick word
	Dim i As Integer
	i = r.Next(0, word_array.Count)
	'r.Next gives a random number between 0, and how many items there are in word_array
	LabelOutput.Text = word_array(i)
End Sub

Private Sub Button3Word_Click(sender As Object, e As EventArgs) Handles Button3Word.Click
	'retrieve third word
	LabelOutput.Text = word_array(2) 'Needs to be two because arrays start from zero
End Sub

Private Sub Button2Word_Click(sender As Object, e As EventArgs) Handles Button2Word.Click
	'retrieve second word
	LabelOutput.Text = word_array(1) 'Needs to be one because arrays start from zero 
End Sub

Private Sub Button1Word_Click(sender As Object, e As EventArgs) Handles Button1Word.Click
	'Retrieve first word
	LabelOutput.Text = word_array(0) 'Needs to be zero because arrays start from zero
End Sub

Private Sub ButtonDefaultFile_Click(sender As Object, e As EventArgs) Handles ButtonDefaultFile.Click
	Dim del() As String = {Environment.NewLine}
	'sets DEL as newline so that split can break every newline into a different item in the array
	'load from wordlist in My Resources

word_array = {"apple","pear","orange","apricot","peach","plum","banana","mango","strawberry","watermelon"}

	Me.Size = New Size(659, 489)
	'Enlarge form from (209,489) too see hidden buttons
End Sub
