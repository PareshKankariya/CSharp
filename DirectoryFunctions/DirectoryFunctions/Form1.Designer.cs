namespace DirectoryFunctions
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
            this.btnCreateDirectory = new System.Windows.Forms.Button();
            this.btnMoveDirectory = new System.Windows.Forms.Button();
            this.btnDeleteDirectory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateDirectory
            // 
            this.btnCreateDirectory.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateDirectory.Location = new System.Drawing.Point(44, 52);
            this.btnCreateDirectory.Name = "btnCreateDirectory";
            this.btnCreateDirectory.Size = new System.Drawing.Size(158, 31);
            this.btnCreateDirectory.TabIndex = 0;
            this.btnCreateDirectory.Text = "Create Directory";
            this.btnCreateDirectory.UseVisualStyleBackColor = true;
            this.btnCreateDirectory.Click += new System.EventHandler(this.btnCreateDirectory_Click);
            // 
            // btnMoveDirectory
            // 
            this.btnMoveDirectory.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveDirectory.Location = new System.Drawing.Point(44, 159);
            this.btnMoveDirectory.Name = "btnMoveDirectory";
            this.btnMoveDirectory.Size = new System.Drawing.Size(158, 31);
            this.btnMoveDirectory.TabIndex = 1;
            this.btnMoveDirectory.Text = "Move Directory";
            this.btnMoveDirectory.UseVisualStyleBackColor = true;
            // 
            // btnDeleteDirectory
            // 
            this.btnDeleteDirectory.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteDirectory.Location = new System.Drawing.Point(44, 270);
            this.btnDeleteDirectory.Name = "btnDeleteDirectory";
            this.btnDeleteDirectory.Size = new System.Drawing.Size(158, 31);
            this.btnDeleteDirectory.TabIndex = 2;
            this.btnDeleteDirectory.Text = "Delete Directory";
            this.btnDeleteDirectory.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 361);
            this.Controls.Add(this.btnDeleteDirectory);
            this.Controls.Add(this.btnMoveDirectory);
            this.Controls.Add(this.btnCreateDirectory);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateDirectory;
        private System.Windows.Forms.Button btnMoveDirectory;
        private System.Windows.Forms.Button btnDeleteDirectory;
    }
}

