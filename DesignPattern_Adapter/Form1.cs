using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPattern_Adapter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ReaderAdapter RA = new ReaderAdapter();
            RA.Read("IssoAqui.doc");
            RA.Read("PercyJackson.pdf");
            RA.Read("MatériaHistória.doc");
            RA.Read("HarryPotter.pdf");
            RA.Read("ASereia.pdf");
            RA.Read("Trabalho.doc");
        }
    }
}
