namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSub = new System.Windows.Forms.Button();
            this.buttonMul = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.buttonEvaluate = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.Dot = new System.Windows.Forms.Button();
            this.DecimalRadioButton = new System.Windows.Forms.RadioButton();
            this.BinaryRadioButton = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.닫기ㅌToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(242, 21);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(74, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 42);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(136, 242);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 42);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 194);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 42);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(74, 194);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 42);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(136, 194);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(56, 42);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 146);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(56, 42);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(74, 146);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(56, 42);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(136, 146);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(56, 42);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(198, 146);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(56, 90);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.OperatorButton_Click);
            // 
            // buttonSub
            // 
            this.buttonSub.Location = new System.Drawing.Point(198, 98);
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.Size = new System.Drawing.Size(56, 42);
            this.buttonSub.TabIndex = 11;
            this.buttonSub.Text = "-";
            this.buttonSub.UseVisualStyleBackColor = true;
            this.buttonSub.Click += new System.EventHandler(this.OperatorButton_Click);
            // 
            // buttonMul
            // 
            this.buttonMul.Location = new System.Drawing.Point(136, 98);
            this.buttonMul.Name = "buttonMul";
            this.buttonMul.Size = new System.Drawing.Size(56, 42);
            this.buttonMul.TabIndex = 12;
            this.buttonMul.Text = "*";
            this.buttonMul.UseVisualStyleBackColor = true;
            this.buttonMul.Click += new System.EventHandler(this.OperatorButton_Click);
            // 
            // buttonDiv
            // 
            this.buttonDiv.Location = new System.Drawing.Point(74, 98);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(56, 42);
            this.buttonDiv.TabIndex = 13;
            this.buttonDiv.Text = "/";
            this.buttonDiv.UseVisualStyleBackColor = true;
            this.buttonDiv.Click += new System.EventHandler(this.OperatorButton_Click);
            // 
            // buttonEvaluate
            // 
            this.buttonEvaluate.Location = new System.Drawing.Point(198, 242);
            this.buttonEvaluate.Name = "buttonEvaluate";
            this.buttonEvaluate.Size = new System.Drawing.Size(56, 90);
            this.buttonEvaluate.TabIndex = 14;
            this.buttonEvaluate.Text = "=";
            this.buttonEvaluate.UseVisualStyleBackColor = true;
            this.buttonEvaluate.Click += new System.EventHandler(this.EvaluateButton_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(12, 98);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(56, 42);
            this.buttonClear.TabIndex = 15;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(12, 290);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(118, 42);
            this.button0.TabIndex = 16;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // Dot
            // 
            this.Dot.Location = new System.Drawing.Point(136, 290);
            this.Dot.Name = "Dot";
            this.Dot.Size = new System.Drawing.Size(56, 42);
            this.Dot.TabIndex = 17;
            this.Dot.Text = ".";
            this.Dot.UseVisualStyleBackColor = true;
            this.Dot.Click += new System.EventHandler(this.OperatorButton_Click);
            // 
            // DecimalRadioButton
            // 
            this.DecimalRadioButton.AutoSize = true;
            this.DecimalRadioButton.Checked = true;
            this.DecimalRadioButton.Location = new System.Drawing.Point(136, 5);
            this.DecimalRadioButton.Name = "DecimalRadioButton";
            this.DecimalRadioButton.Size = new System.Drawing.Size(59, 16);
            this.DecimalRadioButton.TabIndex = 18;
            this.DecimalRadioButton.TabStop = true;
            this.DecimalRadioButton.Text = "10진수";
            this.DecimalRadioButton.UseVisualStyleBackColor = true;
            this.DecimalRadioButton.CheckedChanged += new System.EventHandler(this.DecimalButton_CheckedChanged);
            // 
            // BinaryRadioButton
            // 
            this.BinaryRadioButton.AutoSize = true;
            this.BinaryRadioButton.Location = new System.Drawing.Point(201, 5);
            this.BinaryRadioButton.Name = "BinaryRadioButton";
            this.BinaryRadioButton.Size = new System.Drawing.Size(53, 16);
            this.BinaryRadioButton.TabIndex = 19;
            this.BinaryRadioButton.Text = "2진수";
            this.BinaryRadioButton.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일FToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(270, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일FToolStripMenuItem
            // 
            this.파일FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.닫기ㅌToolStripMenuItem});
            this.파일FToolStripMenuItem.Name = "파일FToolStripMenuItem";
            this.파일FToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.파일FToolStripMenuItem.Text = "파일(&F)";
            // 
            // 닫기ㅌToolStripMenuItem
            // 
            this.닫기ㅌToolStripMenuItem.Name = "닫기ㅌToolStripMenuItem";
            this.닫기ㅌToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.닫기ㅌToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.닫기ㅌToolStripMenuItem.Text = "닫기(&X)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 347);
            this.Controls.Add(this.BinaryRadioButton);
            this.Controls.Add(this.DecimalRadioButton);
            this.Controls.Add(this.Dot);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonEvaluate);
            this.Controls.Add(this.buttonDiv);
            this.Controls.Add(this.buttonMul);
            this.Controls.Add(this.buttonSub);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Calc";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSub;
        private System.Windows.Forms.Button buttonMul;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Button buttonEvaluate;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button Dot;
        private System.Windows.Forms.RadioButton DecimalRadioButton;
        private System.Windows.Forms.RadioButton BinaryRadioButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 닫기ㅌToolStripMenuItem;
    }
}

