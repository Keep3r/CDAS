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

namespace Checador_de_arquivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static int numberOfNullFiles { get; set; }
        static int numberOfFiles { get; set; }
        static int numberOfDeletedFiles { get; set; }

        static void GetFiles(string path, bool delFiles)
        {

            string[] files = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);

            foreach (string item in files)
            {
                numberOfFiles++;
                FileInfo obj = new FileInfo(item);
                if (obj.Length == 0 || obj == null)
                {
                    numberOfNullFiles++;
                    if (delFiles)
                    {
                        numberOfDeletedFiles++;
                        obj.Delete();
                    }
                }
            }
        }

        private void txtB_Path_TextChanged(object sender, EventArgs e) {  }

        private void bt_Start_Click(object sender, EventArgs e)
        {
            GetFiles(txtB_Path.Text, chckB_DeleteNullFiles.Checked);
            MessageBox.Show(String.Format("Number of null files: {0}", numberOfNullFiles, MessageBoxIcon.Error, MessageBoxOptions.RightAlign, MessageBoxButtons.OK));
            if (chckB_DeleteNullFiles.Checked) MessageBox.Show(String.Format("Number of Deleted files: {0}", numberOfDeletedFiles, MessageBoxButtons.OK, MessageBoxIcon.Error));
            lb_NullFiles.Text = numberOfNullFiles.ToString();
            lb_Files.Text = numberOfFiles.ToString();
            numberOfFiles = 0;
            numberOfNullFiles = 0;
        }
    }
}
