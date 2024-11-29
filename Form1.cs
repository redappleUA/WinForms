using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        List<Person> employeesInGrid = new List<Person>();

        public Form1()
        {
            InitializeComponent();
            InitEmployees();
            InitGrid();
        }

        //add some default values to grid
        private void InitEmployees()
        {
            employeesInGrid.Add(new Person("employee1", DateTime.Parse("08:00:00")));
            employeesInGrid.Add(new Person("employee2", DateTime.Parse("07:59:59")));
        }

        //fill grid with values
        private void InitGrid()
        {
            Employees.Rows.Clear();

            foreach (var employee in employeesInGrid)
                Employees.Rows.Add(employee.Name, employee.Time);
        }

        private void openFromxmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employees.Rows.Clear();
            string FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                FileName = openFileDialog1.FileName;
            else
                return;

            XmlSerializer deserializer = new XmlSerializer(typeof(List<Person>));
            TextReader textReader = new StreamReader(FileName);
            employeesInGrid = (deserializer.Deserialize(textReader) as List<Person>) ?? new List<Person>();
            textReader.Close();

            foreach (var employee in employeesInGrid)
                Employees.Rows.Add(employee.Name, employee.Time);
        }

        private void saveAsxmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileName = "";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                fileName = saveFileDialog1.FileName;
            else
                return;

            fileName += ".xml";

            XmlSerializer serializer = new XmlSerializer(typeof(List<Person>));
            var textWriter = new StreamWriter(fileName);
            var xmlWriter = XmlWriter.Create(textWriter, new XmlWriterSettings { Indent = true });
            serializer.Serialize(xmlWriter, employeesInGrid);
            textWriter.Close();
            MessageBox.Show($"Data saved in {fileName}", "Saved");
        }

        private void CountButton_Click(object sender, EventArgs e)
        {
            Employees.Rows.Clear();

            foreach (var employee in employeesInGrid)
            {
                if (!employee.IsLate())
                    Employees.Rows.Add(employee.Name, employee.Time, 100, 0);
                else
                    Employees.Rows.Add(employee.Name, employee.Time, 0, 200);
            }
        }

        private void generateReportAboutBonusesAndFinesForEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var employeesWithBonuses = new List<Person>();
            var employeesWithFines = new List<Person>();
            foreach (var employee in employeesInGrid)
            {
                if (employee.IsLate())
                    employeesWithBonuses.Add(employee);
                else
                    employeesWithFines.Add(employee);
            }

            string fileName = "";
            if (saveFileDialog2.ShowDialog() == DialogResult.OK)
                fileName = saveFileDialog2.FileName;
            else
                return;
            fileName += ".txt";
            var file = new FileInfo(fileName);
            File.WriteAllText(file.Name, null);
            using FileStream stream = new(file.Name, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            using StreamWriter writer = new(stream, Encoding.UTF8);

            writer.WriteLine("Employees who arrived on time:");
            foreach (var employee in employeesWithBonuses)
                writer.WriteLine($"\t{employee.Name}  arrived at {employee.Time.ToShortTimeString()}, got bonus: 100.00");
            writer.WriteLine("--------------------------------------------------------------------------------");
            writer.WriteLine("Employees who were late:");
            foreach (var employee in employeesWithFines)
                writer.WriteLine($"\t{employee.Name}  arrived at {employee.Time.ToShortTimeString()}, got fine: 200.00");
            writer.WriteLine("--------------------------------------------------------------------------------");

            writer.Close();
            stream.Close();
        }
    
        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("беру дубки");
        }
    }
}