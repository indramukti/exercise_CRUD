using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercise_CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'exercise_PabdDataSet3.asdos' table. You can move, or remove it, as needed.
            this.asdosTableAdapter.Fill(this.exercise_PabdDataSet3.asdos);
            // TODO: This line of code loads data into the 'exercise_PabdDataSet3.dosen' table. You can move, or remove it, as needed.
            this.dosenTableAdapter.Fill(this.exercise_PabdDataSet3.dosen);
            // TODO: This line of code loads data into the 'exercise_PabdDataSet2.mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter2.Fill(this.exercise_PabdDataSet2.mahasiswa);
            // TODO: This line of code loads data into the 'exercise_PabdDataSet1.mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter1.Fill(this.exercise_PabdDataSet1.mahasiswa);
            // TODO: This line of code loads data into the 'exercise_PabdDataSet.mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.exercise_PabdDataSet.mahasiswa);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nama_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
