using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PowerCombiner
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
            buttonCombine.Click += new EventHandler(buttonCombine_Click);
            buttonBrowse.Click += new EventHandler(ChooseFolder);
        }

        //Chose the input folder
        public void ChooseFolder(object sender, System.EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                inputFolder.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        //Combine files in input foldwer
        private void buttonCombine_Click(object sender, System.EventArgs e)
        {
            string inputPath = inputFolder.Text;
            string fileType = inputFileType.Text;
            fileType = fileType.Replace(".", "" );
            if (string.IsNullOrEmpty(fileType))
            {
                fileType = "*";
            }
            fileType = "*." + fileType;
            string outputPath = inputFolder.Text + "\\PowerCombined.txt";
            File.Delete(outputPath);

            string[] fileArray = Directory.GetFiles(inputPath, fileType);
            progressBar.Maximum = fileArray.Length;
            progressBar.Value = 0;

            using (var outputStream = File.Create(outputPath))
            {
                foreach (string file in fileArray)
                {
                    using (var fileContent = File.OpenRead(file))
                    {
                        fileContent.CopyTo(outputStream);
                        progressBar.Value += 1;
                    }

                }
            }
        }
    }
}
