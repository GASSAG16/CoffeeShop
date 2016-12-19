namespace CoffeeShop
{
    partial class fmCoffeShop
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmCoffeShop));
            this.btnPrint = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.btnWater = new System.Windows.Forms.Button();
            this.btnCoffe = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbCostEspresso = new System.Windows.Forms.Label();
            this.lbCostWater = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chSugar = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrint.BackgroundImage")));
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Location = new System.Drawing.Point(425, 299);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(52, 53);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(37, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "Меню";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.BackColor = System.Drawing.Color.Transparent;
            this.lbTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTotal.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTotal.ForeColor = System.Drawing.Color.Black;
            this.lbTotal.Location = new System.Drawing.Point(107, 310);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(0, 27);
            this.lbTotal.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Location = new System.Drawing.Point(23, 293);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(63, 71);
            this.panel5.TabIndex = 9;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(20, 60);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(460, 296);
            this.shapeContainer1.TabIndex = 10;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 70;
            this.lineShape1.X2 = 389;
            this.lineShape1.Y1 = 287;
            this.lineShape1.Y2 = 287;
            // 
            // btnWater
            // 
            this.btnWater.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWater.BackgroundImage")));
            this.btnWater.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnWater.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWater.Location = new System.Drawing.Point(237, 201);
            this.btnWater.Name = "btnWater";
            this.btnWater.Size = new System.Drawing.Size(77, 74);
            this.btnWater.TabIndex = 0;
            this.btnWater.UseVisualStyleBackColor = true;
            this.btnWater.Click += new System.EventHandler(this.btnWater_Click);
            // 
            // btnCoffe
            // 
            this.btnCoffe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCoffe.BackgroundImage")));
            this.btnCoffe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCoffe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCoffe.Location = new System.Drawing.Point(320, 201);
            this.btnCoffe.Name = "btnCoffe";
            this.btnCoffe.Size = new System.Drawing.Size(95, 74);
            this.btnCoffe.TabIndex = 0;
            this.btnCoffe.UseVisualStyleBackColor = true;
            this.btnCoffe.Click += new System.EventHandler(this.btnCoffe_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lbCostEspresso);
            this.panel1.Controls.Add(this.lbCostWater);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(23, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 201);
            this.panel1.TabIndex = 11;
            // 
            // lbCostEspresso
            // 
            this.lbCostEspresso.AutoSize = true;
            this.lbCostEspresso.Location = new System.Drawing.Point(84, 90);
            this.lbCostEspresso.Name = "lbCostEspresso";
            this.lbCostEspresso.Size = new System.Drawing.Size(70, 27);
            this.lbCostEspresso.TabIndex = 10;
            this.lbCostEspresso.Text = "label2";
            // 
            // lbCostWater
            // 
            this.lbCostWater.AutoSize = true;
            this.lbCostWater.Location = new System.Drawing.Point(84, 53);
            this.lbCostWater.Name = "lbCostWater";
            this.lbCostWater.Size = new System.Drawing.Size(70, 27);
            this.lbCostWater.TabIndex = 9;
            this.lbCostWater.Text = "label2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = "Кофе";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 27);
            this.label3.TabIndex = 8;
            this.label3.Text = "Вода";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(272, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // chSugar
            // 
            this.chSugar.AutoSize = true;
            this.chSugar.ForeColor = System.Drawing.Color.Black;
            this.chSugar.Location = new System.Drawing.Point(278, 266);
            this.chSugar.Name = "chSugar";
            this.chSugar.Size = new System.Drawing.Size(69, 21);
            this.chSugar.TabIndex = 13;
            this.chSugar.Text = "Сахар";
            this.chSugar.UseVisualStyleBackColor = true;
            this.chSugar.CheckedChanged += new System.EventHandler(this.chSugar_CheckedChanged);
            // 
            // fmCoffeShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 376);
            this.Controls.Add(this.chSugar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCoffe);
            this.Controls.Add(this.btnWater);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.shapeContainer1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.MaximizeBox = false;
            this.Name = "fmCoffeShop";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Добро пожаловать в кофейню!";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Panel panel5;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Button btnWater;
        private System.Windows.Forms.Button btnCoffe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbCostEspresso;
        private System.Windows.Forms.Label lbCostWater;
        private System.Windows.Forms.CheckBox chSugar;
    }
}

