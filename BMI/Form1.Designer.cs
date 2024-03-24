namespace BMI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textWeight = new System.Windows.Forms.TextBox();
            this.textHeight = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBmi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textRemarks = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btnView);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textRemarks);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBmi);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.btnCalculate);
            this.panel1.Controls.Add(this.textHeight);
            this.panel1.Controls.Add(this.textWeight);
            this.panel1.Controls.Add(this.textName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(116, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(839, 777);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(436, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "BMI Calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(44, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(44, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Height";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(44, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "Weight";
            // 
            // textName
            // 
            this.textName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textName.Location = new System.Drawing.Point(211, 43);
            this.textName.Multiline = true;
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(192, 29);
            this.textName.TabIndex = 3;
            // 
            // textWeight
            // 
            this.textWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textWeight.Location = new System.Drawing.Point(211, 99);
            this.textWeight.Multiline = true;
            this.textWeight.Name = "textWeight";
            this.textWeight.Size = new System.Drawing.Size(192, 29);
            this.textWeight.TabIndex = 4;
            // 
            // textHeight
            // 
            this.textHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textHeight.Location = new System.Drawing.Point(211, 155);
            this.textHeight.Multiline = true;
            this.textHeight.Name = "textHeight";
            this.textHeight.Size = new System.Drawing.Size(192, 29);
            this.textHeight.TabIndex = 5;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnCalculate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCalculate.Location = new System.Drawing.Point(216, 231);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(130, 44);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReset.Location = new System.Drawing.Point(387, 231);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(130, 44);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnExit.ForeColor = System.Drawing.Color.Purple;
            this.btnExit.Location = new System.Drawing.Point(957, 11);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 44);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(554, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // textBmi
            // 
            this.textBmi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBmi.Location = new System.Drawing.Point(211, 317);
            this.textBmi.Multiline = true;
            this.textBmi.Name = "textBmi";
            this.textBmi.Size = new System.Drawing.Size(135, 29);
            this.textBmi.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(94, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "BMI";
            // 
            // textRemarks
            // 
            this.textRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textRemarks.Location = new System.Drawing.Point(211, 377);
            this.textRemarks.Multiline = true;
            this.textRemarks.Name = "textRemarks";
            this.textRemarks.Size = new System.Drawing.Size(520, 80);
            this.textRemarks.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label6.Location = new System.Drawing.Point(94, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Remarks*";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnSave.ForeColor = System.Drawing.Color.Navy;
            this.btnSave.Location = new System.Drawing.Point(257, 484);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 44);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnView.ForeColor = System.Drawing.Color.Navy;
            this.btnView.Location = new System.Drawing.Point(456, 484);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(175, 44);
            this.btnView.TabIndex = 15;
            this.btnView.Text = "View Records";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlText;
            this.dataGridView1.Location = new System.Drawing.Point(211, 547);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(555, 207);
            this.dataGridView1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1055, 857);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox textHeight;
        private System.Windows.Forms.TextBox textWeight;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textRemarks;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBmi;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

