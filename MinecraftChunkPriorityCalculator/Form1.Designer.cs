namespace MinecraftChunkPriorityCalculator
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
            this.tbChunkX = new System.Windows.Forms.TextBox();
            this.tbChunkY = new System.Windows.Forms.TextBox();
            this.tbPlayerY = new System.Windows.Forms.TextBox();
            this.tbPlayerX = new System.Windows.Forms.TextBox();
            this.lblChunkX = new System.Windows.Forms.Label();
            this.lblChunkY = new System.Windows.Forms.Label();
            this.lblPlayerY = new System.Windows.Forms.Label();
            this.lblPlayerX = new System.Windows.Forms.Label();
            this.lblPriorityTitle = new System.Windows.Forms.Label();
            this.lblPriority = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblFile = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbChunkX
            // 
            this.tbChunkX.Location = new System.Drawing.Point(108, 34);
            this.tbChunkX.Name = "tbChunkX";
            this.tbChunkX.Size = new System.Drawing.Size(100, 20);
            this.tbChunkX.TabIndex = 0;
            this.tbChunkX.TextChanged += new System.EventHandler(this.tbChunkX_TextChanged);
            // 
            // tbChunkY
            // 
            this.tbChunkY.Location = new System.Drawing.Point(108, 60);
            this.tbChunkY.Name = "tbChunkY";
            this.tbChunkY.Size = new System.Drawing.Size(100, 20);
            this.tbChunkY.TabIndex = 1;
            this.tbChunkY.TextChanged += new System.EventHandler(this.tbChunkY_TextChanged);
            // 
            // tbPlayerY
            // 
            this.tbPlayerY.Location = new System.Drawing.Point(108, 198);
            this.tbPlayerY.Name = "tbPlayerY";
            this.tbPlayerY.Size = new System.Drawing.Size(100, 20);
            this.tbPlayerY.TabIndex = 3;
            this.tbPlayerY.TextChanged += new System.EventHandler(this.tbPlayerY_TextChanged);
            // 
            // tbPlayerX
            // 
            this.tbPlayerX.Location = new System.Drawing.Point(108, 172);
            this.tbPlayerX.Name = "tbPlayerX";
            this.tbPlayerX.Size = new System.Drawing.Size(100, 20);
            this.tbPlayerX.TabIndex = 2;
            this.tbPlayerX.TextChanged += new System.EventHandler(this.tbPlayerX_TextChanged);
            // 
            // lblChunkX
            // 
            this.lblChunkX.AutoSize = true;
            this.lblChunkX.Location = new System.Drawing.Point(38, 40);
            this.lblChunkX.Name = "lblChunkX";
            this.lblChunkX.Size = new System.Drawing.Size(48, 13);
            this.lblChunkX.TabIndex = 4;
            this.lblChunkX.Text = "Chunk X";
            // 
            // lblChunkY
            // 
            this.lblChunkY.AutoSize = true;
            this.lblChunkY.Location = new System.Drawing.Point(38, 67);
            this.lblChunkY.Name = "lblChunkY";
            this.lblChunkY.Size = new System.Drawing.Size(48, 13);
            this.lblChunkY.TabIndex = 5;
            this.lblChunkY.Text = "Chunk Y";
            // 
            // lblPlayerY
            // 
            this.lblPlayerY.AutoSize = true;
            this.lblPlayerY.Location = new System.Drawing.Point(37, 202);
            this.lblPlayerY.Name = "lblPlayerY";
            this.lblPlayerY.Size = new System.Drawing.Size(46, 13);
            this.lblPlayerY.TabIndex = 7;
            this.lblPlayerY.Text = "Player Y";
            // 
            // lblPlayerX
            // 
            this.lblPlayerX.AutoSize = true;
            this.lblPlayerX.Location = new System.Drawing.Point(37, 175);
            this.lblPlayerX.Name = "lblPlayerX";
            this.lblPlayerX.Size = new System.Drawing.Size(46, 13);
            this.lblPlayerX.TabIndex = 6;
            this.lblPlayerX.Text = "Player X";
            // 
            // lblPriorityTitle
            // 
            this.lblPriorityTitle.AutoSize = true;
            this.lblPriorityTitle.Location = new System.Drawing.Point(273, 41);
            this.lblPriorityTitle.Name = "lblPriorityTitle";
            this.lblPriorityTitle.Size = new System.Drawing.Size(38, 13);
            this.lblPriorityTitle.TabIndex = 8;
            this.lblPriorityTitle.Text = "Priority";
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(329, 41);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(13, 13);
            this.lblPriority.TabIndex = 9;
            this.lblPriority.Text = "0";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(40, 263);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(168, 23);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Force Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(316, 79);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(51, 13);
            this.lblFile.TabIndex = 12;
            this.lblFile.Text = "r.0.0.mca";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(273, 79);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(26, 13);
            this.lblFileName.TabIndex = 11;
            this.lblFileName.Text = "File:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 333);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblPriority);
            this.Controls.Add(this.lblPriorityTitle);
            this.Controls.Add(this.lblPlayerY);
            this.Controls.Add(this.lblPlayerX);
            this.Controls.Add(this.lblChunkY);
            this.Controls.Add(this.lblChunkX);
            this.Controls.Add(this.tbPlayerY);
            this.Controls.Add(this.tbPlayerX);
            this.Controls.Add(this.tbChunkY);
            this.Controls.Add(this.tbChunkX);
            this.Name = "Form1";
            this.Text = "Minecraft Chunk ToolKit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbChunkX;
        private System.Windows.Forms.TextBox tbChunkY;
        private System.Windows.Forms.TextBox tbPlayerY;
        private System.Windows.Forms.TextBox tbPlayerX;
        private System.Windows.Forms.Label lblChunkX;
        private System.Windows.Forms.Label lblChunkY;
        private System.Windows.Forms.Label lblPlayerY;
        private System.Windows.Forms.Label lblPlayerX;
        private System.Windows.Forms.Label lblPriorityTitle;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.Label lblFileName;
    }
}

