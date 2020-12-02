using BusinessLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBoxStudents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadForm(object sender, EventArgs e)
        {
            StudentBusiness Conn = new StudentBusiness();
            listBoxStudents.Items.Clear();
            foreach(Student s in Conn.GetAllStudents())
            {
                listBoxStudents.Items.Add(s);
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.Name = textBoxName.Text;
            s.Index = textBoxIndex.Text;
            s.Average = decimal.Parse(textBoxAverage.Text);
            StudentBusiness Conn = new StudentBusiness();
            Conn.EnableInsert(s);
            listBoxStudents.Items.Clear();
            foreach (Student t in Conn.GetAllStudents())
            {
                listBoxStudents.Items.Add(t);
            }
        }
    }
}
