namespace PatelHiren_Matching_State_Capital
{
    partial class GameForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.selectTextBox = new System.Windows.Forms.TextBox();
            this.capitalListBox = new System.Windows.Forms.ListBox();
            this.nextQuestion = new System.Windows.Forms.Button();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.attemptBox = new System.Windows.Forms.TextBox();
            this.correctBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.capitalOfTextBox = new System.Windows.Forms.TextBox();
            this.stateNameBox = new System.Windows.Forms.TextBox();
            this.endButton = new System.Windows.Forms.Button();
            this.timeBox = new System.Windows.Forms.TextBox();
            this.textBoxTR = new System.Windows.Forms.TextBox();
            this.statePictureBox = new System.Windows.Forms.PictureBox();
            this.questionTimer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statePictureBox)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectTextBox
            // 
            this.selectTextBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.selectTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.selectTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.selectTextBox.Location = new System.Drawing.Point(796, 35);
            this.selectTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.selectTextBox.Name = "selectTextBox";
            this.selectTextBox.ReadOnly = true;
            this.selectTextBox.Size = new System.Drawing.Size(199, 28);
            this.selectTextBox.TabIndex = 0;
            this.selectTextBox.TabStop = false;
            this.selectTextBox.Text = "Select Capital";
            this.selectTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // capitalListBox
            // 
            this.capitalListBox.FormattingEnabled = true;
            this.capitalListBox.HorizontalScrollbar = true;
            this.capitalListBox.ItemHeight = 29;
            this.capitalListBox.Location = new System.Drawing.Point(734, 81);
            this.capitalListBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.capitalListBox.Name = "capitalListBox";
            this.capitalListBox.Size = new System.Drawing.Size(309, 671);
            this.capitalListBox.TabIndex = 0;
            this.capitalListBox.SelectedIndexChanged += new System.EventHandler(this.capitalListBox_SelectedIndexChanged);
            // 
            // nextQuestion
            // 
            this.nextQuestion.Location = new System.Drawing.Point(187, 673);
            this.nextQuestion.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.nextQuestion.Name = "nextQuestion";
            this.nextQuestion.Size = new System.Drawing.Size(224, 81);
            this.nextQuestion.TabIndex = 2;
            this.nextQuestion.Text = "Next Question";
            this.nextQuestion.UseVisualStyleBackColor = true;
            this.nextQuestion.Click += new System.EventHandler(this.nextQuestion_Click);
            // 
            // textBoxC
            // 
            this.textBoxC.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxC.Location = new System.Drawing.Point(498, 545);
            this.textBoxC.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.ReadOnly = true;
            this.textBoxC.Size = new System.Drawing.Size(162, 28);
            this.textBoxC.TabIndex = 0;
            this.textBoxC.TabStop = false;
            this.textBoxC.Text = "Correct";
            this.textBoxC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxA
            // 
            this.textBoxA.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxA.Location = new System.Drawing.Point(224, 545);
            this.textBoxA.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.ReadOnly = true;
            this.textBoxA.Size = new System.Drawing.Size(162, 28);
            this.textBoxA.TabIndex = 0;
            this.textBoxA.TabStop = false;
            this.textBoxA.Text = "Attempts";
            this.textBoxA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // attemptBox
            // 
            this.attemptBox.Location = new System.Drawing.Point(261, 592);
            this.attemptBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.attemptBox.Multiline = true;
            this.attemptBox.Name = "attemptBox";
            this.attemptBox.ReadOnly = true;
            this.attemptBox.Size = new System.Drawing.Size(85, 56);
            this.attemptBox.TabIndex = 0;
            this.attemptBox.TabStop = false;
            this.attemptBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // correctBox
            // 
            this.correctBox.Location = new System.Drawing.Point(535, 592);
            this.correctBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.correctBox.Multiline = true;
            this.correctBox.Name = "correctBox";
            this.correctBox.ReadOnly = true;
            this.correctBox.Size = new System.Drawing.Size(85, 56);
            this.correctBox.TabIndex = 0;
            this.correctBox.TabStop = false;
            this.correctBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.capitalOfTextBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.stateNameBox, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(75, 23);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(548, 46);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // capitalOfTextBox
            // 
            this.capitalOfTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.capitalOfTextBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.capitalOfTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.capitalOfTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capitalOfTextBox.Location = new System.Drawing.Point(5, 4);
            this.capitalOfTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.capitalOfTextBox.Name = "capitalOfTextBox";
            this.capitalOfTextBox.ReadOnly = true;
            this.capitalOfTextBox.Size = new System.Drawing.Size(264, 31);
            this.capitalOfTextBox.TabIndex = 0;
            this.capitalOfTextBox.TabStop = false;
            this.capitalOfTextBox.Text = "The Capital of:";
            this.capitalOfTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // stateNameBox
            // 
            this.stateNameBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.stateNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stateNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateNameBox.ForeColor = System.Drawing.Color.MidnightBlue;
            this.stateNameBox.Location = new System.Drawing.Point(279, 4);
            this.stateNameBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.stateNameBox.Name = "stateNameBox";
            this.stateNameBox.ReadOnly = true;
            this.stateNameBox.Size = new System.Drawing.Size(264, 34);
            this.stateNameBox.TabIndex = 0;
            this.stateNameBox.TabStop = false;
            // 
            // endButton
            // 
            this.endButton.Location = new System.Drawing.Point(473, 673);
            this.endButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.endButton.Name = "endButton";
            this.endButton.Size = new System.Drawing.Size(224, 81);
            this.endButton.TabIndex = 9;
            this.endButton.Text = "End Game";
            this.endButton.UseVisualStyleBackColor = true;
            this.endButton.Click += new System.EventHandler(this.endButton_Click);
            // 
            // timeBox
            // 
            this.timeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.timeBox.BackColor = System.Drawing.Color.Red;
            this.timeBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeBox.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.timeBox.Location = new System.Drawing.Point(75, 302);
            this.timeBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.timeBox.Multiline = true;
            this.timeBox.Name = "timeBox";
            this.timeBox.ReadOnly = true;
            this.timeBox.Size = new System.Drawing.Size(124, 70);
            this.timeBox.TabIndex = 0;
            this.timeBox.TabStop = false;
            this.timeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxTR
            // 
            this.textBoxTR.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxTR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxTR.Location = new System.Drawing.Point(25, 244);
            this.textBoxTR.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxTR.Multiline = true;
            this.textBoxTR.Name = "textBoxTR";
            this.textBoxTR.ReadOnly = true;
            this.textBoxTR.Size = new System.Drawing.Size(236, 38);
            this.textBoxTR.TabIndex = 0;
            this.textBoxTR.TabStop = false;
            this.textBoxTR.Text = "Time Remaining";
            this.textBoxTR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statePictureBox
            // 
            this.statePictureBox.BackColor = System.Drawing.Color.White;
            this.statePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.statePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statePictureBox.Location = new System.Drawing.Point(5, 4);
            this.statePictureBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.statePictureBox.Name = "statePictureBox";
            this.statePictureBox.Size = new System.Drawing.Size(388, 385);
            this.statePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.statePictureBox.TabIndex = 0;
            this.statePictureBox.TabStop = false;
            // 
            // questionTimer
            // 
            this.questionTimer.Interval = 1000;
            this.questionTimer.Tick += new System.EventHandler(this.questionTimer_Tick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.statePictureBox, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(299, 116);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(398, 394);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1070, 776);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.textBoxTR);
            this.Controls.Add(this.timeBox);
            this.Controls.Add(this.endButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.correctBox);
            this.Controls.Add(this.attemptBox);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.nextQuestion);
            this.Controls.Add(this.selectTextBox);
            this.Controls.Add(this.capitalListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "GameForm";
            this.Text = "Matching State Capitals";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statePictureBox)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox selectTextBox;
        private System.Windows.Forms.ListBox capitalListBox;
        private System.Windows.Forms.Button nextQuestion;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox attemptBox;
        private System.Windows.Forms.TextBox correctBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox capitalOfTextBox;
        private System.Windows.Forms.TextBox stateNameBox;
        private System.Windows.Forms.Button endButton;
        private System.Windows.Forms.TextBox timeBox;
        private System.Windows.Forms.TextBox textBoxTR;
        private System.Windows.Forms.PictureBox statePictureBox;
        private System.Windows.Forms.Timer questionTimer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}

