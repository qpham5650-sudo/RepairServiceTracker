using System.ComponentModel;

namespace RepairServiceTracker
{
    public partial class Form1 : Form
    {
        private BindingList<RepairOrder> orders =
            new BindingList<RepairOrder>();

        private BindingSource source =
            new BindingSource();

        private ErrorProvider errorProvider =
            new ErrorProvider();

        private string selectedImagePath = "";

        public Form1()
        {
            InitializeComponent();

            InitializeData();
            InitializeGrid();
        }

        private void InitializeData()
        {
            source.DataSource = orders;

            dgvOrders.DataSource = source;

            cboDeviceType.Items.AddRange(
                new string[]
                {
                    "Laptop",
                    "Điện thoại",
                    "Máy tính bảng",
                    "Máy in",
                    "Khác"
                });

            cboStatus.Items.AddRange(
                new string[]
                {
                    "Mới tiếp nhận",
                    "Đang sửa",
                    "Chờ linh kiện",
                    "Hoàn tất",
                    "Đã hủy"
                });

            cboFilterStatus.Items.Add(
                "Tất cả");

            cboFilterStatus.Items.AddRange(
                new string[]
                {
                    "Mới tiếp nhận",
                    "Đang sửa",
                    "Chờ linh kiện",
                    "Hoàn tất",
                    "Đã hủy"
                });

            cboFilterStatus.SelectedIndex =
                0;

            txtSearch.TextChanged +=
                TxtSearch_TextChanged;

            cboFilterStatus
                .SelectedIndexChanged +=
                CboFilterStatus_SelectedIndexChanged;

            UpdateStatusStrip();
        }

        private void InitializeGrid()
        {
            dgvOrders.AutoGenerateColumns =
                false;

            dgvOrders.SelectionMode =
                DataGridViewSelectionMode
                .FullRowSelect;

            dgvOrders.MultiSelect =
                false;

            dgvOrders.Columns.Clear();

            dgvOrders.Columns.Add(
                new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Mã đơn",
                    DataPropertyName =
                        "OrderId"
                });

            dgvOrders.Columns.Add(
                new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Khách hàng",
                    DataPropertyName =
                        "CustomerName"
                });

            dgvOrders.Columns.Add(
                new DataGridViewTextBoxColumn()
                {
                    HeaderText = "SĐT",
                    DataPropertyName =
                        "PhoneNumber"
                });

