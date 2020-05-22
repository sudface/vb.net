# Arrays
Consider a situation where we need to store five integer numbers. If we use programming's simple variable and data type concepts, then we need five variables of integer data type and the program will be as follows −

    dim number1 As Integer
    dim number2 As Integer
    dim number3 As Integer
    dim number4 As Integer
    dim number5 As Integer
   
    number1 = 10 
    number2 = 20   
    number3 = 30   
    number4 = 40 
    number5 = 50

It was simple, because we had to store just five integer numbers. Now let's assume we have to store 5000 integer numbers. Are we going to use 5000 variables?

To handle such situations, almost all the programming languages provide a concept called array. An array is a data structure, which can store a fixed-size collection of elements of the same data type. An array is used to store a collection of data, but it is often more useful to think of an array as a collection of variables of the same type.
<br><br>
Instead of declaring individual variables, such as number1, number2, ..., number99, you just declare one array variable "number" of integer type and use number(0), number(1), and ..., number(99) to represent individual variables. Here, 0, 1, 2, .....99 are variables, being used to represent individual elements available in the array.
<br><br>
Arrays can also store strings (words), for example,

    dim word_array(6) As String ' When using String Arrays, remember to state the number of items in the array when declaring it (`dim`). In this case, 6 items.
    word_array(0) = "bob"
    word_array(1) = "the"
    word_array(2) = "builder"
    word_array(3) = "can"
    word_array(4) = "we"
    word_array(5) = "fix"
    word_array(6) = "it"
    
This makes it easy to access these words programatically in For loops and such. For example,

    For x = 0 to 6
      word = word_array(x)
      ListBox.Items.Add(word)
    Next
<br><br>
# Random
VB.NET also provides a random number function. We can pair this with Arrays, to pick a random word from an array. For example,

    Dim myRandom As New Random
    Dim i As Integer
    i = myRandom.Next(0,word_array.Length) ' word_array.length returns the number of values in the array
    
    Label1.Text = word_array(i)
Note that we have to make another variable (i) and use that in our array. This is because (myRandom)'s type is not an integer. (i = myRandom) stores a random value as an integer in (i). We can then refer to this for use in our array :)
