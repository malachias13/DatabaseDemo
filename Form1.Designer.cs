
namespace DataEXE
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
            this.WordText = new System.Windows.Forms.Label();
            this.PreBtn = new System.Windows.Forms.Button();
            this.NexBtn = new System.Windows.Forms.Button();
            this.Addbtn = new System.Windows.Forms.Button();
            this.WordBox = new System.Windows.Forms.TextBox();
            this.delBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WordText
            // 
            this.WordText.AutoSize = true;
            this.WordText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WordText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.WordText.Location = new System.Drawing.Point(479, 214);
            this.WordText.Name = "WordText";
            this.WordText.Size = new System.Drawing.Size(71, 29);
            this.WordText.TabIndex = 0;
            this.WordText.Text = "Word";
            // 
            // PreBtn
            // 
            this.PreBtn.Location = new System.Drawing.Point(366, 331);
            this.PreBtn.Name = "PreBtn";
            this.PreBtn.Size = new System.Drawing.Size(98, 30);
            this.PreBtn.TabIndex = 1;
            this.PreBtn.Text = "Previous";
            this.PreBtn.UseVisualStyleBackColor = true;
            this.PreBtn.Click += new System.EventHandler(this.PreBtn_Click);
            // 
            // NexBtn
            // 
            this.NexBtn.Location = new System.Drawing.Point(569, 331);
            this.NexBtn.Name = "NexBtn";
            this.NexBtn.Size = new System.Drawing.Size(98, 30);
            this.NexBtn.TabIndex = 2;
            this.NexBtn.Text = "Next";
            this.NexBtn.UseVisualStyleBackColor = true;
            this.NexBtn.Click += new System.EventHandler(this.NexBtn_Click);
            // 
            // Addbtn
            // 
            this.Addbtn.Location = new System.Drawing.Point(892, 70);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(75, 23);
            this.Addbtn.TabIndex = 3;
            this.Addbtn.Text = "Add";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // WordBox
            // 
            this.WordBox.Location = new System.Drawing.Point(366, 282);
            this.WordBox.Name = "WordBox";
            this.WordBox.Size = new System.Drawing.Size(301, 20);
            this.WordBox.TabIndex = 4;
            // 
            // delBtn
            // 
            this.delBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.delBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.delBtn.Location = new System.Drawing.Point(111, 89);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(75, 23);
            this.delBtn.TabIndex = 5;
            this.delBtn.Text = "Del";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 620);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.WordBox);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.NexBtn);
            this.Controls.Add(this.PreBtn);
            this.Controls.Add(this.WordText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WordText;
        private System.Windows.Forms.Button PreBtn;
        private System.Windows.Forms.Button NexBtn;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.TextBox WordBox;
        private System.Windows.Forms.Button delBtn;
    }
}

