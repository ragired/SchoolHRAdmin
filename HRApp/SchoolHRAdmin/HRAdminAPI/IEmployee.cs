/*
 * Interface definition for an Employee
 * This realizes the SOLID Goal Dependency Inversion
 * The base class can have a list of IEmployee objects 
 * That way, the base class is not dependent on changing each time the derived class is changed / extended
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRAdminAPI
{
    public interface IEmployee
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        decimal Salary   { get; set; }


    }
}
