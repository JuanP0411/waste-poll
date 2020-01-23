using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using model;



namespace Interface
{
    public partial class Form1 : Form
    {
        public List<Person> PersonList = new List<Person>();
     
        public Form1()
        {
            InitializeComponent();
            
        }

        
        

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lbPreference_Click(object sender, EventArgs e)
        {

        }

        private void btSave_Click(object sender, EventArgs e)
        {
            String name = txbName.Text;
            int age = int.Parse(txbAge.Text);
            String waste = cmbWaste.SelectedItem.ToString();
            String wasteAmount = txbWaste.Text;
            String recycle = cmbRecycle.SelectedItem.ToString();
            Person temp = new Person(name, age,wasteAmount ,waste,recycle);
            PersonList.Add(temp);
             
            Console.Write(temp.toString());

            MessageBox.Show("Se agrego exitosamente la persona");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btShow_Click(object sender, EventArgs e)
        {
            String message = "";
            for(int j = 0; j < PersonList.Count; j++)
            {
                //puse un to string personal que devuelve la persona en fomra de texto
                message += PersonList[j].toString() + "\n"
                    +"------------------" + "\n";
            }
            Console.Write(message);
            
        }
    }
}
