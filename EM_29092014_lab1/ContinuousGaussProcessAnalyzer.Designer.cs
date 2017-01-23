namespace EM_29092014_lab1
{
    partial class ContinuousGaussProcessAnalyzer
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
            this.labelNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelFilling = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Отримано число";
            // 
            // labelNumber
            // 
            this.labelNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumber.Location = new System.Drawing.Point(133, 22);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(445, 36);
            this.labelNumber.TabIndex = 1;
            this.labelNumber.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Заповнення масива";
            // 
            // labelFilling
            // 
            this.labelFilling.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFilling.Location = new System.Drawing.Point(133, 80);
            this.labelFilling.Name = "labelFilling";
            this.labelFilling.Size = new System.Drawing.Size(445, 36);
            this.labelFilling.TabIndex = 3;
            this.labelFilling.Text = "label2";
            // 
            // ContinuousGaussProcessAnalyzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 173);
            this.Controls.Add(this.labelFilling);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.label1);
            this.Name = "ContinuousGaussProcessAnalyzer";
            this.Text = "ContinuousGaussProcessAnalyzer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ContinuousGaussProcessAnalyzer_FormClosing);
            this.Load += new System.EventHandler(this.ContinuousGaussProcessAnalyzer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelFilling;

    }
}