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

namespace CopyFile
{

    public partial class CopyingFileForm : Form
    {
        OpenFileDialog inputFileDialog = new OpenFileDialog();
        OpenFileDialog outFileDialog = new OpenFileDialog();
        public CopyingFileForm()
        {
            InitializeComponent();
            fromButton.Click += FromButttonClick;
            toButton.Click += ToButtonClick;
        }

        void FromButttonClick(object sender, EventArgs e)
        {
            inputFileDialog.ShowDialog();
            fromTextBox.Text = inputFileDialog.FileName;
        }

        void ToButtonClick(object sender, EventArgs e)
        {
            outFileDialog.ShowDialog();
            toTextBox.Text = outFileDialog.FileName;
        }

        void CopyFile(object sender, EventArgs e)
        {
            int buffersize = inputFileDialog.FileName.Length;
            FileStream inputStream = new FileStream(inputFileDialog.FileName, FileMode.Open);
            byte []
            inputStream.Read();

        }
    }
}
