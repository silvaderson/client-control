﻿using System;

namespace Domain
{
    public class Client : BaseEntity
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Email { get; private set; }
        public string DocumentNumber { get; private set; }
        public Address Address { get; private set; }
        public DateTime BirthDate { get; private set; }

        public Client(string firstName, string lastName, string phoneNumber, string email, string documentNumber,DateTime birthDate, Address address)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
            DocumentNumber = documentNumber;
            Address = address;
            BirthDate = birthDate;
        }
        public void UpdateClient(string firstName, string lastName, string phoneNumber, string email, string documentNumber, DateTime birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
            DocumentNumber = documentNumber;
            BirthDate = birthDate;

        }

    }
}
