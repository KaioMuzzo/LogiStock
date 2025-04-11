using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogiStock.Forms
{
    public partial class FormListarMercadorias: Form
    {
        bdLogistock bd = new bdLogistock();
        public FormListarMercadorias()
        {
            InitializeComponent();
            bdLogistock.ListarMercadorias(dtGridMerc);
        }
    }
}
