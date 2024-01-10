namespace ADO.NET_CRUD_Ellis
{
    public partial class Form1 : Form
    {
        List<Person> people = new List<Person>();
        public Form1()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            people = db.getPerson(personIDText.Text);

            if (people == null || people.Count == 0)
            {
                MessageBox.Show("Invalid Input"); // Sorry Dan ;)
            }

            peopleFoundListBox.DataSource = people;
            peopleFoundListBox.DisplayMember = "FullInfo";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            people = db.getAllPeople();

            foreach(Person person in people)
            {
                peopleFoundListBox.Text = person.FirstName + " " + person.MiddleName + " " + person.LastName;
            }

            peopleFoundListBox.DataSource = people;
            peopleFoundListBox.DisplayMember = "Name";
        }
    }
}