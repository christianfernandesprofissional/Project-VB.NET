Public Class frm_cadastro_produtos
    Private Sub frm_cadastro_produtos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_tipo.Items.Add("ID")
        cmb_tipo.Items.Add("NOME")
        carregar_dados()
    End Sub

    Private Sub btn_gravar_Click(sender As Object, e As EventArgs) Handles btn_gravar.Click
        If txt_nome_produto.Text = "" Or txt_preco.Text = "" Or txt_qtde_estoque.Text = "" Then

            MsgBox("Preencha todos os campos!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO!")
            Exit Sub
        End If

        If txt_id.Text = "" Then
            sql = "select * from tb_produtos where NOME_PRODUTO = '" & txt_nome_produto.Text & "'"
            rs = db.Execute(UCase(sql))

            If rs.EOF = False Then
                MsgBox("NOME JÁ CADASTRADO!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO!")
                Exit Sub
            End If
        End If


        sql = "select * from tb_produtos where ID_PRODUTO = '" & txt_id.Text & "'"
        rs = db.Execute(UCase(sql))

        If rs.EOF = False Then



            sql = "update tb_produtos set NOME_PRODUTO = '" & txt_nome_produto.Text & "', " &
                                              "PRECO_ATUAL = '" & txt_preco.Text.Replace(",", ".") & "', " &
                                              "QTDE_ESTOQUE = '" & txt_qtde_estoque.Text & "' where ID_PRODUTO = '" & txt_id.Text & "'"
            rs = db.Execute(UCase(sql))

            MsgBox("Produto atualizado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")


            sql = "select * from tb_produtos where ID_PRODUTO = '" & txt_id.Text & "'"
            rs = db.Execute(UCase(sql))

            If rs.Fields(3).Value >= rs.Fields(4).Value Then
                sql = "update tb_pedidos set STATUS = 'DISPONIVEL' where NOME_PRODUTO = '" & txt_nome_produto.Text & "' AND STATUS = 'PENDENTE';"
                rs = db.Execute(sql)
            End If


        Else
            sql = "insert into tb_produtos(NOME_PRODUTO, PRECO_ATUAL, QTDE_ESTOQUE, ENCOMENDAS) values ('" & txt_nome_produto.Text & "', '" & txt_preco.Text.Replace(",", ".") & "', '" & txt_qtde_estoque.Text & "', '0')"
            rs = db.Execute(UCase(sql))

            MsgBox("Produto cadastrado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End If
        limpar_dados()
        carregar_dados()
    End Sub


    Private Sub dgv_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellContentClick
        If dgv_dados.CurrentRow.Cells(5).Selected = True Then

            sql = "select * from tb_produtos where ID_PRODUTO = '" & dgv_dados.CurrentRow.Cells(0).Value & "'"
            rs = db.Execute(sql)

            txt_id.Text = rs.Fields(0).Value
            txt_nome_produto.Text = rs.Fields(1).Value
            txt_preco.Text = rs.Fields(2).Value
            txt_qtde_estoque.Text = rs.Fields(3).Value




        ElseIf dgv_dados.CurrentRow.Cells(6).Selected = True Then
            resp = MsgBox("Deseja mesmo excluir o produto?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "ATENÇÃO")
            If resp = vbYes Then
                sql = "delete from tb_produtos where ID_PRODUTO='" & dgv_dados.CurrentRow.Cells(0).Value & "'"
                rs = db.Execute(sql)
                MsgBox("Produto excluido com sucesso!")
                limpar_dados()

            End If
            carregar_dados()
        End If
    End Sub


    Sub limpar_dados()
        txt_qtde_estoque.Text = ""
        txt_nome_produto.Text = ""
        txt_preco.Text = ""
        txt_id.Text = ""
        txt_nome_produto.Focus()
    End Sub

    Sub carregar_dados()
        sql = "select * from tb_PRODUTOS order by ID_PRODUTO asc"
        rs = db.Execute(UCase(sql))

        With dgv_dados
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, Nothing, Nothing)
                rs.MoveNext()
            Loop
        End With
    End Sub

    Private Sub txt_busca_TextChanged(sender As Object, e As EventArgs) Handles txt_busca.TextChanged
        If cmb_tipo.Text = "" Then
            Exit Sub
        Else
            sql = "select * from tb_produtos where " & cmb_tipo.Text & "_PRODUTO like '" & txt_busca.Text & "%';"
            rs = db.Execute(UCase(sql))

            With dgv_dados
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, Nothing, Nothing)
                    rs.MoveNext()
                Loop
            End With
        End If
    End Sub


End Class