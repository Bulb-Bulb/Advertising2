namespace Advertising2
{
    partial class FormMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOpenOrg = new System.Windows.Forms.Button();
            this.buttonOpenNP = new System.Windows.Forms.Button();
            this.buttonOpenAdv = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpenOrg
            // 
            this.buttonOpenOrg.BackColor = System.Drawing.Color.Aqua;
            this.buttonOpenOrg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOpenOrg.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenOrg.ForeColor = System.Drawing.Color.Black;
            this.buttonOpenOrg.Location = new System.Drawing.Point(12, 147);
            this.buttonOpenOrg.Name = "buttonOpenOrg";
            this.buttonOpenOrg.Size = new System.Drawing.Size(280, 36);
            this.buttonOpenOrg.TabIndex = 2;
            this.buttonOpenOrg.Text = "Организации";
            this.buttonOpenOrg.UseVisualStyleBackColor = false;
            // 
            // buttonOpenNP
            // 
            this.buttonOpenNP.BackColor = System.Drawing.Color.Aqua;
            this.buttonOpenNP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOpenNP.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenNP.ForeColor = System.Drawing.Color.Black;
            this.buttonOpenNP.Location = new System.Drawing.Point(12, 207);
            this.buttonOpenNP.Name = "buttonOpenNP";
            this.buttonOpenNP.Size = new System.Drawing.Size(280, 36);
            this.buttonOpenNP.TabIndex = 3;
            this.buttonOpenNP.Text = "Газеты";
            this.buttonOpenNP.UseVisualStyleBackColor = false;
            // 
            // buttonOpenAdv
            // 
            this.buttonOpenAdv.BackColor = System.Drawing.Color.Aqua;
            this.buttonOpenAdv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOpenAdv.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenAdv.ForeColor = System.Drawing.Color.Black;
            this.buttonOpenAdv.Location = new System.Drawing.Point(12, 265);
            this.buttonOpenAdv.Name = "buttonOpenAdv";
            this.buttonOpenAdv.Size = new System.Drawing.Size(280, 36);
            this.buttonOpenAdv.TabIndex = 4;
            this.buttonOpenAdv.Text = "Реклама";
            this.buttonOpenAdv.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 109);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(304, 331);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonOpenAdv);
            this.Controls.Add(this.buttonOpenNP);
            this.Controls.Add(this.buttonOpenOrg);
            this.MaximumSize = new System.Drawing.Size(320, 370);
            this.MinimumSize = new System.Drawing.Size(320, 370);
            this.Name = "FormMenu";
            this.Text = "Меню";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenOrg;
        private System.Windows.Forms.Button buttonOpenNP;
        private System.Windows.Forms.Button buttonOpenAdv;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

