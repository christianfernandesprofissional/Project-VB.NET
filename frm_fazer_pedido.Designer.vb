<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_fazer_pedido
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_fazer_pedido))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txt_busca = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.cmb_tipo = New System.Windows.Forms.ToolStripComboBox()
        Me.dgv_dados = New System.Windows.Forms.DataGridView()
        Me.dgv_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_cpf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_editar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.gb_1 = New System.Windows.Forms.GroupBox()
        Me.txt_cpf_cliente = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_ver_carrinho = New System.Windows.Forms.Button()
        Me.btn_adicionar_carrinho = New System.Windows.Forms.Button()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_nome_produto = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_qtde_estoque = New System.Windows.Forms.TextBox()
        Me.txt_preco = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ToolStrip2)
        Me.GroupBox2.Controls.Add(Me.dgv_dados)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(1, 306)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(1012, 311)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "LISTA DE PRODUTOS"
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
        Me.ToolStripLabel1.Size = New System.Drawing.Size(179, 22)
        Me.ToolStripLabel1.Text = "Digite o nome ou ID  do produto"
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
        'dgv_dados
        '
        Me.dgv_dados.AllowUserToAddRows = False
        Me.dgv_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgv_id, Me.dgv_nome, Me.dgv_cpf, Me.Column1, Me.dgv_editar})
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
        Me.dgv_id.Width = 50
        '
        'dgv_nome
        '
        Me.dgv_nome.HeaderText = "NOME"
        Me.dgv_nome.MinimumWidth = 8
        Me.dgv_nome.Name = "dgv_nome"
        Me.dgv_nome.Width = 150
        '
        'dgv_cpf
        '
        Me.dgv_cpf.HeaderText = "PREÇO"
        Me.dgv_cpf.Name = "dgv_cpf"
        '
        'Column1
        '
        Me.Column1.HeaderText = "QTDE ESTOQUE"
        Me.Column1.Name = "Column1"
        '
        'dgv_editar
        '
        Me.dgv_editar.HeaderText = "CARREGAR"
        Me.dgv_editar.MinimumWidth = 8
        Me.dgv_editar.Name = "dgv_editar"
        Me.dgv_editar.Width = 120
        '
        'gb_1
        '
        Me.gb_1.Controls.Add(Me.txt_cpf_cliente)
        Me.gb_1.Controls.Add(Me.Label4)
        Me.gb_1.Controls.Add(Me.btn_ver_carrinho)
        Me.gb_1.Controls.Add(Me.btn_adicionar_carrinho)
        Me.gb_1.Controls.Add(Me.txt_id)
        Me.gb_1.Controls.Add(Me.Label1)
        Me.gb_1.Controls.Add(Me.txt_nome_produto)
        Me.gb_1.Controls.Add(Me.Label7)
        Me.gb_1.Controls.Add(Me.Label2)
        Me.gb_1.Controls.Add(Me.txt_qtde_estoque)
        Me.gb_1.Controls.Add(Me.txt_preco)
        Me.gb_1.Controls.Add(Me.Label3)
        Me.gb_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_1.Location = New System.Drawing.Point(201, 49)
        Me.gb_1.Margin = New System.Windows.Forms.Padding(2)
        Me.gb_1.Name = "gb_1"
        Me.gb_1.Padding = New System.Windows.Forms.Padding(2)
        Me.gb_1.Size = New System.Drawing.Size(524, 230)
        Me.gb_1.TabIndex = 25
        Me.gb_1.TabStop = False
        Me.gb_1.Text = "v"
        '
        'txt_cpf_cliente
        '
        Me.txt_cpf_cliente.Location = New System.Drawing.Point(244, 97)
        Me.txt_cpf_cliente.Mask = "000.000.000-00"
        Me.txt_cpf_cliente.Name = "txt_cpf_cliente"
        Me.txt_cpf_cliente.Size = New System.Drawing.Size(114, 23)
        Me.txt_cpf_cliente.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(241, 78)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "CPF DO CLIENTE"
        '
        'btn_ver_carrinho
        '
        Me.btn_ver_carrinho.Image = CType(resources.GetObject("btn_ver_carrinho.Image"), System.Drawing.Image)
        Me.btn_ver_carrinho.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ver_carrinho.Location = New System.Drawing.Point(235, 160)
        Me.btn_ver_carrinho.Name = "btn_ver_carrinho"
        Me.btn_ver_carrinho.Size = New System.Drawing.Size(123, 49)
        Me.btn_ver_carrinho.TabIndex = 24
        Me.btn_ver_carrinho.Text = "Visualizar carrinho"
        Me.btn_ver_carrinho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ver_carrinho.UseVisualStyleBackColor = True
        '
        'btn_adicionar_carrinho
        '
        Me.btn_adicionar_carrinho.Image = CType(resources.GetObject("btn_adicionar_carrinho.Image"), System.Drawing.Image)
        Me.btn_adicionar_carrinho.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_adicionar_carrinho.Location = New System.Drawing.Point(381, 160)
        Me.btn_adicionar_carrinho.Name = "btn_adicionar_carrinho"
        Me.btn_adicionar_carrinho.Size = New System.Drawing.Size(118, 49)
        Me.btn_adicionar_carrinho.TabIndex = 23
        Me.btn_adicionar_carrinho.Text = "Adicionar"
        Me.btn_adicionar_carrinho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_adicionar_carrinho.UseVisualStyleBackColor = True
        '
        'txt_id
        '
        Me.txt_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id.Location = New System.Drawing.Point(32, 52)
        Me.txt_id.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.ReadOnly = True
        Me.txt_id.Size = New System.Drawing.Size(55, 24)
        Me.txt_id.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 36)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "ID"
        '
        'txt_nome_produto
        '
        Me.txt_nome_produto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome_produto.Location = New System.Drawing.Point(91, 52)
        Me.txt_nome_produto.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_nome_produto.Name = "txt_nome_produto"
        Me.txt_nome_produto.ReadOnly = True
        Me.txt_nome_produto.Size = New System.Drawing.Size(389, 24)
        Me.txt_nome_produto.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(133, 78)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "QUANTIDADE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(91, 37)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "NOME DO PRODUTO"
        '
        'txt_qtde_estoque
        '
        Me.txt_qtde_estoque.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_qtde_estoque.Location = New System.Drawing.Point(136, 94)
        Me.txt_qtde_estoque.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_qtde_estoque.Name = "txt_qtde_estoque"
        Me.txt_qtde_estoque.Size = New System.Drawing.Size(85, 24)
        Me.txt_qtde_estoque.TabIndex = 7
        '
        'txt_preco
        '
        Me.txt_preco.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_preco.Location = New System.Drawing.Point(32, 94)
        Me.txt_preco.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_preco.Name = "txt_preco"
        Me.txt_preco.ReadOnly = True
        Me.txt_preco.Size = New System.Drawing.Size(100, 24)
        Me.txt_preco.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 78)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "PREÇO"
        '
        'frm_fazer_pedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1015, 647)
        Me.Controls.Add(Me.gb_1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_fazer_pedido"
        Me.Text = "frm_fazer_pedido"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_1.ResumeLayout(False)
        Me.gb_1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents txt_busca As ToolStripTextBox
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents cmb_tipo As ToolStripComboBox
    Friend WithEvents dgv_dados As DataGridView
    Friend WithEvents gb_1 As GroupBox
    Friend WithEvents txt_id As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_nome_produto As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_qtde_estoque As TextBox
    Friend WithEvents txt_preco As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_adicionar_carrinho As Button
    Friend WithEvents btn_ver_carrinho As Button
    Friend WithEvents dgv_id As DataGridViewTextBoxColumn
    Friend WithEvents dgv_nome As DataGridViewTextBoxColumn
    Friend WithEvents dgv_cpf As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents dgv_editar As DataGridViewButtonColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_cpf_cliente As MaskedTextBox
End Class
