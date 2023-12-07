namespace ASM_2.GUI.View
{
    partial class MainApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txt_Ma = new TextBox();
            txt_HoTen = new TextBox();
            dtp_birthday = new DateTimePicker();
            rdb_Nam = new RadioButton();
            rdb_Nu = new RadioButton();
            cbo_PhongBan = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            dgv_Main = new DataGridView();
            btn_add = new Button();
            btn_Sua = new Button();
            btn_Xoa = new Button();
            btn_Clear = new Button();
            btn_TimKiem = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_Main).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(236, 9);
            label1.Name = "label1";
            label1.Size = new Size(351, 32);
            label1.TabIndex = 0;
            label1.Text = "Quản lí thông tin nhân viên";
            // 
            // txt_Ma
            // 
            txt_Ma.Location = new Point(129, 81);
            txt_Ma.Name = "txt_Ma";
            txt_Ma.Size = new Size(514, 23);
            txt_Ma.TabIndex = 1;
            // 
            // txt_HoTen
            // 
            txt_HoTen.Location = new Point(129, 121);
            txt_HoTen.Name = "txt_HoTen";
            txt_HoTen.Size = new Size(514, 23);
            txt_HoTen.TabIndex = 2;
            // 
            // dtp_birthday
            // 
            dtp_birthday.CustomFormat = "dd-MM-yyyy";
            dtp_birthday.Format = DateTimePickerFormat.Custom;
            dtp_birthday.Location = new Point(129, 167);
            dtp_birthday.Name = "dtp_birthday";
            dtp_birthday.Size = new Size(514, 23);
            dtp_birthday.TabIndex = 3;
            // 
            // rdb_Nam
            // 
            rdb_Nam.AutoSize = true;
            rdb_Nam.Location = new Point(166, 217);
            rdb_Nam.Name = "rdb_Nam";
            rdb_Nam.Size = new Size(51, 19);
            rdb_Nam.TabIndex = 4;
            rdb_Nam.TabStop = true;
            rdb_Nam.Text = "Nam";
            rdb_Nam.UseVisualStyleBackColor = true;
            // 
            // rdb_Nu
            // 
            rdb_Nu.AutoSize = true;
            rdb_Nu.Location = new Point(341, 221);
            rdb_Nu.Name = "rdb_Nu";
            rdb_Nu.Size = new Size(41, 19);
            rdb_Nu.TabIndex = 5;
            rdb_Nu.TabStop = true;
            rdb_Nu.Text = "Nữ";
            rdb_Nu.UseVisualStyleBackColor = true;
            // 
            // cbo_PhongBan
            // 
            cbo_PhongBan.FormattingEnabled = true;
            cbo_PhongBan.Location = new Point(129, 276);
            cbo_PhongBan.Name = "cbo_PhongBan";
            cbo_PhongBan.Size = new Size(514, 23);
            cbo_PhongBan.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(48, 319);
            label2.Name = "label2";
            label2.Size = new Size(205, 30);
            label2.TabIndex = 7;
            label2.Text = "Danh sách nhân viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 84);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 8;
            label3.Text = "Mã nhân viên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 121);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 9;
            label4.Text = "Họ tên";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 173);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 10;
            label5.Text = "Ngày sinh";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 225);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 11;
            label6.Text = "Giới tính";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 279);
            label7.Name = "label7";
            label7.Size = new Size(65, 15);
            label7.TabIndex = 12;
            label7.Text = "Phòng ban";
            // 
            // dgv_Main
            // 
            dgv_Main.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Main.Location = new Point(31, 357);
            dgv_Main.Name = "dgv_Main";
            dgv_Main.RowTemplate.Height = 25;
            dgv_Main.Size = new Size(789, 154);
            dgv_Main.TabIndex = 13;
            dgv_Main.CellClick += dgv_Main_CellClick;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(684, 81);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(100, 35);
            btn_add.TabIndex = 14;
            btn_add.Text = "Thêm";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_Sua
            // 
            btn_Sua.Location = new Point(684, 122);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(100, 35);
            btn_Sua.TabIndex = 15;
            btn_Sua.Text = "Sửa";
            btn_Sua.UseVisualStyleBackColor = true;
            btn_Sua.Click += btn_Sua_Click;
            // 
            // btn_Xoa
            // 
            btn_Xoa.Location = new Point(684, 173);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(100, 35);
            btn_Xoa.TabIndex = 16;
            btn_Xoa.Text = "Xóa";
            btn_Xoa.UseVisualStyleBackColor = true;
            btn_Xoa.Click += btn_Xoa_Click;
            // 
            // btn_Clear
            // 
            btn_Clear.Location = new Point(684, 276);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(100, 35);
            btn_Clear.TabIndex = 17;
            btn_Clear.Text = "Clear";
            btn_Clear.UseVisualStyleBackColor = true;
            btn_Clear.Click += btn_Clear_Click;
            // 
            // btn_TimKiem
            // 
            btn_TimKiem.Location = new Point(684, 225);
            btn_TimKiem.Name = "btn_TimKiem";
            btn_TimKiem.Size = new Size(100, 35);
            btn_TimKiem.TabIndex = 18;
            btn_TimKiem.Text = "Tìm kiếm";
            btn_TimKiem.UseVisualStyleBackColor = true;
            btn_TimKiem.Click += btn_TimKiem_Click;
            // 
            // MainApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(832, 523);
            Controls.Add(btn_TimKiem);
            Controls.Add(btn_Clear);
            Controls.Add(btn_Xoa);
            Controls.Add(btn_Sua);
            Controls.Add(btn_add);
            Controls.Add(dgv_Main);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cbo_PhongBan);
            Controls.Add(rdb_Nu);
            Controls.Add(rdb_Nam);
            Controls.Add(dtp_birthday);
            Controls.Add(txt_HoTen);
            Controls.Add(txt_Ma);
            Controls.Add(label1);
            Name = "MainApp";
            Text = "MainApp";
            Load += MainApp_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Main).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_Ma;
        private TextBox txt_HoTen;
        private DateTimePicker dtp_birthday;
        private RadioButton rdb_Nam;
        private RadioButton rdb_Nu;
        private ComboBox cbo_PhongBan;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DataGridView dgv_Main;
        private Button btn_add;
        private Button btn_Sua;
        private Button btn_Xoa;
        private Button btn_Clear;
        private Button btn_TimKiem;
    }
}