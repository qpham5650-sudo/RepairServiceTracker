namespace RepairServiceTracker
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exportCsvToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblTotalOrders;
        private ToolStripStatusLabel lblTotalCost;

        private Label lblOrderId;
        private Label lblCustomerName;
        private Label lblPhone;
        private Label lblDevice;
        private Label lblReceivedDate;
        private Label lblCost;
        private Label lblStatus;
        private Label lblProblem;
        private Label lblSearch;
        private Label lblFilter;

        private TextBox txtOrderId;
        private TextBox txtCustomerName;
        private TextBox txtPhone;
        private TextBox txtCost;
        private TextBox txtProblem;
        private TextBox txtSearch;

        private ComboBox cboDeviceType;
        private ComboBox cboStatus;
        private ComboBox cboFilterStatus;

        private DateTimePicker dtReceivedDate;

        private PictureBox picDevice;

        private Button btnChooseImage;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;

        private DataGridView dgvOrders;

        protected override void Dispose(bool disposing)
        {
            if (disposing &&
                (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components =
                new System.ComponentModel.Container();

            menuStrip1 = new MenuStrip();

            fileToolStripMenuItem =
                new ToolStripMenuItem();

            exportCsvToolStripMenuItem =
                new ToolStripMenuItem();

            exitToolStripMenuItem =
                new ToolStripMenuItem();

            statusStrip1 =
                new StatusStrip();

            lblTotalOrders =
                new ToolStripStatusLabel();

            lblTotalCost =
                new ToolStripStatusLabel();

            lblOrderId = new Label();
            lblCustomerName = new Label();
            lblPhone = new Label();
            lblDevice = new Label();
            lblReceivedDate = new Label();
            lblCost = new Label();
            lblStatus = new Label();
            lblProblem = new Label();
            lblSearch = new Label();
            lblFilter = new Label();

            txtOrderId = new TextBox();
            txtCustomerName = new TextBox();
            txtPhone = new TextBox();
            txtCost = new TextBox();
            txtProblem = new TextBox();
            txtSearch = new TextBox();

            cboDeviceType = new ComboBox();
            cboStatus = new ComboBox();
            cboFilterStatus = new ComboBox();

            dtReceivedDate =
                new DateTimePicker();

            picDevice =
                new PictureBox();

            btnChooseImage =
                new Button();

            btnAdd =
                new Button();

            btnUpdate =
                new Button();

            btnDelete =
                new Button();

            btnClear =
                new Button();

            dgvOrders =
                new DataGridView();

            ((System.ComponentModel.ISupportInitialize)
                picDevice).BeginInit();

            ((System.ComponentModel.ISupportInitialize)
                dgvOrders).BeginInit();

            SuspendLayout();

            // Menu

            fileToolStripMenuItem.Text =
                "File";

            exportCsvToolStripMenuItem.Text =
                "Export CSV";

            exitToolStripMenuItem.Text =
                "Exit";

            fileToolStripMenuItem
                .DropDownItems
                .AddRange(
                new ToolStripItem[]
                {
                    exportCsvToolStripMenuItem,
                    exitToolStripMenuItem
                });

            menuStrip1.Items.AddRange(
                new ToolStripItem[]
                {
                    fileToolStripMenuItem
                });

            // Status

            lblTotalOrders.Text =
                "Số đơn: 0";

            lblTotalCost.Text =
                "Tổng chi phí: 0";

            statusStrip1.Items.AddRange(
                new ToolStripItem[]
                {
                    lblTotalOrders,
                    lblTotalCost
                });

            // Labels

            lblOrderId.Text = "Mã đơn";
            lblOrderId.Location =
                new Point(20,40);

            lblCustomerName.Text =
                "Khách hàng";
            lblCustomerName.Location =
                new Point(20,80);

            lblPhone.Text =
                "Số điện thoại";
            lblPhone.Location =
                new Point(20,120);

            lblDevice.Text =
                "Thiết bị";
            lblDevice.Location =
                new Point(350,40);

            lblReceivedDate.Text =
                "Ngày nhận";
            lblReceivedDate.Location =
                new Point(350,80);

            lblCost.Text =
                "Chi phí";
            lblCost.Location =
                new Point(350,120);

            lblStatus.Text =
                "Trạng thái";
            lblStatus.Location =
                new Point(650,40);

            lblProblem.Text =
                "Mô tả lỗi";
            lblProblem.Location =
                new Point(650,80);

            lblSearch.Text =
                "Tìm kiếm";
            lblSearch.Location =
                new Point(20,210);

            lblFilter.Text =
                "Lọc";
            lblFilter.Location =
                new Point(350,210);

            // TextBox

            txtOrderId.Location =
                new Point(120,40);
            txtOrderId.Width = 180;

            txtCustomerName.Location =
                new Point(120,80);
            txtCustomerName.Width = 180;

            txtPhone.Location =
                new Point(120,120);
            txtPhone.Width = 180;

            txtCost.Location =
                new Point(450,120);
            txtCost.Width = 150;

            txtProblem.Location =
                new Point(760,80);
            txtProblem.Width = 260;
            txtProblem.Height = 80;
            txtProblem.Multiline = true;

            txtSearch.Location =
                new Point(120,210);
            txtSearch.Width = 180;

            // ComboBox

            cboDeviceType.Location =
                new Point(450,40);
            cboDeviceType.Width = 150;

            cboStatus.Location =
                new Point(760,40);
            cboStatus.Width = 200;

            cboFilterStatus.Location =
                new Point(450,210);
            cboFilterStatus.Width = 150;

            // DateTime

            dtReceivedDate.Location =
                new Point(450,80);
            dtReceivedDate.Width = 180;

            // PictureBox

            picDevice.Location =
                new Point(1040,30);

            picDevice.Size =
                new Size(180,180);

            picDevice.BorderStyle =
                BorderStyle.FixedSingle;

            picDevice.SizeMode =
                PictureBoxSizeMode.Zoom;

            // Choose Image

            btnChooseImage.Location =
                new Point(1040,220);

            btnChooseImage.Size =
                new Size(180,35);

            btnChooseImage.Text =
                "Chọn ảnh";

            btnChooseImage.Click +=
                btnChooseImage_Click;
            // Buttons

            btnAdd.Location =
                new Point(620,210);

            btnAdd.Size =
                new Size(90,35);

            btnAdd.Text =
                "Thêm";

            btnAdd.Click +=
                btnAdd_Click;

            btnUpdate.Location =
                new Point(720,210);

            btnUpdate.Size =
                new Size(90,35);

            btnUpdate.Text =
                "Cập nhật";

            btnUpdate.Click +=
                btnUpdate_Click;

            btnDelete.Location =
                new Point(820,210);

            btnDelete.Size =
                new Size(90,35);

            btnDelete.Text =
                "Xóa";

            btnDelete.Click +=
                btnDelete_Click;

            btnClear.Location =
                new Point(920,210);

            btnClear.Size =
                new Size(90,35);

            btnClear.Text =
                "Làm mới";

            btnClear.Click +=
                btnClear_Click;

            // DataGridView

            dgvOrders.Location =
                new Point(20,270);

            dgvOrders.Size =
                new Size(1200,400);

            dgvOrders.Anchor =
                AnchorStyles.Top
                | AnchorStyles.Bottom
                | AnchorStyles.Left
                | AnchorStyles.Right;

            // Form

            AutoScaleDimensions =
                new SizeF(7F,15F);

            AutoScaleMode =
                AutoScaleMode.Font;

            ClientSize =
                new Size(1250,720);

            Controls.Add(menuStrip1);

            Controls.Add(statusStrip1);

            Controls.Add(lblOrderId);
            Controls.Add(lblCustomerName);
            Controls.Add(lblPhone);
            Controls.Add(lblDevice);
            Controls.Add(lblReceivedDate);
            Controls.Add(lblCost);
            Controls.Add(lblStatus);
            Controls.Add(lblProblem);
            Controls.Add(lblSearch);
            Controls.Add(lblFilter);

            Controls.Add(txtOrderId);
            Controls.Add(txtCustomerName);
            Controls.Add(txtPhone);
            Controls.Add(txtCost);
            Controls.Add(txtProblem);
            Controls.Add(txtSearch);

            Controls.Add(cboDeviceType);
            Controls.Add(cboStatus);
            Controls.Add(cboFilterStatus);

            Controls.Add(dtReceivedDate);

            Controls.Add(picDevice);

            Controls.Add(btnChooseImage);

            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);

            Controls.Add(dgvOrders);

            MainMenuStrip =
                menuStrip1;

            Text =
                "Repair Service Tracker";

            ((System.ComponentModel.ISupportInitialize)
                picDevice).EndInit();

            ((System.ComponentModel.ISupportInitialize)
                dgvOrders).EndInit();

            ResumeLayout(false);

            PerformLayout();
        }
    }
}    