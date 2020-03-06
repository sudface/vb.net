' This app has 2 textboxes:
' TextBox1 for the first number
' And TextBox2 for the second number
' It then has 4 buttons:
' ButtonAdd, ButtonSubtract, ButtonMultiply, and ButtonDivide
' When a Variable is "Dim"d as an INTEGER, it only supports whole numbers
' Whereas on the other hand, the type DOUBLE supports decimals.

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        Dim firstuserno As Double 
        Dim seconduserno As Double
        Dim resultvar As Double

        firstuserno = TextBox1.Text
        seconduserno = TextBox2.Text

        resultvar = firstuserno + seconduserno

        LabelAns.Text = resultvar
    End Sub

    Private Sub ButtonSubtract_Click(sender As Object, e As EventArgs) Handles ButtonSubtract.Click
        Dim firstuserno As Double
        Dim seconduserno As Double
        Dim resultvar As Double
        firstuserno = TextBox1.Text
        seconduserno = TextBox2.Text

        resultvar = firstuserno - seconduserno

        LabelAns.Text = resultvar

    End Sub

    Private Sub ButtonMultiply_Click(sender As Object, e As EventArgs) Handles ButtonMultiply.Click
        Dim firstuserno As Double
        Dim seconduserno As Double
        Dim resultvar As Double
        firstuserno = TextBox1.Text
        seconduserno = TextBox2.Text

        resultvar = firstuserno * seconduserno

        LabelAns.Text = resultvar
    End Sub

    Private Sub ButtonDivide_Click(sender As Object, e As EventArgs) Handles ButtonDivide.Click
        Dim firstuserno As Double
        Dim seconduserno As Double
        Dim resultvar As Double
        firstuserno = TextBox1.Text
        seconduserno = TextBox2.Text

        resultvar = firstuserno / seconduserno

        LabelAns.Text = resultvar
    End Sub