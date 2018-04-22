namespace WinformsSample
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
            this.EditorSplitContainer = new System.Windows.Forms.SplitContainer();
            this.CodeSplitContainer = new System.Windows.Forms.SplitContainer();
            this.CodeTextBox = new System.Windows.Forms.TextBox();
            this.RunButton = new System.Windows.Forms.Button();
            this.OutputPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.EditorSplitContainer)).BeginInit();
            this.EditorSplitContainer.Panel1.SuspendLayout();
            this.EditorSplitContainer.Panel2.SuspendLayout();
            this.EditorSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CodeSplitContainer)).BeginInit();
            this.CodeSplitContainer.Panel1.SuspendLayout();
            this.CodeSplitContainer.Panel2.SuspendLayout();
            this.CodeSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // EditorSplitContainer
            // 
            this.EditorSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditorSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.EditorSplitContainer.Name = "EditorSplitContainer";
            // 
            // EditorSplitContainer.Panel1
            // 
            this.EditorSplitContainer.Panel1.Controls.Add(this.CodeSplitContainer);
            // 
            // EditorSplitContainer.Panel2
            // 
            this.EditorSplitContainer.Panel2.Controls.Add(this.OutputPanel);
            this.EditorSplitContainer.Size = new System.Drawing.Size(643, 379);
            this.EditorSplitContainer.SplitterDistance = 288;
            this.EditorSplitContainer.TabIndex = 0;
            // 
            // CodeSplitContainer
            // 
            this.CodeSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CodeSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.CodeSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.CodeSplitContainer.Name = "CodeSplitContainer";
            this.CodeSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // CodeSplitContainer.Panel1
            // 
            this.CodeSplitContainer.Panel1.Controls.Add(this.CodeTextBox);
            // 
            // CodeSplitContainer.Panel2
            // 
            this.CodeSplitContainer.Panel2.Controls.Add(this.RunButton);
            this.CodeSplitContainer.Size = new System.Drawing.Size(288, 379);
            this.CodeSplitContainer.SplitterDistance = 343;
            this.CodeSplitContainer.TabIndex = 0;
            // 
            // CodeTextBox
            // 
            this.CodeTextBox.AcceptsReturn = true;
            this.CodeTextBox.AcceptsTab = true;
            this.CodeTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CodeTextBox.Location = new System.Drawing.Point(0, 0);
            this.CodeTextBox.Multiline = true;
            this.CodeTextBox.Name = "CodeTextBox";
            this.CodeTextBox.Size = new System.Drawing.Size(288, 343);
            this.CodeTextBox.TabIndex = 0;
            this.CodeTextBox.Text = "using System.Windows.Forms;\r\n\r\nvar lbl = new Label();\r\nlbl.Text = \'Label1\';\r\nroot" +
    ".Controls.Add(lbl);";
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(0, 0);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(75, 23);
            this.RunButton.TabIndex = 0;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // OutputPanel
            // 
            this.OutputPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutputPanel.Location = new System.Drawing.Point(0, 0);
            this.OutputPanel.Name = "OutputPanel";
            this.OutputPanel.Size = new System.Drawing.Size(351, 379);
            this.OutputPanel.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 379);
            this.Controls.Add(this.EditorSplitContainer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.EditorSplitContainer.Panel1.ResumeLayout(false);
            this.EditorSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EditorSplitContainer)).EndInit();
            this.EditorSplitContainer.ResumeLayout(false);
            this.CodeSplitContainer.Panel1.ResumeLayout(false);
            this.CodeSplitContainer.Panel1.PerformLayout();
            this.CodeSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CodeSplitContainer)).EndInit();
            this.CodeSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer EditorSplitContainer;
        private System.Windows.Forms.SplitContainer CodeSplitContainer;
        private System.Windows.Forms.Button RunButton;
        public System.Windows.Forms.TextBox CodeTextBox;
        public System.Windows.Forms.Panel OutputPanel;
    }
}

