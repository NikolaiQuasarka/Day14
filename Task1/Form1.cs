using System.Text.RegularExpressions;

namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            apartments= new List<Apartment>();
            Apartment.GenerateApartments(ref apartments);
            bindingSource1.DataSource = apartments;
            dataGridView1.DataSource = bindingSource1;
            
        }
        List<Apartment> apartments;
        private void buttonSort_Click(object sender, EventArgs e)
        {
            IEnumerable<Apartment> sortedApartments = apartments;

            if(checkBox1.Checked& uint.TryParse(textBoxMinRoomsCount.Text, out uint RoomCount))
            sortedApartments = from a in sortedApartments where a.Rooms>=RoomCount select a;

            if (checkBox2.Checked)
            {
                Regex r = new Regex("[0-9]{4}");
                sortedApartments = from a in sortedApartments where r.IsMatch(a.YearBuilt.ToString()) select a;
            }

            if (checkBox3.Checked)
            {
              
                sortedApartments = from a in sortedApartments where a.Address.Contains(textBoxDistrict.Text)
                                   select a;
            }
            if (checkBox4.Checked)
            {
                sortedApartments = from a in sortedApartments where a.Address.Contains(textBoxCity.Text) select a;
            }

            if(checkBox5.Checked& uint.TryParse(textBoxMinArea.Text, out uint Area))
                sortedApartments = from a in sortedApartments where   a.Area >= Area select a;
            if(checkBox6.Checked & uint.TryParse(textBoxMaxPrice.Text, out uint Price))
                sortedApartments = from a in sortedApartments where a.Price >= Price select a;

            SortedList sortedList = new SortedList(sortedApartments.ToList());
            sortedList.ShowDialog();
        }
    }
}
