namespace Student.Record.Manager
{
    partial class StudentListControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            emptyLabel = new MaterialSkin.Controls.MaterialLabel();
            addButton = new MaterialSkin.Controls.MaterialButton();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            studentList = new MaterialSkin.Controls.MaterialListView();
            columnHeader6 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(emptyLabel);
            panel1.Controls.Add(addButton);
            panel1.Controls.Add(materialLabel1);
            panel1.Controls.Add(studentList);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(794, 633);
            panel1.TabIndex = 0;
            // 
            // emptyLabel
            // 
            emptyLabel.BorderStyle = BorderStyle.FixedSingle;
            emptyLabel.Depth = 0;
            emptyLabel.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            emptyLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            emptyLabel.Location = new Point(187, 177);
            emptyLabel.MouseState = MaterialSkin.MouseState.HOVER;
            emptyLabel.Name = "emptyLabel";
            emptyLabel.Size = new Size(385, 56);
            emptyLabel.TabIndex = 5;
            emptyLabel.Text = "Student list goes here (Currently empty)";
            emptyLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // addButton
            // 
            addButton.AutoSize = false;
            addButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            addButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            addButton.Depth = 0;
            addButton.HighEmphasis = true;
            addButton.Icon = null;
            addButton.Location = new Point(632, 11);
            addButton.Margin = new Padding(4, 6, 4, 6);
            addButton.MouseState = MaterialSkin.MouseState.HOVER;
            addButton.Name = "addButton";
            addButton.NoAccentTextColor = Color.Empty;
            addButton.Padding = new Padding(6, 0, 6, 0);
            addButton.Size = new Size(158, 36);
            addButton.TabIndex = 4;
            addButton.Text = "Add student";
            addButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            addButton.UseAccentColor = false;
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            materialLabel1.Location = new Point(3, 11);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(136, 41);
            materialLabel1.TabIndex = 3;
            materialLabel1.Text = "Students";
            // 
            // studentList
            // 
            studentList.AutoSizeTable = false;
            studentList.BackColor = Color.FromArgb(255, 255, 255);
            studentList.BorderStyle = BorderStyle.None;
            studentList.Columns.AddRange(new ColumnHeader[] { columnHeader6, columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            studentList.Depth = 0;
            studentList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            studentList.FullRowSelect = true;
            studentList.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            studentList.Location = new Point(3, 62);
            studentList.MinimumSize = new Size(200, 100);
            studentList.MouseLocation = new Point(-1, -1);
            studentList.MouseState = MaterialSkin.MouseState.OUT;
            studentList.MultiSelect = false;
            studentList.Name = "studentList";
            studentList.OwnerDraw = true;
            studentList.Size = new Size(788, 568);
            studentList.TabIndex = 1;
            studentList.TileSize = new Size(1, 1);
            studentList.UseCompatibleStateImageBehavior = false;
            studentList.View = View.Details;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "#";
            columnHeader6.Width = 40;
            // 
            // columnHeader1
            // 
            columnHeader1.Tag = "Firstname";
            columnHeader1.Text = "Firstname";
            columnHeader1.Width = 145;
            // 
            // columnHeader2
            // 
            columnHeader2.Tag = "Lastname";
            columnHeader2.Text = "Lastname";
            columnHeader2.Width = 145;
            // 
            // columnHeader3
            // 
            columnHeader3.Tag = "Email";
            columnHeader3.Text = "Email";
            columnHeader3.Width = 165;
            // 
            // columnHeader4
            // 
            columnHeader4.Tag = "IsActive";
            columnHeader4.Text = "Enrollment status";
            columnHeader4.Width = 145;
            // 
            // columnHeader5
            // 
            columnHeader5.Tag = "AdmissionDate";
            columnHeader5.Text = "Admission date";
            columnHeader5.Width = 145;
            // 
            // StudentListControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(panel1);
            Name = "StudentListControl";
            Size = new Size(794, 633);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private MaterialSkin.Controls.MaterialListView studentList;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton addButton;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private MaterialSkin.Controls.MaterialLabel emptyLabel;
    }
}