            dgvOrders.Columns.Add(
                new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Thiết bị",
                    DataPropertyName =
                        "DeviceType"
                });

            dgvOrders.Columns.Add(
                new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Chi phí",
                    DataPropertyName =
                        "EstimatedCost",
                    DefaultCellStyle =
                    {
                        Format = "N0"
                    }
                });

            dgvOrders.Columns.Add(
                new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Trạng thái",
                    DataPropertyName =
                        "Status"
                });

            dgvOrders.CellClick +=
                DgvOrders_CellClick;
        }

        private bool ValidateInput()
        {
            errorProvider.Clear();

            bool valid = true;

            if (string.IsNullOrWhiteSpace(
                txtOrderId.Text))
            {
                errorProvider.SetError(
                    txtOrderId,
                    "Nhập mã đơn");

                valid = false;
            }

            if (orders.Any(x =>
                x.OrderId ==
                txtOrderId.Text))
            {
                errorProvider.SetError(
                    txtOrderId,
                    "Mã đơn đã tồn tại");

                valid = false;
            }

            if (string.IsNullOrWhiteSpace(
                txtCustomerName.Text))
            {
                errorProvider.SetError(
                    txtCustomerName,
                    "Nhập tên khách");

                valid = false;
            }

            if (string.IsNullOrWhiteSpace(
                txtPhone.Text))
            {
                errorProvider.SetError(
                    txtPhone,
                    "Nhập số điện thoại");

                valid = false;
            }

            if (string.IsNullOrWhiteSpace(
                txtProblem.Text))
            {
                errorProvider.SetError(
                    txtProblem,
                    "Nhập mô tả lỗi");

                valid = false;
            }

            decimal cost;

            if (!decimal.TryParse(
                txtCost.Text,
                out cost))
            {
                errorProvider.SetError(
                    txtCost,
                    "Chi phí không hợp lệ");

                valid = false;
            }

            if (cost < 0)
            {
                errorProvider.SetError(
                    txtCost,
                    "Chi phí ≥ 0");

                valid = false;
            }

            return valid;
        }

        private void btnChooseImage_Click(
            object sender,
            EventArgs e)
        {
            OpenFileDialog dlg =
                new OpenFileDialog();

            dlg.Filter =
                "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (dlg.ShowDialog()
                == DialogResult.OK)
            {
                selectedImagePath =
                    dlg.FileName;

                picDevice.Image =
                    Image.FromFile(
                        dlg.FileName);

                picDevice.SizeMode =
                    PictureBoxSizeMode.Zoom;
            }
        }

        private void btnAdd_Click(
            object sender,
            EventArgs e)
        {
            if (!ValidateInput())
                return;

            orders.Add(
                new RepairOrder
                {
                    OrderId =
                        txtOrderId.Text,

                    CustomerName =
                        txtCustomerName.Text,

                    PhoneNumber =
                        txtPhone.Text,

                    DeviceType =
                        cboDeviceType.Text,

                    ProblemDescription =
                        txtProblem.Text,

                    ReceivedDate =
                        dtReceivedDate.Value,

                    EstimatedCost =
                        decimal.Parse(
                            txtCost.Text),

                    Status =
                        cboStatus.Text,

                    ImagePath =
                        selectedImagePath
                });

            UpdateStatusStrip();
        }

        private void btnUpdate_Click(
            object sender,
            EventArgs e)
        {
            if (source.Current
                is RepairOrder item)
            {
                item.CustomerName =
                    txtCustomerName.Text;

                item.PhoneNumber =
                    txtPhone.Text;

                item.DeviceType =
                    cboDeviceType.Text;

                item.ProblemDescription =
                    txtProblem.Text;

                item.ReceivedDate =
                    dtReceivedDate.Value;

                item.EstimatedCost =
                    decimal.Parse(
                        txtCost.Text);

                item.Status =
                    cboStatus.Text;

                item.ImagePath =
                    selectedImagePath;

                source.ResetBindings(false);

                UpdateStatusStrip();
            }
        }

        private void btnDelete_Click(
            object sender,
            EventArgs e)
        {
            if (source.Current == null)
                return;

            DialogResult rs =
                MessageBox.Show(
                    "Xóa đơn sửa chữa ?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
            {
                source.RemoveCurrent();

                UpdateStatusStrip();
            }
        }

        private void DgvOrders_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (source.Current
                is RepairOrder item)
            {
                txtOrderId.Text =
                    item.OrderId;

                txtCustomerName.Text =
                    item.CustomerName;

                txtPhone.Text =
                    item.PhoneNumber;

                cboDeviceType.Text =
                    item.DeviceType;

                txtProblem.Text =
                    item.ProblemDescription;

                dtReceivedDate.Value =
                    item.ReceivedDate;

                txtCost.Text =
                    item.EstimatedCost
                    .ToString();

                cboStatus.Text =
                    item.Status;

                selectedImagePath =
                    item.ImagePath;

                if (
                    !string.IsNullOrWhiteSpace(
                        item.ImagePath)
                    &&
                    File.Exists(
                        item.ImagePath))
                {
                    picDevice.Image =
                        Image.FromFile(
                            item.ImagePath);

                    picDevice.SizeMode =
                        PictureBoxSizeMode.Zoom;
                }
            }
        }

        private void TxtSearch_TextChanged(
            object sender,
            EventArgs e)
        {
            ApplyFilter();
        }

        private void CboFilterStatus_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            string keyword =
                txtSearch.Text
                .ToLower();

            string status =
                cboFilterStatus.Text;

            var filtered =
                orders.Where(x =>
                    (
                        x.OrderId
                         .ToLower()
                         .Contains(keyword)
                        ||

                        x.CustomerName
                         .ToLower()
                         .Contains(keyword)
                        ||

                        x.PhoneNumber
                         .Contains(keyword)
                    )
                    &&
                    (
                        status == "Tất cả"
                        ||
                        x.Status == status
                    )
                )
                .ToList();

            dgvOrders.DataSource =
                new BindingList
                <RepairOrder>(
                    filtered);

            UpdateFilteredStatus(
                filtered);
        }

        private void UpdateFilteredStatus(
            List<RepairOrder>
            filtered)
        {
            lblTotalOrders.Text =
                $"Số đơn: {filtered.Count}";

            decimal totalCost =
                filtered
                .Where(x =>
                    x.Status
                    != "Hoàn tất")
                .Sum(x =>
                    x.EstimatedCost);

            lblTotalCost.Text =
                $"Tổng chi phí: {totalCost:N0}";
        }

        private void UpdateStatusStrip()
        {
            int total =
                orders.Count;

            decimal totalCost =
                orders
                .Where(x =>
                    x.Status
                    != "Hoàn tất")
                .Sum(x =>
                    x.EstimatedCost);

            lblTotalOrders.Text =
                $"Số đơn: {total}";

            lblTotalCost.Text =
                $"Tổng chi phí: {totalCost:N0}";
        }

        private void btnClear_Click(
            object sender,
            EventArgs e)
        {
            txtOrderId.Clear();

            txtCustomerName.Clear();

            txtPhone.Clear();

            txtProblem.Clear();

            txtCost.Clear();

            cboDeviceType.SelectedIndex =
                -1;

            cboStatus.SelectedIndex =
                -1;

            picDevice.Image = null;

            selectedImagePath = "";
        }
    }
}