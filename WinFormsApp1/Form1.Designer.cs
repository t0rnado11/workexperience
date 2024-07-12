namespace WinFormsApp1
{
    partial class ddddddddddd
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
            LoadingBar = new ProgressBar();
            label1 = new Label();
            SuspendLayout();
            // 
            // LoadingBar
            // 
            LoadingBar.Location = new Point(121, 280);
            LoadingBar.Name = "LoadingBar";
            LoadingBar.Size = new Size(519, 23);
            LoadingBar.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(300, 211);
            label1.Name = "label1";
            label1.Size = new Size(157, 50);
            label1.TabIndex = 1;
            label1.Text = "Loading";
            label1.Click += label1_Click;
            // 
            // ddddddddddd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 528);
            Controls.Add(label1);
            Controls.Add(LoadingBar);
            Name = "ddddddddddd";
            Text = "TEST";
            Load += ddddddddddd_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar LoadingBar;
        private Label label1;
    }
}