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

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {


            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Displays an OpenFileDialog so the user can select a Cursor.
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "KEY FILE|*.txt";
            openFileDialog1.Title = "Select a CLASSIC-KEY File";

            // Show the Dialog.
            // If the user clicked OK in the dialog 
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                classic.Text = openFileDialog1.FileName;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog2 = new OpenFileDialog();
            openFileDialog2.Filter = "KEY FILE (*.txt)|*.txt";
            openFileDialog2.Title = "Select a LOD-KEY File";

            // Show the Dialog.
            // If the user clicked OK in the dialog 
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                lod.Text = openFileDialog2.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (classic.Text == "" || lod.Text == "" || praefix.Text == "" || listname.Text == "" || target.Text == "")
            {
                string message2 = "Please fill all Fields!";
                string caption2 = "ERROR";
                MessageBoxButtons buttons2 = MessageBoxButtons.OK;
                DialogResult result2;

                // Displays the MessageBox.

                result2 = MessageBox.Show(message2, caption2, buttons2);

                if (result2 == System.Windows.Forms.DialogResult.Yes)
                {
                    this.Close();
                }
                return;
            }
            StreamReader classic_file = new StreamReader(classic.Text);
            StreamReader lod_file = new StreamReader(lod.Text);
            StreamWriter outputFile = new StreamWriter(target.Text, false);
            string line_classic;
            string line_lod;
            int i = 0;
            string add;
          
            add = "{\"CDKeys\":[";
            outputFile.Write(add);
            // Read and display lines from the file until the end of 
            // the file is reached.
            while (((line_classic = classic_file.ReadLine()) != null)&& ((line_lod = lod_file.ReadLine()) != null))
            {
                if (i > 0)
                {
                    add = ",";
                    outputFile.Write(add);
                }
                i++;

                add = "{ \"Name\":\""+praefix.Text+"-"+ i +"\",\"Classic\":\""+line_classic+"\",\"Expansion\":\""+line_lod+"\"}";
                outputFile.Write(add);
            }
            add =  "],\"Name\":\"" + listname.Text + "\",\"east\":0,\"west\":0,\"euro\":0,\"asia\":0}";
            outputFile.Write(add);
            // Initializes the variables to pass to the MessageBox.Show method.

            string message = "added "+i+" keys";
            string caption = "KEYS added";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;

            // Displays the MessageBox.

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
            outputFile.Close();
            classic_file.Close();
            lod_file.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }
    }
}
