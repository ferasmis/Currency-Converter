Public Class Form1
    Const dblPOUNDS As Double = 0.78
    Const dblEUROS As Double = 0.92
    Const dblYEN As Double = 111.22
    Const dblAMOUNT_DOLLARS As Double = 0.0
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click


        'declaring variables
        Dim dblAmountPounds As Double = dblPOUNDS
        Dim dblAmountEuros As Double = dblEUROS
        Dim dblAmountYen As Double = dblYEN
        Dim dblAmountDollars As Double = dblAMOUNT_DOLLARS
        'retrive the amount 
        dblAmountDollars = CDbl(txtAmountDollar.Text)

        'multiplying dollars by the currency rate
        dblAmountPounds = dblAmountDollars * dblAmountPounds
        dblAmountEuros = dblAmountDollars * dblAmountEuros
        dblAmountYen = dblAmountDollars * dblAmountYen

        'dislpay the currecny amount in lables
        lblPounds.Text = dblAmountPounds.ToString("n")
        lblEuros.Text = dblAmountEuros.ToString("n")
        lblYen.Text = dblAmountYen.ToString("n")

    End Sub

    Private Sub picPounds_Click(sender As Object, e As EventArgs) Handles picPounds.Click
        'Declaring variable of the currency rate pounds
        Dim dblAmountDollars As Double = dblAMOUNT_DOLLARS
        Dim dblAmountPounds As Double = dblPOUNDS

        'retrieving the amount 
        dblAmountDollars = CDbl(txtAmountDollar.Text)

        'Multiplying the amount of dollars to the pounds currency rate
        dblAmountPounds = dblAmountDollars * dblAmountPounds

        'displaying the amount of pounds exchanged in the pounds label
        lblPounds.Text = dblAmountPounds.ToString("n")

    End Sub

    Private Sub picEuros_Click(sender As Object, e As EventArgs) Handles picEuros.Click
        ' Declaring variable. Rate of amount of Euros currency
        Dim dblAmountDollars As Double = dblAMOUNT_DOLLARS
        Dim dblAmoundEuros As Double = dblEUROS

        'Retreiveing the amount 
        dblAmountDollars = CDbl(txtAmountDollar.Text)

        'Multiplying the amount of dollars to the Euros rate
        dblAmoundEuros = dblAmountDollars * dblAmoundEuros

        'Displaying the currency change in the label of Euros currency 
        lblEuros.Text = dblAmoundEuros.ToString("n")

    End Sub

    Private Sub picYen_Click(sender As Object, e As EventArgs) Handles picYen.Click

        ' Declaring variable. Rate of amount of Yen currency
        Dim dblAmountDollars As Double = dblAMOUNT_DOLLARS
        Dim dblAmountYen As Double = dblYEN

        'Retreiveing the amount 
        dblAmountDollars = CDbl(txtAmountDollar.Text)

        'Multiplying the amount of dollars to the Yen rate
        dblAmountYen = dblAmountDollars * dblAmountYen

        'Displaying the currency change in the label Yen currency 
        lblYen.Text = dblAmountYen.ToString("n")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clearing all the labels with the amounts
        lblEuros.Text = ""
        lblPounds.Text = ""
        lblYen.Text = ""

        'clearing the texz box for the amount of dollars
        txtAmountDollar.Clear()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'exit the application
        Me.Close()
    End Sub
End Class

