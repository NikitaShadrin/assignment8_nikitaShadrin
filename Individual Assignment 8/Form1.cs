using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Individual_Assignment_8
{
    public partial class Form1 : Form
    {

        List<String> list1;
        List<String> list2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            list1 = file_to_arr("File1.txt");
            list2 = file_to_arr("File2.txt");
        }

        private List<String> file_to_arr(String file_name)
        {
            List<String> loaded_array = new List<String>();
            StreamReader inputFile;
            inputFile = File.OpenText(file_name);
            while (!inputFile.EndOfStream)
            {
                loaded_array.Add(inputFile.ReadLine());
            }
            inputFile.Close();
            return loaded_array;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (list1.Contains(textBox1.Text))
            {
                label1.Text = textBox1.Text + " was found in the first list";
            }
            else if (list2.Contains(textBox1.Text))
            {
                label1.Text = textBox1.Text + " was found in the second list";
            }
            else
            {
                label1.Text = textBox1.Text + " was not found in either list";
            }
        }
    }
}
