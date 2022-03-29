namespace TuitionCalculator
{
    partial class Total
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
            this.answer = new System.Windows.Forms.Label();
            this.okay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Total Is";
            // 
            // answer
            // 
            this.answer.AutoSize = true;
            this.answer.Location = new System.Drawing.Point(211, 203);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(19, 29);
            this.answer.TabIndex = 1;
            this.answer.Text = " ";
            // 
            // okay
            // 
            this.okay.Location = new System.Drawing.Point(216, 302);
            this.okay.Name = "okay";
            this.okay.Size = new System.Drawing.Size(287, 108);
            this.okay.TabIndex = 2;
            this.okay.Text = "Okay";
            this.okay.UseVisualStyleBackColor = true;
            this.okay.Click += new System.EventHandler(this.okay_Click);
            // 
            // Total
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 572);
            this.Controls.Add(this.okay);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.label1);
            this.Name = "Total";
            this.Text = "Total";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button okay;
        public System.Windows.Forms.Label answer;
    }
}