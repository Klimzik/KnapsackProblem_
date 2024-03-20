using KnapsackProblem;
using Microsoft.VisualBasic.ApplicationServices;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int seedValue, capacityValue, numberOfItemsValue;
            if (string.IsNullOrWhiteSpace(seed.Text) || !int.TryParse(seed.Text, out seedValue) || string.IsNullOrWhiteSpace(capacity.Text) || !int.TryParse(capacity.Text, out capacityValue) || string.IsNullOrWhiteSpace(capacity.Text) || !int.TryParse(numberOfItems.Text, out numberOfItemsValue))
            {
                return;
            }

            int numberOfItems_ = int.Parse(numberOfItems.Text);
            int seed_ = int.Parse(seed.Text);
            int capacity_ = int.Parse(capacity.Text);

            Problem problem = new Problem(numberOfItems_, capacity_, seed_);
            result_text.Text = problem.Solve().ToString();
        }

        private void numberOfItems_TextChanged(object sender, EventArgs e)
        {

        }

        private void numberOfItems_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int numberOfItemsValue;
            if (string.IsNullOrWhiteSpace(numberOfItems.Text) || !int.TryParse(numberOfItems.Text, out numberOfItemsValue))
            {
                e.Cancel = true;
                numberOfItems.Focus();
                errorProvider.SetError(numberOfItems, "Bad Data");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(numberOfItems, "");
            }
        }

        private void capacity_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int capacityValue;
            if (string.IsNullOrWhiteSpace(capacity.Text) || !int.TryParse(capacity.Text, out capacityValue))
            {
                e.Cancel = true;
                capacity.Focus();
                errorProvider.SetError(capacity, "Bad Data");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(capacity, "");
            }
        }

        private void seed_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int seedValue;
            if (string.IsNullOrWhiteSpace(seed.Text) || !int.TryParse(seed.Text, out seedValue))
            {
                e.Cancel = true;
                seed.Focus();
                errorProvider.SetError(seed, "Bad Data");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(seed, "");
            }
        }
    }
}



/*if (int.TryParse(numberOfItems.Text, out numberOfItemsValue))
          {
          }
          else
          {
          }*/