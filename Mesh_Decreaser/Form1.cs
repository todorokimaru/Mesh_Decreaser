﻿using System;
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
                XmlTextReader reader = null;
                try
                {
                    reader = new XmlTextReader(fn);
                    //ストリームからノードを読み取る
                    {
                        if (reader.NodeType == XmlNodeType.Element)
                        {
                            switch (reader.LocalName)
                            {
                                case "gml:high":
                                    textBox2.Text += reader.ReadString() + "\r\n";
                                    break;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    reader.Close();
                }
            }

        }
    }
}
