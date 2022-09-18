using BuyMore.controllers;
using ConsoleTables;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuyMore
{
    public partial class Rapport : Form
    {
        public PrintDocument PrintDocument1 { get; private set; }

        public Rapport()
        {
            InitializeComponent();
        }

        private void Rapport_Load(object sender, EventArgs e)
        {

        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int y = 80;
            string datee,year,month,day;
            year = theDate.Value.Year.ToString();
            month = theDate.Value.Month.ToString();
            day = theDate.Value.Day.ToString();
            datee = year + "/" + month + "/" + day;
            MySqlDataReader result = VenteC.getAllVente(datee);
            e.Graphics.DrawString("Buy More", new Font("Arial", 16, FontStyle.Bold),Brushes.Black ,new Point(350, 10));
                     
            var table = new DataTable();
            table.Columns.Add("ID", typeof(string));
            table.Columns.Add("NOM", typeof(string));
            table.Columns.Add("PRIX", typeof(string));
            table.Columns.Add("QUANTITE", typeof(string));
            table.Columns.Add("TOTAL", typeof(string));
            table.Columns.Add("DATE", typeof(string));
            while(result.Read())
            {
                table.Rows.Add(result["id"].ToString(),result["nom_du_produit"].ToString(), result["prix"].ToString(), result["quantite"].ToString(), result["total"].ToString(), result["date"].ToString());
            }
            
            var data = table;
            string[] colummnNames = data.Columns.Cast<DataColumn>().Select(x => x.ColumnName).ToArray();
            DataRow[] rows = data.Select();
            var tata = new ConsoleTable(colummnNames);
            foreach (DataRow row in rows)
            {
                tata.AddRow(row.ItemArray);
            }

            e.Graphics.DrawString(tata.ToString(), new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(50, y));
            
        }

        private void PrintPreviewDialog1_Load(object sender, EventArgs e)
        {
           
        }

        private void Imprimer_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog1 = new PrintDialog();
            printDialog1.Document = PrintDocument1;
            DialogResult result = printDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void BunifuButton1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
