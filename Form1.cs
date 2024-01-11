namespace _28.ComboBox_add_and_remove
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var items = comboBox1.Items;
            var selectedItem = comboBox1.SelectedItem;
           //remove item in combo
            if (rdRemove.Checked)
            {
                items.Remove(selectedItem);
                comboBox1.Text = "";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //adding item into combobox
            var items = comboBox1.Items;
            string item = txtItem.Text;
            items.Add(item);
            txtItem.Text = "";
            MessageBox.Show($"{item} is added to the combobox");
        }

       
    }
}