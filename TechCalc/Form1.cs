using System.Diagnostics.Eventing.Reader;

namespace TechCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void sumbutton_Click(object sender, EventArgs e)
        {
            string num1 = primernumtxt.Text;
            string num2 = segundonumtxt.Text;
            int num1_int = 0;
            int num2_int = 0;

            if (num1.Length > 0 && num2.Length > 0)
            {
                try
                {
                    num1_int = Convert.ToInt32(num1);
                    num2_int = Convert.ToInt32(num2);
                    int resultado = num1_int + num2_int;
                    resultadolbl.Text = resultado.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Formato inválido, por favor intente nuevamente.");
                    primernumtxt.Text = "";
                    segundonumtxt.Text = "";
                }
            }
            else
            {
                MessageBox.Show("No puede haber cuadros en blanco.");
            }
        }

        private void resbutton_Click(object sender, EventArgs e)
        {
            string num1 = primernumtxt.Text;
            string num2 = segundonumtxt.Text;
            int num1_int = 0;
            int num2_int = 0;

            if (num1.Length > 0 && num2.Length > 0)
            {
                try
                {
                    num1_int = Convert.ToInt32(num1);
                    num2_int = Convert.ToInt32(num2);
                    int resultado = num1_int - num2_int;
                    resultadolbl.Text = resultado.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Formato inválido, por favor intente nuevamente.");
                    primernumtxt.Text = "";
                    segundonumtxt.Text = "";
                }
            }
            else
            {
                MessageBox.Show("No puede haber cuadros en blanco.");
            }

        }

        private void divbutton_Click(object sender, EventArgs e)
        {
            string num1 = primernumtxt.Text;
            string num2 = segundonumtxt.Text;
            double num1_double = 0;
            int num1_int = 0;
            int num2_int = 0;

            if(num2 != "0") {
                if (num1.Length > 0 && num2.Length > 0)
                {
                    try
                    {
                        num1_int = Convert.ToInt32(num1);
                        num1_double = Convert.ToDouble(num1_int);
                        num2_int = Convert.ToInt32(num2);
                        double resultado = num1_double / num2_int;
                        resultadolbl.Text = resultado.ToString("0.###");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Formato inválido, por favor intente nuevamente.");
                        primernumtxt.Text = "";
                        segundonumtxt.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("No puede haber cuadros en blanco.");
                }
            } else {
                MessageBox.Show("Error: No se puede dividir por 0. Intente nuevamente.");

            }
        
        }


        private void mulbutton_Click(object sender, EventArgs e)
        {
                string num1 = primernumtxt.Text;
                string num2 = segundonumtxt.Text;
                int num1_int = 0;
                int num2_int = 0;

                if (num1.Length > 0 && num2.Length > 0)
                {
                    try
                    {
                        num1_int = Convert.ToInt32(num1);
                        num2_int = Convert.ToInt32(num2);
                        int resultado = num1_int * num2_int;
                        resultadolbl.Text = resultado.ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Formato inválido, por favor intente nuevamente.");
                        primernumtxt.Text = "";
                        segundonumtxt.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("No puede haber cuadros en blanco.");
                }

            }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void primernumtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void segundonumtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }




    }

}

