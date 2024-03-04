namespace Lab2.UI
{
    partial class SingleForm
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
            this.graph = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.label1 = new System.Windows.Forms.Label();
            this.equationBox = new System.Windows.Forms.ComboBox();
            this.intervalLabel = new System.Windows.Forms.Label();
            this.boundBox = new System.Windows.Forms.TextBox();
            this.toLabel = new System.Windows.Forms.Label();
            this.secondBoundBox = new System.Windows.Forms.TextBox();
            this.selectStarerBox = new System.Windows.Forms.CheckBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.changeFormButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.methodBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.epsilonBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.graph)).BeginInit();
            this.SuspendLayout();
            // 
            // graph
            // 
            this.graph.AllowExternalDrop = true;
            this.graph.CreationProperties = null;
            this.graph.DefaultBackgroundColor = System.Drawing.Color.White;
            this.graph.Location = new System.Drawing.Point(11, 116);
            this.graph.Margin = new System.Windows.Forms.Padding(2);
            this.graph.Name = "graph";
            this.graph.Size = new System.Drawing.Size(364, 214);
            this.graph.TabIndex = 0;
            this.graph.ZoomFactor = 1D;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите уравнение:";
            // 
            // equationBox
            // 
            this.equationBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.equationBox.FormattingEnabled = true;
            this.equationBox.Location = new System.Drawing.Point(130, 12);
            this.equationBox.Name = "equationBox";
            this.equationBox.Size = new System.Drawing.Size(179, 21);
            this.equationBox.TabIndex = 2;
            this.equationBox.SelectedIndexChanged += new System.EventHandler(this.equationBox_SelectedIndexChanged);
            // 
            // intervalLabel
            // 
            this.intervalLabel.AutoSize = true;
            this.intervalLabel.Location = new System.Drawing.Point(9, 94);
            this.intervalLabel.Name = "intervalLabel";
            this.intervalLabel.Size = new System.Drawing.Size(126, 13);
            this.intervalLabel.TabIndex = 3;
            this.intervalLabel.Text = "Границы интервала: От";
            // 
            // boundBox
            // 
            this.boundBox.Location = new System.Drawing.Point(141, 91);
            this.boundBox.Name = "boundBox";
            this.boundBox.Size = new System.Drawing.Size(100, 20);
            this.boundBox.TabIndex = 4;
            this.boundBox.Text = "-1";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(247, 94);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(22, 13);
            this.toLabel.TabIndex = 5;
            this.toLabel.Text = "До";
            // 
            // secondBoundBox
            // 
            this.secondBoundBox.Location = new System.Drawing.Point(275, 91);
            this.secondBoundBox.Name = "secondBoundBox";
            this.secondBoundBox.Size = new System.Drawing.Size(100, 20);
            this.secondBoundBox.TabIndex = 6;
            this.secondBoundBox.Text = "1";
            // 
            // selectStarerBox
            // 
            this.selectStarerBox.AutoSize = true;
            this.selectStarerBox.Location = new System.Drawing.Point(12, 74);
            this.selectStarerBox.Name = "selectStarerBox";
            this.selectStarerBox.Size = new System.Drawing.Size(203, 17);
            this.selectStarerBox.TabIndex = 7;
            this.selectStarerBox.Text = "Выбирать начальное приближение";
            this.selectStarerBox.UseVisualStyleBackColor = true;
            this.selectStarerBox.CheckedChanged += new System.EventHandler(this.selectStarerBox_CheckedChanged);
            // 
            // resultLabel
            // 
            this.resultLabel.Location = new System.Drawing.Point(380, 116);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(166, 214);
            this.resultLabel.TabIndex = 8;
            this.resultLabel.Text = "Результат:\r\nВычисления не проводились\r\n";
            // 
            // changeFormButton
            // 
            this.changeFormButton.Location = new System.Drawing.Point(318, 4);
            this.changeFormButton.Name = "changeFormButton";
            this.changeFormButton.Size = new System.Drawing.Size(228, 34);
            this.changeFormButton.TabIndex = 9;
            this.changeFormButton.Text = "Переключиться на системы нелинейных уравнений";
            this.changeFormButton.UseVisualStyleBackColor = true;
            this.changeFormButton.Click += new System.EventHandler(this.changeFormButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Enabled = false;
            this.calculateButton.Location = new System.Drawing.Point(383, 91);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(163, 20);
            this.calculateButton.TabIndex = 10;
            this.calculateButton.Text = "Вычислить";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Выберите метод:";
            // 
            // methodBox
            // 
            this.methodBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.methodBox.FormattingEnabled = true;
            this.methodBox.Items.AddRange(new object[] {
            "Метод половинного деления",
            "Метод Ньютона",
            "Метод простой итерации"});
            this.methodBox.Location = new System.Drawing.Point(130, 44);
            this.methodBox.Name = "methodBox";
            this.methodBox.Size = new System.Drawing.Size(179, 21);
            this.methodBox.TabIndex = 12;
            this.methodBox.SelectedIndexChanged += new System.EventHandler(this.methodBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Погрешность:";
            // 
            // epsilonBox
            // 
            this.epsilonBox.Location = new System.Drawing.Point(399, 44);
            this.epsilonBox.Name = "epsilonBox";
            this.epsilonBox.Size = new System.Drawing.Size(146, 20);
            this.epsilonBox.TabIndex = 14;
            this.epsilonBox.Text = "0.001";
            // 
            // SingleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 340);
            this.Controls.Add(this.epsilonBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.methodBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.changeFormButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.selectStarerBox);
            this.Controls.Add(this.secondBoundBox);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.boundBox);
            this.Controls.Add(this.intervalLabel);
            this.Controls.Add(this.equationBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.graph);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SingleForm";
            this.Text = "Лабораторная работа №2";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.graph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 graph;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox equationBox;
        private System.Windows.Forms.Label intervalLabel;
        private System.Windows.Forms.TextBox boundBox;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.TextBox secondBoundBox;
        private System.Windows.Forms.CheckBox selectStarerBox;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button changeFormButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox methodBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox epsilonBox;
    }
}