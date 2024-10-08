Public Class frm_visualizar_pedidos
    Private Sub frm_visualizar_pedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_dados()
    End Sub

    Private Sub dgv_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellContentClick
        If dgv_dados.CurrentRow.Cells(5).Selected = True Then
            If dgv_dados.CurrentRow.Cells(4).Value = "ENTREGUE" Or dgv_dados.CurrentRow.Cells(4).Value = "PENDENTE" Then
                Exit Sub
            Else

                sql = "UPDATE tb_produtos
                SET tb_produtos.QTDE_ESTOQUE -= tb_pedidos.QTDE_PEDIDO, tb_produtos.ENCOMENDAS -= tb_pedidos.QTDE_PEDIDO
                FROM tb_produtos AS tb_produtos
                INNER JOIN tb_pedidos AS tb_pedidos
                ON tb_produtos.NOME_PRODUTO = tb_pedidos.NOME_PRODUTO WHERE tb_pedidos.STATUS = 'DISPONIVEL' AND tb_pedidos.NOME_PRODUTO = '" & dgv_dados.CurrentRow.Cells(2).Value & "';"

                rs = db.Execute(UCase(sql))





                sql = "update tb_pedidos set STATUS = 'ENTREGUE' WHERE ID_PEDIDO = '" & dgv_dados.CurrentRow.Cells(0).Value & "' AND NOME_PRODUTO = '" & dgv_dados.CurrentRow.Cells(2).Value & "'"
                rs = db.Execute(UCase(sql))
                MsgBox("Pedido entregue!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

                carregar_dados()
            End If
        End If
    End Sub

    Sub carregar_dados()
        sql = "select * from tb_pedidos ORDER BY STATUS ASC"
        rs = db.Execute(UCase(sql))

        With dgv_dados
            .Rows.Clear()
            Do While rs.EOF = False

                .Rows.Add(rs.Fields(0).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(8).Value, rs.Fields(4).Value, Nothing)
                rs.MoveNext()
            Loop

            For Each row As DataGridViewRow In .Rows
                If row.Cells("dgv_status").Value = "ENTREGUE" Then
                    row.Cells("dgv_status").Style.BackColor = Color.Green
                    row.Cells("dgv_id").Style.BackColor = Color.Green
                    row.Cells("dgv_nome").Style.BackColor = Color.Green
                    row.Cells("dgv_total").Style.BackColor = Color.Green
                    row.Cells("dgv_cpf").Style.BackColor = Color.Green
                ElseIf row.Cells("dgv_status").Value = "PENDENTE" Then
                    row.Cells("dgv_status").Style.BackColor = Color.Red
                    row.Cells("dgv_id").Style.BackColor = Color.Red
                    row.Cells("dgv_nome").Style.BackColor = Color.Red
                    row.Cells("dgv_total").Style.BackColor = Color.Red
                    row.Cells("dgv_cpf").Style.BackColor = Color.Red
                Else
                    row.Cells("dgv_status").Style.BackColor = Color.Yellow
                    row.Cells("dgv_id").Style.BackColor = Color.Yellow
                    row.Cells("dgv_nome").Style.BackColor = Color.Yellow
                    row.Cells("dgv_total").Style.BackColor = Color.Yellow
                    row.Cells("dgv_cpf").Style.BackColor = Color.Yellow
                End If
            Next
        End With


    End Sub
End Class