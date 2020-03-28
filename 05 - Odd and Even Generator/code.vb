' This app introduces the MOD function.
' MOD is short for the mathematical function modulus,
' which is basically just the remainder after a divide operation.
' For example, 17 Mod 4 will return 1, as the remainder after 7 is 
' divided by 4 is 1 (16 + 1 = 17).
' -------------
' Otherwise, it is just the same FOR and IF loop.
' -------------
' Listbox1 contains all the Odd numbers
' Listbox2 contains the Even numbers.


Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
	Dim lowerlimit As Integer
	Dim upperlimit As Integer
	
	ListBox1.Items.Clear()
	ListBox2.Items.Clear()

	lowerlimit = TextBox1.Text
	upperlimit = TextBox2.Text

	For x = lowerlimit To upperlimit
		If x Mod 2 = 0 Then ListBox2.Items.Add(x) 
			' If the value between lower and upper limits has a 
			' remainder of 0 when divided by 2, add to listbox2
			
		If x Mod 2 = 1 Then ListBox1.Items.Add(x)
	Next
End Sub