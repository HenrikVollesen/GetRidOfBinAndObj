namespace getRidOfBinAndObj
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
            openFileDialog1 = new OpenFileDialog();
            buttonSelectFolder = new Button();
            textBoxFolder = new TextBox();
            buttonClean = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            labelProcessing = new Label();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonSelectFolder
            // 
            buttonSelectFolder.Location = new Point(12, 12);
            buttonSelectFolder.Name = "buttonSelectFolder";
            buttonSelectFolder.Size = new Size(164, 31);
            buttonSelectFolder.TabIndex = 1;
            buttonSelectFolder.Text = "Select Root folder to clean:";
            buttonSelectFolder.TextAlign = ContentAlignment.MiddleLeft;
            buttonSelectFolder.UseVisualStyleBackColor = true;
            buttonSelectFolder.Click += buttonSelectFolder_Click;
            // 
            // textBoxFolder
            // 
            textBoxFolder.Location = new Point(12, 49);
            textBoxFolder.Name = "textBoxFolder";
            textBoxFolder.Size = new Size(501, 23);
            textBoxFolder.TabIndex = 2;
            textBoxFolder.TextChanged += textBoxFolder_TextChanged;
            // 
            // buttonClean
            // 
            buttonClean.Enabled = false;
            buttonClean.Location = new Point(12, 78);
            buttonClean.Name = "buttonClean";
            buttonClean.Size = new Size(164, 31);
            buttonClean.TabIndex = 3;
            buttonClean.Text = "Clean Root and subfolders";
            buttonClean.TextAlign = ContentAlignment.MiddleLeft;
            buttonClean.UseVisualStyleBackColor = true;
            buttonClean.Click += buttonClean_Click;
            // 
            // labelProcessing
            // 
            labelProcessing.Location = new Point(184, 86);
            labelProcessing.Name = "labelProcessing";
            labelProcessing.Size = new Size(330, 15);
            labelProcessing.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 120);
            Controls.Add(labelProcessing);
            Controls.Add(buttonClean);
            Controls.Add(textBoxFolder);
            Controls.Add(buttonSelectFolder);
            Name = "Form1";
            Text = "GetRidOfBinAndObj";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private OpenFileDialog openFileDialog1;
        private Button buttonSelectFolder;
        private TextBox textBoxFolder;
        private Button buttonClean;
        private FolderBrowserDialog folderBrowserDialog1;
        private Label labelProcessing;
    }
}