namespace DisplayArrayValues
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
            this.btnArray = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnArraySize = new System.Windows.Forms.Button();
            this.txtArraySize = new System.Windows.Forms.TextBox();
            this.btnTimesTable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnArray
            // 
            this.btnArray.Location = new System.Drawing.Point(172, 24);
            this.btnArray.Name = "btnArray";
            this.btnArray.Size = new System.Drawing.Size(75, 23);
            this.btnArray.TabIndex = 0;
            this.btnArray.Text = "Array";
            this.btnArray.UseVisualStyleBackColor = true;
            this.btnArray.Click += new System.EventHandler(this.btnArray_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(56, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(88, 121);
            this.listBox1.TabIndex = 1;
            // 
            // btnArraySize
            // 
            this.btnArraySize.Location = new System.Drawing.Point(22, 180);
            this.btnArraySize.Name = "btnArraySize";
            this.btnArraySize.Size = new System.Drawing.Size(108, 23);
            this.btnArraySize.TabIndex = 2;
            this.btnArraySize.Text = "Set Array Size";
            this.btnArraySize.UseVisualStyleBackColor = true;
            // 
            // txtArraySize
            // 
            this.txtArraySize.Location = new System.Drawing.Point(172, 182);
            this.txtArraySize.Name = "txtArraySize";
            this.txtArraySize.Size = new System.Drawing.Size(51, 20);
            this.txtArraySize.TabIndex = 3;
            // 
            // btnTimesTable
            // 
            this.btnTimesTable.Location = new System.Drawing.Point(22, 241);
            this.btnTimesTable.Name = "btnTimesTable";
            this.btnTimesTable.Size = new System.Drawing.Size(75, 23);
            this.btnTimesTable.TabIndex = 4;
            this.btnTimesTable.Text = "Excercise: Times Table";
            this.btnTimesTable.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 319);
            this.Controls.Add(this.btnTimesTable);
            this.Controls.Add(this.txtArraySize);
            this.Controls.Add(this.btnArraySize);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnArray);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnArray;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnArraySize;
        private System.Windows.Forms.TextBox txtArraySize;
        private System.Windows.Forms.Button btnTimesTable;
    }
}

