namespace Vtitbid.ISP20.SarbaevZlokazov.Project
{
    public class Person
    {
        public string firstname;
        public string Firstname
        {
            get
            {
                return firstname;
            }
            set
            {
                int temp;
                if (!String.IsNullOrEmpty(value) && int.TryParse(value,out temp)==false)
                {
                    firstname = value;
                }
                else
                {
                    PersonAction.GetError();
                }
            }
        }

        public string lastname;
        public string Lastname
        {
            get
            {
                return lastname;
            }
            set
            {
                int temp;
                if (!String.IsNullOrEmpty(value) && int.TryParse(value, out temp) == false)
                {
                    lastname = value;
                }
                else
                {
                    PersonAction.GetError();
                }
            }
        }

        public string PhoneNumber { get; set; }
        public DateTime DayOfBirth { get; set;}
        public Person (string firstname, string lastname, string phoneNumber, DateTime dateTime)
        {
            Firstname = firstname;
            Lastname = lastname;
            PhoneNumber = phoneNumber;
            DayOfBirth = dateTime;
        }
        public override string ToString()
        {
            return $"Имя: {Firstname}\nФамилия: {Lastname}\nНомер телефона: {PhoneNumber}\nДата рождения: {DayOfBirth.ToShortDateString()}";
        }
    }
}
