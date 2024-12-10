namespace Calculator1
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
            addition = new Button();
            substraction = new Button();
            result = new Label();
            multiplication = new Button();
            division = new Button();
            input1 = new TextBox();
            input2 = new TextBox();
            SuspendLayout();
            // 
            // addition
            // 
            addition.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            addition.Location = new Point(36, 159);
            addition.Name = "addition";
            addition.Size = new Size(89, 58);
            addition.TabIndex = 0;
            addition.Text = "+";
            addition.UseVisualStyleBackColor = true;
            addition.Click += Addition;
            // 
            // substraction
            // 
            substraction.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            substraction.Location = new Point(36, 251);
            substraction.Name = "substraction";
            substraction.Size = new Size(89, 58);
            substraction.TabIndex = 1;
            substraction.Text = "-";
            substraction.UseVisualStyleBackColor = true;
            substraction.Click += Substraction;
            // 
            // result
            // 
            result.AutoSize = true;
            result.Location = new Point(392, 48);
            result.Name = "result";
            result.Size = new Size(45, 20);
            result.TabIndex = 2;
            result.Text = "result";
            // 
            // multiplication
            // 
            multiplication.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            multiplication.Location = new Point(36, 333);
            multiplication.Name = "multiplication";
            multiplication.Size = new Size(89, 58);
            multiplication.TabIndex = 3;
            multiplication.Text = "*";
            multiplication.UseVisualStyleBackColor = true;
            multiplication.Click += Multiplication;
            // 
            // division
            // 
            division.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            division.Location = new Point(166, 333);
            division.Name = "division";
            division.Size = new Size(89, 58);
            division.TabIndex = 4;
            division.Text = "/";
            division.UseVisualStyleBackColor = true;
            division.Click += Division;
            // 
            // input1
            // 
            input1.Location = new Point(36, 45);
            input1.Name = "input1";
            input1.Size = new Size(125, 27);
            input1.TabIndex = 6;
            // 
            // input2
            // 
            input2.Location = new Point(202, 45);
            input2.Name = "input2";
            input2.Size = new Size(125, 27);
            input2.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 450);
            Controls.Add(input2);
            Controls.Add(input1);
            Controls.Add(division);
            Controls.Add(multiplication);
            Controls.Add(result);
            Controls.Add(substraction);
            Controls.Add(addition);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addition;
        private Button substraction;
        private Label result;
        private Button multiplication;
        private Button division;
        private TextBox input1;
        private TextBox input2;
    }
}
