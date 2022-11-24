using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01_Moya_Create
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string studentNo = txtStudentNo.Text;
            string fullname = txtFirstName.Text + " " + txtMiddleInitial.Text + " " + txtLastName.Text;
            string Program = cbGender.Text;
            string gender = cbGender.Text;
            string age = txtAge.Text;
            string birthday = datePickerBirthday.Text;
            string contact = txtContactNo.Text;

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            string filename = studentNo + ".txt";

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, filename)))
            {
                outputFile.WriteLine("Student No.: {0}\n" +"Fullname: {1}\n"+"Program: {2}\n" +"Gender: {3}\n"+"Age: {4}\n" +"Birtday: {5}\n"+"Contact no: {6}", studentNo, fullname, Program, gender, age, birthday, contact);

            }
        }
    }
}
