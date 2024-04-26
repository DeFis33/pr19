namespace PR19
{
    partial class Info
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
            this.title = new System.Windows.Forms.Label();
            this.developer = new System.Windows.Forms.Label();
            this.specialization = new System.Windows.Forms.Label();
            this.vk = new System.Windows.Forms.Label();
            this.vkLink = new System.Windows.Forms.LinkLabel();
            this.btnBack = new System.Windows.Forms.Button();
            this.image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.Location = new System.Drawing.Point(93, 65);
            this.title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(311, 24);
            this.title.TabIndex = 0;
            this.title.Text = "Программа \"Мое приложение\"";
            // 
            // developer
            // 
            this.developer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.developer.AutoSize = true;
            this.developer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.developer.Location = new System.Drawing.Point(28, 128);
            this.developer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.developer.Name = "developer";
            this.developer.Size = new System.Drawing.Size(168, 17);
            this.developer.TabIndex = 1;
            this.developer.Text = "Разработал: Пирогов Д.";
            // 
            // specialization
            // 
            this.specialization.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.specialization.AutoSize = true;
            this.specialization.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.specialization.Location = new System.Drawing.Point(24, 176);
            this.specialization.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.specialization.Name = "specialization";
            this.specialization.Size = new System.Drawing.Size(439, 17);
            this.specialization.TabIndex = 2;
            this.specialization.Text = "Специальность: Информационные системы и программирование";
            // 
            // vk
            // 
            this.vk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.vk.AutoSize = true;
            this.vk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vk.Location = new System.Drawing.Point(28, 221);
            this.vk.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vk.Name = "vk";
            this.vk.Size = new System.Drawing.Size(30, 17);
            this.vk.TabIndex = 3;
            this.vk.Text = "VK:";
            // 
            // vkLink
            // 
            this.vkLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.vkLink.AutoSize = true;
            this.vkLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vkLink.Location = new System.Drawing.Point(62, 221);
            this.vkLink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vkLink.Name = "vkLink";
            this.vkLink.Size = new System.Drawing.Size(160, 17);
            this.vkLink.TabIndex = 4;
            this.vkLink.TabStop = true;
            this.vkLink.Text = "https://vk.com/nee_gear";
            this.vkLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.emailLink_LinkClicked);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.Location = new System.Drawing.Point(82, 343);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 48);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // image
            // 
            this.image.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.image.Image = global::PR19.Properties.Resources._479_4793466_netbook_hd_png_download;
            this.image.Location = new System.Drawing.Point(288, 258);
            this.image.Margin = new System.Windows.Forms.Padding(2);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(175, 145);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image.TabIndex = 6;
            this.image.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 432);
            this.Controls.Add(this.image);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.vkLink);
            this.Controls.Add(this.vk);
            this.Controls.Add(this.specialization);
            this.Controls.Add(this.developer);
            this.Controls.Add(this.title);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(522, 471);
            this.MinimumSize = new System.Drawing.Size(522, 471);
            this.Name = "Form2";
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label developer;
        private System.Windows.Forms.Label specialization;
        private System.Windows.Forms.Label vk;
        private System.Windows.Forms.LinkLabel vkLink;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox image;
    }
}