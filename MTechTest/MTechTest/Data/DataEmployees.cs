using MTechTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace MTechTest.Data
{
    public class DataEmployees
    {
        /*
         Initialize the employees list
         */
        List<Employee> employeesList = new List<Employee>
        {
            new Employee
            {
                ID = 1,
                Name= "Pedro",
                LastName = "Rubens",
                RFC = "RUPE770628001",
                BornDate = DateTime.Parse("28/06/1977"),
                Status = EmployeeStatus.Active,
            },
            new Employee
            {
                ID = 2,
                Name= "Theodore",
                LastName = "Gericault",
                RFC = "GETH910926002",
                BornDate = DateTime.Parse("26/09/1991"),
                Status = EmployeeStatus.Inactive,
            },
            new Employee
            {
                ID = 3,
                Name= "Paolo",
                LastName = "Caliari",
                RFC = "PACA880419003",
                BornDate = DateTime.Parse("19/04/1988"),
                Status = EmployeeStatus.NotSet,
            },
        };

        /*
         Inserts the data given
        by the user
         */
        public void InsertData(Employee employee)
        {
            employeesList.Add(employee);
        }

        /*
         Validates that the RFC is
        unique in the List.
         */
        public Boolean ValidateUniquenessRFC(string RFC)
        {
            var RFCList = employeesList.Where(e => e.RFC == RFC);
            return (RFCList.Count() == 0);
        }

        /*
         Validates that the RFC format is correct
        also its length (13 characters)
        
        RFC Format:
        -First 2 characters of the Last name
        -First 2 characters of the Name
        -Birth year (2 digits)
        -Birth month (2 digits)
        -Birth day (2 digits)
        -Homoclave (3 digits)
         */
        public Boolean ValidateRFCFormatAndLength(string RFC)
        {
            if (RFC.Length == 13)
            {
                Regex rx = new Regex(@"^([A-ZÑ\x26]{3,4}([0-9]{2})(0[1-9]|1[0-2])(0[1-9]|1[0-9]|2[0-9]|3[0-1]))((-)?([A-Z\d]{3}))?$");
                return (rx.IsMatch(RFC));
            }
            else return false;
        }
        
        /*
         Checks if the string given has no numbers
        or empty and has a valid length
         */
        public Boolean ValidString(string Chain)
        {
            Chain = Chain.Trim();
            Regex rx = new Regex(@"^[a-z]{2,30}$");
            return (Chain.Length != 0 && Chain != null && rx.IsMatch(Chain.ToLower()));
        }

        /*
         Returns a sorted list by date
         */
        public List<Employee> OrderDataByBornDate()
        {
            List<Employee> SortedList = employeesList.OrderBy(e => e.BornDate).ToList();
            return SortedList;
        }

        /*
         Returns a sorted list by name
         */
        public List<Employee> OrderDataByName()
        {
            List<Employee> SortedList = employeesList.OrderBy(e => e.Name).ToList();
            return SortedList;
        }

        /*
         Retrieves a free ID, so the user does not
        have to write it
         */
        public int RetrieveNewID()
        {
            return employeesList.Count()+1;
        }
    }
}


