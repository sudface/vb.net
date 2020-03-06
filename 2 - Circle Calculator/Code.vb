' This app makes use of RADIO BUTTONS
' Radio Buttons only allow one of a few options to be selected
' Radio Buttons have a functionality, where you can check if a button has been clicked,
' That you can check with, IF RadioButton1.Checked = [True or False] THEN etc.
' TextBox1 is the input for Circumference Calculator, and
' TextBox2 is the input for the Area Calculator.


    Private Sub ComputeCircum_Click(sender As Object, e As EventArgs) Handles ComputeCircum.Click
		'PRESETVALUE is used as a mediator in the function 2piR, 
		'combining the 2 and Radius, or just being the Diameter for further calculation
		'It is then multiplied by PI, and stored in the variable ANSWERVAR
        Dim circumvalue As Double
        Dim presetvalue As Double
        Dim answervar As Double
        Dim pi As Double
        pi = System.Math.PI

        circumvalue = TextBox1.Text
        If RadiusC.Checked = True And DiameterC.Checked = False Then presetvalue = circumvalue * 2

        If RadiusC.Checked = False And DiameterC.Checked = True Then presetvalue = circumvalue

        answervar = presetvalue * pi

        LabelAnsCirc.Text = answervar

    End Sub

    Private Sub ComputeArea_Click(sender As Object, e As EventArgs) Handles ComputeArea.Click
		Dim areavalue As Double
        Dim r2value As Double
        Dim answervar2 As Double
        Dim mediatorvalue As Double
        Dim pi As Double
        pi = System.Math.PI

        areavalue = TextBox2.Text

        If RadiusA.Checked = True And DiameterA.Checked = False Then mediatorvalue = areavalue

        If RadiusA.Checked = False And DiameterA.Checked = True Then mediatorvalue = areavalue / 2

        r2value = mediatorvalue * mediatorvalue

        answervar2 = r2value * pi

        LabelAnsArea.Text = answervar2

    End Sub
