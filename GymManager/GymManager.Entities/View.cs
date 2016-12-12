using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Review IP: remove unused usings, just as you`ve done in other files
namespace GymManager.Entities
{
    public class View
    {
        public int Id { get; set; }
        public string NameSurname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int CardNumber { get; set; }
        public string CardType { get; set; }
        public string RegistrationDate { get; set; }
        public string EndDate { get; set; }
        public int Balance { get; set; }
        public string AdministratorName { get; set; }
        public string CardStatus { get; set; }
    }
}
