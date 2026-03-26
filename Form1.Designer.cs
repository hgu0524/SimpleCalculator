namespace SimpleCalculator
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
            calculator = new Label();
            txtInput = new TextBox();
            txtResult = new TextBox();
            btnDiv = new Button();
            btnCE = new Button();
            btnC = new Button();
            btnD = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btnMul = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btnSub = new Button();
            btnDot = new Button();
            btn0 = new Button();
            btnAM = new Button();
            btnEqual = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // calculator
            // 
            calculator.AutoSize = true;
            calculator.BackColor = SystemColors.Control;
            calculator.Font = new Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            calculator.ForeColor = SystemColors.HotTrack;
            calculator.Location = new Point(83, 63);
            calculator.Name = "calculator";
            calculator.Size = new Size(746, 109);
            calculator.TabIndex = 0;
            calculator.Text = "Simple Calculator";
            // 
            // txtInput
            // 
            txtInput.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtInput.Location = new Point(119, 217);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(660, 62);
            txtInput.TabIndex = 1;
            // 
            // txtResult
            // 
            txtResult.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtResult.Location = new Point(119, 313);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(660, 60);
            txtResult.TabIndex = 2;
            // 
            // btnDiv
            // 
            btnDiv.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnDiv.Location = new Point(617, 415);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(162, 71);
            btnDiv.TabIndex = 6;
            btnDiv.Text = "÷";
            btnDiv.UseVisualStyleBackColor = true;
            // 
            // btnCE
            // 
            btnCE.Font = new Font("맑은 고딕", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnCE.Location = new Point(113, 415);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(162, 71);
            btnCE.TabIndex = 7;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = true;
            // 
            // btnC
            // 
            btnC.Font = new Font("맑은 고딕", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnC.Location = new Point(281, 415);
            btnC.Name = "btnC";
            btnC.Size = new Size(162, 71);
            btnC.TabIndex = 8;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            // 
            // btnD
            // 
            btnD.Font = new Font("맑은 고딕", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnD.Location = new Point(449, 415);
            btnD.Name = "btnD";
            btnD.Size = new Size(162, 71);
            btnD.TabIndex = 9;
            btnD.Text = "del";
            btnD.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            btn9.Font = new Font("맑은 고딕", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btn9.Location = new Point(449, 492);
            btn9.Name = "btn9";
            btn9.Size = new Size(162, 71);
            btn9.TabIndex = 13;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += NumberButton_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("맑은 고딕", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btn8.Location = new Point(281, 492);
            btn8.Name = "btn8";
            btn8.Size = new Size(162, 71);
            btn8.TabIndex = 12;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += NumberButton_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("맑은 고딕", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btn7.Location = new Point(113, 492);
            btn7.Name = "btn7";
            btn7.Size = new Size(162, 71);
            btn7.TabIndex = 11;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += NumberButton_Click;
            // 
            // btnMul
            // 
            btnMul.Font = new Font("맑은 고딕", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnMul.Location = new Point(617, 492);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(162, 71);
            btnMul.TabIndex = 10;
            btnMul.Text = "x";
            btnMul.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            btn6.Font = new Font("맑은 고딕", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btn6.Location = new Point(449, 569);
            btn6.Name = "btn6";
            btn6.Size = new Size(162, 71);
            btn6.TabIndex = 17;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += NumberButton_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("맑은 고딕", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btn5.Location = new Point(281, 569);
            btn5.Name = "btn5";
            btn5.Size = new Size(162, 71);
            btn5.TabIndex = 16;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += NumberButton_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("맑은 고딕", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btn4.Location = new Point(113, 569);
            btn4.Name = "btn4";
            btn4.Size = new Size(162, 71);
            btn4.TabIndex = 15;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += NumberButton_Click;
            // 
            // btnSub
            // 
            btnSub.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnSub.Location = new Point(617, 569);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(162, 71);
            btnSub.TabIndex = 14;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            // 
            // btnDot
            // 
            btnDot.Font = new Font("맑은 고딕", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnDot.Location = new Point(449, 723);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(162, 71);
            btnDot.TabIndex = 25;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            btn0.Font = new Font("맑은 고딕", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btn0.Location = new Point(281, 723);
            btn0.Name = "btn0";
            btn0.Size = new Size(162, 71);
            btn0.TabIndex = 24;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += NumberButton_Click;
            // 
            // btnAM
            // 
            btnAM.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnAM.Location = new Point(113, 723);
            btnAM.Name = "btnAM";
            btnAM.Size = new Size(162, 71);
            btnAM.TabIndex = 23;
            btnAM.Text = "+/-";
            btnAM.UseVisualStyleBackColor = true;
            // 
            // btnEqual
            // 
            btnEqual.Font = new Font("맑은 고딕", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnEqual.Location = new Point(617, 723);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(162, 71);
            btnEqual.TabIndex = 22;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("맑은 고딕", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btn1.Location = new Point(449, 646);
            btn1.Name = "btn1";
            btn1.Size = new Size(162, 71);
            btn1.TabIndex = 21;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += NumberButton_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("맑은 고딕", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btn2.Location = new Point(281, 646);
            btn2.Name = "btn2";
            btn2.Size = new Size(162, 71);
            btn2.TabIndex = 20;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += NumberButton_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("맑은 고딕", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btn3.Location = new Point(113, 646);
            btn3.Name = "btn3";
            btn3.Size = new Size(162, 71);
            btn3.TabIndex = 19;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += NumberButton_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnAdd.Location = new Point(617, 646);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(162, 71);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 893);
            Controls.Add(btnDot);
            Controls.Add(btn0);
            Controls.Add(btnAM);
            Controls.Add(btnEqual);
            Controls.Add(btn1);
            Controls.Add(btn2);
            Controls.Add(btn3);
            Controls.Add(btnAdd);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnSub);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnMul);
            Controls.Add(btnD);
            Controls.Add(btnC);
            Controls.Add(btnCE);
            Controls.Add(btnDiv);
            Controls.Add(txtResult);
            Controls.Add(txtInput);
            Controls.Add(calculator);
            Name = "Form1";
            Text = "Calculator v1.0";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label calculator;
        private TextBox txtInput;
        private TextBox txtResult;
        private Button btnDiv;
        private Button btnCE;
        private Button btnC;
        private Button btnD;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btnMul;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btnSub;
        private Button btnDot;
        private Button btn0;
        private Button btnAM;
        private Button btnEqual;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnAdd;
    }
}
