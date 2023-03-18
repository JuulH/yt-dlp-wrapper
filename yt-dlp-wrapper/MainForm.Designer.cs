namespace yt_dlp_wrapper
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lbl_url = new System.Windows.Forms.Label();
            this.txt_url = new System.Windows.Forms.TextBox();
            this.txt_from = new System.Windows.Forms.TextBox();
            this.lbl_from = new System.Windows.Forms.Label();
            this.lbl_to = new System.Windows.Forms.Label();
            this.txt_to = new System.Windows.Forms.TextBox();
            this.btn_download = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_timestamp = new System.Windows.Forms.CheckBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_path = new System.Windows.Forms.Button();
            this.lbl_path = new System.Windows.Forms.Label();
            this.combo_filetype = new System.Windows.Forms.ComboBox();
            this.lbl_filetype = new System.Windows.Forms.Label();
            this.txt_cmd = new System.Windows.Forms.TextBox();
            this.progressbar = new System.Windows.Forms.ProgressBar();
            this.lbl_progress = new System.Windows.Forms.Label();
            this.chk_cmdonly = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbl_url
            // 
            this.lbl_url.AutoSize = true;
            this.lbl_url.Location = new System.Drawing.Point(134, 59);
            this.lbl_url.Name = "lbl_url";
            this.lbl_url.Size = new System.Drawing.Size(99, 25);
            this.lbl_url.TabIndex = 0;
            this.lbl_url.Text = "Video URL";
            // 
            // txt_url
            // 
            this.txt_url.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_url.Location = new System.Drawing.Point(239, 56);
            this.txt_url.Name = "txt_url";
            this.txt_url.PlaceholderText = "https://www.youtube.com/watch?v=Xmt_V7fotTM&ab_channel=cat";
            this.txt_url.Size = new System.Drawing.Size(299, 33);
            this.txt_url.TabIndex = 1;
            // 
            // txt_from
            // 
            this.txt_from.Enabled = false;
            this.txt_from.Location = new System.Drawing.Point(195, 140);
            this.txt_from.Name = "txt_from";
            this.txt_from.PlaceholderText = "0:00";
            this.txt_from.Size = new System.Drawing.Size(94, 33);
            this.txt_from.TabIndex = 4;
            // 
            // lbl_from
            // 
            this.lbl_from.AutoSize = true;
            this.lbl_from.Location = new System.Drawing.Point(134, 143);
            this.lbl_from.Name = "lbl_from";
            this.lbl_from.Size = new System.Drawing.Size(55, 25);
            this.lbl_from.TabIndex = 3;
            this.lbl_from.Text = "From";
            // 
            // lbl_to
            // 
            this.lbl_to.AutoSize = true;
            this.lbl_to.Location = new System.Drawing.Point(295, 143);
            this.lbl_to.Name = "lbl_to";
            this.lbl_to.Size = new System.Drawing.Size(31, 25);
            this.lbl_to.TabIndex = 5;
            this.lbl_to.Text = "To";
            // 
            // txt_to
            // 
            this.txt_to.Enabled = false;
            this.txt_to.Location = new System.Drawing.Point(332, 140);
            this.txt_to.Name = "txt_to";
            this.txt_to.PlaceholderText = "1:00";
            this.txt_to.Size = new System.Drawing.Size(94, 33);
            this.txt_to.TabIndex = 6;
            // 
            // btn_download
            // 
            this.btn_download.Location = new System.Drawing.Point(268, 342);
            this.btn_download.Name = "btn_download";
            this.btn_download.Size = new System.Drawing.Size(131, 44);
            this.btn_download.TabIndex = 13;
            this.btn_download.Text = "Download!";
            this.btn_download.UseVisualStyleBackColor = true;
            this.btn_download.Click += new System.EventHandler(this.btn_download_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(309, 201);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // chk_timestamp
            // 
            this.chk_timestamp.AutoSize = true;
            this.chk_timestamp.Location = new System.Drawing.Point(134, 105);
            this.chk_timestamp.Name = "chk_timestamp";
            this.chk_timestamp.Size = new System.Drawing.Size(163, 29);
            this.chk_timestamp.TabIndex = 2;
            this.chk_timestamp.Text = "Use timestamps";
            this.chk_timestamp.UseVisualStyleBackColor = true;
            this.chk_timestamp.CheckedChanged += new System.EventHandler(this.chk_timestamp_CheckedChanged);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "Select a folder to save the video to.";
            this.folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyVideos;
            // 
            // btn_path
            // 
            this.btn_path.Location = new System.Drawing.Point(134, 190);
            this.btn_path.Name = "btn_path";
            this.btn_path.Size = new System.Drawing.Size(155, 38);
            this.btn_path.TabIndex = 7;
            this.btn_path.Text = "Select folder";
            this.btn_path.UseVisualStyleBackColor = true;
            this.btn_path.Click += new System.EventHandler(this.btn_path_Click);
            // 
            // lbl_path
            // 
            this.lbl_path.AutoSize = true;
            this.lbl_path.Location = new System.Drawing.Point(295, 197);
            this.lbl_path.Name = "lbl_path";
            this.lbl_path.Size = new System.Drawing.Size(53, 25);
            this.lbl_path.TabIndex = 8;
            this.lbl_path.Text = "Path:";
            // 
            // combo_filetype
            // 
            this.combo_filetype.FormattingEnabled = true;
            this.combo_filetype.Items.AddRange(new object[] {
            "Best video (default)",
            "mp4",
            "webm",
            "vp9",
            "3gp",
            "mkv",
            "flv",
            "avi",
            "Best audio",
            "mp3",
            "wav",
            "opus",
            "m4a",
            "vorbis",
            "aac"});
            this.combo_filetype.Location = new System.Drawing.Point(217, 247);
            this.combo_filetype.Name = "combo_filetype";
            this.combo_filetype.Size = new System.Drawing.Size(204, 33);
            this.combo_filetype.TabIndex = 10;
            // 
            // lbl_filetype
            // 
            this.lbl_filetype.AutoSize = true;
            this.lbl_filetype.Location = new System.Drawing.Point(134, 250);
            this.lbl_filetype.Name = "lbl_filetype";
            this.lbl_filetype.Size = new System.Drawing.Size(77, 25);
            this.lbl_filetype.TabIndex = 9;
            this.lbl_filetype.Text = "Filetype";
            // 
            // txt_cmd
            // 
            this.txt_cmd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_cmd.Location = new System.Drawing.Point(297, 293);
            this.txt_cmd.Name = "txt_cmd";
            this.txt_cmd.PlaceholderText = "Command will show up here";
            this.txt_cmd.Size = new System.Drawing.Size(236, 25);
            this.txt_cmd.TabIndex = 12;
            // 
            // progressbar
            // 
            this.progressbar.Location = new System.Drawing.Point(134, 391);
            this.progressbar.Name = "progressbar";
            this.progressbar.Size = new System.Drawing.Size(399, 23);
            this.progressbar.TabIndex = 12;
            // 
            // lbl_progress
            // 
            this.lbl_progress.AutoSize = true;
            this.lbl_progress.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_progress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_progress.Location = new System.Drawing.Point(136, 416);
            this.lbl_progress.Name = "lbl_progress";
            this.lbl_progress.Size = new System.Drawing.Size(0, 21);
            this.lbl_progress.TabIndex = 13;
            // 
            // chk_cmdonly
            // 
            this.chk_cmdonly.AutoSize = true;
            this.chk_cmdonly.Location = new System.Drawing.Point(136, 289);
            this.chk_cmdonly.Name = "chk_cmdonly";
            this.chk_cmdonly.Size = new System.Drawing.Size(159, 29);
            this.chk_cmdonly.TabIndex = 11;
            this.chk_cmdonly.Text = "Command only";
            this.chk_cmdonly.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(667, 450);
            this.Controls.Add(this.chk_cmdonly);
            this.Controls.Add(this.lbl_progress);
            this.Controls.Add(this.progressbar);
            this.Controls.Add(this.txt_cmd);
            this.Controls.Add(this.lbl_filetype);
            this.Controls.Add(this.combo_filetype);
            this.Controls.Add(this.lbl_path);
            this.Controls.Add(this.btn_path);
            this.Controls.Add(this.chk_timestamp);
            this.Controls.Add(this.btn_download);
            this.Controls.Add(this.txt_to);
            this.Controls.Add(this.lbl_to);
            this.Controls.Add(this.lbl_from);
            this.Controls.Add(this.txt_from);
            this.Controls.Add(this.txt_url);
            this.Controls.Add(this.lbl_url);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm";
            this.Text = "YouTube Downloader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_url;
        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.TextBox txt_from;
        private System.Windows.Forms.Label lbl_from;
        private System.Windows.Forms.Label lbl_to;
        private System.Windows.Forms.TextBox txt_to;
        private System.Windows.Forms.Button btn_download;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chk_timestamp;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button btn_path;
        private System.Windows.Forms.Label lbl_path;
        private System.Windows.Forms.ComboBox combo_filetype;
        private System.Windows.Forms.Label lbl_filetype;
        private System.Windows.Forms.TextBox txt_cmd;
        private System.Windows.Forms.ProgressBar progressbar;
        private System.Windows.Forms.Label lbl_progress;
        private System.Windows.Forms.CheckBox chk_cmdonly;
    }
}

