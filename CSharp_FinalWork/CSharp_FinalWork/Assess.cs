using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_FinalWork
{
    public partial class Assess : Form
    {
        public Assess(string Link)
        {
            
            InitializeComponent();

            WebService.WebServiceSoapClient Movies = new WebService.WebServiceSoapClient();

            WebService.ArrayOfString assess = null;
            try
            {
                assess = Movies.MovieAssess(Link);
            }
            catch
            {
                MessageBox.Show("加载出错！");
            }

            string[] assessx = assess.ToArray();
            textBox1.Text = "    " + assessx[0];
            textBox2.Text = "    " + assessx[1];
            textBox3.Text = "    " + assessx[2];
        }
    }
}
