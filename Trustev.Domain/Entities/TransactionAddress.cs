﻿using System;

namespace Trustev.Domain.Entities
{
    public class TransactionAddress
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public int Type { get; set; }
        public string CountryCode { get; set; }
        public DateTime Timestamp { get; set; }
        public bool IsDefault { get; set; }


    }
}