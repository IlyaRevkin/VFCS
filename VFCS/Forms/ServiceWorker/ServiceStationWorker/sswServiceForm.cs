using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VFCS.Classes.Style;
using VFCS.Classes.Style.Controls;
using VFCS.Forms.Template;

namespace VFCS
{
    public partial class sswServiceForm : Template
    {
        int idReg;

        List<(CheckBox, int)> services = new List<(CheckBox, int)>();
        List<int> idServices = new List<int>();
        List<(int, string, int)> mainServices = new List<(int, string, int)>();

        int price = 0;

        bool done = false;

        public sswServiceForm()
        {
            InitializeComponent();
        }

        public sswServiceForm(int idReg, List<int> idServices)
        {
            InitializeComponent();

            this.idReg = idReg;
            this.idServices = idServices;

        }

        private void sswServiceForm_Load(object sender, EventArgs e)
        {
            panelService.AutoScroll = true;

            //Add checkBox in panelService
            try
            {
                Connection.connection.Open();

                foreach (int idService in idServices)
                {
                    string sqlExp = "SELECT * FROM [dbo].[Service]" +
                        " WHERE NOT([id_service] = @idService)";
                    SqlCommand cmd = new SqlCommand(sqlExp, Connection.connection);

                    cmd.Parameters.AddWithValue("@idService", idService);

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                        while (dr.Read())
                            mainServices.Add(((int)dr[0], (string)dr[1], (int)dr[2]));
                    else
                        MessageBox.Show("Ошибка загрузки доступных сервисов");

                    dr.Close();
                }

                int i = 0;
                foreach ((int, string, int) service in mainServices)
                {
                    Panel_ pan = new Panel_();
                    pan.Height = 40;
                    pan.Dock = DockStyle.Top;
                    pan.AutoSize = true;

                    if (!(Convert.ToDouble(i) / 2 == Math.Truncate(Convert.ToDouble(i) / 2)))
                        pan.BackColor = FlatColors.GrayLight2;
                    else
                        pan.BackColor = Color.WhiteSmoke;

                    Label lbName = new Label();
                    lbName.Dock = DockStyle.Top;
                    lbName.AutoSize = true;
                    lbName.Text = "Название: " + service.Item2 +
                        "\nЦена: " + service.Item3.ToString() + " руб";

                    CheckBox ch = new CheckBox();
                    ch.Dock = DockStyle.Bottom;
                    ch.Tag = service.Item1;
                    services.Add((ch, service.Item3));

                    pan.Controls.Add(ch);
                    pan.Controls.Add(lbName);
                    panelService.Controls.Add(pan);

                    i++;
                }

                Connection.connection.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void buttonAddService_Click(object sender, EventArgs e)
        {
            mergeReg_Service();

            if (done == true)
            {
                try
                {
                    Connection.connection.Open();

                    for (int i = 0; i < services.Count; i++)
                        if (services[i].Item1.Checked)
                            price += services[i].Item2;

                    string sqlExp = "UPDATE [dbo].[Registration]" +
                        " SET [price] = @price" +
                        " WHERE [id_reg] = @idReg";
                    SqlCommand cmd = new SqlCommand(sqlExp, Connection.connection);

                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@idReg", idReg);

                    if (cmd.ExecuteNonQuery() != 0)
                    {
                        Connection.connection.Close();

                        serviceWorkerForm swf = new serviceWorkerForm();
                        swf.Show();
                        Close();
                    }
                    else
                        del_Merge();

                    Connection.connection.Close();
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            }
        }

        private void mergeReg_Service()
        {
            // INSERT INTO Service_Reg
            Connection.connection.Open();
            try
            {
                List<int> idServices = new List<int>();

                for (int i = 0; i < services.Count; i++)
                    if (services[i].Item1.Checked)
                        idServices.Add((int)services[i].Item1.Tag);

                if (idServices.Count != 0)
                    foreach (int idService in idServices)
                    {
                        string sqlExp = "INSERT INTO [dbo].[Service_Reg] VALUES" +
                            " (@idService, @idReg);";
                        SqlCommand cmd = new SqlCommand(sqlExp, Connection.connection);

                        cmd.Parameters.AddWithValue("@idService", idService);
                        cmd.Parameters.AddWithValue("@idReg", idReg);

                        if (cmd.ExecuteNonQuery() != 0)
                            done = true;
                        //MessageBox.Show("");
                        else
                            done = false;
                        //MessageBox.Show("");
                    }
                else
                    MessageBox.Show("Ошибка связи регистрации и сервисов");

                Connection.connection.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void del_Merge()
        {
            try
            {
                Connection.connection.Open();

                string sqlExp = "DELETE FROM [dbo].[Service_Reg] WHERE [id_reg] = @idReg";
                SqlCommand cmd = new SqlCommand(sqlExp, Connection.connection);

                cmd.Parameters.AddWithValue("@idReg", idReg);

                if (cmd.ExecuteNonQuery() != 0)
                    MessageBox.Show("Ошибка добавления сервисов, данные связи были удалены");
                else
                    MessageBox.Show("Ошибка добавления сервисов, данные связи не были удалены");

                Connection.connection.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void iconButtonExit_Click(object sender, EventArgs e)
        {
            Connection.connection.Close();

            serviceWorkerForm sswf = new serviceWorkerForm();
            sswf.Show();
            Close();
        }
    }
}
