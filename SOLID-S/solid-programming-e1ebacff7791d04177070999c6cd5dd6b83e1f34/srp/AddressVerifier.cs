using System;

namespace SingleResponsibilityPrinciple
{
    public class AddressVerifier{
        public bool IsAddressValid(Account account){
            // NEW CODE -- Check country is in the supported countries.
            // Why do I care about account?
            // return postalService.CheckAddress(account.Street, account.City, address.Zipcode);
            return true;
        }
    }
}