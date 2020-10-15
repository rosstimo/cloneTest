'Luis Torres
'RCET0265
'Fall 2020
'Roll of the Dice 
'https://github.com/LuisTorres0419/RollDiceListBox.git

Public Class DiceForm

    'soeahytasnrytrfty

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        DisplayListBox.Items.Clear()
    End Sub

    Private Sub RollButton_Click(sender As Object, e As EventArgs) Handles RollButton.Click

        Randomize()

        Dim randomNumber As Integer
        Dim lable, line1, line2, dash As String
        Dim data(10) As Integer

        DisplayListBox.Items.Add("                                                                     
Roll of the Dice")

        For i = 1 To 1000
            randomNumber = CInt(getRandomNumber(1, 6))
            data(randomNumber - 2) += 1
        Next



        For i = 2 To 12
            line1 = line1 & String.Format("{0,11}", i) & "|"
        Next

        DisplayListBox.Items.Add(line1)
        dash = (StrDup(177, "-"))
        DisplayListBox.Items.Add(dash)


        For i = 0 To 10
            line2 = line2 & String.Format("{0,10}", data(i)) & "|"
        Next

        DisplayListBox.Items.Add(line2)
        DisplayListBox.Items.Add(dash)
        DisplayListBox.Items.Add("")
        DisplayListBox.Items.Add("")

    End Sub

    Function getRandomNumber(ByVal minimum As Integer, ByVal maximum As Integer) As Integer
        Dim value1, value2 As Single
        Dim amount As Integer

        Do

            value1 = (maximum * Rnd()) + 0.5
            value2 = (maximum * Rnd()) + 0.5

        Loop While value1 < minimum - 0.5 Or value1 > maximum + 0.5 Or
 value2 < minimum - 0.5 Or value2 > maximum + 0.5

        amount = CInt(value1) + CInt(value2)

        Return amount
    End Function

End Class
