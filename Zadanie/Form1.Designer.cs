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
            this.Box_label = new System.Windows.Forms.Label();
            this.Text_Box = new System.Windows.Forms.TextBox();
            this.Box_Label2 = new System.Windows.Forms.Label();
            this.Text_Box2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Box_label
            // 
            this.Box_label.AutoSize = true;
            this.Box_label.Location = new System.Drawing.Point(71, 19);
            this.Box_label.Name = "Box_label";
            this.Box_label.Size = new System.Drawing.Size(57, 13);
            this.Box_label.TabIndex = 0;
            this.Box_label.Text = "Вид рыбы";
            this.Box_label.Click += new System.EventHandler(this.label1_Click);
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
            this.Box_Label2.Location = new System.Drawing.Point(80, 81);
            this.Box_Label2.Name = "Box_Label2";
            this.Box_Label2.Size = new System.Drawing.Size(37, 13);
            this.Box_Label2.TabIndex = 2;
            this.Box_Label2.Text = "Max C";
            this.Box_Label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Text_Box2
            // 
            this.Text_Box2.Location = new System.Drawing.Point(50, 97);
            this.Text_Box2.Name = "Text_Box2";
            this.Text_Box2.Size = new System.Drawing.Size(100, 20);
            this.Text_Box2.TabIndex = 3;
            this.Text_Box2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(339, 211);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(449, 227);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Text_Box2);
            this.Controls.Add(this.Box_Label2);
            this.Controls.Add(this.Text_Box);
            this.Controls.Add(this.Box_label);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Box_label;
        private System.Windows.Forms.TextBox Text_Box;
        private System.Windows.Forms.Label Box_Label2;
        private System.Windows.Forms.TextBox Text_Box2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

