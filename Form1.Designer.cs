namespace MT_test_deck_solver
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
            btnLoad = new Button();
            txtSourceFile = new TextBox();
            btnChooseSource = new Button();
            SuspendLayout();
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(596, 397);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 0;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // txtSourceFile
            // 
            txtSourceFile.Location = new Point(64, 102);
            txtSourceFile.Name = "txtSourceFile";
            txtSourceFile.Size = new Size(547, 23);
            txtSourceFile.TabIndex = 1;
            // 
            // btnChooseSource
            // 
            btnChooseSource.Location = new Point(665, 102);
            btnChooseSource.Name = "btnChooseSource";
            btnChooseSource.Size = new Size(75, 23);
            btnChooseSource.TabIndex = 2;
            btnChooseSource.Text = "Choose";
            btnChooseSource.UseVisualStyleBackColor = true;
            btnChooseSource.Click += btnChooseSource_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnChooseSource);
            Controls.Add(txtSourceFile);
            Controls.Add(btnLoad);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLoad;
        private TextBox txtSourceFile;
        private Button btnChooseSource;
    }
}
