namespace Teste_Cartsys
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            button3 = new Button();
            button2 = new Button();
            panelCadastro = new Panel();
            label2 = new Label();
            textBoxCargo = new TextBox();
            buttonEnviarCadastro = new Button();
            labelBairro = new Label();
            labelEmail = new Label();
            labelEstadoCivil = new Label();
            labelIdade = new Label();
            labelCPF = new Label();
            textBoxBairro = new TextBox();
            textBoxEmail = new TextBox();
            textBoxEstadoCivil = new TextBox();
            textBoxIdade = new TextBox();
            textBoxCPF = new TextBox();
            textBoxNome = new TextBox();
            labelNomeCadastro = new Label();
            panelDetalhes = new Panel();
            labelEmailRetDetalhes = new Label();
            labelEstadoCivilRetDetalhes = new Label();
            labelIdadeRetDetalhes = new Label();
            labelNomeRetDetalhes = new Label();
            labelEmailDetalhes = new Label();
            labelEstadoCivilDetalhes = new Label();
            labelIdadeDetalhes = new Label();
            labelNomeDetalhes = new Label();
            buttonPesquisarDetalhesPessoa = new Button();
            textBoxNumRegistroDetalhes = new TextBox();
            labelNumRegistroDetalhes = new Label();
            panelRegistro = new Panel();
            buttonDeletarPessoa = new Button();
            labelNomePessoaPesquisaRetorno = new Label();
            labelNomePesquisa = new Label();
            buttonAlterarSituacao = new Button();
            labelSituacaoPessoaRet = new Label();
            label3 = new Label();
            labelCargoPessoaRet = new Label();
            textBoxPesquisarNomeRegistro = new TextBox();
            labelPesquisarNumRegistro = new Label();
            buttonPesquisarNumRegistro = new Button();
            label9 = new Label();
            label4 = new Label();
            labelCPFDetalhesRet = new Label();
            panelCadastro.SuspendLayout();
            panelDetalhes.SuspendLayout();
            panelRegistro.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(315, 25);
            label1.Name = "label1";
            label1.Size = new Size(184, 35);
            label1.TabIndex = 3;
            label1.Text = "Teste Cartsys";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F);
            button1.Location = new Point(22, 110);
            button1.Name = "button1";
            button1.Size = new Size(195, 41);
            button1.TabIndex = 4;
            button1.Text = "Cadastrar Usuário";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.Font = new Font("Segoe UI", 14F);
            button3.Location = new Point(577, 110);
            button3.Name = "button3";
            button3.Size = new Size(195, 41);
            button3.TabIndex = 6;
            button3.Text = "Detalhes Usuário";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top;
            button2.Font = new Font("Segoe UI", 14F);
            button2.Location = new Point(304, 110);
            button2.Name = "button2";
            button2.Size = new Size(195, 41);
            button2.TabIndex = 7;
            button2.Text = "Pesquisar Usuário";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panelCadastro
            // 
            panelCadastro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panelCadastro.Controls.Add(label2);
            panelCadastro.Controls.Add(textBoxCargo);
            panelCadastro.Controls.Add(buttonEnviarCadastro);
            panelCadastro.Controls.Add(labelBairro);
            panelCadastro.Controls.Add(labelEmail);
            panelCadastro.Controls.Add(labelEstadoCivil);
            panelCadastro.Controls.Add(labelIdade);
            panelCadastro.Controls.Add(labelCPF);
            panelCadastro.Controls.Add(textBoxBairro);
            panelCadastro.Controls.Add(textBoxEmail);
            panelCadastro.Controls.Add(textBoxEstadoCivil);
            panelCadastro.Controls.Add(textBoxIdade);
            panelCadastro.Controls.Add(textBoxCPF);
            panelCadastro.Controls.Add(textBoxNome);
            panelCadastro.Controls.Add(labelNomeCadastro);
            panelCadastro.Location = new Point(22, 182);
            panelCadastro.Name = "panelCadastro";
            panelCadastro.Size = new Size(750, 242);
            panelCadastro.TabIndex = 8;
            panelCadastro.Paint += panelCadastro_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(502, 39);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 13;
            label2.Text = "Cargo:";
            // 
            // textBoxCargo
            // 
            textBoxCargo.Location = new Point(560, 36);
            textBoxCargo.Name = "textBoxCargo";
            textBoxCargo.Size = new Size(133, 23);
            textBoxCargo.TabIndex = 14;
            // 
            // buttonEnviarCadastro
            // 
            buttonEnviarCadastro.Font = new Font("Segoe UI", 12F);
            buttonEnviarCadastro.Location = new Point(293, 196);
            buttonEnviarCadastro.Name = "buttonEnviarCadastro";
            buttonEnviarCadastro.Size = new Size(172, 33);
            buttonEnviarCadastro.TabIndex = 12;
            buttonEnviarCadastro.Text = "Enviar Cadastro";
            buttonEnviarCadastro.UseVisualStyleBackColor = true;
            buttonEnviarCadastro.Click += buttonEnviarCadastro_Click;
            // 
            // labelBairro
            // 
            labelBairro.AutoSize = true;
            labelBairro.Font = new Font("Segoe UI", 11F);
            labelBairro.Location = new Point(498, 130);
            labelBairro.Name = "labelBairro";
            labelBairro.Size = new Size(52, 20);
            labelBairro.TabIndex = 11;
            labelBairro.Text = "Bairro:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 11F);
            labelEmail.Location = new Point(9, 130);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(55, 20);
            labelEmail.TabIndex = 10;
            labelEmail.Text = "E-mail:";
            // 
            // labelEstadoCivil
            // 
            labelEstadoCivil.AutoSize = true;
            labelEstadoCivil.Font = new Font("Segoe UI", 11F);
            labelEstadoCivil.Location = new Point(498, 85);
            labelEstadoCivil.Name = "labelEstadoCivil";
            labelEstadoCivil.Size = new Size(89, 20);
            labelEstadoCivil.TabIndex = 9;
            labelEstadoCivil.Text = "Estado Civil:";
            // 
            // labelIdade
            // 
            labelIdade.AutoSize = true;
            labelIdade.Font = new Font("Segoe UI", 11F);
            labelIdade.Location = new Point(356, 85);
            labelIdade.Name = "labelIdade";
            labelIdade.Size = new Size(50, 20);
            labelIdade.TabIndex = 8;
            labelIdade.Text = "Idade:";
            // 
            // labelCPF
            // 
            labelCPF.AutoSize = true;
            labelCPF.Font = new Font("Segoe UI", 11F);
            labelCPF.Location = new Point(8, 81);
            labelCPF.Name = "labelCPF";
            labelCPF.Size = new Size(36, 20);
            labelCPF.TabIndex = 7;
            labelCPF.Text = "CPF:";
            // 
            // textBoxBairro
            // 
            textBoxBairro.Location = new Point(593, 127);
            textBoxBairro.Name = "textBoxBairro";
            textBoxBairro.Size = new Size(100, 23);
            textBoxBairro.TabIndex = 6;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(82, 127);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(395, 23);
            textBoxEmail.TabIndex = 5;
            // 
            // textBoxEstadoCivil
            // 
            textBoxEstadoCivil.Location = new Point(593, 82);
            textBoxEstadoCivil.Name = "textBoxEstadoCivil";
            textBoxEstadoCivil.Size = new Size(100, 23);
            textBoxEstadoCivil.TabIndex = 4;
            // 
            // textBoxIdade
            // 
            textBoxIdade.Location = new Point(428, 82);
            textBoxIdade.Name = "textBoxIdade";
            textBoxIdade.Size = new Size(49, 23);
            textBoxIdade.TabIndex = 3;
            // 
            // textBoxCPF
            // 
            textBoxCPF.Location = new Point(82, 82);
            textBoxCPF.Name = "textBoxCPF";
            textBoxCPF.Size = new Size(227, 23);
            textBoxCPF.TabIndex = 2;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(82, 36);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(395, 23);
            textBoxNome.TabIndex = 1;
            // 
            // labelNomeCadastro
            // 
            labelNomeCadastro.AutoSize = true;
            labelNomeCadastro.Font = new Font("Segoe UI", 12F);
            labelNomeCadastro.Location = new Point(8, 38);
            labelNomeCadastro.Name = "labelNomeCadastro";
            labelNomeCadastro.Size = new Size(56, 21);
            labelNomeCadastro.TabIndex = 0;
            labelNomeCadastro.Text = "Nome:";
            // 
            // panelDetalhes
            // 
            panelDetalhes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panelDetalhes.Controls.Add(labelCPFDetalhesRet);
            panelDetalhes.Controls.Add(label4);
            panelDetalhes.Controls.Add(labelEmailRetDetalhes);
            panelDetalhes.Controls.Add(labelEstadoCivilRetDetalhes);
            panelDetalhes.Controls.Add(labelIdadeRetDetalhes);
            panelDetalhes.Controls.Add(labelNomeRetDetalhes);
            panelDetalhes.Controls.Add(labelEmailDetalhes);
            panelDetalhes.Controls.Add(labelEstadoCivilDetalhes);
            panelDetalhes.Controls.Add(labelIdadeDetalhes);
            panelDetalhes.Controls.Add(labelNomeDetalhes);
            panelDetalhes.Controls.Add(buttonPesquisarDetalhesPessoa);
            panelDetalhes.Controls.Add(textBoxNumRegistroDetalhes);
            panelDetalhes.Controls.Add(labelNumRegistroDetalhes);
            panelDetalhes.Location = new Point(19, 177);
            panelDetalhes.Name = "panelDetalhes";
            panelDetalhes.Size = new Size(752, 244);
            panelDetalhes.TabIndex = 15;
            panelDetalhes.Paint += panelDetalhes_Paint;
            // 
            // labelEmailRetDetalhes
            // 
            labelEmailRetDetalhes.AutoSize = true;
            labelEmailRetDetalhes.Location = new Point(128, 139);
            labelEmailRetDetalhes.Name = "labelEmailRetDetalhes";
            labelEmailRetDetalhes.Size = new Size(140, 15);
            labelEmailRetDetalhes.TabIndex = 11;
            labelEmailRetDetalhes.Text = "emailpessoa@gmail.com";
            // 
            // labelEstadoCivilRetDetalhes
            // 
            labelEstadoCivilRetDetalhes.AutoSize = true;
            labelEstadoCivilRetDetalhes.Location = new Point(128, 109);
            labelEstadoCivilRetDetalhes.Name = "labelEstadoCivilRetDetalhes";
            labelEstadoCivilRetDetalhes.Size = new Size(91, 15);
            labelEstadoCivilRetDetalhes.TabIndex = 10;
            labelEstadoCivilRetDetalhes.Text = "Solteiro/Casado";
            // 
            // labelIdadeRetDetalhes
            // 
            labelIdadeRetDetalhes.AutoSize = true;
            labelIdadeRetDetalhes.Location = new Point(128, 80);
            labelIdadeRetDetalhes.Name = "labelIdadeRetDetalhes";
            labelIdadeRetDetalhes.Size = new Size(91, 15);
            labelIdadeRetDetalhes.TabIndex = 9;
            labelIdadeRetDetalhes.Text = "Idade da pessoa";
            labelIdadeRetDetalhes.Click += label2_Click;
            // 
            // labelNomeRetDetalhes
            // 
            labelNomeRetDetalhes.AutoSize = true;
            labelNomeRetDetalhes.Location = new Point(128, 48);
            labelNomeRetDetalhes.Name = "labelNomeRetDetalhes";
            labelNomeRetDetalhes.Size = new Size(155, 15);
            labelNomeRetDetalhes.TabIndex = 8;
            labelNomeRetDetalhes.Text = "Nome da pessoa cadastrada";
            // 
            // labelEmailDetalhes
            // 
            labelEmailDetalhes.AutoSize = true;
            labelEmailDetalhes.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelEmailDetalhes.Location = new Point(53, 139);
            labelEmailDetalhes.Name = "labelEmailDetalhes";
            labelEmailDetalhes.Size = new Size(44, 15);
            labelEmailDetalhes.TabIndex = 7;
            labelEmailDetalhes.Text = "E-Mail:";
            // 
            // labelEstadoCivilDetalhes
            // 
            labelEstadoCivilDetalhes.AutoSize = true;
            labelEstadoCivilDetalhes.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelEstadoCivilDetalhes.Location = new Point(53, 109);
            labelEstadoCivilDetalhes.Name = "labelEstadoCivilDetalhes";
            labelEstadoCivilDetalhes.Size = new Size(72, 15);
            labelEstadoCivilDetalhes.TabIndex = 6;
            labelEstadoCivilDetalhes.Text = "Estado Civil:";
            // 
            // labelIdadeDetalhes
            // 
            labelIdadeDetalhes.AutoSize = true;
            labelIdadeDetalhes.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelIdadeDetalhes.Location = new Point(53, 80);
            labelIdadeDetalhes.Name = "labelIdadeDetalhes";
            labelIdadeDetalhes.Size = new Size(41, 15);
            labelIdadeDetalhes.TabIndex = 5;
            labelIdadeDetalhes.Text = "Idade:";
            // 
            // labelNomeDetalhes
            // 
            labelNomeDetalhes.AutoSize = true;
            labelNomeDetalhes.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelNomeDetalhes.Location = new Point(50, 49);
            labelNomeDetalhes.Name = "labelNomeDetalhes";
            labelNomeDetalhes.Size = new Size(44, 15);
            labelNomeDetalhes.TabIndex = 4;
            labelNomeDetalhes.Text = "Nome:";
            labelNomeDetalhes.UseWaitCursor = true;
            // 
            // buttonPesquisarDetalhesPessoa
            // 
            buttonPesquisarDetalhesPessoa.Font = new Font("Segoe UI", 11F);
            buttonPesquisarDetalhesPessoa.Location = new Point(555, 186);
            buttonPesquisarDetalhesPessoa.Name = "buttonPesquisarDetalhesPessoa";
            buttonPesquisarDetalhesPessoa.Size = new Size(114, 35);
            buttonPesquisarDetalhesPessoa.TabIndex = 3;
            buttonPesquisarDetalhesPessoa.Text = "Pesquisar";
            buttonPesquisarDetalhesPessoa.UseVisualStyleBackColor = true;
            buttonPesquisarDetalhesPessoa.Click += buttonPesquisarDetalhesPessoa_Click;
            // 
            // textBoxNumRegistroDetalhes
            // 
            textBoxNumRegistroDetalhes.Location = new Point(203, 196);
            textBoxNumRegistroDetalhes.Name = "textBoxNumRegistroDetalhes";
            textBoxNumRegistroDetalhes.Size = new Size(233, 23);
            textBoxNumRegistroDetalhes.TabIndex = 2;
            // 
            // labelNumRegistroDetalhes
            // 
            labelNumRegistroDetalhes.AutoSize = true;
            labelNumRegistroDetalhes.Font = new Font("Segoe UI", 12F);
            labelNumRegistroDetalhes.Location = new Point(42, 198);
            labelNumRegistroDetalhes.Name = "labelNumRegistroDetalhes";
            labelNumRegistroDetalhes.Size = new Size(155, 21);
            labelNumRegistroDetalhes.TabIndex = 1;
            labelNumRegistroDetalhes.Text = "Número do Registro:";
            // 
            // panelRegistro
            // 
            panelRegistro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panelRegistro.Controls.Add(buttonDeletarPessoa);
            panelRegistro.Controls.Add(labelNomePessoaPesquisaRetorno);
            panelRegistro.Controls.Add(labelNomePesquisa);
            panelRegistro.Controls.Add(buttonAlterarSituacao);
            panelRegistro.Controls.Add(labelSituacaoPessoaRet);
            panelRegistro.Controls.Add(label3);
            panelRegistro.Controls.Add(labelCargoPessoaRet);
            panelRegistro.Controls.Add(textBoxPesquisarNomeRegistro);
            panelRegistro.Controls.Add(labelPesquisarNumRegistro);
            panelRegistro.Controls.Add(buttonPesquisarNumRegistro);
            panelRegistro.Controls.Add(label9);
            panelRegistro.Location = new Point(21, 179);
            panelRegistro.Name = "panelRegistro";
            panelRegistro.Size = new Size(750, 242);
            panelRegistro.TabIndex = 15;
            panelRegistro.Paint += panelRegistro_Paint;
            // 
            // buttonDeletarPessoa
            // 
            buttonDeletarPessoa.Location = new Point(376, 78);
            buttonDeletarPessoa.Name = "buttonDeletarPessoa";
            buttonDeletarPessoa.Size = new Size(89, 23);
            buttonDeletarPessoa.TabIndex = 21;
            buttonDeletarPessoa.Text = "Deletar";
            buttonDeletarPessoa.UseVisualStyleBackColor = true;
            buttonDeletarPessoa.Visible = false;
            buttonDeletarPessoa.Click += buttonDeletarPessoa_Click;
            // 
            // labelNomePessoaPesquisaRetorno
            // 
            labelNomePessoaPesquisaRetorno.AutoSize = true;
            labelNomePessoaPesquisaRetorno.Font = new Font("Segoe UI", 11F);
            labelNomePessoaPesquisaRetorno.Location = new Point(87, 122);
            labelNomePessoaPesquisaRetorno.Name = "labelNomePessoaPesquisaRetorno";
            labelNomePessoaPesquisaRetorno.Size = new Size(203, 20);
            labelNomePessoaPesquisaRetorno.TabIndex = 20;
            labelNomePessoaPesquisaRetorno.Text = "Nome da pessoa pesquisada.";
            // 
            // labelNomePesquisa
            // 
            labelNomePesquisa.AutoSize = true;
            labelNomePesquisa.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelNomePesquisa.Location = new Point(11, 122);
            labelNomePesquisa.Name = "labelNomePesquisa";
            labelNomePesquisa.Size = new Size(56, 20);
            labelNomePesquisa.TabIndex = 19;
            labelNomePesquisa.Text = "Nome:";
            // 
            // buttonAlterarSituacao
            // 
            buttonAlterarSituacao.Location = new Point(376, 35);
            buttonAlterarSituacao.Name = "buttonAlterarSituacao";
            buttonAlterarSituacao.Size = new Size(89, 23);
            buttonAlterarSituacao.TabIndex = 18;
            buttonAlterarSituacao.UseVisualStyleBackColor = true;
            buttonAlterarSituacao.Visible = false;
            buttonAlterarSituacao.Click += buttonAlterarSituacao_Click;
            // 
            // labelSituacaoPessoaRet
            // 
            labelSituacaoPessoaRet.AutoSize = true;
            labelSituacaoPessoaRet.Font = new Font("Segoe UI", 11F);
            labelSituacaoPessoaRet.Location = new Point(87, 82);
            labelSituacaoPessoaRet.Name = "labelSituacaoPessoaRet";
            labelSituacaoPessoaRet.Size = new Size(98, 20);
            labelSituacaoPessoaRet.TabIndex = 17;
            labelSituacaoPessoaRet.Text = "Ativo/Inativo.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.Location = new Point(9, 81);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 16;
            label3.Text = "Situação:";
            // 
            // labelCargoPessoaRet
            // 
            labelCargoPessoaRet.AutoSize = true;
            labelCargoPessoaRet.Font = new Font("Segoe UI", 11F);
            labelCargoPessoaRet.Location = new Point(82, 39);
            labelCargoPessoaRet.Name = "labelCargoPessoaRet";
            labelCargoPessoaRet.Size = new Size(202, 20);
            labelCargoPessoaRet.TabIndex = 15;
            labelCargoPessoaRet.Text = "Cargo da pessoa pesquisada.";
            // 
            // textBoxPesquisarNomeRegistro
            // 
            textBoxPesquisarNomeRegistro.Location = new Point(162, 190);
            textBoxPesquisarNomeRegistro.Name = "textBoxPesquisarNomeRegistro";
            textBoxPesquisarNomeRegistro.Size = new Size(303, 23);
            textBoxPesquisarNomeRegistro.TabIndex = 14;
            // 
            // labelPesquisarNumRegistro
            // 
            labelPesquisarNumRegistro.AutoSize = true;
            labelPesquisarNumRegistro.Font = new Font("Segoe UI", 11F);
            labelPesquisarNumRegistro.Location = new Point(19, 193);
            labelPesquisarNumRegistro.Name = "labelPesquisarNumRegistro";
            labelPesquisarNumRegistro.Size = new Size(53, 20);
            labelPesquisarNumRegistro.TabIndex = 13;
            labelPesquisarNumRegistro.Text = "Nome:";
            // 
            // buttonPesquisarNumRegistro
            // 
            buttonPesquisarNumRegistro.Font = new Font("Segoe UI", 12F);
            buttonPesquisarNumRegistro.Location = new Point(521, 186);
            buttonPesquisarNumRegistro.Name = "buttonPesquisarNumRegistro";
            buttonPesquisarNumRegistro.Size = new Size(172, 33);
            buttonPesquisarNumRegistro.TabIndex = 12;
            buttonPesquisarNumRegistro.Text = "Pesquisar";
            buttonPesquisarNumRegistro.UseVisualStyleBackColor = true;
            buttonPesquisarNumRegistro.Click += buttonPesquisarNumRegistro_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label9.Location = new Point(8, 38);
            label9.Name = "label9";
            label9.Size = new Size(59, 21);
            label9.TabIndex = 0;
            label9.Text = "Cargo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(53, 167);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 12;
            label4.Text = "CPF:";
            // 
            // labelCPFDetalhesRet
            // 
            labelCPFDetalhesRet.AutoSize = true;
            labelCPFDetalhesRet.Location = new Point(128, 167);
            labelCPFDetalhesRet.Name = "labelCPFDetalhesRet";
            labelCPFDetalhesRet.Size = new Size(129, 15);
            labelCPFDetalhesRet.TabIndex = 13;
            labelCPFDetalhesRet.Text = "CPF pessoa pesquisada";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelDetalhes);
            Controls.Add(panelRegistro);
            Controls.Add(panelCadastro);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            panelCadastro.ResumeLayout(false);
            panelCadastro.PerformLayout();
            panelDetalhes.ResumeLayout(false);
            panelDetalhes.PerformLayout();
            panelRegistro.ResumeLayout(false);
            panelRegistro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Button button1;
        private Button button3;
        private Button button2;
        private Panel panelCadastro;
        private Label labelNomeCadastro;
        private Label labelIdade;
        private Label labelCPF;
        private TextBox textBoxBairro;
        private TextBox textBoxEmail;
        private TextBox textBoxEstadoCivil;
        private TextBox textBoxIdade;
        private TextBox textBoxCPF;
        private TextBox textBoxNome;
        private Label labelBairro;
        private Label labelEmail;
        private Label labelEstadoCivil;
        private Button buttonEnviarCadastro;
        private Panel panelRegistro;
        private TextBox textBoxPesquisarNomeRegistro;
        private Label labelPesquisarNumRegistro;
        private Button buttonPesquisarNumRegistro;
        private Label label9;
        private Panel panelDetalhes;
        private Button buttonPesquisarDetalhesPessoa;
        private TextBox textBoxNumRegistroDetalhes;
        private Label labelNumRegistroDetalhes;
        private Label labelEstadoCivilDetalhes;
        private Label labelIdadeDetalhes;
        private Label labelNomeDetalhes;
        private Label labelEmailDetalhes;
        private Label labelIdadeRetDetalhes;
        private Label labelNomeRetDetalhes;
        private Label labelEstadoCivilRetDetalhes;
        private Label labelEmailRetDetalhes;
        private Label labelCargoPessoaRet;
        private Label label2;
        private TextBox textBoxCargo;
        private Label labelSituacaoPessoaRet;
        private Label label3;
        private Button buttonAlterarSituacao;
        private Label labelNomePessoaPesquisaRetorno;
        private Label labelNomePesquisa;
        private Button buttonDeletarPessoa;
        private Label labelCPFDetalhesRet;
        private Label label4;
    }
}
