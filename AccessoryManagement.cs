using Final.Model.BuildPCModel;
using Final.Model.LaptopModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;

namespace Final {
    public partial class AccessoryManagement : Form {
        public AccessoryManagement() {
            InitializeComponent();
        }

        private void AccessoryManagement_Load(object sender, EventArgs e) {
            try {
                var context = new BuildPcDBContext();
                FillBrandBox(context.AccessoryBrand.ToList());
                FillCategoryBox(context.AccessoryCategory.ToList());
                FillDataView(context.Accessory.ToList());
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e) {
            //Tìm kiếm, thoả mãn một trong các ô mã linh kiện, tên, hãng, loại linh kiện

            var context = new BuildPcDBContext();
            try
            {
                
                var findById = context.Accessory.Where(a => a.AccessoryID == TbAccessoryID.Text);
                var findByName = context.Accessory.Where(b => b.AccessoryName == TbAccessoryName.Text);
                var findByCbxAccessoryBrand = context.Accessory.Where(c => c.AccessoryBrand.BrandName == ((BuildPcDBContext)CbxAccessoryBrand.SelectedItem).AccessoryBrand.BrandName);
                var findByCbxAccessoryCategory = context.Accessory.Where(d => d.AccessoryCategory.CategoryName == ((BuildPcDBContext)CbxAccessoryCategory.SelectedItem).AccessoryCategory.AccessoryCategoryName);
                FillDataView(findById.Union(findByName).Union(findByCbxAccessoryBrand).Union(findByCbxAccessoryCategory).ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //Có thể kết hợp nhiều điều kiện

            if (TbAccessoryID.Text != "" || TbAccessoryName.Text != "")
            {
                FillDataView(context.Accessory.Where(l => l.AccessoryID.Contains(TbAccessoryID.Text) || l.AccessoryName.Contains(TbAccessoryName.Text)).ToList());
            }
           


        }

        private void BtnEdit_Click(object sender, EventArgs e) {
            try {
                BuildPcDBContext context = new BuildPcDBContext();
                var find = context.Accessory.FirstOrDefault(a => a.AccessoryID == TbAccessoryID.Text);
                if (find != null) {
                    if (TbAccessoryID.Text == "" || TbAccessoryName.Text == "" || TbPrice.Text == "" || TbQuantity.Text == "") {
                        MessageBox.Show("Nhập đầy đủ thông tin");
                    }

                    find.AccessoryID = TbAccessoryID.Text;
                    find.AccessoryName = TbAccessoryName.Text;
                    find.BrandID = ((AccessoryBrand)CbxAccessoryBrand.SelectedItem).BrandID;
                    find.CategoryID = ((AccessoryCategory)CbxAccessoryCategory.SelectedItem).CategoryID;
                    if (decimal.TryParse(TbPrice.Text, out decimal price)) {
                        find.SalePrice = price;
                    } else {
                        MessageBox.Show("Giá trị không hợp lệ");
                        TbPrice.Text = "";
                    }
                    if (int.TryParse(TbQuantity.Text, out int quantity)) {
                        find.Quantity += quantity;
                    } else {
                        MessageBox.Show("Giá trị không hợp lệ");
                        TbQuantity.Text = "";
                    }
                    if (int.TryParse(TbSale.Text, out int sale)) {
                        if (sale != 0) {
                            find.SalePrice = sale;
                        }
                    } else {
                        MessageBox.Show("Giá trị không hợp lệ");
                        TbSale.Text = "";
                    }
                } else {
                    var accessory = new Accessory {
                        AccessoryID = TbAccessoryID.Text,
                        AccessoryName = TbAccessoryID.Text,
                        BrandID = ((AccessoryBrand)CbxAccessoryBrand.SelectedItem).BrandID,
                        CategoryID = ((AccessoryCategory)CbxAccessoryCategory.SelectedItem).CategoryID
                    };
                    if (decimal.TryParse(TbPrice.Text, out decimal price)) {
                        accessory.SalePrice = price;
                    } else {
                        MessageBox.Show("Giá trị không hợp lệ");
                    }
                    if (int.TryParse(TbQuantity.Text, out int quantity)) {
                        accessory.Quantity = quantity;
                    } else {
                        MessageBox.Show("Giá trị không hợp lệ");
                    }
                    if (int.TryParse(TbSale.Text, out int sale) && sale != 0) {
                        accessory.Sale = sale;
                    }

                    context.Accessory.Add(accessory);
                    context.SaveChanges();
                    MessageBox.Show("Thêm mới thành công");
                    context = new BuildPcDBContext();
                    FillDataView(context.Accessory.ToList());
                }

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e) {
            //Xoá một linh kiện kiểm tra xem nếu số lương = 0 thì ko cho xoá
            try
            {
                BuildPcDBContext context = new BuildPcDBContext();
                var find = context.Accessory.FirstOrDefault(a => a.AccessoryID == TbAccessoryID.Text);
                //Nếu không tồn tại
                if (find.Quantity == 0)
                {
                    MessageBox.Show("Số lượng xoá ngoài phạm vi có thể xoá !","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                //Khi xoá chỉ thay đổi số lượng, không xoá trong db
                DialogResult dialog = MessageBox.Show("Bạn có muốn xoá ?", "YES/NO", MessageBoxButtons.YesNo);
                if (int.TryParse(TbQuantity.Text, out int quantity) && quantity > 0 && quantity <= find.Quantity)
                {
                    if (dialog == DialogResult.Yes)
                    {
                        find.Quantity -= quantity;
                        context.SaveChanges();
                        FillDataView(context.Accessory.ToList());
                    }
                }
                else
                {
                    MessageBox.Show("Số lượng xoá ngoài phạm vi có thể xoá !","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillCategoryBox(IReadOnlyCollection<AccessoryCategory> categories) {
            CbxAccessoryCategory.DataSource = categories;
            CbxAccessoryCategory.DisplayMember = "CategoryName";
            CbxAccessoryCategory.ValueMember = "CategoryID";
            CbxAccessoryCategory.SelectedIndex = -1;
        }

        private void FillBrandBox(IReadOnlyCollection<AccessoryBrand> brands) {
            CbxAccessoryBrand.DataSource = brands;
            CbxAccessoryBrand.DisplayMember = "BrandName";
            CbxAccessoryBrand.ValueMember = "BrandID";
            CbxAccessoryBrand.SelectedIndex = -1;
        }

        private void FillDataView(List<Accessory> accessories) {
            DgvAccessories.Rows.Clear();
            foreach (var accessory in accessories) {
                var index = DgvAccessories.Rows.Add();
                DgvAccessories.Rows[index].Cells[0].Value = accessory.AccessoryID;
                DgvAccessories.Rows[index].Cells[1].Value = accessory.AccessoryName;
                DgvAccessories.Rows[index].Cells[2].Value = accessory.AccessoryBrand.BrandName;
                DgvAccessories.Rows[index].Cells[3].Value = accessory.AccessoryCategory.CategoryName;
                DgvAccessories.Rows[index].Cells[4].Value = accessory.SalePrice.ToString();
                DgvAccessories.Rows[index].Cells[5].Value = accessory.Sale.ToString();
                DgvAccessories.Rows[index].Cells[6].Value = accessory.Quantity.ToString();
            }
        }

        
    }
}