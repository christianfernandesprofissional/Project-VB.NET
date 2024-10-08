<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cadastro_clientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cadastro_clientes))
        Me.gb_1 = New System.Windows.Forms.GroupBox()
        Me.txt_telefone = New System.Windows.Forms.MaskedTextBox()
        Me.qt_pedidos = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_gravar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_endereco = New System.Windows.Forms.TextBox()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_data_nasc = New System.Windows.Forms.MaskedTextBox()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txt_busca = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.cmb_tipo = New System.Windows.Forms.ToolStripComboBox()
        Me.dgv_dados = New System.Windows.Forms.DataGridView()
        Me.dgv_nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_cpf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMAIL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_cargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_editar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.dgv_excluir = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.gb_1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gb_1
        '
        Me.gb_1.Controls.Add(Me.txt_telefone)
        Me.gb_1.Controls.Add(Me.qt_pedidos)
        Me.gb_1.Controls.Add(Me.Label4)
        Me.gb_1.Controls.Add(Me.ToolStrip1)
        Me.gb_1.Controls.Add(Me.Label8)
        Me.gb_1.Controls.Add(Me.Label1)
        Me.gb_1.Controls.Add(Me.txt_endereco)
        Me.gb_1.Controls.Add(Me.txt_nome)
        Me.gb_1.Controls.Add(Me.Label7)
        Me.gb_1.Controls.Add(Me.Label2)
        Me.gb_1.Controls.Add(Me.txt_email)
        Me.gb_1.Controls.Add(Me.Label6)
        Me.gb_1.Controls.Add(Me.Label3)
        Me.gb_1.Controls.Add(Me.txt_data_nasc)
        Me.gb_1.Controls.Add(Me.txt_cpf)
        Me.gb_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_1.Location = New System.Drawing.Point(111, 24)
        Me.gb_1.Margin = New System.Windows.Forms.Padding(2)
        Me.gb_1.Name = "gb_1"
        Me.gb_1.Padding = New System.Windows.Forms.Padding(2)
        Me.gb_1.Size = New System.Drawing.Size(617, 229)
        Me.gb_1.TabIndex = 21
        Me.gb_1.TabStop = False
        Me.gb_1.Text = "CADASTRO DE CLIENTES"
        '
        'txt_telefone
        '
        Me.txt_telefone.Location = New System.Drawing.Point(59, 129)
        Me.txt_telefone.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_telefone.Mask = "(00)00000-0000"
        Me.txt_telefone.Name = "txt_telefone"
        Me.txt_telefone.Size = New System.Drawing.Size(118, 23)
        Me.txt_telefone.TabIndex = 23
        Me.txt_telefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'qt_pedidos
        '
        Me.qt_pedidos.Enabled = False
        Me.qt_pedidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qt_pedidos.Location = New System.Drawing.Point(357, 129)
        Me.qt_pedidos.Margin = New System.Windows.Forms.Padding(2)
        Me.qt_pedidos.Name = "qt_pedidos"
        Me.qt_pedidos.Size = New System.Drawing.Size(69, 24)
        Me.qt_pedidos.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(354, 113)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "QT DE PEDIDOS"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_gravar, Me.ToolStripLabel3})
        Me.ToolStrip1.Location = New System.Drawing.Point(2, 18)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(613, 31)
        Me.ToolStrip1.TabIndex = 20
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btn_gravar
        '
        Me.btn_gravar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_gravar.Image = CType(resources.GetObject("btn_gravar.Image"), System.Drawing.Image)
        Me.btn_gravar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_gravar.Name = "btn_gravar"
        Me.btn_gravar.Size = New System.Drawing.Size(28, 28)
        Me.btn_gravar.Text = "btn_cadastrar"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(54, 28)
        Me.ToolStripLabel3.Text = "GRAVAR"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(269, 165)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "ENDEREÇO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(56, 63)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "CPF"
        '
        'txt_endereco
        '
        Me.txt_endereco.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_endereco.Location = New System.Drawing.Point(271, 180)
        Me.txt_endereco.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_endereco.Name = "txt_endereco"
        Me.txt_endereco.Size = New System.Drawing.Size(303, 24)
        Me.txt_endereco.TabIndex = 8
        '
        'txt_nome
        '
        Me.txt_nome.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome.Location = New System.Drawing.Point(170, 78)
        Me.txt_nome.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(256, 24)
        Me.txt_nome.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(56, 165)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "E-MAIL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(170, 63)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "NOME"
        '
        'txt_email
        '
        Me.txt_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.Location = New System.Drawing.Point(59, 180)
        Me.txt_email.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(210, 24)
        Me.txt_email.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(195, 114)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "DATA NASCIMENTO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(56, 114)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "TELEFONE"
        '
        'txt_data_nasc
        '
        Me.txt_data_nasc.Location = New System.Drawing.Point(211, 129)
        Me.txt_data_nasc.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_data_nasc.Mask = "00/00/0000"
        Me.txt_data_nasc.Name = "txt_data_nasc"
        Me.txt_data_nasc.Size = New System.Drawing.Size(89, 23)
        Me.txt_data_nasc.TabIndex = 4
        Me.txt_data_nasc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_cpf
        '
        Me.txt_cpf.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cpf.Location = New System.Drawing.Point(59, 78)
        Me.txt_cpf.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_cpf.Mask = "999,999,999-99"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(109, 24)
        Me.txt_cpf.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ToolStrip2)
        Me.GroupBox2.Controls.Add(Me.dgv_dados)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(11, 291)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(1012, 311)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "LISTA DE CLIENTES"
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
        Me.ToolStripLabel1.Size = New System.Drawing.Size(178, 22)
        Me.ToolStripLabel1.Text = "Digite o nome ou CPF do cliente"
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
        Me.dgv_dados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgv_nome, Me.dgv_cpf, Me.Column1, Me.EMAIL, Me.dgv_cargo, Me.dgv_editar, Me.dgv_excluir})
        Me.dgv_dados.Location = New System.Drawing.Point(4, 45)
        Me.dgv_dados.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_dados.Name = "dgv_dados"
        Me.dgv_dados.RowHeadersWidth = 62
        Me.dgv_dados.RowTemplate.Height = 28
        Me.dgv_dados.Size = New System.Drawing.Size(1004, 259)
        Me.dgv_dados.TabIndex = 0
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
        Me.dgv_cpf.Width = 150
        '
        'Column1
        '
        Me.Column1.HeaderText = "TELEFONE"
        Me.Column1.MinimumWidth = 15
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'EMAIL
        '
        Me.EMAIL.HeaderText = "EMAIL"
        Me.EMAIL.MinimumWidth = 30
        Me.EMAIL.Name = "EMAIL"
        Me.EMAIL.ReadOnly = True
        Me.EMAIL.Width = 150
        '
        'dgv_cargo
        '
        Me.dgv_cargo.HeaderText = "DATA_NASC"
        Me.dgv_cargo.MinimumWidth = 8
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
        'frm_cadastro_clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1047, 645)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gb_1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_cadastro_clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_cadastro_clientes"
        Me.gb_1.ResumeLayout(False)
        Me.gb_1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gb_1 As GroupBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btn_gravar As ToolStripButton
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_endereco As TextBox
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_data_nasc As MaskedTextBox
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents txt_busca As ToolStripTextBox
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents cmb_tipo As ToolStripComboBox
    Friend WithEvents dgv_dados As DataGridView
    Friend WithEvents qt_pedidos As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents txt_telefone As MaskedTextBox
    Friend WithEvents dgv_nome As DataGridViewTextBoxColumn
    Friend WithEvents dgv_cpf As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents EMAIL As DataGridViewTextBoxColumn
    Friend WithEvents dgv_cargo As DataGridViewTextBoxColumn
    Friend WithEvents dgv_editar As DataGridViewButtonColumn
    Friend WithEvents dgv_excluir As DataGridViewButtonColumn
End Class
