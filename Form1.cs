using Newtonsoft.Json;
using System.Windows.Forms;

namespace WinFormsHomeApp3
{
    public partial class Form1 : Form
    {
        List<Student> students = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student student = new();
            if (textBox1.Text == null) MessageBox.Show("Ad daxil edilmeyib"); else student.Name = textBox1.Text ;
            if (textBox2.Text == null) MessageBox.Show("Soyad daxil edilmeyib"); else student.Surname  = textBox2.Text ;
            if (textBox3.Text == null) MessageBox.Show("Email daxil edilmeyib"); else student.Email  = textBox3.Text ;
            if (textBox4.Text == null) MessageBox.Show("Phone daxil edilmeyib"); else student.Phone  = textBox4.Text ;

            students.Insert (0, student); 

            listBox1.Items.Add(student!.Name );


        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.AppendAllText(saveFileDialog1.FileName , students[0].ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (var item in students)
            {
                if (item.Name == listBox1.SelectedItem || textBox5.Text == item.Name)
                {
                    textBox1.Text = item.Name; textBox1.Enabled = false;
                    textBox2.Text = item.Surname; textBox2.Enabled = false;
                    textBox3.Text = item.Email; textBox3.Enabled = false;
                    textBox4.Text = item.Phone; textBox4.Enabled = false;

                    textBox5.Text = item.Name;
                }

                /*
                    if(openFileDialog1.ShowDialog() == DialogResult.OK )
                    {
                        //openFileDialog1.Filter = "Text File|*.json";
                        if (openFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            var str = File.ReadAllText(openFileDialog1.FileName);
                            List<Student>? studs = JsonConvert.DeserializeObject<List<Student>>(str);
                        foreach (var item in studs!)
                        {
                            listBox1.Items .Add(item.Name!);
                            if (item.Name == textBox5.Text)
                            {

                                textBox1.Text = item.Name; textBox1.Enabled = false;
                                textBox2.Text = item.Surname; textBox2.Enabled = false;
                                textBox3.Text = item.Email; textBox3.Enabled = false;
                                textBox4.Text = item.Phone; textBox4.Enabled = false;

                            }
                        }
                    }*/
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
        }
    }
}