    ' This app introduces the &= operator
    ' Any code will be enclosed in hashes #like this#
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim addme = TextBox1.Text
        Label2.Text &= addme
        ' The &= operator appends whatever is after it to the value before the operator.
        ' EG, # Hello &= World # will return # Hello World #
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim addme = TextBox2.Text
        Dim howmany As Integer = TextBox3.Text

        For x = 0 To howmany - 1
            Label6.Text &= addme
        Next
        'Need to do Minus One because 0 is included in the for loop
        'Appends #addme# to #Label6's Text#, #howmany# times
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim addme = TextBox4.Text
        Dim word As String = TextBox5.Text

        For x As Integer = 0 To word.Length - 1
            Label10.Text &= addme
        Next

    End Sub