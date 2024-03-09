Public Class grade_form
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub evaluate_btn_Click(sender As Object, e As EventArgs) Handles evaluate_btn.Click
        Dim math As Integer
        Dim science As Integer
        Dim english As Integer
        Dim Grade As Double

        math = Val(math_txtbox.Text)
        science = Val(science_txtbox.Text)
        english = Val(english_txtbox.Text)


        Grade = (math + science + english)
        Grade = Grade / 3

        If Grade >= 90 Then
            MsgBox("A+")
        ElseIf Grade >= 80 Then
            MsgBox("B+")
        ElseIf Grade >= 75 Then
            MsgBox("C+")
        Else
            MsgBox("failed")
        End If




    End Sub
End Class
