namespace _1600_ICA_1
{
    partial class ICA1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Value_lbl = new System.Windows.Forms.Label();
            this.CurAvg_lbl = new System.Windows.Forms.Label();
            this.CurAvg_val = new System.Windows.Forms.Label();
            this.NumVal_lbl = new System.Windows.Forms.Label();
            this.NumVal_val = new System.Windows.Forms.Label();
            this.Avg_button = new System.Windows.Forms.Button();
            this.Reset_buttton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(354, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 20);
            this.textBox1.TabIndex = 0;
            // 
            // Value_lbl
            // 
            this.Value_lbl.AutoSize = true;
            this.Value_lbl.Location = new System.Drawing.Point(59, 33);
            this.Value_lbl.Name = "Value_lbl";
            this.Value_lbl.Size = new System.Drawing.Size(34, 13);
            this.Value_lbl.TabIndex = 1;
            this.Value_lbl.Text = "Value";
            this.Value_lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // CurAvg_lbl
            // 
            this.CurAvg_lbl.AutoSize = true;
            this.CurAvg_lbl.Location = new System.Drawing.Point(59, 88);
            this.CurAvg_lbl.Name = "CurAvg_lbl";
            this.CurAvg_lbl.Size = new System.Drawing.Size(84, 13);
            this.CurAvg_lbl.TabIndex = 2;
            this.CurAvg_lbl.Text = "Current Average";
            // 
            // CurAvg_val
            // 
            this.CurAvg_val.AutoSize = true;
            this.CurAvg_val.Location = new System.Drawing.Point(354, 84);
            this.CurAvg_val.Name = "CurAvg_val";
            this.CurAvg_val.Size = new System.Drawing.Size(35, 13);
            this.CurAvg_val.TabIndex = 3;
            this.CurAvg_val.Text = "label1";
            // 
            // NumVal_lbl
            // 
            this.NumVal_lbl.AutoSize = true;
            this.NumVal_lbl.Location = new System.Drawing.Point(59, 142);
            this.NumVal_lbl.Name = "NumVal_lbl";
            this.NumVal_lbl.Size = new System.Drawing.Size(91, 13);
            this.NumVal_lbl.TabIndex = 4;
            this.NumVal_lbl.Text = "Number of Values";
            // 
            // NumVal_val
            // 
            this.NumVal_val.AutoSize = true;
            this.NumVal_val.Location = new System.Drawing.Point(356, 135);
            this.NumVal_val.Name = "NumVal_val";
            this.NumVal_val.Size = new System.Drawing.Size(35, 13);
            this.NumVal_val.TabIndex = 5;
            this.NumVal_val.Text = "label1";
            // 
            // Avg_button
            // 
            this.Avg_button.Location = new System.Drawing.Point(91, 265);
            this.Avg_button.Name = "Avg_button";
            this.Avg_button.Size = new System.Drawing.Size(159, 50);
            this.Avg_button.TabIndex = 6;
            this.Avg_button.Text = "Average";
            this.Avg_button.UseVisualStyleBackColor = true;
            this.Avg_button.Click += new System.EventHandler(this.Avg_button_Click);
            // 
            // Reset_buttton
            // 
            this.Reset_buttton.Location = new System.Drawing.Point(354, 265);
            this.Reset_buttton.Name = "Reset_buttton";
            this.Reset_buttton.Size = new System.Drawing.Size(182, 50);
            this.Reset_buttton.TabIndex = 7;
            this.Reset_buttton.Text = "Reset";
            this.Reset_buttton.UseVisualStyleBackColor = true;
            this.Reset_buttton.Click += new System.EventHandler(this.Reset_buttton_Click);
            // 
            // ICA1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 393);
            this.Controls.Add(this.Reset_buttton);
            this.Controls.Add(this.Avg_button);
            this.Controls.Add(this.NumVal_val);
            this.Controls.Add(this.NumVal_lbl);
            this.Controls.Add(this.CurAvg_val);
            this.Controls.Add(this.CurAvg_lbl);
            this.Controls.Add(this.Value_lbl);
            this.Controls.Add(this.textBox1);
            this.Name = "ICA1";
            this.Text = "ICA1";
            this.Load += new System.EventHandler(this.ICA1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Value_lbl;
        private System.Windows.Forms.Label CurAvg_lbl;
        private System.Windows.Forms.Label CurAvg_val;
        private System.Windows.Forms.Label NumVal_lbl;
        private System.Windows.Forms.Label NumVal_val;
        private System.Windows.Forms.Button Avg_button;
        private System.Windows.Forms.Button Reset_buttton;
    }
}

