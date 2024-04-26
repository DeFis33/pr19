namespace PR19
{
    partial class Project
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вычислитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.программаРасчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMath = new System.Windows.Forms.Button();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.variable3 = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.groupBoxDate = new System.Windows.Forms.GroupBox();
            this.variable2 = new System.Windows.Forms.Label();
            this.variable1 = new System.Windows.Forms.Label();
            this.textBoxDate2 = new System.Windows.Forms.TextBox();
            this.textBoxDate1 = new System.Windows.Forms.TextBox();
            this.groupBoxTask = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.condition = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxResult.SuspendLayout();
            this.groupBoxDate.SuspendLayout();
            this.groupBoxTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(502, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вычислитьToolStripMenuItem,
            this.очиститьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // вычислитьToolStripMenuItem
            // 
            this.вычислитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.программаРасчетыToolStripMenuItem});
            this.вычислитьToolStripMenuItem.Name = "вычислитьToolStripMenuItem";
            this.вычислитьToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.вычислитьToolStripMenuItem.Text = "Вычислить";
            // 
            // программаРасчетыToolStripMenuItem
            // 
            this.программаРасчетыToolStripMenuItem.Name = "программаРасчетыToolStripMenuItem";
            this.программаРасчетыToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.программаРасчетыToolStripMenuItem.Text = "Программа \"Расчеты\"";
            this.программаРасчетыToolStripMenuItem.Click += new System.EventHandler(this.программаРасчетыToolStripMenuItem_Click);
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnClose);
            this.tabPage1.Controls.Add(this.btnMath);
            this.tabPage1.Controls.Add(this.groupBoxResult);
            this.tabPage1.Controls.Add(this.groupBoxDate);
            this.tabPage1.Controls.Add(this.groupBoxTask);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(492, 387);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Расчеты";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.Location = new System.Drawing.Point(324, 313);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(95, 46);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Выход";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMath
            // 
            this.btnMath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMath.Location = new System.Drawing.Point(82, 313);
            this.btnMath.Margin = new System.Windows.Forms.Padding(2);
            this.btnMath.Name = "btnMath";
            this.btnMath.Size = new System.Drawing.Size(95, 46);
            this.btnMath.TabIndex = 3;
            this.btnMath.Text = "Вычислить";
            this.btnMath.UseVisualStyleBackColor = true;
            this.btnMath.Click += new System.EventHandler(this.btnMath_Click);
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxResult.Controls.Add(this.variable3);
            this.groupBoxResult.Controls.Add(this.textBoxResult);
            this.groupBoxResult.Location = new System.Drawing.Point(266, 167);
            this.groupBoxResult.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxResult.Size = new System.Drawing.Size(222, 124);
            this.groupBoxResult.TabIndex = 2;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Результат:";
            // 
            // variable3
            // 
            this.variable3.AutoSize = true;
            this.variable3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.variable3.Location = new System.Drawing.Point(44, 56);
            this.variable3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.variable3.Name = "variable3";
            this.variable3.Size = new System.Drawing.Size(32, 17);
            this.variable3.TabIndex = 3;
            this.variable3.Text = "Y =";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(76, 56);
            this.textBoxResult.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(108, 20);
            this.textBoxResult.TabIndex = 2;
            // 
            // groupBoxDate
            // 
            this.groupBoxDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDate.Controls.Add(this.variable2);
            this.groupBoxDate.Controls.Add(this.variable1);
            this.groupBoxDate.Controls.Add(this.textBoxDate2);
            this.groupBoxDate.Controls.Add(this.textBoxDate1);
            this.groupBoxDate.Location = new System.Drawing.Point(6, 167);
            this.groupBoxDate.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxDate.Name = "groupBoxDate";
            this.groupBoxDate.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxDate.Size = new System.Drawing.Size(222, 124);
            this.groupBoxDate.TabIndex = 1;
            this.groupBoxDate.TabStop = false;
            this.groupBoxDate.Text = "Исходные данные:";
            // 
            // variable2
            // 
            this.variable2.AutoSize = true;
            this.variable2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.variable2.Location = new System.Drawing.Point(44, 80);
            this.variable2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.variable2.Name = "variable2";
            this.variable2.Size = new System.Drawing.Size(30, 17);
            this.variable2.TabIndex = 2;
            this.variable2.Text = "z =";
            // 
            // variable1
            // 
            this.variable1.AutoSize = true;
            this.variable1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.variable1.Location = new System.Drawing.Point(45, 37);
            this.variable1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.variable1.Name = "variable1";
            this.variable1.Size = new System.Drawing.Size(29, 17);
            this.variable1.TabIndex = 1;
            this.variable1.Text = "x =";
            // 
            // textBoxDate2
            // 
            this.textBoxDate2.Location = new System.Drawing.Point(76, 80);
            this.textBoxDate2.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDate2.Name = "textBoxDate2";
            this.textBoxDate2.Size = new System.Drawing.Size(108, 20);
            this.textBoxDate2.TabIndex = 1;
            this.toolTip1.SetToolTip(this.textBoxDate2, "Введите число");
            // 
            // textBoxDate1
            // 
            this.textBoxDate1.Location = new System.Drawing.Point(76, 37);
            this.textBoxDate1.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDate1.Name = "textBoxDate1";
            this.textBoxDate1.Size = new System.Drawing.Size(108, 20);
            this.textBoxDate1.TabIndex = 0;
            this.toolTip1.SetToolTip(this.textBoxDate1, "Введите число");
            // 
            // groupBoxTask
            // 
            this.groupBoxTask.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTask.Controls.Add(this.pictureBox1);
            this.groupBoxTask.Controls.Add(this.condition);
            this.groupBoxTask.Location = new System.Drawing.Point(6, 12);
            this.groupBoxTask.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxTask.Name = "groupBoxTask";
            this.groupBoxTask.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxTask.Size = new System.Drawing.Size(482, 150);
            this.groupBoxTask.TabIndex = 0;
            this.groupBoxTask.TabStop = false;
            this.groupBoxTask.Text = "Задание:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::PR19.Properties.Resources._123;
            this.pictureBox1.Location = new System.Drawing.Point(105, 42);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(274, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // condition
            // 
            this.condition.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.condition.AutoSize = true;
            this.condition.Location = new System.Drawing.Point(100, 24);
            this.condition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.condition.Name = "condition";
            this.condition.Size = new System.Drawing.Size(291, 13);
            this.condition.TabIndex = 0;
            this.condition.Text = "Рассчитать значение выражения при исходных данных:";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 57);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(500, 413);
            this.tabControl1.TabIndex = 1;
            // 
            // Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 475);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(518, 514);
            this.MinimumSize = new System.Drawing.Size(518, 514);
            this.Name = "Project";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мое приложение";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBoxResult.ResumeLayout(false);
            this.groupBoxResult.PerformLayout();
            this.groupBoxDate.ResumeLayout(false);
            this.groupBoxDate.PerformLayout();
            this.groupBoxTask.ResumeLayout(false);
            this.groupBoxTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вычислитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem программаРасчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.GroupBox groupBoxDate;
        private System.Windows.Forms.GroupBox groupBoxTask;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label variable3;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label variable2;
        private System.Windows.Forms.Label variable1;
        private System.Windows.Forms.TextBox textBoxDate2;
        private System.Windows.Forms.TextBox textBoxDate1;
        private System.Windows.Forms.Label condition;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMath;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

