[//]: # (If you are reading this, then it means that you have downloaded this whole course-like thingy)
[//]: # (This file may not render properly when you open it, heck, if you have managed to open it, kudos!)
[//]: # (To view the file with all the formatting and stuff, head back online to the link below:)
[//]: # (https://github.com/sudface/vb.net/blob/master/10%20-%20Arrays%20and%20Random%20Numbers/README.md)
[//]: # (Cheers and Happy Coding!)


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

It was simple, because we had to store just five integer numbers. Now let's assume we have to store 5000 integer numbers. Are we going to use 5000 variables and reference them one by one?

To handle such situations, almost all the programming languages provide a concept called "array". An array is a data structure, which can store a fixed-size collection of elements of the same data type. An array is used to store a collection of data, but it is useful to think of an array as a collection of variables of the same type, all relating to a similar thing.
<br><br>
Instead of declaring individual variables, such as number1, number2, ..., number99, you can just declare one array variable "number" of integer type and use number(0), number(1), and ..., number(99) to represent individual variables. We have to use number(0) to refer to the first value, number(1) for the second and so on, because that's how computers think. Remember that!

Here are variables, represented as individual elements available in an array. Like so,

    dim number() As Integer = {135,521,352,235,155,34,1513,473}
    
    'Note: calling number(5) would return the 6th value in the array (remember, computers think from zero), which will be "34"

Arrays can also store strings (words), for example,
    
    dim word_array() As String = {"bob","the","builder","can","we","fix","it"}
    
    'Note: calling word_array(3) would return the 4th value in the array (remember, zero), which will be "can"
    
Why use arrays, you may ask. What's the gain?

Arrays make it easy to access these words programatically in For loops and such. For example,

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
