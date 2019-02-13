namespace PowerCombiner
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
            this.labelFolder = new System.Windows.Forms.Label();
            this.inputFolder = new System.Windows.Forms.TextBox();
            this.labelFileType = new System.Windows.Forms.Label();
            this.inputFileType = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.buttonCombine = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFolder
            // 
            this.labelFolder.AutoSize = true;
            this.labelFolder.Location = new System.Drawing.Point(13, 16);
            this.labelFolder.Name = "labelFolder";
            this.labelFolder.Size = new System.Drawing.Size(36, 13);
            this.labelFolder.TabIndex = 0;
            this.labelFolder.Text = "Folder";
            // 
            // inputFolder
            // 
            this.inputFolder.Location = new System.Drawing.Point(16, 36);
            this.inputFolder.Name = "inputFolder";
            this.inputFolder.Size = new System.Drawing.Size(341, 20);
            this.inputFolder.TabIndex = 1;
            // 
            // labelFileType
            // 
            this.labelFileType.AutoSize = true;
            this.labelFileType.Location = new System.Drawing.Point(13, 70);
            this.labelFileType.Name = "labelFileType";
            this.labelFileType.Size = new System.Drawing.Size(186, 13);
            this.labelFileType.TabIndex = 2;
            this.labelFileType.Text = "File Type (leave blank for all file types)";
            // 
            // inputFileType
            // 
            this.inputFileType.Location = new System.Drawing.Point(16, 90);
            this.inputFileType.Name = "inputFileType";
            this.inputFileType.Size = new System.Drawing.Size(60, 20);
            this.inputFileType.TabIndex = 3;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(16, 280);
            this.progressBar.Margin = new System.Windows.Forms.Padding(0);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(432, 23);
            this.progressBar.TabIndex = 4;
            // 
            // buttonCombine
            // 
            this.buttonCombine.Location = new System.Drawing.Point(16, 224);
            this.buttonCombine.Name = "buttonCombine";
            this.buttonCombine.Size = new System.Drawing.Size(75, 23);
            this.buttonCombine.TabIndex = 5;
            this.buttonCombine.Text = "Combine";
            this.buttonCombine.UseVisualStyleBackColor = true;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(373, 33);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 6;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 321);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.buttonCombine);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.inputFileType);
            this.Controls.Add(this.labelFileType);
            this.Controls.Add(this.inputFolder);
            this.Controls.Add(this.labelFolder);
            this.Name = "Form1";
            this.Text = "Power Combiner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFolder;
        private System.Windows.Forms.TextBox inputFolder;
        private System.Windows.Forms.Label labelFileType;
        private System.Windows.Forms.TextBox inputFileType;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button buttonCombine;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button buttonBrowse;
    }
}

