Public Class frm_menu_admin

    Private Sub btn_cadastro_funcionario_Click(sender As Object, e As EventArgs) Handles btn_cadastro_funcionario.Click

        While Me.center_panel.Controls.Count > 0
            Me.center_panel.Controls(0).Dispose()

        End While

        Dim nf As New frm_cadastro With {.TopMost = False, .AutoSize = True}
        nf.TopLevel = False
        nf.Dock = DockStyle.Fill
        Me.center_panel.Controls.Add(nf)
        nf.Show()


    End Sub

    Private Sub menu_img_Click(sender As Object, e As EventArgs) Handles menu_img.Click
        If left_panel.Width > 50 Then
            Timer1.Enabled = True
        Else
            Timer2.Enabled = True
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If left_panel.Width > 50 Then
            left_panel.Width -= 5
        Else
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If left_panel.Width < 149 Then
            left_panel.Width += 5
        Else
            Timer2.Enabled = False

        End If
    End Sub



    Private Sub left_panel_SizeChanged(sender As Object, e As EventArgs) Handles left_panel.SizeChanged
        If left_panel.Width < 100 Then
            btn_cadastro_funcionario.Text = ""



        Else

            btn_cadastro_funcionario.Text = "Funcionários"
            menu_img.Dock = DockStyle.Right
        End If
    End Sub



    Private Sub frm_menu_admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        btn_pedidos.Enabled = False
        btn_pedir.Enabled = False
        btn_cadastrar_cliente.Enabled = False

        btn_cadastrar_produto.Enabled = False
        btn_cadastro_funcionario.Enabled = False

        btn_logoff.Enabled = False


    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        frm_login.ShowDialog()
    End Sub

    Private Sub btn_logoff_Click(sender As Object, e As EventArgs) Handles btn_logoff.Click

        btn_pedidos.Enabled = False
        btn_pedir.Enabled = False
        btn_cadastrar_cliente.Enabled = False

        btn_cadastrar_produto.Enabled = False
        btn_cadastro_funcionario.Enabled = False

        btn_logoff.Enabled = False
        btn_login.Enabled = True
        While Me.center_panel.Controls.Count > 0
            Me.center_panel.Controls(0).Dispose()

        End While

    End Sub

    Private Sub btn_cadastrar_produto_Click(sender As Object, e As EventArgs) Handles btn_cadastrar_produto.Click
        While Me.center_panel.Controls.Count > 0
            Me.center_panel.Controls(0).Dispose()

        End While

        Dim nf As New frm_cadastro_produtos With {.TopMost = False, .AutoSize = True}
        nf.TopLevel = False
        nf.Dock = DockStyle.Fill
        Me.center_panel.Controls.Add(nf)
        nf.Show()

    End Sub

    Private Sub btn_cadastrar_cliente_Click(sender As Object, e As EventArgs) Handles btn_cadastrar_cliente.Click
        While Me.center_panel.Controls.Count > 0
            Me.center_panel.Controls(0).Dispose()

        End While

        Dim nf As New frm_cadastro_clientes With {.TopMost = False, .AutoSize = True}
        nf.TopLevel = False
        nf.Dock = DockStyle.Fill
        Me.center_panel.Controls.Add(nf)
        nf.Show()
    End Sub

    Private Sub btn_pedir_Click(sender As Object, e As EventArgs) Handles btn_pedir.Click
        While Me.center_panel.Controls.Count > 0
            Me.center_panel.Controls(0).Dispose()

        End While

        Dim nf As New frm_fazer_pedido With {.TopMost = False, .AutoSize = True}
        nf.TopLevel = False
        nf.Dock = DockStyle.Fill
        Me.center_panel.Controls.Add(nf)
        nf.Show()
    End Sub

    Private Sub btn_pedidos_Click(sender As Object, e As EventArgs) Handles btn_pedidos.Click
        While Me.center_panel.Controls.Count > 0
            Me.center_panel.Controls(0).Dispose()

        End While

        Dim nf As New frm_visualizar_pedidos With {.TopMost = False, .AutoSize = True}
        nf.TopLevel = False
        nf.Dock = DockStyle.Fill
        Me.center_panel.Controls.Add(nf)
        nf.Show()
    End Sub


End Class