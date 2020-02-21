using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _02_Claims_Challenge.Claims;

namespace _02_Claims_Challenge
{
    public class ProgramUI_02
    {
        private Claims_Repository _claimRepo = new Claims_Repository();
        private readonly Claims _claim = new Claims();
        public void Run()
        {
            _claimRepo.AddtoQueue(1, "Car Accident on 465.", 400, DateTime.Now, DateTime.Now, true, ClaimType.Car));

            _claimRepo.AddtoQueue(2, "House Break In.", 400, DateTime.Now, DateTime.Now, true, ClaimType.Home));


            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("1.See all Claims in queue\n" +
                    "2. Next Claim in queue\n" +
                    "3. Enter new Claim.");
                string InputAsString = Console.ReadLine();
                int inputType = int.Parse(InputAsString);
                switch (inputType)
                {
                    case 1:
                        SeeAllClaims();
                        break;
                    case 2:
                        DoNextClaim();
                        break;
                    case 3:
                        EnterNewClaim();
                        break;
                }
            }
        }

        private void EnterNewClaim()
        {
            Claims newClaim = new Claims();
            Console.WriteLine("Enter the Claim information:\n" +
                "What is the Claim ID?");
            string claimId = Console.ReadLine();

            Console.WriteLine("What is the Claim Description?");
            Console.ReadLine();

            Console.WriteLine("What is the Claim Amount?");
            string claimAmount = Console.ReadLine();

            Console.WriteLine("Last, what is the Claim Type?:\n" +
                "1. Car\n" +
                "2. Home \n" +
                "3. Theft\n");
            string OrderAsString = Console.ReadLine();

            int claimType = int.Parse(OrderAsString);

            switch (claimType)
            {
                case 1:
                    newClaim.TypeOfClaim = ClaimType.Car;
                    break;
                case 2:
                    newClaim.TypeOfClaim = ClaimType.Home;
                    break;
                case 3:
                    newClaim.TypeOfClaim = ClaimType.Theft;
                    break;

            }

            Console.WriteLine("Date of the incident?");
            string DateofIncident = Console.ReadLine();

            Console.WriteLine("When was the claim entered?");
            string DateofClaim = Console.ReadLine();


            double DayDifference = (newClaim.DateOfClaim - newClaim.DateOfIncident);
            if (DayDifference > 30)
            {
                newClaim.IsValid = false;
            }
            else
            {
                newClaim.IsValid = true;

            }

            _claimRepo.AddtoQueue(newClaim);
        }
        private void DoNextClaim()
        {
            Claims NextClaim = _claimRepo.GetClaims().Peek();

            string TakeNextClaim = Console.ReadLine();
            if (TakeNextClaim.ToUpper() == "Y")
            {
                _claimRepo.GetNextClaim();
            }
        }

        private void SeeAllClaims()
        {
            IEnumerable<Claims> claimsData = _claimRepo.GetClaims().AsEnumerable<Claims>();

            Console.WriteLine("Claim ID", "Type", "Description", "Amount", "DateOfAccident", "DateOFClaim", "IsValid");
            foreach (Claims claim in claimsData)
            {
                Console.WriteLine(claim.ClaimId, claim.TypeOfClaim, claim.ClaimDescription, claim.ClaimAmount, claim.DateOfIncident, claim.DateOfClaim, claim.IsValid); ;
            }
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();
        }
    }
}
