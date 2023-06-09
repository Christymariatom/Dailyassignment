﻿using System;
namespace carpoolreq1

{
    internal class Member

    {

        private long _id;
        private string _firstname;
        private string _lastname;
        private string _email;
        private string _contactnumber;
        private string _licensenumber;
        private DateTime _licenseStartDate;
        private DateTime _licenseExpiryDate;

        public long Id

        {
            get { return _id; }
            set { _id = value; }
        }

        public string Firstname
        {
            get { return _firstname; }
            set { _firstname = value; }
        }

        public string Lastname

        {
            get { return _lastname; }
            set { _lastname = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Contactnumber

        {
            get { return _contactnumber; }
            set { _contactnumber = value; }
        }

        public string LicenseNumber

        {
            get { return _licensenumber; }
            set { _licensenumber = value; } 
        }

        public DateTime LicenseStartDate

        {

            get { return _licenseStartDate; }

            set { _licenseStartDate = value; }

        }

        public DateTime LicenseExpiryDate

        {
            get { return _licenseExpiryDate; }
            set { _licenseExpiryDate = value; }
        }

        public Member(long id, string firstname, string lastname, string email, string contactnumber, string licensenumber, DateTime licenseStartDate, DateTime licenseExpiryDate)

        {
            _id = id;
            _firstname = firstname;
            _lastname = lastname;
            _email = email;
            _contactnumber = contactnumber;
            _licensenumber = licensenumber;
            _licenseStartDate = licenseStartDate;
            _licenseExpiryDate = licenseExpiryDate;
        }

        public override string ToString()

        {
            return $"Member: {_firstname} {_lastname}\n" +
            $"Member contact details: {_contactnumber}, {_email}";
        }

        public override bool Equals(object obj)

        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Member member = (Member)obj;
            return Email.ToLower() == member.Email.ToLower() && Contactnumber.ToLower() == member.Contactnumber.ToLower();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }

}


















