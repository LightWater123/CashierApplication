using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeNamespace;

namespace EmployeeApplication
{
    public partial class frmEmployeeDatabase : Form
    {
        public frmEmployeeDatabase()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmEmployeeDatabase_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string empID = textBox1.Text;
            string fName = textBox2.Text;
            string lName = textBox3.Text;
            string position = textBox4.Text;

            try
            {
                if (string.IsNullOrWhiteSpace(empID) || string.IsNullOrWhiteSpace(fName) ||
                string.IsNullOrWhiteSpace(lName) || string.IsNullOrWhiteSpace(position))
                {
                    MessageBox.Show("Fill in the blanks.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("An exception occured.", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            Employee emp = new Employee(empID, fName, lName, position);

            dataGridView1.Rows.Add(emp.EmpID, emp.FName, emp.LName, emp.Position);



            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
