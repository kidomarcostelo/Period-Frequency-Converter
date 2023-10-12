namespace Period_Frequency_Converter
{
    public partial class Form1 : Form
    {
        int convert = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            if (checkBox1.Checked == false)
            {
                convert = 0;
                return;
            }
            convert = 1;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            if (checkBox2.Checked == false)
            {
                convert = 0;
                return;
            }
            convert = 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the input value as a string from the inputText control
            string inputValue = textBox1.Text;

            // Convert the input value to a double
            if (double.TryParse(inputValue, out double input))
            {
                // Perform the conversion based on the value of isFreq
                double convertedValue;
                string unit;

                if (convert == 1)
                {
                    convertedValue = 1 / input;
                    unit = "hertz";
                }
                else if (convert == 2)
                {
                    convertedValue = 1 / input;
                    unit = "second" + (input != 1 ? "s" : ""); // Add 's' for plural if input is not 1
                }
                else
                {
                    label1.Text = $"Invalid";
                    return;
                }

                // Format the result and set it to the outputText control
                label1.Text = $"{convertedValue} {unit}";
            }
            else
            {
                label1.Text = "Invalid input";
            }
        }
    }
}