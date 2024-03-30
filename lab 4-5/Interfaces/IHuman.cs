namespace lab_4_5.Interfaces
{
    public interface IHuman //2.1 наслідування інтерфейсів
    {
        public string Name { get; set; } //2.1 інтерфейсна властивість
        public string Surname { get; set; } //2.1 інтерфейсна властивість
        public string Patronymic { get; set; } //2.1 інтерфейсна властивість
        public string PhoneNumber { get; set; } //2.1 інтерфейсна властивість
    }
}
