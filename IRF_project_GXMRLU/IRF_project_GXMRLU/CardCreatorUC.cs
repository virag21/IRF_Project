using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using IRF_project_GXMRLU.Entities;

namespace IRF_project_GXMRLU
{
    public partial class CardCreatorUC : UserControl
    {
        GiftBox gift;
        Tree tree;
        public CardCreatorUC()
        {
            InitializeComponent();
  }




        public void treeBtn_Click_1(object sender, EventArgs e)
        {
            this.tree = CreateNewTree();
            Controls.Add(tree);
            treeBtn.Enabled = false;
        }

        public Tree CreateNewTree()
        {
            return new Tree();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you, Santa got your letter! Merry Christmas!");
            textBox1.Text = "Dear Santa!";
        }

        
        private void backBtn_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            Main m = new Main();
            Controls.Add(m);
        }

        public void button1_Click(object sender, EventArgs e)
        {
            this.gift = CreateNewGift();
            Controls.Add(gift);
            button1.Enabled = false;
        }

        public GiftBox CreateNewGift()
        {
            return new GiftBox();
        }      

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            treeBtn.Enabled = true;
            Controls.Remove (tree);
            Controls.Remove(gift);
        }
    }
    }
