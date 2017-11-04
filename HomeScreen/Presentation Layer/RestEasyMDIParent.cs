using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomeScreen.Database_Layer;

namespace HomeScreen.Presentation_Layer
{
    public partial class RestEasyMDIParent : Form
    {
        private int childFormNumber = 0;
        private AdminLoginForm adminForm;
        private AdminDB adminDB;

        #region Constructors
        public RestEasyMDIParent()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            adminDB = new AdminDB();

        }
        #endregion

        #region Properties

        public AdminLoginForm AdminForm
        {
            get
            {
                return adminForm;
            }

            set
            {
                adminForm = value;
            }
        }

        #endregion

        #region Form Events (MenuStrip)
        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }
        #endregion

        #region Child Forms

        public void CreateNewAdminForm()
        {
            adminForm = new AdminLoginForm();
            adminForm.MdiParent = this;
            adminForm.StartPosition = FormStartPosition.CenterParent;
        }

        #endregion

        #region ToolStripMenu Items
        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        #endregion

        #region Coded ToolStripMenu Items

        private void displayAdminForm()
        {
            if (adminForm == null)
            {
                CreateNewAdminForm();
            }
            if (adminForm.adminLoginFormClosed)
            {
                CreateNewAdminForm();
            }
            adminForm.Show();
        }

        #endregion

        private void RestEasyMDIParent_Load(object sender, EventArgs e)
        {
        }
    }
}
