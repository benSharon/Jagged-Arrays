using System.IO;
using System.Windows.Forms;

namespace JaggedArrays
{
    public partial class FrmMain : Form
    {
        private string[][] memberClubs;
        public FrmMain()
        {
            InitializeComponent();

            // Read data file and Initialize jagged array
            InitializeMembers();

            // TODO: Display members in lstMembers control
            for (int i = 0; i < memberClubs.Length; i++)
                lstMembers.Items.Add(memberClubs[i][0]);
        }

        private void lstMembers_Click(object sender, System.EventArgs e)
        {
            // TODO: Retrieve index of selected item
            int itemIndex = lstMembers.SelectedIndex;

            // TODO: Clear lstClubs items
            lstClubs.Items.Clear();

            // TODO: Retrieve row from memberClubs
            var clubs = memberClubs[itemIndex];

            // TODO: Display clubs in lstClubs control
            for (int i = 1; i < clubs.Length; i++)
                lstClubs.Items.Add(clubs[i]);
        }

        #region DO NOT EDIT
        private void InitializeMembers()
        {
            string[] lines = File.ReadAllLines("../../data.txt");
            memberClubs = new string[lines.Length][];
            for (int i = 0; i < lines.Length; i++)
                memberClubs[i] = lines[i].Split(',');
        }
        #endregion
    }
}
