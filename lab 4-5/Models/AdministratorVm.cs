using lab_4_5.Enums;
using lab_4_5.Interfaces;

namespace lab_4_5.Models
{
    public class AdministratorVm : IAdministrator //1. Class implementation
    {
        public List<ClientManagerVm> ClientsManagers { get; set; } //3. Implementing a data field using properties { get; set; }
        //static public LinkedListNode<ClientManagerVm> Nodes { get; set; } //12. A static pointer (iterator) to a linked list of objects
        public int Index { get; set; }
        public ClientManagerVm this[int index]
        {
            get
            {
                if (Index >= 0 && Index < ClientsManagers.Count)
                {
                    return ClientsManagers[index];
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }   
            set 
            {
                if (Index >= 0 && Index < ClientsManagers.Count)
                {
                    ClientsManagers[index] = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
        public AdministratorVm() //4. Constructor without parameters
        {
            ClientsManagers = new List<ClientManagerVm>();
        }
        public AdministratorVm(List<ClientManagerVm> clientsManagers) //4. Constructor with parameters
        {
            ClientsManagers = clientsManagers;
        }
        public void ShowRequest(Label label_ClientName, Label label_ClientSurname, Label label_ClientPatronymic, Label label_ClientPhoneNumber, Label label_SleepingPlacesNumber, Label label_ApartmentСlass, Label label_StayTime, Label label_RequestState, Button button_ConfirmRequest, Button button_DeclineRequest) //12. Static method for list view
        {
            label_ClientName.Text = ClientsManagers[Index].Client.Name;
            label_ClientSurname.Text = ClientsManagers[Index].Client.Surname;
            label_ClientPatronymic.Text = ClientsManagers[Index].Client.Patronymic;
            label_ClientPhoneNumber.Text = ClientsManagers[Index].Client.PhoneNumber;
            if (ClientsManagers[Index].Client.Request == null)
            {
                label_SleepingPlacesNumber.Visible = false;
                label_ApartmentСlass.Visible = false;
                label_StayTime.Visible = false;
                label_RequestState.Visible = false;
                button_ConfirmRequest.Enabled = false;
                button_DeclineRequest.Enabled = false;
            }
            else
            {
                label_SleepingPlacesNumber.Visible = true;
                label_ApartmentСlass.Visible = true;
                label_StayTime.Visible = true;
                label_RequestState.Visible = true;
                button_ConfirmRequest.Enabled = true;
                button_DeclineRequest.Enabled = true;

                label_SleepingPlacesNumber.Text = ClientsManagers[Index].Client.Request.Apartment.SleepingPlacesNumber;
                label_ApartmentСlass.Text = ClientsManagers[Index].Client.Request.Apartment.ApartmentСlass;
                label_StayTime.Text = ClientsManagers[Index].Client.Request.Apartment.StayTime[(int)StayTime.Days].ToString() + " Днів " + ClientsManagers[Index].Client.Request.Apartment.StayTime[(int)StayTime.Hours].ToString() + " Годин " + ClientsManagers[Index].Client.Request.Apartment.StayTime[(int)StayTime.Minutes].ToString() + " Хвилин";
                label_RequestState.Text = ClientsManagers[Index].Client.Request.State.ToString();
            }
        }
    }
}
