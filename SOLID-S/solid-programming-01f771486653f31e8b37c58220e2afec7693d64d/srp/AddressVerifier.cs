using System;

namespace SingleResponsibilityPrinciple
{
    public class AddressVerifier{
        public bool IsAddressValid(Account account){ // single responsibility principle için öok uygun bir class
            // Why do I care about account?
            // return postalService.CheckAddress(account.Street, account.City, address.Zipcode);
            return true;
        }
    }
}