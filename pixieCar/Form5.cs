using System.ComponentModel;


namespace pixieCar
{
    public partial class Form5 : Form
    {


        public Form5()
        {
            InitializeComponent();
            SetupDataGridView();

            
            LoadGameHistory();

        }

        private void SetupDataGridView()
        {
            
            dataGridView1.Columns.Clear();

            
            dataGridView1.Columns.Add("Score", "Score");
            dataGridView1.Columns.Add("Date", "Date");

            
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToAddRows = false; 
            dataGridView1.ReadOnly = true; 
        }

        private void LoadGameHistory()
        {
            
            foreach (var record in Form2.gameHistory)
            {
                dataGridView1.Rows.Add(record.score, record.date);
            }

            dataGridView1.Sort(dataGridView1.Columns["Score"], ListSortDirection.Descending);
        }

        private void btnScoreBoardClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
