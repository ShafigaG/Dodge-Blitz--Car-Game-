using System.Data;


namespace pixieCar
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            var frm2 = new Form2()
            {
                ShowInTaskbar = false,

                FormBorderStyle = FormBorderStyle.None,
            };
            frm2.StartPosition = FormStartPosition.CenterParent;
            frm2.ShowDialog(this);

            
        }

       

        private void button2_Click(object sender, EventArgs e)
        {   this.Close();

            var frm1 = new Form1()
            {
                ShowInTaskbar = false,

                FormBorderStyle = FormBorderStyle.None,
            };
            frm1.StartPosition = FormStartPosition.CenterParent;
            frm1.ShowDialog(this);
            
            


            foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
            {
                if (form.Name != "Form1") form.Close();
            }
        }

    }
}
