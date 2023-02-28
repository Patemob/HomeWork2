
Public Class frmPayRoll

    Const cdecFica As Decimal = 0.0765D
    Const cdecFed As Decimal = 0.22D
    Const cdecState As Decimal = 0.04D
    Private Sub lblPayCheck_Click(sender As Object, e As EventArgs) Handles lblPayCheck.Click

    End Sub

    Private Sub lblGross_Click(sender As Object, e As EventArgs) Handles lblGross.Click

    End Sub

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim strIncome As String
        Dim decIncome As Decimal
        Dim decFica As Decimal
        Dim decFederal As Decimal
        Dim decState As Decimal
        Dim decNet As Decimal



        strIncome = txtGrossPay.Text
        decIncome = Convert.ToInt32(strIncome)

        decFica = decIncome * cdecFica
        decFederal = decIncome * cdecFed
        decState = decIncome * cdecState


        lblFicaTotal.Text = decFica.ToString("C")
        lblFedTotal.Text = decFederal.ToString("C")
        lblStateTotal.Text = decState.ToString("C")


        decNet = decIncome - decFica - decFederal - decState
        lblIncomeTotal.Text = decNet.ToString("C")



    End Sub

    Private Sub lblFica_Click(sender As Object, e As EventArgs) Handles lblFica.Click

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtGrossPay.Clear()
        lblIncomeTotal.Text = ""
        txtGrossPay.Focus()
        lblFicaTotal.Text = ""
        lblStateTotal.Text = ""
        lblFedTotal.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub frmPayRoll_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblFedTotal.Text = ""
        lblFicaTotal.Text = ""
        lblStateTotal.Text = ""
        lblIncomeTotal.Text = ""
        txtGrossPay.Focus()
    End Sub
End Class
