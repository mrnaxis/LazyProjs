namespace checkLog
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbSucesso = new System.Windows.Forms.Label();
            this.btVerificaLog = new System.Windows.Forms.Button();
            this.txDir = new System.Windows.Forms.TextBox();
            this.btDir = new System.Windows.Forms.Button();
            this.lbErros = new System.Windows.Forms.Label();
            this.lbError = new System.Windows.Forms.Label();
            this.lbPorc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbSucesso
            // 
            this.lbSucesso.AutoSize = true;
            this.lbSucesso.Location = new System.Drawing.Point(63, 86);
            this.lbSucesso.Name = "lbSucesso";
            this.lbSucesso.Size = new System.Drawing.Size(0, 13);
            this.lbSucesso.TabIndex = 0;
            // 
            // btVerificaLog
            // 
            this.btVerificaLog.Location = new System.Drawing.Point(420, 76);
            this.btVerificaLog.Name = "btVerificaLog";
            this.btVerificaLog.Size = new System.Drawing.Size(139, 23);
            this.btVerificaLog.TabIndex = 1;
            this.btVerificaLog.Text = "Verificar Logs";
            this.btVerificaLog.UseVisualStyleBackColor = true;
            this.btVerificaLog.Click += new System.EventHandler(this.btVerificaLog_Click);
            // 
            // txDir
            // 
            this.txDir.Location = new System.Drawing.Point(15, 18);
            this.txDir.Name = "txDir";
            this.txDir.Size = new System.Drawing.Size(399, 20);
            this.txDir.TabIndex = 2;
            // 
            // btDir
            // 
            this.btDir.Location = new System.Drawing.Point(420, 16);
            this.btDir.Name = "btDir";
            this.btDir.Size = new System.Drawing.Size(139, 23);
            this.btDir.TabIndex = 3;
            this.btDir.Text = "Selecionar Diretório";
            this.btDir.UseVisualStyleBackColor = true;
            this.btDir.Click += new System.EventHandler(this.btDir_Click);
            // 
            // lbErros
            // 
            this.lbErros.AutoSize = true;
            this.lbErros.Location = new System.Drawing.Point(183, 86);
            this.lbErros.Name = "lbErros";
            this.lbErros.Size = new System.Drawing.Size(0, 13);
            this.lbErros.TabIndex = 4;
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.Location = new System.Drawing.Point(12, 41);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(107, 13);
            this.lbError.TabIndex = 5;
            this.lbError.Text = "Basic Mistakes Here!";
            // 
            // lbPorc
            // 
            this.lbPorc.AutoSize = true;
            this.lbPorc.Location = new System.Drawing.Point(342, 86);
            this.lbPorc.Name = "lbPorc";
            this.lbPorc.Size = new System.Drawing.Size(0, 13);
            this.lbPorc.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sucessos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Erros:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Porcentagem Acertos:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 113);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbPorc);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.lbErros);
            this.Controls.Add(this.btDir);
            this.Controls.Add(this.txDir);
            this.Controls.Add(this.btVerificaLog);
            this.Controls.Add(this.lbSucesso);
            this.Name = "Form1";
            this.Text = "Check Logs for Lazy People";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSucesso;
        private System.Windows.Forms.Button btVerificaLog;
        private System.Windows.Forms.TextBox txDir;
        private System.Windows.Forms.Button btDir;
        private System.Windows.Forms.Label lbErros;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.Label lbPorc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

