using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trpo_task_25_11
{
    public partial class FormAdd : Form
    {
        public FormAdd()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_AddNew_Click(object sender, EventArgs e)
        {
            var entrant = new Entrant()
            {
                Name = textBox_fio.Text,
                Math = int.Parse(textBox_math.Text),
                Biology = int.Parse(textBox_biology.Text),
                Chemistry = int.Parse(textBox_chemistry.Text),
                ForeignLang = int.Parse(textBox_foreign.Text),
                Informatics = int.Parse(textBox_inf.Text),
                PE = int.Parse(textBox_pe.Text),
                Physics = int.Parse(textBox_physics.Text),
                RusLang = int.Parse(textBox_rus.Text)
            };
            using AppDBContext db = new AppDBContext();
            db.Entrants.Add(entrant);
            db.SaveChanges();
            textBox_biology.Clear();
            textBox_fio.Clear();
            textBox_chemistry.Clear();
            textBox_foreign.Clear();
            textBox_inf.Clear();
            textBox_math.Clear();
            textBox_pe.Clear();
            textBox_physics.Clear();
            textBox_rus.Clear();
        }
    }
}
