using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeaderFooterAdded
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateOutputFolder(string path)
        {
            string folderPath;

            folderPath = path;

            folderPath = path + "\\Output";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            string filePath;

            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (DialogResult.OK == openFileDialog.ShowDialog())
            {
                Image image = Image.FromFile(openFileDialog.FileName);
                Image result;

                result = Adder.AddHeaderAndFooter(image);

                CreateOutputFolder(Path.GetDirectoryName(openFileDialog.FileName));
                filePath = Path.GetDirectoryName(openFileDialog.FileName) + "\\Output\\" + Path.GetFileName(openFileDialog.FileName);

                result.Save(filePath);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if (DialogResult.OK == folderBrowser.ShowDialog())
            {
                string path = folderBrowser.SelectedPath;
                string[] files = Directory.GetFiles(path);
                
                CreateOutputFolder(path);

                foreach (string file in files)
                {
                    Image result;
                    string filePath;

                    result = Adder.AddHeaderAndFooter(Image.FromFile(file));

                    filePath = path + "\\Output\\" + Path.GetFileName(file);
                    result.Save(filePath);
                }
            }
        }
    }
}
