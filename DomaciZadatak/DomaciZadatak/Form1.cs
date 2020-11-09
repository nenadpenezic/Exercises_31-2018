using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace DomaciZadatak
{
    public partial class novaForma : Form

    {
        private string connectionString = "Data Source=(localdb)\\ProjectsV13;Initial Catalog=FacultyDB;Integrated Security=true;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public novaForma()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection();
            sql.ConnectionString = connectionString;
            sql.Open();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = sql;
            sqlCmd.CommandText = "SELECT * FROM ExerciseResults";
            SqlDataReader sdr = sqlCmd.ExecuteReader();

            List<ExerciseResult> exl = new List<ExerciseResult>();

            while (sdr.Read())
            {
                ExerciseResult ex = new ExerciseResult();
                ex.Id = sdr.GetInt32(0);
                ex.StudentName = sdr.GetString(1);
                ex.StudentIndex = sdr.GetString(2);
                ex.points = sdr.GetInt32(3);
                exl.Add(ex);
            }
            sql.Close();

            foreach(ExerciseResult er in exl)
            {
                listBoxExerciseResults.Items.Add(er.Id + " " + er.StudentName + " " + er.StudentIndex + er.points);
            }
        }
        private void lista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxExerciseResults_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
