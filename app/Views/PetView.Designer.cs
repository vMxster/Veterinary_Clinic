namespace Veterinary_Clinic.Views
{
    partial class PetView
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
            panel1 = new Panel();
            buttonClose = new Button();
            tabControl1 = new TabControl();
            tabPagePetList = new TabPage();
            dataGridView1 = new DataGridView();
            buttonDelete = new Button();
            buttonEdit = new Button();
            buttonAdd = new Button();
            buttonSearch = new Button();
            textSearch = new TextBox();
            label2 = new Label();
            tabPagePetDetail = new TabPage();
            textPetType = new TextBox();
            textPetColour = new TextBox();
            textPetName = new TextBox();
            textPetId = new TextBox();
            buttonCancel = new Button();
            buttonSave = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPagePetList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPagePetDetail.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(38, 25);
            label1.Name = "label1";
            label1.Size = new Size(54, 28);
            label1.TabIndex = 0;
            label1.Text = "PETS";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(buttonClose);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 76);
            panel1.TabIndex = 1;
            // 
            // buttonClose
            // 
            buttonClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonClose.Font = new Font("Segoe UI", 12F);
            buttonClose.Location = new Point(748, 12);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(40, 40);
            buttonClose.TabIndex = 1;
            buttonClose.Text = "X";
            buttonClose.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPagePetList);
            tabControl1.Controls.Add(tabPagePetDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 76);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 374);
            tabControl1.TabIndex = 2;
            // 
            // tabPagePetList
            // 
            tabPagePetList.BackColor = Color.White;
            tabPagePetList.Controls.Add(dataGridView1);
            tabPagePetList.Controls.Add(buttonDelete);
            tabPagePetList.Controls.Add(buttonEdit);
            tabPagePetList.Controls.Add(buttonAdd);
            tabPagePetList.Controls.Add(buttonSearch);
            tabPagePetList.Controls.Add(textSearch);
            tabPagePetList.Controls.Add(label2);
            tabPagePetList.Location = new Point(4, 24);
            tabPagePetList.Name = "tabPagePetList";
            tabPagePetList.Padding = new Padding(3);
            tabPagePetList.Size = new Size(792, 346);
            tabPagePetList.TabIndex = 0;
            tabPagePetList.Text = "Pet List";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(34, 63);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(629, 275);
            dataGridView1.TabIndex = 6;
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDelete.Location = new Point(669, 121);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 5;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            buttonEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonEdit.Location = new Point(669, 92);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(75, 23);
            buttonEdit.TabIndex = 4;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            buttonAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAdd.Location = new Point(669, 63);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 3;
            buttonAdd.Text = "Add new";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            buttonSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSearch.Location = new Point(588, 34);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(75, 23);
            buttonSearch.TabIndex = 2;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            // 
            // textSearch
            // 
            textSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textSearch.Location = new Point(34, 34);
            textSearch.Name = "textSearch";
            textSearch.Size = new Size(548, 23);
            textSearch.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 16);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 0;
            label2.Text = "Search Pet:";
            // 
            // tabPagePetDetail
            // 
            tabPagePetDetail.Controls.Add(textPetType);
            tabPagePetDetail.Controls.Add(textPetColour);
            tabPagePetDetail.Controls.Add(textPetName);
            tabPagePetDetail.Controls.Add(textPetId);
            tabPagePetDetail.Controls.Add(buttonCancel);
            tabPagePetDetail.Controls.Add(buttonSave);
            tabPagePetDetail.Controls.Add(label6);
            tabPagePetDetail.Controls.Add(label5);
            tabPagePetDetail.Controls.Add(label4);
            tabPagePetDetail.Controls.Add(label3);
            tabPagePetDetail.Location = new Point(4, 24);
            tabPagePetDetail.Name = "tabPagePetDetail";
            tabPagePetDetail.Padding = new Padding(3);
            tabPagePetDetail.Size = new Size(792, 346);
            tabPagePetDetail.TabIndex = 1;
            tabPagePetDetail.Text = "Pet Detail";
            tabPagePetDetail.UseVisualStyleBackColor = true;
            // 
            // textPetType
            // 
            textPetType.Location = new Point(260, 129);
            textPetType.Name = "textPetType";
            textPetType.Size = new Size(149, 23);
            textPetType.TabIndex = 9;
            // 
            // textPetColour
            // 
            textPetColour.Location = new Point(51, 198);
            textPetColour.Name = "textPetColour";
            textPetColour.Size = new Size(358, 23);
            textPetColour.TabIndex = 8;
            // 
            // textPetName
            // 
            textPetName.Location = new Point(51, 129);
            textPetName.Name = "textPetName";
            textPetName.Size = new Size(149, 23);
            textPetName.TabIndex = 7;
            // 
            // textPetId
            // 
            textPetId.Location = new Point(51, 57);
            textPetId.Name = "textPetId";
            textPetId.ReadOnly = true;
            textPetId.Size = new Size(149, 23);
            textPetId.TabIndex = 6;
            textPetId.Text = "0";
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(228, 239);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(176, 30);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(51, 239);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(176, 30);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(260, 111);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 3;
            label6.Text = "Pet Type:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 180);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 2;
            label5.Text = "Pet Colour:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 111);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 1;
            label4.Text = "Pet Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 39);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 0;
            label3.Text = "Pet ID:";
            // 
            // PetView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "PetView";
            Text = "PetView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPagePetList.ResumeLayout(false);
            tabPagePetList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPagePetDetail.ResumeLayout(false);
            tabPagePetDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPagePetList;
        private Button buttonDelete;
        private Button buttonEdit;
        private Button buttonAdd;
        private Button buttonSearch;
        private TextBox textSearch;
        private Label label2;
        private TabPage tabPagePetDetail;
        private DataGridView dataGridView1;
        private TextBox textPetType;
        private TextBox textPetColour;
        private TextBox textPetName;
        private TextBox textPetId;
        private Button buttonCancel;
        private Button buttonSave;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button buttonClose;
    }
}