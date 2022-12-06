using Microsoft.EntityFrameworkCore.Storage;
using System.Linq;

namespace trpo_task_25_11
{
    public partial class Form1 : Form
    {
        public FormAdd formAdd;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            formAdd = new FormAdd();
            formAdd.Show();
        }
        public void InitComboBox()
        {
            using AppDBContext db = new AppDBContext();
            var entrants = db.Entrants.ToList();
            var comboBoxItems = entrants.ConvertAll(x => new ComboboxItem() { Text = x.Name, Value = x}).ToArray();
            comboBox.Items.AddRange(comboBoxItems);
            comboBox.SelectedIndex = 0;
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitComboBox();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            var item = comboBox.SelectedItem as ComboboxItem;
            var itemId = item.Value as Entrant;
            using AppDBContext db = new AppDBContext();
            var entrants = db.Entrants.ToList();
            var entrant = entrants.FirstOrDefault(x => x.Id == itemId.Id);
            double avgNote = (entrant.PE + entrant.Informatics + entrant.RusLang + entrant.ForeignLang +
                entrant.Biology + entrant.Chemistry + entrant.Math + entrant.Physics) / 8.0;
            if (avgNote < 4.2)
                MessageBox.Show($"Средняя оценка: {avgNote}\nАбитуриент на контракте");
            else
            MessageBox.Show($"Средняя оценка: {avgNote}\nАбитуриент на бюджете");
            var history = new History
            {
                AvgNote = avgNote,
                EntrantId = entrant.Id,
                Entrant = entrant
            };
            var historiesId = db.Histories.FirstOrDefault(x => x.EntrantId == entrant.Id);
            if (historiesId != null)
                db.Histories.Add(history);
            else db.Histories.Update(history);
            db.SaveChanges();
        }
    }
}