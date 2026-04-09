using ContactDemo.Models;


namespace ContactDemo.DataAccess
{
    public class ContactRepoImp : IContactRepo<ContactInfo>
    {
        public static List<ContactInfo> contacts = new List<ContactInfo>
        {
             new ContactInfo{ ContactId=1,FirstName="Sai",LastName="Gurram",CompanyName="Cognizant",EmailId="ajay@gmail.com",MobileNo=123456789,Designation="Traine" },
             new ContactInfo{ ContactId=2,FirstName="Kumar",LastName="Venkata",CompanyName="Cogn",EmailId="kumar@gmail.com",MobileNo=123456789,Designation="Testing" },
             new ContactInfo{ ContactId=3,FirstName="Kishore",LastName="Pavan",CompanyName="Cog",EmailId="saii@gmail.com",MobileNo=123456789,Designation="Analyst" }
        };
        public bool AddContact(ContactInfo contact)
        {
            contacts.Add(contact);
            return true;
        }

        public ContactInfo GetContactById(int id)
        {
            var contact = contacts.FirstOrDefault(con => con.ContactId.Equals(id));
            return contact;
        }

        public List<ContactInfo> ShowContacts()
        {
            return contacts;
        }
        

    }
}

