namespace computerVisionLab1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxJ = new System.Windows.Forms.TextBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnGeneration = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(238, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(255, 400);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(23, 15);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(81, 30);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(509, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "ввод данных";
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(12, 123);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(56, 20);
            this.textBoxX.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(15, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(90, 98);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Y";
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(87, 123);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(56, 20);
            this.textBoxY.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(163, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Яркость";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxJ
            // 
            this.textBoxJ.Location = new System.Drawing.Point(163, 123);
            this.textBoxJ.Name = "textBoxJ";
            this.textBoxJ.Size = new System.Drawing.Size(56, 20);
            this.textBoxJ.TabIndex = 9;
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(10, 159);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(204, 25);
            this.btnDownload.TabIndex = 11;
            this.btnDownload.Text = "загрузить данные";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnGeneration
            // 
            this.btnGeneration.Location = new System.Drawing.Point(10, 244);
            this.btnGeneration.Name = "btnGeneration";
            this.btnGeneration.Size = new System.Drawing.Size(112, 25);
            this.btnGeneration.TabIndex = 12;
            this.btnGeneration.Text = "генерация ";
            this.btnGeneration.UseVisualStyleBackColor = true;
            this.btnGeneration.Click += new System.EventHandler(this.btnGeneration_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(157, 246);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(66, 21);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 448);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnGeneration);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxJ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ComboBox comboBox1;

        private System.Windows.Forms.Button btnGeneration;

        private System.Windows.Forms.Button btnDownload;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxJ;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.Button btnLoad;

        private System.Windows.Forms.DataGridView dataGridView1;

        #endregion
    }
}