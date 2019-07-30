using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HypervApp
{
    public partial class FrmSetting : Form
    {
        public FrmSetting()
        {
            InitializeComponent();
            propertyGrid1.SelectedObject = Properties.Settings.Default;
            
        }
    }
}
