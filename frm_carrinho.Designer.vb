<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_carrinho
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_carrinho))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txt_busca = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.cmb_tipo = New System.Windows.Forms.ToolStripComboBox()
        Me.dgv_dados_carrinho = New System.Windows.Forms.DataGridView()
        Me.btn_finalizar_pedido = New System.Windows.Forms.Button()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_total = New System.Windows.Forms.Label()
        Me.dgv_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_cpf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_editar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.GroupBox2.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.dgv_dados_carrinho, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ToolStrip2)
        Me.GroupBox2.Controls.Add(Me.dgv_dados_carrinho)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(11, 11)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(804, 362)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CARRINHO"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.txt_busca, Me.ToolStripLabel2, Me.cmb_tipo})
        Me.ToolStrip2.Location = New System.Drawing.Point(2, 18)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(800, 25)
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
        'dgv_dados_carrinho
        '
        Me.dgv_dados_carrinho.AllowUserToAddRows = False
        Me.dgv_dados_carrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dados_carrinho.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgv_id, Me.dgv_nome, Me.dgv_cpf, Me.Column1, Me.Column2, Me.dgv_editar})
        Me.dgv_dados_carrinho.Location = New System.Drawing.Point(4, 45)
        Me.dgv_dados_carrinho.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_dados_carrinho.Name = "dgv_dados_carrinho"
        Me.dgv_dados_carrinho.RowHeadersWidth = 62
        Me.dgv_dados_carrinho.RowTemplate.Height = 28
        Me.dgv_dados_carrinho.Size = New System.Drawing.Size(796, 313)
        Me.dgv_dados_carrinho.TabIndex = 0
        '
        'btn_finalizar_pedido
        '
        Me.btn_finalizar_pedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_finalizar_pedido.Image = CType(resources.GetObject("btn_finalizar_pedido.Image"), System.Drawing.Image)
        Me.btn_finalizar_pedido.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_finalizar_pedido.Location = New System.Drawing.Point(679, 403)
        Me.btn_finalizar_pedido.Name = "btn_finalizar_pedido"
        Me.btn_finalizar_pedido.Size = New System.Drawing.Size(136, 62)
        Me.btn_finalizar_pedido.TabIndex = 26
        Me.btn_finalizar_pedido.Text = "FINALIZAR " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PEDIDO"
        Me.btn_finalizar_pedido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_finalizar_pedido.UseVisualStyleBackColor = True
        '
        'btn_voltar
        '
        Me.btn_voltar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_voltar.Location = New System.Drawing.Point(516, 403)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(136, 62)
        Me.btn_voltar.TabIndex = 27
        Me.btn_voltar.Text = "VOLTAR"
        Me.btn_voltar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 384)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 24)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "TOTAL GERAL"
        '
        'txt_total
        '
        Me.txt_total.AutoSize = True
        Me.txt_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total.Location = New System.Drawing.Point(33, 419)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(101, 31)
        Me.txt_total.TabIndex = 29
        Me.txt_total.Text = "Label2"
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
        Me.Column1.HeaderText = "QTDE"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "TOTAL ITEM"
        Me.Column2.Name = "Column2"
        '
        'dgv_editar
        '
        Me.dgv_editar.HeaderText = "EXCLUIR"
        Me.dgv_editar.MinimumWidth = 8
        Me.dgv_editar.Name = "dgv_editar"
        Me.dgv_editar.Width = 120
        '
        'frm_carrinho
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(823, 482)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.btn_finalizar_pedido)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_carrinho"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_carrinho"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.dgv_dados_carrinho, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents txt_busca As ToolStripTextBox
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents cmb_tipo As ToolStripComboBox
    Friend WithEvents dgv_dados_carrinho As DataGridView
    Friend WithEvents btn_finalizar_pedido As Button
    Friend WithEvents btn_voltar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_total As Label
    Friend WithEvents dgv_id As DataGridViewTextBoxColumn
    Friend WithEvents dgv_nome As DataGridViewTextBoxColumn
    Friend WithEvents dgv_cpf As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents dgv_editar As DataGridViewButtonColumn
End Class
