using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;


namespace БилетыВКинотеатр
{
    public partial class RageWindow : Form
    {
        public ComboBox CBLine;
        public ComboBox CBPlace;
        public Dictionary<string, List<string>> data = new Dictionary<string, List<string>>();
        public RageWindow()
        {

            InitializeComponent();
            data["1 ряд"] = new List<string> { "1 место", "2 место", "3 место", "4 место" };
            data["2 ряд"] = new List<string> { "5 место", "6 место", "7 место", "8 место" };
            data["3 ряд"] = new List<string> { "9 место", "10 место", "11 место", "12 место" };
            CBLine = new ComboBox { Parent = this, DropDownStyle = ComboBoxStyle.DropDownList, Top = 40, Left = 20 };
            CBPlace = new ComboBox { Parent = this, DropDownStyle = ComboBoxStyle.DropDownList, Top = 110, Left = 20 };
            CBLine.SelectedIndexChanged += new EventHandler(CBLine_SelectedIndexChanged);
            CBLine.DataSource = data.Keys.ToList();
            CBTime.Items.AddRange(new string[] { "10:00", "13:30", "18:30", "20:00", "23:00" });
        }

        private void CheckBtn_Click(object sender, EventArgs e)
        {
            if (CBTime.Text != "Выберите время" && lblTime.Text != "" )
            {
                if (TBPay.TextLength == 16)
                {
                    MessageBox.Show("Фильм: Гнев человеческий         " + lblTime.Text + "   Время: " + CBTime.Text + ".    Ряд: " + CBLine.Text + ".       Место: " + CBPlace.Text, "Билет");
                }
                else
                {
                    MessageBox.Show("Внесите данные по карте!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Не все данные выбраны!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }
        private void CBLine_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBPlace.DataSource = data[CBLine.SelectedItem.ToString()];
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            lblTime.Text = String.Format(" Дата : {0}", e.Start.ToLongDateString());
        }

        

        private void TBPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MenuWindow f6 = new MenuWindow();
            f6.Show();
            this.Close();
        }

        private void TBPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBPay_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }

        private void TBPay_MouseClick(object sender, MouseEventArgs e)
        {
            TBPay.Clear();
        }

        private void TBPhone_MouseClick(object sender, MouseEventArgs e)
        {
         
        }

        private void TBPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }
    }
}
