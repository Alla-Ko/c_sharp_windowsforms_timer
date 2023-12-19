namespace WindowsFormsApp_timer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_h = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_m = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_s = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button_start = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_pause = new System.Windows.Forms.Button();
            this.button_continue = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_h)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_m)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_s)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(43, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(585, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Години     Хвилини     Секунди";
            // 
            // numericUpDown_h
            // 
            this.numericUpDown_h.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_h.Location = new System.Drawing.Point(38, 85);
            this.numericUpDown_h.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDown_h.Name = "numericUpDown_h";
            this.numericUpDown_h.Size = new System.Drawing.Size(157, 128);
            this.numericUpDown_h.TabIndex = 1;
            this.numericUpDown_h.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_h.Enter += new System.EventHandler(this.numericUpDown_h_Enter);
            // 
            // numericUpDown_m
            // 
            this.numericUpDown_m.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_m.Location = new System.Drawing.Point(250, 85);
            this.numericUpDown_m.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDown_m.Name = "numericUpDown_m";
            this.numericUpDown_m.Size = new System.Drawing.Size(157, 128);
            this.numericUpDown_m.TabIndex = 2;
            this.numericUpDown_m.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_m.Enter += new System.EventHandler(this.numericUpDown_m_Enter);
            // 
            // numericUpDown_s
            // 
            this.numericUpDown_s.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_s.Location = new System.Drawing.Point(458, 85);
            this.numericUpDown_s.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDown_s.Name = "numericUpDown_s";
            this.numericUpDown_s.Size = new System.Drawing.Size(157, 128);
            this.numericUpDown_s.TabIndex = 3;
            this.numericUpDown_s.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_s.Enter += new System.EventHandler(this.numericUpDown_s_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(187, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 120);
            this.label2.TabIndex = 4;
            this.label2.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(397, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 120);
            this.label3.TabIndex = 5;
            this.label3.Text = ":";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.flowLayoutPanel1.Controls.Add(this.button_start);
            this.flowLayoutPanel1.Controls.Add(this.button_delete);
            this.flowLayoutPanel1.Controls.Add(this.button_pause);
            this.flowLayoutPanel1.Controls.Add(this.button_continue);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(38, 235);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(577, 145);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // button_start
            // 
            this.button_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_start.Location = new System.Drawing.Point(3, 3);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(574, 40);
            this.button_start.TabIndex = 4;
            this.button_start.Text = "Запустити";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_delete
            // 
            this.button_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_delete.Location = new System.Drawing.Point(3, 49);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(279, 40);
            this.button_delete.TabIndex = 5;
            this.button_delete.Text = "Видалити";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_pause
            // 
            this.button_pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_pause.Location = new System.Drawing.Point(288, 49);
            this.button_pause.Name = "button_pause";
            this.button_pause.Size = new System.Drawing.Size(279, 40);
            this.button_pause.TabIndex = 6;
            this.button_pause.Text = "Пауза";
            this.button_pause.UseVisualStyleBackColor = true;
            this.button_pause.Click += new System.EventHandler(this.button_pause_Click);
            // 
            // button_continue
            // 
            this.button_continue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_continue.Location = new System.Drawing.Point(3, 95);
            this.button_continue.Name = "button_continue";
            this.button_continue.Size = new System.Drawing.Size(279, 40);
            this.button_continue.TabIndex = 7;
            this.button_continue.Text = "Продовжити";
            this.button_continue.UseVisualStyleBackColor = true;
            this.button_continue.Click += new System.EventHandler(this.button_continue_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 305);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.numericUpDown_s);
            this.Controls.Add(this.numericUpDown_m);
            this.Controls.Add(this.numericUpDown_h);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(681, 344);
            this.MinimumSize = new System.Drawing.Size(681, 344);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timer";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_h)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_m)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_s)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_h;
        private System.Windows.Forms.NumericUpDown numericUpDown_m;
        private System.Windows.Forms.NumericUpDown numericUpDown_s;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_pause;
        private System.Windows.Forms.Button button_continue;
    }
}

