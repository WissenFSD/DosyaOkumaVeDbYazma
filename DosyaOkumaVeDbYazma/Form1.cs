using System.Data.SqlClient;

namespace DosyaOkumaVeDbYazma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            string path = @"C:\Windows\System32";


            foreach (var item in Directory.GetFiles(path))
            {
                lstDosyalar.Items.Add(Path.GetFileName(item));


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btndb_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source=.;initial catalog=FileDatabase;integrated security=true");
            con.Open();
            foreach (string item in lstDosyalar.Items)
            {

                SqlCommand cmd = new SqlCommand("insert into FileName (Name) values (@name)", con);
                cmd.Parameters.Add(new SqlParameter("@name", item));
                

                // insert update ve delete sorgularýný db'de çalýþtýrmaya yarar
                cmd.ExecuteNonQuery();
              

            }
            con.Close();



        }
    }
}