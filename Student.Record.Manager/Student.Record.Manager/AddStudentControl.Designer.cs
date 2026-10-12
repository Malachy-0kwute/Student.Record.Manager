namespace Student.Record.Manager
{
    partial class AddStudentControl
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
            admissionError = new Label();
            addressError = new Label();
            phoneError = new Label();
            emailError = new Label();
            lastNameError = new Label();
            firstNameError = new Label();
            cancleButton = new MaterialSkin.Controls.MaterialButton();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            createRecordBtn = new MaterialSkin.Controls.MaterialButton();
            address = new MaterialSkin.Controls.MaterialTextBox2();
            credit = new MaterialSkin.Controls.MaterialTextBox2();
            admissionDate = new MaterialSkin.Controls.MaterialTextBox2();
            courses = new MaterialSkin.Controls.MaterialCheckedListBox();
            lastName = new MaterialSkin.Controls.MaterialTextBox2();
            isActive = new MaterialSkin.Controls.MaterialSwitch();
            firstName = new MaterialSkin.Controls.MaterialTextBox2();
            phoneNumber = new MaterialSkin.Controls.MaterialTextBox2();
            gpa = new MaterialSkin.Controls.MaterialComboBox();
            email = new MaterialSkin.Controls.MaterialTextBox2();
            creditError = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(creditError);
            panel1.Controls.Add(admissionError);
            panel1.Controls.Add(addressError);
            panel1.Controls.Add(phoneError);
            panel1.Controls.Add(emailError);
            panel1.Controls.Add(lastNameError);
            panel1.Controls.Add(firstNameError);
            panel1.Controls.Add(cancleButton);
            panel1.Controls.Add(materialLabel1);
            panel1.Controls.Add(createRecordBtn);
            panel1.Controls.Add(address);
            panel1.Controls.Add(credit);
            panel1.Controls.Add(admissionDate);
            panel1.Controls.Add(courses);
            panel1.Controls.Add(lastName);
            panel1.Controls.Add(isActive);
            panel1.Controls.Add(firstName);
            panel1.Controls.Add(phoneNumber);
            panel1.Controls.Add(gpa);
            panel1.Controls.Add(email);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(794, 633);
            panel1.TabIndex = 0;
            // 
            // admissionError
            // 
            admissionError.AutoSize = true;
            admissionError.ForeColor = Color.OrangeRed;
            admissionError.Location = new Point(7, 276);
            admissionError.Name = "admissionError";
            admissionError.Size = new Size(32, 15);
            admissionError.TabIndex = 49;
            admissionError.Text = "error";
            admissionError.Visible = false;
            // 
            // addressError
            // 
            addressError.AutoSize = true;
            addressError.ForeColor = Color.OrangeRed;
            addressError.Location = new Point(7, 140);
            addressError.Name = "addressError";
            addressError.Size = new Size(32, 15);
            addressError.TabIndex = 48;
            addressError.Text = "error";
            addressError.Visible = false;
            // 
            // phoneError
            // 
            phoneError.AutoSize = true;
            phoneError.ForeColor = Color.OrangeRed;
            phoneError.Location = new Point(431, 71);
            phoneError.Name = "phoneError";
            phoneError.Size = new Size(32, 15);
            phoneError.TabIndex = 47;
            phoneError.Text = "error";
            phoneError.Visible = false;
            // 
            // emailError
            // 
            emailError.AutoSize = true;
            emailError.ForeColor = Color.OrangeRed;
            emailError.Location = new Point(7, 71);
            emailError.Name = "emailError";
            emailError.Size = new Size(32, 15);
            emailError.TabIndex = 46;
            emailError.Text = "error";
            emailError.Visible = false;
            // 
            // lastNameError
            // 
            lastNameError.AutoSize = true;
            lastNameError.ForeColor = Color.OrangeRed;
            lastNameError.Location = new Point(431, 3);
            lastNameError.Name = "lastNameError";
            lastNameError.Size = new Size(32, 15);
            lastNameError.TabIndex = 45;
            lastNameError.Text = "error";
            lastNameError.Visible = false;
            // 
            // firstNameError
            // 
            firstNameError.AutoSize = true;
            firstNameError.ForeColor = Color.OrangeRed;
            firstNameError.Location = new Point(7, 3);
            firstNameError.Name = "firstNameError";
            firstNameError.Size = new Size(32, 15);
            firstNameError.TabIndex = 44;
            firstNameError.Text = "error";
            firstNameError.Visible = false;
            // 
            // cancleButton
            // 
            cancleButton.AutoSize = false;
            cancleButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cancleButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            cancleButton.Depth = 0;
            cancleButton.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancleButton.HighEmphasis = true;
            cancleButton.Icon = null;
            cancleButton.Location = new Point(435, 565);
            cancleButton.Margin = new Padding(4, 6, 4, 6);
            cancleButton.MouseState = MaterialSkin.MouseState.HOVER;
            cancleButton.Name = "cancleButton";
            cancleButton.NoAccentTextColor = Color.Empty;
            cancleButton.Size = new Size(200, 50);
            cancleButton.TabIndex = 43;
            cancleButton.Text = "Cancle";
            cancleButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            cancleButton.UseAccentColor = false;
            cancleButton.UseVisualStyleBackColor = true;
            cancleButton.Click += cancleButton_Click;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(10, 366);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(105, 19);
            materialLabel1.TabIndex = 36;
            materialLabel1.Text = "Select Courses";
            // 
            // createRecordBtn
            // 
            createRecordBtn.AutoSize = false;
            createRecordBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            createRecordBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            createRecordBtn.Depth = 0;
            createRecordBtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createRecordBtn.HighEmphasis = true;
            createRecordBtn.Icon = null;
            createRecordBtn.Location = new Point(167, 565);
            createRecordBtn.Margin = new Padding(4, 6, 4, 6);
            createRecordBtn.MouseState = MaterialSkin.MouseState.HOVER;
            createRecordBtn.Name = "createRecordBtn";
            createRecordBtn.NoAccentTextColor = Color.Empty;
            createRecordBtn.Size = new Size(200, 50);
            createRecordBtn.TabIndex = 35;
            createRecordBtn.Text = "Create record";
            createRecordBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            createRecordBtn.UseAccentColor = false;
            createRecordBtn.UseVisualStyleBackColor = true;
            createRecordBtn.Click += materialButton1_Click;
            // 
            // address
            // 
            address.AnimateReadOnly = false;
            address.BackgroundImageLayout = ImageLayout.None;
            address.CharacterCasing = CharacterCasing.Normal;
            address.Depth = 0;
            address.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            address.HideSelection = true;
            address.Hint = "Address";
            address.LeadingIcon = null;
            address.Location = new Point(4, 155);
            address.MaxLength = 32767;
            address.MouseState = MaterialSkin.MouseState.OUT;
            address.Name = "address";
            address.PasswordChar = '\0';
            address.PrefixSuffixText = null;
            address.ReadOnly = false;
            address.RightToLeft = RightToLeft.No;
            address.SelectedText = "";
            address.SelectionLength = 0;
            address.SelectionStart = 0;
            address.ShortcutsEnabled = true;
            address.Size = new Size(787, 48);
            address.TabIndex = 29;
            address.TabStop = false;
            address.TextAlign = HorizontalAlignment.Left;
            address.TrailingIcon = null;
            address.UseSystemPasswordChar = false;
            // 
            // credit
            // 
            credit.AnimateReadOnly = false;
            credit.BackgroundImageLayout = ImageLayout.None;
            credit.CharacterCasing = CharacterCasing.Normal;
            credit.Depth = 0;
            credit.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            credit.HideSelection = true;
            credit.Hint = "Credit";
            credit.LeadingIcon = null;
            credit.Location = new Point(7, 223);
            credit.MaxLength = 32767;
            credit.MouseState = MaterialSkin.MouseState.OUT;
            credit.Name = "credit";
            credit.PasswordChar = '\0';
            credit.PrefixSuffixText = null;
            credit.ReadOnly = false;
            credit.RightToLeft = RightToLeft.No;
            credit.SelectedText = "";
            credit.SelectionLength = 0;
            credit.SelectionStart = 0;
            credit.ShortcutsEnabled = true;
            credit.Size = new Size(360, 48);
            credit.TabIndex = 30;
            credit.TabStop = false;
            credit.TextAlign = HorizontalAlignment.Left;
            credit.TrailingIcon = null;
            credit.UseSystemPasswordChar = false;
            // 
            // admissionDate
            // 
            admissionDate.AnimateReadOnly = false;
            admissionDate.BackgroundImageLayout = ImageLayout.None;
            admissionDate.CharacterCasing = CharacterCasing.Normal;
            admissionDate.Depth = 0;
            admissionDate.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            admissionDate.HideSelection = true;
            admissionDate.Hint = "Admission date";
            admissionDate.LeadingIcon = null;
            admissionDate.Location = new Point(7, 294);
            admissionDate.MaxLength = 32767;
            admissionDate.MouseState = MaterialSkin.MouseState.OUT;
            admissionDate.Name = "admissionDate";
            admissionDate.PasswordChar = '\0';
            admissionDate.PrefixSuffixText = null;
            admissionDate.ReadOnly = false;
            admissionDate.RightToLeft = RightToLeft.No;
            admissionDate.SelectedText = "";
            admissionDate.SelectionLength = 0;
            admissionDate.SelectionStart = 0;
            admissionDate.ShortcutsEnabled = true;
            admissionDate.Size = new Size(360, 48);
            admissionDate.TabIndex = 32;
            admissionDate.TabStop = false;
            admissionDate.TextAlign = HorizontalAlignment.Left;
            admissionDate.TrailingIcon = null;
            admissionDate.UseSystemPasswordChar = false;
            // 
            // courses
            // 
            courses.AutoScroll = true;
            courses.BackColor = SystemColors.Control;
            courses.BorderStyle = BorderStyle.FixedSingle;
            courses.Depth = 0;
            courses.Location = new Point(7, 387);
            courses.MouseState = MaterialSkin.MouseState.HOVER;
            courses.Name = "courses";
            courses.Padding = new Padding(10, 5, 10, 5);
            courses.Size = new Size(784, 160);
            courses.Striped = true;
            courses.StripeDarkColor = Color.Transparent;
            courses.TabIndex = 34;
            // 
            // lastName
            // 
            lastName.AnimateReadOnly = false;
            lastName.BackgroundImageLayout = ImageLayout.None;
            lastName.CharacterCasing = CharacterCasing.Normal;
            lastName.Depth = 0;
            lastName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            lastName.HideSelection = true;
            lastName.Hint = "Last name";
            lastName.LeadingIcon = null;
            lastName.Location = new Point(431, 20);
            lastName.MaxLength = 32767;
            lastName.MouseState = MaterialSkin.MouseState.OUT;
            lastName.Name = "lastName";
            lastName.PasswordChar = '\0';
            lastName.PrefixSuffixText = null;
            lastName.ReadOnly = false;
            lastName.RightToLeft = RightToLeft.No;
            lastName.SelectedText = "";
            lastName.SelectionLength = 0;
            lastName.SelectionStart = 0;
            lastName.ShortcutsEnabled = true;
            lastName.Size = new Size(360, 48);
            lastName.TabIndex = 26;
            lastName.TabStop = false;
            lastName.TextAlign = HorizontalAlignment.Left;
            lastName.TrailingIcon = null;
            lastName.UseSystemPasswordChar = false;
            // 
            // isActive
            // 
            isActive.AutoSize = true;
            isActive.Depth = 0;
            isActive.Location = new Point(435, 294);
            isActive.Margin = new Padding(0);
            isActive.MouseLocation = new Point(-1, -1);
            isActive.MouseState = MaterialSkin.MouseState.HOVER;
            isActive.Name = "isActive";
            isActive.Ripple = true;
            isActive.Size = new Size(131, 37);
            isActive.TabIndex = 33;
            isActive.Text = "Is Enrolled";
            isActive.UseVisualStyleBackColor = true;
            // 
            // firstName
            // 
            firstName.AnimateReadOnly = false;
            firstName.BackgroundImageLayout = ImageLayout.None;
            firstName.CharacterCasing = CharacterCasing.Normal;
            firstName.Depth = 0;
            firstName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            firstName.HideSelection = true;
            firstName.Hint = "First name";
            firstName.LeadingIcon = null;
            firstName.Location = new Point(7, 20);
            firstName.MaxLength = 32767;
            firstName.MouseState = MaterialSkin.MouseState.OUT;
            firstName.Name = "firstName";
            firstName.PasswordChar = '\0';
            firstName.PrefixSuffixText = null;
            firstName.ReadOnly = false;
            firstName.RightToLeft = RightToLeft.No;
            firstName.SelectedText = "";
            firstName.SelectionLength = 0;
            firstName.SelectionStart = 0;
            firstName.ShortcutsEnabled = true;
            firstName.Size = new Size(360, 48);
            firstName.TabIndex = 25;
            firstName.TabStop = false;
            firstName.Tag = "";
            firstName.TextAlign = HorizontalAlignment.Left;
            firstName.TrailingIcon = null;
            firstName.UseSystemPasswordChar = false;
            // 
            // phoneNumber
            // 
            phoneNumber.AnimateReadOnly = false;
            phoneNumber.BackgroundImageLayout = ImageLayout.None;
            phoneNumber.CharacterCasing = CharacterCasing.Normal;
            phoneNumber.Depth = 0;
            phoneNumber.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            phoneNumber.HideSelection = true;
            phoneNumber.Hint = "Phone number";
            phoneNumber.LeadingIcon = null;
            phoneNumber.Location = new Point(431, 89);
            phoneNumber.MaxLength = 32767;
            phoneNumber.MouseState = MaterialSkin.MouseState.OUT;
            phoneNumber.Name = "phoneNumber";
            phoneNumber.PasswordChar = '\0';
            phoneNumber.PrefixSuffixText = null;
            phoneNumber.ReadOnly = false;
            phoneNumber.RightToLeft = RightToLeft.No;
            phoneNumber.SelectedText = "";
            phoneNumber.SelectionLength = 0;
            phoneNumber.SelectionStart = 0;
            phoneNumber.ShortcutsEnabled = true;
            phoneNumber.Size = new Size(360, 48);
            phoneNumber.TabIndex = 28;
            phoneNumber.TabStop = false;
            phoneNumber.TextAlign = HorizontalAlignment.Left;
            phoneNumber.TrailingIcon = null;
            phoneNumber.UseSystemPasswordChar = false;
            // 
            // gpa
            // 
            gpa.AutoResize = false;
            gpa.BackColor = Color.FromArgb(255, 255, 255);
            gpa.Depth = 0;
            gpa.DrawMode = DrawMode.OwnerDrawVariable;
            gpa.DropDownHeight = 174;
            gpa.DropDownStyle = ComboBoxStyle.DropDownList;
            gpa.DropDownWidth = 121;
            gpa.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            gpa.ForeColor = Color.FromArgb(222, 0, 0, 0);
            gpa.FormattingEnabled = true;
            gpa.Hint = "GPA";
            gpa.IntegralHeight = false;
            gpa.ItemHeight = 43;
            gpa.Items.AddRange(new object[] { "0.0", "1.0", "2.0", "3.0", "4.0" });
            gpa.Location = new Point(431, 225);
            gpa.MaxDropDownItems = 4;
            gpa.MouseState = MaterialSkin.MouseState.OUT;
            gpa.Name = "gpa";
            gpa.Size = new Size(360, 49);
            gpa.StartIndex = 0;
            gpa.TabIndex = 31;
            gpa.Tag = "";
            // 
            // email
            // 
            email.AnimateReadOnly = false;
            email.BackgroundImageLayout = ImageLayout.None;
            email.CharacterCasing = CharacterCasing.Normal;
            email.Depth = 0;
            email.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            email.HideSelection = true;
            email.Hint = "Email";
            email.LeadingIcon = null;
            email.Location = new Point(7, 89);
            email.MaxLength = 32767;
            email.MouseState = MaterialSkin.MouseState.OUT;
            email.Name = "email";
            email.PasswordChar = '\0';
            email.PrefixSuffixText = null;
            email.ReadOnly = false;
            email.RightToLeft = RightToLeft.No;
            email.SelectedText = "";
            email.SelectionLength = 0;
            email.SelectionStart = 0;
            email.ShortcutsEnabled = true;
            email.Size = new Size(360, 48);
            email.TabIndex = 27;
            email.TabStop = false;
            email.TextAlign = HorizontalAlignment.Left;
            email.TrailingIcon = null;
            email.UseSystemPasswordChar = false;
            // 
            // creditError
            // 
            creditError.AutoSize = true;
            creditError.ForeColor = Color.OrangeRed;
            creditError.Location = new Point(7, 205);
            creditError.Name = "creditError";
            creditError.Size = new Size(32, 15);
            creditError.TabIndex = 50;
            creditError.Text = "error";
            creditError.Visible = false;
            // 
            // AddStudentControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "AddStudentControl";
            Size = new Size(794, 633);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton createRecordBtn;
        private MaterialSkin.Controls.MaterialTextBox2 address;
        private MaterialSkin.Controls.MaterialTextBox2 credit;
        private MaterialSkin.Controls.MaterialTextBox2 admissionDate;
        private MaterialSkin.Controls.MaterialCheckedListBox courses;
        private MaterialSkin.Controls.MaterialTextBox2 lastName;
        private MaterialSkin.Controls.MaterialSwitch isActive;
        private MaterialSkin.Controls.MaterialTextBox2 firstName;
        private MaterialSkin.Controls.MaterialTextBox2 phoneNumber;
        private MaterialSkin.Controls.MaterialComboBox gpa;
        private MaterialSkin.Controls.MaterialTextBox2 email;
        private MaterialSkin.Controls.MaterialButton cancleButton;
        private Label firstNameError;
        private Label admissionError;
        private Label addressError;
        private Label phoneError;
        private Label emailError;
        private Label lastNameError;
        private Label creditError;
    }
}
