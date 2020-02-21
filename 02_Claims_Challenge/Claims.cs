using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Claims_Challenge
{
    class Claims
    {
        public ClaimType TypeOfClaim { get; internal set; }
        public int DateOfIncident { get; internal set; }
        public int DateOfClaim { get; internal set; }
        public bool IsValid { get; internal set; }
        public bool ClaimId { get; internal set; }
        public int ClaimDescription { get; internal set; }
        public object ClaimAmount { get; internal set; }

        public enum ClaimType
        {
            Car, Home, Theft
        }

        public class ClaimsProp
        {
            public int ClaimId { get; set; }
            public string ClaimDescription { get; set; }
            public decimal ClaimAmount { get; set; }
            public DateTime DateOfIncident { get; set; }
            public DateTime DateOfClaim { get; set; }
            public bool IsValid { get; set; }
            public ClaimType TypeOfClaim { get; set; }

            public void Claims() { }
            public void Claims(int claimId, string claimDescription, decimal claimAmount, DateTime dateOfIncident, DateTime dateOfClaim, bool isValid, ClaimType typeOfClaim)
            {
                ClaimId = claimId;
                ClaimDescription = claimDescription;
                ClaimAmount = claimAmount;
                DateOfIncident = dateOfIncident;
                DateOfClaim = dateOfClaim;
                IsValid = isValid;
                TypeOfClaim = typeOfClaim;

            }

        }
    }
}

