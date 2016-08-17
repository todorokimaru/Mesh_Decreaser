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
using System.Xml;

namespace Mesh_Decreaser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            string fn = openFileDialog1.FileName;
            textBox1.Text = fn;
            if (File.Exists(fn))
            {
                XmlDocument reader = new XmlDocument();
                reader.Load(fn);
                
                try
                {
                    XmlElement rootElement = reader.DocumentElement;
                    //ストリームからノードを読み取る
                    {
                        XmlNodeList graundList =
                            reader.GetElementsByTagName("low");
                        Console.WriteLine(graundList.Count.ToString());
                        for(int i=0; i < graundList.Count; i++)
                        {
                            textBox2.Text += graundList[i].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
    }
}
