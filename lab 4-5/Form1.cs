using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using lab_4_5.Interfaces;
using lab_4_5.Models;
using lab_4_5.Enums;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Collections;
using System.Data;

namespace lab_4_5
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            Color Dark = Color.FromArgb(33, 33, 33);
            Color LessDark = Color.FromArgb(42, 42, 42);
            Color LightGrey = Color.LightGray;
            Color MoreDark = Color.FromArgb(5, 5, 5);
            Color Orange = Color.Orange;
            Color White = Color.White;
            materialSkinManager.ColorScheme = new ColorScheme(Dark, Dark, MoreDark, Orange, TextShade.WHITE);

            TabControl_MainTabs.SelectTab((int)Tabs.SignUp);
        }

        private void TabControl_MainTabs_Selected(object sender, TabControlEventArgs e)
        {
            //Administrator
            if (TabControl_MainTabs.SelectedIndex == (int)Tabs.Administrator)
            {
                Administrator = new AdministratorVm();

                ClientsFoldersPaths = (Directory.GetDirectories("D:\\Work\\IV семестр\\Об'єктно орієнтоване проектування Лаб №4-5\\lab 4-5\\lab 4-5\\Clients\\")).ToList();

                //Clients = new List<ClientVm>();

                //ClientsManagerVm CurrentClientManager = new ClientsManagerVm(AdmnistratorClientsManager[CurrentAdministratorClientIter].Client);

                for (int i = 0; i < ClientsFoldersPaths.Count; i++)
                {
                    using (FileStream fs = new FileStream(ClientsFoldersPaths[i] + "\\Client.json", FileMode.Open, FileAccess.Read))
                    {
                        //Clients.Add(JsonSerializer.Deserialize<ClientVm>(fs));
                        ClientManagerVm temp = new ClientManagerVm(JsonSerializer.Deserialize<ClientVm>(fs));
                        Administrator.ClientsManagers.Add(temp);
                    }
                }

                if (Administrator.ClientsManagers.Count == 0)
                {
                    Tab_Administrator_Panel_RequesList.Visible = false;
                    Tab_Administrator_Button_NextRequest.Enabled = false;
                    return;
                }
                Tab_Administrator_Panel_RequesList.Visible = true;
                if (Administrator.ClientsManagers.Count == 1)
                {
                    Tab_Administrator_Button_NextRequest.Enabled = false;
                }
                else
                {
                    Tab_Administrator_Button_NextRequest.Enabled = true;
                }
                Administrator.ShowRequest(Tab_Administrator_Label_ClientName, Tab_Administrator_Label_ClientSurname, Tab_Administrator_Label_ClientPatronymic, Tab_Administrator_Label_ClientPhoneNumber, Tab_Administrator_Label_SleepingPlacesNumber, Tab_Administrator_Label_ApartmentСlass, Tab_Administrator_Label_StayTime, Tab_Administrator_Label_RequestState, Tab_Administrator_Button_ConfirmRequest, Tab_Administrator_Button_DeclineRequest);
            }

            //Client
            if (TabControl_MainTabs.SelectedIndex == (int)Tabs.Client)
            {
                AuthorizedClientManager.Client = AuthorizedClientFileManager.LoadClient();

                if (AuthorizedClientManager.Client.Request == null)
                {
                    Tab_Client_Panel_RequesForm.Visible = false;
                    return;
                }
                Tab_Client_Panel_RequesForm.Visible = true;

                if (AuthorizedClientManager.Client.Request.State == RequestStates.Розлядається || AuthorizedClientManager.Client.Request.State == RequestStates.Відхилено)
                {
                    Tab_Client_Button_Pay.Enabled = false;
                }
                else
                {
                    Tab_Client_Button_Pay.Enabled = true;
                }

                Tab_Client_Label_ClientName.Text = AuthorizedClientManager.Client.Name;
                Tab_Client_Label_ClientSurname.Text = AuthorizedClientManager.Client.Surname;
                Tab_Client_Label_ClientPatronymic.Text = AuthorizedClientManager.Client.Patronymic;
                Tab_Client_Label_ClientPhoneNumber.Text = AuthorizedClientManager.Client.PhoneNumber;
                Tab_Client_Label_SleepingPlacesNumber.Text = AuthorizedClientManager.Client.Request.Apartment.SleepingPlacesNumber;
                Tab_Client_Label_ApartmentСlass.Text = AuthorizedClientManager.Client.Request.Apartment.ApartmentСlass;
                Tab_Client_Label_StayTime.Text = AuthorizedClientManager.Client.Request.Apartment.StayTime[(int)StayTime.Days].ToString() + " Днів " + AuthorizedClientManager.Client.Request.Apartment.StayTime[(int)StayTime.Hours].ToString() + " Годин " + AuthorizedClientManager.Client.Request.Apartment.StayTime[(int)StayTime.Minutes].ToString() + " Хвилин";
                Tab_Client_Label_RequestState.Text = AuthorizedClientManager.Client.Request.State.ToString();
            }

            //Request
            if (TabControl_MainTabs.SelectedIndex == (int)Tabs.Request)
            {
                RequestStayTimeDays = 0;
                Tab_Request_Label_DaysCount.Text = RequestStayTimeDays.ToString();
                RequestStayTimeHours = 0;
                Tab_Request_Label_HoursCount.Text = RequestStayTimeHours.ToString();
                RequestStayTimeMinutes = 0;
                Tab_Request_Label_MinutesCount.Text = RequestStayTimeMinutes.ToString();

                Tab_Request_Button_DaysUp.Enabled = true;
                Tab_Request_Button_DaysDown.Enabled = false;
                Tab_Request_Button_HoursUp.Enabled = true;
                Tab_Request_Button_HoursDown.Enabled = false;
                Tab_Request_Button_MinutesUp.Enabled = true;
                Tab_Request_Button_MinutesDown.Enabled = false;
            }
        }
        //Administrator
        public List<string> ClientsFoldersPaths;
        //public List<ClientVm> Clients; //10. An array of class object pointers
        //public List<ClientManagerVm> AdmnistratorClientsManager; //10. An array of class object pointers
        public AdministratorVm Administrator;

        private void Tab_Administrator_Button_NextRequest_Click(object sender, EventArgs e)
        {
            Administrator.Index++;

            try
            {
                ClientManagerVm IsException = Administrator[Administrator.Index + 1];
            }
            catch (Exception)
            {
                Tab_Administrator_Button_NextRequest.Enabled = false;
                Tab_Administrator_Button_PrevRequest.Enabled = true;
                Administrator.ShowRequest(Tab_Administrator_Label_ClientName, Tab_Administrator_Label_ClientSurname, Tab_Administrator_Label_ClientPatronymic, Tab_Administrator_Label_ClientPhoneNumber, Tab_Administrator_Label_SleepingPlacesNumber, Tab_Administrator_Label_ApartmentСlass, Tab_Administrator_Label_StayTime, Tab_Administrator_Label_RequestState, Tab_Administrator_Button_ConfirmRequest, Tab_Administrator_Button_DeclineRequest);
                return;
            }
            Tab_Administrator_Button_PrevRequest.Enabled = true;
            Administrator.ShowRequest(Tab_Administrator_Label_ClientName, Tab_Administrator_Label_ClientSurname, Tab_Administrator_Label_ClientPatronymic, Tab_Administrator_Label_ClientPhoneNumber, Tab_Administrator_Label_SleepingPlacesNumber, Tab_Administrator_Label_ApartmentСlass, Tab_Administrator_Label_StayTime, Tab_Administrator_Label_RequestState, Tab_Administrator_Button_ConfirmRequest, Tab_Administrator_Button_DeclineRequest);

            IAdministrator LabTask2_1 = Administrator;
        }
        private void Tab_Administrator_Button_PrevRequest_Click(object sender, EventArgs e)
        {
            Administrator.Index--;
            try
            {
                ClientManagerVm IsException = Administrator[Administrator.Index - 1];
            }
            catch (Exception)
            {
                Tab_Administrator_Button_NextRequest.Enabled = true;
                Tab_Administrator_Button_PrevRequest.Enabled = false;
                Administrator.ShowRequest(Tab_Administrator_Label_ClientName, Tab_Administrator_Label_ClientSurname, Tab_Administrator_Label_ClientPatronymic, Tab_Administrator_Label_ClientPhoneNumber, Tab_Administrator_Label_SleepingPlacesNumber, Tab_Administrator_Label_ApartmentСlass, Tab_Administrator_Label_StayTime, Tab_Administrator_Label_RequestState, Tab_Administrator_Button_ConfirmRequest, Tab_Administrator_Button_DeclineRequest);
                return;
            }
            Tab_Administrator_Button_NextRequest.Enabled = true;
            Administrator.ShowRequest(Tab_Administrator_Label_ClientName, Tab_Administrator_Label_ClientSurname, Tab_Administrator_Label_ClientPatronymic, Tab_Administrator_Label_ClientPhoneNumber, Tab_Administrator_Label_SleepingPlacesNumber, Tab_Administrator_Label_ApartmentСlass, Tab_Administrator_Label_StayTime, Tab_Administrator_Label_RequestState, Tab_Administrator_Button_ConfirmRequest, Tab_Administrator_Button_DeclineRequest);
        }
        private void Tab_Administrator_Button_ConfirmRequest_Click(object sender, EventArgs e)
        {
            Administrator[Administrator.Index].Client.Request.State = RequestStates.Свалено;
            Tab_Administrator_Label_RequestState.Text = "Свалено";
            ClientFileManagerVm currentAdminisatrorClientFileManager = new ClientFileManagerVm(Administrator[Administrator.Index].Client);
            currentAdminisatrorClientFileManager.SaveClient();
        }
        private void Tab_Administrator_Button_DeclineRequest_Click(object sender, EventArgs e)
        {
            Administrator[Administrator.Index].Client.Request.State = RequestStates.Відхилено;
            Tab_Administrator_Label_RequestState.Text = "Відхилено";
            ClientFileManagerVm currentAdminisatrorClientFileManager = new ClientFileManagerVm(Administrator[Administrator.Index].Client);
            currentAdminisatrorClientFileManager.SaveClient();
        }
        private void Tab_Administrator_Button_MoveToSignIn_Click(object sender, EventArgs e)
        {
            TabControl_MainTabs.SelectTab((int)Tabs.SignUp);
        }
        // Client
        public ClientVm AuthorizedClient;
        public ClientManagerVm AuthorizedClientManager;
        public ClientFileManagerVm AuthorizedClientFileManager;
        private void Tab_Client_Button_Pay_Click(object sender, EventArgs e)
        {
            AuthorizedClientManager.Client.Request = null;
            //AuthorizedClientManager.SaveProfile();
            AuthorizedClientFileManager.SaveClient();
            Tab_Client_Panel_RequesForm.Visible = false;
        }
        private void Tab_Client_Button_MoveToRequest_Click(object sender, EventArgs e)
        {
            TabControl_MainTabs.SelectTab((int)Tabs.Request);
        }
        private void Tab_Client_Button_MoveToSignIn_Click(object sender, EventArgs e)
        {
            TabControl_MainTabs.SelectTab((int)Tabs.SignUp);
        }
        //SignIn
        private void Tab_Client_Button_SignIn_Click(object sender, EventArgs e)
        {
            string ClinetName = Tab_SignIn_TextBox_ClientName.Text;
            string ClientSurname = Tab_SignIn_TextBox_ClientSurname.Text;
            string ClientPatronymic = Tab_SignIn_TextBox_ClientPatronymic.Text;
            string ClientPassword = Tab_SignIn_TextBox_ClientPassword.Text;

            if (ClinetName == "" || ClientSurname == "" || ClientPatronymic == "" || ClientPassword == "")
            {
                MessageBox.Show("Будь-ласка, заповність усі поля", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }

            AuthorizedClientFileManager = new ClientFileManagerVm(ClinetName, ClientSurname, ClientPatronymic, ClientPassword);

            if (AuthorizedClientFileManager.IsAllClientAuthorizationDataCorrect() == true)
            {
                AuthorizedClient = AuthorizedClientFileManager.LoadClient();
                AuthorizedClientManager = new ClientManagerVm(ref AuthorizedClient);
                MessageBox.Show("Авторизація пройшла успішно", "Усіпх", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                TabControl_MainTabs.SelectTab((int)Tabs.Client);
                return;
            }

            MessageBox.Show("Ви невірно ввели ініціали або пароль", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }
        //SignUp
        private void Tab_SignUp_Button_SignUp_Click(object sender, EventArgs e)
        {
            string ClinetName = Tab_SignUp_TextBox_ClientName.Text;
            string ClientSurname = Tab_SignUp_TextBox_ClientSurname.Text;
            string ClientPatronymic = Tab_SignUp_TextBox_ClientPatronymic.Text;
            string ClientPhoneNumber = Tab_SignUp_TextBox_ClientPhoneNumber.Text;
            string ClientStatus = Tab_SignUp_ComboBox_ClientStatus.Text;
            string ClientPassword = Tab_SignUp_TextBox_ClientPassword.Text;
            string ClientPasswordСonfirmation = Tab_SignUp_TextBox_ClientPasswordСonfirmation.Text;

            if (ClinetName == "" || ClientSurname == "" || ClientPatronymic == "" || ClientPhoneNumber == "" || ClientStatus == "" || ClientPassword == "" || ClientPasswordСonfirmation == "")
            {
                MessageBox.Show("Будь-ласка, заповність усі поля", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }
            if (ClientPassword != ClientPasswordСonfirmation)
            {
                MessageBox.Show("Будь-ласка, введені пароль і підтвердження паролю повинні бути одаковими", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }
            ClientVm newClient = new ClientVm(ClinetName, ClientSurname, ClientPatronymic, ClientPhoneNumber, ClientStatus);
            ClientFileManagerVm newClientFileManagerVm = new ClientFileManagerVm(newClient);
            if (newClientFileManagerVm.CreateProfile(ClientPassword) == false)
            {
                MessageBox.Show("Клієнт з даними ініціалами вже існує", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }
            MessageBox.Show("Профіль було успішно створено", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }
        private void Tab_SignUp_TextBox_ClientPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < Tab_SignUp_TextBox_ClientPhoneNumber.TextLength; i++)
            {
                if (Tab_SignUp_TextBox_ClientPhoneNumber.Text[i] < '0' || Tab_SignUp_TextBox_ClientPhoneNumber.Text[i] > '9')
                {
                    Tab_SignUp_TextBox_ClientPhoneNumber.Text = Tab_SignUp_TextBox_ClientPhoneNumber.Text.Remove(i, 1);
                    return;
                }
            }
        }
        //Request
        public int RequestStayTimeDays = 0;
        public int RequestStayTimeHours = 0;
        public int RequestStayTimeMinutes = 0;
        private void Tab_Request_Buttonn_SendRequest_Click(object sender, EventArgs e)
        {
            if (RequestStayTimeDays == 0 && RequestStayTimeHours == 0 && RequestStayTimeMinutes == 0)
            {
                MessageBox.Show("Будь-ласка, загальний час перебування у номері не повинен дорівнювати нулю", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }

            AuthorizedClientManager.Client.Request = new RequestVm();

            AuthorizedClientManager.Client.Request.Apartment.SleepingPlacesNumber = Tab_Request_ComboBox_SleepingPlacesNumber.Text;
            AuthorizedClientManager.Client.Request.Apartment.ApartmentСlass = Tab_Request_ComboBox_ApartmentСlass.Text;
            AuthorizedClientManager.Client.Request.Apartment.StayTime[(int)StayTime.Days] = RequestStayTimeDays;
            AuthorizedClientManager.Client.Request.Apartment.StayTime[(int)StayTime.Hours] = RequestStayTimeHours;
            AuthorizedClientManager.Client.Request.Apartment.StayTime[(int)StayTime.Minutes] = RequestStayTimeMinutes;

            AuthorizedClientFileManager.SaveClient();

            MessageBox.Show("Заявка була успішно подана на розглядання", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            TabControl_MainTabs.SelectTab((int)Tabs.Client);
        }
        private void Tab_Request_Button_MoveToClient_Click(object sender, EventArgs e)
        {
            TabControl_MainTabs.SelectTab((int)Tabs.Client);
        }
        private void Tab_Request_Button_DaysUp_Click(object sender, EventArgs e)
        {
            if (RequestStayTimeDays >= 364)
            {
                Tab_Request_Button_DaysUp.Enabled = false;
            }
            Tab_Request_Button_DaysDown.Enabled = true;
            RequestStayTimeDays++;
            Tab_Request_Label_DaysCount.Text = RequestStayTimeDays.ToString();
        }
        private void Tab_Request_Button_DaysDown_Click(object sender, EventArgs e)
        {
            if (RequestStayTimeDays <= 1)
            {
                Tab_Request_Button_DaysDown.Enabled = false;
            }
            Tab_Request_Button_DaysUp.Enabled = true;
            RequestStayTimeDays--;
            Tab_Request_Label_DaysCount.Text = RequestStayTimeDays.ToString();
        }
        private void Tab_Request_Button_HoursUp_Click(object sender, EventArgs e)
        {
            if (RequestStayTimeHours >= 23)
            {
                Tab_Request_Button_HoursUp.Enabled = false;
            }
            Tab_Request_Button_HoursDown.Enabled = true;
            RequestStayTimeHours++;
            Tab_Request_Label_HoursCount.Text = RequestStayTimeHours.ToString();
        }
        private void Tab_Request_Button_HoursDown_Click(object sender, EventArgs e)
        {
            if (RequestStayTimeHours <= 1)
            {
                Tab_Request_Button_HoursDown.Enabled = false;
            }
            Tab_Request_Button_HoursUp.Enabled = true;
            RequestStayTimeHours--;
            Tab_Request_Label_HoursCount.Text = RequestStayTimeHours.ToString();
        }
        private void Tab_Request_Button_MinutesUp_Click(object sender, EventArgs e)
        {
            if (RequestStayTimeMinutes >= 59)
            {
                Tab_Request_Button_MinutesUp.Enabled = false;
            }
            Tab_Request_Button_MinutesDown.Enabled = true;
            RequestStayTimeMinutes++;
            Tab_Request_Label_MinutesCount.Text = RequestStayTimeMinutes.ToString();
        }
        private void Tab_Request_Button_MinutesDown_Click(object sender, EventArgs e)
        {
            if (RequestStayTimeMinutes <= 1)
            {
                Tab_Request_Button_MinutesDown.Enabled = false;
            }
            Tab_Request_Button_MinutesUp.Enabled = true;
            RequestStayTimeMinutes--;
            Tab_Request_Label_MinutesCount.Text = RequestStayTimeMinutes.ToString();
        }
        //Other
        private void Tab_SignUp_TextBox_ClientName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Tab_SignUp_TextBox_ClientSurname.Focus();
            }
        }
        private void Tab_SignUp_TextBox_ClientSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Tab_SignUp_TextBox_ClientPatronymic.Focus();
            }
        }
        private void Tab_SignUp_TextBox_ClientPatronymic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Tab_SignUp_TextBox_ClientPhoneNumber.Focus();
            }
        }
        private void Tab_SignUp_TextBox_ClientPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Tab_SignUp_ComboBox_ClientStatus.Focus();
            }
        }
        private void Tab_SignUp_ComboBox_ClientStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Tab_SignUp_TextBox_ClientPassword.Focus();
            }
        }
        private void Tab_SignUp_TextBox_ClientPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Tab_SignUp_TextBox_ClientPasswordСonfirmation.Focus();
            }
        }
        private void Tab_SignUp_TextBox_ClientPasswordСonfirmation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                object sen = new object();
                Tab_SignUp_Button_SignUp_Click(sen, e);
            }
        }
        //Trash
        delegate string AnonymousFunction1(string line);
        private void Tab_Trash_Button_AnonymousFunction1_Click(object sender, EventArgs e)
        {
            AnonymousFunction1 func1 = delegate (string line)
            {
                return line;
            };
            MessageBox.Show(func1("Відпрацьовано"), "Відпрацювання", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }
        delegate bool AnonymousFunction2(bool state);
        private void Tab_Trash_Button_AnonymousFunction2_Click(object sender, EventArgs e)
        {
            AnonymousFunction2 func2 = delegate (bool state)
            {
                return state;
            };
            MessageBox.Show(func2(true).ToString(), "Відпрацювання", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }
        delegate int AnonymousFunction3(int var);
        private void Tab_Trash_Button_AnonymousFunction3_Click(object sender, EventArgs e)
        {
            AnonymousFunction3 func3 = delegate (int var)
            {
                return var;
            };
            MessageBox.Show(func3(123).ToString(), "Відпрацювання", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }
        delegate string LambdaExpression1(string line);
        private void Tab_Trash_Button_LambdaExpression1_Click(object sender, EventArgs e)
        {
            LambdaExpression1 func1 = line => line + "!";
            MessageBox.Show(func1("Рядок").ToString(), "Відпрацювання", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }
        delegate bool LambdaExpression2(bool state);
        private void Tab_Trash_Button_LambdaExpression2_Click(object sender, EventArgs e)
        {
            LambdaExpression2 func2 = state => !state;
            MessageBox.Show(func2(false).ToString(), "Відпрацювання", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }
        delegate int LambdaExpression3(int var);
        private void Tab_Trash_Button_LambdaExpression3_Click(object sender, EventArgs e)
        {
            LambdaExpression3 func3 = var =>
            {
                for (int i = 0; i < 10; i++)
                {
                    var++;
                }
                return var;
            };
            MessageBox.Show(func3(0).ToString(), "Відпрацювання", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        //

        public class UniversalClass<T> //Шаблонний (унівесральний) клас
        {
            public T Value { get; set; }
            public UniversalClass(T Value)
            {
                this.Value = Value;
            }
            public void Func(T Value)
            {
                MessageBox.Show($"{this.Value} {Value}", "Відпрацювання", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void Tab_Trash_Button_UniversalClassFunc_Click(object sender, EventArgs e)
        {
            UniversalClass<int> universalClass_TypeInt = new UniversalClass<int>(123); //Ствоерння шаблонного (унівесрального) об'єкту класу
            universalClass_TypeInt.Func(456); //Виклик функції шаблонного (унівесрального) об'єкту класу

            UniversalClass<string> universalClass_TypeString = new UniversalClass<string>("String1"); //Ствоерння шаблонного (унівесрального) об'єкту класу
            universalClass_TypeString.Func("String2"); //Виклик функції шаблонного (унівесрального) об'єкту класу
        }

        public interface IUnviversalInterface<T> //Шаблонний (унівесральний) інтерфейс
        {
            T Value { get; set; }
            public void Func(T Value);
        }

        public class UniversalClassFromUniversalInterface<T> : IUnviversalInterface<T> //Імплементація Шаблонного (унівесрального) інтерфейсу до шаблонного (унівесрального) класу
        {
            public T Value { get; set; }
            public UniversalClassFromUniversalInterface(T Value)
            {
                this.Value = Value;
            }
            public void Func(T Value)
            {
                MessageBox.Show($"{this.Value} {Value}", "Відпрацювання", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void Tab_Trash_Button_UniversalClassFromInterfaceFunc_Click(object sender, EventArgs e)
        {
            UniversalClassFromUniversalInterface<int> universalClassFromInterface_TypeInt = new UniversalClassFromUniversalInterface<int>(123); //Ствоерння шаблонного (унівесрального) об'єкту класу 
            universalClassFromInterface_TypeInt.Func(456); //Виклик функції шаблонного (унівесрального) об'єкту класу

            UniversalClass<string> universalClassFromInterface_TypeString = new UniversalClass<string>("String1"); //Ствоерння шаблонного (унівесрального) об'єкту класу
            universalClassFromInterface_TypeString.Func("String2"); //Виклик функції шаблонного (унівесрального) об'єкту класу
        }

        void UniversalFunc1<T>(T value1, T value2) //Шаблонна (універсальна) функція 
        {
            MessageBox.Show($"{value1} {value2}", "Відпрацювання", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        private void Tab_Trash_Button_UniversalFunc1_Click(object sender, EventArgs e)
        {
            UniversalFunc1(123, 456); //Виклик шаблонної (універсальної) функції
        }

        void UniversalFunc2<T, G>(T value1, G value2) //Шаблонна (універсальна) функція 
        {
            MessageBox.Show($"{value1} {value2}", "Відпрацювання", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        private void Tab_Trash_Button_UniversalFunc2_Click(object sender, EventArgs e)
        {
            UniversalFunc2(123, "string"); //Виклик шаблонної (універсальної) функції
        }

        public delegate void Del<T>(T item); //Шаблонний (універсальний) делегат
        public void IntFunc(int i) { MessageBox.Show($"{i}", "Відпрацювання", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1); } //Функція, що буде збергіатися в делегаті
        public void StringFunc(string str) { MessageBox.Show($"{str}", "Відпрацювання", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1); } //Функція, що буде збергіатися в делегаті
        private void Tab_Trash_Button_UniversalDelegate_Click(object sender, EventArgs e)
        {
            Del<int> UniversalDelegate_TypeInt = new Del<int>(IntFunc); //Свтоерння делегату з записом в нього адреси функції IntFunc
            UniversalDelegate_TypeInt(123); //Виклик шаблонного (універсального) делегату

            Del<string> UniversalDelegate_TypeString = new Del<string>(StringFunc); //Свтоерння делегату з записом в нього адреси функції StringFunc
            UniversalDelegate_TypeString("string"); //Виклик шаблонного (універсального) делегату
        }

        class EnumerableClass : IEnumerable //Злічувальний клас
        {
            public IEnumerator GetEnumerator()
            {
                for (int i = 0; i < 10; i++)
                {
                    yield return i;
                }
            }
            public IEnumerable Sampleiterator(int start, int end)
            {
                for (int i = start; i <= end; i++)
                {
                    yield return i;
                }
            }
        }

        private void Tab_Trash_Button_IteratorFunc_Click(object sender, EventArgs e)
        {
            EnumerableClass enumerableClass = new EnumerableClass();

            foreach (int i in enumerableClass)
            {
                MessageBox.Show($"{i}", "Відпрацювання", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }

            foreach (int n in enumerableClass.Sampleiterator(3, 7))
            {
                MessageBox.Show($"{n}", "Відпрацювання", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        //

        public class Map<T>
        {
            public int Index { get; set; }
            public T Value { get; set; }
            public Map(int index, T value)
            {
                Index = index;
                Value = value;
            }
        }

        public class Couple<T, G>
        {
            public T First { get; set; }
            public G Second { get; set; }
            public Couple(T first, G second)
            {
                First = first;
                Second = second;
            }
        }

        private void Tab_Trash_Button_LINQ_Click(object sender, EventArgs e)
        {
            List<string> CPUs = new List<string>() { "AMD Ryzen 5 7500F", "Intel Core i5 12400", "AMD Ryzen 7 5800H", "AMD Ryzen 3 8300G", "Intel Core i9 14900KS", "AMD Ryzen 5 5500" };

            var selectedWords1 = from t in CPUs
                                where t.ToUpper().StartsWith("AMD")
                                orderby t
                                select t;

            // Методи LINQ
            List<string> selectedWords2 = (CPUs.Where(p => p.ToUpper().StartsWith("AMD")).OrderBy(p => p)).ToList();
            
            foreach (string team in selectedWords2)
            {
                MessageBox.Show($"{team}", "Відпрацювання", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }

            //

            List<Map<string>> MapsOfStrings = new List<Map<string>>()
            {
                new Map<string>(0, "string0.A"),
                new Map<string>(1, "string1.B"),
                new Map<string>(2, "string2.A"),
                new Map<string>(3, "string3.B"),
                new Map<string>(4, "string4.C"),
                new Map<string>(5, "string5.D"),
                new Map<string>(6, "string6.C"),
                new Map<string>(7, "string7.D"),
                new Map<string>(8, "string8.A"),
                new Map<string>(9, "string9.B"),
            };

            var strings = from line in MapsOfStrings
                           where line.Value.LastIndexOf('.') != -1
                           group line by line.Value.Substring(line.Value.LastIndexOf('.'));

            string Result = "";
            foreach (var line in strings)
            {
                Result += ($"Веб-сайти, згрупованi по iменi домена: {line.Key}\n");
                foreach (var site in line)
                {
                    Result += $" {site.Value}\n";
                }
            }

            MessageBox.Show($"{Result}", "Відпрацювання", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            //

            var chars = from str in MapsOfStrings
                       let chrArray = str.Value.ToCharArray()
                       from ch in chrArray
                       orderby ch
                       select ch;

            Result = "";
            foreach (char с in chars)
            {
                Result += $"{с} ";
            }

            MessageBox.Show($"{Result}", "Відпрацювання", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            //

            List<Map<string>> Items = new List<Map<string>>()
            {
                new Map<string>(0, "Корпус"),
                new Map<string>(1, "ОЗУ"),
                new Map<string>(2, "Процесор"),
                new Map<string>(3, "Відеокарта"),
                new Map<string>(4, "Блок живлення"),
                new Map<string>(5, "Материнська плата"),
                new Map<string>(6, "HDD"),
                new Map<string>(7, "SSD"),
                new Map<string>(8, "Башений кулер"),
                new Map<string>(9, "Плата розштрення"),
            };

            List<Map<bool>> InStockStatus = new List<Map<bool>>()
            {
                new Map<bool>(0, true),
                new Map<bool>(1, false),
                new Map<bool>(2, true),
                new Map<bool>(3, false),
                new Map<bool>(4, true),
                new Map<bool>(5, false),
                new Map<bool>(6, true),
                new Map<bool>(7, false),
                new Map<bool>(8, true),
                new Map<bool>(9, false),
            };

            var inStockList = from item in Items
                              join entry in InStockStatus
                              on item.Index equals entry.Index
                              select new Couple<string, bool>(item.Value, entry.Value);

            Result = "";
            foreach (Couple<string, bool> t in inStockList)
            {
                Result += $"{t.First}\t{t.Second}\n";
            }

            MessageBox.Show($"{Result}", "Відпрацювання", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }
    }
}
