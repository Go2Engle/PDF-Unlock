namespace PDF_Unlock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pdfDropBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.browsePDFbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pdffile = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gswin64cLocationtxt = new System.Windows.Forms.TextBox();
            this.browseGswin64cbtn = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pdfDropBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pdfDropBox
            // 
            this.pdfDropBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pdfDropBox.Controls.Add(this.pictureBox1);
            this.pdfDropBox.Controls.Add(this.label1);
            this.pdfDropBox.Location = new System.Drawing.Point(12, 62);
            this.pdfDropBox.Name = "pdfDropBox";
            this.pdfDropBox.Size = new System.Drawing.Size(505, 142);
            this.pdfDropBox.TabIndex = 0;
            this.pdfDropBox.TabStop = false;
            this.pdfDropBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.pdfDropBox_DragDrop);
            this.pdfDropBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.pdfDropBox_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Drop PDF Here";
            // 
            // browsePDFbtn
            // 
            this.browsePDFbtn.Location = new System.Drawing.Point(432, 12);
            this.browsePDFbtn.Name = "browsePDFbtn";
            this.browsePDFbtn.Size = new System.Drawing.Size(85, 28);
            this.browsePDFbtn.TabIndex = 1;
            this.browsePDFbtn.Text = "Browse...";
            this.browsePDFbtn.UseVisualStyleBackColor = true;
            this.browsePDFbtn.Click += new System.EventHandler(this.browsePDFbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(390, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "To unlock a PDF Browse to a locked PDF or drag and drop it below";
            // 
            // pdffile
            // 
            this.pdffile.AutoSize = true;
            this.pdffile.Location = new System.Drawing.Point(12, 46);
            this.pdffile.Name = "pdffile";
            this.pdffile.Size = new System.Drawing.Size(0, 13);
            this.pdffile.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "pdf";
            this.openFileDialog1.Filter = "pdf files (*.pdf)|*.pdf|All files (*.*)|*.*";
            this.openFileDialog1.Title = "Select PDF File";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(15, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(502, 53);
            this.label3.TabIndex = 3;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Instructions";
            // 
            // gswin64cLocationtxt
            // 
            this.gswin64cLocationtxt.Location = new System.Drawing.Point(15, 298);
            this.gswin64cLocationtxt.Name = "gswin64cLocationtxt";
            this.gswin64cLocationtxt.Size = new System.Drawing.Size(406, 20);
            this.gswin64cLocationtxt.TabIndex = 5;
            // 
            // browseGswin64cbtn
            // 
            this.browseGswin64cbtn.Location = new System.Drawing.Point(432, 293);
            this.browseGswin64cbtn.Name = "browseGswin64cbtn";
            this.browseGswin64cbtn.Size = new System.Drawing.Size(85, 28);
            this.browseGswin64cbtn.TabIndex = 6;
            this.browseGswin64cbtn.Text = "Browse...";
            this.browseGswin64cbtn.UseVisualStyleBackColor = true;
            this.browseGswin64cbtn.Click += new System.EventHandler(this.browseGswin64cbtn_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "gswin64c.exe";
            this.openFileDialog2.Filter = "gswin64c.exe (gswin64c.exe)|gswin64c.exe|All files (*.*)|*.*";
            this.openFileDialog2.InitialDirectory = "C:\\Program Files\\gs";
            this.openFileDialog2.Title = "gswin64c.ee";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(232, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 330);
            this.Controls.Add(this.browseGswin64cbtn);
            this.Controls.Add(this.gswin64cLocationtxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pdffile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.browsePDFbtn);
            this.Controls.Add(this.pdfDropBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 369);
            this.MinimumSize = new System.Drawing.Size(541, 369);
            this.Name = "Form1";
            this.Text = "PDF-Unlock";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.pdfDropBox_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.pdfDropBox_DragEnter);
            this.pdfDropBox.ResumeLayout(false);
            this.pdfDropBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox pdfDropBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button browsePDFbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label pdffile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox gswin64cLocationtxt;
        private System.Windows.Forms.Button browseGswin64cbtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

