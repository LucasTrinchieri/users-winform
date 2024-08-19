using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsersWinForm
{
    public partial class Pricipal : Form
    {
        public Pricipal()
        {
            InitializeComponent();
        }

        private void Pricipal_Load(object sender, EventArgs e)
        {
            this.usersTableAdapter.Fill(this._users_apiDataSet.Users);

            // Centrar Titulo
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;

            label1.Width = formWidth;
            label1.Height = 30;

            int labelX = (formWidth - label1.Width) / 2;
            int labelY = (formHeight / 100);

            label1.Location = new Point(labelX, labelY);

            label1.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void btn_nuevoUser_Click(object sender, EventArgs e)
        {
            DataRow newRow = this._users_apiDataSet.Users.NewRow();

            newRow["Name"] = txt_name.Text;
            newRow["Email"] = txt_email.Text;

            this._users_apiDataSet.Users.Rows.Add(newRow);

            this.usersTableAdapter.Update(this._users_apiDataSet.Users);

            this.usersTableAdapter.Fill(this._users_apiDataSet.Users);

            MessageBox.Show("Registro agregado exitosamente.");
        }

        private void btn_ModifyUser_Click(object sender, EventArgs e)
        {
            int userId = int.Parse(txt_userId.Text);
            DataRow[] rows = _users_apiDataSet.Users.Select("UserID = " + userId);

            if (rows.Length > 0)
            {
                DataRow userRow = rows[0];
                userRow["Name"] = txt_name.Text;
                userRow["Email"] = txt_email.Text;

                usersTableAdapter.Update(_users_apiDataSet.Users);

                usersTableAdapter.Fill(_users_apiDataSet.Users);

                MessageBox.Show("Usuario modificado exitosamente.");
            }
            else
            {
                MessageBox.Show("Usuario no encontrado.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_userId.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["UserId"].Value);
            txt_name.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["UserName"].Value);
            txt_email.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["Email"].Value);
        }

        private void btn_DeleteUser_Click(object sender, EventArgs e)
        {
            int userId = int.Parse(txt_userId.Text);
            DataRow[] rows = _users_apiDataSet.Users.Select("UserID = " + userId);

            if (rows.Length > 0)
            {
                DataRow userRow = rows[0];
                userRow.Delete();

                usersTableAdapter.Update(_users_apiDataSet.Users);

                usersTableAdapter.Fill(_users_apiDataSet.Users);

                MessageBox.Show("Usuario eliminado exitosamente.");
            }
            else
            {
                MessageBox.Show("Usuario no encontrado.");
            }
        }
    }
}
