Imports Microsoft.VisualBasic.FileIO

Public Class frm_carrinho
    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        frm_fazer_pedido.carregar_dados()
        Me.Close()
    End Sub

    Private Sub dgv_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados_carrinho.CellContentClick
        If dgv_dados_carrinho.CurrentRow.Cells(5).Selected = True Then
            resp = MsgBox("Deseja excluir item do carrinho?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "AVISO!")
            If resp = vbYes Then
                sql = "delete from tb_carrinho where NOME_PRODUTO = '" & dgv_dados_carrinho.CurrentRow.Cells(1).Value & "'"
                rs = db.Execute(UCase(sql))
                carregar_dados()
            End If

        End If
    End Sub

    Private Sub frm_carrinho_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_dados()

        txt_total.Text = total.ToString("C")

    End Sub

    Sub carregar_dados()

        sql = "select * from tb_carrinho "
        rs = db.Execute(UCase(sql))

        With dgv_dados_carrinho
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value, rs.Fields(3).Value, rs.Fields(7).Value, rs.Fields(6).Value, rs.Fields(8).Value, Nothing)
                rs.MoveNext()
            Loop
        End With

    End Sub

    Private Sub btn_finalizar_pedido_Click(sender As Object, e As EventArgs) Handles btn_finalizar_pedido.Click

        If dgv_dados_carrinho.RowCount <> 0 Then
            sql = "select * from tb_carrinho where STATUS = 'PENDENTE'"

            rs = db.Execute(sql)

            If rs.EOF = False Then
                sql = "UPDATE tb_produtos
                        SET tb_produtos.ENCOMENDAS += tb_carrinho.QTDE_PEDIDO
                        FROM tb_produtos AS tb_produtos
                        INNER JOIN tb_carrinho AS tb_carrinho
                        ON tb_produtos.NOME_PRODUTO = tb_carrinho.NOME_PRODUTO WHERE tb_produtos.QTDE_ESTOQUE = 0;"

                rs = db.Execute(sql)

            End If


            sql = "select * from tb_carrinho where STATUS = 'ENTREGUE'"

            rs = db.Execute(sql)

            If rs.EOF = False Then
                sql = "UPDATE tb_produtos
                SET tb_produtos.QTDE_ESTOQUE -= tb_carrinho.QTDE_PEDIDO
                FROM tb_produtos AS tb_produtos
                INNER JOIN tb_carrinho AS tb_carrinho
                ON tb_produtos.NOME_PRODUTO = tb_carrinho.NOME_PRODUTO WHERE tb_carrinho.STATUS = 'ENTREGUE';"

                rs = db.Execute(sql)
            End If


            sql = "insert into tb_pedidos(ID_PEDIDO,CPF_FUNCIONARIO, CPF_CLIENTE, NOME_PRODUTO, STATUS, DATA_COMPRA, QTDE_PEDIDO, PRECO_VENDA, TOTAL_ITEM) 
        select ID_PEDIDO,CPF_FUNCIONARIO, CPF_CLIENTE, NOME_PRODUTO, STATUS, DATA_COMPRA, QTDE_PEDIDO, PRECO_VENDA, TOTAL_ITEM from tb_carrinho"
                rs = db.Execute(sql)

                sql = "delete from tb_carrinho;"
                rs = db.Execute(sql)
                MsgBox("Pedido feito com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")

                carregar_dados()
                txt_total.Text = "R$0,00"
                frm_fazer_pedido.carregar_dados()

            Else
                MsgBox("Sem produtos no carrinho!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End If


    End Sub
End Class
