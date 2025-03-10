namespace Home_page
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            student Student = new student();
            Student.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            student Student = new student();
            Student.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
