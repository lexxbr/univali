
namespace Minha_Calculadora_v1
{
    partial class FormCalc
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalc));
            this.calcBox = new System.Windows.Forms.TextBox();
            this.botaoMais = new System.Windows.Forms.Button();
            this.labelOperador = new System.Windows.Forms.Label();
            this.botaoOito = new System.Windows.Forms.Button();
            this.botaoNove = new System.Windows.Forms.Button();
            this.botaoCE = new System.Windows.Forms.Button();
            this.botaoC = new System.Windows.Forms.Button();
            this.botaoSeis = new System.Windows.Forms.Button();
            this.botaoCinco = new System.Windows.Forms.Button();
            this.botaoMenos = new System.Windows.Forms.Button();
            this.botaoQuatro = new System.Windows.Forms.Button();
            this.botaoIgual = new System.Windows.Forms.Button();
            this.botaoTres = new System.Windows.Forms.Button();
            this.botaoDois = new System.Windows.Forms.Button();
            this.botaoVezes = new System.Windows.Forms.Button();
            this.botaoUm = new System.Windows.Forms.Button();
            this.botaoPonto = new System.Windows.Forms.Button();
            this.botaoDividr = new System.Windows.Forms.Button();
            this.botaoZero = new System.Windows.Forms.Button();
            this.labelCopy = new System.Windows.Forms.Label();
            this.botaoSete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calcBox
            // 
            this.calcBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.calcBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calcBox.Cursor = System.Windows.Forms.Cursors.No;
            this.calcBox.Font = new System.Drawing.Font("Arial Narrow", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcBox.ForeColor = System.Drawing.Color.Aqua;
            this.calcBox.Location = new System.Drawing.Point(3, 36);
            this.calcBox.MaxLength = 11;
            this.calcBox.Name = "calcBox";
            this.calcBox.Size = new System.Drawing.Size(314, 69);
            this.calcBox.TabIndex = 0;
            this.calcBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.calcBox.TextChanged += new System.EventHandler(this.CalcBox_TextChanged);
            this.calcBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CalcBox_KeyPress);
            // 
            // botaoMais
            // 
            this.botaoMais.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.botaoMais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoMais.Location = new System.Drawing.Point(195, 123);
            this.botaoMais.Name = "botaoMais";
            this.botaoMais.Size = new System.Drawing.Size(58, 57);
            this.botaoMais.TabIndex = 2;
            this.botaoMais.Text = "+";
            this.botaoMais.UseVisualStyleBackColor = false;
            this.botaoMais.Click += new System.EventHandler(this.PlusButton_Click);
            this.botaoMais.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BotaoMais_KeyPress);
            // 
            // labelOperador
            // 
            this.labelOperador.AutoSize = true;
            this.labelOperador.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOperador.ForeColor = System.Drawing.Color.Lime;
            this.labelOperador.Location = new System.Drawing.Point(12, 52);
            this.labelOperador.Name = "labelOperador";
            this.labelOperador.Size = new System.Drawing.Size(0, 20);
            this.labelOperador.TabIndex = 3;
            // 
            // botaoOito
            // 
            this.botaoOito.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.botaoOito.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoOito.ForeColor = System.Drawing.SystemColors.Control;
            this.botaoOito.Location = new System.Drawing.Point(67, 123);
            this.botaoOito.Name = "botaoOito";
            this.botaoOito.Size = new System.Drawing.Size(58, 57);
            this.botaoOito.TabIndex = 4;
            this.botaoOito.Text = "8";
            this.botaoOito.UseVisualStyleBackColor = false;
            this.botaoOito.Click += new System.EventHandler(this.Button1_Click);
            // 
            // botaoNove
            // 
            this.botaoNove.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.botaoNove.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoNove.ForeColor = System.Drawing.SystemColors.Control;
            this.botaoNove.Location = new System.Drawing.Point(131, 123);
            this.botaoNove.Name = "botaoNove";
            this.botaoNove.Size = new System.Drawing.Size(58, 57);
            this.botaoNove.TabIndex = 5;
            this.botaoNove.Text = "9";
            this.botaoNove.UseVisualStyleBackColor = false;
            this.botaoNove.Click += new System.EventHandler(this.Button2_Click);
            // 
            // botaoCE
            // 
            this.botaoCE.Location = new System.Drawing.Point(259, 123);
            this.botaoCE.Name = "botaoCE";
            this.botaoCE.Size = new System.Drawing.Size(58, 57);
            this.botaoCE.TabIndex = 6;
            this.botaoCE.Text = "CE";
            this.botaoCE.UseVisualStyleBackColor = true;
            this.botaoCE.Click += new System.EventHandler(this.Button3_Click);
            // 
            // botaoC
            // 
            this.botaoC.Location = new System.Drawing.Point(259, 186);
            this.botaoC.Name = "botaoC";
            this.botaoC.Size = new System.Drawing.Size(58, 57);
            this.botaoC.TabIndex = 11;
            this.botaoC.Text = "C";
            this.botaoC.UseVisualStyleBackColor = true;
            this.botaoC.Click += new System.EventHandler(this.Button4_Click);
            // 
            // botaoSeis
            // 
            this.botaoSeis.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.botaoSeis.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoSeis.ForeColor = System.Drawing.SystemColors.Control;
            this.botaoSeis.Location = new System.Drawing.Point(131, 186);
            this.botaoSeis.Name = "botaoSeis";
            this.botaoSeis.Size = new System.Drawing.Size(58, 57);
            this.botaoSeis.TabIndex = 10;
            this.botaoSeis.Text = "6";
            this.botaoSeis.UseVisualStyleBackColor = false;
            this.botaoSeis.Click += new System.EventHandler(this.Button5_Click);
            // 
            // botaoCinco
            // 
            this.botaoCinco.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.botaoCinco.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoCinco.ForeColor = System.Drawing.SystemColors.Control;
            this.botaoCinco.Location = new System.Drawing.Point(67, 186);
            this.botaoCinco.Name = "botaoCinco";
            this.botaoCinco.Size = new System.Drawing.Size(58, 57);
            this.botaoCinco.TabIndex = 9;
            this.botaoCinco.Text = "5";
            this.botaoCinco.UseVisualStyleBackColor = false;
            this.botaoCinco.Click += new System.EventHandler(this.Button6_Click);
            // 
            // botaoMenos
            // 
            this.botaoMenos.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.botaoMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoMenos.Location = new System.Drawing.Point(195, 186);
            this.botaoMenos.Name = "botaoMenos";
            this.botaoMenos.Size = new System.Drawing.Size(58, 57);
            this.botaoMenos.TabIndex = 8;
            this.botaoMenos.Text = "-";
            this.botaoMenos.UseVisualStyleBackColor = false;
            this.botaoMenos.Click += new System.EventHandler(this.Button7_Click);
            // 
            // botaoQuatro
            // 
            this.botaoQuatro.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.botaoQuatro.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoQuatro.ForeColor = System.Drawing.SystemColors.Control;
            this.botaoQuatro.Location = new System.Drawing.Point(3, 186);
            this.botaoQuatro.Name = "botaoQuatro";
            this.botaoQuatro.Size = new System.Drawing.Size(58, 57);
            this.botaoQuatro.TabIndex = 7;
            this.botaoQuatro.Text = "4";
            this.botaoQuatro.UseVisualStyleBackColor = false;
            this.botaoQuatro.Click += new System.EventHandler(this.Button8_Click);
            // 
            // botaoIgual
            // 
            this.botaoIgual.Location = new System.Drawing.Point(259, 249);
            this.botaoIgual.Name = "botaoIgual";
            this.botaoIgual.Size = new System.Drawing.Size(58, 120);
            this.botaoIgual.TabIndex = 16;
            this.botaoIgual.Text = "=";
            this.botaoIgual.UseVisualStyleBackColor = true;
            this.botaoIgual.Click += new System.EventHandler(this.Button9_Click);
            // 
            // botaoTres
            // 
            this.botaoTres.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.botaoTres.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoTres.ForeColor = System.Drawing.SystemColors.Control;
            this.botaoTres.Location = new System.Drawing.Point(131, 249);
            this.botaoTres.Name = "botaoTres";
            this.botaoTres.Size = new System.Drawing.Size(58, 57);
            this.botaoTres.TabIndex = 15;
            this.botaoTres.Text = "3";
            this.botaoTres.UseVisualStyleBackColor = false;
            this.botaoTres.Click += new System.EventHandler(this.Button10_Click);
            // 
            // botaoDois
            // 
            this.botaoDois.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.botaoDois.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoDois.ForeColor = System.Drawing.SystemColors.Control;
            this.botaoDois.Location = new System.Drawing.Point(67, 249);
            this.botaoDois.Name = "botaoDois";
            this.botaoDois.Size = new System.Drawing.Size(58, 57);
            this.botaoDois.TabIndex = 14;
            this.botaoDois.Text = "2";
            this.botaoDois.UseVisualStyleBackColor = false;
            this.botaoDois.Click += new System.EventHandler(this.Button11_Click);
            // 
            // botaoVezes
            // 
            this.botaoVezes.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.botaoVezes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoVezes.Location = new System.Drawing.Point(195, 249);
            this.botaoVezes.Name = "botaoVezes";
            this.botaoVezes.Size = new System.Drawing.Size(58, 57);
            this.botaoVezes.TabIndex = 13;
            this.botaoVezes.Text = "x";
            this.botaoVezes.UseVisualStyleBackColor = false;
            this.botaoVezes.Click += new System.EventHandler(this.Button12_Click);
            // 
            // botaoUm
            // 
            this.botaoUm.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.botaoUm.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoUm.ForeColor = System.Drawing.SystemColors.Control;
            this.botaoUm.Location = new System.Drawing.Point(3, 249);
            this.botaoUm.Name = "botaoUm";
            this.botaoUm.Size = new System.Drawing.Size(58, 57);
            this.botaoUm.TabIndex = 12;
            this.botaoUm.Text = "1";
            this.botaoUm.UseVisualStyleBackColor = false;
            this.botaoUm.Click += new System.EventHandler(this.Button13_Click);
            // 
            // botaoPonto
            // 
            this.botaoPonto.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.botaoPonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoPonto.Location = new System.Drawing.Point(131, 312);
            this.botaoPonto.Name = "botaoPonto";
            this.botaoPonto.Size = new System.Drawing.Size(58, 57);
            this.botaoPonto.TabIndex = 20;
            this.botaoPonto.Text = ".";
            this.botaoPonto.UseVisualStyleBackColor = false;
            this.botaoPonto.Click += new System.EventHandler(this.Button15_Click);
            this.botaoPonto.Enter += new System.EventHandler(this.BotaoPonto_PreviewTextInput);
            this.botaoPonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BotaoPonto_KeyPress);
            this.botaoPonto.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BotaoPonto_MouseClick);
            // 
            // botaoDividr
            // 
            this.botaoDividr.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.botaoDividr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoDividr.Location = new System.Drawing.Point(195, 312);
            this.botaoDividr.Name = "botaoDividr";
            this.botaoDividr.Size = new System.Drawing.Size(58, 57);
            this.botaoDividr.TabIndex = 18;
            this.botaoDividr.Text = "/";
            this.botaoDividr.UseVisualStyleBackColor = false;
            this.botaoDividr.Click += new System.EventHandler(this.Button17_Click);
            // 
            // botaoZero
            // 
            this.botaoZero.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.botaoZero.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoZero.ForeColor = System.Drawing.SystemColors.Control;
            this.botaoZero.Location = new System.Drawing.Point(3, 312);
            this.botaoZero.Name = "botaoZero";
            this.botaoZero.Size = new System.Drawing.Size(122, 57);
            this.botaoZero.TabIndex = 17;
            this.botaoZero.Text = "0";
            this.botaoZero.UseVisualStyleBackColor = false;
            this.botaoZero.Click += new System.EventHandler(this.Button18_Click);
            // 
            // labelCopy
            // 
            this.labelCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCopy.AutoSize = true;
            this.labelCopy.Font = new System.Drawing.Font("Arial", 8F);
            this.labelCopy.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelCopy.Location = new System.Drawing.Point(97, 372);
            this.labelCopy.Name = "labelCopy";
            this.labelCopy.Size = new System.Drawing.Size(122, 14);
            this.labelCopy.TabIndex = 21;
            this.labelCopy.Text = "© 2021 - Alexandre Fco";
            this.labelCopy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // botaoSete
            // 
            this.botaoSete.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.botaoSete.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Bold);
            this.botaoSete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.botaoSete.Location = new System.Drawing.Point(3, 123);
            this.botaoSete.Name = "botaoSete";
            this.botaoSete.Size = new System.Drawing.Size(58, 55);
            this.botaoSete.TabIndex = 22;
            this.botaoSete.Text = "7";
            this.botaoSete.UseVisualStyleBackColor = false;
            this.botaoSete.Click += new System.EventHandler(this.Button14_Click);
            // 
            // FormCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(320, 395);
            this.Controls.Add(this.botaoSete);
            this.Controls.Add(this.labelCopy);
            this.Controls.Add(this.botaoPonto);
            this.Controls.Add(this.botaoDividr);
            this.Controls.Add(this.botaoZero);
            this.Controls.Add(this.botaoIgual);
            this.Controls.Add(this.botaoTres);
            this.Controls.Add(this.botaoDois);
            this.Controls.Add(this.botaoVezes);
            this.Controls.Add(this.botaoUm);
            this.Controls.Add(this.botaoC);
            this.Controls.Add(this.botaoSeis);
            this.Controls.Add(this.botaoCinco);
            this.Controls.Add(this.botaoMenos);
            this.Controls.Add(this.botaoQuatro);
            this.Controls.Add(this.botaoCE);
            this.Controls.Add(this.botaoNove);
            this.Controls.Add(this.botaoOito);
            this.Controls.Add(this.labelOperador);
            this.Controls.Add(this.botaoMais);
            this.Controls.Add(this.calcBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FormCalc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minha Calc v.1";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox calcBox;
        private System.Windows.Forms.Button botaoMais;
        private System.Windows.Forms.Label labelOperador;
        private System.Windows.Forms.Button botaoOito;
        private System.Windows.Forms.Button botaoNove;
        private System.Windows.Forms.Button botaoCE;
        private System.Windows.Forms.Button botaoC;
        private System.Windows.Forms.Button botaoSeis;
        private System.Windows.Forms.Button botaoCinco;
        private System.Windows.Forms.Button botaoMenos;
        private System.Windows.Forms.Button botaoQuatro;
        private System.Windows.Forms.Button botaoIgual;
        private System.Windows.Forms.Button botaoTres;
        private System.Windows.Forms.Button botaoDois;
        private System.Windows.Forms.Button botaoVezes;
        private System.Windows.Forms.Button botaoUm;
        private System.Windows.Forms.Button botaoPonto;
        private System.Windows.Forms.Button botaoDividr;
        private System.Windows.Forms.Button botaoZero;
        private System.Windows.Forms.Label labelCopy;
        private System.Windows.Forms.Button botaoSete;
    }
}

