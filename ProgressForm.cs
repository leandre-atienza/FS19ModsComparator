using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FS19ModsComparator
{
    public partial class ProgressForm : Form
    {
        public ProgressForm(int progressMax)
        {
            InitializeComponent();
            progressbar.Maximum = progressMax;
        }

        public void setCurrentLabel(string text)
        {
            lbl_current.Text = text;
        }

        public void setCurrentValue(int value)
        {
            progressbar.Value = value;
        }
        
        public int getCurrentValue()
        {
            return progressbar.Value;
        }
    }
}
