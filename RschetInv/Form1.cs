using System.Diagnostics.Eventing.Reader;

namespace RschetInv
{
    public partial class Form1 : Form
    {
        private decimal summinv1;
        private decimal summinv;
        private decimal summnot;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }




        private void button1_Click_1(object sender, EventArgs e)
        {
            if (brandCombo.Text == "Остин")
            {
                double a = 0.2;
                summinv1 = (decimal)(int.Parse(ostTxt.Text) * (2 + a) / (500 * int.Parse(timeTxt.Text)));

                summinv = (decimal)(int.Parse(ostTxt.Text) * (2 + a) / (500 * int.Parse(timeTxt.Text)));
                summinv = Math.Round(decimal.Ceiling(summinv), 0);
                summinv1 = Math.Round(summinv1, 1);
                summa.Text = summinv.ToString();
                label5.Text = summinv1.ToString();
                summnot = (decimal)int.Parse(ostTxt.Text) / 5000;
                summnot = Math.Round(decimal.Ceiling(summnot), 1);
                label7.Text = summnot.ToString();
            }
            if (brandCombo.Text == "Дэмикс")
            {


                double a = 0.33;
                summinv1 = (decimal)(int.Parse(ostTxt.Text) * (2 + a) / (500 * int.Parse(timeTxt.Text)));

                summinv = (decimal)(int.Parse(ostTxt.Text) * (2 + a) / (500 * int.Parse(timeTxt.Text)));
                summinv = Math.Round(decimal.Ceiling(summinv), 0);
                summinv1 = Math.Round(summinv1, 1);
                summa.Text = summinv.ToString();
                label5.Text = summinv1.ToString();
                summnot = ((decimal)int.Parse(ostTxt.Text) / 5000);
                summnot = Math.Round(decimal.Ceiling(summnot), 1);
                label7.Text = summnot.ToString();

            }

            if (brandCombo.Text == "Спортмастер")
            {

                double a = 0.1;
                summinv1 = (decimal)(int.Parse(ostTxt.Text) * (2 + a) / (400 * int.Parse(timeTxt.Text)));

                summinv = (decimal)(int.Parse(ostTxt.Text) * (2 + a) / (400 * int.Parse(timeTxt.Text)));
                summinv = Math.Round(decimal.Ceiling(summinv), 0);

                summinv1 = Math.Round(summinv1, 1);
                summa.Text = summinv.ToString();
                label5.Text = summinv1.ToString();
                summnot = (decimal)int.Parse(ostTxt.Text) / 5000;
                summnot = Math.Round(decimal.Ceiling(summnot), 1);
                label7.Text = summnot.ToString();

            }



            if (brandCombo.Text == "Фандей")
            {

                double a = 0.15;
                summinv1 = (decimal)(int.Parse(ostTxt.Text) * (2 + a) / (450 * int.Parse(timeTxt.Text)));

                summinv = (decimal)(int.Parse(ostTxt.Text) * (2 + a) / (450 * int.Parse(timeTxt.Text)));
                summinv = Math.Round(decimal.Ceiling(summinv), 0);

                summinv1 = Math.Round(summinv1, 1);
                summa.Text = summinv.ToString();
                label5.Text = summinv1.ToString();
                summnot = ((decimal)int.Parse(ostTxt.Text) / 5000);
                summnot = Math.Round(decimal.Ceiling(summnot), 1);
                label7.Text = summnot.ToString();


            }
            if (brandCombo.Text == "Урбан вайб")
            {


                double a = 0.33;
                summinv1 = (decimal)(int.Parse(ostTxt.Text) * (2 + a) / (500 * int.Parse(timeTxt.Text)));

                summinv = (decimal)(int.Parse(ostTxt.Text) * (2 + a) / (500 * int.Parse(timeTxt.Text)));
                summinv = Math.Round(decimal.Ceiling(summinv), 0);
                summinv1 = Math.Round(summinv1, 1);
                summa.Text = summinv.ToString();
                label5.Text = summinv1.ToString();
                summnot = ((decimal)int.Parse(ostTxt.Text) / 5000);
                summnot = Math.Round(decimal.Ceiling(summnot), 1);
                label7.Text = summnot.ToString();
            }
            if (brandCombo.Text == "Другое")
            {
                double a = 0.1;
                double b = 0.15;
                double c = 0.2;
                double d = 0.33;
                if (pogrBox.Text == "0.1")
                {
                    summinv1 = (decimal)(int.Parse(ostTxt.Text) * (2 + a) / (int.Parse(edchTxt.Text) * int.Parse(timeTxt.Text)));

                    summinv = (decimal)(int.Parse(ostTxt.Text) * (2 + a) / (int.Parse(edchTxt.Text) * int.Parse(timeTxt.Text)));
                    summinv = Math.Round(decimal.Ceiling(summinv), 0);
                    summinv1 = Math.Round(summinv1, 1);
                    summa.Text = summinv.ToString();
                    label5.Text = summinv1.ToString();
                    summnot = ((decimal)int.Parse(ostTxt.Text) / 5000);
                    summnot = Math.Round(decimal.Ceiling(summnot), 1);
                    label7.Text = summnot.ToString();
                }
                if (pogrBox.Text == "0.15")
                {
                    summinv1 = (decimal)(int.Parse(ostTxt.Text) * (2 + b) / (int.Parse(edchTxt.Text) * int.Parse(timeTxt.Text)));

                    summinv = (decimal)(int.Parse(ostTxt.Text) * (2 + b) / (int.Parse(edchTxt.Text) * int.Parse(timeTxt.Text)));
                    summinv = Math.Round(decimal.Ceiling(summinv), 0);
                    summinv1 = Math.Round(summinv1, 1);
                    summa.Text = summinv.ToString();
                    label5.Text = summinv1.ToString();
                    summnot = ((decimal)int.Parse(ostTxt.Text) / 5000);
                    summnot = Math.Round(decimal.Ceiling(summnot), 1);
                    label7.Text = summnot.ToString();
                }
                if (pogrBox.Text == "0.2")
                {
                    summinv1 = (decimal)(int.Parse(ostTxt.Text) * (2 + c) / (int.Parse(edchTxt.Text) * int.Parse(timeTxt.Text)));

                    summinv = (decimal)(int.Parse(ostTxt.Text) * (2 + c) / (int.Parse(edchTxt.Text) * int.Parse(timeTxt.Text)));
                    summinv = Math.Round(decimal.Ceiling(summinv), 0);
                    summinv1 = Math.Round(summinv1, 1);
                    summa.Text = summinv.ToString();
                    label5.Text = summinv1.ToString();
                    summnot = ((decimal)int.Parse(ostTxt.Text) / 5000);
                    summnot = Math.Round(decimal.Ceiling(summnot), 1);
                    label7.Text = summnot.ToString();
                }
                if (pogrBox.Text == "0.33")
                {
                    summinv1 = (decimal)(int.Parse(ostTxt.Text) * (2 + d) / (int.Parse(edchTxt.Text) * int.Parse(timeTxt.Text)));

                    summinv = (decimal)(int.Parse(ostTxt.Text) * (2 + d) / (int.Parse(edchTxt.Text) * int.Parse(timeTxt.Text)));
                    summinv = Math.Round(decimal.Ceiling(summinv), 0);
                    summinv1 = Math.Round(summinv1, 1);
                    summa.Text = summinv.ToString();
                    label5.Text = summinv1.ToString();
                    summnot = ((decimal)int.Parse(ostTxt.Text) / 5000);
                    summnot = Math.Round(decimal.Ceiling(summnot), 1);
                    label7.Text = summnot.ToString();
                }
                else if (pogrBox.Text == "")
                {
                    MessageBox.Show("Введите погрешность");
                }
            }



            if (ostTxt.Text == "")
            {

                MessageBox.Show("Введите остатки!");


            }
            else if (timeTxt.Text == "")
            {

                MessageBox.Show("Введите время!");

            }
            else if (brandCombo.Text == "")
            {
                MessageBox.Show("Выберите бизнес!");
            }








        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void ostTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ostTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void timeTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void brandCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (brandCombo.Text == "Другое")
            {
                edchTxt.Visible = true;
                label3.Visible = true;
                pogrBox.Visible = true;
                radioButton1.Visible = true;

            }
        }

        private void edchTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void edchTxt_KeyPress(object sender, KeyPressEventArgs e)
        {

            char number = e.KeyChar;

            if (!Char.IsDigit(number) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void pogrBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
