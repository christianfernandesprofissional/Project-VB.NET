Imports System.Diagnostics.Eventing.Reader

Public Class frm_cadastro

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If txt_cpf.Text = "" Or txt_cargo.Text = "" Or txt_email.Text = "" Or txt_nome.Text = "" Or txt_login.Text = "" Or txt_senha.Text = "" Or cmb_data_nasc.Text = "" Or txt_endereco.Text = "" Then
            MsgBox("Preencha todos os campos!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO!")
            Exit Sub
        End If
        sql = "select * from tb_funcionarios where CPF_FUNCIONARIO = '" & txt_cpf.Text & "'"
        rs = db.Execute(sql)

        If rs.EOF = False Then
            sql = "update tb_funcionarios set NOME_FUNCIONARIO = '" & txt_nome.Text & "', " &
                                             "CPF_FUNCIONARIO = '" & txt_cpf.Text & "', " &
                                             "CARGO = '" & txt_cargo.Text & "', " &
                                             "DATA_NASC = '" & cmb_data_nasc.Text & "', " &
                                             "USUARIO = '" & txt_login.Text & "', " &
                                             "SENHA = '" & txt_senha.Text & "', " &
                                             "EMAIL = '" & txt_email.Text & "', " &
                                             "ENDERECO = '" & txt_endereco.Text & "', " &
                                             "DATA_LOGIN = '" & Date.Now.ToShortDateString & "', " &
                                             "STATUS = '" & txt_status.Text & "' where CPF_FUNCIONARIO= '" & txt_cpf.Text & "'"

            db.Execute(UCase(sql))
            limpar_dados()
            carregar_dados()
        Else
            sql = "insert into tb_funcionarios (NOME_FUNCIONARIO, CPF_FUNCIONARIO, CARGO,DATA_NASC,USUARIO,SENHA,EMAIL,ENDERECO,DATA_LOGIN, STATUS) values
                ('" & txt_nome.Text & "','" & txt_cpf.Text & "','" & txt_cargo.Text & "','" & cmb_data_nasc.Text & "','" & txt_login.Text & "', " &
                "'" & txt_senha.Text & "','" & txt_email.Text & "','" & txt_endereco.Text & "','" & DateAndTime.Now.ToShortDateString & "', 'ATIVADO')"

            rs = db.Execute(UCase(sql))
            MsgBox("Dados Salvos com sucesso!!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ATENÇÃO")
            limpar_dados()
            carregar_dados()

        End If


    End Sub

    Private Sub dgv_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellContentClick

        If dgv_dados.CurrentRow.Cells(5).Selected = True Then

            sql = "select * from tb_funcionarios where CPF_FUNCIONARIO = '" & dgv_dados.CurrentRow.Cells(3).Value & "'"
            rs = db.Execute(sql)

            txt_nome.Text = rs.Fields(1).Value
            txt_cargo.Text = rs.Fields(3).Value
            txt_email.Text = rs.Fields(7).Value
            txt_endereco.Text = rs.Fields(8).Value
            cmb_data_nasc.Text = rs.Fields(4).Value
            txt_login.Text = rs.Fields(5).Value
            txt_senha.Text = rs.Fields(6).Value
            txt_cpf.Text = rs.Fields(2).Value
            txt_status.Text = rs.Fields(10).Value
            txt_ultimo_login.Text = rs.Fields(9).Value



        ElseIf dgv_dados.CurrentRow.Cells(6).Selected = True Then
            resp = MsgBox("Deseja mesmo excluir esse usuário?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "ATENÇÃO")
            If resp = vbYes Then
                sql = "delete from tb_funcionarios where ID_FUNCIONARIO='" & dgv_dados.CurrentRow.Cells(0).Value & "'"
                rs = db.Execute(sql)
                MsgBox("Usuário excluido com sucesso!")
                carregar_dados()

            End If
            carregar_dados()


        End If
    End Sub

    Private Sub frm_cadastro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_dados()
        cmb_tipo.Items.Add("ID")
        cmb_tipo.Items.Add("CPF")
        cmb_tipo.Items.Add("NOME")
    End Sub


    Private Sub txt_busca_TextChanged(sender As Object, e As EventArgs) Handles txt_busca.TextChanged
        If cmb_tipo.Text = "" Then
            Exit Sub
        Else
            sql = "select * from tb_funcionarios where " & cmb_tipo.Text & "_FUNCIONARIO like '" & txt_busca.Text & "%'"
            rs = db.Execute(sql)

            With dgv_dados
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(5).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, Nothing, Nothing, Nothing, rs.Fields(9).Value)
                    rs.MoveNext()
                Loop
            End With
        End If
    End Sub


    Sub carregar_dados()
        sql = "select * from tb_funcionarios order by id_funcionario asc"
        rs = db.Execute(UCase(sql))

        With dgv_dados
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value, rs.Fields(5).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, Nothing, Nothing, Nothing, rs.Fields(10).Value)
                rs.MoveNext()
            Loop
        End With
    End Sub

    Sub limpar_dados()
        txt_cpf.Text = ""
        txt_cargo.Text = ""
        txt_email.Text = ""
        txt_endereco.Text = ""
        cmb_data_nasc.Text = ""
        txt_login.Text = ""
        txt_senha.Text = ""
        txt_nome.Text = ""
        txt_ultimo_login.Text = ""
        txt_status.Text = ""
        txt_cpf.Focus()
    End Sub

    Private Sub txt_status_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt_status.MouseDoubleClick
        If txt_status.Text = "ATIVADO" Then
            txt_status.Text = "BLOQUEADO"
        Else
            txt_status.Text = "ATIVADO"
        End If
    End Sub
End Class