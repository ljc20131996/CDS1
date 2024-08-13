namespace CDS1
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
			numericUpDownSigma = new NumericUpDown();
			numericUpDownMu = new NumericUpDown();
			label1 = new Label();
			label2 = new Label();
			buttonLoadSensorData = new Button();
			listView = new ListView();
			SensorA = new ColumnHeader();
			SensorB = new ColumnHeader();
			label3 = new Label();
			buttonIterativeA = new Button();
			textBoxIterativeA = new TextBox();
			textBoxRecursiveA = new TextBox();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			buttonRecursiveA = new Button();
			label7 = new Label();
			textBoxSearchTargetA = new TextBox();
			label8 = new Label();
			buttonSelectionSortA = new Button();
			textBoxSelectionSortA = new TextBox();
			textBoxInsertionSortA = new TextBox();
			buttonInsertionSortA = new Button();
			label9 = new Label();
			listBoxSensorA = new ListBox();
			listBoxSensorB = new ListBox();
			textBoxInsertionSortB = new TextBox();
			buttonInsertionSortB = new Button();
			label10 = new Label();
			textBoxSelectionSortB = new TextBox();
			buttonSelectionSortB = new Button();
			label11 = new Label();
			textBoxSearchTargetB = new TextBox();
			label12 = new Label();
			buttonRecursiveB = new Button();
			label13 = new Label();
			textBoxRecursiveB = new TextBox();
			textBoxIterativeB = new TextBox();
			buttonIterativeB = new Button();
			label14 = new Label();
			((System.ComponentModel.ISupportInitialize)numericUpDownSigma).BeginInit();
			((System.ComponentModel.ISupportInitialize)numericUpDownMu).BeginInit();
			SuspendLayout();
			// 
			// numericUpDownSigma
			// 
			numericUpDownSigma.Location = new Point(63, 39);
			numericUpDownSigma.Margin = new Padding(3, 4, 3, 4);
			numericUpDownSigma.Name = "numericUpDownSigma";
			numericUpDownSigma.Size = new Size(54, 27);
			numericUpDownSigma.TabIndex = 0;
			numericUpDownSigma.ValueChanged += numericUpDownSigma_ValueChanged;
			// 
			// numericUpDownMu
			// 
			numericUpDownMu.Location = new Point(134, 39);
			numericUpDownMu.Margin = new Padding(3, 4, 3, 4);
			numericUpDownMu.Name = "numericUpDownMu";
			numericUpDownMu.Size = new Size(54, 27);
			numericUpDownMu.TabIndex = 1;
			numericUpDownMu.ValueChanged += numericUpDownMu_ValueChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(63, 15);
			label1.Name = "label1";
			label1.Size = new Size(51, 20);
			label1.TabIndex = 2;
			label1.Text = "Sigma";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(134, 15);
			label2.Name = "label2";
			label2.Size = new Size(30, 20);
			label2.TabIndex = 3;
			label2.Text = "Mu";
			// 
			// buttonLoadSensorData
			// 
			buttonLoadSensorData.Location = new Point(46, 77);
			buttonLoadSensorData.Margin = new Padding(3, 4, 3, 4);
			buttonLoadSensorData.Name = "buttonLoadSensorData";
			buttonLoadSensorData.Size = new Size(161, 31);
			buttonLoadSensorData.TabIndex = 4;
			buttonLoadSensorData.Text = "Load Sensor Data";
			buttonLoadSensorData.UseVisualStyleBackColor = true;
			buttonLoadSensorData.Click += buttonLoadSensorData_Click;
			// 
			// listView
			// 
			listView.Columns.AddRange(new ColumnHeader[] { SensorA, SensorB });
			listView.Location = new Point(14, 140);
			listView.Margin = new Padding(3, 4, 3, 4);
			listView.Name = "listView";
			listView.Size = new Size(228, 701);
			listView.TabIndex = 5;
			listView.UseCompatibleStateImageBehavior = false;
			listView.View = View.Details;
			listView.SelectedIndexChanged += listView_SelectedIndexChanged;
			// 
			// SensorA
			// 
			SensorA.Text = "A";
			SensorA.Width = 120;
			// 
			// SensorB
			// 
			SensorB.Text = "B";
			SensorB.Width = 120;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(255, 75);
			label3.Name = "label3";
			label3.Size = new Size(156, 20);
			label3.TabIndex = 6;
			label3.Text = "Binary Search Iterative";
			// 
			// buttonIterativeA
			// 
			buttonIterativeA.Location = new Point(255, 99);
			buttonIterativeA.Margin = new Padding(3, 4, 3, 4);
			buttonIterativeA.Name = "buttonIterativeA";
			buttonIterativeA.Size = new Size(86, 31);
			buttonIterativeA.TabIndex = 7;
			buttonIterativeA.Text = "Search";
			buttonIterativeA.UseVisualStyleBackColor = true;
			buttonIterativeA.Click += buttonIterativeA_Click;
			// 
			// textBoxIterativeA
			// 
			textBoxIterativeA.Location = new Point(255, 137);
			textBoxIterativeA.Margin = new Padding(3, 4, 3, 4);
			textBoxIterativeA.Name = "textBoxIterativeA";
			textBoxIterativeA.Size = new Size(114, 27);
			textBoxIterativeA.TabIndex = 8;
			textBoxIterativeA.TextChanged += textBoxIterativeA_TextChanged;
			// 
			// textBoxRecursiveA
			// 
			textBoxRecursiveA.Location = new Point(255, 272);
			textBoxRecursiveA.Margin = new Padding(3, 4, 3, 4);
			textBoxRecursiveA.Name = "textBoxRecursiveA";
			textBoxRecursiveA.Size = new Size(114, 27);
			textBoxRecursiveA.TabIndex = 9;
			textBoxRecursiveA.TextChanged += textBoxRecursiveA_TextChanged;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 15F);
			label4.Location = new Point(425, 23);
			label4.Name = "label4";
			label4.Size = new Size(130, 35);
			label4.TabIndex = 10;
			label4.Text = "SENSOR A";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 15F);
			label5.Location = new Point(753, 23);
			label5.Name = "label5";
			label5.Size = new Size(128, 35);
			label5.TabIndex = 11;
			label5.Text = "SENSOR B";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(255, 209);
			label6.Name = "label6";
			label6.Size = new Size(164, 20);
			label6.TabIndex = 12;
			label6.Text = "Binary Search Recursive";
			// 
			// buttonRecursiveA
			// 
			buttonRecursiveA.Location = new Point(255, 233);
			buttonRecursiveA.Margin = new Padding(3, 4, 3, 4);
			buttonRecursiveA.Name = "buttonRecursiveA";
			buttonRecursiveA.Size = new Size(86, 31);
			buttonRecursiveA.TabIndex = 13;
			buttonRecursiveA.Text = "Search";
			buttonRecursiveA.UseVisualStyleBackColor = true;
			buttonRecursiveA.Click += buttonRecursiveA_Click;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(255, 373);
			label7.Name = "label7";
			label7.Size = new Size(98, 20);
			label7.TabIndex = 14;
			label7.Text = "Search Target";
			// 
			// textBoxSearchTargetA
			// 
			textBoxSearchTargetA.Location = new Point(255, 397);
			textBoxSearchTargetA.Margin = new Padding(3, 4, 3, 4);
			textBoxSearchTargetA.Name = "textBoxSearchTargetA";
			textBoxSearchTargetA.Size = new Size(87, 27);
			textBoxSearchTargetA.TabIndex = 15;
			textBoxSearchTargetA.TextChanged += textBoxSearchTargetA_TextChanged;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(255, 489);
			label8.Name = "label8";
			label8.Size = new Size(101, 20);
			label8.TabIndex = 16;
			label8.Text = "Selection Sort";
			// 
			// buttonSelectionSortA
			// 
			buttonSelectionSortA.Location = new Point(255, 513);
			buttonSelectionSortA.Margin = new Padding(3, 4, 3, 4);
			buttonSelectionSortA.Name = "buttonSelectionSortA";
			buttonSelectionSortA.Size = new Size(86, 31);
			buttonSelectionSortA.TabIndex = 17;
			buttonSelectionSortA.Text = "Sort";
			buttonSelectionSortA.UseVisualStyleBackColor = true;
			buttonSelectionSortA.Click += buttonSelectionSortA_Click;
			// 
			// textBoxSelectionSortA
			// 
			textBoxSelectionSortA.Location = new Point(255, 552);
			textBoxSelectionSortA.Margin = new Padding(3, 4, 3, 4);
			textBoxSelectionSortA.Name = "textBoxSelectionSortA";
			textBoxSelectionSortA.Size = new Size(114, 27);
			textBoxSelectionSortA.TabIndex = 18;
			textBoxSelectionSortA.TextChanged += textBoxSelectionSortA_TextChanged;
			// 
			// textBoxInsertionSortA
			// 
			textBoxInsertionSortA.Location = new Point(256, 721);
			textBoxInsertionSortA.Margin = new Padding(3, 4, 3, 4);
			textBoxInsertionSortA.Name = "textBoxInsertionSortA";
			textBoxInsertionSortA.Size = new Size(114, 27);
			textBoxInsertionSortA.TabIndex = 21;
			textBoxInsertionSortA.TextChanged += textBoxInsertionSortA_TextChanged;
			// 
			// buttonInsertionSortA
			// 
			buttonInsertionSortA.Location = new Point(256, 683);
			buttonInsertionSortA.Margin = new Padding(3, 4, 3, 4);
			buttonInsertionSortA.Name = "buttonInsertionSortA";
			buttonInsertionSortA.Size = new Size(86, 31);
			buttonInsertionSortA.TabIndex = 20;
			buttonInsertionSortA.Text = "Sort";
			buttonInsertionSortA.UseVisualStyleBackColor = true;
			buttonInsertionSortA.Click += buttonInsertionSortA_Click;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(255, 659);
			label9.Name = "label9";
			label9.Size = new Size(97, 20);
			label9.TabIndex = 19;
			label9.Text = "Insertion Sort";
			// 
			// listBoxSensorA
			// 
			listBoxSensorA.FormattingEnabled = true;
			listBoxSensorA.Location = new Point(425, 75);
			listBoxSensorA.Margin = new Padding(3, 4, 3, 4);
			listBoxSensorA.Name = "listBoxSensorA";
			listBoxSensorA.SelectionMode = SelectionMode.MultiSimple;
			listBoxSensorA.Size = new Size(148, 764);
			listBoxSensorA.TabIndex = 22;
			listBoxSensorA.SelectedIndexChanged += listBoxSensorA_SelectedIndexChanged;
			// 
			// listBoxSensorB
			// 
			listBoxSensorB.FormattingEnabled = true;
			listBoxSensorB.Location = new Point(753, 77);
			listBoxSensorB.Margin = new Padding(3, 4, 3, 4);
			listBoxSensorB.Name = "listBoxSensorB";
			listBoxSensorB.SelectionMode = SelectionMode.MultiSimple;
			listBoxSensorB.Size = new Size(148, 764);
			listBoxSensorB.TabIndex = 37;
			listBoxSensorB.SelectedIndexChanged += listBoxSensorB_SelectedIndexChanged;
			// 
			// textBoxInsertionSortB
			// 
			textBoxInsertionSortB.Location = new Point(583, 721);
			textBoxInsertionSortB.Margin = new Padding(3, 4, 3, 4);
			textBoxInsertionSortB.Name = "textBoxInsertionSortB";
			textBoxInsertionSortB.Size = new Size(114, 27);
			textBoxInsertionSortB.TabIndex = 36;
			textBoxInsertionSortB.TextChanged += textBoxInsertionSortB_TextChanged;
			// 
			// buttonInsertionSortB
			// 
			buttonInsertionSortB.Location = new Point(583, 683);
			buttonInsertionSortB.Margin = new Padding(3, 4, 3, 4);
			buttonInsertionSortB.Name = "buttonInsertionSortB";
			buttonInsertionSortB.Size = new Size(86, 31);
			buttonInsertionSortB.TabIndex = 35;
			buttonInsertionSortB.Text = "Sort";
			buttonInsertionSortB.UseVisualStyleBackColor = true;
			buttonInsertionSortB.Click += buttonInsertionSortB_Click;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new Point(581, 659);
			label10.Name = "label10";
			label10.Size = new Size(97, 20);
			label10.TabIndex = 34;
			label10.Text = "Insertion Sort";
			// 
			// textBoxSelectionSortB
			// 
			textBoxSelectionSortB.Location = new Point(585, 552);
			textBoxSelectionSortB.Margin = new Padding(3, 4, 3, 4);
			textBoxSelectionSortB.Name = "textBoxSelectionSortB";
			textBoxSelectionSortB.Size = new Size(114, 27);
			textBoxSelectionSortB.TabIndex = 33;
			textBoxSelectionSortB.TextChanged += textBoxSelectionSortB_TextChanged;
			// 
			// buttonSelectionSortB
			// 
			buttonSelectionSortB.Location = new Point(585, 513);
			buttonSelectionSortB.Margin = new Padding(3, 4, 3, 4);
			buttonSelectionSortB.Name = "buttonSelectionSortB";
			buttonSelectionSortB.Size = new Size(86, 31);
			buttonSelectionSortB.TabIndex = 32;
			buttonSelectionSortB.Text = "Sort";
			buttonSelectionSortB.UseVisualStyleBackColor = true;
			buttonSelectionSortB.Click += buttonSelectionSortB_Click;
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Location = new Point(583, 489);
			label11.Name = "label11";
			label11.Size = new Size(101, 20);
			label11.TabIndex = 31;
			label11.Text = "Selection Sort";
			// 
			// textBoxSearchTargetB
			// 
			textBoxSearchTargetB.Location = new Point(585, 397);
			textBoxSearchTargetB.Margin = new Padding(3, 4, 3, 4);
			textBoxSearchTargetB.Name = "textBoxSearchTargetB";
			textBoxSearchTargetB.Size = new Size(87, 27);
			textBoxSearchTargetB.TabIndex = 30;
			textBoxSearchTargetB.TextChanged += textBoxSearchTargetB_TextChanged;
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Location = new Point(583, 373);
			label12.Name = "label12";
			label12.Size = new Size(98, 20);
			label12.TabIndex = 29;
			label12.Text = "Search Target";
			// 
			// buttonRecursiveB
			// 
			buttonRecursiveB.Location = new Point(585, 233);
			buttonRecursiveB.Margin = new Padding(3, 4, 3, 4);
			buttonRecursiveB.Name = "buttonRecursiveB";
			buttonRecursiveB.Size = new Size(86, 31);
			buttonRecursiveB.TabIndex = 28;
			buttonRecursiveB.Text = "Search";
			buttonRecursiveB.UseVisualStyleBackColor = true;
			buttonRecursiveB.Click += buttonRecursiveB_Click;
			// 
			// label13
			// 
			label13.AutoSize = true;
			label13.Location = new Point(583, 209);
			label13.Name = "label13";
			label13.Size = new Size(164, 20);
			label13.TabIndex = 27;
			label13.Text = "Binary Search Recursive";
			// 
			// textBoxRecursiveB
			// 
			textBoxRecursiveB.Location = new Point(585, 272);
			textBoxRecursiveB.Margin = new Padding(3, 4, 3, 4);
			textBoxRecursiveB.Name = "textBoxRecursiveB";
			textBoxRecursiveB.Size = new Size(114, 27);
			textBoxRecursiveB.TabIndex = 26;
			textBoxRecursiveB.TextChanged += textBoxRecursiveB_TextChanged;
			// 
			// textBoxIterativeB
			// 
			textBoxIterativeB.Location = new Point(585, 137);
			textBoxIterativeB.Margin = new Padding(3, 4, 3, 4);
			textBoxIterativeB.Name = "textBoxIterativeB";
			textBoxIterativeB.Size = new Size(114, 27);
			textBoxIterativeB.TabIndex = 25;
			textBoxIterativeB.TextChanged += textBoxIterativeB_TextChanged;
			// 
			// buttonIterativeB
			// 
			buttonIterativeB.Location = new Point(585, 99);
			buttonIterativeB.Margin = new Padding(3, 4, 3, 4);
			buttonIterativeB.Name = "buttonIterativeB";
			buttonIterativeB.Size = new Size(86, 31);
			buttonIterativeB.TabIndex = 24;
			buttonIterativeB.Text = "Search";
			buttonIterativeB.UseVisualStyleBackColor = true;
			buttonIterativeB.Click += buttonIterativeB_Click;
			// 
			// label14
			// 
			label14.AutoSize = true;
			label14.Location = new Point(585, 75);
			label14.Name = "label14";
			label14.Size = new Size(156, 20);
			label14.TabIndex = 23;
			label14.Text = "Binary Search Iterative";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(905, 852);
			Controls.Add(listBoxSensorB);
			Controls.Add(textBoxInsertionSortB);
			Controls.Add(buttonInsertionSortB);
			Controls.Add(label10);
			Controls.Add(textBoxSelectionSortB);
			Controls.Add(buttonSelectionSortB);
			Controls.Add(label11);
			Controls.Add(textBoxSearchTargetB);
			Controls.Add(label12);
			Controls.Add(buttonRecursiveB);
			Controls.Add(label13);
			Controls.Add(textBoxRecursiveB);
			Controls.Add(textBoxIterativeB);
			Controls.Add(buttonIterativeB);
			Controls.Add(label14);
			Controls.Add(listBoxSensorA);
			Controls.Add(textBoxInsertionSortA);
			Controls.Add(buttonInsertionSortA);
			Controls.Add(label9);
			Controls.Add(textBoxSelectionSortA);
			Controls.Add(buttonSelectionSortA);
			Controls.Add(label8);
			Controls.Add(textBoxSearchTargetA);
			Controls.Add(label7);
			Controls.Add(buttonRecursiveA);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(textBoxRecursiveA);
			Controls.Add(textBoxIterativeA);
			Controls.Add(buttonIterativeA);
			Controls.Add(label3);
			Controls.Add(listView);
			Controls.Add(buttonLoadSensorData);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(numericUpDownMu);
			Controls.Add(numericUpDownSigma);
			Margin = new Padding(3, 4, 3, 4);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)numericUpDownSigma).EndInit();
			((System.ComponentModel.ISupportInitialize)numericUpDownMu).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private NumericUpDown numericUpDownSigma;
		private NumericUpDown numericUpDownMu;
		private Label label1;
		private Label label2;
		private Button buttonLoadSensorData;
		private ListView listView;
		private Label label3;
		private Button buttonIterativeA;
		private TextBox textBoxIterativeA;
		private TextBox textBoxRecursiveA;
		private Label label4;
		private Label label5;
		private Label label6;
		private Button buttonRecursiveA;
		private Label label7;
		private TextBox textBoxSearchTargetA;
		private Label label8;
		private Button buttonSelectionSortA;
		private TextBox textBoxSelectionSortA;
		private TextBox textBoxInsertionSortA;
		private Button buttonInsertionSortA;
		private Label label9;
		private ListBox listBoxSensorA;
		private ListBox listBoxSensorB;
		private TextBox textBoxInsertionSortB;
		private Button buttonInsertionSortB;
		private Label label10;
		private TextBox textBoxSelectionSortB;
		private Button buttonSelectionSortB;
		private Label label11;
		private TextBox textBoxSearchTargetB;
		private Label label12;
		private Button buttonRecursiveB;
		private Label label13;
		private TextBox textBoxRecursiveB;
		private TextBox textBoxIterativeB;
		private Button buttonIterativeB;
		private Label label14;
		private ColumnHeader SensorA;
		private ColumnHeader SensorB;
	}
}
