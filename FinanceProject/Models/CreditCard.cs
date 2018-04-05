using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinanceProject.Models
{
    public class CreditCard
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int AnnualFee { get; set; }

        public string BonusOffer { get; set; }

        public string Description { get; set; }

        public int FileRepositoryId { get; set; }

        public int DisplayOrder { get; set; }

        public bool IsActive { get; set; }
    }
}