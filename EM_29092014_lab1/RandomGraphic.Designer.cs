namespace EM_29092014_lab1
{
    partial class RandomGraphic
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
            this.labelMethodName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCorelation = new System.Windows.Forms.Button();
            this.checkBoxMusic = new System.Windows.Forms.CheckBox();
            this.labelPosition = new System.Windows.Forms.Label();
            this.checkBoxAnalyze = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxIterations = new System.Windows.Forms.TextBox();
            this.labelShortestCycle = new System.Windows.Forms.Label();
            this.labelLongestCycle = new System.Windows.Forms.Label();
            this.labelRepeatsPercent = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCycleThreshold = new System.Windows.Forms.TextBox();
            this.labelDispersion = new System.Windows.Forms.Label();
            this.labelAvg = new System.Windows.Forms.Label();
            this.labelIterations = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.buttonPlot = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonAddMathExpectationAnalyzer = new System.Windows.Forms.Button();
            this.buttonAddAnalyzerContinuousGaussRandomProcess = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonDeleteAnalyzer = new System.Windows.Forms.Button();
            this.listBoxAnalyzers = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAddDispersionAnalyzer = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMethodName
            // 
            this.labelMethodName.AutoSize = true;
            this.labelMethodName.Location = new System.Drawing.Point(12, 9);
            this.labelMethodName.Name = "labelMethodName";
            this.labelMethodName.Size = new System.Drawing.Size(78, 13);
            this.labelMethodName.TabIndex = 0;
            this.labelMethodName.Text = "Назва методу";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonCorelation);
            this.panel1.Controls.Add(this.checkBoxMusic);
            this.panel1.Controls.Add(this.labelPosition);
            this.panel1.Controls.Add(this.checkBoxAnalyze);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxIterations);
            this.panel1.Controls.Add(this.labelShortestCycle);
            this.panel1.Controls.Add(this.labelLongestCycle);
            this.panel1.Controls.Add(this.labelRepeatsPercent);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxCycleThreshold);
            this.panel1.Controls.Add(this.labelDispersion);
            this.panel1.Controls.Add(this.labelAvg);
            this.panel1.Controls.Add(this.labelIterations);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxMax);
            this.panel1.Controls.Add(this.textBoxMin);
            this.panel1.Controls.Add(this.buttonPlot);
            this.panel1.Controls.Add(this.labelMethodName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 100);
            this.panel1.TabIndex = 1;
            // 
            // buttonCorelation
            // 
            this.buttonCorelation.Location = new System.Drawing.Point(276, 71);
            this.buttonCorelation.Name = "buttonCorelation";
            this.buttonCorelation.Size = new System.Drawing.Size(75, 23);
            this.buttonCorelation.TabIndex = 21;
            this.buttonCorelation.Text = "Кореляція";
            this.buttonCorelation.UseVisualStyleBackColor = true;
            this.buttonCorelation.Click += new System.EventHandler(this.buttonCorelation_Click);
            // 
            // checkBoxMusic
            // 
            this.checkBoxMusic.AutoSize = true;
            this.checkBoxMusic.Checked = true;
            this.checkBoxMusic.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMusic.Location = new System.Drawing.Point(311, 29);
            this.checkBoxMusic.Name = "checkBoxMusic";
            this.checkBoxMusic.Size = new System.Drawing.Size(53, 17);
            this.checkBoxMusic.TabIndex = 4;
            this.checkBoxMusic.Text = "music";
            this.checkBoxMusic.UseVisualStyleBackColor = true;
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(516, 82);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(91, 13);
            this.labelPosition.TabIndex = 20;
            this.labelPosition.Text = "Позиція курсора";
            // 
            // checkBoxAnalyze
            // 
            this.checkBoxAnalyze.AutoSize = true;
            this.checkBoxAnalyze.Checked = true;
            this.checkBoxAnalyze.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAnalyze.Location = new System.Drawing.Point(184, 29);
            this.checkBoxAnalyze.Name = "checkBoxAnalyze";
            this.checkBoxAnalyze.Size = new System.Drawing.Size(121, 17);
            this.checkBoxAnalyze.TabIndex = 19;
            this.checkBoxAnalyze.Text = "Аналізувати метод";
            this.checkBoxAnalyze.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Кількість ітерацій";
            // 
            // textBoxIterations
            // 
            this.textBoxIterations.Location = new System.Drawing.Point(169, 74);
            this.textBoxIterations.Name = "textBoxIterations";
            this.textBoxIterations.Size = new System.Drawing.Size(61, 20);
            this.textBoxIterations.TabIndex = 17;
            this.textBoxIterations.Text = "-1";
            // 
            // labelShortestCycle
            // 
            this.labelShortestCycle.AutoSize = true;
            this.labelShortestCycle.Location = new System.Drawing.Point(512, 69);
            this.labelShortestCycle.Name = "labelShortestCycle";
            this.labelShortestCycle.Size = new System.Drawing.Size(217, 13);
            this.labelShortestCycle.TabIndex = 16;
            this.labelShortestCycle.Text = "Найкоротша відстань циклу: не знайдено";
            // 
            // labelLongestCycle
            // 
            this.labelLongestCycle.AutoSize = true;
            this.labelLongestCycle.Location = new System.Drawing.Point(512, 56);
            this.labelLongestCycle.Name = "labelLongestCycle";
            this.labelLongestCycle.Size = new System.Drawing.Size(92, 13);
            this.labelLongestCycle.TabIndex = 15;
            this.labelLongestCycle.Text = "Найдовший цикл";
            // 
            // labelRepeatsPercent
            // 
            this.labelRepeatsPercent.AutoSize = true;
            this.labelRepeatsPercent.Location = new System.Drawing.Point(512, 43);
            this.labelRepeatsPercent.Name = "labelRepeatsPercent";
            this.labelRepeatsPercent.Size = new System.Drawing.Size(97, 13);
            this.labelRepeatsPercent.TabIndex = 14;
            this.labelRepeatsPercent.Text = "Відсоток повторів";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Порог циклу";
            // 
            // textBoxCycleThreshold
            // 
            this.textBoxCycleThreshold.Location = new System.Drawing.Point(95, 74);
            this.textBoxCycleThreshold.Name = "textBoxCycleThreshold";
            this.textBoxCycleThreshold.Size = new System.Drawing.Size(32, 20);
            this.textBoxCycleThreshold.TabIndex = 10;
            this.textBoxCycleThreshold.Text = "10";
            // 
            // labelDispersion
            // 
            this.labelDispersion.AutoSize = true;
            this.labelDispersion.Location = new System.Drawing.Point(512, 30);
            this.labelDispersion.Name = "labelDispersion";
            this.labelDispersion.Size = new System.Drawing.Size(60, 13);
            this.labelDispersion.TabIndex = 9;
            this.labelDispersion.Text = "Дисперсія";
            // 
            // labelAvg
            // 
            this.labelAvg.AutoSize = true;
            this.labelAvg.Location = new System.Drawing.Point(512, 17);
            this.labelAvg.Name = "labelAvg";
            this.labelAvg.Size = new System.Drawing.Size(83, 13);
            this.labelAvg.TabIndex = 8;
            this.labelAvg.Text = "мат очікування";
            // 
            // labelIterations
            // 
            this.labelIterations.AutoSize = true;
            this.labelIterations.Location = new System.Drawing.Point(512, 4);
            this.labelIterations.Name = "labelIterations";
            this.labelIterations.Size = new System.Drawing.Size(43, 13);
            this.labelIterations.TabIndex = 7;
            this.labelIterations.Text = "ітерації";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Стоп";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "max";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "min";
            // 
            // textBoxMax
            // 
            this.textBoxMax.Location = new System.Drawing.Point(56, 74);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.Size = new System.Drawing.Size(32, 20);
            this.textBoxMax.TabIndex = 3;
            this.textBoxMax.Text = "100";
            // 
            // textBoxMin
            // 
            this.textBoxMin.Location = new System.Drawing.Point(15, 74);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.Size = new System.Drawing.Size(34, 20);
            this.textBoxMin.TabIndex = 2;
            this.textBoxMin.Text = "0";
            // 
            // buttonPlot
            // 
            this.buttonPlot.Location = new System.Drawing.Point(13, 26);
            this.buttonPlot.Name = "buttonPlot";
            this.buttonPlot.Size = new System.Drawing.Size(75, 23);
            this.buttonPlot.TabIndex = 1;
            this.buttonPlot.Text = "Графік";
            this.buttonPlot.UseVisualStyleBackColor = true;
            this.buttonPlot.Click += new System.EventHandler(this.buttonPlot_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(883, 454);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonAddDispersionAnalyzer);
            this.panel2.Controls.Add(this.buttonAddMathExpectationAnalyzer);
            this.panel2.Controls.Add(this.buttonAddAnalyzerContinuousGaussRandomProcess);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.buttonDeleteAnalyzer);
            this.panel2.Controls.Add(this.listBoxAnalyzers);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(486, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(397, 454);
            this.panel2.TabIndex = 3;
            // 
            // buttonAddMathExpectationAnalyzer
            // 
            this.buttonAddMathExpectationAnalyzer.Location = new System.Drawing.Point(210, 143);
            this.buttonAddMathExpectationAnalyzer.Name = "buttonAddMathExpectationAnalyzer";
            this.buttonAddMathExpectationAnalyzer.Size = new System.Drawing.Size(179, 37);
            this.buttonAddMathExpectationAnalyzer.TabIndex = 5;
            this.buttonAddMathExpectationAnalyzer.Text = "Додати аналізатор математичного очікування";
            this.buttonAddMathExpectationAnalyzer.UseVisualStyleBackColor = true;
            this.buttonAddMathExpectationAnalyzer.Click += new System.EventHandler(this.buttonAddMathExpectationAnalyzer_Click);
            // 
            // buttonAddAnalyzerContinuousGaussRandomProcess
            // 
            this.buttonAddAnalyzerContinuousGaussRandomProcess.Location = new System.Drawing.Point(210, 86);
            this.buttonAddAnalyzerContinuousGaussRandomProcess.Name = "buttonAddAnalyzerContinuousGaussRandomProcess";
            this.buttonAddAnalyzerContinuousGaussRandomProcess.Size = new System.Drawing.Size(179, 51);
            this.buttonAddAnalyzerContinuousGaussRandomProcess.TabIndex = 4;
            this.buttonAddAnalyzerContinuousGaussRandomProcess.Text = "Додати аналізатор неперервного гаусівсього випадкового процесу";
            this.buttonAddAnalyzerContinuousGaussRandomProcess.UseVisualStyleBackColor = true;
            this.buttonAddAnalyzerContinuousGaussRandomProcess.Click += new System.EventHandler(this.buttonAddAnalyzerContinuousGaussRandomProcess_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Активні аналізатори";
            // 
            // buttonDeleteAnalyzer
            // 
            this.buttonDeleteAnalyzer.Location = new System.Drawing.Point(210, 56);
            this.buttonDeleteAnalyzer.Name = "buttonDeleteAnalyzer";
            this.buttonDeleteAnalyzer.Size = new System.Drawing.Size(179, 23);
            this.buttonDeleteAnalyzer.TabIndex = 2;
            this.buttonDeleteAnalyzer.Text = "Видалити аналізатор";
            this.buttonDeleteAnalyzer.UseVisualStyleBackColor = true;
            this.buttonDeleteAnalyzer.Click += new System.EventHandler(this.buttonDeleteAnalyzer_Click);
            // 
            // listBoxAnalyzers
            // 
            this.listBoxAnalyzers.Location = new System.Drawing.Point(7, 56);
            this.listBoxAnalyzers.Name = "listBoxAnalyzers";
            this.listBoxAnalyzers.Size = new System.Drawing.Size(200, 212);
            this.listBoxAnalyzers.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Блок аналізу методів";
            // 
            // buttonAddDispersionAnalyzer
            // 
            this.buttonAddDispersionAnalyzer.Location = new System.Drawing.Point(210, 186);
            this.buttonAddDispersionAnalyzer.Name = "buttonAddDispersionAnalyzer";
            this.buttonAddDispersionAnalyzer.Size = new System.Drawing.Size(179, 37);
            this.buttonAddDispersionAnalyzer.TabIndex = 6;
            this.buttonAddDispersionAnalyzer.Text = "Додати аналізатор дисперсії";
            this.buttonAddDispersionAnalyzer.UseVisualStyleBackColor = true;
            this.buttonAddDispersionAnalyzer.Click += new System.EventHandler(this.buttonAddDispersionAnalyzer_Click);
            // 
            // RandomGraphic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 554);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "RandomGraphic";
            this.Text = "Аналіз випадкового розподілу";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RandomGraphic_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelMethodName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonPlot;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.TextBox textBoxMin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelIterations;
        private System.Windows.Forms.Label labelAvg;
        private System.Windows.Forms.Label labelDispersion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCycleThreshold;
        private System.Windows.Forms.Label labelRepeatsPercent;
        private System.Windows.Forms.Label labelLongestCycle;
        private System.Windows.Forms.Label labelShortestCycle;
        private System.Windows.Forms.CheckBox checkBoxAnalyze;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxIterations;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.CheckBox checkBoxMusic;
        private System.Windows.Forms.Button buttonCorelation;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonAddAnalyzerContinuousGaussRandomProcess;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonDeleteAnalyzer;
        private System.Windows.Forms.ListBox listBoxAnalyzers;
        private System.Windows.Forms.Button buttonAddMathExpectationAnalyzer;
        private System.Windows.Forms.Button buttonAddDispersionAnalyzer;
    }
}