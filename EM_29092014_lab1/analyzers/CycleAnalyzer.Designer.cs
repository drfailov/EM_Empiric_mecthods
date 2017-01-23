namespace EM_29092014_lab1
{
    partial class CycleAnalyzer
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
            this.labelLongestCycle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxСycleThreshold = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelRepeatingNumbers = new System.Windows.Forms.Label();
            this.labelShortestDistance = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelCycleFound = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Найдовший цикл";
            // 
            // labelLongestCycle
            // 
            this.labelLongestCycle.AutoSize = true;
            this.labelLongestCycle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLongestCycle.Location = new System.Drawing.Point(166, 69);
            this.labelLongestCycle.Name = "labelLongestCycle";
            this.labelLongestCycle.Size = new System.Drawing.Size(24, 25);
            this.labelLongestCycle.TabIndex = 1;
            this.labelLongestCycle.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Кількість повторів";
            // 
            // textBoxСycleThreshold
            // 
            this.textBoxСycleThreshold.Location = new System.Drawing.Point(112, 10);
            this.textBoxСycleThreshold.Name = "textBoxСycleThreshold";
            this.textBoxСycleThreshold.Size = new System.Drawing.Size(100, 20);
            this.textBoxСycleThreshold.TabIndex = 3;
            this.textBoxСycleThreshold.Text = "11";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelRepeatingNumbers);
            this.groupBox1.Location = new System.Drawing.Point(218, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 233);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Проблемні числа";
            // 
            // labelRepeatingNumbers
            // 
            this.labelRepeatingNumbers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRepeatingNumbers.Location = new System.Drawing.Point(3, 16);
            this.labelRepeatingNumbers.Name = "labelRepeatingNumbers";
            this.labelRepeatingNumbers.Padding = new System.Windows.Forms.Padding(5);
            this.labelRepeatingNumbers.Size = new System.Drawing.Size(217, 214);
            this.labelRepeatingNumbers.TabIndex = 0;
            this.labelRepeatingNumbers.Text = "...";
            // 
            // labelShortestDistance
            // 
            this.labelShortestDistance.AutoSize = true;
            this.labelShortestDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelShortestDistance.Location = new System.Drawing.Point(166, 126);
            this.labelShortestDistance.Name = "labelShortestDistance";
            this.labelShortestDistance.Size = new System.Drawing.Size(24, 25);
            this.labelShortestDistance.TabIndex = 6;
            this.labelShortestDistance.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Найкоротша відстань циклу";
            // 
            // labelCycleFound
            // 
            this.labelCycleFound.AutoSize = true;
            this.labelCycleFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCycleFound.ForeColor = System.Drawing.Color.Crimson;
            this.labelCycleFound.Location = new System.Drawing.Point(3, 184);
            this.labelCycleFound.Name = "labelCycleFound";
            this.labelCycleFound.Size = new System.Drawing.Size(212, 31);
            this.labelCycleFound.TabIndex = 7;
            this.labelCycleFound.Text = "Знайдено цикл!";
            this.labelCycleFound.Visible = false;
            // 
            // CycleAnalyzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 256);
            this.Controls.Add(this.labelCycleFound);
            this.Controls.Add(this.labelShortestDistance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxСycleThreshold);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelLongestCycle);
            this.Controls.Add(this.label1);
            this.Name = "CycleAnalyzer";
            this.Text = "Пошук циклів";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MathExpectationAnalyzer_FormClosing);
            this.Load += new System.EventHandler(this.MathExpectationAnalyzer_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelLongestCycle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxСycleThreshold;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelRepeatingNumbers;
        private System.Windows.Forms.Label labelShortestDistance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelCycleFound;

    }
}