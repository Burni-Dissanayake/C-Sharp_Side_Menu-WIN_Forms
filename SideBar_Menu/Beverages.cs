using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SideBar_Menu
{
    public partial class Beverages : UserControl
    {
        private static Beverages beverages;

        public static Beverages Instance
        {
            get
            {
                if (beverages == null)
                {
                    beverages = new Beverages();
                }

                return beverages;
            }
        }

        public Beverages()
        {
            InitializeComponent();
        }
    }
}
