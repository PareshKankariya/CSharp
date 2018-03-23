namespace multipleForms
{
    partial class Form2
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbUpperCase = new System.Windows.Forms.RadioButton();
            this.rbLowerCase = new System.Windows.Forms.RadioButton();
            this.rbProperCase = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(39, 270);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(196, 270);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbProperCase);
            this.groupBox1.Controls.Add(this.rbLowerCase);
            this.groupBox1.Controls.Add(this.rbUpperCase);
            this.groupBox1.Location = new System.Drawing.Point(39, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 188);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Change Case";
            // 
            // rbUpperCase
            // 
            this.rbUpperCase.AutoSize = true;
            this.rbUpperCase.Checked = true;
            this.rbUpperCase.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbUpperCase.Location = new System.Drawing.Point(33, 37);
            this.rbUpperCase.Name = "rbUpperCase";
            this.rbUpperCase.Size = new System.Drawing.Size(87, 19);
            this.rbUpperCase.TabIndex = 0;
            this.rbUpperCase.TabStop = true;
            this.rbUpperCase.Text = "Upper Case";
            this.rbUpperCase.UseVisualStyleBackColor = true;
            // 
            // rbLowerCase
            // 
            this.rbLowerCase.AutoSize = true;
            this.rbLowerCase.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLowerCase.Location = new System.Drawing.Point(33, 94);
            this.rbLowerCase.Name = "rbLowerCase";
            this.rbLowerCase.Size = new System.Drawing.Size(88, 19);
            this.rbLowerCase.TabIndex = 1;
            this.rbLowerCase.Text = "Lower Case";
            this.rbLowerCase.UseVisualStyleBackColor = true;
            // 
            // rbProperCase
            // 
            this.rbProperCase.AutoSize = true;
            this.rbProperCase.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbProperCase.Location = new System.Drawing.Point(33, 149);
            this.rbProperCase.Name = "rbProperCase";
            this.rbProperCase.Size = new System.Drawing.Size(91, 19);
            this.rbProperCase.TabIndex = 2;
            this.rbProperCase.Text = "Proper Case";
            this.rbProperCase.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 345);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbProperCase;
        private System.Windows.Forms.RadioButton rbLowerCase;
        private System.Windows.Forms.RadioButton rbUpperCase;
    }
}