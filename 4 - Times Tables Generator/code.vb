' This app introduces LISTBOXES.
' Listboxes can show multiple values one after another.
' They can be added with ListBox1.Items.Add("add whatever here")
' And be cleared with Listbox1.Items.Clear()
' ------------------------
' This app also introduces FOR LOOPS.
' For loops function while a certain condition is true
' Which in most cases is an incremental number.
' For x = 1 to 20, the for loop will run 20 times,
' making x every value between 1 and 20
' x can then be referred to within the for loop as the number, 
' producing the backbone of our timetable generator.
' The NEXT word at the end of the for loop tells it to repeat
' the loop how many ever times is required until the condition
' is satisfied, and proceed to the next command once complete
' ------------------------
' This App contains 2 Textboxes, 1 for the base number
' And one for the number to generate timestables UP To
' Count is the "x" used in the for loop
' userno is the base number, and usercount is the UP TO number

Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
	Dim userno As Integer
	Dim result As Integer
	Dim count As Integer
	Dim usercount As Integer

	usercount = TextBox2.Text

	userno = TextBox1.Text

	ListBox1.Items.Clear() ' Clear the listbox everytime before running

	For count = 1 To usercount
		result = userno * count
		ListBox1.Items.Add(userno & " * " & count & " = " & result)
		' Once again, string concatenation (the & symbol) is used to add to the listbox
	Next
	
	' In more complex programs, more code will be here, waiting to be run
	' once the for loop has been succesfully completed.
End Sub
