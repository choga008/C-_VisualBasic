using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yogi_ireland
{
    public partial class Form2 : Form
    {
        //public ListBox FormList { get { return MgmtListBox; } }    

        public Form2()
        {
            InitializeComponent();
        }

        public void Form2_Load(object sender, EventArgs e)
        {
            //get today's date
            string Date = DateTime.Now.ToString("yyyy-MM-dd");
            string Time = DateTime.Now.ToString("HH:mm:ss tt");
            DateLabel.Text = Date;
            TimeLabel.Text = Time;            

    }
    
}
