namespace ImageProcessing
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
            this.pboOriginal = new System.Windows.Forms.PictureBox();
            this.pboResult = new System.Windows.Forms.PictureBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnGrey = new System.Windows.Forms.Button();
            this.btnNegative = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pboOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboResult)).BeginInit();
            this.SuspendLayout();
            // 
            // pboOriginal
            // 
            this.pboOriginal.Location = new System.Drawing.Point(12, 25);
            this.pboOriginal.Name = "pboOriginal";
            this.pboOriginal.Size = new System.Drawing.Size(279, 232);
            this.pboOriginal.TabIndex = 0;
            this.pboOriginal.TabStop = false;
            // 
            // pboResult
            // 
            this.pboResult.Location = new System.Drawing.Point(367, 25);
            this.pboResult.Name = "pboResult";
            this.pboResult.Size = new System.Drawing.Size(279, 232);
            this.pboResult.TabIndex = 0;
            this.pboResult.TabStop = false;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(55, 277);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(111, 49);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnGrey
            // 
            this.btnGrey.Location = new System.Drawing.Point(218, 277);
            this.btnGrey.Name = "btnGrey";
            this.btnGrey.Size = new System.Drawing.Size(116, 53);
            this.btnGrey.TabIndex = 1;
            this.btnGrey.Text = "Grey";
            this.btnGrey.UseVisualStyleBackColor = true;
            this.btnGrey.Click += new System.EventHandler(this.btnGrey_Click);
            // 
            // btnNegative
            // 
            this.btnNegative.Location = new System.Drawing.Point(396, 273);
            this.btnNegative.Name = "btnNegative";
            this.btnNegative.Size = new System.Drawing.Size(116, 53);
            this.btnNegative.TabIndex = 2;
            this.btnNegative.Text = "Negative";
            this.btnNegative.UseVisualStyleBackColor = true;
            this.btnNegative.Click += new System.EventHandler(this.btnNegative_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(544, 277);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 53);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNegative);
            this.Controls.Add(this.btnGrey);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.pboResult);
            this.Controls.Add(this.pboOriginal);
            this.Name = "Form1";
            this.Text = "ImageProcessing";
            ((System.ComponentModel.ISupportInitialize)(this.pboOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pboOriginal;
        private System.Windows.Forms.PictureBox pboResult;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnGrey;
        private System.Windows.Forms.Button btnNegative;
        private System.Windows.Forms.Button btnSave;
    }
}

