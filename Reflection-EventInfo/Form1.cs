using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reflection_EventInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Type t = typeof(Button);

            EventInfo[] eInfo = t.GetEvents();

            int counter = 0;
            foreach (EventInfo item in eInfo)
            {
                listBox1.Items.Add(item.Name + " => " + item.EventHandlerType);
                if (counter %5 ==0)
                {
                    listBox1.Items.Add("");
                }
                
                counter++;
            }


        }
    }
}
