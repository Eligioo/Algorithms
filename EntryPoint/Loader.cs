﻿using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace EntryPoint
{
    public partial class Loader : Form
    {
        public Loader()
        {
            InitializeComponent();
        }

        private void eExit(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void btnInsertionSort_Click(object sender, EventArgs e)
        {
            InsertionSort.Run InsertionSort = new InsertionSort.Run();
            Process.Start(InsertionSort.returnPath() + @"\InsertionSort.exe");
        }

        private void btnMergeSort_Click(object sender, EventArgs e)
        {
            MergeSort.Run MergeSort = new MergeSort.Run();
            Process.Start(MergeSort.returnPath() + @"\MergeSort.exe");
        }
    }
}
