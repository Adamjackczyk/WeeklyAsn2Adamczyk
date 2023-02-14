' Program Name: Farm Burger Specials 

Public Class frmBurger
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub pic1_Click(sender As Object, e As EventArgs) Handles picBeef.Click

    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        btnBeef.Enabled = False
        btnVeggie.Enabled = False
        btnSelect.Enabled = False
        btnExit.Enabled = True
        lblChoose.Visible = False
        lblEnjoy.Visible = True


    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btnBeef.Click
        picBeef.Visible = True
        picVeggie.Visible = False
        'btnBeef.Enabled = True  'enables button 
        btnSelect.Enabled = True

    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btnVeggie.Click

        picVeggie.Visible = True
        picBeef.Visible = False
        'btnVeggie.Enabled = True
        btnSelect.Enabled = True

    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        btnExit.Enabled = True

        Close()

    End Sub

    Private Sub lbl3_Click(sender As Object, e As EventArgs) Handles lblEnjoy.Click

        lblEnjoy.Visible = False

    End Sub
End Class
