namespace UDownload
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.targetpath = new System.Windows.Forms.TextBox();
            this.playid = new System.Windows.Forms.TextBox();
            this.downloadbtn = new System.Windows.Forms.Button();
            this.viewbtn = new System.Windows.Forms.Button();
            this.openbtn = new System.Windows.Forms.Button();
            this.viewfile = new System.Windows.Forms.WebBrowser();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.playlistview = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.playlistview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "PlayList Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Target Path";
            // 
            // targetpath
            // 
            this.targetpath.Location = new System.Drawing.Point(88, 60);
            this.targetpath.Name = "targetpath";
            this.targetpath.Size = new System.Drawing.Size(473, 20);
            this.targetpath.TabIndex = 2;
            // 
            // playid
            // 
            this.playid.Location = new System.Drawing.Point(88, 23);
            this.playid.Name = "playid";
            this.playid.Size = new System.Drawing.Size(473, 20);
            this.playid.TabIndex = 3;
            // 
            // downloadbtn
            // 
            this.downloadbtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.downloadbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.downloadbtn.Location = new System.Drawing.Point(648, 57);
            this.downloadbtn.Name = "downloadbtn";
            this.downloadbtn.Size = new System.Drawing.Size(75, 23);
            this.downloadbtn.TabIndex = 4;
            this.downloadbtn.Text = "Download";
            this.downloadbtn.UseVisualStyleBackColor = false;
            this.downloadbtn.Click += new System.EventHandler(this.downloadbtn_Click);
            // 
            // viewbtn
            // 
            this.viewbtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.viewbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewbtn.Location = new System.Drawing.Point(567, 21);
            this.viewbtn.Name = "viewbtn";
            this.viewbtn.Size = new System.Drawing.Size(75, 23);
            this.viewbtn.TabIndex = 5;
            this.viewbtn.Text = "View";
            this.viewbtn.UseVisualStyleBackColor = false;
            this.viewbtn.Click += new System.EventHandler(this.viewbtn_Click);
            // 
            // openbtn
            // 
            this.openbtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.openbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openbtn.Location = new System.Drawing.Point(567, 58);
            this.openbtn.Name = "openbtn";
            this.openbtn.Size = new System.Drawing.Size(75, 23);
            this.openbtn.TabIndex = 6;
            this.openbtn.Text = "Select";
            this.openbtn.UseVisualStyleBackColor = false;
            this.openbtn.Click += new System.EventHandler(this.openbtn_Click);
            // 
            // viewfile
            // 
            this.viewfile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewfile.Location = new System.Drawing.Point(2, 107);
            this.viewfile.MinimumSize = new System.Drawing.Size(20, 20);
            this.viewfile.Name = "viewfile";
            this.viewfile.Size = new System.Drawing.Size(534, 429);
            this.viewfile.TabIndex = 7;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(2, 86);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(534, 23);
            this.progressBar1.TabIndex = 10;
            // 
            // playlistview
            // 
            this.playlistview.AllowExternalDrop = true;
            this.playlistview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playlistview.CreationProperties = null;
            this.playlistview.DefaultBackgroundColor = System.Drawing.Color.White;
            this.playlistview.Location = new System.Drawing.Point(542, 107);
            this.playlistview.Name = "playlistview";
            this.playlistview.Size = new System.Drawing.Size(514, 429);
            this.playlistview.TabIndex = 11;
            this.playlistview.ZoomFactor = 1D;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1058, 548);
            this.Controls.Add(this.playlistview);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.viewfile);
            this.Controls.Add(this.openbtn);
            this.Controls.Add(this.viewbtn);
            this.Controls.Add(this.downloadbtn);
            this.Controls.Add(this.playid);
            this.Controls.Add(this.targetpath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "YoutubePlayListDownloader V5.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playlistview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox targetpath;
        private System.Windows.Forms.TextBox playid;
        private System.Windows.Forms.Button downloadbtn;
        private System.Windows.Forms.Button viewbtn;
        private System.Windows.Forms.Button openbtn;
        private System.Windows.Forms.WebBrowser viewfile;
        private System.Windows.Forms.ProgressBar progressBar1;
        private Microsoft.Web.WebView2.WinForms.WebView2 playlistview;
    }
}

