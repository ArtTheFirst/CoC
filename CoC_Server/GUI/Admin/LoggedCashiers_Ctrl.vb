Public Class LoggedCashiers_Ctrl

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        l_User.Text = String.Concat("signed in as ", usr)
    End Sub

End Class