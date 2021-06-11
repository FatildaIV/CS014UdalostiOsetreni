using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS014UdalostiOsetreni
{
    public partial class UdalostiOsetreniForm : Form
    {
        private int pocetUdalosti = 0;

        public UdalostiOsetreniForm()
        {
            InitializeComponent();
        }

        private void UdalostZaznam(string zprava) 
        {
            udalostiListBox.Items.Insert(0, String.Format("{0:D4} {1}", pocetUdalosti++, zprava));  // pocet++->pocet = pocet + 1
        }

        private string KurzorSouradnice(int x, int y)
        {
            return String.Format("X: {0:D3}, Y: {1:D3}", x, y);
        }

        private void UdalostiOsetreniForm_MouseMove(object sender, MouseEventArgs e)
        {
            souradniceLabel.Text = KurzorSouradnice(e.X, e.Y);
            UdalostZaznam(string.Format("MouseMove {0}", KurzorSouradnice(e.X, e.Y)));
        }

        private void UdalostiOsetreniForm_MouseClick(object sender, MouseEventArgs e)
        {
            UdalostZaznam("MouseClick");
        }

        private void UdalostiOsetreniForm_MouseDown(object sender, MouseEventArgs e)
        {
            UdalostZaznam("MouseDown");
        }

        private void UdalostiOsetreniForm_MouseEnter(object sender, EventArgs e)
        {
            UdalostZaznam("MouseEnter");
        }

        private void UdalostiOsetreniForm_MouseLeave(object sender, EventArgs e)
        {
            UdalostZaznam("MouseLeave");
        }
    }
}
