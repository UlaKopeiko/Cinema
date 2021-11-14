using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace БилетыВКинотеатр
{
    public partial class GodzillaWindow : Form
    {
        private ComboBox CBLine;
        private ComboBox CBPlace;
        private Dictionary<string, List<string>> data = new Dictionary<string, List<string>>();
        public GodzillaWindow()
        {
            MenuWindow f4 = new MenuWindow();
            f4.Close();
            InitializeComponent();
            data["1 ряд"] = new List<string> { "1 место", "2 место", "3 место", "4 место" };
            data["2 ряд"] = new List<string> { "5 место", "6 место", "7 место", "8 место" };
            data["3 ряд"] = new List<string> { "9 место", "10 место", "11 место", "12 место" };
            CBLine = new ComboBox { Parent = this, DropDownStyle = ComboBoxStyle.DropDownList, Top = 40, Left = 20 };
            CBPlace = new ComboBox { Parent = this, DropDownStyle = ComboBoxStyle.DropDownList, Top = 110, Left = 20 };
            CBLine.SelectedIndexChanged += new EventHandler(CBLine_SelectedIndexChanged);
            CBLine.DataSource = data.Keys.ToList();
            CBTime.Items.AddRange(new string[] { "8:00", "9:30", "10:30", "20:00" });
        }

        

        

        
        private void CBLine_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBPlace.DataSource = data[CBLine.SelectedItem.ToString()];
        }

        private void GodzillaWindow_Load(object sender, EventArgs e)
        {

        }

        private void TBPay_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
             Application.Exit();
        }

        private void CBTime_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar_DateChanged_1(object sender, DateRangeEventArgs e)
        {
            lblTime.Text = String.Format(" Дата : {0}", e.Start.ToLongDateString());
            
        }

        private void CheckBtn_Click_1(object sender, EventArgs e)
        {
            if (CBTime.Text != "Выберите время" && lblTime.Text != "")
            {
                if (TBPay.TextLength == 16)
                {
                    MessageBox.Show("Фильм: Годзилла против Конга    " + lblTime.Text + " Время: " + CBTime.Text + ".    Ряд: " + CBLine.Text + ".       Место: " + CBPlace.Text, "Билет");
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            MenuWindow f6 = new MenuWindow();
            f6.Show();
            this.Close();
        }

        private void TBPay_MouseClick(object sender, MouseEventArgs e)
        {
            TBPay.Clear();
        }

        private void TBPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void TBPhone_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TBPhone_MouseClick(object sender, MouseEventArgs e)
        {
          
        }
    }
}
