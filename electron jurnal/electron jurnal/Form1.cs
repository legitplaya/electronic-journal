using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static electron_jurnal.logpass;

namespace electron_jurnal
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        internal class logpass
        {
            string AdminPass { get; set; } = "admin";
            string AdminLog { get; set; } = "admin";

            string TeacherPass = "teacher";
            string TeacherLog = "teacher";

            string StudentPass = "student";
            string StudentLog = "student";


        }

        public Form1()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue700, MaterialSkin.Primary.Blue700, MaterialSkin.Primary.Blue100, MaterialSkin.Accent.Blue100, MaterialSkin.TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Convert.ToString(materialSingleLineTextField1);
            Convert.ToString(materialSingleLineTextField2);
            if (materialSingleLineTextField2.Text == AdminPass && materialSingleLineTextField1.Text == AdminLog)
            {
                this.Hide();
                Form2 f = new Form2();
                f.Show();
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль");
            }
            
            
        }

       

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {
            materialSingleLineTextField1.Clear();
        }

        private void materialSingleLineTextField2_Click(object sender, EventArgs e)
        {
            materialSingleLineTextField2.Clear();
        }
    }
}
