using System;
using System.IO;
using System.Windows.Forms;

using DungeonMaster.Common;

namespace DungeonMaster.WinForms
{
    public partial class DungeonMasterMainForm : Form
    {
        public DungeonMasterMainForm()
        {
            InitializeComponent();
        }

        private void GenerateLandButton_Click(object sender, EventArgs e)
        {
            var landWithCreature = Generator.GenerateLandAndEnemy();

            var land = landWithCreature.Item1;
            var creature = landWithCreature.Item2;

            LandPlaceholderLabel.Text = land.Name;
            CreaturePlaceholderLabel.Text = creature.Name;
        }

        private void OpenAddEnemyFormButton_Click(object sender, EventArgs e)
        {
            var form = new AddEnemyForm();
            form.Show();
            form.Focus();
        }

        private void DungeonMasterMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string serializedWorld = Data.SerializeMyWorld();

            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
            Directory.CreateDirectory(path);

            path = Path.Combine(path, "myData.txt");
            File.WriteAllText(path, serializedWorld);
        }
    }
}
