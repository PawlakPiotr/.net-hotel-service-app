using ProjektAPBD_PiotrPawlaks15182.Forms.InformationDialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektAPBD_PiotrPawlaks15182.Forms.ActionDialogs
{
    public partial class AddCategory : Form
    {
        s15182Entities db;

        public AddCategory()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;

            db = new s15182Entities();
            AddCategoryButton.Enabled = false;

            PriceTextBox.TextAlign = HorizontalAlignment.Center;
        }

        private void AddCategoryButton_Click(object sender, EventArgs e)
        {
            bool CategoryExisits = db.Kategoria.Any(k => k.Nazwa
                                                        ==  CategoryNameTextBox.Text);

            if (CategoryExisits)
            {
                var CatExists = new CategoryExists();
                CatExists.ShowDialog();
            }
            else
            {
                AddNewCategory();
            }

            this.Close();
        }

        private void CategoryName_TextChanged(object sender, EventArgs e)
        {
            ValidateInputs();
        }

        private void PriceTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateInputs();
        }

        private void AddNewCategory()
        {
            Kategoria kt = new Kategoria();

            var GetKategoriaId = db.Kategoria.Max(k => k.IdKategoria);

            kt.IdKategoria = GetKategoriaId + 1;
            kt.Nazwa = CategoryNameTextBox.Text;
            kt.Cena = Int32.Parse(PriceTextBox.Text);

            db.Kategoria.Add(kt);
            db.SaveChanges();

        }

        private void ValidateInputs()
        {
            string Name = CategoryNameTextBox.Text.Replace(" ", "");
            string Price = PriceTextBox.Text.Replace(" ", "");

            if (!Name.Equals(""))
            {
                if (!Price.Equals(""))
                {
                    var isNUmeric = Int32.TryParse(Price, out int n);

                    if (n > 0)
                    {
                        AddCategoryButton.Enabled = true;
                    }
                    else
                        AddCategoryButton.Enabled = false;
                }
                else
                {
                    AddCategoryButton.Enabled = false;
                }
            }
            else
            {
                AddCategoryButton.Enabled = false;
            }
        }

    
    }
}
