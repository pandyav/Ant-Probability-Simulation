namespace AntProb
{
    partial class AntSolver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AntSolver));
            this.button1 = new System.Windows.Forms.Button();
            this.RowsTextbox = new System.Windows.Forms.TextBox();
            this.ColsTextbox = new System.Windows.Forms.TextBox();
            this.IterTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TimeStepLabel = new System.Windows.Forms.Label();
            this.NestLocationLabel = new System.Windows.Forms.Label();
            this.NestTextboxX = new System.Windows.Forms.TextBox();
            this.FoodLabel = new System.Windows.Forms.Label();
            this.FoodsCellsList = new System.Windows.Forms.TextBox();
            this.NestTextboxY = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.PercentLabel = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(341, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RowsTextbox
            // 
            this.RowsTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RowsTextbox.Location = new System.Drawing.Point(67, 19);
            this.RowsTextbox.Name = "RowsTextbox";
            this.RowsTextbox.Size = new System.Drawing.Size(100, 22);
            this.RowsTextbox.TabIndex = 1;
            // 
            // ColsTextbox
            // 
            this.ColsTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColsTextbox.Location = new System.Drawing.Point(67, 53);
            this.ColsTextbox.Name = "ColsTextbox";
            this.ColsTextbox.Size = new System.Drawing.Size(100, 22);
            this.ColsTextbox.TabIndex = 2;
            // 
            // IterTextbox
            // 
            this.IterTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IterTextbox.Location = new System.Drawing.Point(243, 19);
            this.IterTextbox.Name = "IterTextbox";
            this.IterTextbox.Size = new System.Drawing.Size(50, 22);
            this.IterTextbox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rows";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cols";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Iterations";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(12, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 600);
            this.panel1.TabIndex = 7;
            // 
            // TimeStepLabel
            // 
            this.TimeStepLabel.AutoSize = true;
            this.TimeStepLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeStepLabel.ForeColor = System.Drawing.Color.Red;
            this.TimeStepLabel.Location = new System.Drawing.Point(798, 397);
            this.TimeStepLabel.Name = "TimeStepLabel";
            this.TimeStepLabel.Size = new System.Drawing.Size(36, 37);
            this.TimeStepLabel.TabIndex = 0;
            this.TimeStepLabel.Text = "0";
            // 
            // NestLocationLabel
            // 
            this.NestLocationLabel.AutoSize = true;
            this.NestLocationLabel.Location = new System.Drawing.Point(187, 53);
            this.NestLocationLabel.Name = "NestLocationLabel";
            this.NestLocationLabel.Size = new System.Drawing.Size(29, 13);
            this.NestLocationLabel.TabIndex = 8;
            this.NestLocationLabel.Text = "Nest";
            // 
            // NestTextboxX
            // 
            this.NestTextboxX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NestTextboxX.Location = new System.Drawing.Point(243, 53);
            this.NestTextboxX.Name = "NestTextboxX";
            this.NestTextboxX.Size = new System.Drawing.Size(23, 22);
            this.NestTextboxX.TabIndex = 9;
            // 
            // FoodLabel
            // 
            this.FoodLabel.AutoSize = true;
            this.FoodLabel.Location = new System.Drawing.Point(299, 19);
            this.FoodLabel.Name = "FoodLabel";
            this.FoodLabel.Size = new System.Drawing.Size(36, 13);
            this.FoodLabel.TabIndex = 10;
            this.FoodLabel.Text = "Foods";
            // 
            // FoodsCellsList
            // 
            this.FoodsCellsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoodsCellsList.Location = new System.Drawing.Point(341, 12);
            this.FoodsCellsList.Multiline = true;
            this.FoodsCellsList.Name = "FoodsCellsList";
            this.FoodsCellsList.Size = new System.Drawing.Size(128, 33);
            this.FoodsCellsList.TabIndex = 11;
            // 
            // NestTextboxY
            // 
            this.NestTextboxY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NestTextboxY.Location = new System.Drawing.Point(273, 53);
            this.NestTextboxY.Name = "NestTextboxY";
            this.NestTextboxY.Size = new System.Drawing.Size(23, 22);
            this.NestTextboxY.TabIndex = 12;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(550, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 31);
            this.button2.TabIndex = 13;
            this.button2.Text = "Build Grid";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(519, 61);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(139, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 15;
            this.progressBar1.Visible = false;
            // 
            // PercentLabel
            // 
            this.PercentLabel.AutoSize = true;
            this.PercentLabel.Location = new System.Drawing.Point(674, 66);
            this.PercentLabel.Name = "PercentLabel";
            this.PercentLabel.Size = new System.Drawing.Size(15, 13);
            this.PercentLabel.TabIndex = 16;
            this.PercentLabel.Text = "%";
            this.PercentLabel.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(664, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // AntSolver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 512);
            this.Controls.Add(this.TimeStepLabel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.PercentLabel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.NestTextboxY);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FoodsCellsList);
            this.Controls.Add(this.FoodLabel);
            this.Controls.Add(this.NestTextboxX);
            this.Controls.Add(this.NestLocationLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IterTextbox);
            this.Controls.Add(this.ColsTextbox);
            this.Controls.Add(this.RowsTextbox);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AntSolver";
            this.Text = "ANT-GAME";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AntSolver_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AntSolver_FormClosed);
            this.Load += new System.EventHandler(this.AntSolver_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox RowsTextbox;
        private System.Windows.Forms.TextBox ColsTextbox;
        private System.Windows.Forms.TextBox IterTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label NestLocationLabel;
        private System.Windows.Forms.TextBox NestTextboxX;
        private System.Windows.Forms.Label FoodLabel;
        private System.Windows.Forms.TextBox FoodsCellsList;
        private System.Windows.Forms.TextBox NestTextboxY;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label TimeStepLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label PercentLabel;
        private System.Windows.Forms.Button button3;
    }
}

