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
    public partial class ewTimelessForm : Template
    {
        List<int> timelessIdReg = new List<int>();

        public ewTimelessForm()
        {
            InitializeComponent();
        }

        public ewTimelessForm(List<int> timelessIdReg)
        {
            InitializeComponent();

            this.timelessIdReg = timelessIdReg;
        }

        private void ewTimelessForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < timelessIdReg.Count; i++)
                PanLoad(i);
        }

        private void PanLoad(int i)
        {
            panelMain.AutoScroll = true;

            try
            {
                Connection.connection.Open();

                string sqlExp = "SELECT [name], [model_name], [id_configuration], [description_service], [dbo].[Registration].[id_reg]" +
               " FROM [dbo].[Registration]" +
               " join [dbo].[Model] ON [dbo].[Model] .[id_model] = [dbo].[Registration].[id_model]" +
               " join [dbo].[Service_Reg] ON [dbo].[Service_Reg].[id_reg] = [dbo].[Registration].[id_reg]" +
               " join [dbo].[Service] ON [dbo].[Service].[id_service] = [dbo].[Service_Reg].[id_service]" +
               " WHERE [dbo].[Registration].[id_reg] = @idReg";
                SqlCommand cmd = new SqlCommand(sqlExp, Connection.connection);

                cmd.Parameters.AddWithValue("@idReg", timelessIdReg[i]);

                SqlDataReader dr = cmd.ExecuteReader(); 

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Panel_ pan = new Panel_();
                        pan.Padding = new Padding(5);
                        pan.AutoSize = true;
                        pan.Dock = DockStyle.Top;

                        if (!(Convert.ToDouble(i) / 2 == Math.Truncate(Convert.ToDouble(i) / 2)))
                            pan.BackColor = FlatColors.GrayLight2;
                        else
                            pan.BackColor = Color.WhiteSmoke;

                        Label lb = new Label();
                        lb.Dock = DockStyle.Top;
                        lb.Text = dr[0].ToString();

                        Label lbConfModel = new Label();
                        lbConfModel.Dock = DockStyle.Top;
                        lbConfModel.Text = dr[1].ToString() + " " + dr[2].ToString();

                        pan.Controls.Add(lb);
                        pan.Controls.Add(lbConfModel);

                        pan.Tag = (int)dr[4];
                        pan.Click += new EventHandler(panTimeReg_Click);

                        panelMain.Controls.Add(pan);
                    }
                    dr.Close();
                }
                else
                    MessageBox.Show("Ошибка получения данных");

                Connection.connection.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void panTimeReg_Click(object sender, EventArgs e)
        {
            var pan = (Panel)sender;
            int idReg = (int)pan.Tag;

            ewCurrentForm ewcf = new ewCurrentForm(idReg, 1);
            ewcf.Show();
            Close();
        }

        private void iconButtonExit_Click(object sender, EventArgs e)
        {
            EvaluationWorkerForm ewf = new EvaluationWorkerForm();
            ewf.Show();
            Close();
        }
    }
}
