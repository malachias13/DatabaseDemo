using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace DataEXE
{
    public partial class Form1 : Form
    {
        Item item = new Item();
        List<Item> itemsList = new List<Item>();

        int currentIdex = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            itemsList = db.GetData();

            item = itemsList[0];

            WordText.Text = item.words;
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            string word = WordBox.Text;

             db.AddData(word);
        }

        private void PreBtn_Click(object sender, EventArgs e)
        {

        }

        private void NexBtn_Click(object sender, EventArgs e)
        {
            DataAccess Db = new DataAccess();
            int max;

            itemsList = Db.GetData();

            max = itemsList.Count();

            if(currentIdex <max)
            {
                item = itemsList[currentIdex];
                currentIdex++;
            }
            else if(currentIdex >= max)
            {
                currentIdex = 0;
                item = itemsList[currentIdex];
            }

            WordText.Text = item.words;
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            itemsList = db.GetData();

            db.RemoveTo(item.Id);
        }
    }
}
