namespace EM_29092014_lab1
{
    partial class SwapCriteriaAnalyzer
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
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonGraph = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.textBoxT = new System.Windows.Forms.TextBox();
            this.labelNumbersGot = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Результат";
            // 
            // labelResult
            // 
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.Location = new System.Drawing.Point(96, 89);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(466, 39);
            this.labelResult.TabIndex = 1;
            this.labelResult.Text = "0";
            // 
            // buttonGraph
            // 
            this.buttonGraph.Location = new System.Drawing.Point(159, 131);
            this.buttonGraph.Name = "buttonGraph";
            this.buttonGraph.Size = new System.Drawing.Size(197, 23);
            this.buttonGraph.TabIndex = 3;
            this.buttonGraph.Text = "Будувати графік зміни в часі";
            this.buttonGraph.UseVisualStyleBackColor = true;
            this.buttonGraph.Click += new System.EventHandler(this.buttonGraph_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "n (кількість груп)";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "t (кількість чисел в групі)";
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(159, 10);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(100, 20);
            this.textBoxN.TabIndex = 6;
            this.textBoxN.Text = "100";
            this.textBoxN.TextChanged += new System.EventHandler(this.textBoxN_TextChanged);
            // 
            // textBoxT
            // 
            this.textBoxT.Location = new System.Drawing.Point(159, 36);
            this.textBoxT.Name = "textBoxT";
            this.textBoxT.Size = new System.Drawing.Size(100, 20);
            this.textBoxT.TabIndex = 7;
            this.textBoxT.Text = "5";
            // 
            // labelNumbersGot
            // 
            this.labelNumbersGot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumbersGot.Location = new System.Drawing.Point(51, 64);
            this.labelNumbersGot.Name = "labelNumbersGot";
            this.labelNumbersGot.Size = new System.Drawing.Size(325, 20);
            this.labelNumbersGot.TabIndex = 8;
            this.labelNumbersGot.Text = "Отримано чисел...";
            this.labelNumbersGot.Click += new System.EventHandler(this.labelNumbersGot_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(265, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Застосувати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SwapCriteriaAnalyzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 168);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelNumbersGot);
            this.Controls.Add(this.textBoxT);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonGraph);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.label1);
            this.Name = "SwapCriteriaAnalyzer";
            this.Text = "MathExpectationAnalyzer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MathExpectationAnalyzer_FormClosing);
            this.Load += new System.EventHandler(this.MathExpectationAnalyzer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonGraph;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.TextBox textBoxT;
        private System.Windows.Forms.Label labelNumbersGot;
        private System.Windows.Forms.Button button1;
    }
}