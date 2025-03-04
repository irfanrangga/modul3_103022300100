namespace modul3_103022300100
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
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnAdd = new Button();
            btn0 = new Button();
            btnResult = new Button();
            textBox = new TextBox();
            label = new Label();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Location = new Point(150, 128);
            btn1.Name = "btn1";
            btn1.Size = new Size(56, 37);
            btn1.TabIndex = 0;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(212, 128);
            btn2.Name = "btn2";
            btn2.Size = new Size(56, 37);
            btn2.TabIndex = 0;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(274, 128);
            btn3.Name = "btn3";
            btn3.Size = new Size(56, 37);
            btn3.TabIndex = 0;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(150, 171);
            btn4.Name = "btn4";
            btn4.Size = new Size(56, 37);
            btn4.TabIndex = 0;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(212, 171);
            btn5.Name = "btn5";
            btn5.Size = new Size(56, 37);
            btn5.TabIndex = 0;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(274, 171);
            btn6.Name = "btn6";
            btn6.Size = new Size(56, 37);
            btn6.TabIndex = 0;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(150, 214);
            btn7.Name = "btn7";
            btn7.Size = new Size(56, 37);
            btn7.TabIndex = 0;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(212, 214);
            btn8.Name = "btn8";
            btn8.Size = new Size(56, 37);
            btn8.TabIndex = 0;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(274, 214);
            btn9.Name = "btn9";
            btn9.Size = new Size(56, 37);
            btn9.TabIndex = 0;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(150, 257);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(56, 37);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(212, 257);
            btn0.Name = "btn0";
            btn0.Size = new Size(56, 37);
            btn0.TabIndex = 0;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnResult
            // 
            btnResult.Location = new Point(274, 257);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(56, 37);
            btnResult.TabIndex = 0;
            btnResult.Text = "=";
            btnResult.UseVisualStyleBackColor = true;
            btnResult.Click += btnResult_Click;
            // 
            // textBox
            // 
            textBox.Location = new Point(150, 99);
            textBox.Name = "textBox";
            textBox.Size = new Size(180, 23);
            textBox.TabIndex = 1;
            textBox.TextChanged += textBox_TextChanged;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(150, 76);
            label.Name = "label";
            label.Size = new Size(77, 15);
            label.TabIndex = 2;
            label.Text = "Penambahan";
            label.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 445);
            Controls.Add(label);
            Controls.Add(textBox);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btnResult);
            Controls.Add(btn0);
            Controls.Add(btnAdd);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Name = "Form1";
            Text = "Calculator_103022300100";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnAdd;
        private Button btn0;
        private Button btnResult;
        private TextBox textBox;
        private Label label;
    }
}
