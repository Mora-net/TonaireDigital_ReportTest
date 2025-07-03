namespace TonaireDigital_Report
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
            this.dpend = new System.Windows.Forms.DateTimePicker();
            this.btnsub = new System.Windows.Forms.Button();
            this.dpstart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dpend
            // 
            this.dpend.CustomFormat = "yyyy-MM-dd";
            this.dpend.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpend.Location = new System.Drawing.Point(180, 124);
            this.dpend.Name = "dpend";
            this.dpend.Size = new System.Drawing.Size(166, 34);
            this.dpend.TabIndex = 1;
            this.dpend.Value = new System.DateTime(2025, 7, 3, 0, 0, 0, 0);
            // 
            // btnsub
            // 
            this.btnsub.Location = new System.Drawing.Point(146, 211);
            this.btnsub.Name = "btnsub";
            this.btnsub.Size = new System.Drawing.Size(122, 55);
            this.btnsub.TabIndex = 2;
            this.btnsub.Text = "Submit";
            this.btnsub.UseVisualStyleBackColor = true;
            // 
            // dpstart
            // 
            this.dpstart.CustomFormat = "yyyy-MM-dd";
            this.dpstart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpstart.Location = new System.Drawing.Point(180, 65);
            this.dpstart.Name = "dpstart";
            this.dpstart.Size = new System.Drawing.Size(166, 34);
            this.dpstart.TabIndex = 3;
            this.dpstart.Value = new System.DateTime(2025, 7, 18, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Start Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "End Date";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 292);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dpstart);
            this.Controls.Add(this.btnsub);
            this.Controls.Add(this.dpend);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dpend;
        private System.Windows.Forms.Button btnsub;
        private System.Windows.Forms.DateTimePicker dpstart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

