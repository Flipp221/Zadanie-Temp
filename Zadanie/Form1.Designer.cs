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
            this.Text_Box2 = new System.Windows.Forms.TextBox();
            this.box_label3 = new System.Windows.Forms.Label();
            this.text_box3 = new System.Windows.Forms.TextBox();
            this.box_label4 = new System.Windows.Forms.Label();
            this.text_box4 = new System.Windows.Forms.TextBox();
            this.box_label5 = new System.Windows.Forms.Label();
            this.text_box6 = new System.Windows.Forms.TextBox();
            this.text_box5 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // Text_Box2
            // 
            this.Text_Box2.Location = new System.Drawing.Point(206, 99);
            this.Text_Box2.Name = "Text_Box2";
            this.Text_Box2.Size = new System.Drawing.Size(100, 20);
            this.Text_Box2.TabIndex = 3;
            this.Text_Box2.Text = "5";
            this.Text_Box2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
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
            // text_box3
            // 
            this.text_box3.Location = new System.Drawing.Point(206, 35);
            this.text_box3.Name = "text_box3";
            this.text_box3.Size = new System.Drawing.Size(100, 20);
            this.text_box3.TabIndex = 6;
            this.text_box3.Text = "-3";
            this.text_box3.TextChanged += new System.EventHandler(this.text_box3_TextChanged);
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(312, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(438, 339);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.text_box5);
            this.Controls.Add(this.text_box6);
            this.Controls.Add(this.box_label5);
            this.Controls.Add(this.text_box4);
            this.Controls.Add(this.box_label4);
            this.Controls.Add(this.text_box3);
            this.Controls.Add(this.box_label3);
            this.Controls.Add(this.Text_Box2);
            this.Controls.Add(this.Box_Label2);
            this.Controls.Add(this.Text_Box);
            this.Controls.Add(this.box_label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label box_label1;
        private System.Windows.Forms.TextBox Text_Box;
        private System.Windows.Forms.Label Box_Label2;
        private System.Windows.Forms.TextBox Text_Box2;
        private System.Windows.Forms.Label box_label3;
        private System.Windows.Forms.TextBox text_box3;
        private System.Windows.Forms.Label box_label4;
        private System.Windows.Forms.TextBox text_box4;
        private System.Windows.Forms.Label box_label5;
        private System.Windows.Forms.TextBox text_box6;
        private System.Windows.Forms.TextBox text_box5;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

