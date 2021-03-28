//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace PlaneTickets
//{
//    public partial class Form1 : Form
//    {
//        public Form1()
//        {
//            InitializeComponent();
//        }

//        private void button1_Click(object sender, EventArgs e)
//        {           
//            List<Ticket> formedTicket = new List<Ticket>();
//            Ticket tl = new Ticket("0", "0", comboBox1.SelectedItem.ToString(), comboBox3.SelectedItem.ToString(), "23.12.2019", comboBox2.SelectedItem.ToString());
//            DateTime date1 = new DateTime(2015, 7, 20);
//            Console.WriteLine(date1);
//            formedTicket.Add(tl);
            
//            listBox1.DataSource = formedTicket;


//        }

//        private void button2_Click(object sender, EventArgs e)
//        {

//        }

//        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
//        {

//        }

//        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            if (comboBox1.SelectedItem.Equals(comboBox3.SelectedItem))
//            {
//                //comboBox3.SelectedItem.Checked;
                
//            }
//        }
//    }
//}
