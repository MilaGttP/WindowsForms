
namespace WindowsForms
{
    public partial class MainForm : Form
    {
        List <Worker> workers = null;
        List<Worker> matchingWorkers = null;
        List<Student> students = null;
        List<Student> matchingStudents = null;
        public MainForm() => InitializeComponent();
        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 0)
            {
                workers = new List<Worker>();
                workers.Add(new Worker("Petrov", "Ivan", "Sergiyovich", new DateOnly(1998, 2, 3), "Kyiv"));
                workers.Add(new Worker("Sergienko", "Volodymyr", "Abramovich", new DateOnly(1987, 5, 7), "Vinnytsia"));
                workers.Add(new Worker("Zybenko", "Myhaiv", "Petrovich", new DateOnly(1990, 7, 23), "Kyiv"));
                WorkersLB.DataSource = workers;
                
            }
            else if (tabControl.SelectedIndex == 1)
            {
                students = new List<Student>();
                students.Add(new Student("DF121", "Petrov Ivan Sergiyovich", new DateOnly(1998, 2, 3), "1.76", "65"));
                students.Add(new Student("VD142", "Sergienko Volodymyr Abramovich", new DateOnly(1987, 5, 7), "1.68", "70"));
                students.Add(new Student("DF121", "Zybenko Myhaiv Petrovich", new DateOnly(1990, 7, 23), "1.90", "76"));
                StudentsLB.DataSource = students;
                LogicForStudents();
            }
        }
        private void CityTB_TextChanged(object sender, EventArgs e)
        {
            List <Worker> matchingWorkers = new List <Worker> ();
            foreach (var item in workers)
            {
                if (CityTB.Text == item.City)
                {
                    matchingWorkers.Add(item);
                    WorkersQuantityTB.Text = matchingWorkers.Count.ToString();
                    WorkersQuantityLabel.Visible = true;
                    WorkersQuantityTB.Visible = true;
                    ResultWorkersLB.Visible = true;
                }
            }
            ResultWorkersLB.DataSource = matchingWorkers;
        }
        private void LogicForStudents()
        {
            List<Student> matchingStudents = new List<Student>();
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i - 1].Group == students[i].Group) matchingStudents.Add(students[i]);
            }
            ResultStudentsLB.DataSource = matchingStudents;
        }
    }
}
