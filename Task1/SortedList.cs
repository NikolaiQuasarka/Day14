using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class SortedList : Form
    {
        public SortedList(List<Apartment> apartments)
        {
            InitializeComponent();
            dataGridView1.DataSource = apartments;
        }
    }
}
