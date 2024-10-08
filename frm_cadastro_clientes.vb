Public Class frm_cadastro_clientes
    Private Sub frm_cadastro_clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_tipo.Items.Add("CPF")
        cmb_tipo.Items.Add("NOME")
        carregar_dados()
    End Sub

    Private Sub btn_gravar_Click(sender As Object, e As EventArgs) Handles btn_gravar.Click

        If txt_cpf.Text = "" Or txt_nome.Text = "" Or txt_telefone.Text = "" Or txt_data_nasc.Text = "" Or txt_email.Text = "" Or txt_endereco.Text = "" Then

            MsgBox("Preencha todos os campos!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO!")
            Exit Sub
        End If

        sql = "select*from tb_clientes where CPF_CLIENTE= '" & txt_cpf.Text & "'"
        rs = db.Execute(UCase(sql))

        If rs.EOF = False Then
            sql = "update tb_clientes set CPF_CLIENTE = '" & txt_cpf.Text & "'," &
                                         "NOME_CLIENTE = '" & txt_nome.Text & "', " &
                                         "EMAIL = '" & txt_email.Text & "', " &
                                         "TELEFONE = '" & txt_telefone.Text & "', " &
                                         "DATA_NASC = '" & txt_data_nasc.Text & "', " &
                                         "ENDERECO = '" & txt_endereco.Text & "' where CPF_CLIENTE = '" & txt_cpf.Text & "'"
            rs = db.Execute(UCase(sql))
            MsgBox("Dados atualizados!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO!")

        Else
            sql = "insert into tb_clientes (CPF_CLIENTE, NOME_CLIENTE, EMAIL, TELEFONE, DATA_NASC, ENDERECO, QTDE_PEDIDOS) values
                        ('" & txt_cpf.Text & "', '" & txt_nome.Text & "', '" & txt_email.Text & "', '" & txt_telefone.Text & "', '" & txt_data_nasc.Text & "','" & txt_endereco.Text & "', '0')"

            rs = db.Execute(UCase(sql))
            MsgBox("Cliente cadastrado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO!")

        End If

        carregar_dados()
        limpar_dados()
    End Sub


    Sub limpar_dados()
        txt_cpf.Text = ""
        txt_telefone.Text = ""
        txt_email.Text = ""
        txt_endereco.Text = ""
        txt_data_nasc.Text = ""
        txt_nome.Text = ""
        qt_pedidos.Text = ""
        txt_cpf.Focus()
    End Sub

    Sub carregar_dados()
        sql = "select * from tb_clientes order by NOME_CLIENTE asc"
        rs = db.Execute(UCase(sql))

        With dgv_dados
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(1).Value, rs.Fields(0).Value, rs.Fields(3).Value, rs.Fields(2).Value, rs.Fields(4).Value, Nothing, Nothing)
                rs.MoveNext()
            Loop
        End With
    End Sub

    Private Sub dgv_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellContentClick
        If dgv_dados.CurrentRow.Cells(5).Selected = True Then

            sql = "select * from tb_clientes where CPF_CLIENTE = '" & dgv_dados.CurrentRow.Cells(1).Value & "'"
            rs = db.Execute(sql)

            txt_cpf.Text = rs.Fields(0).Value
            txt_nome.Text = rs.Fields(1).Value
            txt_email.Text = rs.Fields(2).Value
            txt_telefone.Text = rs.Fields(3).Value
            txt_data_nasc.Text = rs.Fields(4).Value
            txt_endereco.Text = rs.Fields(5).Value
            qt_pedidos.Text = rs.Fields(6).Value



        ElseIf dgv_dados.CurrentRow.Cells(6).Selected = True Then
            resp = MsgBox("Deseja mesmo excluir os dados do cliente?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "ATENÇÃO")
            If resp = vbYes Then
                sql = "delete from tb_clientes where CPF_CLIENTE='" & dgv_dados.CurrentRow.Cells(1).Value & "'"
                rs = db.Execute(sql)
                MsgBox("Usuário excluido com sucesso!")
                limpar_dados()

            End If
            carregar_dados()
        End If
    End Sub

    Private Sub txt_busca_TextChanged(sender As Object, e As EventArgs) Handles txt_busca.TextChanged
        If cmb_tipo.Text = "" Then
            Exit Sub
        Else
            sql = "select * from tb_clientes where " & cmb_tipo.Text & "_CLIENTE like '" & txt_busca.Text & "%';"
            rs = db.Execute(UCase(sql))

            With dgv_dados
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(1).Value, rs.Fields(0).Value, rs.Fields(3).Value, rs.Fields(2).Value, rs.Fields(4).Value, Nothing, Nothing)
                    rs.MoveNext()
                Loop
            End With
        End If
    End Sub
End Class