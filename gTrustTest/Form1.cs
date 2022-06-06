using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
namespace gTrustTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Customer> customers = new List<Customer>();
        //var jsonConvert = JsonConvert.SerializeObject(customers);
        private void LoadBtn_Click(object sender, EventArgs e)
        {
            string NameText = FileText.Text + ".txt";
            //var jsonConvert = JsonConvert.SerializeObject(customers);
            if (!File.Exists(NameText))
            {
                throw new Exception("Not have file");
            }
            else
            {
                StreamReader FileReader = new StreamReader(NameText);
                ShowBox.Text = FileReader.ReadToEnd();
                //Customer customer = new Customer();
                //customer.name = FileText.Text;
                //customer.FeedBack = ShowBox.Text;
                //customers.Add(customer);
                FileReader.Close();

            }

        }
        string FileJsonName = "customers.json";
        private void Form1_Load(object sender, EventArgs e)
        {
            var jsonConvert = JsonConvert.SerializeObject(customers);
            if (!File.Exists(FileJsonName))
            {
                var writeJson = new StreamWriter(FileJsonName);
                writeJson.Write(jsonConvert);
                writeJson.Close();
            }
            else
            {
                File.WriteAllText(FileJsonName,jsonConvert);
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string NameText = FileText.Text + ".txt";
            if (!File.Exists(NameText))
            {
                StreamWriter newFile = new StreamWriter(NameText);
                newFile.WriteLine(ShowBox.Text);
                Customer customer = new Customer();
                customer.name = FileText.Text;
                customer.FeedBack=ShowBox.Text;
                customers.Add(customer);
                var jsonConvert = JsonConvert.SerializeObject(customers);
                File.WriteAllText(FileJsonName, jsonConvert);
                newFile.Close();
            }
            else
            {
                throw new Exception("This file already exist");
            }
        }
    }
}
