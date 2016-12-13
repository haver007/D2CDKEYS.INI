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
    public partial class Form2 : Form
    {
        public Form2()
        {


            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
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
                keys.Text = openFileDialog1.FileName;

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
                spacing.Text = openFileDialog2.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (keys.Text == "" || spacing.Text == "" || praefix.Text == "" || listname.Text == "" || target.Text == "")
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
            StreamReader key_file = new StreamReader(keys.Text);
            StreamWriter outputFile = new StreamWriter(target.Text, false);
            string line_keys;
            int i = 0;
            string add;
          
            add = "{\"CDKeys\":[";
            outputFile.Write(add);
            // Read and display lines from the file until the end of 
            // the file is reached.
            while (((line_keys = key_file.ReadLine()) != null))
            {
                if (i > 0)
                {
                    add = ",";
                    outputFile.Write(add);
                }
                i++;
                char delimiter = spacing.Text[0];
                String[] substrings = line_keys.Split(delimiter);
                if(substrings.Length<2)
                {
                    string message3 = "Do you used the right delimiter? or your file is not correct Tip around Line: "+ i;
                    string caption3 = "ERROR";
                    MessageBoxButtons buttons3 = MessageBoxButtons.OK;
                    DialogResult result3;

                    // Displays the MessageBox.

                    result3 = MessageBox.Show(message3, caption3, buttons3);

                    if (result3 == System.Windows.Forms.DialogResult.Yes)
                    {
                        
                        this.Close();
                    }
                    outputFile.Close();
                    key_file.Close();
                    return;
            }
                add = "{ \"Name\":\""+praefix.Text+"-"+ i +"\",\"Classic\":\""+ substrings[0] + "\",\"Expansion\":\"" + substrings[1] + "\"}";
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
            key_file.Close();
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
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }
    }
}
