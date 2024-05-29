using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fileor
{
    class Info
    {
        public static string filename = ""; // file name
        public static int rec_size = 24 * 10; //Record Size 10 num of fields and 24 size of encrypted text;
        public static int count;// Count Number of Records

        public static string crtfile()
        {
            SaveFileDialog ofd = new SaveFileDialog();
            ofd.Title = "Select a File";
            ofd.Filter = "Binary File (*.bin)|*.bin";
            //   Path.GetExtension(ofd.FileName).ToLower();

            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.Cancel) { return "-1"; }
            if (ofd.FileName == "")
            {
                MessageBox.Show("please write a valid name ");
                return "";
            }
            else
            {
                return filename = ofd.FileName;
            }
        }
        public static string selectfile()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select a File";
            ofd.Filter = "Binary File (*.bin)|*.bin";
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.Cancel) { return "-1"; }
            return filename = ofd.FileName;
        }

        public static int culc_count()
        {
            if (!File.Exists(filename)) { return 0; }
            var FileLength = new FileInfo(filename);

            int count =  (int) FileLength.Length/ rec_size;
            return count;
        }
    }

}
