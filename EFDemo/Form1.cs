using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IBLL;
using BLL;
using Model;
using System.Reflection;

namespace MvcEfTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Shown += OnFormShown;
        }

        private IAdministratorsService AdminService = new AdministratorsService();

        private void OnFormShown(object sender, EventArgs e)
        {
            List<Administrators> list = AdminService.GetModels(p => true).ToList();
            DataTable dt = new DataTable();
            PropertyInfo[] props = typeof(Administrators).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo item in props)
            {
                dt.Columns.Add(item.Name, item.PropertyType);
            }

            foreach (Administrators item in list)
            {
                object[] objs = new object[props.Length];
                for (int i = 0; i < props.Length; i++)
                {
                    objs[i] = props[i].GetValue(item, null);
                }
                dt.Rows.Add(objs);
            }
            dataGridView1.DataSource = dt;
        }
    }
}
