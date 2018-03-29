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
        SaveFileDialog outFileDialog = new SaveFileDialog();
        public CopyingFileForm()
        {
            InitializeComponent();
            fromButton.Click += FromButttonClick;
            toButton.Click += ToButtonClick;
            copyingButton.Click += CopyFile;
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
           
            const int bufSize = 1024 * 4;//4kb
            try
            {
                using (FileStream inputFile = new FileStream(inputFileDialog.FileName, FileMode.Open))
                {
                    byte[] buffer = new byte[bufSize];
                    int rW_count = (int)inputFile.Length / bufSize;//кол-во циклов чтения записи
                    int lastSize = (int)inputFile.Length % bufSize;//размер последнего копирования, как остаток от деления размера файла к размеру буфера  

                    using (FileStream outFile = new FileStream(outFileDialog.FileName, FileMode.OpenOrCreate))
                    {
                        progressBar.Minimum = 0;
                        progressBar.Maximum = 10;
                        for (int i = 0; i < rW_count; i++)
                        {
                            inputFile.Read(buffer, 0, bufSize);
                            outFile.Write(buffer, 0, bufSize);
                            progressBar.Increment((int)outFile.Length);
                        }
                        if (lastSize != 0)
                        {
                            inputFile.Read(buffer, 0, lastSize);
                            outFile.Write(buffer, 0, lastSize);
                        }
                        MessageBox.Show("Копирование завершено!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось открыть файл!");
            }
        }
    }
}
