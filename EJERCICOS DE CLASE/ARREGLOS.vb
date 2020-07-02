Public Class MENU
    Private Sub MENU_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hideSubMenu()
    End Sub
    Private Sub hideSubMenu()
        Panelsubmenu.Visible = False
    End Sub
    Private Sub showsubmenu(submenu As Panel)
        If submenu.Visible = False Then
            hideSubMenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If
    End Sub

    Private Sub btnmenu_Click(sender As Object, e As EventArgs) Handles btnmenu.Click
        showsubmenu(Panelsubmenu)
    End Sub

    Private Sub btnejerciciosclase_Click(sender As Object, e As EventArgs) Handles btnejercicios1.Click
        openchildren(ARREGLOSCLASE)
        hideSubMenu()
    End Sub


    Private formularioactual As Form = Nothing
    Private Sub openchildren(childform As Form)
        ' If formularioactual IsNot Nothing Then formularioactual.Close()
        ' formularioactual = childform
        ' childform.TopLevel = False
        ' childform.FormBorderStyle = FormBorderStyle.None
        ' Panelformulario.Controls.Add(childform)
        ' Panelformulario.Tag = childform
        ' If Panelformulario.Controls.Count > 0 Then
        '  Me.Panelformulario.Controls.RemoveAt(0)
        '  End If
        Dim frm As Form = TryCast(childform, Form)
        frm.TopLevel = False
        frm.Dock = DockStyle.Fill
        Me.Panelformulario.Controls.Add(frm)
        Me.Panelformulario.Tag = frm
        childform.BringToFront()
        childform.Show()
    End Sub
    Private Sub TimerOcultarMenu_Tick(sender As Object, e As EventArgs) Handles TimerOcultarMenu.Tick
        If Panelsubmenu.Width <= 45 Then
            Me.TimerOcultarMenu.Enabled = False
        Else
            Me.Panelsubmenu.Width = Panelsubmenu.Width - 20
        End If
    End Sub

    Private Sub TimerMostrar_Tick(sender As Object, e As EventArgs) Handles TimerMostrar.Tick
        If Panelsubmenu.Width >= 165 Then
            Me.TimerMostrar.Enabled = False
        Else
            Me.Panelsubmenu.Width = Panelsubmenu.Width + 20
        End If
    End Sub

    Private Sub btnejercicio2_Click(sender As Object, e As EventArgs) Handles btnejercicio2.Click
        openchildren(frmEstudiante)
        hideSubMenu()
    End Sub
End Class