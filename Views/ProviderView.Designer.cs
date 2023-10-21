namespace Supermarket_mvp.Views
{
    partial class ProviderView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProviderView));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            tabControl1 = new TabControl();
            tabPageProviderList = new TabPage();
            tabPageProviderDetail = new TabPage();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            label2 = new Label();
            DgProvider = new DataGridView();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            BtnSave = new Button();
            BtnCancel = new Button();
            TxtProviderObservation = new TextBox();
            label5 = new Label();
            TxtProviderName = new TextBox();
            label4 = new Label();
            TxtProviderId = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPageProviderList.SuspendLayout();
            tabPageProviderDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgProvider).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(173, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(158, 26);
            label1.Name = "label1";
            label1.Size = new Size(205, 45);
            label1.TabIndex = 0;
            label1.Text = " PROVIDERS";
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageProviderList);
            tabControl1.Controls.Add(tabPageProviderDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 100);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 350);
            tabControl1.TabIndex = 2;
            // 
            // tabPageProviderList
            // 
            tabPageProviderList.Controls.Add(BtnClose);
            tabPageProviderList.Controls.Add(BtnDelete);
            tabPageProviderList.Controls.Add(BtnEdit);
            tabPageProviderList.Controls.Add(BtnNew);
            tabPageProviderList.Controls.Add(DgProvider);
            tabPageProviderList.Controls.Add(BtnSearch);
            tabPageProviderList.Controls.Add(TxtSearch);
            tabPageProviderList.Controls.Add(label2);
            tabPageProviderList.Location = new Point(4, 24);
            tabPageProviderList.Name = "tabPageProviderList";
            tabPageProviderList.Padding = new Padding(3);
            tabPageProviderList.Size = new Size(792, 322);
            tabPageProviderList.TabIndex = 0;
            tabPageProviderList.Text = "Provider List";
            tabPageProviderList.UseVisualStyleBackColor = true;
            // 
            // tabPageProviderDetail
            // 
            tabPageProviderDetail.Controls.Add(BtnSave);
            tabPageProviderDetail.Controls.Add(BtnCancel);
            tabPageProviderDetail.Controls.Add(TxtProviderObservation);
            tabPageProviderDetail.Controls.Add(label5);
            tabPageProviderDetail.Controls.Add(TxtProviderName);
            tabPageProviderDetail.Controls.Add(label4);
            tabPageProviderDetail.Controls.Add(TxtProviderId);
            tabPageProviderDetail.Controls.Add(label3);
            tabPageProviderDetail.Location = new Point(4, 24);
            tabPageProviderDetail.Name = "tabPageProviderDetail";
            tabPageProviderDetail.Padding = new Padding(3);
            tabPageProviderDetail.Size = new Size(792, 322);
            tabPageProviderDetail.TabIndex = 1;
            tabPageProviderDetail.Text = "Provider Detail";
            tabPageProviderDetail.UseVisualStyleBackColor = true;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.Image = (Image)resources.GetObject("BtnSearch.Image");
            BtnSearch.Location = new Point(528, 21);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(40, 46);
            BtnSearch.TabIndex = 5;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(8, 34);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(514, 23);
            TxtSearch.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 16);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 3;
            label2.Text = "Search Provider";
            // 
            // DgProvider
            // 
            DgProvider.AllowUserToAddRows = false;
            DgProvider.AllowUserToDeleteRows = false;
            DgProvider.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgProvider.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgProvider.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProvider.Location = new Point(8, 73);
            DgProvider.Name = "DgProvider";
            DgProvider.ReadOnly = true;
            DgProvider.RowTemplate.Height = 25;
            DgProvider.Size = new Size(560, 233);
            DgProvider.TabIndex = 6;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = (Image)resources.GetObject("BtnClose.Image");
            BtnClose.Location = new Point(592, 260);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(178, 46);
            BtnClose.TabIndex = 11;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Image = (Image)resources.GetObject("BtnDelete.Image");
            BtnDelete.Location = new Point(592, 199);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(178, 46);
            BtnDelete.TabIndex = 10;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Image = (Image)resources.GetObject("BtnEdit.Image");
            BtnEdit.Location = new Point(592, 136);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(178, 46);
            BtnEdit.TabIndex = 9;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.Image = (Image)resources.GetObject("BtnNew.Image");
            BtnNew.Location = new Point(592, 73);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(178, 46);
            BtnNew.TabIndex = 8;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = (Image)resources.GetObject("BtnSave.Image");
            BtnSave.Location = new Point(19, 223);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(100, 72);
            BtnSave.TabIndex = 18;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.Image = (Image)resources.GetObject("BtnCancel.Image");
            BtnCancel.Location = new Point(191, 223);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(100, 72);
            BtnCancel.TabIndex = 17;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // TxtProviderObservation
            // 
            TxtProviderObservation.Location = new Point(19, 148);
            TxtProviderObservation.Multiline = true;
            TxtProviderObservation.Name = "TxtProviderObservation";
            TxtProviderObservation.PlaceholderText = "Provider Observation";
            TxtProviderObservation.Size = new Size(272, 52);
            TxtProviderObservation.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 130);
            label5.Name = "label5";
            label5.Size = new Size(118, 15);
            label5.TabIndex = 15;
            label5.Text = "Provider Observation";
            // 
            // TxtProviderName
            // 
            TxtProviderName.Location = new Point(19, 89);
            TxtProviderName.Name = "TxtProviderName";
            TxtProviderName.PlaceholderText = "Provider name";
            TxtProviderName.Size = new Size(272, 23);
            TxtProviderName.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 71);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 13;
            label4.Text = "Provider Name";
            // 
            // TxtProviderId
            // 
            TxtProviderId.Location = new Point(19, 38);
            TxtProviderId.Name = "TxtProviderId";
            TxtProviderId.ReadOnly = true;
            TxtProviderId.Size = new Size(272, 23);
            TxtProviderId.TabIndex = 12;
            TxtProviderId.Text = "0";
            TxtProviderId.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 20);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 11;
            label3.Text = "Provider Id";
            // 
            // ProviderView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "ProviderView";
            Text = "Provider Managment";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPageProviderList.ResumeLayout(false);
            tabPageProviderList.PerformLayout();
            tabPageProviderDetail.ResumeLayout(false);
            tabPageProviderDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPageProviderList;
        private TabPage tabPageProviderDetail;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private Label label2;
        private DataGridView DgProvider;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private Button BtnSave;
        private Button BtnCancel;
        private TextBox TxtProviderObservation;
        private Label label5;
        private TextBox TxtProviderName;
        private Label label4;
        private TextBox TxtProviderId;
        private Label label3;
    }
}