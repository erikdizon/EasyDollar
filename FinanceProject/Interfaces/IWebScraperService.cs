using FinanceProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceProject.Interfaces
{
    public interface IWebScraperService
    {
        List<CardScrape> CashBackScrape();

        List<CardScrape> TravelScrape();

        List<CardScrape> BalanceTransferScrape();
    }
}
