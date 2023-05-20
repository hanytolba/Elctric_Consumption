namespace Elctric_Consumption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double consumption;
            string phase = "";
            double rate = 0;
            double bill = 0;


            if (double.TryParse(textBox1.Text, out rate))


            {
                consumption = Convert.ToDouble(textBox1.Text);
                if (consumption > 1000)
                {
                    label2.Visible = true;
                    //consumption = 1000;
                    label1.Text = " ? ";
                }
                else
                {
                    label2.Visible = false;
                }


                if (consumption <= 50)
                {
                    phase = "الاولى";
                    rate = 0.48;
                    bill = (consumption * rate) + 1;
                }
                else if (consumption > 50 && consumption <= 100)
                {
                    phase = "الثانية";
                    rate = 0.58;
                    bill = (50 * 0.48) + ((consumption - 50) * rate) + 2;
                }
                else if (consumption > 100 && consumption <= 200)
                {
                    phase = "الثالثة";
                    rate = 0.77;
                    bill = consumption * rate + 6;
                }
                else if (consumption > 200 && consumption <= 350)
                {
                    phase = "الرابعة";
                    rate = 1.06;
                    bill = (200 * 0.77) + ((consumption - 200) * rate) + 11;
                }
                else if (consumption > 351 && consumption <= 650)
                {
                    phase = "الخامسة";//end
                    rate = 1.28;
                    bill = (200 * 0.77) + (150 * 1.06) + +((consumption - 350) * rate) + 15;
                }
                else if (consumption > 651 && consumption <= 1000)
                {
                    phase = "السادسة";
                    rate = 1.28;
                    bill = ((consumption) * rate) + 25;
                }
                else if (consumption > 1000)
                {
                    phase = "السابعة";
                    rate = 1.45;
                    bill = (consumption) * rate + 40;
                }
                bill = Math.Round(bill, 1);
                label1.Text = " انت فى الشريحة" + phase + "  الاستهلاك  =  " + bill.ToString() + "  جنية مصرى  ";
            }
            else
            {
                label1.Text = "خطأ ادخل ارقام ";
            }

        }


    }

}