using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai13
{
    public partial class frmBai13 : Form
    {
        public frmBai13()
        {
            InitializeComponent();
        }




        private void tvKTH_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Parent != null)
            {
                lvwInfo.Items.Clear();

                if (tvKTH.SelectedNode.Nodes.Count != 0)
                {
                    int index = tvKTH.SelectedNode.Index;

                    for (int i = 0; i < tvKTH.SelectedNode.Nodes.Count; i++)
                    {
                        ListViewItem listView = new ListViewItem(tvKTH.Nodes[0].Nodes[index].Nodes[i].Text);
                        listView.SubItems.Add(tvKTH.Nodes[0].Nodes[index].Nodes[i].Parent.Name);
                        lvwInfo.Items.Add(listView);
                    }
                }
                else
                {
                    ListViewItem listView = new ListViewItem(tvKTH.SelectedNode.Text);
                    listView.SubItems.Add(e.Node.Parent.Name);
                    lvwInfo.Items.Add(listView);
                }
            }
            else
            {
                foreach (TreeNode tn in tvKTH.Nodes)
                {
                    for (int iParent = 0; iParent < tn.Nodes.Count; iParent++)
                    {
                        for (int iChild = 0; iChild < tn.Nodes[iParent].Nodes.Count; iChild++)
                        {
                            ListViewItem listView = new ListViewItem(tn.Nodes[iParent].Nodes[iChild].Text);
                            listView.SubItems.Add(tn.Nodes[iParent].Nodes[iChild].Parent.Name);
                            lvwInfo.Items.Add(listView);
                        }
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lvwInfo.Items.Clear();
            foreach (TreeNode tn in tvKTH.Nodes)
            {
                for (int iParent = 0; iParent < tn.Nodes.Count; iParent++)
                {
                    for (int iChild = 0; iChild < tn.Nodes[iParent].Nodes.Count; iChild++)
                    {
                        if (tn.Nodes[iParent].Nodes[iChild].Text == txtInputName.Text)
                        {
                            ListViewItem listView = new ListViewItem(tn.Nodes[iParent].Nodes[iChild].Text);
                            listView.SubItems.Add(tn.Nodes[iParent].Nodes[iChild].Parent.Name);
                            lvwInfo.Items.Add(listView);
                        }
                    }
                }
            }
        }
    }
}
