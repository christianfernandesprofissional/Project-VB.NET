Imports System.Runtime.InteropServices

Public Class frm_fazer_pedido
    Private Sub btn_ver_carrinho_Click(sender As Object, e As EventArgs) Handles btn_ver_carrinho.Click

        total = 0
        sql = "select * from tb_carrinho "
        rs = db.Execute(UCase(sql))


        Do While rs.EOF = False
            total += rs.Fields(8).Value
            rs.MoveNext()
        Loop


        frm_carrinho.ShowDialog()
    End Sub

    Private Sub dgv_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellContentClick

        dgv_dados.CurrentRow.Cells(4).Selected = True
        txt_id.Text = dgv_dados.CurrentRow.Cells(0).Value
        txt_nome_produto.Text = dgv_dados.CurrentRow.Cells(1).Value
        txt_preco.Text = dgv_dados.CurrentRow.Cells(2).Value

    End Sub

    Private Sub frm_fazer_pedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_tipo.Items.Add("ID")
        cmb_tipo.Items.Add("NOME")
        num = 1
        carregar_dados()

        sql = "select * from tb_pedidos order by ID_PEDIDO desc"
        rs = db.Execute(UCase(sql))

        If rs.EOF = False Then
            num = rs.Fields(0).Value + 1
        End If

    End Sub

    Private Sub btn_adicionar_carrinho_Click(sender As Object, e As EventArgs) Handles btn_adicionar_carrinho.Click

        sql = "select * from tb_clientes where CPF_CLIENTE = '" & txt_cpf_cliente.Text.Replace(",", ".") & "'"
        rs = db.Execute(sql)

        If rs.EOF = True Then
            MsgBox("CPF não cadastrado!", MsgBoxStyle.OkOnly, "ATENÇÃO")
        ElseIf txt_nome_produto.Text = "" Or txt_qtde_estoque.Text = "" Then
            MsgBox("Selecione o Produto!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        Else
            sql = "select * from  tb_carrinho where NOME_PRODUTO = '" & txt_nome_produto.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                sql = "update tb_carrinho set QTDE_PEDIDO = '" & txt_qtde_estoque.Text & "' where NOME_PRODUTO = '" & txt_nome_produto.Text & "'"
                rs = db.Execute(UCase(sql))


                sql = "select * from tb_carrinho"
                rs = db.Execute(sql)
                qtde = txt_preco.Text
                mult = txt_qtde_estoque.Text
                total = qtde * mult

                sql = "update tb_carrinho set TOTAL_ITEM = '" & total.ToString(".") & "' WHERE nome_produto = '" & txt_nome_produto.Text & "';"
                rs = db.Execute(sql)
                MsgBox("Produto adicionado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                txt_qtde_estoque.Text = ""

            Else
                qtde = txt_preco.Text
                mult = txt_qtde_estoque.Text
                total = qtde * mult
                sql = "select * from tb_produtos where NOME_PRODUTO = '" & txt_nome_produto.Text & "'"
                rs = db.Execute(UCase(sql))

                If rs.Fields(3).Value = 0 Or txt_qtde_estoque.Text > rs.Fields(3).Value Then
                    resp = "pendente"
                Else
                    resp = "entregue"
                End If


                sql = "insert into tb_carrinho (ID_PEDIDO,CPF_FUNCIONARIO, CPF_CLIENTE, NOME_PRODUTO, STATUS, DATA_COMPRA, QTDE_PEDIDO, PRECO_VENDA, TOTAL_ITEM) values ('" & num & "', '" & cpf_func & "',  '" & txt_cpf_cliente.Text.Replace(",", ".") & "', '" & txt_nome_produto.Text & "' , '" & resp & "', '" & Date.Now.ToShortDateString & "', '" & txt_qtde_estoque.Text & "', '" & txt_preco.Text.Replace(",", ".") & "',  '" & total.ToString(".") & "');"
                rs = db.Execute(UCase(sql))
                    MsgBox("Produto adicionado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
                    txt_qtde_estoque.Text = ""
                End If
            End If

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
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, Nothing, Nothing, Nothing)
                    rs.MoveNext()
                Loop
            End With
        End If
    End Sub



    Sub carregar_dados()
        sql = "select * from tb_PRODUTOS order by ID_PRODUTO asc"
        rs = db.Execute(UCase(sql))

        With dgv_dados
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, Nothing, Nothing, Nothing)
                rs.MoveNext()
            Loop
        End With
    End Sub



End Class