using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace CodeFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Hitss_TM2 db = new Hitss_TM2();
        int index;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
                var Name2 = txtName.Text;
                var Descripcion2 = txtDescription.Text;
                var fecha2 = TimeStartDate.Value.ToString("yyyy-MM-dd");           
                var ADDCompany = new Company { Name = Name2, Description= Descripcion2, StartDate=Convert.ToDateTime(fecha2),Statee=1 };
                db.Company.Add(ADDCompany);
                db.SaveChanges();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            Company company = db.Company.FirstOrDefault(c => c.ID == id);
            db.Company.Remove(company);
            db.SaveChanges();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowCustomer.DataSource=db.Company.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBuscar.Text);
            List<Company> temporal = new List<Company>();
            temporal.Add(db.Company.FirstOrDefault(c => c.ID == id));
            ShowCustomer.DataSource = temporal;

        }

        private void ShowCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            try { txtName.Text = ShowCustomer.Rows[index].Cells[1].Value.ToString(); }
            catch { txtName.Text = "NULL"; }
            try { txtDescription.Text = ShowCustomer.Rows[index].Cells[2].Value.ToString(); }
            catch { txtDescription.Text = "NULL"; }
            try { TimeStartDate.Text = ShowCustomer.Rows[index].Cells[3].Value.ToString(); }
            catch { }
            try { txtID.Text = ShowCustomer.Rows[index].Cells[0].Value.ToString(); }
            catch { txtID.Text = "NULL"; }
            btnEliminar.Enabled = true;
            btnModificicar.Enabled = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnModificicar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            Company company = db.Company.FirstOrDefault(c => c.ID == id);
            if (company != null)
            {
                company.Name = txtName.Text;
                company.Description = txtDescription.Text;
                company.StartDate = Convert.ToDateTime(TimeStartDate.Value.ToString("yyyy-MM-dd"));
                db.SaveChanges();
            }
        }

        private void ShowCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
