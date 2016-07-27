using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace Mesh_Decreaser
{
    class xml_loader
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
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    switch (reader.LocalName)
                    {
                        case "p":
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
