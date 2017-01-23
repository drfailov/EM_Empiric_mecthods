namespace EM_29092014_lab1
{
    partial class MethodAnalyzeWindow
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
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxIterations = new System.Windows.Forms.TextBox();
            this.labelIterations = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonPlot = new System.Windows.Forms.Button();
            this.buttonAddDensityAnalyser = new System.Windows.Forms.Button();
            this.buttonAddDispersionAnalyzer = new System.Windows.Forms.Button();
            this.buttonAddMathExpectationAnalyzer = new System.Windows.Forms.Button();
            this.buttonAddAnalyzerContinuousGaussRandomProcess = new System.Windows.Forms.Button();
            this.buttonDeleteAnalyzer = new System.Windows.Forms.Button();
            this.listBoxAnalyzers = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelNumber = new System.Windows.Forms.Label();
            this.buttonGenerateOne = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.checkBoxInterval = new System.Windows.Forms.CheckBox();
            this.checkBoxdouble = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonDeleteAll = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAddLogGenerator = new System.Windows.Forms.Button();
            this.buttonAddEventTimeAnalyzer = new System.Windows.Forms.Button();
            this.buttonAddAutocorelationCriteria = new System.Windows.Forms.Button();
            this.buttonSwapCriteria = new System.Windows.Forms.Button();
            this.buttonAddCycleAnalyzer = new System.Windows.Forms.Button();
            this.buttonAddRepeatsAnalyzer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMethodName
            // 
            this.labelMethodName.AutoSize = true;
            this.labelMethodName.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelMethodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMethodName.Location = new System.Drawing.Point(0, 0);
            this.labelMethodName.Name = "labelMethodName";
            this.labelMethodName.Padding = new System.Windows.Forms.Padding(10);
            this.labelMethodName.Size = new System.Drawing.Size(138, 38);
            this.labelMethodName.TabIndex = 0;
            this.labelMethodName.Text = "Назва методу";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Кількість ітерацій";
            // 
            // textBoxIterations
            // 
            this.textBoxIterations.Location = new System.Drawing.Point(186, 3);
            this.textBoxIterations.Name = "textBoxIterations";
            this.textBoxIterations.Size = new System.Drawing.Size(55, 20);
            this.textBoxIterations.TabIndex = 17;
            this.textBoxIterations.Text = "-1";
            // 
            // labelIterations
            // 
            this.labelIterations.AutoSize = true;
            this.labelIterations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIterations.Location = new System.Drawing.Point(144, 29);
            this.labelIterations.Name = "labelIterations";
            this.labelIterations.Size = new System.Drawing.Size(63, 20);
            this.labelIterations.TabIndex = 7;
            this.labelIterations.Text = "ітерації";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 26);
            this.button1.TabIndex = 6;
            this.button1.Text = "Стоп";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonPlot
            // 
            this.buttonPlot.Location = new System.Drawing.Point(6, 19);
            this.buttonPlot.Name = "buttonPlot";
            this.buttonPlot.Size = new System.Drawing.Size(122, 43);
            this.buttonPlot.TabIndex = 1;
            this.buttonPlot.Text = "Старт";
            this.buttonPlot.UseVisualStyleBackColor = true;
            this.buttonPlot.Click += new System.EventHandler(this.buttonPlot_Click);
            this.buttonPlot.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonPlot_MouseDown);
            // 
            // buttonAddDensityAnalyser
            // 
            this.buttonAddDensityAnalyser.Location = new System.Drawing.Point(3, 9);
            this.buttonAddDensityAnalyser.Name = "buttonAddDensityAnalyser";
            this.buttonAddDensityAnalyser.Size = new System.Drawing.Size(365, 30);
            this.buttonAddDensityAnalyser.TabIndex = 7;
            this.buttonAddDensityAnalyser.Text = "Додати аналізатор густини розподілу";
            this.buttonAddDensityAnalyser.UseVisualStyleBackColor = true;
            this.buttonAddDensityAnalyser.Click += new System.EventHandler(this.buttonAddDensityAnalyser_Click);
            // 
            // buttonAddDispersionAnalyzer
            // 
            this.buttonAddDispersionAnalyzer.Location = new System.Drawing.Point(3, 76);
            this.buttonAddDispersionAnalyzer.Name = "buttonAddDispersionAnalyzer";
            this.buttonAddDispersionAnalyzer.Size = new System.Drawing.Size(365, 24);
            this.buttonAddDispersionAnalyzer.TabIndex = 6;
            this.buttonAddDispersionAnalyzer.Text = "Додати аналізатор дисперсії";
            this.buttonAddDispersionAnalyzer.UseVisualStyleBackColor = true;
            this.buttonAddDispersionAnalyzer.Click += new System.EventHandler(this.buttonAddDispersionAnalyzer_Click);
            // 
            // buttonAddMathExpectationAnalyzer
            // 
            this.buttonAddMathExpectationAnalyzer.Location = new System.Drawing.Point(3, 45);
            this.buttonAddMathExpectationAnalyzer.Name = "buttonAddMathExpectationAnalyzer";
            this.buttonAddMathExpectationAnalyzer.Size = new System.Drawing.Size(365, 25);
            this.buttonAddMathExpectationAnalyzer.TabIndex = 5;
            this.buttonAddMathExpectationAnalyzer.Text = "Додати аналізатор математичного очікування";
            this.buttonAddMathExpectationAnalyzer.UseVisualStyleBackColor = true;
            this.buttonAddMathExpectationAnalyzer.Click += new System.EventHandler(this.buttonAddMathExpectationAnalyzer_Click);
            // 
            // buttonAddAnalyzerContinuousGaussRandomProcess
            // 
            this.buttonAddAnalyzerContinuousGaussRandomProcess.Location = new System.Drawing.Point(5, 999);
            this.buttonAddAnalyzerContinuousGaussRandomProcess.Name = "buttonAddAnalyzerContinuousGaussRandomProcess";
            this.buttonAddAnalyzerContinuousGaussRandomProcess.Size = new System.Drawing.Size(365, 25);
            this.buttonAddAnalyzerContinuousGaussRandomProcess.TabIndex = 4;
            this.buttonAddAnalyzerContinuousGaussRandomProcess.TabStop = false;
            this.buttonAddAnalyzerContinuousGaussRandomProcess.Text = "Додати аналізатор неперервного гаусівсього випадкового процесу";
            this.buttonAddAnalyzerContinuousGaussRandomProcess.UseVisualStyleBackColor = true;
            this.buttonAddAnalyzerContinuousGaussRandomProcess.Click += new System.EventHandler(this.buttonAddAnalyzerContinuousGaussRandomProcess_Click);
            // 
            // buttonDeleteAnalyzer
            // 
            this.buttonDeleteAnalyzer.Location = new System.Drawing.Point(155, 11);
            this.buttonDeleteAnalyzer.Name = "buttonDeleteAnalyzer";
            this.buttonDeleteAnalyzer.Size = new System.Drawing.Size(127, 23);
            this.buttonDeleteAnalyzer.TabIndex = 2;
            this.buttonDeleteAnalyzer.Text = "Видалити вибраний";
            this.buttonDeleteAnalyzer.UseVisualStyleBackColor = true;
            this.buttonDeleteAnalyzer.Click += new System.EventHandler(this.buttonDeleteAnalyzer_Click);
            // 
            // listBoxAnalyzers
            // 
            this.listBoxAnalyzers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxAnalyzers.Location = new System.Drawing.Point(8, 21);
            this.listBoxAnalyzers.Margin = new System.Windows.Forms.Padding(10);
            this.listBoxAnalyzers.Name = "listBoxAnalyzers";
            this.listBoxAnalyzers.Size = new System.Drawing.Size(545, 154);
            this.listBoxAnalyzers.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelNumber);
            this.groupBox1.Controls.Add(this.buttonGenerateOne);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.buttonPlot);
            this.groupBox1.Controls.Add(this.labelIterations);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(561, 136);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Керування процесом аналізу";
            // 
            // labelNumber
            // 
            this.labelNumber.BackColor = System.Drawing.Color.LightBlue;
            this.labelNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNumber.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumber.Location = new System.Drawing.Point(148, 68);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(141, 36);
            this.labelNumber.TabIndex = 22;
            this.labelNumber.Text = "0,2354654";
            this.labelNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonGenerateOne
            // 
            this.buttonGenerateOne.Location = new System.Drawing.Point(6, 100);
            this.buttonGenerateOne.Name = "buttonGenerateOne";
            this.buttonGenerateOne.Size = new System.Drawing.Size(122, 26);
            this.buttonGenerateOne.TabIndex = 21;
            this.buttonGenerateOne.Text = "Генерувати одне";
            this.buttonGenerateOne.UseVisualStyleBackColor = true;
            this.buttonGenerateOne.Click += new System.EventHandler(this.buttonGenerateOne_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBoxMax);
            this.panel3.Controls.Add(this.textBoxMin);
            this.panel3.Controls.Add(this.checkBoxInterval);
            this.panel3.Controls.Add(this.textBoxIterations);
            this.panel3.Controls.Add(this.checkBoxdouble);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(307, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(248, 111);
            this.panel3.TabIndex = 20;
            // 
            // textBoxMax
            // 
            this.textBoxMax.Location = new System.Drawing.Point(153, 66);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.Size = new System.Drawing.Size(52, 20);
            this.textBoxMax.TabIndex = 22;
            this.textBoxMax.Text = "100";
            // 
            // textBoxMin
            // 
            this.textBoxMin.Location = new System.Drawing.Point(95, 66);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.Size = new System.Drawing.Size(52, 20);
            this.textBoxMin.TabIndex = 21;
            this.textBoxMin.Text = "0";
            // 
            // checkBoxInterval
            // 
            this.checkBoxInterval.AutoSize = true;
            this.checkBoxInterval.Location = new System.Drawing.Point(19, 70);
            this.checkBoxInterval.Name = "checkBoxInterval";
            this.checkBoxInterval.Size = new System.Drawing.Size(70, 17);
            this.checkBoxInterval.TabIndex = 20;
            this.checkBoxInterval.Text = "Інтервал";
            this.checkBoxInterval.UseVisualStyleBackColor = true;
            // 
            // checkBoxdouble
            // 
            this.checkBoxdouble.AutoSize = true;
            this.checkBoxdouble.Location = new System.Drawing.Point(133, 37);
            this.checkBoxdouble.Name = "checkBoxdouble";
            this.checkBoxdouble.Size = new System.Drawing.Size(108, 17);
            this.checkBoxdouble.TabIndex = 19;
            this.checkBoxdouble.Text = "Генерувати 0...1";
            this.checkBoxdouble.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxAnalyzers);
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(10, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(8);
            this.groupBox2.Size = new System.Drawing.Size(561, 231);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Активні аналізатори";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(8, 175);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(545, 48);
            this.panel4.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.buttonDeleteAll);
            this.panel5.Controls.Add(this.buttonDeleteAnalyzer);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(254, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(291, 48);
            this.panel5.TabIndex = 4;
            // 
            // buttonDeleteAll
            // 
            this.buttonDeleteAll.Location = new System.Drawing.Point(26, 11);
            this.buttonDeleteAll.Name = "buttonDeleteAll";
            this.buttonDeleteAll.Size = new System.Drawing.Size(127, 23);
            this.buttonDeleteAll.TabIndex = 3;
            this.buttonDeleteAll.Text = "Видалити всі";
            this.buttonDeleteAll.UseVisualStyleBackColor = true;
            this.buttonDeleteAll.Click += new System.EventHandler(this.buttonDeleteAll_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(581, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(396, 387);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Додати аналізатори";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.buttonAddLogGenerator);
            this.panel1.Controls.Add(this.buttonAddMathExpectationAnalyzer);
            this.panel1.Controls.Add(this.buttonAddDensityAnalyser);
            this.panel1.Controls.Add(this.buttonAddEventTimeAnalyzer);
            this.panel1.Controls.Add(this.buttonAddAutocorelationCriteria);
            this.panel1.Controls.Add(this.buttonSwapCriteria);
            this.panel1.Controls.Add(this.buttonAddCycleAnalyzer);
            this.panel1.Controls.Add(this.buttonAddRepeatsAnalyzer);
            this.panel1.Controls.Add(this.buttonAddDispersionAnalyzer);
            this.panel1.Controls.Add(this.buttonAddAnalyzerContinuousGaussRandomProcess);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 368);
            this.panel1.TabIndex = 0;
            // 
            // buttonAddLogGenerator
            // 
            this.buttonAddLogGenerator.Location = new System.Drawing.Point(3, 226);
            this.buttonAddLogGenerator.Name = "buttonAddLogGenerator";
            this.buttonAddLogGenerator.Size = new System.Drawing.Size(365, 24);
            this.buttonAddLogGenerator.TabIndex = 14;
            this.buttonAddLogGenerator.Text = "Додати генератор логу";
            this.buttonAddLogGenerator.UseVisualStyleBackColor = true;
            this.buttonAddLogGenerator.Click += new System.EventHandler(this.buttonAddLogGenerator_Click);
            // 
            // buttonAddEventTimeAnalyzer
            // 
            this.buttonAddEventTimeAnalyzer.Location = new System.Drawing.Point(5, 968);
            this.buttonAddEventTimeAnalyzer.Name = "buttonAddEventTimeAnalyzer";
            this.buttonAddEventTimeAnalyzer.Size = new System.Drawing.Size(365, 25);
            this.buttonAddEventTimeAnalyzer.TabIndex = 13;
            this.buttonAddEventTimeAnalyzer.Text = "Додати аналізатор час появи заданої події";
            this.buttonAddEventTimeAnalyzer.UseVisualStyleBackColor = true;
            this.buttonAddEventTimeAnalyzer.Click += new System.EventHandler(this.buttonAddEventTimeAnalyzer_Click);
            // 
            // buttonAddAutocorelationCriteria
            // 
            this.buttonAddAutocorelationCriteria.Location = new System.Drawing.Point(3, 196);
            this.buttonAddAutocorelationCriteria.Name = "buttonAddAutocorelationCriteria";
            this.buttonAddAutocorelationCriteria.Size = new System.Drawing.Size(365, 24);
            this.buttonAddAutocorelationCriteria.TabIndex = 12;
            this.buttonAddAutocorelationCriteria.Text = "Додати автокореляційний критерій";
            this.buttonAddAutocorelationCriteria.UseVisualStyleBackColor = true;
            this.buttonAddAutocorelationCriteria.Click += new System.EventHandler(this.buttonAddAutocorelationCriteria_Click);
            // 
            // buttonSwapCriteria
            // 
            this.buttonSwapCriteria.Location = new System.Drawing.Point(3, 166);
            this.buttonSwapCriteria.Name = "buttonSwapCriteria";
            this.buttonSwapCriteria.Size = new System.Drawing.Size(365, 24);
            this.buttonSwapCriteria.TabIndex = 11;
            this.buttonSwapCriteria.Text = "Додати критерій перестановок";
            this.buttonSwapCriteria.UseVisualStyleBackColor = true;
            this.buttonSwapCriteria.Click += new System.EventHandler(this.buttonSwapCriteria_Click);
            // 
            // buttonAddCycleAnalyzer
            // 
            this.buttonAddCycleAnalyzer.Location = new System.Drawing.Point(3, 136);
            this.buttonAddCycleAnalyzer.Name = "buttonAddCycleAnalyzer";
            this.buttonAddCycleAnalyzer.Size = new System.Drawing.Size(365, 24);
            this.buttonAddCycleAnalyzer.TabIndex = 10;
            this.buttonAddCycleAnalyzer.Text = "Додати аналізатор циклів";
            this.buttonAddCycleAnalyzer.UseVisualStyleBackColor = true;
            this.buttonAddCycleAnalyzer.Click += new System.EventHandler(this.buttonAddCycleAnalyzer_Click);
            // 
            // buttonAddRepeatsAnalyzer
            // 
            this.buttonAddRepeatsAnalyzer.Location = new System.Drawing.Point(3, 106);
            this.buttonAddRepeatsAnalyzer.Name = "buttonAddRepeatsAnalyzer";
            this.buttonAddRepeatsAnalyzer.Size = new System.Drawing.Size(365, 24);
            this.buttonAddRepeatsAnalyzer.TabIndex = 9;
            this.buttonAddRepeatsAnalyzer.Text = "Додати аналізатор повторів";
            this.buttonAddRepeatsAnalyzer.UseVisualStyleBackColor = true;
            this.buttonAddRepeatsAnalyzer.Click += new System.EventHandler(this.buttonAddRepeatsAnalyzer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 1082);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Кінець списку";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelStatus.Location = new System.Drawing.Point(0, 425);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Padding = new System.Windows.Forms.Padding(5, 5, 5, 20);
            this.labelStatus.Size = new System.Drawing.Size(51, 38);
            this.labelStatus.TabIndex = 22;
            this.labelStatus.Text = "Статус";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(581, 387);
            this.panel2.TabIndex = 23;
            // 
            // MethodAnalyzeWindow
            // 
            this.AcceptButton = this.buttonAddDensityAnalyser;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 463);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelMethodName);
            this.Name = "MethodAnalyzeWindow";
            this.Text = "Аналіз випадкового розподілу";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RandomGraphic_FormClosing);
            this.Load += new System.EventHandler(this.MethodAnalyzeWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMethodName;
        private System.Windows.Forms.Button buttonPlot;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelIterations;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxIterations;
        private System.Windows.Forms.Button buttonAddAnalyzerContinuousGaussRandomProcess;
        private System.Windows.Forms.Button buttonDeleteAnalyzer;
        private System.Windows.Forms.ListBox listBoxAnalyzers;
        private System.Windows.Forms.Button buttonAddMathExpectationAnalyzer;
        private System.Windows.Forms.Button buttonAddDispersionAnalyzer;
        private System.Windows.Forms.Button buttonAddDensityAnalyser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddRepeatsAnalyzer;
        private System.Windows.Forms.Button buttonAddCycleAnalyzer;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button buttonDeleteAll;
        private System.Windows.Forms.Button buttonSwapCriteria;
        private System.Windows.Forms.Button buttonAddAutocorelationCriteria;
        private System.Windows.Forms.CheckBox checkBoxdouble;
        private System.Windows.Forms.Button buttonAddEventTimeAnalyzer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.TextBox textBoxMin;
        private System.Windows.Forms.CheckBox checkBoxInterval;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Button buttonGenerateOne;
        private System.Windows.Forms.Button buttonAddLogGenerator;
    }
}