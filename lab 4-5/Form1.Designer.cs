namespace lab_4_5
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            TabControl_MainTabs = new TabControl();
            Tab_Authorization = new TabPage();
            Tab_SignIn_TextBox_ClientPatronymic = new MaterialSkin.Controls.MaterialTextBox();
            Tab_SignIn_TextBox_ClientPassword = new MaterialSkin.Controls.MaterialTextBox();
            Tab_SignIn_TextBox_ClientSurname = new MaterialSkin.Controls.MaterialTextBox();
            Tab_SignIn_TextBox_ClientName = new MaterialSkin.Controls.MaterialTextBox();
            Tab_Client_Button_SignIn = new MaterialSkin.Controls.MaterialButton();
            Tab_SignUp = new TabPage();
            Tab_SignUp_TextBox_ClientPasswordСonfirmation = new MaterialSkin.Controls.MaterialTextBox();
            Tab_SignUp_TextBox_ClientPassword = new MaterialSkin.Controls.MaterialTextBox();
            Tab_SignUp_ComboBox_ClientStatus = new MaterialSkin.Controls.MaterialComboBox();
            Tab_SignUp_TextBox_ClientPhoneNumber = new MaterialSkin.Controls.MaterialTextBox();
            Tab_SignUp_TextBox_ClientPatronymic = new MaterialSkin.Controls.MaterialTextBox();
            Tab_SignUp_TextBox_ClientSurname = new MaterialSkin.Controls.MaterialTextBox();
            Tab_SignUp_TextBox_ClientName = new MaterialSkin.Controls.MaterialTextBox();
            Tab_SignUp_Button_SignUp = new MaterialSkin.Controls.MaterialButton();
            Tab_Aministrator = new TabPage();
            Tab_Administrator_Button_MoveToSignIn = new MaterialSkin.Controls.MaterialButton();
            Tab_Administrator_Panel_RequesList = new Panel();
            Tab_Administrator_Label_ClientPhoneNumber = new MaterialSkin.Controls.MaterialLabel();
            Tab_Administrator_LabelText_ClientPhoneNumber = new MaterialSkin.Controls.MaterialLabel();
            Tab_Administrator_Button_PrevRequest = new MaterialSkin.Controls.MaterialButton();
            Tab_Administrator_Button_NextRequest = new MaterialSkin.Controls.MaterialButton();
            Tab_Administrator_Button_DeclineRequest = new MaterialSkin.Controls.MaterialButton();
            Tab_Administrator_Button_ConfirmRequest = new MaterialSkin.Controls.MaterialButton();
            Tab_Administrator_Label_RequestState = new MaterialSkin.Controls.MaterialLabel();
            Tab_Administrator_Label_StayTime = new MaterialSkin.Controls.MaterialLabel();
            Tab_Administrator_Label_ApartmentСlass = new MaterialSkin.Controls.MaterialLabel();
            Tab_Administrator_Label_SleepingPlacesNumber = new MaterialSkin.Controls.MaterialLabel();
            Tab_Administrator_Label_ClientPatronymic = new MaterialSkin.Controls.MaterialLabel();
            Tab_Administrator_Label_ClientSurname = new MaterialSkin.Controls.MaterialLabel();
            Tab_Administrator_Label_ClientName = new MaterialSkin.Controls.MaterialLabel();
            Tab_Administrator_LabelText_RequestState = new MaterialSkin.Controls.MaterialLabel();
            Tab_Administrator_LabelText_StayTime = new MaterialSkin.Controls.MaterialLabel();
            Tab_Administrator_LabelText_ApartmentСlass = new MaterialSkin.Controls.MaterialLabel();
            Tab_Administrator_LabelText_SleepingPlacesNumber = new MaterialSkin.Controls.MaterialLabel();
            Tab_Administrator_LabelText_ClientPatronymic = new MaterialSkin.Controls.MaterialLabel();
            Tab_Administrator_LabelText_ClientSurname = new MaterialSkin.Controls.MaterialLabel();
            Tab_Administrator_LabelText_ClientName = new MaterialSkin.Controls.MaterialLabel();
            label1 = new Label();
            Tab_Client = new TabPage();
            Tab_Client_Button_MoveToSignIn = new MaterialSkin.Controls.MaterialButton();
            Tab_Client_Button_MoveToRequest = new MaterialSkin.Controls.MaterialButton();
            Tab_Client_Panel_RequesForm = new Panel();
            Tab_Client_Label_ClientPhoneNumber = new MaterialSkin.Controls.MaterialLabel();
            Tab_Client_LabelText_ClientPhoneNumber = new MaterialSkin.Controls.MaterialLabel();
            Tab_Client_Button_Pay = new MaterialSkin.Controls.MaterialButton();
            Tab_Client_Label_RequestState = new MaterialSkin.Controls.MaterialLabel();
            Tab_Client_Label_StayTime = new MaterialSkin.Controls.MaterialLabel();
            Tab_Client_Label_ApartmentСlass = new MaterialSkin.Controls.MaterialLabel();
            Tab_Client_Label_SleepingPlacesNumber = new MaterialSkin.Controls.MaterialLabel();
            Tab_Client_Label_ClientPatronymic = new MaterialSkin.Controls.MaterialLabel();
            Tab_Client_Label_ClientSurname = new MaterialSkin.Controls.MaterialLabel();
            Tab_Client_Label_ClientName = new MaterialSkin.Controls.MaterialLabel();
            Tab_Client_LabelText_RequestState = new MaterialSkin.Controls.MaterialLabel();
            Tab_Client_LabelText_StayTime = new MaterialSkin.Controls.MaterialLabel();
            Tab_Client_LabelText_ApartmentСlass = new MaterialSkin.Controls.MaterialLabel();
            Tab_Client_LabelText_SleepingPlacesNumber = new MaterialSkin.Controls.MaterialLabel();
            Tab_Client_LabelText_ClientPatronymic = new MaterialSkin.Controls.MaterialLabel();
            Tab_Client_LabelText_ClientSurname = new MaterialSkin.Controls.MaterialLabel();
            Tab_Client_LabelText_ClientName = new MaterialSkin.Controls.MaterialLabel();
            label2 = new Label();
            Tab_Request = new TabPage();
            Tab_Request_Button_MoveToClient = new MaterialSkin.Controls.MaterialButton();
            Tab_Request_LabelText_StayTime = new MaterialSkin.Controls.MaterialLabel();
            Tab_Request_LabelText_Minutes = new Label();
            Tab_Request_LabelText_Hours = new Label();
            Tab_Request_LabelText_Days = new Label();
            Tab_Request_Label_MinutesCount = new MaterialSkin.Controls.MaterialLabel();
            Tab_Request_Label_HoursCount = new MaterialSkin.Controls.MaterialLabel();
            Tab_Request_Label_DaysCount = new MaterialSkin.Controls.MaterialLabel();
            Tab_Request_ComboBox_SleepingPlacesNumber = new MaterialSkin.Controls.MaterialComboBox();
            Tab_Request_ComboBox_ApartmentСlass = new MaterialSkin.Controls.MaterialComboBox();
            Tab_Request_Button_MinutesUp = new MaterialSkin.Controls.MaterialButton();
            Tab_Request_Button_MinutesDown = new MaterialSkin.Controls.MaterialButton();
            Tab_Request_Button_HoursUp = new MaterialSkin.Controls.MaterialButton();
            Tab_Request_Button_HoursDown = new MaterialSkin.Controls.MaterialButton();
            Tab_Request_Button_DaysDown = new MaterialSkin.Controls.MaterialButton();
            Tab_Request_Button_DaysUp = new MaterialSkin.Controls.MaterialButton();
            Tab_Request_Buttonn_SendRequest = new MaterialSkin.Controls.MaterialButton();
            tabPage1 = new TabPage();
            Tab_Trash_Button_IteratorFunc = new Button();
            Tab_Trash_Button_UniversalDelegate = new Button();
            Tab_Trash_Button_UniversalFunc2 = new Button();
            Tab_Trash_Button_UniversalFunc1 = new Button();
            Tab_Trash_Button_UniversalClassFromInterfaceFunc = new Button();
            Tab_Trash_Button_UniversalClassFunc = new Button();
            Tab_Trash_Button_LambdaExpression3 = new Button();
            Tab_Trash_Button_LambdaExpression2 = new Button();
            Tab_Trash_Button_LambdaExpression1 = new Button();
            Tab_Trash_Button_AnonymousFunction3 = new Button();
            Tab_Trash_Button_AnonymousFunction2 = new Button();
            Tab_Trash_Button_AnonymousFunction1 = new Button();
            Tab_Trash_Button_LINQ = new Button();
            TabControl_MainTabs.SuspendLayout();
            Tab_Authorization.SuspendLayout();
            Tab_SignUp.SuspendLayout();
            Tab_Aministrator.SuspendLayout();
            Tab_Administrator_Panel_RequesList.SuspendLayout();
            Tab_Client.SuspendLayout();
            Tab_Client_Panel_RequesForm.SuspendLayout();
            Tab_Request.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // TabControl_MainTabs
            // 
            TabControl_MainTabs.Controls.Add(Tab_Authorization);
            TabControl_MainTabs.Controls.Add(Tab_SignUp);
            TabControl_MainTabs.Controls.Add(Tab_Aministrator);
            TabControl_MainTabs.Controls.Add(Tab_Client);
            TabControl_MainTabs.Controls.Add(Tab_Request);
            TabControl_MainTabs.Controls.Add(tabPage1);
            TabControl_MainTabs.Location = new Point(-5, 77);
            TabControl_MainTabs.Margin = new Padding(4, 3, 4, 3);
            TabControl_MainTabs.Name = "TabControl_MainTabs";
            TabControl_MainTabs.SelectedIndex = 0;
            TabControl_MainTabs.Size = new Size(943, 447);
            TabControl_MainTabs.TabIndex = 0;
            TabControl_MainTabs.Selected += TabControl_MainTabs_Selected;
            // 
            // Tab_Authorization
            // 
            Tab_Authorization.BackColor = Color.FromArgb(50, 50, 50);
            Tab_Authorization.Controls.Add(Tab_SignIn_TextBox_ClientPatronymic);
            Tab_Authorization.Controls.Add(Tab_SignIn_TextBox_ClientPassword);
            Tab_Authorization.Controls.Add(Tab_SignIn_TextBox_ClientSurname);
            Tab_Authorization.Controls.Add(Tab_SignIn_TextBox_ClientName);
            Tab_Authorization.Controls.Add(Tab_Client_Button_SignIn);
            Tab_Authorization.Location = new Point(4, 24);
            Tab_Authorization.Margin = new Padding(4, 3, 4, 3);
            Tab_Authorization.Name = "Tab_Authorization";
            Tab_Authorization.Size = new Size(935, 419);
            Tab_Authorization.TabIndex = 4;
            Tab_Authorization.Text = "Авторизація";
            // 
            // Tab_SignIn_TextBox_ClientPatronymic
            // 
            Tab_SignIn_TextBox_ClientPatronymic.AnimateReadOnly = false;
            Tab_SignIn_TextBox_ClientPatronymic.BorderStyle = BorderStyle.None;
            Tab_SignIn_TextBox_ClientPatronymic.Depth = 0;
            Tab_SignIn_TextBox_ClientPatronymic.Font = new Font("Microsoft Sans Serif", 12F);
            Tab_SignIn_TextBox_ClientPatronymic.Hint = "По батькові";
            Tab_SignIn_TextBox_ClientPatronymic.LeadingIcon = null;
            Tab_SignIn_TextBox_ClientPatronymic.Location = new Point(470, 92);
            Tab_SignIn_TextBox_ClientPatronymic.Margin = new Padding(4, 3, 4, 3);
            Tab_SignIn_TextBox_ClientPatronymic.MaxLength = 50;
            Tab_SignIn_TextBox_ClientPatronymic.MouseState = MaterialSkin.MouseState.OUT;
            Tab_SignIn_TextBox_ClientPatronymic.Multiline = false;
            Tab_SignIn_TextBox_ClientPatronymic.Name = "Tab_SignIn_TextBox_ClientPatronymic";
            Tab_SignIn_TextBox_ClientPatronymic.Size = new Size(233, 50);
            Tab_SignIn_TextBox_ClientPatronymic.TabIndex = 16;
            Tab_SignIn_TextBox_ClientPatronymic.Text = "Олексійович";
            Tab_SignIn_TextBox_ClientPatronymic.TrailingIcon = null;
            // 
            // Tab_SignIn_TextBox_ClientPassword
            // 
            Tab_SignIn_TextBox_ClientPassword.AnimateReadOnly = false;
            Tab_SignIn_TextBox_ClientPassword.BorderStyle = BorderStyle.None;
            Tab_SignIn_TextBox_ClientPassword.Depth = 0;
            Tab_SignIn_TextBox_ClientPassword.Font = new Font("Microsoft Sans Serif", 12F);
            Tab_SignIn_TextBox_ClientPassword.Hint = "Пароль";
            Tab_SignIn_TextBox_ClientPassword.LeadingIcon = null;
            Tab_SignIn_TextBox_ClientPassword.Location = new Point(470, 156);
            Tab_SignIn_TextBox_ClientPassword.Margin = new Padding(4, 3, 4, 3);
            Tab_SignIn_TextBox_ClientPassword.MaxLength = 50;
            Tab_SignIn_TextBox_ClientPassword.MouseState = MaterialSkin.MouseState.OUT;
            Tab_SignIn_TextBox_ClientPassword.Multiline = false;
            Tab_SignIn_TextBox_ClientPassword.Name = "Tab_SignIn_TextBox_ClientPassword";
            Tab_SignIn_TextBox_ClientPassword.Size = new Size(233, 50);
            Tab_SignIn_TextBox_ClientPassword.TabIndex = 15;
            Tab_SignIn_TextBox_ClientPassword.Text = "Password";
            Tab_SignIn_TextBox_ClientPassword.TrailingIcon = null;
            // 
            // Tab_SignIn_TextBox_ClientSurname
            // 
            Tab_SignIn_TextBox_ClientSurname.AnimateReadOnly = false;
            Tab_SignIn_TextBox_ClientSurname.BorderStyle = BorderStyle.None;
            Tab_SignIn_TextBox_ClientSurname.Depth = 0;
            Tab_SignIn_TextBox_ClientSurname.Font = new Font("Microsoft Sans Serif", 12F);
            Tab_SignIn_TextBox_ClientSurname.Hint = "Прізвище";
            Tab_SignIn_TextBox_ClientSurname.LeadingIcon = null;
            Tab_SignIn_TextBox_ClientSurname.Location = new Point(230, 156);
            Tab_SignIn_TextBox_ClientSurname.Margin = new Padding(4, 3, 4, 3);
            Tab_SignIn_TextBox_ClientSurname.MaxLength = 50;
            Tab_SignIn_TextBox_ClientSurname.MouseState = MaterialSkin.MouseState.OUT;
            Tab_SignIn_TextBox_ClientSurname.Multiline = false;
            Tab_SignIn_TextBox_ClientSurname.Name = "Tab_SignIn_TextBox_ClientSurname";
            Tab_SignIn_TextBox_ClientSurname.Size = new Size(233, 50);
            Tab_SignIn_TextBox_ClientSurname.TabIndex = 14;
            Tab_SignIn_TextBox_ClientSurname.Text = "Шуневич";
            Tab_SignIn_TextBox_ClientSurname.TrailingIcon = null;
            // 
            // Tab_SignIn_TextBox_ClientName
            // 
            Tab_SignIn_TextBox_ClientName.AnimateReadOnly = false;
            Tab_SignIn_TextBox_ClientName.BorderStyle = BorderStyle.None;
            Tab_SignIn_TextBox_ClientName.Depth = 0;
            Tab_SignIn_TextBox_ClientName.Font = new Font("Microsoft Sans Serif", 12F);
            Tab_SignIn_TextBox_ClientName.Hint = "Ім'я";
            Tab_SignIn_TextBox_ClientName.LeadingIcon = null;
            Tab_SignIn_TextBox_ClientName.Location = new Point(230, 92);
            Tab_SignIn_TextBox_ClientName.Margin = new Padding(4, 3, 4, 3);
            Tab_SignIn_TextBox_ClientName.MaxLength = 50;
            Tab_SignIn_TextBox_ClientName.MouseState = MaterialSkin.MouseState.OUT;
            Tab_SignIn_TextBox_ClientName.Multiline = false;
            Tab_SignIn_TextBox_ClientName.Name = "Tab_SignIn_TextBox_ClientName";
            Tab_SignIn_TextBox_ClientName.Size = new Size(233, 50);
            Tab_SignIn_TextBox_ClientName.TabIndex = 13;
            Tab_SignIn_TextBox_ClientName.Text = "Максим";
            Tab_SignIn_TextBox_ClientName.TrailingIcon = null;
            // 
            // Tab_Client_Button_SignIn
            // 
            Tab_Client_Button_SignIn.AutoSize = false;
            Tab_Client_Button_SignIn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Tab_Client_Button_SignIn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            Tab_Client_Button_SignIn.Depth = 0;
            Tab_Client_Button_SignIn.HighEmphasis = true;
            Tab_Client_Button_SignIn.Icon = (Image)resources.GetObject("Tab_Client_Button_SignIn.Icon");
            Tab_Client_Button_SignIn.Location = new Point(358, 285);
            Tab_Client_Button_SignIn.Margin = new Padding(5, 7, 5, 7);
            Tab_Client_Button_SignIn.MouseState = MaterialSkin.MouseState.HOVER;
            Tab_Client_Button_SignIn.Name = "Tab_Client_Button_SignIn";
            Tab_Client_Button_SignIn.NoAccentTextColor = Color.Empty;
            Tab_Client_Button_SignIn.Size = new Size(210, 42);
            Tab_Client_Button_SignIn.TabIndex = 12;
            Tab_Client_Button_SignIn.Text = "Атворизуватися";
            Tab_Client_Button_SignIn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            Tab_Client_Button_SignIn.UseAccentColor = false;
            Tab_Client_Button_SignIn.UseVisualStyleBackColor = true;
            Tab_Client_Button_SignIn.Click += Tab_Client_Button_SignIn_Click;
            // 
            // Tab_SignUp
            // 
            Tab_SignUp.BackColor = Color.FromArgb(50, 50, 50);
            Tab_SignUp.Controls.Add(Tab_SignUp_TextBox_ClientPasswordСonfirmation);
            Tab_SignUp.Controls.Add(Tab_SignUp_TextBox_ClientPassword);
            Tab_SignUp.Controls.Add(Tab_SignUp_ComboBox_ClientStatus);
            Tab_SignUp.Controls.Add(Tab_SignUp_TextBox_ClientPhoneNumber);
            Tab_SignUp.Controls.Add(Tab_SignUp_TextBox_ClientPatronymic);
            Tab_SignUp.Controls.Add(Tab_SignUp_TextBox_ClientSurname);
            Tab_SignUp.Controls.Add(Tab_SignUp_TextBox_ClientName);
            Tab_SignUp.Controls.Add(Tab_SignUp_Button_SignUp);
            Tab_SignUp.Location = new Point(4, 24);
            Tab_SignUp.Margin = new Padding(4, 3, 4, 3);
            Tab_SignUp.Name = "Tab_SignUp";
            Tab_SignUp.Size = new Size(935, 419);
            Tab_SignUp.TabIndex = 3;
            Tab_SignUp.Text = "Регістрація";
            // 
            // Tab_SignUp_TextBox_ClientPasswordСonfirmation
            // 
            Tab_SignUp_TextBox_ClientPasswordСonfirmation.AnimateReadOnly = false;
            Tab_SignUp_TextBox_ClientPasswordСonfirmation.BorderStyle = BorderStyle.None;
            Tab_SignUp_TextBox_ClientPasswordСonfirmation.Depth = 0;
            Tab_SignUp_TextBox_ClientPasswordСonfirmation.Font = new Font("Microsoft Sans Serif", 12F);
            Tab_SignUp_TextBox_ClientPasswordСonfirmation.Hint = "Підтвердження паролю";
            Tab_SignUp_TextBox_ClientPasswordСonfirmation.LeadingIcon = null;
            Tab_SignUp_TextBox_ClientPasswordСonfirmation.Location = new Point(344, 256);
            Tab_SignUp_TextBox_ClientPasswordСonfirmation.Margin = new Padding(4, 3, 4, 3);
            Tab_SignUp_TextBox_ClientPasswordСonfirmation.MaxLength = 50;
            Tab_SignUp_TextBox_ClientPasswordСonfirmation.MouseState = MaterialSkin.MouseState.OUT;
            Tab_SignUp_TextBox_ClientPasswordСonfirmation.Multiline = false;
            Tab_SignUp_TextBox_ClientPasswordСonfirmation.Name = "Tab_SignUp_TextBox_ClientPasswordСonfirmation";
            Tab_SignUp_TextBox_ClientPasswordСonfirmation.Size = new Size(245, 50);
            Tab_SignUp_TextBox_ClientPasswordСonfirmation.TabIndex = 14;
            Tab_SignUp_TextBox_ClientPasswordСonfirmation.Text = "Password";
            Tab_SignUp_TextBox_ClientPasswordСonfirmation.TrailingIcon = null;
            Tab_SignUp_TextBox_ClientPasswordСonfirmation.KeyPress += Tab_SignUp_TextBox_ClientPasswordСonfirmation_KeyPress;
            // 
            // Tab_SignUp_TextBox_ClientPassword
            // 
            Tab_SignUp_TextBox_ClientPassword.AnimateReadOnly = false;
            Tab_SignUp_TextBox_ClientPassword.BorderStyle = BorderStyle.None;
            Tab_SignUp_TextBox_ClientPassword.Depth = 0;
            Tab_SignUp_TextBox_ClientPassword.Font = new Font("Microsoft Sans Serif", 12F);
            Tab_SignUp_TextBox_ClientPassword.Hint = "Пароль";
            Tab_SignUp_TextBox_ClientPassword.LeadingIcon = null;
            Tab_SignUp_TextBox_ClientPassword.Location = new Point(474, 190);
            Tab_SignUp_TextBox_ClientPassword.Margin = new Padding(4, 3, 4, 3);
            Tab_SignUp_TextBox_ClientPassword.MaxLength = 50;
            Tab_SignUp_TextBox_ClientPassword.MouseState = MaterialSkin.MouseState.OUT;
            Tab_SignUp_TextBox_ClientPassword.Multiline = false;
            Tab_SignUp_TextBox_ClientPassword.Name = "Tab_SignUp_TextBox_ClientPassword";
            Tab_SignUp_TextBox_ClientPassword.Size = new Size(233, 50);
            Tab_SignUp_TextBox_ClientPassword.TabIndex = 13;
            Tab_SignUp_TextBox_ClientPassword.Text = "Password";
            Tab_SignUp_TextBox_ClientPassword.TrailingIcon = null;
            Tab_SignUp_TextBox_ClientPassword.KeyPress += Tab_SignUp_TextBox_ClientPassword_KeyPress;
            // 
            // Tab_SignUp_ComboBox_ClientStatus
            // 
            Tab_SignUp_ComboBox_ClientStatus.AutoResize = false;
            Tab_SignUp_ComboBox_ClientStatus.BackColor = Color.FromArgb(255, 255, 255);
            Tab_SignUp_ComboBox_ClientStatus.Depth = 0;
            Tab_SignUp_ComboBox_ClientStatus.DrawMode = DrawMode.OwnerDrawVariable;
            Tab_SignUp_ComboBox_ClientStatus.DropDownHeight = 174;
            Tab_SignUp_ComboBox_ClientStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            Tab_SignUp_ComboBox_ClientStatus.DropDownWidth = 121;
            Tab_SignUp_ComboBox_ClientStatus.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            Tab_SignUp_ComboBox_ClientStatus.ForeColor = Color.FromArgb(222, 0, 0, 0);
            Tab_SignUp_ComboBox_ClientStatus.FormattingEnabled = true;
            Tab_SignUp_ComboBox_ClientStatus.Hint = "Статус";
            Tab_SignUp_ComboBox_ClientStatus.IntegralHeight = false;
            Tab_SignUp_ComboBox_ClientStatus.ItemHeight = 43;
            Tab_SignUp_ComboBox_ClientStatus.Items.AddRange(new object[] { "Гість", "Постійний клієнт", "VIP" });
            Tab_SignUp_ComboBox_ClientStatus.Location = new Point(474, 127);
            Tab_SignUp_ComboBox_ClientStatus.Margin = new Padding(4, 3, 4, 3);
            Tab_SignUp_ComboBox_ClientStatus.MaxDropDownItems = 4;
            Tab_SignUp_ComboBox_ClientStatus.MouseState = MaterialSkin.MouseState.OUT;
            Tab_SignUp_ComboBox_ClientStatus.Name = "Tab_SignUp_ComboBox_ClientStatus";
            Tab_SignUp_ComboBox_ClientStatus.Size = new Size(233, 49);
            Tab_SignUp_ComboBox_ClientStatus.StartIndex = 0;
            Tab_SignUp_ComboBox_ClientStatus.TabIndex = 12;
            Tab_SignUp_ComboBox_ClientStatus.KeyPress += Tab_SignUp_ComboBox_ClientStatus_KeyPress;
            // 
            // Tab_SignUp_TextBox_ClientPhoneNumber
            // 
            Tab_SignUp_TextBox_ClientPhoneNumber.AnimateReadOnly = false;
            Tab_SignUp_TextBox_ClientPhoneNumber.BorderStyle = BorderStyle.None;
            Tab_SignUp_TextBox_ClientPhoneNumber.Depth = 0;
            Tab_SignUp_TextBox_ClientPhoneNumber.Font = new Font("Microsoft Sans Serif", 12F);
            Tab_SignUp_TextBox_ClientPhoneNumber.Hint = "Номер телефону";
            Tab_SignUp_TextBox_ClientPhoneNumber.LeadingIcon = null;
            Tab_SignUp_TextBox_ClientPhoneNumber.Location = new Point(474, 62);
            Tab_SignUp_TextBox_ClientPhoneNumber.Margin = new Padding(4, 3, 4, 3);
            Tab_SignUp_TextBox_ClientPhoneNumber.MaxLength = 50;
            Tab_SignUp_TextBox_ClientPhoneNumber.MouseState = MaterialSkin.MouseState.OUT;
            Tab_SignUp_TextBox_ClientPhoneNumber.Multiline = false;
            Tab_SignUp_TextBox_ClientPhoneNumber.Name = "Tab_SignUp_TextBox_ClientPhoneNumber";
            Tab_SignUp_TextBox_ClientPhoneNumber.Size = new Size(233, 50);
            Tab_SignUp_TextBox_ClientPhoneNumber.TabIndex = 11;
            Tab_SignUp_TextBox_ClientPhoneNumber.Text = "0673802728";
            Tab_SignUp_TextBox_ClientPhoneNumber.TrailingIcon = null;
            Tab_SignUp_TextBox_ClientPhoneNumber.TextChanged += Tab_SignUp_TextBox_ClientPhoneNumber_TextChanged;
            Tab_SignUp_TextBox_ClientPhoneNumber.KeyPress += Tab_SignUp_TextBox_ClientPhoneNumber_KeyPress;
            // 
            // Tab_SignUp_TextBox_ClientPatronymic
            // 
            Tab_SignUp_TextBox_ClientPatronymic.AnimateReadOnly = false;
            Tab_SignUp_TextBox_ClientPatronymic.BorderStyle = BorderStyle.None;
            Tab_SignUp_TextBox_ClientPatronymic.Depth = 0;
            Tab_SignUp_TextBox_ClientPatronymic.Font = new Font("Microsoft Sans Serif", 12F);
            Tab_SignUp_TextBox_ClientPatronymic.Hint = "По батькові";
            Tab_SignUp_TextBox_ClientPatronymic.LeadingIcon = null;
            Tab_SignUp_TextBox_ClientPatronymic.Location = new Point(233, 190);
            Tab_SignUp_TextBox_ClientPatronymic.Margin = new Padding(4, 3, 4, 3);
            Tab_SignUp_TextBox_ClientPatronymic.MaxLength = 50;
            Tab_SignUp_TextBox_ClientPatronymic.MouseState = MaterialSkin.MouseState.OUT;
            Tab_SignUp_TextBox_ClientPatronymic.Multiline = false;
            Tab_SignUp_TextBox_ClientPatronymic.Name = "Tab_SignUp_TextBox_ClientPatronymic";
            Tab_SignUp_TextBox_ClientPatronymic.Size = new Size(233, 50);
            Tab_SignUp_TextBox_ClientPatronymic.TabIndex = 10;
            Tab_SignUp_TextBox_ClientPatronymic.Text = "Олексійович";
            Tab_SignUp_TextBox_ClientPatronymic.TrailingIcon = null;
            Tab_SignUp_TextBox_ClientPatronymic.KeyPress += Tab_SignUp_TextBox_ClientPatronymic_KeyPress;
            // 
            // Tab_SignUp_TextBox_ClientSurname
            // 
            Tab_SignUp_TextBox_ClientSurname.AnimateReadOnly = false;
            Tab_SignUp_TextBox_ClientSurname.BorderStyle = BorderStyle.None;
            Tab_SignUp_TextBox_ClientSurname.Depth = 0;
            Tab_SignUp_TextBox_ClientSurname.Font = new Font("Microsoft Sans Serif", 12F);
            Tab_SignUp_TextBox_ClientSurname.Hint = "Прізвище";
            Tab_SignUp_TextBox_ClientSurname.LeadingIcon = null;
            Tab_SignUp_TextBox_ClientSurname.Location = new Point(233, 127);
            Tab_SignUp_TextBox_ClientSurname.Margin = new Padding(4, 3, 4, 3);
            Tab_SignUp_TextBox_ClientSurname.MaxLength = 50;
            Tab_SignUp_TextBox_ClientSurname.MouseState = MaterialSkin.MouseState.OUT;
            Tab_SignUp_TextBox_ClientSurname.Multiline = false;
            Tab_SignUp_TextBox_ClientSurname.Name = "Tab_SignUp_TextBox_ClientSurname";
            Tab_SignUp_TextBox_ClientSurname.Size = new Size(233, 50);
            Tab_SignUp_TextBox_ClientSurname.TabIndex = 9;
            Tab_SignUp_TextBox_ClientSurname.Text = "Шуневич";
            Tab_SignUp_TextBox_ClientSurname.TrailingIcon = null;
            Tab_SignUp_TextBox_ClientSurname.KeyPress += Tab_SignUp_TextBox_ClientSurname_KeyPress;
            // 
            // Tab_SignUp_TextBox_ClientName
            // 
            Tab_SignUp_TextBox_ClientName.AnimateReadOnly = false;
            Tab_SignUp_TextBox_ClientName.BorderStyle = BorderStyle.None;
            Tab_SignUp_TextBox_ClientName.Depth = 0;
            Tab_SignUp_TextBox_ClientName.Font = new Font("Microsoft Sans Serif", 12F);
            Tab_SignUp_TextBox_ClientName.Hint = "Ім'я";
            Tab_SignUp_TextBox_ClientName.LeadingIcon = null;
            Tab_SignUp_TextBox_ClientName.Location = new Point(233, 62);
            Tab_SignUp_TextBox_ClientName.Margin = new Padding(4, 3, 4, 3);
            Tab_SignUp_TextBox_ClientName.MaxLength = 50;
            Tab_SignUp_TextBox_ClientName.MouseState = MaterialSkin.MouseState.OUT;
            Tab_SignUp_TextBox_ClientName.Multiline = false;
            Tab_SignUp_TextBox_ClientName.Name = "Tab_SignUp_TextBox_ClientName";
            Tab_SignUp_TextBox_ClientName.Size = new Size(233, 50);
            Tab_SignUp_TextBox_ClientName.TabIndex = 8;
            Tab_SignUp_TextBox_ClientName.Text = "Максим";
            Tab_SignUp_TextBox_ClientName.TrailingIcon = null;
            Tab_SignUp_TextBox_ClientName.KeyPress += Tab_SignUp_TextBox_ClientName_KeyPress;
            // 
            // Tab_SignUp_Button_SignUp
            // 
            Tab_SignUp_Button_SignUp.AutoSize = false;
            Tab_SignUp_Button_SignUp.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Tab_SignUp_Button_SignUp.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            Tab_SignUp_Button_SignUp.Depth = 0;
            Tab_SignUp_Button_SignUp.HighEmphasis = true;
            Tab_SignUp_Button_SignUp.Icon = (Image)resources.GetObject("Tab_SignUp_Button_SignUp.Icon");
            Tab_SignUp_Button_SignUp.Location = new Point(362, 320);
            Tab_SignUp_Button_SignUp.Margin = new Padding(5, 7, 5, 7);
            Tab_SignUp_Button_SignUp.MouseState = MaterialSkin.MouseState.HOVER;
            Tab_SignUp_Button_SignUp.Name = "Tab_SignUp_Button_SignUp";
            Tab_SignUp_Button_SignUp.NoAccentTextColor = Color.Empty;
            Tab_SignUp_Button_SignUp.Size = new Size(210, 42);
            Tab_SignUp_Button_SignUp.TabIndex = 7;
            Tab_SignUp_Button_SignUp.Text = "Зареєструватися";
            Tab_SignUp_Button_SignUp.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            Tab_SignUp_Button_SignUp.UseAccentColor = false;
            Tab_SignUp_Button_SignUp.UseVisualStyleBackColor = true;
            Tab_SignUp_Button_SignUp.Click += Tab_SignUp_Button_SignUp_Click;
            // 
            // Tab_Aministrator
            // 
            Tab_Aministrator.BackColor = Color.FromArgb(50, 50, 50);
            Tab_Aministrator.Controls.Add(Tab_Administrator_Button_MoveToSignIn);
            Tab_Aministrator.Controls.Add(Tab_Administrator_Panel_RequesList);
            Tab_Aministrator.Controls.Add(label1);
            Tab_Aministrator.Location = new Point(4, 24);
            Tab_Aministrator.Margin = new Padding(4, 3, 4, 3);
            Tab_Aministrator.Name = "Tab_Aministrator";
            Tab_Aministrator.Padding = new Padding(4, 3, 4, 3);
            Tab_Aministrator.Size = new Size(935, 419);
            Tab_Aministrator.TabIndex = 0;
            Tab_Aministrator.Text = "Адміністратор";
            // 
            // Tab_Administrator_Button_MoveToSignIn
            // 
            Tab_Administrator_Button_MoveToSignIn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Tab_Administrator_Button_MoveToSignIn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            Tab_Administrator_Button_MoveToSignIn.Depth = 0;
            Tab_Administrator_Button_MoveToSignIn.HighEmphasis = true;
            Tab_Administrator_Button_MoveToSignIn.Icon = (Image)resources.GetObject("Tab_Administrator_Button_MoveToSignIn.Icon");
            Tab_Administrator_Button_MoveToSignIn.Location = new Point(8, 7);
            Tab_Administrator_Button_MoveToSignIn.Margin = new Padding(5, 7, 5, 7);
            Tab_Administrator_Button_MoveToSignIn.MouseState = MaterialSkin.MouseState.HOVER;
            Tab_Administrator_Button_MoveToSignIn.Name = "Tab_Administrator_Button_MoveToSignIn";
            Tab_Administrator_Button_MoveToSignIn.NoAccentTextColor = Color.Empty;
            Tab_Administrator_Button_MoveToSignIn.Size = new Size(194, 36);
            Tab_Administrator_Button_MoveToSignIn.TabIndex = 18;
            Tab_Administrator_Button_MoveToSignIn.Text = "Меню авторизації";
            Tab_Administrator_Button_MoveToSignIn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            Tab_Administrator_Button_MoveToSignIn.UseAccentColor = false;
            Tab_Administrator_Button_MoveToSignIn.UseVisualStyleBackColor = true;
            Tab_Administrator_Button_MoveToSignIn.Click += Tab_Administrator_Button_MoveToSignIn_Click;
            // 
            // Tab_Administrator_Panel_RequesList
            // 
            Tab_Administrator_Panel_RequesList.BorderStyle = BorderStyle.FixedSingle;
            Tab_Administrator_Panel_RequesList.Controls.Add(Tab_Administrator_Label_ClientPhoneNumber);
            Tab_Administrator_Panel_RequesList.Controls.Add(Tab_Administrator_LabelText_ClientPhoneNumber);
            Tab_Administrator_Panel_RequesList.Controls.Add(Tab_Administrator_Button_PrevRequest);
            Tab_Administrator_Panel_RequesList.Controls.Add(Tab_Administrator_Button_NextRequest);
            Tab_Administrator_Panel_RequesList.Controls.Add(Tab_Administrator_Button_DeclineRequest);
            Tab_Administrator_Panel_RequesList.Controls.Add(Tab_Administrator_Button_ConfirmRequest);
            Tab_Administrator_Panel_RequesList.Controls.Add(Tab_Administrator_Label_RequestState);
            Tab_Administrator_Panel_RequesList.Controls.Add(Tab_Administrator_Label_StayTime);
            Tab_Administrator_Panel_RequesList.Controls.Add(Tab_Administrator_Label_ApartmentСlass);
            Tab_Administrator_Panel_RequesList.Controls.Add(Tab_Administrator_Label_SleepingPlacesNumber);
            Tab_Administrator_Panel_RequesList.Controls.Add(Tab_Administrator_Label_ClientPatronymic);
            Tab_Administrator_Panel_RequesList.Controls.Add(Tab_Administrator_Label_ClientSurname);
            Tab_Administrator_Panel_RequesList.Controls.Add(Tab_Administrator_Label_ClientName);
            Tab_Administrator_Panel_RequesList.Controls.Add(Tab_Administrator_LabelText_RequestState);
            Tab_Administrator_Panel_RequesList.Controls.Add(Tab_Administrator_LabelText_StayTime);
            Tab_Administrator_Panel_RequesList.Controls.Add(Tab_Administrator_LabelText_ApartmentСlass);
            Tab_Administrator_Panel_RequesList.Controls.Add(Tab_Administrator_LabelText_SleepingPlacesNumber);
            Tab_Administrator_Panel_RequesList.Controls.Add(Tab_Administrator_LabelText_ClientPatronymic);
            Tab_Administrator_Panel_RequesList.Controls.Add(Tab_Administrator_LabelText_ClientSurname);
            Tab_Administrator_Panel_RequesList.Controls.Add(Tab_Administrator_LabelText_ClientName);
            Tab_Administrator_Panel_RequesList.Location = new Point(170, 81);
            Tab_Administrator_Panel_RequesList.Margin = new Padding(4, 3, 4, 3);
            Tab_Administrator_Panel_RequesList.Name = "Tab_Administrator_Panel_RequesList";
            Tab_Administrator_Panel_RequesList.Size = new Size(592, 293);
            Tab_Administrator_Panel_RequesList.TabIndex = 0;
            Tab_Administrator_Panel_RequesList.Visible = false;
            // 
            // Tab_Administrator_Label_ClientPhoneNumber
            // 
            Tab_Administrator_Label_ClientPhoneNumber.Depth = 0;
            Tab_Administrator_Label_ClientPhoneNumber.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            Tab_Administrator_Label_ClientPhoneNumber.Location = new Point(298, 80);
            Tab_Administrator_Label_ClientPhoneNumber.Margin = new Padding(4, 0, 4, 0);
            Tab_Administrator_Label_ClientPhoneNumber.MouseState = MaterialSkin.MouseState.HOVER;
            Tab_Administrator_Label_ClientPhoneNumber.Name = "Tab_Administrator_Label_ClientPhoneNumber";
            Tab_Administrator_Label_ClientPhoneNumber.Size = new Size(233, 27);
            Tab_Administrator_Label_ClientPhoneNumber.TabIndex = 16;
            Tab_Administrator_Label_ClientPhoneNumber.Text = "PhoneNumber";
            Tab_Administrator_Label_ClientPhoneNumber.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Tab_Administrator_LabelText_ClientPhoneNumber
            // 
            Tab_Administrator_LabelText_ClientPhoneNumber.Depth = 0;
            Tab_Administrator_LabelText_ClientPhoneNumber.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            Tab_Administrator_LabelText_ClientPhoneNumber.Location = new Point(57, 80);
            Tab_Administrator_LabelText_ClientPhoneNumber.Margin = new Padding(4, 0, 4, 0);
            Tab_Administrator_LabelText_ClientPhoneNumber.MouseState = MaterialSkin.MouseState.HOVER;
            Tab_Administrator_LabelText_ClientPhoneNumber.Name = "Tab_Administrator_LabelText_ClientPhoneNumber";
            Tab_Administrator_LabelText_ClientPhoneNumber.Size = new Size(233, 27);
            Tab_Administrator_LabelText_ClientPhoneNumber.TabIndex = 15;
            Tab_Administrator_LabelText_ClientPhoneNumber.Text = "Номер телефону";
            Tab_Administrator_LabelText_ClientPhoneNumber.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Tab_Administrator_Button_PrevRequest
            // 
            Tab_Administrator_Button_PrevRequest.AutoSize = false;
            Tab_Administrator_Button_PrevRequest.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Tab_Administrator_Button_PrevRequest.BackColor = Color.FromArgb(50, 50, 50);
            Tab_Administrator_Button_PrevRequest.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            Tab_Administrator_Button_PrevRequest.Depth = 0;
            Tab_Administrator_Button_PrevRequest.Enabled = false;
            Tab_Administrator_Button_PrevRequest.HighEmphasis = true;
            Tab_Administrator_Button_PrevRequest.Icon = (Image)resources.GetObject("Tab_Administrator_Button_PrevRequest.Icon");
            Tab_Administrator_Button_PrevRequest.Location = new Point(-1, 121);
            Tab_Administrator_Button_PrevRequest.Margin = new Padding(5, 7, 5, 7);
            Tab_Administrator_Button_PrevRequest.MouseState = MaterialSkin.MouseState.HOVER;
            Tab_Administrator_Button_PrevRequest.Name = "Tab_Administrator_Button_PrevRequest";
            Tab_Administrator_Button_PrevRequest.NoAccentTextColor = Color.Empty;
            Tab_Administrator_Button_PrevRequest.Size = new Size(40, 44);
            Tab_Administrator_Button_PrevRequest.TabIndex = 14;
            Tab_Administrator_Button_PrevRequest.Text = "1";
            Tab_Administrator_Button_PrevRequest.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            Tab_Administrator_Button_PrevRequest.UseAccentColor = false;
            Tab_Administrator_Button_PrevRequest.UseVisualStyleBackColor = false;
            Tab_Administrator_Button_PrevRequest.Click += Tab_Administrator_Button_PrevRequest_Click;
            // 
            // Tab_Administrator_Button_NextRequest
            // 
            Tab_Administrator_Button_NextRequest.AutoSize = false;
            Tab_Administrator_Button_NextRequest.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Tab_Administrator_Button_NextRequest.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            Tab_Administrator_Button_NextRequest.Depth = 0;
            Tab_Administrator_Button_NextRequest.HighEmphasis = true;
            Tab_Administrator_Button_NextRequest.Icon = (Image)resources.GetObject("Tab_Administrator_Button_NextRequest.Icon");
            Tab_Administrator_Button_NextRequest.Location = new Point(545, 121);
            Tab_Administrator_Button_NextRequest.Margin = new Padding(5, 7, 5, 7);
            Tab_Administrator_Button_NextRequest.MouseState = MaterialSkin.MouseState.HOVER;
            Tab_Administrator_Button_NextRequest.Name = "Tab_Administrator_Button_NextRequest";
            Tab_Administrator_Button_NextRequest.NoAccentTextColor = Color.Empty;
            Tab_Administrator_Button_NextRequest.Size = new Size(40, 44);
            Tab_Administrator_Button_NextRequest.TabIndex = 14;
            Tab_Administrator_Button_NextRequest.Text = "1";
            Tab_Administrator_Button_NextRequest.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            Tab_Administrator_Button_NextRequest.UseAccentColor = false;
            Tab_Administrator_Button_NextRequest.UseVisualStyleBackColor = true;
            Tab_Administrator_Button_NextRequest.Click += Tab_Administrator_Button_NextRequest_Click;
            // 
            // Tab_Administrator_Button_DeclineRequest
            // 
            Tab_Administrator_Button_DeclineRequest.AutoSize = false;
            Tab_Administrator_Button_DeclineRequest.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Tab_Administrator_Button_DeclineRequest.BackColor = Color.FromArgb(50, 50, 50);
            Tab_Administrator_Button_DeclineRequest.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            Tab_Administrator_Button_DeclineRequest.Depth = 0;
            Tab_Administrator_Button_DeclineRequest.HighEmphasis = true;
            Tab_Administrator_Button_DeclineRequest.Icon = (Image)resources.GetObject("Tab_Administrator_Button_DeclineRequest.Icon");
            Tab_Administrator_Button_DeclineRequest.Location = new Point(245, 239);
            Tab_Administrator_Button_DeclineRequest.Margin = new Padding(5, 7, 5, 7);
            Tab_Administrator_Button_DeclineRequest.MouseState = MaterialSkin.MouseState.HOVER;
            Tab_Administrator_Button_DeclineRequest.Name = "Tab_Administrator_Button_DeclineRequest";
            Tab_Administrator_Button_DeclineRequest.NoAccentTextColor = Color.Empty;
            Tab_Administrator_Button_DeclineRequest.Size = new Size(40, 44);
            Tab_Administrator_Button_DeclineRequest.TabIndex = 13;
            Tab_Administrator_Button_DeclineRequest.Text = "1";
            Tab_Administrator_Button_DeclineRequest.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            Tab_Administrator_Button_DeclineRequest.UseAccentColor = false;
            Tab_Administrator_Button_DeclineRequest.UseVisualStyleBackColor = false;
            Tab_Administrator_Button_DeclineRequest.Click += Tab_Administrator_Button_DeclineRequest_Click;
            // 
            // Tab_Administrator_Button_ConfirmRequest
            // 
            Tab_Administrator_Button_ConfirmRequest.AutoSize = false;
            Tab_Administrator_Button_ConfirmRequest.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Tab_Administrator_Button_ConfirmRequest.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            Tab_Administrator_Button_ConfirmRequest.Depth = 0;
            Tab_Administrator_Button_ConfirmRequest.HighEmphasis = true;
            Tab_Administrator_Button_ConfirmRequest.Icon = (Image)resources.GetObject("Tab_Administrator_Button_ConfirmRequest.Icon");
            Tab_Administrator_Button_ConfirmRequest.Location = new Point(302, 239);
            Tab_Administrator_Button_ConfirmRequest.Margin = new Padding(5, 7, 5, 7);
            Tab_Administrator_Button_ConfirmRequest.MouseState = MaterialSkin.MouseState.HOVER;
            Tab_Administrator_Button_ConfirmRequest.Name = "Tab_Administrator_Button_ConfirmRequest";
            Tab_Administrator_Button_ConfirmRequest.NoAccentTextColor = Color.Empty;
            Tab_Administrator_Button_ConfirmRequest.Size = new Size(40, 44);
            Tab_Administrator_Button_ConfirmRequest.TabIndex = 1;
            Tab_Administrator_Button_ConfirmRequest.Text = "1";
            Tab_Administrator_Button_ConfirmRequest.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            Tab_Administrator_Button_ConfirmRequest.UseAccentColor = false;
            Tab_Administrator_Button_ConfirmRequest.UseVisualStyleBackColor = true;
            Tab_Administrator_Button_ConfirmRequest.Click += Tab_Administrator_Button_ConfirmRequest_Click;
            // 
            // Tab_Administrator_Label_RequestState
            // 
            Tab_Administrator_Label_RequestState.Depth = 0;
            Tab_Administrator_Label_RequestState.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            Tab_Administrator_Label_RequestState.Location = new Point(299, 212);
            Tab_Administrator_Label_RequestState.Margin = new Padding(4, 0, 4, 0);
            Tab_Administrator_Label_RequestState.MouseState = MaterialSkin.MouseState.HOVER;
            Tab_Administrator_Label_RequestState.Name = "Tab_Administrator_Label_RequestState";
            Tab_Administrator_Label_RequestState.Size = new Size(233, 22);
            Tab_Administrator_Label_RequestState.TabIndex = 12;
            Tab_Administrator_Label_RequestState.Text = "State";
            Tab_Administrator_Label_RequestState.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Tab_Administrator_Label_StayTime
            // 
            Tab_Administrator_Label_StayTime.Depth = 0;
            Tab_Administrator_Label_StayTime.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            Tab_Administrator_Label_StayTime.Location = new Point(299, 186);
            Tab_Administrator_Label_StayTime.Margin = new Padding(4, 0, 4, 0);
            Tab_Administrator_Label_StayTime.MouseState = MaterialSkin.MouseState.HOVER;
            Tab_Administrator_Label_StayTime.Name = "Tab_Administrator_Label_StayTime";
            Tab_Administrator_Label_StayTime.Size = new Size(233, 27);
            Tab_Administrator_Label_StayTime.TabIndex = 11;
            Tab_Administrator_Label_StayTime.Text = "Time in D.H.M.";
            Tab_Administrator_Label_StayTime.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Tab_Administrator_Label_ApartmentСlass
            // 
            Tab_Administrator_Label_ApartmentСlass.Depth = 0;
            Tab_Administrator_Label_ApartmentСlass.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            Tab_Administrator_Label_ApartmentСlass.Location = new Point(299, 159);
            Tab_Administrator_Label_ApartmentСlass.Margin = new Padding(4, 0, 4, 0);
            Tab_Administrator_Label_ApartmentСlass.MouseState = MaterialSkin.MouseState.HOVER;
            Tab_Administrator_Label_ApartmentСlass.Name = "Tab_Administrator_Label_ApartmentСlass";
            Tab_Administrator_Label_ApartmentСlass.Size = new Size(233, 27);
            Tab_Administrator_Label_ApartmentСlass.TabIndex = 10;
            Tab_Administrator_Label_ApartmentСlass.Text = "Count";
            Tab_Administrator_Label_ApartmentСlass.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Tab_Administrator_Label_SleepingPlacesNumber
            // 
            Tab_Administrator_Label_SleepingPlacesNumber.Depth = 0;
            Tab_Administrator_Label_SleepingPlacesNumber.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            Tab_Administrator_Label_SleepingPlacesNumber.Location = new Point(299, 106);
            Tab_Administrator_Label_SleepingPlacesNumber.Margin = new Padding(4, 0, 4, 0);
            Tab_Administrator_Label_SleepingPlacesNumber.MouseState = MaterialSkin.MouseState.HOVER;
            Tab_Administrator_Label_SleepingPlacesNumber.Name = "Tab_Administrator_Label_SleepingPlacesNumber";
            Tab_Administrator_Label_SleepingPlacesNumber.Size = new Size(233, 53);
            Tab_Administrator_Label_SleepingPlacesNumber.TabIndex = 9;
            Tab_Administrator_Label_SleepingPlacesNumber.Text = "Count";
            Tab_Administrator_Label_SleepingPlacesNumber.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Tab_Administrator_Label_ClientPatronymic
            // 
            Tab_Administrator_Label_ClientPatronymic.Depth = 0;
            Tab_Administrator_Label_ClientPatronymic.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            Tab_Administrator_Label_ClientPatronymic.Location = new Point(299, 53);
            Tab_Administrator_Label_ClientPatronymic.Margin = new Padding(4, 0, 4, 0);
            Tab_Administrator_Label_ClientPatronymic.MouseState = MaterialSkin.MouseState.HOVER;
            Tab_Administrator_Label_ClientPatronymic.Name = "Tab_Administrator_Label_ClientPatronymic";
            Tab_Administrator_Label_ClientPatronymic.Size = new Size(233, 27);
            Tab_Administrator_Label_ClientPatronymic.TabIndex = 8;
            Tab_Administrator_Label_ClientPatronymic.Text = "Patronymic";
            Tab_Administrator_Label_ClientPatronymic.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Tab_Administrator_Label_ClientSurname
            // 
            Tab_Administrator_Label_ClientSurname.Depth = 0;
            Tab_Administrator_Label_ClientSurname.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            Tab_Administrator_Label_ClientSurname.Location = new Point(299, 27);
            Tab_Administrator_Label_ClientSurname.Margin = new Padding(4, 0, 4, 0);
            Tab_Administrator_Label_ClientSurname.MouseState = MaterialSkin.MouseState.HOVER;
            Tab_Administrator_Label_ClientSurname.Name = "Tab_Administrator_Label_ClientSurname";
            Tab_Administrator_Label_ClientSurname.Size = new Size(233, 27);
            Tab_Administrator_Label_ClientSurname.TabIndex = 7;
            Tab_Administrator_Label_ClientSurname.Text = "Surname";
            Tab_Administrator_Label_ClientSurname.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Tab_Administrator_Label_ClientName
            // 
            Tab_Administrator_Label_ClientName.Depth = 0;
            Tab_Administrator_Label_ClientName.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            Tab_Administrator_Label_ClientName.Location = new Point(299, 0);
            Tab_Administrator_Label_ClientName.Margin = new Padding(4, 0, 4, 0);
            Tab_Administrator_Label_ClientName.MouseState = MaterialSkin.MouseState.HOVER;
            Tab_Administrator_Label_ClientName.Name = "Tab_Administrator_Label_ClientName";
            Tab_Administrator_Label_ClientName.Size = new Size(233, 27);
            Tab_Administrator_Label_ClientName.TabIndex = 6;
            Tab_Administrator_Label_ClientName.Text = "Name";
            Tab_Administrator_Label_ClientName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Tab_Administrator_LabelText_RequestState
            // 
            Tab_Administrator_LabelText_RequestState.Depth = 0;
            Tab_Administrator_LabelText_RequestState.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            Tab_Administrator_LabelText_RequestState.Location = new Point(58, 212);
            Tab_Administrator_LabelText_RequestState.Margin = new Padding(4, 0, 4, 0);
            Tab_Administrator_LabelText_RequestState.MouseState = MaterialSkin.MouseState.HOVER;
            Tab_Administrator_LabelText_RequestState.Name = "Tab_Administrator_LabelText_RequestState";
            Tab_Administrator_LabelText_RequestState.Size = new Size(233, 22);
            Tab_Administrator_LabelText_RequestState.TabIndex = 5;
            Tab_Administrator_LabelText_RequestState.Text = "Стан заявки:";
            Tab_Administrator_LabelText_RequestState.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Tab_Administrator_LabelText_StayTime
            // 
            Tab_Administrator_LabelText_StayTime.Depth = 0;
            Tab_Administrator_LabelText_StayTime.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            Tab_Administrator_LabelText_StayTime.Location = new Point(58, 186);
            Tab_Administrator_LabelText_StayTime.Margin = new Padding(4, 0, 4, 0);
            Tab_Administrator_LabelText_StayTime.MouseState = MaterialSkin.MouseState.HOVER;
            Tab_Administrator_LabelText_StayTime.Name = "Tab_Administrator_LabelText_StayTime";
            Tab_Administrator_LabelText_StayTime.Size = new Size(233, 27);
            Tab_Administrator_LabelText_StayTime.TabIndex = 4;
            Tab_Administrator_LabelText_StayTime.Text = "Час перебування:";
            Tab_Administrator_LabelText_StayTime.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Tab_Administrator_LabelText_ApartmentСlass
            // 
            Tab_Administrator_LabelText_ApartmentСlass.Depth = 0;
            Tab_Administrator_LabelText_ApartmentСlass.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            Tab_Administrator_LabelText_ApartmentСlass.Location = new Point(58, 159);
            Tab_Administrator_LabelText_ApartmentСlass.Margin = new Padding(4, 0, 4, 0);
            Tab_Administrator_LabelText_ApartmentСlass.MouseState = MaterialSkin.MouseState.HOVER;
            Tab_Administrator_LabelText_ApartmentСlass.Name = "Tab_Administrator_LabelText_ApartmentСlass";
            Tab_Administrator_LabelText_ApartmentСlass.Size = new Size(233, 27);
            Tab_Administrator_LabelText_ApartmentСlass.TabIndex = 3;
            Tab_Administrator_LabelText_ApartmentСlass.Text = "Клас апартаментів:";
            Tab_Administrator_LabelText_ApartmentСlass.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Tab_Administrator_LabelText_SleepingPlacesNumber
            // 
            Tab_Administrator_LabelText_SleepingPlacesNumber.Depth = 0;
            Tab_Administrator_LabelText_SleepingPlacesNumber.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            Tab_Administrator_LabelText_SleepingPlacesNumber.Location = new Point(58, 120);
            Tab_Administrator_LabelText_SleepingPlacesNumber.Margin = new Padding(4, 0, 4, 0);
            Tab_Administrator_LabelText_SleepingPlacesNumber.MouseState = MaterialSkin.MouseState.HOVER;
            Tab_Administrator_LabelText_SleepingPlacesNumber.Name = "Tab_Administrator_LabelText_SleepingPlacesNumber";
            Tab_Administrator_LabelText_SleepingPlacesNumber.Size = new Size(233, 27);
            Tab_Administrator_LabelText_SleepingPlacesNumber.TabIndex = 2;
            Tab_Administrator_LabelText_SleepingPlacesNumber.Text = "Кількість місць у номері:";
            Tab_Administrator_LabelText_SleepingPlacesNumber.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Tab_Administrator_LabelText_ClientPatronymic
            // 
            Tab_Administrator_LabelText_ClientPatronymic.Depth = 0;
            Tab_Administrator_LabelText_ClientPatronymic.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            Tab_Administrator_LabelText_ClientPatronymic.Location = new Point(58, 53);
            Tab_Administrator_LabelText_ClientPatronymic.Margin = new Padding(4, 0, 4, 0);
            Tab_Administrator_LabelText_ClientPatronymic.MouseState = MaterialSkin.MouseState.HOVER;
            Tab_Administrator_LabelText_ClientPatronymic.Name = "Tab_Administrator_LabelText_ClientPatronymic";
            Tab_Administrator_LabelText_ClientPatronymic.Size = new Size(233, 27);
            Tab_Administrator_LabelText_ClientPatronymic.TabIndex = 1;
            Tab_Administrator_LabelText_ClientPatronymic.Text = "По батькові:";
            Tab_Administrator_LabelText_ClientPatronymic.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Tab_Administrator_LabelText_ClientSurname
            // 
            Tab_Administrator_LabelText_ClientSurname.Depth = 0;
            Tab_Administrator_LabelText_ClientSurname.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            Tab_Administrator_LabelText_ClientSurname.Location = new Point(58, 27);
            Tab_Administrator_LabelText_ClientSurname.Margin = new Padding(4, 0, 4, 0);
            Tab_Administrator_LabelText_ClientSurname.MouseState = MaterialSkin.MouseState.HOVER;
            Tab_Administrator_LabelText_ClientSurname.Name = "Tab_Administrator_LabelText_ClientSurname";
            Tab_Administrator_LabelText_ClientSurname.Size = new Size(233, 27);
            Tab_Administrator_LabelText_ClientSurname.TabIndex = 1;
            Tab_Administrator_LabelText_ClientSurname.Text = "Прізвище:";
            Tab_Administrator_LabelText_ClientSurname.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Tab_Administrator_LabelText_ClientName
            // 
            Tab_Administrator_LabelText_ClientName.Depth = 0;
            Tab_Administrator_LabelText_ClientName.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            Tab_Administrator_LabelText_ClientName.Location = new Point(58, 0);
            Tab_Administrator_LabelText_ClientName.Margin = new Padding(4, 0, 4, 0);
            Tab_Administrator_LabelText_ClientName.MouseState = MaterialSkin.MouseState.HOVER;
            Tab_Administrator_LabelText_ClientName.Name = "Tab_Administrator_LabelText_ClientName";
            Tab_Administrator_LabelText_ClientName.Size = new Size(233, 27);
            Tab_Administrator_LabelText_ClientName.TabIndex = 0;
            Tab_Administrator_LabelText_ClientName.Text = "Ім'я:";
            Tab_Administrator_LabelText_ClientName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.FromArgb(223, 223, 223);
            label1.Location = new Point(226, 37);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(483, 143);
            label1.TabIndex = 15;
            label1.Text = "Перелік залишених заявок:\r\n\r\nНа даний момент, заявок немає\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Tab_Client
            // 
            Tab_Client.BackColor = Color.FromArgb(50, 50, 50);
            Tab_Client.Controls.Add(Tab_Client_Button_MoveToSignIn);
            Tab_Client.Controls.Add(Tab_Client_Button_MoveToRequest);
            Tab_Client.Controls.Add(Tab_Client_Panel_RequesForm);
            Tab_Client.Controls.Add(label2);
            Tab_Client.Location = new Point(4, 24);
            Tab_Client.Margin = new Padding(4, 3, 4, 3);
            Tab_Client.Name = "Tab_Client";
            Tab_Client.Padding = new Padding(4, 3, 4, 3);
            Tab_Client.Size = new Size(935, 419);
            Tab_Client.TabIndex = 1;
            Tab_Client.Text = "Клієнт";
            // 
            // Tab_Client_Button_MoveToSignIn
            // 
            Tab_Client_Button_MoveToSignIn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Tab_Client_Button_MoveToSignIn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            Tab_Client_Button_MoveToSignIn.Depth = 0;
            Tab_Client_Button_MoveToSignIn.HighEmphasis = true;
            Tab_Client_Button_MoveToSignIn.Icon = (Image)resources.GetObject("Tab_Client_Button_MoveToSignIn.Icon");
            Tab_Client_Button_MoveToSignIn.Location = new Point(10, 7);
            Tab_Client_Button_MoveToSignIn.Margin = new Padding(5, 7, 5, 7);
            Tab_Client_Button_MoveToSignIn.MouseState = MaterialSkin.MouseState.HOVER;
            Tab_Client_Button_MoveToSignIn.Name = "Tab_Client_Button_MoveToSignIn";
            Tab_Client_Button_MoveToSignIn.NoAccentTextColor = Color.Empty;
            Tab_Client_Button_MoveToSignIn.Size = new Size(194, 36);
            Tab_Client_Button_MoveToSignIn.TabIndex = 17;
            Tab_Client_Button_MoveToSignIn.Text = "Меню авторизації";
            Tab_Client_Button_MoveToSignIn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            Tab_Client_Button_MoveToSignIn.UseAccentColor = false;
            Tab_Client_Button_MoveToSignIn.UseVisualStyleBackColor = true;
            Tab_Client_Button_MoveToSignIn.Click += Tab_Client_Button_MoveToSignIn_Click;
            // 
            // Tab_Client_Button_MoveToRequest
            // 
            Tab_Client_Button_MoveToRequest.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Tab_Client_Button_MoveToRequest.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            Tab_Client_Button_MoveToRequest.Depth = 0;
            Tab_Client_Button_MoveToRequest.HighEmphasis = true;
            Tab_Client_Button_MoveToRequest.Icon = (Image)resources.GetObject("Tab_Client_Button_MoveToRequest.Icon");
            Tab_Client_Button_MoveToRequest.Location = new Point(712, 7);
            Tab_Client_Button_MoveToRequest.Margin = new Padding(5, 7, 5, 7);
            Tab_Client_Button_MoveToRequest.MouseState = MaterialSkin.MouseState.HOVER;
            Tab_Client_Button_MoveToRequest.Name = "Tab_Client_Button_MoveToRequest";
            Tab_Client_Button_MoveToRequest.NoAccentTextColor = Color.Empty;
            Tab_Client_Button_MoveToRequest.Size = new Size(214, 36);
            Tab_Client_Button_MoveToRequest.TabIndex = 2;
            Tab_Client_Button_MoveToRequest.Text = "Оформлення заявки";
            Tab_Client_Button_MoveToRequest.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            Tab_Client_Button_MoveToRequest.UseAccentColor = false;
            Tab_Client_Button_MoveToRequest.UseVisualStyleBackColor = true;
            Tab_Client_Button_MoveToRequest.Click += Tab_Client_Button_MoveToRequest_Click;
            // 
            // Tab_Client_Panel_RequesForm
            // 
            Tab_Client_Panel_RequesForm.BorderStyle = BorderStyle.FixedSingle;
            Tab_Client_Panel_RequesForm.Controls.Add(Tab_Client_Label_ClientPhoneNumber);
            Tab_Client_Panel_RequesForm.Controls.Add(Tab_Client_LabelText_ClientPhoneNumber);
            Tab_Client_Panel_RequesForm.Controls.Add(Tab_Client_Button_Pay);
            Tab_Client_Panel_RequesForm.Controls.Add(Tab_Client_Label_RequestState);
            Tab_Client_Panel_RequesForm.Controls.Add(Tab_Client_Label_StayTime);
            Tab_Client_Panel_RequesForm.Controls.Add(Tab_Client_Label_ApartmentСlass);
            Tab_Client_Panel_RequesForm.Controls.Add(Tab_Client_Label_SleepingPlacesNumber);
            Tab_Client_Panel_RequesForm.Controls.Add(Tab_Client_Label_ClientPatronymic);
            Tab_Client_Panel_RequesForm.Controls.Add(Tab_Client_Label_ClientSurname);
            Tab_Client_Panel_RequesForm.Controls.Add(Tab_Client_Label_ClientName);
            Tab_Client_Panel_RequesForm.Controls.Add(Tab_Client_LabelText_RequestState);
            Tab_Client_Panel_RequesForm.Controls.Add(Tab_Client_LabelText_StayTime);
            Tab_Client_Panel_RequesForm.Controls.Add(Tab_Client_LabelText_ApartmentСlass);
            Tab_Client_Panel_RequesForm.Controls.Add(Tab_Client_LabelText_SleepingPlacesNumber);
            Tab_Client_Panel_RequesForm.Controls.Add(Tab_Client_LabelText_ClientPatronymic);
            Tab_Client_Panel_RequesForm.Controls.Add(Tab_Client_LabelText_ClientSurname);
            Tab_Client_Panel_RequesForm.Controls.Add(Tab_Client_LabelText_ClientName);
            Tab_Client_Panel_RequesForm.Location = new Point(170, 81);
            Tab_Client_Panel_RequesForm.Margin = new Padding(4, 3, 4, 3);
            Tab_Client_Panel_RequesForm.Name = "Tab_Client_Panel_RequesForm";
            Tab_Client_Panel_RequesForm.Size = new Size(592, 293);
            Tab_Client_Panel_RequesForm.TabIndex = 1;
            Tab_Client_Panel_RequesForm.Visible = false;
            // 
            // Tab_Client_Label_ClientPhoneNumber
            // 
            Tab_Client_Label_ClientPhoneNumber.Depth = 0;
            Tab_Client_Label_ClientPhoneNumber.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            Tab_Client_Label_ClientPhoneNumber.Location = new Point(298, 80);
            Tab_Client_Label_ClientPhoneNumber.Margin = new Padding(4, 0, 4, 0);
            Tab_Client_Label_ClientPhoneNumber.MouseState = MaterialSkin.MouseState.HOVER;
            Tab_Client_Label_ClientPhoneNumber.Name = "Tab_Client_Label_ClientPhoneNumber";
            Tab_Client_Label_ClientPhoneNumber.Size = new Size(233, 27);
            Tab_Client_Label_ClientPhoneNumber.TabIndex = 18;
            Tab_Client_Label_ClientPhoneNumber.Text = "PhoneNumber";
            Tab_Client_Label_ClientPhoneNumber.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Tab_Client_LabelText_ClientPhoneNumber
            // 
            Tab_Client_LabelText_ClientPhoneNumber.Depth = 0;
            Tab_Client_LabelText_ClientPhoneNumber.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            Tab_Client_LabelText_ClientPhoneNumber.Location = new Point(57, 80);
            Tab_Client_LabelText_ClientPhoneNumber.Margin = new Padding(4, 0, 4, 0);
            Tab_Client_LabelText_ClientPhoneNumber.MouseState = MaterialSkin.MouseState.HOVER;
            Tab_Client_LabelText_ClientPhoneNumber.Name = "Tab_Client_LabelText_ClientPhoneNumber";
            Tab_Client_LabelText_ClientPhoneNumber.Size = new Size(233, 27);
            Tab_Client_LabelText_ClientPhoneNumber.TabIndex = 17;
            Tab_Client_LabelText_ClientPhoneNumber.Text = "Номер телефону";
            Tab_Client_LabelText_ClientPhoneNumber.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Tab_Client_Button_Pay
            // 
            Tab_Client_Button_Pay.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Tab_Client_Button_Pay.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            Tab_Client_Button_Pay.Depth = 0;
            Tab_Client_Button_Pay.HighEmphasis = true;
            Tab_Client_Button_Pay.Icon = (Image)resources.GetObject("Tab_Client_Button_Pay.Icon");
            Tab_Client_Button_Pay.Location = new Point(197, 245);
            Tab_Client_Button_Pay.Margin = new Padding(5, 7, 5, 7);
            Tab_Client_Button_Pay.MouseState = MaterialSkin.MouseState.HOVER;
            Tab_Client_Button_Pay.Name = "Tab_Client_Button_Pay";
            Tab_Client_Button_Pay.NoAccentTextColor = Color.Empty;
            Tab_Client_Button_Pay.Size = new Size(189, 36);
            Tab_Client_Button_Pay.TabIndex = 13;
            Tab_Client_Button_Pay.Text = "Оплатити заявку";
            Tab_Client_Button_Pay.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            Tab_Client_Button_Pay.UseAccentColor = false;
            Tab_Client_Button_Pay.UseVisualStyleBackColor = true;
            Tab_Client_Button_Pay.Click += Tab_Client_Button_Pay_Click;
            // 
            // Tab_Client_Label_RequestState
            // 
            Tab_Client_Label_RequestState.Depth = 0;
            Tab_Client_Label_RequestState.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            Tab_Client_Label_RequestState.Location = new Point(299, 212);
            Tab_Client_Label_RequestState.Margin = new Padding(4, 0, 4, 0);
            Tab_Client_Label_RequestState.MouseState = MaterialSkin.MouseState.HOVER;
            Tab_Client_Label_RequestState.Name = "Tab_Client_Label_RequestState";
            Tab_Client_Label_RequestState.Size = new Size(233, 22);
            Tab_Client_Label_RequestState.TabIndex = 12;
            Tab_Client_Label_RequestState.Text = "State";
            Tab_Client_Label_RequestState.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Tab_Client_Label_StayTime
            // 
            Tab_Client_Label_StayTime.Depth = 0;
            Tab_Client_Label_StayTime.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            Tab_Client_Label_StayTime.Location = new Point(299, 186);
            Tab_Client_Label_StayTime.Margin = new Padding(4, 0, 4, 0);
            Tab_Client_Label_StayTime.MouseState = MaterialSkin.MouseState.HOVER;
            Tab_Client_Label_StayTime.Name = "Tab_Client_Label_StayTime";
            Tab_Client_Label_StayTime.Size = new Size(233, 27);
            Tab_Client_Label_StayTime.TabIndex = 11;
            Tab_Client_Label_StayTime.Text = "Time in D.H.M.";
            Tab_Client_Label_StayTime.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Tab_Client_Label_ApartmentСlass
            // 
            Tab_Client_Label_ApartmentСlass.Depth = 0;
            Tab_Client_Label_ApartmentСlass.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            Tab_Client_Label_ApartmentСlass.Location = new Point(299, 159);
            Tab_Client_Label_ApartmentСlass.Margin = new Padding(4, 0, 4, 0);
            Tab_Client_Label_ApartmentСlass.MouseState = MaterialSkin.MouseState.HOVER;
            Tab_Client_Label_ApartmentСlass.Name = "Tab_Client_Label_ApartmentСlass";
            Tab_Client_Label_ApartmentСlass.Size = new Size(233, 27);
            Tab_Client_Label_ApartmentСlass.TabIndex = 10;
            Tab_Client_Label_ApartmentСlass.Text = "Count";
            Tab_Client_Label_ApartmentСlass.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Tab_Client_Label_SleepingPlacesNumber
            // 
            Tab_Client_Label_SleepingPlacesNumber.Depth = 0;
            Tab_Client_Label_SleepingPlacesNumber.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            Tab_Client_Label_SleepingPlacesNumber.Location = new Point(299, 106);
            Tab_Client_Label_SleepingPlacesNumber.Margin = new Padding(4, 0, 4, 0);
            Tab_Client_Label_SleepingPlacesNumber.MouseState = MaterialSkin.MouseState.HOVER;
            Tab_Client_Label_SleepingPlacesNumber.Name = "Tab_Client_Label_SleepingPlacesNumber";
            Tab_Client_Label_SleepingPlacesNumber.Size = new Size(233, 53);
            Tab_Client_Label_SleepingPlacesNumber.TabIndex = 9;
            Tab_Client_Label_SleepingPlacesNumber.Text = "Count";
            Tab_Client_Label_SleepingPlacesNumber.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Tab_Client_Label_ClientPatronymic
            // 
            Tab_Client_Label_ClientPatronymic.Depth = 0;
            Tab_Client_Label_ClientPatronymic.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            Tab_Client_Label_ClientPatronymic.Location = new Point(299, 53);
            Tab_Client_Label_ClientPatronymic.Margin = new Padding(4, 0, 4, 0);
            Tab_Client_Label_ClientPatronymic.MouseState = MaterialSkin.MouseState.HOVER;
            Tab_Client_Label_ClientPatronymic.Name = "Tab_Client_Label_ClientPatronymic";
            Tab_Client_Label_ClientPatronymic.Size = new Size(233, 27);
            Tab_Client_Label_ClientPatronymic.TabIndex = 8;
            Tab_Client_Label_ClientPatronymic.Text = "Patronymic";
            Tab_Client_Label_ClientPatronymic.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Tab_Client_Label_ClientSurname
            // 
            Tab_Client_Label_ClientSurname.Depth = 0;
            Tab_Client_Label_ClientSurname.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            Tab_Client_Label_ClientSurname.Location = new Point(299, 27);
            Tab_Client_Label_ClientSurname.Margin = new Padding(4, 0, 4, 0);
            Tab_Client_Label_ClientSurname.MouseState = MaterialSkin.MouseState.HOVER;
            Tab_Client_Label_ClientSurname.Name = "Tab_Client_Label_ClientSurname";
            Tab_Client_Label_ClientSurname.Size = new Size(233, 27);
            Tab_Client_Label_ClientSurname.TabIndex = 7;
            Tab_Client_Label_ClientSurname.Text = "Surname";
            Tab_Client_Label_ClientSurname.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Tab_Client_Label_ClientName
            // 
            Tab_Client_Label_ClientName.Depth = 0;
            Tab_Client_Label_ClientName.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            Tab_Client_Label_ClientName.Location = new Point(299, 0);
            Tab_Client_Label_ClientName.Margin = new Padding(4, 0, 4, 0);
            Tab_Client_Label_ClientName.MouseState = MaterialSkin.MouseState.HOVER;
            Tab_Client_Label_ClientName.Name = "Tab_Client_Label_ClientName";
            Tab_Client_Label_ClientName.Size = new Size(233, 27);
            Tab_Client_Label_ClientName.TabIndex = 6;
            Tab_Client_Label_ClientName.Text = "Name";
            Tab_Client_Label_ClientName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Tab_Client_LabelText_RequestState
            // 
            Tab_Client_LabelText_RequestState.Depth = 0;
            Tab_Client_LabelText_RequestState.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            Tab_Client_LabelText_RequestState.Location = new Point(58, 212);
            Tab_Client_LabelText_RequestState.Margin = new Padding(4, 0, 4, 0);
            Tab_Client_LabelText_RequestState.MouseState = MaterialSkin.MouseState.HOVER;
            Tab_Client_LabelText_RequestState.Name = "Tab_Client_LabelText_RequestState";
            Tab_Client_LabelText_RequestState.Size = new Size(233, 22);
            Tab_Client_LabelText_RequestState.TabIndex = 5;
            Tab_Client_LabelText_RequestState.Text = "Стан заявки:";
            Tab_Client_LabelText_RequestState.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Tab_Client_LabelText_StayTime
            // 
            Tab_Client_LabelText_StayTime.Depth = 0;
            Tab_Client_LabelText_StayTime.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            Tab_Client_LabelText_StayTime.Location = new Point(58, 186);
            Tab_Client_LabelText_StayTime.Margin = new Padding(4, 0, 4, 0);
            Tab_Client_LabelText_StayTime.MouseState = MaterialSkin.MouseState.HOVER;
            Tab_Client_LabelText_StayTime.Name = "Tab_Client_LabelText_StayTime";
            Tab_Client_LabelText_StayTime.Size = new Size(233, 27);
            Tab_Client_LabelText_StayTime.TabIndex = 4;
            Tab_Client_LabelText_StayTime.Text = "Час перебування:";
            Tab_Client_LabelText_StayTime.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Tab_Client_LabelText_ApartmentСlass
            // 
            Tab_Client_LabelText_ApartmentСlass.Depth = 0;
            Tab_Client_LabelText_ApartmentСlass.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            Tab_Client_LabelText_ApartmentСlass.Location = new Point(58, 159);
            Tab_Client_LabelText_ApartmentСlass.Margin = new Padding(4, 0, 4, 0);
            Tab_Client_LabelText_ApartmentСlass.MouseState = MaterialSkin.MouseState.HOVER;
            Tab_Client_LabelText_ApartmentСlass.Name = "Tab_Client_LabelText_ApartmentСlass";
            Tab_Client_LabelText_ApartmentСlass.Size = new Size(233, 27);
            Tab_Client_LabelText_ApartmentСlass.TabIndex = 3;
            Tab_Client_LabelText_ApartmentСlass.Text = "Клас апартаментів:";
            Tab_Client_LabelText_ApartmentСlass.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Tab_Client_LabelText_SleepingPlacesNumber
            // 
            Tab_Client_LabelText_SleepingPlacesNumber.Depth = 0;
            Tab_Client_LabelText_SleepingPlacesNumber.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            Tab_Client_LabelText_SleepingPlacesNumber.Location = new Point(58, 120);
            Tab_Client_LabelText_SleepingPlacesNumber.Margin = new Padding(4, 0, 4, 0);
            Tab_Client_LabelText_SleepingPlacesNumber.MouseState = MaterialSkin.MouseState.HOVER;
            Tab_Client_LabelText_SleepingPlacesNumber.Name = "Tab_Client_LabelText_SleepingPlacesNumber";
            Tab_Client_LabelText_SleepingPlacesNumber.Size = new Size(233, 27);
            Tab_Client_LabelText_SleepingPlacesNumber.TabIndex = 2;
            Tab_Client_LabelText_SleepingPlacesNumber.Text = "Кількість місць у номері:";
            Tab_Client_LabelText_SleepingPlacesNumber.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Tab_Client_LabelText_ClientPatronymic
            // 
            Tab_Client_LabelText_ClientPatronymic.Depth = 0;
            Tab_Client_LabelText_ClientPatronymic.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            Tab_Client_LabelText_ClientPatronymic.Location = new Point(58, 53);
            Tab_Client_LabelText_ClientPatronymic.Margin = new Padding(4, 0, 4, 0);
            Tab_Client_LabelText_ClientPatronymic.MouseState = MaterialSkin.MouseState.HOVER;
            Tab_Client_LabelText_ClientPatronymic.Name = "Tab_Client_LabelText_ClientPatronymic";
            Tab_Client_LabelText_ClientPatronymic.Size = new Size(233, 27);
            Tab_Client_LabelText_ClientPatronymic.TabIndex = 1;
            Tab_Client_LabelText_ClientPatronymic.Text = "По батькові:";
            Tab_Client_LabelText_ClientPatronymic.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Tab_Client_LabelText_ClientSurname
            // 
            Tab_Client_LabelText_ClientSurname.Depth = 0;
            Tab_Client_LabelText_ClientSurname.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            Tab_Client_LabelText_ClientSurname.Location = new Point(58, 27);
            Tab_Client_LabelText_ClientSurname.Margin = new Padding(4, 0, 4, 0);
            Tab_Client_LabelText_ClientSurname.MouseState = MaterialSkin.MouseState.HOVER;
            Tab_Client_LabelText_ClientSurname.Name = "Tab_Client_LabelText_ClientSurname";
            Tab_Client_LabelText_ClientSurname.Size = new Size(233, 27);
            Tab_Client_LabelText_ClientSurname.TabIndex = 1;
            Tab_Client_LabelText_ClientSurname.Text = "Прізвище:";
            Tab_Client_LabelText_ClientSurname.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Tab_Client_LabelText_ClientName
            // 
            Tab_Client_LabelText_ClientName.Depth = 0;
            Tab_Client_LabelText_ClientName.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            Tab_Client_LabelText_ClientName.Location = new Point(58, 0);
            Tab_Client_LabelText_ClientName.Margin = new Padding(4, 0, 4, 0);
            Tab_Client_LabelText_ClientName.MouseState = MaterialSkin.MouseState.HOVER;
            Tab_Client_LabelText_ClientName.Name = "Tab_Client_LabelText_ClientName";
            Tab_Client_LabelText_ClientName.Size = new Size(233, 27);
            Tab_Client_LabelText_ClientName.TabIndex = 0;
            Tab_Client_LabelText_ClientName.Text = "Ім'я:";
            Tab_Client_LabelText_ClientName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.FromArgb(223, 223, 223);
            label2.Location = new Point(225, 137);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(483, 143);
            label2.TabIndex = 16;
            label2.Text = "У вас ще немає створеної заявки. Перейдіть у меню оформлення заявки для створення заявки";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Tab_Request
            // 
            Tab_Request.BackColor = Color.FromArgb(50, 50, 50);
            Tab_Request.Controls.Add(Tab_Request_Button_MoveToClient);
            Tab_Request.Controls.Add(Tab_Request_LabelText_StayTime);
            Tab_Request.Controls.Add(Tab_Request_LabelText_Minutes);
            Tab_Request.Controls.Add(Tab_Request_LabelText_Hours);
            Tab_Request.Controls.Add(Tab_Request_LabelText_Days);
            Tab_Request.Controls.Add(Tab_Request_Label_MinutesCount);
            Tab_Request.Controls.Add(Tab_Request_Label_HoursCount);
            Tab_Request.Controls.Add(Tab_Request_Label_DaysCount);
            Tab_Request.Controls.Add(Tab_Request_ComboBox_SleepingPlacesNumber);
            Tab_Request.Controls.Add(Tab_Request_ComboBox_ApartmentСlass);
            Tab_Request.Controls.Add(Tab_Request_Button_MinutesUp);
            Tab_Request.Controls.Add(Tab_Request_Button_MinutesDown);
            Tab_Request.Controls.Add(Tab_Request_Button_HoursUp);
            Tab_Request.Controls.Add(Tab_Request_Button_HoursDown);
            Tab_Request.Controls.Add(Tab_Request_Button_DaysDown);
            Tab_Request.Controls.Add(Tab_Request_Button_DaysUp);
            Tab_Request.Controls.Add(Tab_Request_Buttonn_SendRequest);
            Tab_Request.Location = new Point(4, 24);
            Tab_Request.Margin = new Padding(4, 3, 4, 3);
            Tab_Request.Name = "Tab_Request";
            Tab_Request.Size = new Size(935, 419);
            Tab_Request.TabIndex = 2;
            Tab_Request.Text = "Заявка";
            // 
            // Tab_Request_Button_MoveToClient
            // 
            Tab_Request_Button_MoveToClient.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Tab_Request_Button_MoveToClient.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            Tab_Request_Button_MoveToClient.Depth = 0;
            Tab_Request_Button_MoveToClient.HighEmphasis = true;
            Tab_Request_Button_MoveToClient.Icon = (Image)resources.GetObject("Tab_Request_Button_MoveToClient.Icon");
            Tab_Request_Button_MoveToClient.Location = new Point(8, 7);
            Tab_Request_Button_MoveToClient.Margin = new Padding(5, 7, 5, 7);
            Tab_Request_Button_MoveToClient.MouseState = MaterialSkin.MouseState.HOVER;
            Tab_Request_Button_MoveToClient.Name = "Tab_Request_Button_MoveToClient";
            Tab_Request_Button_MoveToClient.NoAccentTextColor = Color.Empty;
            Tab_Request_Button_MoveToClient.Size = new Size(110, 36);
            Tab_Request_Button_MoveToClient.TabIndex = 18;
            Tab_Request_Button_MoveToClient.Text = "Кабінет";
            Tab_Request_Button_MoveToClient.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            Tab_Request_Button_MoveToClient.UseAccentColor = false;
            Tab_Request_Button_MoveToClient.UseVisualStyleBackColor = true;
            Tab_Request_Button_MoveToClient.Click += Tab_Request_Button_MoveToClient_Click;
            // 
            // Tab_Request_LabelText_StayTime
            // 
            Tab_Request_LabelText_StayTime.Depth = 0;
            Tab_Request_LabelText_StayTime.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            Tab_Request_LabelText_StayTime.Location = new Point(204, 209);
            Tab_Request_LabelText_StayTime.Margin = new Padding(4, 0, 4, 0);
            Tab_Request_LabelText_StayTime.MouseState = MaterialSkin.MouseState.HOVER;
            Tab_Request_LabelText_StayTime.Name = "Tab_Request_LabelText_StayTime";
            Tab_Request_LabelText_StayTime.Size = new Size(166, 57);
            Tab_Request_LabelText_StayTime.TabIndex = 17;
            Tab_Request_LabelText_StayTime.Text = "Час перебування:";
            Tab_Request_LabelText_StayTime.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Tab_Request_LabelText_Minutes
            // 
            Tab_Request_LabelText_Minutes.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_Request_LabelText_Minutes.Location = new Point(505, 211);
            Tab_Request_LabelText_Minutes.Margin = new Padding(4, 0, 4, 0);
            Tab_Request_LabelText_Minutes.Name = "Tab_Request_LabelText_Minutes";
            Tab_Request_LabelText_Minutes.Size = new Size(54, 14);
            Tab_Request_LabelText_Minutes.TabIndex = 16;
            Tab_Request_LabelText_Minutes.Text = "Хвилин";
            // 
            // Tab_Request_LabelText_Hours
            // 
            Tab_Request_LabelText_Hours.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_Request_LabelText_Hours.Location = new Point(441, 211);
            Tab_Request_LabelText_Hours.Margin = new Padding(4, 0, 4, 0);
            Tab_Request_LabelText_Hours.Name = "Tab_Request_LabelText_Hours";
            Tab_Request_LabelText_Hours.Size = new Size(54, 14);
            Tab_Request_LabelText_Hours.TabIndex = 15;
            Tab_Request_LabelText_Hours.Text = "Годин";
            Tab_Request_LabelText_Hours.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Tab_Request_LabelText_Days
            // 
            Tab_Request_LabelText_Days.ForeColor = Color.FromArgb(230, 230, 230);
            Tab_Request_LabelText_Days.Location = new Point(377, 211);
            Tab_Request_LabelText_Days.Margin = new Padding(4, 0, 4, 0);
            Tab_Request_LabelText_Days.Name = "Tab_Request_LabelText_Days";
            Tab_Request_LabelText_Days.Size = new Size(54, 14);
            Tab_Request_LabelText_Days.TabIndex = 14;
            Tab_Request_LabelText_Days.Text = "Днів";
            Tab_Request_LabelText_Days.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Tab_Request_Label_MinutesCount
            // 
            Tab_Request_Label_MinutesCount.BorderStyle = BorderStyle.FixedSingle;
            Tab_Request_Label_MinutesCount.Depth = 0;
            Tab_Request_Label_MinutesCount.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            Tab_Request_Label_MinutesCount.Location = new Point(503, 209);
            Tab_Request_Label_MinutesCount.Margin = new Padding(4, 0, 4, 0);
            Tab_Request_Label_MinutesCount.MouseState = MaterialSkin.MouseState.HOVER;
            Tab_Request_Label_MinutesCount.Name = "Tab_Request_Label_MinutesCount";
            Tab_Request_Label_MinutesCount.Size = new Size(57, 56);
            Tab_Request_Label_MinutesCount.TabIndex = 6;
            Tab_Request_Label_MinutesCount.Text = "0";
            Tab_Request_Label_MinutesCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Tab_Request_Label_HoursCount
            // 
            Tab_Request_Label_HoursCount.BorderStyle = BorderStyle.FixedSingle;
            Tab_Request_Label_HoursCount.Depth = 0;
            Tab_Request_Label_HoursCount.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            Tab_Request_Label_HoursCount.Location = new Point(439, 209);
            Tab_Request_Label_HoursCount.Margin = new Padding(4, 0, 4, 0);
            Tab_Request_Label_HoursCount.MouseState = MaterialSkin.MouseState.HOVER;
            Tab_Request_Label_HoursCount.Name = "Tab_Request_Label_HoursCount";
            Tab_Request_Label_HoursCount.Size = new Size(57, 56);
            Tab_Request_Label_HoursCount.TabIndex = 5;
            Tab_Request_Label_HoursCount.Text = "0";
            Tab_Request_Label_HoursCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Tab_Request_Label_DaysCount
            // 
            Tab_Request_Label_DaysCount.BorderStyle = BorderStyle.FixedSingle;
            Tab_Request_Label_DaysCount.Depth = 0;
            Tab_Request_Label_DaysCount.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            Tab_Request_Label_DaysCount.Location = new Point(374, 209);
            Tab_Request_Label_DaysCount.Margin = new Padding(4, 0, 4, 0);
            Tab_Request_Label_DaysCount.MouseState = MaterialSkin.MouseState.HOVER;
            Tab_Request_Label_DaysCount.Name = "Tab_Request_Label_DaysCount";
            Tab_Request_Label_DaysCount.Size = new Size(57, 56);
            Tab_Request_Label_DaysCount.TabIndex = 4;
            Tab_Request_Label_DaysCount.Text = "0";
            Tab_Request_Label_DaysCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Tab_Request_ComboBox_SleepingPlacesNumber
            // 
            Tab_Request_ComboBox_SleepingPlacesNumber.AutoResize = false;
            Tab_Request_ComboBox_SleepingPlacesNumber.BackColor = Color.FromArgb(255, 255, 255);
            Tab_Request_ComboBox_SleepingPlacesNumber.Depth = 0;
            Tab_Request_ComboBox_SleepingPlacesNumber.DrawMode = DrawMode.OwnerDrawVariable;
            Tab_Request_ComboBox_SleepingPlacesNumber.DropDownHeight = 174;
            Tab_Request_ComboBox_SleepingPlacesNumber.DropDownStyle = ComboBoxStyle.DropDownList;
            Tab_Request_ComboBox_SleepingPlacesNumber.DropDownWidth = 121;
            Tab_Request_ComboBox_SleepingPlacesNumber.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            Tab_Request_ComboBox_SleepingPlacesNumber.ForeColor = Color.FromArgb(222, 0, 0, 0);
            Tab_Request_ComboBox_SleepingPlacesNumber.FormattingEnabled = true;
            Tab_Request_ComboBox_SleepingPlacesNumber.Hint = "Кількість місць у номері";
            Tab_Request_ComboBox_SleepingPlacesNumber.IntegralHeight = false;
            Tab_Request_ComboBox_SleepingPlacesNumber.ItemHeight = 43;
            Tab_Request_ComboBox_SleepingPlacesNumber.Items.AddRange(new object[] { "Одномісний з одномісним ліжком", "Одноміснйи з двомісним ліжком", "Двомісний з одним двухмісним ліжком", "Двомісний з двома одномісними ліжками", "Трьохмісний з трьома одномісними ліжками", "Трьохмісний з одномісним та двохмісним ліжком", "Чотирьохмісний з двома двомісними ліжками" });
            Tab_Request_ComboBox_SleepingPlacesNumber.Location = new Point(210, 22);
            Tab_Request_ComboBox_SleepingPlacesNumber.Margin = new Padding(4, 3, 4, 3);
            Tab_Request_ComboBox_SleepingPlacesNumber.MaxDropDownItems = 4;
            Tab_Request_ComboBox_SleepingPlacesNumber.MouseState = MaterialSkin.MouseState.OUT;
            Tab_Request_ComboBox_SleepingPlacesNumber.Name = "Tab_Request_ComboBox_SleepingPlacesNumber";
            Tab_Request_ComboBox_SleepingPlacesNumber.Size = new Size(513, 49);
            Tab_Request_ComboBox_SleepingPlacesNumber.StartIndex = 0;
            Tab_Request_ComboBox_SleepingPlacesNumber.TabIndex = 3;
            // 
            // Tab_Request_ComboBox_ApartmentСlass
            // 
            Tab_Request_ComboBox_ApartmentСlass.AutoResize = false;
            Tab_Request_ComboBox_ApartmentСlass.BackColor = Color.FromArgb(255, 255, 255);
            Tab_Request_ComboBox_ApartmentСlass.Depth = 0;
            Tab_Request_ComboBox_ApartmentСlass.DrawMode = DrawMode.OwnerDrawVariable;
            Tab_Request_ComboBox_ApartmentСlass.DropDownHeight = 174;
            Tab_Request_ComboBox_ApartmentСlass.DropDownStyle = ComboBoxStyle.DropDownList;
            Tab_Request_ComboBox_ApartmentСlass.DropDownWidth = 121;
            Tab_Request_ComboBox_ApartmentСlass.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            Tab_Request_ComboBox_ApartmentСlass.ForeColor = Color.FromArgb(222, 0, 0, 0);
            Tab_Request_ComboBox_ApartmentСlass.FormattingEnabled = true;
            Tab_Request_ComboBox_ApartmentСlass.Hint = "Клас апартаментів";
            Tab_Request_ComboBox_ApartmentСlass.IntegralHeight = false;
            Tab_Request_ComboBox_ApartmentСlass.ItemHeight = 43;
            Tab_Request_ComboBox_ApartmentСlass.Items.AddRange(new object[] { "Економ", "Економ+", "Бізнес", "Люкс", "Преміум" });
            Tab_Request_ComboBox_ApartmentСlass.Location = new Point(350, 85);
            Tab_Request_ComboBox_ApartmentСlass.Margin = new Padding(4, 3, 4, 3);
            Tab_Request_ComboBox_ApartmentСlass.MaxDropDownItems = 4;
            Tab_Request_ComboBox_ApartmentСlass.MouseState = MaterialSkin.MouseState.OUT;
            Tab_Request_ComboBox_ApartmentСlass.Name = "Tab_Request_ComboBox_ApartmentСlass";
            Tab_Request_ComboBox_ApartmentСlass.Size = new Size(233, 49);
            Tab_Request_ComboBox_ApartmentСlass.StartIndex = 0;
            Tab_Request_ComboBox_ApartmentСlass.TabIndex = 2;
            // 
            // Tab_Request_Button_MinutesUp
            // 
            Tab_Request_Button_MinutesUp.AutoSize = false;
            Tab_Request_Button_MinutesUp.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Tab_Request_Button_MinutesUp.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            Tab_Request_Button_MinutesUp.Depth = 0;
            Tab_Request_Button_MinutesUp.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Tab_Request_Button_MinutesUp.HighEmphasis = true;
            Tab_Request_Button_MinutesUp.Icon = (Image)resources.GetObject("Tab_Request_Button_MinutesUp.Icon");
            Tab_Request_Button_MinutesUp.Location = new Point(507, 160);
            Tab_Request_Button_MinutesUp.Margin = new Padding(5, 7, 5, 7);
            Tab_Request_Button_MinutesUp.MouseState = MaterialSkin.MouseState.HOVER;
            Tab_Request_Button_MinutesUp.Name = "Tab_Request_Button_MinutesUp";
            Tab_Request_Button_MinutesUp.NoAccentTextColor = Color.Empty;
            Tab_Request_Button_MinutesUp.Size = new Size(40, 44);
            Tab_Request_Button_MinutesUp.TabIndex = 13;
            Tab_Request_Button_MinutesUp.Text = "1";
            Tab_Request_Button_MinutesUp.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            Tab_Request_Button_MinutesUp.UseAccentColor = false;
            Tab_Request_Button_MinutesUp.UseVisualStyleBackColor = true;
            Tab_Request_Button_MinutesUp.Click += Tab_Request_Button_MinutesUp_Click;
            // 
            // Tab_Request_Button_MinutesDown
            // 
            Tab_Request_Button_MinutesDown.AutoSize = false;
            Tab_Request_Button_MinutesDown.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Tab_Request_Button_MinutesDown.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            Tab_Request_Button_MinutesDown.Depth = 0;
            Tab_Request_Button_MinutesDown.Enabled = false;
            Tab_Request_Button_MinutesDown.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Tab_Request_Button_MinutesDown.HighEmphasis = true;
            Tab_Request_Button_MinutesDown.Icon = (Image)resources.GetObject("Tab_Request_Button_MinutesDown.Icon");
            Tab_Request_Button_MinutesDown.Location = new Point(507, 272);
            Tab_Request_Button_MinutesDown.Margin = new Padding(5, 7, 5, 7);
            Tab_Request_Button_MinutesDown.MouseState = MaterialSkin.MouseState.HOVER;
            Tab_Request_Button_MinutesDown.Name = "Tab_Request_Button_MinutesDown";
            Tab_Request_Button_MinutesDown.NoAccentTextColor = Color.Empty;
            Tab_Request_Button_MinutesDown.Size = new Size(40, 44);
            Tab_Request_Button_MinutesDown.TabIndex = 12;
            Tab_Request_Button_MinutesDown.Text = "1";
            Tab_Request_Button_MinutesDown.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            Tab_Request_Button_MinutesDown.UseAccentColor = false;
            Tab_Request_Button_MinutesDown.UseVisualStyleBackColor = true;
            Tab_Request_Button_MinutesDown.Click += Tab_Request_Button_MinutesDown_Click;
            // 
            // Tab_Request_Button_HoursUp
            // 
            Tab_Request_Button_HoursUp.AutoSize = false;
            Tab_Request_Button_HoursUp.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Tab_Request_Button_HoursUp.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            Tab_Request_Button_HoursUp.Depth = 0;
            Tab_Request_Button_HoursUp.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Tab_Request_Button_HoursUp.HighEmphasis = true;
            Tab_Request_Button_HoursUp.Icon = (Image)resources.GetObject("Tab_Request_Button_HoursUp.Icon");
            Tab_Request_Button_HoursUp.Location = new Point(443, 160);
            Tab_Request_Button_HoursUp.Margin = new Padding(5, 7, 5, 7);
            Tab_Request_Button_HoursUp.MouseState = MaterialSkin.MouseState.HOVER;
            Tab_Request_Button_HoursUp.Name = "Tab_Request_Button_HoursUp";
            Tab_Request_Button_HoursUp.NoAccentTextColor = Color.Empty;
            Tab_Request_Button_HoursUp.Size = new Size(40, 44);
            Tab_Request_Button_HoursUp.TabIndex = 11;
            Tab_Request_Button_HoursUp.Text = "1";
            Tab_Request_Button_HoursUp.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            Tab_Request_Button_HoursUp.UseAccentColor = false;
            Tab_Request_Button_HoursUp.UseVisualStyleBackColor = true;
            Tab_Request_Button_HoursUp.Click += Tab_Request_Button_HoursUp_Click;
            // 
            // Tab_Request_Button_HoursDown
            // 
            Tab_Request_Button_HoursDown.AutoSize = false;
            Tab_Request_Button_HoursDown.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Tab_Request_Button_HoursDown.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            Tab_Request_Button_HoursDown.Depth = 0;
            Tab_Request_Button_HoursDown.Enabled = false;
            Tab_Request_Button_HoursDown.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Tab_Request_Button_HoursDown.HighEmphasis = true;
            Tab_Request_Button_HoursDown.Icon = (Image)resources.GetObject("Tab_Request_Button_HoursDown.Icon");
            Tab_Request_Button_HoursDown.Location = new Point(443, 272);
            Tab_Request_Button_HoursDown.Margin = new Padding(5, 7, 5, 7);
            Tab_Request_Button_HoursDown.MouseState = MaterialSkin.MouseState.HOVER;
            Tab_Request_Button_HoursDown.Name = "Tab_Request_Button_HoursDown";
            Tab_Request_Button_HoursDown.NoAccentTextColor = Color.Empty;
            Tab_Request_Button_HoursDown.Size = new Size(40, 44);
            Tab_Request_Button_HoursDown.TabIndex = 10;
            Tab_Request_Button_HoursDown.Text = "1";
            Tab_Request_Button_HoursDown.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            Tab_Request_Button_HoursDown.UseAccentColor = false;
            Tab_Request_Button_HoursDown.UseVisualStyleBackColor = true;
            Tab_Request_Button_HoursDown.Click += Tab_Request_Button_HoursDown_Click;
            // 
            // Tab_Request_Button_DaysDown
            // 
            Tab_Request_Button_DaysDown.AutoSize = false;
            Tab_Request_Button_DaysDown.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Tab_Request_Button_DaysDown.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            Tab_Request_Button_DaysDown.Depth = 0;
            Tab_Request_Button_DaysDown.Enabled = false;
            Tab_Request_Button_DaysDown.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Tab_Request_Button_DaysDown.HighEmphasis = true;
            Tab_Request_Button_DaysDown.Icon = (Image)resources.GetObject("Tab_Request_Button_DaysDown.Icon");
            Tab_Request_Button_DaysDown.Location = new Point(379, 272);
            Tab_Request_Button_DaysDown.Margin = new Padding(5, 7, 5, 7);
            Tab_Request_Button_DaysDown.MouseState = MaterialSkin.MouseState.HOVER;
            Tab_Request_Button_DaysDown.Name = "Tab_Request_Button_DaysDown";
            Tab_Request_Button_DaysDown.NoAccentTextColor = Color.Empty;
            Tab_Request_Button_DaysDown.Size = new Size(40, 44);
            Tab_Request_Button_DaysDown.TabIndex = 8;
            Tab_Request_Button_DaysDown.Text = "1";
            Tab_Request_Button_DaysDown.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            Tab_Request_Button_DaysDown.UseAccentColor = false;
            Tab_Request_Button_DaysDown.UseVisualStyleBackColor = true;
            Tab_Request_Button_DaysDown.Click += Tab_Request_Button_DaysDown_Click;
            // 
            // Tab_Request_Button_DaysUp
            // 
            Tab_Request_Button_DaysUp.AutoSize = false;
            Tab_Request_Button_DaysUp.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Tab_Request_Button_DaysUp.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            Tab_Request_Button_DaysUp.Depth = 0;
            Tab_Request_Button_DaysUp.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Tab_Request_Button_DaysUp.HighEmphasis = true;
            Tab_Request_Button_DaysUp.Icon = (Image)resources.GetObject("Tab_Request_Button_DaysUp.Icon");
            Tab_Request_Button_DaysUp.Location = new Point(379, 160);
            Tab_Request_Button_DaysUp.Margin = new Padding(5, 7, 5, 7);
            Tab_Request_Button_DaysUp.MouseState = MaterialSkin.MouseState.HOVER;
            Tab_Request_Button_DaysUp.Name = "Tab_Request_Button_DaysUp";
            Tab_Request_Button_DaysUp.NoAccentTextColor = Color.Empty;
            Tab_Request_Button_DaysUp.Size = new Size(40, 44);
            Tab_Request_Button_DaysUp.TabIndex = 7;
            Tab_Request_Button_DaysUp.Text = "1";
            Tab_Request_Button_DaysUp.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            Tab_Request_Button_DaysUp.UseAccentColor = false;
            Tab_Request_Button_DaysUp.UseVisualStyleBackColor = true;
            Tab_Request_Button_DaysUp.Click += Tab_Request_Button_DaysUp_Click;
            // 
            // Tab_Request_Buttonn_SendRequest
            // 
            Tab_Request_Buttonn_SendRequest.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Tab_Request_Buttonn_SendRequest.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            Tab_Request_Buttonn_SendRequest.Depth = 0;
            Tab_Request_Buttonn_SendRequest.HighEmphasis = true;
            Tab_Request_Buttonn_SendRequest.Icon = (Image)resources.GetObject("Tab_Request_Buttonn_SendRequest.Icon");
            Tab_Request_Buttonn_SendRequest.Location = new Point(363, 341);
            Tab_Request_Buttonn_SendRequest.Margin = new Padding(5, 7, 5, 7);
            Tab_Request_Buttonn_SendRequest.MouseState = MaterialSkin.MouseState.HOVER;
            Tab_Request_Buttonn_SendRequest.Name = "Tab_Request_Buttonn_SendRequest";
            Tab_Request_Buttonn_SendRequest.NoAccentTextColor = Color.Empty;
            Tab_Request_Buttonn_SendRequest.Size = new Size(202, 36);
            Tab_Request_Buttonn_SendRequest.TabIndex = 0;
            Tab_Request_Buttonn_SendRequest.Text = "Відправити заявку";
            Tab_Request_Buttonn_SendRequest.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            Tab_Request_Buttonn_SendRequest.UseAccentColor = false;
            Tab_Request_Buttonn_SendRequest.UseVisualStyleBackColor = true;
            Tab_Request_Buttonn_SendRequest.Click += Tab_Request_Buttonn_SendRequest_Click;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(50, 50, 50);
            tabPage1.Controls.Add(Tab_Trash_Button_LINQ);
            tabPage1.Controls.Add(Tab_Trash_Button_IteratorFunc);
            tabPage1.Controls.Add(Tab_Trash_Button_UniversalDelegate);
            tabPage1.Controls.Add(Tab_Trash_Button_UniversalFunc2);
            tabPage1.Controls.Add(Tab_Trash_Button_UniversalFunc1);
            tabPage1.Controls.Add(Tab_Trash_Button_UniversalClassFromInterfaceFunc);
            tabPage1.Controls.Add(Tab_Trash_Button_UniversalClassFunc);
            tabPage1.Controls.Add(Tab_Trash_Button_LambdaExpression3);
            tabPage1.Controls.Add(Tab_Trash_Button_LambdaExpression2);
            tabPage1.Controls.Add(Tab_Trash_Button_LambdaExpression1);
            tabPage1.Controls.Add(Tab_Trash_Button_AnonymousFunction3);
            tabPage1.Controls.Add(Tab_Trash_Button_AnonymousFunction2);
            tabPage1.Controls.Add(Tab_Trash_Button_AnonymousFunction1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(4, 3, 4, 3);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(935, 419);
            tabPage1.TabIndex = 5;
            tabPage1.Text = "Відпрацювання мусорного коду";
            // 
            // Tab_Trash_Button_IteratorFunc
            // 
            Tab_Trash_Button_IteratorFunc.Location = new Point(173, 219);
            Tab_Trash_Button_IteratorFunc.Margin = new Padding(4, 3, 4, 3);
            Tab_Trash_Button_IteratorFunc.Name = "Tab_Trash_Button_IteratorFunc";
            Tab_Trash_Button_IteratorFunc.Size = new Size(147, 27);
            Tab_Trash_Button_IteratorFunc.TabIndex = 11;
            Tab_Trash_Button_IteratorFunc.Text = "Iterator Func";
            Tab_Trash_Button_IteratorFunc.UseVisualStyleBackColor = true;
            Tab_Trash_Button_IteratorFunc.Click += Tab_Trash_Button_IteratorFunc_Click;
            // 
            // Tab_Trash_Button_UniversalDelegate
            // 
            Tab_Trash_Button_UniversalDelegate.Location = new Point(173, 186);
            Tab_Trash_Button_UniversalDelegate.Margin = new Padding(4, 3, 4, 3);
            Tab_Trash_Button_UniversalDelegate.Name = "Tab_Trash_Button_UniversalDelegate";
            Tab_Trash_Button_UniversalDelegate.Size = new Size(147, 27);
            Tab_Trash_Button_UniversalDelegate.TabIndex = 10;
            Tab_Trash_Button_UniversalDelegate.Text = "Universal Delegates";
            Tab_Trash_Button_UniversalDelegate.UseVisualStyleBackColor = true;
            Tab_Trash_Button_UniversalDelegate.Click += Tab_Trash_Button_UniversalDelegate_Click;
            // 
            // Tab_Trash_Button_UniversalFunc2
            // 
            Tab_Trash_Button_UniversalFunc2.Location = new Point(173, 152);
            Tab_Trash_Button_UniversalFunc2.Margin = new Padding(4, 3, 4, 3);
            Tab_Trash_Button_UniversalFunc2.Name = "Tab_Trash_Button_UniversalFunc2";
            Tab_Trash_Button_UniversalFunc2.Size = new Size(147, 27);
            Tab_Trash_Button_UniversalFunc2.TabIndex = 9;
            Tab_Trash_Button_UniversalFunc2.Text = "Universal Func2";
            Tab_Trash_Button_UniversalFunc2.UseVisualStyleBackColor = true;
            Tab_Trash_Button_UniversalFunc2.Click += Tab_Trash_Button_UniversalFunc2_Click;
            // 
            // Tab_Trash_Button_UniversalFunc1
            // 
            Tab_Trash_Button_UniversalFunc1.Location = new Point(173, 118);
            Tab_Trash_Button_UniversalFunc1.Margin = new Padding(4, 3, 4, 3);
            Tab_Trash_Button_UniversalFunc1.Name = "Tab_Trash_Button_UniversalFunc1";
            Tab_Trash_Button_UniversalFunc1.Size = new Size(147, 27);
            Tab_Trash_Button_UniversalFunc1.TabIndex = 8;
            Tab_Trash_Button_UniversalFunc1.Text = "Universal Func1";
            Tab_Trash_Button_UniversalFunc1.UseVisualStyleBackColor = true;
            Tab_Trash_Button_UniversalFunc1.Click += Tab_Trash_Button_UniversalFunc1_Click;
            // 
            // Tab_Trash_Button_UniversalClassFromInterfaceFunc
            // 
            Tab_Trash_Button_UniversalClassFromInterfaceFunc.Location = new Point(173, 52);
            Tab_Trash_Button_UniversalClassFromInterfaceFunc.Margin = new Padding(4, 3, 4, 3);
            Tab_Trash_Button_UniversalClassFromInterfaceFunc.Name = "Tab_Trash_Button_UniversalClassFromInterfaceFunc";
            Tab_Trash_Button_UniversalClassFromInterfaceFunc.Size = new Size(147, 60);
            Tab_Trash_Button_UniversalClassFromInterfaceFunc.TabIndex = 7;
            Tab_Trash_Button_UniversalClassFromInterfaceFunc.Text = "UniversalClass From Interface Func";
            Tab_Trash_Button_UniversalClassFromInterfaceFunc.UseVisualStyleBackColor = true;
            Tab_Trash_Button_UniversalClassFromInterfaceFunc.Click += Tab_Trash_Button_UniversalClassFromInterfaceFunc_Click;
            // 
            // Tab_Trash_Button_UniversalClassFunc
            // 
            Tab_Trash_Button_UniversalClassFunc.Location = new Point(173, 18);
            Tab_Trash_Button_UniversalClassFunc.Margin = new Padding(4, 3, 4, 3);
            Tab_Trash_Button_UniversalClassFunc.Name = "Tab_Trash_Button_UniversalClassFunc";
            Tab_Trash_Button_UniversalClassFunc.Size = new Size(147, 27);
            Tab_Trash_Button_UniversalClassFunc.TabIndex = 6;
            Tab_Trash_Button_UniversalClassFunc.Text = "UniversalClass Func";
            Tab_Trash_Button_UniversalClassFunc.UseVisualStyleBackColor = true;
            Tab_Trash_Button_UniversalClassFunc.Click += Tab_Trash_Button_UniversalClassFunc_Click;
            // 
            // Tab_Trash_Button_LambdaExpression3
            // 
            Tab_Trash_Button_LambdaExpression3.Location = new Point(18, 186);
            Tab_Trash_Button_LambdaExpression3.Margin = new Padding(4, 3, 4, 3);
            Tab_Trash_Button_LambdaExpression3.Name = "Tab_Trash_Button_LambdaExpression3";
            Tab_Trash_Button_LambdaExpression3.Size = new Size(147, 27);
            Tab_Trash_Button_LambdaExpression3.TabIndex = 5;
            Tab_Trash_Button_LambdaExpression3.Text = "LambdaExpression3";
            Tab_Trash_Button_LambdaExpression3.UseVisualStyleBackColor = true;
            Tab_Trash_Button_LambdaExpression3.Click += Tab_Trash_Button_LambdaExpression3_Click;
            // 
            // Tab_Trash_Button_LambdaExpression2
            // 
            Tab_Trash_Button_LambdaExpression2.Location = new Point(18, 152);
            Tab_Trash_Button_LambdaExpression2.Margin = new Padding(4, 3, 4, 3);
            Tab_Trash_Button_LambdaExpression2.Name = "Tab_Trash_Button_LambdaExpression2";
            Tab_Trash_Button_LambdaExpression2.Size = new Size(147, 27);
            Tab_Trash_Button_LambdaExpression2.TabIndex = 4;
            Tab_Trash_Button_LambdaExpression2.Text = "LambdaExpression2";
            Tab_Trash_Button_LambdaExpression2.UseVisualStyleBackColor = true;
            Tab_Trash_Button_LambdaExpression2.Click += Tab_Trash_Button_LambdaExpression2_Click;
            // 
            // Tab_Trash_Button_LambdaExpression1
            // 
            Tab_Trash_Button_LambdaExpression1.Location = new Point(18, 119);
            Tab_Trash_Button_LambdaExpression1.Margin = new Padding(4, 3, 4, 3);
            Tab_Trash_Button_LambdaExpression1.Name = "Tab_Trash_Button_LambdaExpression1";
            Tab_Trash_Button_LambdaExpression1.Size = new Size(147, 27);
            Tab_Trash_Button_LambdaExpression1.TabIndex = 3;
            Tab_Trash_Button_LambdaExpression1.Text = "LambdaExpression1";
            Tab_Trash_Button_LambdaExpression1.UseVisualStyleBackColor = true;
            Tab_Trash_Button_LambdaExpression1.Click += Tab_Trash_Button_LambdaExpression1_Click;
            // 
            // Tab_Trash_Button_AnonymousFunction3
            // 
            Tab_Trash_Button_AnonymousFunction3.Location = new Point(18, 85);
            Tab_Trash_Button_AnonymousFunction3.Margin = new Padding(4, 3, 4, 3);
            Tab_Trash_Button_AnonymousFunction3.Name = "Tab_Trash_Button_AnonymousFunction3";
            Tab_Trash_Button_AnonymousFunction3.Size = new Size(147, 27);
            Tab_Trash_Button_AnonymousFunction3.TabIndex = 2;
            Tab_Trash_Button_AnonymousFunction3.Text = "AnonymousFunction3";
            Tab_Trash_Button_AnonymousFunction3.UseVisualStyleBackColor = true;
            Tab_Trash_Button_AnonymousFunction3.Click += Tab_Trash_Button_AnonymousFunction3_Click;
            // 
            // Tab_Trash_Button_AnonymousFunction2
            // 
            Tab_Trash_Button_AnonymousFunction2.Location = new Point(18, 52);
            Tab_Trash_Button_AnonymousFunction2.Margin = new Padding(4, 3, 4, 3);
            Tab_Trash_Button_AnonymousFunction2.Name = "Tab_Trash_Button_AnonymousFunction2";
            Tab_Trash_Button_AnonymousFunction2.Size = new Size(147, 27);
            Tab_Trash_Button_AnonymousFunction2.TabIndex = 1;
            Tab_Trash_Button_AnonymousFunction2.Text = "AnonymousFunction2";
            Tab_Trash_Button_AnonymousFunction2.UseVisualStyleBackColor = true;
            Tab_Trash_Button_AnonymousFunction2.Click += Tab_Trash_Button_AnonymousFunction2_Click;
            // 
            // Tab_Trash_Button_AnonymousFunction1
            // 
            Tab_Trash_Button_AnonymousFunction1.Location = new Point(18, 18);
            Tab_Trash_Button_AnonymousFunction1.Margin = new Padding(4, 3, 4, 3);
            Tab_Trash_Button_AnonymousFunction1.Name = "Tab_Trash_Button_AnonymousFunction1";
            Tab_Trash_Button_AnonymousFunction1.Size = new Size(147, 27);
            Tab_Trash_Button_AnonymousFunction1.TabIndex = 0;
            Tab_Trash_Button_AnonymousFunction1.Text = "AnonymousFunction1";
            Tab_Trash_Button_AnonymousFunction1.UseVisualStyleBackColor = true;
            Tab_Trash_Button_AnonymousFunction1.Click += Tab_Trash_Button_AnonymousFunction1_Click;
            // 
            // Tab_Trash_Button_LINQ
            // 
            Tab_Trash_Button_LINQ.Location = new Point(173, 252);
            Tab_Trash_Button_LINQ.Margin = new Padding(4, 3, 4, 3);
            Tab_Trash_Button_LINQ.Name = "Tab_Trash_Button_LINQ";
            Tab_Trash_Button_LINQ.Size = new Size(147, 27);
            Tab_Trash_Button_LINQ.TabIndex = 12;
            Tab_Trash_Button_LINQ.Text = "LINQ";
            Tab_Trash_Button_LINQ.UseVisualStyleBackColor = true;
            Tab_Trash_Button_LINQ.Click += Tab_Trash_Button_LINQ_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 50, 50);
            ClientSize = new Size(933, 519);
            Controls.Add(TabControl_MainTabs);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Padding = new Padding(4, 74, 4, 3);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Система замовлення готелю";
            TabControl_MainTabs.ResumeLayout(false);
            Tab_Authorization.ResumeLayout(false);
            Tab_SignUp.ResumeLayout(false);
            Tab_Aministrator.ResumeLayout(false);
            Tab_Aministrator.PerformLayout();
            Tab_Administrator_Panel_RequesList.ResumeLayout(false);
            Tab_Client.ResumeLayout(false);
            Tab_Client.PerformLayout();
            Tab_Client_Panel_RequesForm.ResumeLayout(false);
            Tab_Client_Panel_RequesForm.PerformLayout();
            Tab_Request.ResumeLayout(false);
            Tab_Request.PerformLayout();
            tabPage1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl TabControl_MainTabs;
        private System.Windows.Forms.TabPage Tab_Aministrator;
        private System.Windows.Forms.TabPage Tab_Client;
        private System.Windows.Forms.TabPage Tab_Request;
        private MaterialSkin.Controls.MaterialButton Tab_Request_Buttonn_SendRequest;
        private MaterialSkin.Controls.MaterialComboBox Tab_Request_ComboBox_ApartmentСlass;
        private MaterialSkin.Controls.MaterialComboBox Tab_Request_ComboBox_SleepingPlacesNumber;
        private MaterialSkin.Controls.MaterialButton Tab_Request_Button_DaysUp;
        private MaterialSkin.Controls.MaterialButton Tab_Request_Button_DaysDown;
        private MaterialSkin.Controls.MaterialButton Tab_Request_Button_MinutesUp;
        private MaterialSkin.Controls.MaterialButton Tab_Request_Button_MinutesDown;
        private MaterialSkin.Controls.MaterialButton Tab_Request_Button_HoursUp;
        private MaterialSkin.Controls.MaterialButton Tab_Request_Button_HoursDown;
        private MaterialSkin.Controls.MaterialLabel Tab_Request_Label_MinutesCount;
        private MaterialSkin.Controls.MaterialLabel Tab_Request_Label_HoursCount;
        private MaterialSkin.Controls.MaterialLabel Tab_Request_Label_DaysCount;
        private System.Windows.Forms.Label Tab_Request_LabelText_Days;
        private System.Windows.Forms.Label Tab_Request_LabelText_Minutes;
        private System.Windows.Forms.Label Tab_Request_LabelText_Hours;
        private MaterialSkin.Controls.MaterialLabel Tab_Request_LabelText_StayTime;
        private System.Windows.Forms.TabPage Tab_SignUp;
        private MaterialSkin.Controls.MaterialTextBox Tab_SignUp_TextBox_ClientPatronymic;
        private MaterialSkin.Controls.MaterialTextBox Tab_SignUp_TextBox_ClientSurname;
        private MaterialSkin.Controls.MaterialTextBox Tab_SignUp_TextBox_ClientName;
        private MaterialSkin.Controls.MaterialButton Tab_SignUp_Button_SignUp;
        private MaterialSkin.Controls.MaterialTextBox Tab_SignUp_TextBox_ClientPhoneNumber;
        private MaterialSkin.Controls.MaterialComboBox Tab_SignUp_ComboBox_ClientStatus;
        private MaterialSkin.Controls.MaterialTextBox Tab_SignUp_TextBox_ClientPasswordСonfirmation;
        private MaterialSkin.Controls.MaterialTextBox Tab_SignUp_TextBox_ClientPassword;
        private System.Windows.Forms.TabPage Tab_Authorization;
        private MaterialSkin.Controls.MaterialTextBox Tab_SignIn_TextBox_ClientPatronymic;
        private MaterialSkin.Controls.MaterialTextBox Tab_SignIn_TextBox_ClientPassword;
        private MaterialSkin.Controls.MaterialTextBox Tab_SignIn_TextBox_ClientSurname;
        private MaterialSkin.Controls.MaterialTextBox Tab_SignIn_TextBox_ClientName;
        private MaterialSkin.Controls.MaterialButton Tab_Client_Button_SignIn;
        private System.Windows.Forms.Panel Tab_Administrator_Panel_RequesList;
        private MaterialSkin.Controls.MaterialLabel Tab_Administrator_LabelText_ClientName;
        private MaterialSkin.Controls.MaterialLabel Tab_Administrator_LabelText_ClientPatronymic;
        private MaterialSkin.Controls.MaterialLabel Tab_Administrator_LabelText_ClientSurname;
        private MaterialSkin.Controls.MaterialLabel Tab_Administrator_LabelText_RequestState;
        private MaterialSkin.Controls.MaterialLabel Tab_Administrator_LabelText_StayTime;
        private MaterialSkin.Controls.MaterialLabel Tab_Administrator_LabelText_ApartmentСlass;
        private MaterialSkin.Controls.MaterialLabel Tab_Administrator_LabelText_SleepingPlacesNumber;
        private MaterialSkin.Controls.MaterialLabel Tab_Administrator_Label_ClientName;
        private MaterialSkin.Controls.MaterialLabel Tab_Administrator_Label_ClientPatronymic;
        private MaterialSkin.Controls.MaterialLabel Tab_Administrator_Label_ClientSurname;
        private MaterialSkin.Controls.MaterialLabel Tab_Administrator_Label_StayTime;
        private MaterialSkin.Controls.MaterialLabel Tab_Administrator_Label_ApartmentСlass;
        private MaterialSkin.Controls.MaterialLabel Tab_Administrator_Label_SleepingPlacesNumber;
        private MaterialSkin.Controls.MaterialLabel Tab_Administrator_Label_RequestState;
        private MaterialSkin.Controls.MaterialButton Tab_Administrator_Button_ConfirmRequest;
        private MaterialSkin.Controls.MaterialButton Tab_Administrator_Button_DeclineRequest;
        private MaterialSkin.Controls.MaterialButton Tab_Administrator_Button_NextRequest;
        private MaterialSkin.Controls.MaterialButton Tab_Administrator_Button_PrevRequest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Tab_Client_Panel_RequesForm;
        private MaterialSkin.Controls.MaterialLabel Tab_Client_Label_RequestState;
        private MaterialSkin.Controls.MaterialLabel Tab_Client_Label_StayTime;
        private MaterialSkin.Controls.MaterialLabel Tab_Client_Label_ApartmentСlass;
        private MaterialSkin.Controls.MaterialLabel Tab_Client_Label_SleepingPlacesNumber;
        private MaterialSkin.Controls.MaterialLabel Tab_Client_Label_ClientPatronymic;
        private MaterialSkin.Controls.MaterialLabel Tab_Client_Label_ClientSurname;
        private MaterialSkin.Controls.MaterialLabel Tab_Client_Label_ClientName;
        private MaterialSkin.Controls.MaterialLabel Tab_Client_LabelText_RequestState;
        private MaterialSkin.Controls.MaterialLabel Tab_Client_LabelText_StayTime;
        private MaterialSkin.Controls.MaterialLabel Tab_Client_LabelText_ApartmentСlass;
        private MaterialSkin.Controls.MaterialLabel Tab_Client_LabelText_SleepingPlacesNumber;
        private MaterialSkin.Controls.MaterialLabel Tab_Client_LabelText_ClientPatronymic;
        private MaterialSkin.Controls.MaterialLabel Tab_Client_LabelText_ClientSurname;
        private MaterialSkin.Controls.MaterialLabel Tab_Client_LabelText_ClientName;
        private MaterialSkin.Controls.MaterialButton Tab_Client_Button_Pay;
        private MaterialSkin.Controls.MaterialButton Tab_Client_Button_MoveToRequest;
        private MaterialSkin.Controls.MaterialButton Tab_Request_Button_MoveToClient;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialButton Tab_Client_Button_MoveToSignIn;
        private MaterialSkin.Controls.MaterialLabel Tab_Administrator_Label_ClientPhoneNumber;
        private MaterialSkin.Controls.MaterialLabel Tab_Administrator_LabelText_ClientPhoneNumber;
        private MaterialSkin.Controls.MaterialLabel Tab_Client_Label_ClientPhoneNumber;
        private MaterialSkin.Controls.MaterialLabel Tab_Client_LabelText_ClientPhoneNumber;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button Tab_Trash_Button_AnonymousFunction1;
        private System.Windows.Forms.Button Tab_Trash_Button_AnonymousFunction3;
        private System.Windows.Forms.Button Tab_Trash_Button_AnonymousFunction2;
        private System.Windows.Forms.Button Tab_Trash_Button_LambdaExpression3;
        private System.Windows.Forms.Button Tab_Trash_Button_LambdaExpression2;
        private System.Windows.Forms.Button Tab_Trash_Button_LambdaExpression1;
        private MaterialSkin.Controls.MaterialButton Tab_Administrator_Button_MoveToSignIn;
        private Button Tab_Trash_Button_UniversalClassFunc;
        private Button Tab_Trash_Button_UniversalClassFromInterfaceFunc;
        private Button Tab_Trash_Button_UniversalFunc1;
        private Button Tab_Trash_Button_UniversalFunc2;
        private Button Tab_Trash_Button_UniversalDelegate;
        private Button Tab_Trash_Button_IteratorFunc;
        private Button Tab_Trash_Button_LINQ;
    }
}

