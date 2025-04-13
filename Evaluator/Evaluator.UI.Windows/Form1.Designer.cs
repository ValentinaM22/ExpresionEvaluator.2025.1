namespace Evaluator.UI.Windows
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
            txtDisplay = new TextBox();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btnMultiply = new Button();
            btnPlus = new Button();
            btnDivide = new Button();
            btnDot = new Button();
            btnMinus = new Button();
            btnOpenParenthesis = new Button();
            btnPow = new Button();
            btnResult = new Button();
            btnCloseParenthesis = new Button();
            btnClean = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDisplay.BackColor = Color.FromArgb(255, 192, 192);
            txtDisplay.Location = new Point(17, 21);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(442, 23);
            txtDisplay.TabIndex = 0;
            // 
            // btn7
            // 
            btn7.BackColor = Color.FromArgb(255, 128, 128);
            btn7.Location = new Point(17, 65);
            btn7.Name = "btn7";
            btn7.Size = new Size(60, 46);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.FromArgb(255, 128, 128);
            btn8.Location = new Point(92, 65);
            btn8.Name = "btn8";
            btn8.Size = new Size(60, 46);
            btn8.TabIndex = 2;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.FromArgb(255, 128, 128);
            btn9.Location = new Point(167, 65);
            btn9.Name = "btn9";
            btn9.Size = new Size(60, 46);
            btn9.TabIndex = 3;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.FromArgb(255, 128, 128);
            btn3.Location = new Point(167, 195);
            btn3.Name = "btn3";
            btn3.Size = new Size(60, 46);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            btn2.BackColor = Color.FromArgb(255, 128, 128);
            btn2.Location = new Point(92, 195);
            btn2.Name = "btn2";
            btn2.Size = new Size(60, 46);
            btn2.TabIndex = 5;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            // 
            // btn1
            // 
            btn1.BackColor = Color.FromArgb(255, 128, 128);
            btn1.Location = new Point(17, 195);
            btn1.Name = "btn1";
            btn1.Size = new Size(60, 46);
            btn1.TabIndex = 4;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            // 
            // btn6
            // 
            btn6.BackColor = Color.FromArgb(255, 128, 128);
            btn6.Location = new Point(167, 128);
            btn6.Name = "btn6";
            btn6.Size = new Size(60, 46);
            btn6.TabIndex = 9;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            // 
            // btn5
            // 
            btn5.BackColor = Color.FromArgb(255, 128, 128);
            btn5.Location = new Point(92, 128);
            btn5.Name = "btn5";
            btn5.Size = new Size(60, 46);
            btn5.TabIndex = 8;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            // 
            // btn4
            // 
            btn4.BackColor = Color.FromArgb(255, 128, 128);
            btn4.Location = new Point(17, 128);
            btn4.Name = "btn4";
            btn4.Size = new Size(60, 46);
            btn4.TabIndex = 7;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = Color.FromArgb(255, 192, 255);
            btnMultiply.Location = new Point(310, 65);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(59, 46);
            btnMultiply.TabIndex = 12;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = false;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = Color.FromArgb(255, 192, 255);
            btnPlus.Location = new Point(310, 128);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(59, 46);
            btnPlus.TabIndex = 11;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = Color.FromArgb(255, 192, 255);
            btnDivide.Location = new Point(245, 65);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(59, 46);
            btnDivide.TabIndex = 10;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = false;
            // 
            // btnDot
            // 
            btnDot.BackColor = Color.FromArgb(255, 128, 128);
            btnDot.Location = new Point(17, 247);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(210, 46);
            btnDot.TabIndex = 13;
            btnDot.Text = "0";
            btnDot.UseVisualStyleBackColor = false;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = Color.FromArgb(255, 192, 255);
            btnMinus.Location = new Point(245, 128);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(59, 46);
            btnMinus.TabIndex = 14;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            // 
            // btnOpenParenthesis
            // 
            btnOpenParenthesis.BackColor = Color.FromArgb(255, 192, 255);
            btnOpenParenthesis.Location = new Point(245, 195);
            btnOpenParenthesis.Name = "btnOpenParenthesis";
            btnOpenParenthesis.Size = new Size(59, 46);
            btnOpenParenthesis.TabIndex = 15;
            btnOpenParenthesis.Text = "(";
            btnOpenParenthesis.UseVisualStyleBackColor = false;
            // 
            // btnPow
            // 
            btnPow.BackColor = Color.FromArgb(255, 192, 255);
            btnPow.Location = new Point(375, 195);
            btnPow.Name = "btnPow";
            btnPow.Size = new Size(59, 46);
            btnPow.TabIndex = 16;
            btnPow.Text = "^";
            btnPow.UseVisualStyleBackColor = false;
            // 
            // btnResult
            // 
            btnResult.BackColor = Color.FromArgb(255, 192, 255);
            btnResult.Location = new Point(245, 247);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(189, 46);
            btnResult.TabIndex = 17;
            btnResult.Text = "=";
            btnResult.UseVisualStyleBackColor = false;
            // 
            // btnCloseParenthesis
            // 
            btnCloseParenthesis.BackColor = Color.FromArgb(255, 192, 255);
            btnCloseParenthesis.Location = new Point(310, 195);
            btnCloseParenthesis.Name = "btnCloseParenthesis";
            btnCloseParenthesis.Size = new Size(59, 46);
            btnCloseParenthesis.TabIndex = 18;
            btnCloseParenthesis.Text = ")";
            btnCloseParenthesis.UseVisualStyleBackColor = false;
            // 
            // btnClean
            // 
            btnClean.BackColor = Color.FromArgb(255, 192, 255);
            btnClean.Location = new Point(375, 128);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(59, 46);
            btnClean.TabIndex = 19;
            btnClean.Text = "Clean";
            btnClean.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 192, 255);
            btnDelete.Location = new Point(375, 65);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(59, 46);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 322);
            Controls.Add(btnDelete);
            Controls.Add(btnClean);
            Controls.Add(btnCloseParenthesis);
            Controls.Add(btnResult);
            Controls.Add(btnPow);
            Controls.Add(btnOpenParenthesis);
            Controls.Add(btnMinus);
            Controls.Add(btnDot);
            Controls.Add(btnMultiply);
            Controls.Add(btnPlus);
            Controls.Add(btnDivide);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(txtDisplay);
            Name = "Form1";
            Text = "Functions Evaluator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btnMultiply;
        private Button btnPlus;
        private Button btnDivide;
        private Button btnDot;
        private Button btnMinus;
        private Button btnOpenParenthesis;
        private Button btnPow;
        private Button btnResult;
        private Button btnCloseParenthesis;
        private Button btnClean;
        private Button btnDelete;
    }
}
