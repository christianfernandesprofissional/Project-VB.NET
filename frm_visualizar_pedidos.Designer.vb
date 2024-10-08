<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_visualizar_pedidos
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txt_busca = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.cmb_tipo = New System.Windows.Forms.ToolStripComboBox()
        Me.dgv_dados = New System.Windows.Forms.DataGridView()
        Me.dgv_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_cpf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_editar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.GroupBox2.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ToolStrip2)
        Me.GroupBox2.Controls.Add(Me.dgv_dados)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(11, 11)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(1012, 586)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "LISTA DE PEDIDOS"
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
        Me.ToolStripLabel1.Size = New System.Drawing.Size(119, 22)
        Me.ToolStripLabel1.Text = "Digite o ID do pedido"
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
        Me.dgv_dados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgv_id, Me.dgv_cpf, Me.dgv_nome, Me.dgv_total, Me.dgv_status, Me.dgv_editar})
        Me.dgv_dados.Location = New System.Drawing.Point(4, 45)
        Me.dgv_dados.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_dados.Name = "dgv_dados"
        Me.dgv_dados.RowHeadersWidth = 62
        Me.dgv_dados.RowTemplate.Height = 28
        Me.dgv_dados.Size = New System.Drawing.Size(1004, 527)
        Me.dgv_dados.TabIndex = 0
        '
        'dgv_id
        '
        Me.dgv_id.HeaderText = "ID"
        Me.dgv_id.MinimumWidth = 8
        Me.dgv_id.Name = "dgv_id"
        Me.dgv_id.Width = 50
        '
        'dgv_cpf
        '
        Me.dgv_cpf.HeaderText = "CPF CLIENTE"
        Me.dgv_cpf.Name = "dgv_cpf"
        '
        'dgv_nome
        '
        Me.dgv_nome.HeaderText = "NOME PRODUTO"
        Me.dgv_nome.MinimumWidth = 8
        Me.dgv_nome.Name = "dgv_nome"
        Me.dgv_nome.Width = 150
        '
        'dgv_total
        '
        Me.dgv_total.HeaderText = "TOTAL ITEM"
        Me.dgv_total.Name = "dgv_total"
        '
        'dgv_status
        '
        Me.dgv_status.HeaderText = "STATUS"
        Me.dgv_status.Name = "dgv_status"
        '
        'dgv_editar
        '
        Me.dgv_editar.HeaderText = "ENTREGAR"
        Me.dgv_editar.MinimumWidth = 8
        Me.dgv_editar.Name = "dgv_editar"
        Me.dgv_editar.Width = 120
        '
        'frm_visualizar_pedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1030, 608)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_visualizar_pedidos"
        Me.Text = "frm_visualizar_pedidos"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents txt_busca As ToolStripTextBox
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents cmb_tipo As ToolStripComboBox
    Friend WithEvents dgv_dados As DataGridView
    Friend WithEvents dgv_id As DataGridViewTextBoxColumn
    Friend WithEvents dgv_cpf As DataGridViewTextBoxColumn
    Friend WithEvents dgv_nome As DataGridViewTextBoxColumn
    Friend WithEvents dgv_total As DataGridViewTextBoxColumn
    Friend WithEvents dgv_status As DataGridViewTextBoxColumn
    Friend WithEvents dgv_editar As DataGridViewButtonColumn
End Class
