namespace TuitionCalculator
{
    partial class Options
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.calculate = new System.Windows.Forms.Button();
            this.AllenCheck = new System.Windows.Forms.CheckBox();
            this.PikeCheck = new System.Windows.Forms.CheckBox();
            this.FarthingCheck = new System.Windows.Forms.CheckBox();
            this.SuitesCheck = new System.Windows.Forms.CheckBox();
            this.SevenCheck = new System.Windows.Forms.CheckBox();
            this.FourteenCheck = new System.Windows.Forms.CheckBox();
            this.UnlimitedCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please pick a dorm option";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(692, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Please pick a meal option";
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(110, 427);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(256, 151);
            this.calculate.TabIndex = 11;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // AllenCheck
            // 
            this.AllenCheck.AutoSize = true;
            this.AllenCheck.Location = new System.Drawing.Point(110, 167);
            this.AllenCheck.Name = "AllenCheck";
            this.AllenCheck.Size = new System.Drawing.Size(232, 33);
            this.AllenCheck.TabIndex = 12;
            this.AllenCheck.Text = "Allen Hall - $1500";
            this.AllenCheck.UseVisualStyleBackColor = true;
            // 
            // PikeCheck
            // 
            this.PikeCheck.AutoSize = true;
            this.PikeCheck.Location = new System.Drawing.Point(110, 206);
            this.PikeCheck.Name = "PikeCheck";
            this.PikeCheck.Size = new System.Drawing.Size(226, 33);
            this.PikeCheck.TabIndex = 13;
            this.PikeCheck.Text = "Pike Hall - $1600";
            this.PikeCheck.UseVisualStyleBackColor = true;
            // 
            // FarthingCheck
            // 
            this.FarthingCheck.AutoSize = true;
            this.FarthingCheck.Location = new System.Drawing.Point(110, 255);
            this.FarthingCheck.Name = "FarthingCheck";
            this.FarthingCheck.Size = new System.Drawing.Size(266, 33);
            this.FarthingCheck.TabIndex = 14;
            this.FarthingCheck.Text = "Farthing Hall - $1800";
            this.FarthingCheck.UseVisualStyleBackColor = true;
            // 
            // SuitesCheck
            // 
            this.SuitesCheck.AutoSize = true;
            this.SuitesCheck.Location = new System.Drawing.Point(110, 294);
            this.SuitesCheck.Name = "SuitesCheck";
            this.SuitesCheck.Size = new System.Drawing.Size(307, 33);
            this.SuitesCheck.TabIndex = 15;
            this.SuitesCheck.Text = "University Suites - $2500";
            this.SuitesCheck.UseVisualStyleBackColor = true;
            // 
            // SevenCheck
            // 
            this.SevenCheck.AutoSize = true;
            this.SevenCheck.Location = new System.Drawing.Point(697, 177);
            this.SevenCheck.Name = "SevenCheck";
            this.SevenCheck.Size = new System.Drawing.Size(201, 33);
            this.SevenCheck.TabIndex = 16;
            this.SevenCheck.Text = "7 Meals - $600";
            this.SevenCheck.UseVisualStyleBackColor = true;
            // 
            // FourteenCheck
            // 
            this.FourteenCheck.AutoSize = true;
            this.FourteenCheck.Location = new System.Drawing.Point(697, 216);
            this.FourteenCheck.Name = "FourteenCheck";
            this.FourteenCheck.Size = new System.Drawing.Size(227, 33);
            this.FourteenCheck.TabIndex = 17;
            this.FourteenCheck.Text = "14 Meals - $1200";
            this.FourteenCheck.UseVisualStyleBackColor = true;
            // 
            // UnlimitedCheck
            // 
            this.UnlimitedCheck.AutoSize = true;
            this.UnlimitedCheck.Location = new System.Drawing.Point(697, 267);
            this.UnlimitedCheck.Name = "UnlimitedCheck";
            this.UnlimitedCheck.Size = new System.Drawing.Size(232, 33);
            this.UnlimitedCheck.TabIndex = 18;
            this.UnlimitedCheck.Text = "Unlimited - $1700";
            this.UnlimitedCheck.UseVisualStyleBackColor = true;
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1863, 834);
            this.Controls.Add(this.UnlimitedCheck);
            this.Controls.Add(this.FourteenCheck);
            this.Controls.Add(this.SevenCheck);
            this.Controls.Add(this.SuitesCheck);
            this.Controls.Add(this.FarthingCheck);
            this.Controls.Add(this.PikeCheck);
            this.Controls.Add(this.AllenCheck);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Options";
            this.Text = "Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.CheckBox AllenCheck;
        private System.Windows.Forms.CheckBox PikeCheck;
        private System.Windows.Forms.CheckBox FarthingCheck;
        private System.Windows.Forms.CheckBox SuitesCheck;
        private System.Windows.Forms.CheckBox SevenCheck;
        private System.Windows.Forms.CheckBox FourteenCheck;
        private System.Windows.Forms.CheckBox UnlimitedCheck;
    }
}

