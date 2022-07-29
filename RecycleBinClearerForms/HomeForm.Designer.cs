namespace RecycleBinClearerForms
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.EmptyButton = new System.Windows.Forms.Button();
            this.EmptyLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EmptyButton
            // 
            this.EmptyButton.Location = new System.Drawing.Point(120, 124);
            this.EmptyButton.Name = "EmptyButton";
            this.EmptyButton.Size = new System.Drawing.Size(164, 54);
            this.EmptyButton.TabIndex = 0;
            this.EmptyButton.Text = "Empty Recycle Bin";
            this.EmptyButton.UseVisualStyleBackColor = true;
            this.EmptyButton.Click += new System.EventHandler(this.EmptyButton_Click);
            // 
            // EmptyLable
            // 
            this.EmptyLable.AutoSize = true;
            this.EmptyLable.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EmptyLable.Location = new System.Drawing.Point(80, 43);
            this.EmptyLable.Name = "EmptyLable";
            this.EmptyLable.Size = new System.Drawing.Size(250, 37);
            this.EmptyLable.TabIndex = 1;
            this.EmptyLable.Text = "Empty Recycle Bin";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 276);
            this.Controls.Add(this.EmptyLable);
            this.Controls.Add(this.EmptyButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomeForm";
            this.Text = "Recycle Bin Clearer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button EmptyButton;
        private Label EmptyLable;
    }
}