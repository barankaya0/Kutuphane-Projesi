namespace Proje.Kutuphane
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            button1 = new Button();
            label1 = new Label();
            comboBox1 = new ComboBox();
            button2 = new Button();
            button3 = new Button();
            richTextBox1 = new RichTextBox();
            button4 = new Button();
            button5 = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonShadow;
            button1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(0, -1);
            button1.Name = "button1";
            button1.Size = new Size(48, 28);
            button1.TabIndex = 0;
            button1.Text = "<-";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 65);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 1;
            label1.Text = "Kitap İsmi:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(111, 62);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.ForeColor = Color.LawnGreen;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(288, 59);
            button2.Name = "button2";
            button2.Size = new Size(35, 33);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(139, 109);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 4;
            button3.Text = "Kitap Seç";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(443, 21);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(257, 308);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            // 
            // button4
            // 
            button4.ForeColor = Color.Green;
            button4.Location = new Point(443, 333);
            button4.Name = "button4";
            button4.Size = new Size(116, 48);
            button4.TabIndex = 7;
            button4.Text = "Kitabı Ödünç Al";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.ForeColor = Color.Firebrick;
            button5.Location = new Point(584, 333);
            button5.Name = "button5";
            button5.Size = new Size(116, 48);
            button5.TabIndex = 8;
            button5.Text = "Kitabı İade Et";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightSalmon;
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Controls.Add(button3);
            groupBox1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 405);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ödünç";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            ForeColor = Color.Black;
            Name = "Form3";
            Text = "Ödünç Ekranı";
            Load += Form3_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Label label1;
        private ComboBox comboBox1;
        private Button button2;
        private Button button3;
        private RichTextBox richTextBox1;
        private Button button4;
        private Button button5;
        private GroupBox groupBox1;
    }
}