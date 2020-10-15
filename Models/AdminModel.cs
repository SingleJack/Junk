using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchedulerApp.Models
{
    public class AdminModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Date { get; set; }
        public string Duties { get; set; }
        public int Service { get; set; }
        public string UserID { get; set; }

        public AdminModel()
        {
            Id = -1;
            FirstName = "";
            LastName = "";
            Date = DateTime.Now;
            Duties = "";
            Service = 0;
        }

        public AdminModel(int id, string firstName, string lastName, DateTime date, string duties, int service, string userID)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Date = date;
            Duties = duties;
            Service = service;
            UserID = userID;
        }
    }
}