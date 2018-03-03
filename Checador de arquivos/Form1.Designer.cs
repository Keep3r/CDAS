namespace Checador_de_arquivos
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chckB_DeleteNullFiles = new System.Windows.Forms.CheckBox();
            this.lb_Files = new System.Windows.Forms.Label();
            this.lb_NullFiles = new System.Windows.Forms.Label();
            this.txtB_Path = new System.Windows.Forms.TextBox();
            this.bt_Start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of files: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of null files: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Delete null files?";
            // 
            // chckB_DeleteNullFiles
            // 
            this.chckB_DeleteNullFiles.AutoSize = true;
            this.chckB_DeleteNullFiles.Location = new System.Drawing.Point(16, 247);
            this.chckB_DeleteNullFiles.Name = "chckB_DeleteNullFiles";
            this.chckB_DeleteNullFiles.Size = new System.Drawing.Size(44, 17);
            this.chckB_DeleteNullFiles.TabIndex = 4;
            this.chckB_DeleteNullFiles.Text = "Yes";
            this.chckB_DeleteNullFiles.UseVisualStyleBackColor = true;
            // 
            // lb_Files
            // 
            this.lb_Files.AutoSize = true;
            this.lb_Files.Location = new System.Drawing.Point(102, 96);
            this.lb_Files.Name = "lb_Files";
            this.lb_Files.Size = new System.Drawing.Size(0, 13);
            this.lb_Files.TabIndex = 5;
            // 
            // lb_NullFiles
            // 
            this.lb_NullFiles.AutoSize = true;
            this.lb_NullFiles.Location = new System.Drawing.Point(121, 158);
            this.lb_NullFiles.Name = "lb_NullFiles";
            this.lb_NullFiles.Size = new System.Drawing.Size(0, 13);
            this.lb_NullFiles.TabIndex = 6;
            // 
            // txtB_Path
            // 
            this.txtB_Path.Location = new System.Drawing.Point(51, 28);
            this.txtB_Path.Name = "txtB_Path";
            this.txtB_Path.Size = new System.Drawing.Size(158, 20);
            this.txtB_Path.TabIndex = 7;
            this.txtB_Path.Text = "C:\\Users\\";
            this.txtB_Path.TextChanged += new System.EventHandler(this.txtB_Path_TextChanged);
            // 
            // bt_Start
            // 
            this.bt_Start.Location = new System.Drawing.Point(297, 247);
            this.bt_Start.Name = "bt_Start";
            this.bt_Start.Size = new System.Drawing.Size(75, 23);
            this.bt_Start.TabIndex = 8;
            this.bt_Start.Text = "Start";
            this.bt_Start.UseVisualStyleBackColor = true;
            this.bt_Start.Click += new System.EventHandler(this.bt_Start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 295);
            this.Controls.Add(this.bt_Start);
            this.Controls.Add(this.txtB_Path);
            this.Controls.Add(this.lb_NullFiles);
            this.Controls.Add(this.lb_Files);
            this.Controls.Add(this.chckB_DeleteNullFiles);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chckB_DeleteNullFiles;
        private System.Windows.Forms.Label lb_Files;
        private System.Windows.Forms.Label lb_NullFiles;
        private System.Windows.Forms.TextBox txtB_Path;
        private System.Windows.Forms.Button bt_Start;
    }
}

