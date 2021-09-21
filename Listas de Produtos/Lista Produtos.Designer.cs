namespace WindowsFormsApplication1
{
    partial class form_Listagem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Listagem));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nomeProduto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdicionaProduto = new System.Windows.Forms.Button();
            this.btnLimpaProduto = new System.Windows.Forms.Button();
            this.btnRemoveProduto = new System.Windows.Forms.Button();
            this.cmb_ListaProdutos = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listagem de produtos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(156, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite o nome de um produto";
            // 
            // nomeProduto
            // 
            this.nomeProduto.Location = new System.Drawing.Point(159, 106);
            this.nomeProduto.Name = "nomeProduto";
            this.nomeProduto.Size = new System.Drawing.Size(181, 20);
            this.nomeProduto.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(151, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Listagem de produtos";
            // 
            // btnAdicionaProduto
            // 
            this.btnAdicionaProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionaProduto.Image")));
            this.btnAdicionaProduto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdicionaProduto.Location = new System.Drawing.Point(154, 149);
            this.btnAdicionaProduto.Name = "btnAdicionaProduto";
            this.btnAdicionaProduto.Size = new System.Drawing.Size(98, 48);
            this.btnAdicionaProduto.TabIndex = 4;
            this.btnAdicionaProduto.Text = "Adicionar";
            this.btnAdicionaProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdicionaProduto.UseVisualStyleBackColor = true;
            this.btnAdicionaProduto.Click += new System.EventHandler(this.btnAdicionaProduto_Click);
            // 
            // btnLimpaProduto
            // 
            this.btnLimpaProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpaProduto.Image")));
            this.btnLimpaProduto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpaProduto.Location = new System.Drawing.Point(258, 149);
            this.btnLimpaProduto.Name = "btnLimpaProduto";
            this.btnLimpaProduto.Size = new System.Drawing.Size(98, 48);
            this.btnLimpaProduto.TabIndex = 5;
            this.btnLimpaProduto.Text = "Limpar";
            this.btnLimpaProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpaProduto.UseVisualStyleBackColor = true;
            this.btnLimpaProduto.Click += new System.EventHandler(this.btnLimpaProduto_Click);
            // 
            // btnRemoveProduto
            // 
            this.btnRemoveProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveProduto.Image")));
            this.btnRemoveProduto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRemoveProduto.Location = new System.Drawing.Point(202, 294);
            this.btnRemoveProduto.Name = "btnRemoveProduto";
            this.btnRemoveProduto.Size = new System.Drawing.Size(98, 48);
            this.btnRemoveProduto.TabIndex = 6;
            this.btnRemoveProduto.Text = "Remover";
            this.btnRemoveProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRemoveProduto.UseVisualStyleBackColor = true;
            this.btnRemoveProduto.Click += new System.EventHandler(this.btnRemoveProduto_Click);
            // 
            // cmb_ListaProdutos
            // 
            this.cmb_ListaProdutos.FormattingEnabled = true;
            this.cmb_ListaProdutos.Location = new System.Drawing.Point(154, 250);
            this.cmb_ListaProdutos.Name = "cmb_ListaProdutos";
            this.cmb_ListaProdutos.Size = new System.Drawing.Size(181, 21);
            this.cmb_ListaProdutos.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(151, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 8;
            this.label4.Visible = false;
            // 
            // form_Listagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 356);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_ListaProdutos);
            this.Controls.Add(this.btnRemoveProduto);
            this.Controls.Add(this.btnLimpaProduto);
            this.Controls.Add(this.btnAdicionaProduto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nomeProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "form_Listagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_Listagem_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nomeProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdicionaProduto;
        private System.Windows.Forms.Button btnLimpaProduto;
        private System.Windows.Forms.Button btnRemoveProduto;
        private System.Windows.Forms.ComboBox cmb_ListaProdutos;
        private System.Windows.Forms.Label label4;
    }
}

