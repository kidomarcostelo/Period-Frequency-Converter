namespace Period_Frequency_Converter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            FirstLabel = new Label();
            SecondLabel = new Label();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(47, 99);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(368, 31);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Location = new Point(47, 258);
            label1.Name = "label1";
            label1.Size = new Size(368, 38);
            label1.TabIndex = 3;
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(47, 211);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(368, 31);
            textBox2.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(447, 97);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(105, 33);
            comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(447, 209);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(105, 33);
            comboBox2.TabIndex = 4;
            // 
            // FirstLabel
            // 
            FirstLabel.AutoSize = true;
            FirstLabel.Location = new Point(47, 71);
            FirstLabel.Name = "FirstLabel";
            FirstLabel.Size = new Size(86, 25);
            FirstLabel.TabIndex = 5;
            FirstLabel.Text = "FirstLabel";
            // 
            // SecondLabel
            // 
            SecondLabel.AutoSize = true;
            SecondLabel.Location = new Point(47, 183);
            SecondLabel.Name = "SecondLabel";
            SecondLabel.Size = new Size(112, 25);
            SecondLabel.TabIndex = 5;
            SecondLabel.Text = "SecondLabel";
            // 
            // button1
            // 
            button1.Location = new Point(249, 321);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 6;
            button1.Text = "Convert";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(289, 156);
            button2.Name = "button2";
            button2.Size = new Size(30, 34);
            button2.TabIndex = 7;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(9, 9);
            label2.Name = "label2";
            label2.Size = new Size(352, 32);
            label2.TabIndex = 8;
            label2.Text = "Frequency / Period Converter";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 411);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(SecondLabel);
            Controls.Add(FirstLabel);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label FirstLabel;
        private Label SecondLabel;
        private Button button1;
        private Button button2;
        private Label label2;
    }
}