using System.Windows.Forms;
using System.Drawing;
using System;
namespace Task_9
{
  
    partial class Form1
    {

        float xz, yz;
        float one;
        float rz;
        float wz, hz;
        int k = 0;
        float teta0 = (float)(5 * Math.PI / 4);
        float R0;
        float rs;
        float ws, hs;
        float dt = (float)(Math.PI / 100);
        int kz = 15, ks = 4, kr = 1, kOne = 100;
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
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(308, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Запуск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(231, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 209);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(308, 333);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Спуск";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Спутник";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics target = e.Graphics;
            Pen blackPen = new Pen(Color.Black);
            Pen greenPen = new Pen(Color.Green);
            target.FillEllipse(blackPen.Brush, ws, hs, 2 * rs, 2 * rs);
            target.FillEllipse(greenPen.Brush, wz, hz, 2 * rz, 2 * rz);
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (!timer1.Enabled) 	// Таймер не включен
                pictureData();	// Пересчет масштабных соотношений
            pictureBox1.Refresh();	// Обновить изображение 
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            button2.Visible = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
        private void pictureData()
        {
            xz = pictureBox1.Size.Width / 2;    // абсцисса центра земли
            yz = pictureBox1.Size.Height / 2;   // ордината центра земли
            one = Math.Min(xz, yz) / kOne;      // единица масштаба 
            rz = one * kz;                      // радиус земли
            wz = xz - rz; hz = yz - rz;         // левый верхний угол для земли   
            rs = one * ks;                      // радиус спутника
            ws = wz; hs = hz;                   // левый верхний угол для спутника
            float R;                            // расстояние от земли до спутника 
            R0 = (float)Math.Sqrt((ws - xz) * (ws - xz) + (hs - yz) * (hs - yz));
            float dR = one * kr;
            R = Math.Min(R0 + k * dR, one * 80);
            ws = (float)(R * Math.Cos(teta0 + k * dt)) + xz;
            hs = (float)(R * Math.Sin(teta0 + k * dt)) + yz;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureData();          // Подготовка и масштабирование данных для 				  //рисунка 
            k++;                    // счетчик тиков
            pictureBox1.Refresh();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            while (k != 0)
            {
                pictureData();          // Подготовка и масштабирование данных для 				  //рисунка 
                k--;                    // счетчик тиков
                pictureBox1.Refresh();
            }
        }
        

        private PictureBox pictureBox1;
        private Button button2;
    }
}

