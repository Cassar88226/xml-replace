namespace refine_entry
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
            this.filePath = new System.Windows.Forms.TextBox();
            this.txtReplace = new System.Windows.Forms.TextBox();
            this.txtXMLDoc = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // filePath
            // 
            this.filePath.Location = new System.Drawing.Point(12, 21);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(303, 20);
            this.filePath.TabIndex = 0;
            // 
            // txtReplace
            // 
            this.txtReplace.Location = new System.Drawing.Point(452, 23);
            this.txtReplace.Name = "txtReplace";
            this.txtReplace.Size = new System.Drawing.Size(119, 20);
            this.txtReplace.TabIndex = 0;
            // 
            // txtXMLDoc
            // 
            this.txtXMLDoc.Location = new System.Drawing.Point(12, 66);
            this.txtXMLDoc.Name = "txtXMLDoc";
            this.txtXMLDoc.Size = new System.Drawing.Size(776, 360);
            this.txtXMLDoc.TabIndex = 1;
            this.txtXMLDoc.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(321, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Brower...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnBrower_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(588, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(699, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtXMLDoc);
            this.Controls.Add(this.txtReplace);
            this.Controls.Add(this.filePath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox filePath;
        private System.Windows.Forms.TextBox txtReplace;
        private System.Windows.Forms.RichTextBox txtXMLDoc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

