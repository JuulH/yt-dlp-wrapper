using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
//using Newtonsoft.Json.Linq;
using System.IO;

namespace yt_dlp_wrapper
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            folderBrowserDialog.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
            lbl_path.Text = folderBrowserDialog.SelectedPath;
            combo_filetype.SelectedIndex = 0;
        }

        private void chk_timestamp_CheckedChanged(object sender, EventArgs e)
        {
            txt_from.Enabled = chk_timestamp.Checked;
            txt_to.Enabled = chk_timestamp.Checked;
        }

        private void btn_path_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            string path = folderBrowserDialog.SelectedPath;
            lbl_path.Text = path;
        }

        private void btn_download_Click(object sender, EventArgs e)
        {
            progressbar.Value = 0;
            lbl_progress.Text = "Setting arguments...";

            string applicationPath = AppDomain.CurrentDomain.BaseDirectory;
            string ytdlp_path = Path.Combine(applicationPath, "external", "yt-dlp.exe");
            string ffmpeg_path = Path.Combine(applicationPath, "external", "ffmpeg", "bin", "ffmpeg.exe");

            string args = "";

            // Set file format
            string fileType = combo_filetype.SelectedItem.ToString();

            if (combo_filetype.SelectedIndex >= 8)
            {
                args += $"--extract-audio ";
            }

            if (combo_filetype.SelectedIndex > 0 && combo_filetype.SelectedIndex < 8)
            {
                args += $"-f {fileType} ";
            } else if (combo_filetype.SelectedIndex > 8)
            {
                args += $"--audio-format {fileType} ";
            }

            // Set timestamps
            if(chk_timestamp.Checked)
            {
                args += $"--download-sections \"*{txt_from.Text}-{txt_to.Text}\" ";
            }

            args += $"-o {folderBrowserDialog.SelectedPath}/%(title)s.%(ext)s "; // Set output folder

            //args += "--progress-hook \"echo {\"progress\":%\"_percent_str%\"}\" "; // YT-DLP Progress hook for progress bar

            args += $"{txt_url.Text}"; // Set video url
            args += $"--ffmpeg-location \"{ffmpeg_path}\" ";

            txt_cmd.Text = $"{ytdlp_path} {args}";

            if (!chk_cmdonly.Checked)
            {
                try
                {
                    progressbar.Value = 10;
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.FileName = ytdlp_path;
                    startInfo.Arguments = args;

                    startInfo.RedirectStandardOutput = true;
                    startInfo.RedirectStandardError = true;
                    startInfo.UseShellExecute = false;
                    startInfo.CreateNoWindow = true;

                    progressbar.Value = 30;

                    using (Process process = Process.Start(startInfo))
                    {
                        process.OutputDataReceived += new DataReceivedEventHandler(OutputDataReceived);
                        process.ErrorDataReceived += new DataReceivedEventHandler(ErrorDataReceived);
                        //process.EnableRaisingEvents = true;
                        lbl_progress.Text = "Starting export...";
                        progressbar.Value = 50;
                        process.BeginOutputReadLine();
                        process.BeginErrorReadLine();
                        process.WaitForExit();
                    }

                    progressbar.Value = 100;

                    lbl_progress.Text = $"Exported to: {folderBrowserDialog.SelectedPath}";
                } catch (Exception error)
                {
                    lbl_progress.Text = error.Message;
                }
            }
        }

        private void OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                // Process the output data here
                Console.WriteLine(e.Data);
            }
        }

        private void ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                // Process the error data here
                Console.WriteLine(e.Data);
            }
        }
    }
}
