using DungeonMaster.Common;
using DungeonMaster.Common.DomainModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DungeonMaster.WinForms
{
    public partial class AddEnemyForm : Form
    {
        public AddEnemyForm()
        {
            InitializeComponent();

            foreach(Land land in Data.World.Lands)
            {
                LandsCheckedListBox.Items.Add(land);
            }
        }

        private void AddAndCloseButton_Click(object sender, EventArgs e)
        {
            string enemyName = EnemyNameTextBox.Text;

            List<Land> lands = new List<Land>();
            foreach (Object item in LandsCheckedListBox.CheckedItems)
            {
                Land land = (Land)item;
                lands.Add(land);
            }

            Data.AddEnemyWithLands(enemyName, lands);

            this.Close();
        }
    }
}
