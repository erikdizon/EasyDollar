using FinanceProject.Models;
using FinanceProject.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceProject.Interfaces
{
    public interface ICreditCardService
    {
        IEnumerable<CreditCard> SelectAll();

        CreditCard SelectById(int id);

        int Insert(CreditCardAddRequest model);

        void Update(CreditCardUpdateRequest model);

        void Delete(int id);
    }
}
