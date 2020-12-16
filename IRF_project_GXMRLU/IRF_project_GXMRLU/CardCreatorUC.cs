﻿using System;
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
        public CardCreatorUC()
        {
            InitializeComponent();


        }




        private void treeBtn_Click_1(object sender, EventArgs e)
        {
            var tree = CreateNew();
            Controls.Add(tree);
            treeBtn.Enabled = false;
        }

        public Tree CreateNew()
        {
            return new Tree();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you, Santa got your letter! Merry Christmas!");
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            Main m = new Main();
            Controls.Add(m);
        }
    }





}
