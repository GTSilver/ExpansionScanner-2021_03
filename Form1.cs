using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scaner_2._0
{
    public partial class Form1 : Form
    {
        static long filesScaned = 0;
        static long foldersScaned = 0;
        static long sizeScaned = 0;
        static Stopwatch timeScaned;
        static Thread scanningThread;
        static Thread calculationThread;
        static Dictionary<string, long> extensionsSize = new Dictionary<string, long>();


        public Form1()
        {
            InitializeComponent();

            while (Result_DGV.RowCount < 9)
                Result_DGV.Rows.Add();
        }

        private string GetSize(long size)
        {
            int switcher = 0;
            string result;
            string suffix = "";
            double temporarSize = size;


            while (temporarSize / 1024 > 1)
            {
                switcher++;
                if (switcher > 5)
                    break;

                temporarSize = temporarSize / 1024;
            }

            switch (switcher)
            {
                case 0:
                    suffix = " B";
                    break;
                case 1:
                    suffix = " kB";
                    break;
                case 2:
                    suffix = " MB";
                    break;
                case 3:
                    suffix = " GB";
                    break;
                case 4:
                    suffix = " TB";
                    break;
                case 5:
                    suffix = " PB";
                    break;
            }

            result = Math.Round(temporarSize, 4).ToString() + suffix;

            return result;
        }

        private double GetPercent(long size)
        {
            double percent = (double)size / (double)sizeScaned * 100;

            var result = Math.Round(percent, 4);

            return result;
        }

        private void Input_TB_TextChanged(object sender, EventArgs e)
        {
            var value = (Input_TB.Text);
            if (value.Length > 0)
                if (value[value.Length - 1] != '\\')
                {
                    value += @"\";
                    Input_TB.Text = value;
                }
        }

        private void BrowseInput_B_Click(object sender, EventArgs e)
        {
            using (var folder = new FolderBrowserDialog())
                if (folder.ShowDialog() == DialogResult.OK)
                    Input_TB.Text = folder.SelectedPath;
        }

        private void Start_B_Click(object sender, EventArgs e)
        {
            StartProcedure();
        }

        private void Stop_B_Click(object sender, EventArgs e)
        {
            StopProcedure();
        }

        private void OffInterface()
        {
            Stop_B.Enabled = true;
            Start_B.Enabled = false;
            Input_TB.Enabled = false;

            filesScaned = 0;
            foldersScaned = 0;
            sizeScaned = 0;

            timeScaned = new Stopwatch();
            timeScaned.Start();
        }

        private void OnInterface()
        {
            Stop_B.Enabled = false;
            Start_B.Enabled = true;
            Input_TB.Enabled = true;

            timeScaned.Stop();
            var elapsedTime = timeScaned.Elapsed;
            string time = String.Format
                (
                "{0:00}:{1:00}:{2:00}.{3:000}",
                elapsedTime.Hours,
                elapsedTime.Minutes,
                elapsedTime.Seconds,
                elapsedTime.Milliseconds
                );

            Files_L.Text = filesScaned.ToString();
            Folders_L.Text = foldersScaned.ToString();
            Size_L.Text = (sizeScaned/1024/1024).ToString();
            Time_L.Text = time;
        }

        public void Scanning()
        {
            var imputPath = Input_TB.Text;

            ScanFolder(imputPath);

            Invoke((MethodInvoker)delegate ()
            {
                StopProcedure();
            });
        }

        private void ScanFolder(string imputPath)
        {
            try
            {
                var allfiles = Directory.GetFiles(imputPath).ToList();
                var allfolders = Directory.GetDirectories(imputPath).Select(x => x + "\\").ToList();

                foreach (var folder in allfolders)
                {
                    DirectoryInfo directoryInfo = new DirectoryInfo(folder);

                    foldersScaned++;
                }

                foreach (var files in allfiles)
                {
                    FileInfo fileInfo = new FileInfo(files);
                    
                    long size = fileInfo.Length;
                    string extension = fileInfo.Extension.ToLower();

                    if (extensionsSize.ContainsKey(extension))
                        extensionsSize[extension] += size;
                    else
                        extensionsSize.Add(extension, size);

                    sizeScaned += fileInfo.Length;
                    filesScaned++;
                }

                foreach (var folder in allfolders)
                    ScanFolder(folder);
            }

            catch
            { try {
                    //***********************
            } catch { }}
        }

        public void Calculation()
        {
            while (true)
            {
                Thread.Sleep(50);

                var elapsedTime = timeScaned.Elapsed;
                string time = String.Format
                    (
                    "{0:00}:{1:00}:{2:00}.{3:000}",
                    elapsedTime.Hours,
                    elapsedTime.Minutes,
                    elapsedTime.Seconds,
                    elapsedTime.Milliseconds
                    );

                Invoke((MethodInvoker)delegate ()
                {
                    Files_L.Text = filesScaned.ToString();
                    Folders_L.Text = foldersScaned.ToString();
                    Size_L.Text = (sizeScaned / 1024 / 1024).ToString();
                    Time_L.Text = time;
                });
            }
        }

        private void StartProcedure()
        {
            filesScaned = 0;
            foldersScaned = 0;
            sizeScaned = 0;
            extensionsSize.Clear();

            OffInterface();
            
            scanningThread = new Thread(new ThreadStart(Scanning));
            scanningThread.Start();

            calculationThread = new Thread(new ThreadStart(Calculation));
            calculationThread.Start();
        }

        private void StopProcedure()
        {
            try { scanningThread.Abort(); }
            catch { MessageBox.Show("Error:\n" + "Scanning is not active. There is nothing to stop."); }

            try { calculationThread.Abort(); }
            catch { MessageBox.Show("Error:\n" + "Calculation is not active. There is nothing to stop."); }

            Result_DGV.Rows.Clear();
            var orderedExtensionsSize = extensionsSize.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            foreach (var type in orderedExtensionsSize)
                Result_DGV.Rows.Add(type.Key, GetSize(type.Value), GetPercent(type.Value));

            while (Result_DGV.RowCount < 9)
                Result_DGV.Rows.Add();

            OnInterface();
        }
    }
}
