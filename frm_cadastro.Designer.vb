<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cadastro
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cadastro))
        Me.dgv_dados = New System.Windows.Forms.DataGridView()
        Me.dgv_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_cpf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_cargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_editar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.dgv_excluir = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_cargo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_login = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.cmb_data_nasc = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_endereco = New System.Windows.Forms.TextBox()
        Me.gb_1 = New System.Windows.Forms.GroupBox()
        Me.txt_ultimo_login = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_status = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txt_busca = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.cmb_tipo = New System.Windows.Forms.ToolStripComboBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDocument2 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDocument3 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDocument4 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDocument5 = New System.Drawing.Printing.PrintDocument()
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_dados
        '
        Me.dgv_dados.AllowUserToAddRows = False
        Me.dgv_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgv_id, Me.dgv_usuario, Me.dgv_nome, Me.dgv_cpf, Me.dgv_cargo, Me.dgv_editar, Me.dgv_excluir})
        Me.dgv_dados.Location = New System.Drawing.Point(4, 45)
        Me.dgv_dados.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_dados.Name = "dgv_dados"
        Me.dgv_dados.RowHeadersWidth = 62
        Me.dgv_dados.RowTemplate.Height = 28
        Me.dgv_dados.Size = New System.Drawing.Size(1004, 259)
        Me.dgv_dados.TabIndex = 0
        '
        'dgv_id
        '
        Me.dgv_id.HeaderText = "ID"
        Me.dgv_id.MinimumWidth = 8
        Me.dgv_id.Name = "dgv_id"
        Me.dgv_id.ReadOnly = True
        Me.dgv_id.Width = 50
        '
        'dgv_usuario
        '
        Me.dgv_usuario.HeaderText = "USUÁRIO"
        Me.dgv_usuario.MinimumWidth = 20
        Me.dgv_usuario.Name = "dgv_usuario"
        Me.dgv_usuario.ReadOnly = True
        '
        'dgv_nome
        '
        Me.dgv_nome.HeaderText = "NOME"
        Me.dgv_nome.MinimumWidth = 20
        Me.dgv_nome.Name = "dgv_nome"
        Me.dgv_nome.ReadOnly = True
        Me.dgv_nome.Width = 150
        '
        'dgv_cpf
        '
        Me.dgv_cpf.HeaderText = "CPF"
        Me.dgv_cpf.MinimumWidth = 15
        Me.dgv_cpf.Name = "dgv_cpf"
        Me.dgv_cpf.ReadOnly = True
        '
        'dgv_cargo
        '
        Me.dgv_cargo.HeaderText = "CARGO"
        Me.dgv_cargo.MinimumWidth = 15
        Me.dgv_cargo.Name = "dgv_cargo"
        Me.dgv_cargo.ReadOnly = True
        Me.dgv_cargo.Width = 150
        '
        'dgv_editar
        '
        Me.dgv_editar.HeaderText = "EDITAR"
        Me.dgv_editar.MinimumWidth = 8
        Me.dgv_editar.Name = "dgv_editar"
        Me.dgv_editar.Width = 120
        '
        'dgv_excluir
        '
        Me.dgv_excluir.HeaderText = "EXCLUIR"
        Me.dgv_excluir.MinimumWidth = 8
        Me.dgv_excluir.Name = "dgv_excluir"
        Me.dgv_excluir.Width = 120
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 47)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "CPF"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(138, 47)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "NOME"
        '
        'txt_nome
        '
        Me.txt_nome.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome.Location = New System.Drawing.Point(138, 62)
        Me.txt_nome.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(256, 24)
        Me.txt_nome.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 85)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "CARGO"
        '
        'txt_cargo
        '
        Me.txt_cargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cargo.Location = New System.Drawing.Point(27, 101)
        Me.txt_cargo.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_cargo.Name = "txt_cargo"
        Me.txt_cargo.Size = New System.Drawing.Size(210, 24)
        Me.txt_cargo.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 125)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "LOGIN"
        '
        'txt_login
        '
        Me.txt_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_login.Location = New System.Drawing.Point(27, 140)
        Me.txt_login.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_login.Name = "txt_login"
        Me.txt_login.Size = New System.Drawing.Size(210, 24)
        Me.txt_login.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(237, 125)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "SENHA"
        '
        'txt_senha
        '
        Me.txt_senha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha.Location = New System.Drawing.Point(239, 140)
        Me.txt_senha.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.Size = New System.Drawing.Size(155, 24)
        Me.txt_senha.TabIndex = 6
        '
        'txt_cpf
        '
        Me.txt_cpf.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cpf.Location = New System.Drawing.Point(27, 62)
        Me.txt_cpf.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_cpf.Mask = "999,999,999-99"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(109, 24)
        Me.txt_cpf.TabIndex = 1
        '
        'cmb_data_nasc
        '
        Me.cmb_data_nasc.Location = New System.Drawing.Point(291, 107)
        Me.cmb_data_nasc.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_data_nasc.Mask = "99/99/9999"
        Me.cmb_data_nasc.Name = "cmb_data_nasc"
        Me.cmb_data_nasc.Size = New System.Drawing.Size(89, 23)
        Me.cmb_data_nasc.TabIndex = 4
        Me.cmb_data_nasc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(275, 92)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "DATA NASCIMENTO"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(24, 167)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "E-MAIL"
        '
        'txt_email
        '
        Me.txt_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.Location = New System.Drawing.Point(27, 182)
        Me.txt_email.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(210, 24)
        Me.txt_email.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(237, 167)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "ENDEREÇO"
        '
        'txt_endereco
        '
        Me.txt_endereco.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_endereco.Location = New System.Drawing.Point(239, 182)
        Me.txt_endereco.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_endereco.Name = "txt_endereco"
        Me.txt_endereco.Size = New System.Drawing.Size(303, 24)
        Me.txt_endereco.TabIndex = 8
        '
        'gb_1
        '
        Me.gb_1.Controls.Add(Me.txt_ultimo_login)
        Me.gb_1.Controls.Add(Me.Label10)
        Me.gb_1.Controls.Add(Me.txt_status)
        Me.gb_1.Controls.Add(Me.Label9)
        Me.gb_1.Controls.Add(Me.ToolStrip1)
        Me.gb_1.Controls.Add(Me.Label8)
        Me.gb_1.Controls.Add(Me.Label1)
        Me.gb_1.Controls.Add(Me.txt_endereco)
        Me.gb_1.Controls.Add(Me.txt_nome)
        Me.gb_1.Controls.Add(Me.Label7)
        Me.gb_1.Controls.Add(Me.Label2)
        Me.gb_1.Controls.Add(Me.txt_email)
        Me.gb_1.Controls.Add(Me.txt_cargo)
        Me.gb_1.Controls.Add(Me.Label6)
        Me.gb_1.Controls.Add(Me.Label3)
        Me.gb_1.Controls.Add(Me.cmb_data_nasc)
        Me.gb_1.Controls.Add(Me.txt_login)
        Me.gb_1.Controls.Add(Me.Label4)
        Me.gb_1.Controls.Add(Me.txt_cpf)
        Me.gb_1.Controls.Add(Me.txt_senha)
        Me.gb_1.Controls.Add(Me.Label5)
        Me.gb_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_1.Location = New System.Drawing.Point(247, 11)
        Me.gb_1.Margin = New System.Windows.Forms.Padding(2)
        Me.gb_1.Name = "gb_1"
        Me.gb_1.Padding = New System.Windows.Forms.Padding(2)
        Me.gb_1.Size = New System.Drawing.Size(617, 229)
        Me.gb_1.TabIndex = 20
        Me.gb_1.TabStop = False
        Me.gb_1.Text = "CADASTRO DE FUNCIONÁRIO"
        '
        'txt_ultimo_login
        '
        Me.txt_ultimo_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ultimo_login.Location = New System.Drawing.Point(409, 62)
        Me.txt_ultimo_login.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_ultimo_login.Name = "txt_ultimo_login"
        Me.txt_ultimo_login.ReadOnly = True
        Me.txt_ultimo_login.Size = New System.Drawing.Size(133, 24)
        Me.txt_ultimo_login.TabIndex = 23
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(407, 47)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 13)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "ULTIMO LOGIN"
        '
        'txt_status
        '
        Me.txt_status.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_status.Location = New System.Drawing.Point(408, 140)
        Me.txt_status.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_status.Name = "txt_status"
        Me.txt_status.ReadOnly = True
        Me.txt_status.Size = New System.Drawing.Size(134, 24)
        Me.txt_status.TabIndex = 21
        Me.txt_status.Text = "ATIVADO"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(406, 125)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "STATUS"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(2, 18)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(613, 31)
        Me.ToolStrip1.TabIndex = 20
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(28, 28)
        Me.ToolStripButton1.Text = "btn_cadastrar"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ToolStrip2)
        Me.GroupBox2.Controls.Add(Me.dgv_dados)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(11, 262)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(1012, 311)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "LISTA DE FUNCIONÁRIOS"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.txt_busca, Me.ToolStripLabel2, Me.cmb_tipo})
        Me.ToolStrip2.Location = New System.Drawing.Point(2, 18)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1008, 25)
        Me.ToolStrip2.TabIndex = 1
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(204, 22)
        Me.ToolStripLabel1.Text = "Digite o nome ou CPF do funcionário"
        '
        'txt_busca
        '
        Me.txt_busca.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_busca.Name = "txt_busca"
        Me.txt_busca.Size = New System.Drawing.Size(68, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(32, 22)
        Me.ToolStripLabel2.Text = "TIPO"
        '
        'cmb_tipo
        '
        Me.cmb_tipo.Name = "cmb_tipo"
        Me.cmb_tipo.Size = New System.Drawing.Size(82, 25)
        '
        'frm_cadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1034, 606)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gb_1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frm_cadastro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Programa de Cadastro"
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_1.ResumeLayout(False)
        Me.gb_1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_dados As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_cargo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_login As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents cmb_data_nasc As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_endereco As TextBox
    Friend WithEvents gb_1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintDocument2 As Printing.PrintDocument
    Friend WithEvents PrintDocument3 As Printing.PrintDocument
    Friend WithEvents PrintDocument4 As Printing.PrintDocument
    Friend WithEvents PrintDocument5 As Printing.PrintDocument
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents txt_busca As ToolStripTextBox
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents cmb_tipo As ToolStripComboBox
    Friend WithEvents txt_status As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_ultimo_login As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents dgv_id As DataGridViewTextBoxColumn
    Friend WithEvents dgv_usuario As DataGridViewTextBoxColumn
    Friend WithEvents dgv_nome As DataGridViewTextBoxColumn
    Friend WithEvents dgv_cpf As DataGridViewTextBoxColumn
    Friend WithEvents dgv_cargo As DataGridViewTextBoxColumn
    Friend WithEvents dgv_editar As DataGridViewButtonColumn
    Friend WithEvents dgv_excluir As DataGridViewButtonColumn
End Class
