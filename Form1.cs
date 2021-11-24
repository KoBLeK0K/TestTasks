using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TestTask
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void check_butt_Click(object sender, EventArgs e)
        {
            string password = "";
            string json = File.ReadAllText(@"users.json");
            var data = (JObject)JsonConvert.DeserializeObject(json);
            if (data[name_box.Text] != null) 
            { 
                password = data[name_box.Text].Value<string>(); 
            }
            
            if(password == pass_box.Text)
            {
                MessageBox.Show("User was found");
            }
            else if (password != pass_box.Text)
            {
                MessageBox.Show("User wasn't found");
                add_butt.Enabled = true;
            }
            
        }

        private void add_butt_Click(object sender, EventArgs e)
        {
            string json = File.ReadAllText(@"users.json");
            JObject prs = JObject.Parse(json);
            prs[name_box.Text] = pass_box.Text;
            string nJson = prs.ToString();
            File.WriteAllText(@"users.json", nJson);
            MessageBox.Show("User was added");
        }

        private void name_box_TextChanged(object sender, EventArgs e)
        {
            setButtonVisibility();
        }
        private void pass_box_TextChanged(object sender, EventArgs e)
        {
            setButtonVisibility();
        }
        private void setButtonVisibility()
        {
            if((name_box.Text != String.Empty) &&(pass_box.Text != String.Empty))
            {
                check_butt.Enabled = true;
                
            }
            else
            {
                check_butt.Enabled = false;
                
            }
        }

        
    }

}
