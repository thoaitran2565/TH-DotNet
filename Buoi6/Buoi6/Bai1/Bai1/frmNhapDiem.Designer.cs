namespace Bai1
{
    partial class frmNhapDiem
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label maSoLabel;
            System.Windows.Forms.Label maMHLabel;
            System.Windows.Forms.Label diemLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapDiem));
            this.qL_SinhVienDataSet = new Bai1.QL_SinhVienDataSet();
            this.ketQuaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ketQuaTableAdapter = new Bai1.QL_SinhVienDataSetTableAdapters.KetQuaTableAdapter();
            this.tableAdapterManager = new Bai1.QL_SinhVienDataSetTableAdapters.TableAdapterManager();
            this.ketQuaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.maSoTextBox = new System.Windows.Forms.TextBox();
            this.maMHTextBox = new System.Windows.Forms.TextBox();
            this.diemTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.ketQuaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.ketQuaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            maSoLabel = new System.Windows.Forms.Label();
            maMHLabel = new System.Windows.Forms.Label();
            diemLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qL_SinhVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketQuaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketQuaBindingNavigator)).BeginInit();
            this.ketQuaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ketQuaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // qL_SinhVienDataSet
            // 
            this.qL_SinhVienDataSet.DataSetName = "QL_SinhVienDataSet";
            this.qL_SinhVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ketQuaBindingSource
            // 
            this.ketQuaBindingSource.DataMember = "KetQua";
            this.ketQuaBindingSource.DataSource = this.qL_SinhVienDataSet;
            // 
            // ketQuaTableAdapter
            // 
            this.ketQuaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KetQuaTableAdapter = this.ketQuaTableAdapter;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.MonTableAdapter = null;
            this.tableAdapterManager.SinhVienTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Bai1.QL_SinhVienDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ketQuaBindingNavigator
            // 
            this.ketQuaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ketQuaBindingNavigator.BindingSource = this.ketQuaBindingSource;
            this.ketQuaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ketQuaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ketQuaBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ketQuaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.ketQuaBindingNavigatorSaveItem});
            this.ketQuaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ketQuaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ketQuaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ketQuaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ketQuaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ketQuaBindingNavigator.Name = "ketQuaBindingNavigator";
            this.ketQuaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ketQuaBindingNavigator.Size = new System.Drawing.Size(665, 33);
            this.ketQuaBindingNavigator.TabIndex = 0;
            this.ketQuaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // maSoLabel
            // 
            maSoLabel.AutoSize = true;
            maSoLabel.Location = new System.Drawing.Point(12, 58);
            maSoLabel.Name = "maSoLabel";
            maSoLabel.Size = new System.Drawing.Size(59, 20);
            maSoLabel.TabIndex = 1;
            maSoLabel.Text = "Ma So:";
            // 
            // maSoTextBox
            // 
            this.maSoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ketQuaBindingSource, "MaSo", true));
            this.maSoTextBox.Location = new System.Drawing.Point(82, 55);
            this.maSoTextBox.Name = "maSoTextBox";
            this.maSoTextBox.Size = new System.Drawing.Size(100, 26);
            this.maSoTextBox.TabIndex = 2;
            // 
            // maMHLabel
            // 
            maMHLabel.AutoSize = true;
            maMHLabel.Location = new System.Drawing.Point(12, 90);
            maMHLabel.Name = "maMHLabel";
            maMHLabel.Size = new System.Drawing.Size(64, 20);
            maMHLabel.TabIndex = 3;
            maMHLabel.Text = "Ma MH:";
            // 
            // maMHTextBox
            // 
            this.maMHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ketQuaBindingSource, "MaMH", true));
            this.maMHTextBox.Location = new System.Drawing.Point(82, 87);
            this.maMHTextBox.Name = "maMHTextBox";
            this.maMHTextBox.Size = new System.Drawing.Size(100, 26);
            this.maMHTextBox.TabIndex = 4;
            // 
            // diemLabel
            // 
            diemLabel.AutoSize = true;
            diemLabel.Location = new System.Drawing.Point(12, 122);
            diemLabel.Name = "diemLabel";
            diemLabel.Size = new System.Drawing.Size(50, 20);
            diemLabel.TabIndex = 5;
            diemLabel.Text = "Diem:";
            // 
            // diemTextBox
            // 
            this.diemTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ketQuaBindingSource, "Diem", true));
            this.diemTextBox.Location = new System.Drawing.Point(82, 119);
            this.diemTextBox.Name = "diemTextBox";
            this.diemTextBox.Size = new System.Drawing.Size(100, 26);
            this.diemTextBox.TabIndex = 6;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // ketQuaBindingNavigatorSaveItem
            // 
            this.ketQuaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ketQuaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ketQuaBindingNavigatorSaveItem.Image")));
            this.ketQuaBindingNavigatorSaveItem.Name = "ketQuaBindingNavigatorSaveItem";
            this.ketQuaBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.ketQuaBindingNavigatorSaveItem.Text = "Save Data";
            this.ketQuaBindingNavigatorSaveItem.Click += new System.EventHandler(this.ketQuaBindingNavigatorSaveItem_Click);
            // 
            // ketQuaDataGridView
            // 
            this.ketQuaDataGridView.AutoGenerateColumns = false;
            this.ketQuaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ketQuaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.ketQuaDataGridView.DataSource = this.ketQuaBindingSource;
            this.ketQuaDataGridView.Location = new System.Drawing.Point(12, 162);
            this.ketQuaDataGridView.Name = "ketQuaDataGridView";
            this.ketQuaDataGridView.RowHeadersWidth = 62;
            this.ketQuaDataGridView.RowTemplate.Height = 28;
            this.ketQuaDataGridView.Size = new System.Drawing.Size(606, 220);
            this.ketQuaDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaSo";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaSo";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MaMH";
            this.dataGridViewTextBoxColumn2.HeaderText = "MaMH";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Diem";
            this.dataGridViewTextBoxColumn3.HeaderText = "Diem";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // frmNhapDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 409);
            this.Controls.Add(this.ketQuaDataGridView);
            this.Controls.Add(maSoLabel);
            this.Controls.Add(this.maSoTextBox);
            this.Controls.Add(maMHLabel);
            this.Controls.Add(this.maMHTextBox);
            this.Controls.Add(diemLabel);
            this.Controls.Add(this.diemTextBox);
            this.Controls.Add(this.ketQuaBindingNavigator);
            this.Name = "frmNhapDiem";
            this.Text = "frmNhapDiem";
            this.Load += new System.EventHandler(this.frmNhapDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qL_SinhVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketQuaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketQuaBindingNavigator)).EndInit();
            this.ketQuaBindingNavigator.ResumeLayout(false);
            this.ketQuaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ketQuaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QL_SinhVienDataSet qL_SinhVienDataSet;
        private System.Windows.Forms.BindingSource ketQuaBindingSource;
        private QL_SinhVienDataSetTableAdapters.KetQuaTableAdapter ketQuaTableAdapter;
        private QL_SinhVienDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ketQuaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton ketQuaBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox maSoTextBox;
        private System.Windows.Forms.TextBox maMHTextBox;
        private System.Windows.Forms.TextBox diemTextBox;
        private System.Windows.Forms.DataGridView ketQuaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}