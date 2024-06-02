using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W5_Livanty_ED
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable dtProdukSimpan = new DataTable();
        DataTable dtProdukTampil = new DataTable();
        DataTable dtCategory = new DataTable();

        
        private void btn_filter_Click(object sender, EventArgs e)
        {
            cmb_filter.Enabled = true;
        }

        int c = 0;
        int angka = 6;
        string data = "";
        List<string> C = new List<string>();
        List<string> category = new List<string>();

        public void refresh()
        {
            cmb_category.Items.Clear();
            
            foreach (var a in category)
            {               
                cmb_category.Items.Add(a);
            }
        }

        public void refreshfilter()
        {
            cmb_filter.Items.Clear();

            foreach (var a in category)
            {
                cmb_filter.Items.Add(a);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dtProdukSimpan.Columns.Add("ID Product");
            dtProdukSimpan.Columns.Add("Nama Product");
            dtProdukSimpan.Columns.Add("Harga");
            dtProdukSimpan.Columns.Add("Stock");
            dtProdukSimpan.Columns.Add("ID Category");
            dgv_product.DataSource = dtProdukSimpan;

            dtProdukTampil.Columns.Add("ID Product");
            dtProdukTampil.Columns.Add("Nama Product");
            dtProdukTampil.Columns.Add("Harga");
            dtProdukTampil.Columns.Add("Stock");
            dtProdukTampil.Columns.Add("ID Category");


            dtCategory.Columns.Add("ID Category");
            dtCategory.Columns.Add("Nama Category");
            dgv_category.DataSource = dtCategory;



            dtProdukSimpan.Rows.Add("J001", "Jas Hitam", "100000", "10", "C1");
            dtProdukSimpan.Rows.Add("T001", "T-Shirt Black Pink", "70000", "20", "C2");
            dtProdukSimpan.Rows.Add("T002", "T-Shirt Obsessive", "75000", "16", "C2");
            dtProdukSimpan.Rows.Add("R001", "Rok Mini", "82000", "26", "C3");
            dtProdukSimpan.Rows.Add("J002", "Jeans Biru", "90000", "5", "C4");
            dtProdukSimpan.Rows.Add("C001", "Celana Pendek Coklat", "60000", "11", "C4");
            dtProdukSimpan.Rows.Add("C002", "Cawat Blink-blink", "1000000", "1", "C5");
            dtProdukSimpan.Rows.Add("R002", "Rocca Shirt", "50000", "8", "C2");

            dtCategory.Rows.Add("C1", "Jas");
            dtCategory.Rows.Add("C2", "T-Shirt");
            dtCategory.Rows.Add("C3", "Rok");
            dtCategory.Rows.Add("C4", "Celana");
            dtCategory.Rows.Add("C5", "Cawat");

            category.Add("Jas");
            category.Add("T-Shirt");
            category.Add("Rok");
            category.Add("Celana");
            category.Add("Cawat");

            C.Add("C1");
            C.Add("C2");
            C.Add("C3");
            C.Add("C4");
            C.Add("C5");
            refresh();
            refreshfilter();

            dgv_product.ClearSelection();
            dgv_category.ClearSelection();
            
        }
        
        
        private void btn_addcategory_Click(object sender, EventArgs e)
        {
            bool cek = false;
            if (txt_namacategory.Text == "")
            {
                MessageBox.Show(" Pastikan nama category terisi ", "Hasil", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
            else
            {
                foreach (var i in category)
                {
                    if (txt_namacategory.Text.ToUpper() == i.ToUpper())
                    {
                        MessageBox.Show("Nama tidak boleh sama ", "Hasil", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cek = false;
                        break;
                        
                    }
                    else
                    {
                        cek = true;
                    }
                }

                if (cek == true)
                {

                    data = "C" + angka;
                    C.Add(data);
                    angka++;
                    category.Add(txt_namacategory.Text);
                    dtCategory.Rows.Add(data, txt_namacategory.Text);
                    cmb_category.Items.Add(txt_namacategory.Text);
                    cmb_filter.Items.Add(txt_namacategory.Text);
                }
                
            }
            txt_namacategory.Clear();
        }
        
        private void btn_addproduct_Click(object sender, EventArgs e)
        {
            bool containsstring1 = int.TryParse(txt_stock.Text, out int n);
            bool containsstring2 = int.TryParse(txt_harga.Text, out int m);
            
                        
            if (txt_namaproduct.Text == "" )
            {
                MessageBox.Show(" Pastikan semuanya terpilih dan terisi ", "Hasil", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmb_category.Text == "")
            {
                MessageBox.Show(" Harap memilih category ", "Hasil", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (containsstring1 == false)
            {
                MessageBox.Show(" Stock harus angka ", "Hasil", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (containsstring2 == false)
            {
                MessageBox.Show(" Harga harus angka ", "Hasil", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (txt_stock.Text == "0")
                {
                    MessageBox.Show("Dilarang input stock 0");
                }
                else
                {
                    string hasil = "";
                    bool ada = false;
                    string simpan = txt_namaproduct.Text.Substring(0, 1).ToUpper();
                    foreach (DataGridViewRow row in dgv_product.Rows)
                    {
                        if (row.Cells[0].Value != null)
                        {
                            if (row.Cells[0].Value.ToString().Substring(0, 1).Equals(simpan))
                            {
                                int a = int.Parse(row.Cells[0].Value.ToString().Substring(1, 3)); // A001
                                                                                                  // 0123
                                if (a < 9)
                                {
                                    a++;
                                    hasil = simpan + "00" + a;
                                    ada = true;
                                }
                                else
                                {
                                    a++;
                                    hasil = simpan + "0" + a;
                                    ada = true;
                                }
                            }
                        }

                    }
                    if (ada == false)
                    {
                        hasil = simpan + "00" + 1;
                    }



                    for (int i = 0; i < C.Count; i++)
                    {
                        if (cmb_category.SelectedItem.ToString() == category[i])
                        {
                            dtProdukSimpan.Rows.Add(hasil, txt_namaproduct.Text, txt_harga.Text, txt_stock.Text, C[i]);
                        }
                    }
                }
                

            }
            txt_harga.Text = "";
            txt_stock.Text = "";
            txt_namaproduct.Text = "";
            cmb_category.Text = null;
           
            
        }

        private void cmb_category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_filter_SelectedIndexChanged(object sender, EventArgs e)
        {
           dtProdukTampil.Rows.Clear();
            dgv_product.DataSource = dtProdukTampil;
            for (int i = 0; i < category.Count; i++)
            {
                if (cmb_filter.SelectedItem == dtCategory.Rows[i][1])
                {
                   for ( int j = 0; j < dtProdukSimpan.Rows.Count;j++)
                   {
                        if (dtCategory.Rows[i][0] == dtProdukSimpan.Rows[j][4])
                        {
                            
                            dtProdukTampil.Rows.Add(dtProdukSimpan.Rows[j][0], dtProdukSimpan.Rows[j][1], dtProdukSimpan.Rows[j][2], dtProdukSimpan.Rows[j][3], dtProdukSimpan.Rows[j][4]);
                        }
                   }
                    break;
                }               
            }           

        }

        private void btn_removeproduct_Click(object sender, EventArgs e)
        {
            if (dgv_product.SelectedCells.Count > 0)
            {
                dtProdukSimpan.Rows.RemoveAt(dgv_product.CurrentCell.RowIndex);
            }
            else
            {
                
                MessageBox.Show(" Pilih dulu ", "Hasil", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }
        bool cekisi = false;
        int simpan = 100;
        private void btn_removecategory_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dgv_product.SelectedCells.Count.ToString());
            if (index > 0)
            {
                string simpann = passRow.Cells[0].Value.ToString();
                

                if (passRow != null)
                {
                    for (int i = 0; i < dtCategory.Rows.Count; i++)
                    {

                        if (passRow.Cells[1].Value.ToString() == dtCategory.Rows[i][1].ToString()) //  HArus milih dulu ya  
                        {

                            cekisi = true;
                            simpan = i;

                        }
                    }
                    for (int i = dtProdukSimpan.Rows.Count - 1; i >= 0; i--)
                    {
                        if (dtProdukSimpan.Rows[i][4] == simpann)
                        {
                            dtProdukSimpan.Rows.RemoveAt(i);
                        }
                    }

                    if (cekisi == true)
                    {
                        category.RemoveAt(simpan);
                        C.RemoveAt(simpan);
                    }
                    dtCategory.Rows.RemoveAt(dgv_category.CurrentCell.RowIndex);
                    refresh();
                    refreshfilter();

                }
                txt_namacategory.Clear();
                dgv_category.ClearSelection();
                
            }
            else
            {
                
                MessageBox.Show(" Pilih dulu ", "Hasil", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btn_all_Click(object sender, EventArgs e)
        {
            cmb_filter.Enabled = false;
            cmb_filter.Text = null;
            dgv_product.DataSource = dtProdukSimpan;
            txt_harga.Text = "";
            txt_stock.Text = "";
            txt_namaproduct.Text = "";
            cmb_category.Text = null;
        }
            DataGridViewRow passRow= null;
        private void dgv_category_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            passRow = dgv_category.Rows[e.RowIndex];
        }
        public int index = 0;
        private void dgv_category_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            passRow = dgv_category.Rows[e.RowIndex];
            index = dgv_category.SelectedCells[0].RowIndex;
            txt_namacategory.Text = dtCategory.Rows[index][1].ToString();
        }

        private void dgv_product_SelectionChanged(object sender, EventArgs e)
        {
           
            
        }
       
        private void dgv_product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_product.DataSource == dtProdukSimpan)
            {
                index = dgv_product.SelectedCells[0].RowIndex;

                txt_namaproduct.Text = dtProdukSimpan.Rows[index][1].ToString();
                txt_stock.Text = dtProdukSimpan.Rows[index][3].ToString();
                txt_harga.Text = dtProdukSimpan.Rows[index][2].ToString();
                for (int i = 0; i < category.Count; i++)
                {

                    if (dtProdukSimpan.Rows[index][4].ToString() == C[i])
                    {
                        cmb_category.Text = category[i];
                    }
                }
            }
            else
            {
                index = dgv_product.SelectedCells[0].RowIndex;

                txt_namaproduct.Text = dtProdukTampil.Rows[index][1].ToString();
                txt_stock.Text = dtProdukTampil.Rows[index][3].ToString();
                txt_harga.Text = dtProdukTampil.Rows[index][2].ToString();
                for (int i = 0; i < category.Count; i++)
                {

                    if (dtProdukTampil.Rows[index][4].ToString() == C[i])
                    {
                        cmb_category.Text = category[i];
                    }
                }               
                
            }

        }

        private void btn_editproduct_Click(object sender, EventArgs e)
        {
            //dtProdukSimpan.Rows.Clear();

            if (dgv_product.DataSource == dtProdukSimpan)
            {
                bool containsstring1 = int.TryParse(txt_stock.Text, out int n);
                bool containsstring2 = int.TryParse(txt_harga.Text, out int m);
                if (dgv_product.SelectedCells.Count > 0)
                {
                    if (containsstring1 == false)
                    {
                        MessageBox.Show(" Stock harus angka ", "Hasil", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (containsstring2 == false)
                    {
                        MessageBox.Show(" Harga harus angka ", "Hasil", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (txt_stock.Text == "0")
                        {
                            dtProdukSimpan.Rows.RemoveAt(dgv_product.CurrentCell.RowIndex);
                            txt_harga.Text = "";
                            txt_stock.Text = "";
                            txt_namaproduct.Text = "";
                            cmb_category.Text = null;
                        }
                        else
                        {
                            dtProdukSimpan.Rows[index][1] = txt_namaproduct.Text;
                            dtProdukSimpan.Rows[index][3] = txt_stock.Text;
                            dtProdukSimpan.Rows[index][2] = txt_harga.Text;

                            for (int i = 0; i < category.Count; i++)
                            {

                                if (cmb_category.SelectedItem == category[i])
                                {


                                    dtProdukSimpan.Rows[index][4] = C[i].ToString();

                                }
                            }
                            dgv_product.DataSource = dtProdukSimpan;
                        }


                    }
                    txt_harga.Text = "";
                    txt_stock.Text = "";
                    txt_namaproduct.Text = "";
                    cmb_category.Text = null;

                }
                else
                {
                    MessageBox.Show(" Pilih dulu ", "Hasil", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Harap kembali ke button all terlebih dahulu agar bisa mengedit");
            }

            
            
             
        }
    }
}
