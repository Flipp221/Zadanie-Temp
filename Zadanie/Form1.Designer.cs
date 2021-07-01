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
            this.box_label1 = new System.Windows.Forms.Label();
            this.Text_Box = new System.Windows.Forms.TextBox();
            this.Box_Label2 = new System.Windows.Forms.Label();
            this.tbMax = new System.Windows.Forms.TextBox();
            this.box_label3 = new System.Windows.Forms.Label();
            this.tbMin = new System.Windows.Forms.TextBox();
            this.box_label4 = new System.Windows.Forms.Label();
            this.text_box4 = new System.Windows.Forms.TextBox();
            this.box_label5 = new System.Windows.Forms.Label();
            this.text_box6 = new System.Windows.Forms.TextBox();
            this.text_box5 = new System.Windows.Forms.TextBox();
            this.dtnTable = new System.Windows.Forms.DataGridView();
            this.result = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtnTable)).BeginInit();
            this.SuspendLayout();
            // 
            // box_label1
            // 
            this.box_label1.AutoSize = true;
            this.box_label1.Location = new System.Drawing.Point(71, 19);
            this.box_label1.Name = "box_label1";
            this.box_label1.Size = new System.Drawing.Size(57, 13);
            this.box_label1.TabIndex = 0;
            this.box_label1.Text = "Вид рыбы";
            this.box_label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Text_Box
            // 
            this.Text_Box.Location = new System.Drawing.Point(50, 35);
            this.Text_Box.Name = "Text_Box";
            this.Text_Box.Size = new System.Drawing.Size(100, 20);
            this.Text_Box.TabIndex = 1;
            this.Text_Box.Text = "Минтай";
            this.Text_Box.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Box_Label2
            // 
            this.Box_Label2.AutoSize = true;
            this.Box_Label2.Location = new System.Drawing.Point(242, 83);
            this.Box_Label2.Name = "Box_Label2";
            this.Box_Label2.Size = new System.Drawing.Size(37, 13);
            this.Box_Label2.TabIndex = 2;
            this.Box_Label2.Text = "Max C";
            this.Box_Label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbMax
            // 
            this.tbMax.Location = new System.Drawing.Point(206, 99);
            this.tbMax.Name = "tbMax";
            this.tbMax.Size = new System.Drawing.Size(100, 20);
            this.tbMax.TabIndex = 3;
            this.tbMax.Text = "5";
            this.tbMax.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // box_label3
            // 
            this.box_label3.AutoSize = true;
            this.box_label3.Location = new System.Drawing.Point(242, 19);
            this.box_label3.Name = "box_label3";
            this.box_label3.Size = new System.Drawing.Size(34, 13);
            this.box_label3.TabIndex = 5;
            this.box_label3.Text = "Min C";
            this.box_label3.Click += new System.EventHandler(this.box_label3_Click);
            // 
            // tbMin
            // 
            this.tbMin.Location = new System.Drawing.Point(206, 35);
            this.tbMin.Name = "tbMin";
            this.tbMin.Size = new System.Drawing.Size(100, 20);
            this.tbMin.TabIndex = 6;
            this.tbMin.Text = "-3";
            this.tbMin.TextChanged += new System.EventHandler(this.text_box3_TextChanged);
            // 
            // box_label4
            // 
            this.box_label4.AutoSize = true;
            this.box_label4.Location = new System.Drawing.Point(476, 19);
            this.box_label4.Name = "box_label4";
            this.box_label4.Size = new System.Drawing.Size(74, 13);
            this.box_label4.TabIndex = 7;
            this.box_label4.Text = "Температура";
            this.box_label4.Click += new System.EventHandler(this.box_label4_Click);
            // 
            // text_box4
            // 
            this.text_box4.Location = new System.Drawing.Point(465, 35);
            this.text_box4.Name = "text_box4";
            this.text_box4.Size = new System.Drawing.Size(100, 20);
            this.text_box4.TabIndex = 8;
            this.text_box4.TextChanged += new System.EventHandler(this.text_box4_TextChanged);
            // 
            // box_label5
            // 
            this.box_label5.AutoSize = true;
            this.box_label5.Location = new System.Drawing.Point(83, 236);
            this.box_label5.Name = "box_label5";
            this.box_label5.Size = new System.Drawing.Size(30, 13);
            this.box_label5.TabIndex = 9;
            this.box_label5.Text = "Time";
            this.box_label5.Click += new System.EventHandler(this.box_label5_Click);
            // 
            // text_box6
            // 
            this.text_box6.Location = new System.Drawing.Point(50, 329);
            this.text_box6.Name = "text_box6";
            this.text_box6.Size = new System.Drawing.Size(100, 20);
            this.text_box6.TabIndex = 10;
            this.text_box6.Text = "60";
            this.text_box6.TextChanged += new System.EventHandler(this.text_box6_TextChanged);
            // 
            // text_box5
            // 
            this.text_box5.Location = new System.Drawing.Point(50, 272);
            this.text_box5.Name = "text_box5";
            this.text_box5.Size = new System.Drawing.Size(100, 20);
            this.text_box5.TabIndex = 11;
            this.text_box5.Text = "20";
            this.text_box5.TextChanged += new System.EventHandler(this.text_box5_TextChanged);
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
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(50, 164);
            this.maskedTextBox1.Mask = "00/00/0000 90:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 15;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Дата";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.result);
            this.Controls.Add(this.dtnTable);
            this.Controls.Add(this.text_box5);
            this.Controls.Add(this.text_box6);
            this.Controls.Add(this.box_label5);
            this.Controls.Add(this.text_box4);
            this.Controls.Add(this.box_label4);
            this.Controls.Add(this.tbMin);
            this.Controls.Add(this.box_label3);
            this.Controls.Add(this.tbMax);
            this.Controls.Add(this.Box_Label2);
            this.Controls.Add(this.Text_Box);
            this.Controls.Add(this.box_label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtnTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label box_label1;
        private System.Windows.Forms.TextBox Text_Box;
        private System.Windows.Forms.Label Box_Label2;
        private System.Windows.Forms.TextBox tbMax;
        private System.Windows.Forms.Label box_label3;
        private System.Windows.Forms.TextBox tbMin;
        private System.Windows.Forms.Label box_label4;
        private System.Windows.Forms.TextBox text_box4;
        private System.Windows.Forms.Label box_label5;
        private System.Windows.Forms.TextBox text_box6;
        private System.Windows.Forms.TextBox text_box5;
        private System.Windows.Forms.DataGridView dtnTable;
        private System.Windows.Forms.Button result;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

