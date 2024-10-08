<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login
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
        Me.btn_entrar = New System.Windows.Forms.Button()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.visualizar_senha = New System.Windows.Forms.CheckBox()
        Me.btn_sair = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_entrar
        '
        Me.btn_entrar.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btn_entrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_entrar.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btn_entrar.Location = New System.Drawing.Point(200, 162)
        Me.btn_entrar.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_entrar.Name = "btn_entrar"
        Me.btn_entrar.Size = New System.Drawing.Size(107, 41)
        Me.btn_entrar.TabIndex = 4
        Me.btn_entrar.Text = "Entrar"
        Me.btn_entrar.UseVisualStyleBackColor = False
        '
        'txt_senha
        '
        Me.txt_senha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_senha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha.Location = New System.Drawing.Point(100, 100)
        Me.txt_senha.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.Size = New System.Drawing.Size(173, 19)
        Me.txt_senha.TabIndex = 2
        Me.txt_senha.UseSystemPasswordChar = True
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(100, 52)
        Me.txt_usuario.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(167, 20)
        Me.txt_usuario.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(100, 79)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Senha"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(100, 31)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nome de usuário"
        '
        'visualizar_senha
        '
        Me.visualizar_senha.AutoSize = True
        Me.visualizar_senha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.visualizar_senha.Location = New System.Drawing.Point(100, 122)
        Me.visualizar_senha.Margin = New System.Windows.Forms.Padding(2)
        Me.visualizar_senha.Name = "visualizar_senha"
        Me.visualizar_senha.Size = New System.Drawing.Size(118, 17)
        Me.visualizar_senha.TabIndex = 3
        Me.visualizar_senha.Text = "Visualizar senha"
        Me.visualizar_senha.UseVisualStyleBackColor = True
        '
        'btn_sair
        '
        Me.btn_sair.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btn_sair.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sair.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btn_sair.Location = New System.Drawing.Point(59, 162)
        Me.btn_sair.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(107, 41)
        Me.btn_sair.TabIndex = 6
        Me.btn_sair.Text = "Sair"
        Me.btn_sair.UseVisualStyleBackColor = False
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(381, 235)
        Me.Controls.Add(Me.btn_sair)
        Me.Controls.Add(Me.visualizar_senha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.btn_entrar)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frm_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_entrar As Button
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents visualizar_senha As CheckBox
    Friend WithEvents btn_sair As Button
End Class
