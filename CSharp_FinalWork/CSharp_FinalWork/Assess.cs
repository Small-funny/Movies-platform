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

            cn.smallfunny.web.WebService Movies = new cn.smallfunny.web.WebService();

            string[] assess = null;
            try
            {
                assess = Movies.MovieAssess(Link);
            }
            catch
            {
                MessageBox.Show("加载出错！");
            }

            textBox1.Text = "    " + assess[0];
            textBox2.Text = "    " + assess[1];
            textBox3.Text = "    " + assess[2];
        }
    }
}
