using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HypervApp
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }
        DataTable aTable=new DataTable();
        void toDataView(string txt,string title="prompt")
        {
            aTable.Columns.Clear();
            aTable.Rows.Clear();
            aTable.Clear();
            
            aTable.Columns.Add(title);
            using (StringReader sr = new StringReader(txt))
            {
                string line;
                //while ((line = sr.ReadLine()) != null)
                while (!string.IsNullOrEmpty(line = sr.ReadLine()))
                {
                    DataRow aRow=aTable.NewRow();
                    aRow[0] = line;
                    aTable.Rows.Add(aRow);
                }
            }
            dataGridView1.DataSource = aTable;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            try
            {
                txtResult.Clear();
                txtResult.Text = WraperPs.RunScript(txtScript.Text);
                toDataView(txtResult.Text);
            }
            catch (Exception error)
            {
                txtResult.Text += String.Format("\r\nError in script : {0}\r\n", error.Message);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            //string text = System.IO.File.ReadAllText(@"c:\hyperv\ps1\test.ps1");
            //toDataView(txtResult.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WraperPs.init_session();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            WraperPs.end_session();
        }

        private void btnGetVm_Click(object sender, EventArgs e)
        {
            txtResult.Text = WraperPs.RunScript("(Get-Vm).Name");
            toDataView(txtResult.Text,"Vm Name");
        }

        private void btnGetDisk_Click(object sender, EventArgs e)
        {
            string prevAction = "Vm Name";
            DataColumn dc = aTable.Columns[prevAction];
            //如果有的話,dc.ColumnName
            if (dc == null)
            {
                MessageBox.Show("未選擇虛擬機", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            string id = dataGridView1.SelectedCells[0].Value.ToString();
            string cmd = "listDisk -Name " + id;
            txtScript.Text = cmd;
            txtResult.Text = WraperPs.RunScript(cmd);
            toDataView(txtResult.Text, "Disk Name");

        }

        private void btnDiskTree_Click(object sender, EventArgs e)
        {
            DataColumn dc = aTable.Columns["Disk Name"];
            if (dc == null)
            {
                MessageBox.Show("未選擇硬碟", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string id = dataGridView1.SelectedCells[0].Value.ToString();
            string cmd = "Get-VHDChain -Path " + id;
            txtScript.Text = cmd;
            txtResult.Text = WraperPs.RunScript(cmd);
            toDataView(txtResult.Text, "Disk Tree");

        }

        private void btnMergeDisk_Click(object sender, EventArgs e)
        {
            DataColumn dc = aTable.Columns["Disk Tree"];
            if (dc == null)
            {
                MessageBox.Show("未選擇虛擬機", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string id = dataGridView1.SelectedCells[0].Value.ToString();
            string cmd = "MergeDisk -DiskPath " + id;
            txtScript.Text = cmd;
            txtResult.Text = WraperPs.RunScript(cmd);
            txtResult.Text = txtResult.Text +Environment.NewLine+ "    ==>done";
            //toDataView(txtResult.Text, "Disk Tree");
        }

        public void DoScript(string scriptText)
        {
            if (Properties.Settings.Default.isDebug)
                txtScript.Text += scriptText;
            
            try
            {
                txtResult.Text = WraperPs.RunScript(scriptText);
            }
            catch (Exception error)
            {
                txtResult.Text += String.Format("\r\nError in script : {0}\r\n", error.Message);
            }
            
        }
        private void btnLoadRoutine_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select file";
            dialog.InitialDirectory = ".\\";
            dialog.Filter = "powershell files (*.*)|*.ps1";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string cmd = ". '" + dialog.FileName+"'";
                //WraperPs.reset_session();
                DoScript(cmd);
            }
        }
        public string targetDir {
            get
            {
                if (string.IsNullOrEmpty(Properties.Settings.Default.targetDir))
                {
                    return System.Environment.GetEnvironmentVariable("USERPROFILE");
                }
                else
                    return Properties.Settings.Default.targetDir;
            }
            set
            {
                Properties.Settings.Default.targetDir = value;
            }
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            using (FrmSetting f = new FrmSetting())
            {
                f.ShowDialog();
            }
        }
    }
}
