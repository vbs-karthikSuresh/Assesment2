﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace web_api_core.Models
{
    public partial class Person
    {
        public Person()
        {
            BusinessEntityContact = new HashSet<BusinessEntityContact>();
            Customer = new HashSet<Customer>();
            EmailAddress = new HashSet<EmailAddress>();
            PersonCreditCard = new HashSet<PersonCreditCard>();
            PersonPhone = new HashSet<PersonPhone>();
        }

        public int BusinessEntityId { get; set; }
        public string PersonType { get; set; }
        public bool NameStyle { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }
        public int EmailPromotion { get; set; }
        public string AdditionalContactInfo { get; set; }
        public string Demographics { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual BusinessEntity BusinessEntity { get; set; }
        public virtual Employee1 Employee1 { get; set; }
        public virtual Password Password { get; set; }
        public virtual ICollection<BusinessEntityContact> BusinessEntityContact { get; set; }
        public virtual ICollection<Customer> Customer { get; set; }
        public virtual ICollection<EmailAddress> EmailAddress { get; set; }
        public virtual ICollection<PersonCreditCard> PersonCreditCard { get; set; }
        public virtual ICollection<PersonPhone> PersonPhone { get; set; }
    }
}
