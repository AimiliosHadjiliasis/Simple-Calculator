namespace Calculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Button_0 = new System.Windows.Forms.Button();
            this.Button_Dot = new System.Windows.Forms.Button();
            this.Button_Plus = new System.Windows.Forms.Button();
            this.Button_Equals = new System.Windows.Forms.Button();
            this.Button_Minus = new System.Windows.Forms.Button();
            this.Button_3 = new System.Windows.Forms.Button();
            this.Button_2 = new System.Windows.Forms.Button();
            this.Button_1 = new System.Windows.Forms.Button();
            this.Button_C = new System.Windows.Forms.Button();
            this.Button_Mult = new System.Windows.Forms.Button();
            this.Button_6 = new System.Windows.Forms.Button();
            this.Button_5 = new System.Windows.Forms.Button();
            this.Button_4 = new System.Windows.Forms.Button();
            this.Button_CE = new System.Windows.Forms.Button();
            this.Button_Division = new System.Windows.Forms.Button();
            this.Button_9 = new System.Windows.Forms.Button();
            this.Button_8 = new System.Windows.Forms.Button();
            this.Button_7 = new System.Windows.Forms.Button();
            this.TextBox_Result = new System.Windows.Forms.TextBox();
            this.LabelCurrentOperation = new System.Windows.Forms.Label();
            this.ButtonSquareRoot = new System.Windows.Forms.Button();
            this.ButtonXSquare = new System.Windows.Forms.Button();
            this.ButtonOneOverX = new System.Windows.Forms.Button();
            this.ButtonCos = new System.Windows.Forms.Button();
            this.ButtonSin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button_0
            // 
            this.Button_0.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Button_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_0.Location = new System.Drawing.Point(10, 334);
            this.Button_0.Name = "Button_0";
            this.Button_0.Size = new System.Drawing.Size(128, 60);
            this.Button_0.TabIndex = 0;
            this.Button_0.Text = "0";
            this.Button_0.UseVisualStyleBackColor = false;
            this.Button_0.Click += new System.EventHandler(this.Button_Click);
            // 
            // Button_Dot
            // 
            this.Button_Dot.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Button_Dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Dot.Location = new System.Drawing.Point(144, 334);
            this.Button_Dot.Name = "Button_Dot";
            this.Button_Dot.Size = new System.Drawing.Size(60, 60);
            this.Button_Dot.TabIndex = 2;
            this.Button_Dot.Text = ".";
            this.Button_Dot.UseVisualStyleBackColor = false;
            this.Button_Dot.Click += new System.EventHandler(this.Button_Click);
            // 
            // Button_Plus
            // 
            this.Button_Plus.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Button_Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Plus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_Plus.Location = new System.Drawing.Point(210, 334);
            this.Button_Plus.Name = "Button_Plus";
            this.Button_Plus.Size = new System.Drawing.Size(60, 60);
            this.Button_Plus.TabIndex = 3;
            this.Button_Plus.Text = "+";
            this.Button_Plus.UseVisualStyleBackColor = false;
            this.Button_Plus.Click += new System.EventHandler(this.Operator_Click);
            // 
            // Button_Equals
            // 
            this.Button_Equals.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Button_Equals.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Equals.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_Equals.Location = new System.Drawing.Point(276, 268);
            this.Button_Equals.Name = "Button_Equals";
            this.Button_Equals.Size = new System.Drawing.Size(60, 126);
            this.Button_Equals.TabIndex = 4;
            this.Button_Equals.Text = "=";
            this.Button_Equals.UseVisualStyleBackColor = false;
            this.Button_Equals.Click += new System.EventHandler(this.Button_Equals_Click);
            // 
            // Button_Minus
            // 
            this.Button_Minus.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Button_Minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Minus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_Minus.Location = new System.Drawing.Point(210, 268);
            this.Button_Minus.Name = "Button_Minus";
            this.Button_Minus.Size = new System.Drawing.Size(60, 60);
            this.Button_Minus.TabIndex = 8;
            this.Button_Minus.Text = "-";
            this.Button_Minus.UseVisualStyleBackColor = false;
            this.Button_Minus.Click += new System.EventHandler(this.Operator_Click);
            // 
            // Button_3
            // 
            this.Button_3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Button_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_3.Location = new System.Drawing.Point(144, 271);
            this.Button_3.Name = "Button_3";
            this.Button_3.Size = new System.Drawing.Size(60, 60);
            this.Button_3.TabIndex = 7;
            this.Button_3.Text = "3";
            this.Button_3.UseVisualStyleBackColor = false;
            this.Button_3.Click += new System.EventHandler(this.Button_Click);
            // 
            // Button_2
            // 
            this.Button_2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Button_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_2.Location = new System.Drawing.Point(78, 271);
            this.Button_2.Name = "Button_2";
            this.Button_2.Size = new System.Drawing.Size(60, 60);
            this.Button_2.TabIndex = 6;
            this.Button_2.Text = "2";
            this.Button_2.UseVisualStyleBackColor = false;
            this.Button_2.Click += new System.EventHandler(this.Button_Click);
            // 
            // Button_1
            // 
            this.Button_1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Button_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_1.Location = new System.Drawing.Point(12, 271);
            this.Button_1.Name = "Button_1";
            this.Button_1.Size = new System.Drawing.Size(60, 60);
            this.Button_1.TabIndex = 5;
            this.Button_1.Text = "1";
            this.Button_1.UseVisualStyleBackColor = false;
            this.Button_1.Click += new System.EventHandler(this.Button_Click);
            // 
            // Button_C
            // 
            this.Button_C.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Button_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_C.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_C.Location = new System.Drawing.Point(276, 205);
            this.Button_C.Name = "Button_C";
            this.Button_C.Size = new System.Drawing.Size(60, 60);
            this.Button_C.TabIndex = 14;
            this.Button_C.Text = "C";
            this.Button_C.UseVisualStyleBackColor = false;
            this.Button_C.Click += new System.EventHandler(this.Button_C_Click);
            // 
            // Button_Mult
            // 
            this.Button_Mult.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Button_Mult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Mult.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_Mult.Location = new System.Drawing.Point(210, 205);
            this.Button_Mult.Name = "Button_Mult";
            this.Button_Mult.Size = new System.Drawing.Size(60, 60);
            this.Button_Mult.TabIndex = 13;
            this.Button_Mult.Text = "*";
            this.Button_Mult.UseVisualStyleBackColor = false;
            this.Button_Mult.Click += new System.EventHandler(this.Operator_Click);
            // 
            // Button_6
            // 
            this.Button_6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Button_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_6.Location = new System.Drawing.Point(144, 206);
            this.Button_6.Name = "Button_6";
            this.Button_6.Size = new System.Drawing.Size(60, 60);
            this.Button_6.TabIndex = 12;
            this.Button_6.Text = "6";
            this.Button_6.UseVisualStyleBackColor = false;
            this.Button_6.Click += new System.EventHandler(this.Button_Click);
            // 
            // Button_5
            // 
            this.Button_5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Button_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_5.Location = new System.Drawing.Point(78, 208);
            this.Button_5.Name = "Button_5";
            this.Button_5.Size = new System.Drawing.Size(60, 60);
            this.Button_5.TabIndex = 11;
            this.Button_5.Text = "5";
            this.Button_5.UseVisualStyleBackColor = false;
            this.Button_5.Click += new System.EventHandler(this.Button_Click);
            // 
            // Button_4
            // 
            this.Button_4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Button_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_4.Location = new System.Drawing.Point(12, 209);
            this.Button_4.Name = "Button_4";
            this.Button_4.Size = new System.Drawing.Size(60, 60);
            this.Button_4.TabIndex = 10;
            this.Button_4.Text = "4";
            this.Button_4.UseVisualStyleBackColor = false;
            this.Button_4.Click += new System.EventHandler(this.Button_Click);
            // 
            // Button_CE
            // 
            this.Button_CE.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Button_CE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_CE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_CE.Location = new System.Drawing.Point(276, 143);
            this.Button_CE.Name = "Button_CE";
            this.Button_CE.Size = new System.Drawing.Size(60, 60);
            this.Button_CE.TabIndex = 19;
            this.Button_CE.Text = "CE";
            this.Button_CE.UseVisualStyleBackColor = false;
            this.Button_CE.Click += new System.EventHandler(this.Button_CE_Click);
            // 
            // Button_Division
            // 
            this.Button_Division.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Button_Division.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Division.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_Division.Location = new System.Drawing.Point(210, 143);
            this.Button_Division.Name = "Button_Division";
            this.Button_Division.Size = new System.Drawing.Size(60, 60);
            this.Button_Division.TabIndex = 18;
            this.Button_Division.Text = "÷";
            this.Button_Division.UseVisualStyleBackColor = false;
            this.Button_Division.Click += new System.EventHandler(this.Operator_Click);
            // 
            // Button_9
            // 
            this.Button_9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Button_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_9.Location = new System.Drawing.Point(144, 143);
            this.Button_9.Name = "Button_9";
            this.Button_9.Size = new System.Drawing.Size(60, 60);
            this.Button_9.TabIndex = 17;
            this.Button_9.Text = "9";
            this.Button_9.UseVisualStyleBackColor = false;
            this.Button_9.Click += new System.EventHandler(this.Button_Click);
            // 
            // Button_8
            // 
            this.Button_8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Button_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_8.Location = new System.Drawing.Point(78, 143);
            this.Button_8.Name = "Button_8";
            this.Button_8.Size = new System.Drawing.Size(60, 60);
            this.Button_8.TabIndex = 16;
            this.Button_8.Text = "8";
            this.Button_8.UseVisualStyleBackColor = false;
            this.Button_8.Click += new System.EventHandler(this.Button_Click);
            // 
            // Button_7
            // 
            this.Button_7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Button_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_7.Location = new System.Drawing.Point(12, 143);
            this.Button_7.Name = "Button_7";
            this.Button_7.Size = new System.Drawing.Size(60, 60);
            this.Button_7.TabIndex = 15;
            this.Button_7.Text = "7";
            this.Button_7.UseVisualStyleBackColor = false;
            this.Button_7.Click += new System.EventHandler(this.Button_Click);
            // 
            // TextBox_Result
            // 
            this.TextBox_Result.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.TextBox_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Result.ForeColor = System.Drawing.SystemColors.Window;
            this.TextBox_Result.Location = new System.Drawing.Point(12, 42);
            this.TextBox_Result.Name = "TextBox_Result";
            this.TextBox_Result.Size = new System.Drawing.Size(326, 29);
            this.TextBox_Result.TabIndex = 20;
            this.TextBox_Result.Text = "0";
            this.TextBox_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LabelCurrentOperation
            // 
            this.LabelCurrentOperation.AutoSize = true;
            this.LabelCurrentOperation.BackColor = System.Drawing.SystemColors.GrayText;
            this.LabelCurrentOperation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelCurrentOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCurrentOperation.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LabelCurrentOperation.Location = new System.Drawing.Point(12, 13);
            this.LabelCurrentOperation.Name = "LabelCurrentOperation";
            this.LabelCurrentOperation.Size = new System.Drawing.Size(2, 26);
            this.LabelCurrentOperation.TabIndex = 21;
            // 
            // ButtonSquareRoot
            // 
            this.ButtonSquareRoot.BackColor = System.Drawing.SystemColors.GrayText;
            this.ButtonSquareRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSquareRoot.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonSquareRoot.Location = new System.Drawing.Point(144, 77);
            this.ButtonSquareRoot.Name = "ButtonSquareRoot";
            this.ButtonSquareRoot.Size = new System.Drawing.Size(60, 60);
            this.ButtonSquareRoot.TabIndex = 23;
            this.ButtonSquareRoot.Text = "√x";
            this.ButtonSquareRoot.UseVisualStyleBackColor = false;
            this.ButtonSquareRoot.Click += new System.EventHandler(this.ButtonSquareRoot_Click);
            // 
            // ButtonXSquare
            // 
            this.ButtonXSquare.BackColor = System.Drawing.SystemColors.GrayText;
            this.ButtonXSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonXSquare.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonXSquare.Location = new System.Drawing.Point(210, 77);
            this.ButtonXSquare.Name = "ButtonXSquare";
            this.ButtonXSquare.Size = new System.Drawing.Size(60, 60);
            this.ButtonXSquare.TabIndex = 24;
            this.ButtonXSquare.Text = "x²";
            this.ButtonXSquare.UseVisualStyleBackColor = false;
            this.ButtonXSquare.Click += new System.EventHandler(this.ButtonXSquare_Click);
            // 
            // ButtonOneOverX
            // 
            this.ButtonOneOverX.BackColor = System.Drawing.SystemColors.GrayText;
            this.ButtonOneOverX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonOneOverX.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonOneOverX.Location = new System.Drawing.Point(276, 77);
            this.ButtonOneOverX.Name = "ButtonOneOverX";
            this.ButtonOneOverX.Size = new System.Drawing.Size(60, 60);
            this.ButtonOneOverX.TabIndex = 25;
            this.ButtonOneOverX.Text = "1/x";
            this.ButtonOneOverX.UseVisualStyleBackColor = false;
            this.ButtonOneOverX.Click += new System.EventHandler(this.ButtonOneOverX_Click);
            // 
            // ButtonCos
            // 
            this.ButtonCos.BackColor = System.Drawing.SystemColors.GrayText;
            this.ButtonCos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonCos.Location = new System.Drawing.Point(78, 77);
            this.ButtonCos.Name = "ButtonCos";
            this.ButtonCos.Size = new System.Drawing.Size(60, 60);
            this.ButtonCos.TabIndex = 26;
            this.ButtonCos.Text = "cos(x)";
            this.ButtonCos.UseVisualStyleBackColor = false;
            this.ButtonCos.Click += new System.EventHandler(this.ButtonCos_Click);
            // 
            // ButtonSin
            // 
            this.ButtonSin.BackColor = System.Drawing.SystemColors.GrayText;
            this.ButtonSin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonSin.Location = new System.Drawing.Point(12, 77);
            this.ButtonSin.Name = "ButtonSin";
            this.ButtonSin.Size = new System.Drawing.Size(60, 60);
            this.ButtonSin.TabIndex = 27;
            this.ButtonSin.Text = "sin(x)";
            this.ButtonSin.UseVisualStyleBackColor = false;
            this.ButtonSin.Click += new System.EventHandler(this.ButtonSin_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(350, 417);
            this.Controls.Add(this.ButtonSin);
            this.Controls.Add(this.ButtonCos);
            this.Controls.Add(this.ButtonOneOverX);
            this.Controls.Add(this.ButtonXSquare);
            this.Controls.Add(this.ButtonSquareRoot);
            this.Controls.Add(this.LabelCurrentOperation);
            this.Controls.Add(this.TextBox_Result);
            this.Controls.Add(this.Button_CE);
            this.Controls.Add(this.Button_Division);
            this.Controls.Add(this.Button_9);
            this.Controls.Add(this.Button_8);
            this.Controls.Add(this.Button_7);
            this.Controls.Add(this.Button_C);
            this.Controls.Add(this.Button_Mult);
            this.Controls.Add(this.Button_6);
            this.Controls.Add(this.Button_5);
            this.Controls.Add(this.Button_4);
            this.Controls.Add(this.Button_Minus);
            this.Controls.Add(this.Button_3);
            this.Controls.Add(this.Button_2);
            this.Controls.Add(this.Button_1);
            this.Controls.Add(this.Button_Equals);
            this.Controls.Add(this.Button_Plus);
            this.Controls.Add(this.Button_Dot);
            this.Controls.Add(this.Button_0);
            this.Font = new System.Drawing.Font("Mistral", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button Button_0;
        private System.Windows.Forms.Button Button_Dot;
        private System.Windows.Forms.Button Button_Plus;
        private System.Windows.Forms.Button Button_Equals;
        private System.Windows.Forms.Button Button_Minus;
        private System.Windows.Forms.Button Button_3;
        private System.Windows.Forms.Button Button_2;
        private System.Windows.Forms.Button Button_1;
        private System.Windows.Forms.Button Button_C;
        private System.Windows.Forms.Button Button_Mult;
        private System.Windows.Forms.Button Button_6;
        private System.Windows.Forms.Button Button_5;
        private System.Windows.Forms.Button Button_4;
        private System.Windows.Forms.Button Button_CE;
        private System.Windows.Forms.Button Button_Division;
        private System.Windows.Forms.Button Button_9;
        private System.Windows.Forms.Button Button_8;
        private System.Windows.Forms.Button Button_7;
        private System.Windows.Forms.TextBox TextBox_Result;
        private System.Windows.Forms.Label LabelCurrentOperation;
        private System.Windows.Forms.Button ButtonSquareRoot;
        private System.Windows.Forms.Button ButtonXSquare;
        private System.Windows.Forms.Button ButtonOneOverX;
        private System.Windows.Forms.Button ButtonCos;
        private System.Windows.Forms.Button ButtonSin;
    }
}

