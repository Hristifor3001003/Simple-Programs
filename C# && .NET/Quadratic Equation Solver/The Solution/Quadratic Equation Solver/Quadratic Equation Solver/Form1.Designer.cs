namespace QuadraticEuation
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
            label1 = new Label();
            label2 = new Label();
            textBoxA = new TextBox();
            label3 = new Label();
            labelA = new Label();
            label51 = new Label();
            textBoxB = new TextBox();
            labelB = new Label();
            label4 = new Label();
            textBoxC = new TextBox();
            labelC = new Label();
            label5 = new Label();
            labelX1 = new Label();
            textBoxRealPart1 = new TextBox();
            labelRealPart1 = new Label();
            label6 = new Label();
            textBoxImagPart1 = new TextBox();
            labelImagPart1 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBoxRealPart2 = new TextBox();
            labelRealPart2 = new Label();
            textBoxImagPart2 = new TextBox();
            labelImagPart2 = new Label();
            label9 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(36, 31);
            label1.Name = "label1";
            label1.Size = new Size(655, 20);
            label1.TabIndex = 0;
            label1.Text = "Enter only coeficients from the interval [-1000000, 1000000] and click the button \"Solve\" to";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(36, 51);
            label2.Name = "label2";
            label2.Size = new Size(212, 20);
            label2.TabIndex = 1;
            label2.Text = "solve the quadratic equation.";
            // 
            // textBoxA
            // 
            textBoxA.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxA.Location = new Point(71, 100);
            textBoxA.Name = "textBoxA";
            textBoxA.PlaceholderText = "eg. 1.652";
            textBoxA.Size = new Size(140, 27);
            textBoxA.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(43, 99);
            label3.Name = "label3";
            label3.Size = new Size(0, 25);
            label3.TabIndex = 3;
            // 
            // labelA
            // 
            labelA.AutoSize = true;
            labelA.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelA.Location = new Point(49, 104);
            labelA.Name = "labelA";
            labelA.Size = new Size(13, 20);
            labelA.TabIndex = 4;
            labelA.Text = " ";
            // 
            // label51
            // 
            label51.AutoSize = true;
            label51.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label51.Location = new Point(217, 103);
            label51.Name = "label51";
            label51.Size = new Size(39, 20);
            label51.TabIndex = 5;
            label51.Text = "X^2";
            // 
            // textBoxB
            // 
            textBoxB.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxB.Location = new Point(296, 99);
            textBoxB.Name = "textBoxB";
            textBoxB.PlaceholderText = "eg. -544";
            textBoxB.Size = new Size(140, 27);
            textBoxB.TabIndex = 6;
            // 
            // labelB
            // 
            labelB.AutoSize = true;
            labelB.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelB.Location = new Point(268, 102);
            labelB.Name = "labelB";
            labelB.Size = new Size(20, 20);
            labelB.TabIndex = 7;
            labelB.Text = "+";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(441, 102);
            label4.Name = "label4";
            label4.Size = new Size(19, 20);
            label4.TabIndex = 8;
            label4.Text = "X";
            // 
            // textBoxC
            // 
            textBoxC.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxC.Location = new Point(497, 99);
            textBoxC.Name = "textBoxC";
            textBoxC.PlaceholderText = "eg. 10234.1111";
            textBoxC.Size = new Size(140, 27);
            textBoxC.TabIndex = 9;
            // 
            // labelC
            // 
            labelC.AutoSize = true;
            labelC.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelC.Location = new Point(469, 104);
            labelC.Name = "labelC";
            labelC.Size = new Size(20, 20);
            labelC.TabIndex = 10;
            labelC.Text = "+";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(645, 101);
            label5.Name = "label5";
            label5.Size = new Size(40, 25);
            label5.TabIndex = 11;
            label5.Text = "= 0";
            // 
            // labelX1
            // 
            labelX1.AutoSize = true;
            labelX1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelX1.Location = new Point(46, 238);
            labelX1.Name = "labelX1";
            labelX1.Size = new Size(47, 20);
            labelX1.TabIndex = 12;
            labelX1.Text = "X1 = ";
            // 
            // textBoxRealPart1
            // 
            textBoxRealPart1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxRealPart1.Location = new Point(134, 235);
            textBoxRealPart1.Name = "textBoxRealPart1";
            textBoxRealPart1.Size = new Size(253, 27);
            textBoxRealPart1.TabIndex = 13;
            textBoxRealPart1.TextChanged += textBoxRealPart1_TextChanged;
            // 
            // labelRealPart1
            // 
            labelRealPart1.AutoSize = true;
            labelRealPart1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRealPart1.Location = new Point(109, 238);
            labelRealPart1.Name = "labelRealPart1";
            labelRealPart1.Size = new Size(13, 20);
            labelRealPart1.TabIndex = 14;
            labelRealPart1.Text = " ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(43, 188);
            label6.Name = "label6";
            label6.Size = new Size(215, 20);
            label6.TabIndex = 15;
            label6.Text = "Roots / Solutions of equation";
            // 
            // textBoxImagPart1
            // 
            textBoxImagPart1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxImagPart1.Location = new Point(423, 235);
            textBoxImagPart1.Name = "textBoxImagPart1";
            textBoxImagPart1.Size = new Size(232, 27);
            textBoxImagPart1.TabIndex = 16;
            // 
            // labelImagPart1
            // 
            labelImagPart1.AutoSize = true;
            labelImagPart1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelImagPart1.Location = new Point(394, 238);
            labelImagPart1.Name = "labelImagPart1";
            labelImagPart1.Size = new Size(20, 20);
            labelImagPart1.TabIndex = 17;
            labelImagPart1.Text = "+";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(663, 235);
            label7.Name = "label7";
            label7.Size = new Size(24, 20);
            label7.TabIndex = 18;
            label7.Text = "* i";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(46, 284);
            label8.Name = "label8";
            label8.Size = new Size(43, 20);
            label8.TabIndex = 19;
            label8.Text = "X2 =";
            // 
            // textBoxRealPart2
            // 
            textBoxRealPart2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxRealPart2.Location = new Point(134, 277);
            textBoxRealPart2.Name = "textBoxRealPart2";
            textBoxRealPart2.Size = new Size(253, 27);
            textBoxRealPart2.TabIndex = 20;
            // 
            // labelRealPart2
            // 
            labelRealPart2.AutoSize = true;
            labelRealPart2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRealPart2.Location = new Point(108, 279);
            labelRealPart2.Name = "labelRealPart2";
            labelRealPart2.Size = new Size(13, 20);
            labelRealPart2.TabIndex = 21;
            labelRealPart2.Text = " ";
            // 
            // textBoxImagPart2
            // 
            textBoxImagPart2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxImagPart2.Location = new Point(423, 276);
            textBoxImagPart2.Name = "textBoxImagPart2";
            textBoxImagPart2.Size = new Size(232, 27);
            textBoxImagPart2.TabIndex = 22;
            // 
            // labelImagPart2
            // 
            labelImagPart2.AutoSize = true;
            labelImagPart2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelImagPart2.Location = new Point(394, 280);
            labelImagPart2.Name = "labelImagPart2";
            labelImagPart2.Size = new Size(20, 20);
            labelImagPart2.TabIndex = 23;
            labelImagPart2.Text = "+";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(663, 277);
            label9.Name = "label9";
            label9.Size = new Size(24, 20);
            label9.TabIndex = 24;
            label9.Text = "* i";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(728, 235);
            button1.Name = "button1";
            button1.Size = new Size(106, 29);
            button1.TabIndex = 25;
            button1.Text = "Solve";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveBorder;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(728, 270);
            button2.Name = "button2";
            button2.Size = new Size(106, 29);
            button2.TabIndex = 26;
            button2.Text = "Erase";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 362);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(labelImagPart2);
            Controls.Add(textBoxImagPart2);
            Controls.Add(labelRealPart2);
            Controls.Add(textBoxRealPart2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(labelImagPart1);
            Controls.Add(textBoxImagPart1);
            Controls.Add(label6);
            Controls.Add(labelRealPart1);
            Controls.Add(textBoxRealPart1);
            Controls.Add(labelX1);
            Controls.Add(label5);
            Controls.Add(labelC);
            Controls.Add(textBoxC);
            Controls.Add(label4);
            Controls.Add(labelB);
            Controls.Add(textBoxB);
            Controls.Add(label51);
            Controls.Add(labelA);
            Controls.Add(label3);
            Controls.Add(textBoxA);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Quadratic Equation";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxA;
        private Label label3;
        private Label labelA;
        private Label label51;
        private TextBox textBoxB;
        private Label labelB;
        private Label label4;
        private TextBox textBoxC;
        private Label labelC;
        private Label label5;
        private Label labelX1;
        private TextBox textBoxRealPart1;
        private Label labelRealPart1;
        private Label label6;
        private TextBox textBoxImagPart1;
        private Label labelImagPart1;
        private Label label7;
        private Label label8;
        private TextBox textBoxRealPart2;
        private Label labelRealPart2;
        private TextBox textBoxImagPart2;
        private Label labelImagPart2;
        private Label label9;
        private Button button1;
        private Button button2;
    }
}
