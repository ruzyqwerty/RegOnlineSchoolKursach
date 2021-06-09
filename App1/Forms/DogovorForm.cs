using App1.SQL;
using System;
using System.Data;
using System.Windows.Forms;

namespace App1.Forms
{
    public partial class DogovorForm : Form
    {
        // переменная для работы с бд
        private SQLManager SQLManager = new SQLManager();

        // переменные хранящие инфу о клиенте, курсе и организации (если это редактирование)
        private int codeOrg;
        private int codeClient;
        private int codeKurs;

        public DogovorForm(int clientId, int kursId)
        {
            InitializeComponent();

            DataTable dataTable = SQLManager.GetDataTable("Kurs");

            string sql = $"SELECT * from Kurs WHERE CODE_CY = {kursId}";
            codeKurs = SQLManager.GetIntValue(sql, 0);
            int orgCode = SQLManager.GetIntValue(sql, 1);
            int prepodCode = SQLManager.GetIntValue(sql, 2);
            string kursName = SQLManager.GetStringValue(sql, 3);
            int chasov = SQLManager.GetIntValue(sql, 4);
            decimal money = SQLManager.GetMoneyValue(sql, 5);

            kursNameText.Text = kursName;
            chasiText.Text = chasov.ToString();
            priceText.Text = money.ToString();

            sql = $"SELECT * from Organizatsia WHERE CODE_ORG = {orgCode}";
            codeOrg = SQLManager.GetIntValue(sql, 0);
            string orgName = SQLManager.GetStringValue(sql, 1);
            string orgAdres = SQLManager.GetStringValue(sql, 2);
            string orgRukovod = SQLManager.GetStringValue(sql, 3);
            string orgTelefon = SQLManager.GetStringValue(sql, 4);

            orgNameText.Text = orgName;
            adresText.Text = orgAdres;
            rukovodText.Text = orgRukovod;
            phoneText.Text = orgTelefon;

            sql = $"SELECT * from Prepodavateli WHERE CODE_PD = {prepodCode}";
            string prepodImya = SQLManager.GetStringValue(sql, 1);
            string prepodFam = SQLManager.GetStringValue(sql, 2);
            string prepodOtch = SQLManager.GetStringValue(sql, 3);
            int staz = SQLManager.GetIntValue(sql, 4);
            string prepodTelefon = SQLManager.GetStringValue(sql, 5);

            prepodNameText.Text = $"{prepodFam} {prepodImya} {prepodOtch}";
            stazText.Text = staz.ToString();
            prepodPhoneText.Text = prepodTelefon;

            codeClient = clientId;
        }

        // отмена оформления договора
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // оформление договора
        private void acceptBtn_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO Dogovor (CODE_ORG, CODE_CL, CODE_CY, DATA) ";
            DateTime date = DateTime.Now;
            sql += $"VALUES ({codeOrg}, {codeClient}, {codeKurs}, '{date:yyyy-MM-dd}')";

            SQLManager.ExecuteSQLCommand(sql);

            this.Close();
        }
    }
}
