namespace Zadanie
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
            this.bl1 = new System.Windows.Forms.Label();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.bl2 = new System.Windows.Forms.Label();
            this.tbMax = new System.Windows.Forms.TextBox();
            this.bl3 = new System.Windows.Forms.Label();
            this.tbMin = new System.Windows.Forms.TextBox();
            this.bl4 = new System.Windows.Forms.Label();
            this.tb4 = new System.Windows.Forms.TextBox();
            this.bl5 = new System.Windows.Forms.Label();
            this.tb6 = new System.Windows.Forms.TextBox();
            this.tb5 = new System.Windows.Forms.TextBox();
            this.dtnTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.result = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.mtb1 = new System.Windows.Forms.MaskedTextBox();
            this.bl6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtnTable)).BeginInit();
            this.SuspendLayout();
            // 
            // bl1
            // 
            this.bl1.AutoSize = true;
            this.bl1.Location = new System.Drawing.Point(71, 19);
            this.bl1.Name = "bl1";
            this.bl1.Size = new System.Drawing.Size(57, 13);
            this.bl1.TabIndex = 0;
            this.bl1.Text = "Вид рыбы";
            this.bl1.Click += new System.EventHandler(this.bl1_Click);
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(50, 35);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(100, 20);
            this.tb1.TabIndex = 1;
            this.tb1.Text = "Минтай";
            this.tb1.TextChanged += new System.EventHandler(this.tb1_TextChanged);
            // 
            // bl2
            // 
            this.bl2.AutoSize = true;
            this.bl2.Location = new System.Drawing.Point(242, 83);
            this.bl2.Name = "bl2";
            this.bl2.Size = new System.Drawing.Size(37, 13);
            this.bl2.TabIndex = 2;
            this.bl2.Text = "Max C";
            this.bl2.Click += new System.EventHandler(this.bl2_Click);
            // 
            // tbMax
            // 
            this.tbMax.Location = new System.Drawing.Point(206, 99);
            this.tbMax.Name = "tbMax";
            this.tbMax.Size = new System.Drawing.Size(100, 20);
            this.tbMax.TabIndex = 3;
            this.tbMax.Text = "5";
            this.tbMax.TextChanged += new System.EventHandler(this.tbMax_TextChanged);
            // 
            // bl3
            // 
            this.bl3.AutoSize = true;
            this.bl3.Location = new System.Drawing.Point(242, 19);
            this.bl3.Name = "bl3";
            this.bl3.Size = new System.Drawing.Size(34, 13);
            this.bl3.TabIndex = 5;
            this.bl3.Text = "Min C";
            this.bl3.Click += new System.EventHandler(this.bl3_Click);
            // 
            // tbMin
            // 
            this.tbMin.Location = new System.Drawing.Point(206, 35);
            this.tbMin.Name = "tbMin";
            this.tbMin.Size = new System.Drawing.Size(100, 20);
            this.tbMin.TabIndex = 6;
            this.tbMin.Text = "-3";
            this.tbMin.TextChanged += new System.EventHandler(this.tbMin_TextChanged);
            // 
            // bl4
            // 
            this.bl4.AutoSize = true;
            this.bl4.Location = new System.Drawing.Point(476, 19);
            this.bl4.Name = "bl4";
            this.bl4.Size = new System.Drawing.Size(74, 13);
            this.bl4.TabIndex = 7;
            this.bl4.Text = "Температура";
            this.bl4.Click += new System.EventHandler(this.bl4_Click);
            // 
            // tb4
            // 
            this.tb4.Location = new System.Drawing.Point(465, 35);
            this.tb4.Name = "tb4";
            this.tb4.Size = new System.Drawing.Size(100, 20);
            this.tb4.TabIndex = 8;
            this.tb4.TextChanged += new System.EventHandler(this.tb4_TextChanged);
            // 
            // bl5
            // 
            this.bl5.AutoSize = true;
            this.bl5.Location = new System.Drawing.Point(83, 236);
            this.bl5.Name = "bl5";
            this.bl5.Size = new System.Drawing.Size(30, 13);
            this.bl5.TabIndex = 9;
            this.bl5.Text = "Time";
            this.bl5.Click += new System.EventHandler(this.bl5_Click);
            // 
            // tb6
            // 
            this.tb6.Location = new System.Drawing.Point(50, 329);
            this.tb6.Name = "tb6";
            this.tb6.Size = new System.Drawing.Size(100, 20);
            this.tb6.TabIndex = 10;
            this.tb6.Text = "60";
            this.tb6.TextChanged += new System.EventHandler(this.tb6_TextChanged);
            // 
            // tb5
            // 
            this.tb5.Location = new System.Drawing.Point(50, 272);
            this.tb5.Name = "tb5";
            this.tb5.Size = new System.Drawing.Size(100, 20);
            this.tb5.TabIndex = 11;
            this.tb5.Text = "20";
            this.tb5.TextChanged += new System.EventHandler(this.tb5_TextChanged);
            // 
            // dtnTable
            // 
            this.dtnTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtnTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dtnTable.Location = new System.Drawing.Point(328, 99);
            this.dtnTable.Name = "dtnTable";
            this.dtnTable.Size = new System.Drawing.Size(438, 339);
            this.dtnTable.TabIndex = 12;
            this.dtnTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Время";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Факт";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Норма";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Отклонение от нормы";
            this.Column4.Name = "Column4";
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(621, 32);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(75, 23);
            this.result.TabIndex = 13;
            this.result.Text = "Вывести";
            this.result.UseVisualStyleBackColor = true;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(713, 32);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 14;
            this.clear.Text = "Отчистить";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // mtb1
            // 
            this.mtb1.Location = new System.Drawing.Point(50, 164);
            this.mtb1.Mask = "00/00/0000 90:00";
            this.mtb1.Name = "mtb1";
            this.mtb1.Size = new System.Drawing.Size(100, 20);
            this.mtb1.TabIndex = 15;
            this.mtb1.ValidatingType = typeof(System.DateTime);
            this.mtb1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // bl6
            // 
            this.bl6.AutoSize = true;
            this.bl6.Location = new System.Drawing.Point(71, 148);
            this.bl6.Name = "bl6";
            this.bl6.Size = new System.Drawing.Size(33, 13);
            this.bl6.TabIndex = 16;
            this.bl6.Text = "Дата";
            this.bl6.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bl6);
            this.Controls.Add(this.mtb1);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.result);
            this.Controls.Add(this.dtnTable);
            this.Controls.Add(this.tb5);
            this.Controls.Add(this.tb6);
            this.Controls.Add(this.bl5);
            this.Controls.Add(this.tb4);
            this.Controls.Add(this.bl4);
            this.Controls.Add(this.tbMin);
            this.Controls.Add(this.bl3);
            this.Controls.Add(this.tbMax);
            this.Controls.Add(this.bl2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.bl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtnTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bl1;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Label bl2;
        private System.Windows.Forms.TextBox tbMax;
        private System.Windows.Forms.Label bl3;
        private System.Windows.Forms.TextBox tbMin;
        private System.Windows.Forms.Label bl4;
        private System.Windows.Forms.TextBox tb4;
        private System.Windows.Forms.Label bl5;
        private System.Windows.Forms.TextBox tb6;
        private System.Windows.Forms.TextBox tb5;
        private System.Windows.Forms.DataGridView dtnTable;
        private System.Windows.Forms.Button result;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.MaskedTextBox mtb1;
        private System.Windows.Forms.Label bl6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

