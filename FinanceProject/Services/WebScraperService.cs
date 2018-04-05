using FinanceProject.Interfaces;
using FinanceProject.Models;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinanceProject.Services
{
    public class WebScraperService : IWebScraperService
    {
        public List<CardScrape> CashBackScrape()
        {
            List<CardScrape> list = new List<CardScrape>();

            string html = "https://www.nerdwallet.com/blog/top-credit-cards/nerdwallets-best-cash-back-credit-cards/?trk=nw_gn1_4.0";
            HtmlWeb web = new HtmlWeb();
            HtmlDocument htmlDoc = web.Load(html);

            HtmlNode[] headers = htmlDoc.DocumentNode.SelectNodes("//h3[@class='nw-summary-table-heading']").ToArray();

            foreach (HtmlNode item in headers)
            {
                CardScrape obj = new CardScrape();
                obj.CardHeading = item.InnerHtml;
                list.Add(obj);
            }

            HtmlNode[] titles = htmlDoc.DocumentNode.SelectNodes("//h3[@class='nw-product-card-title']").ToArray();

            for(int i = 0; i < list.Count; i++)
            {
                list[i].CardTitle = titles[i].InnerHtml;  
                list[i].CardTitle = list[i].CardTitle.Replace("&reg;", "");
                list[i].CardTitle = list[i].CardTitle.Replace("&#8480;", "");
            }

            HtmlNode[] images = htmlDoc.DocumentNode.SelectNodes("//img[@class='card-image card-image-medium']").ToArray();

            for (int i = 0; i < list.Count; i++)
            {
                list[i].CardImage = images[i].Attributes["src"].Value;
                list[i].CardImage = list[i].CardImage.Substring(2);
            }

            return list;
        }

        public List<CardScrape> TravelScrape()
        {
            List<CardScrape> list = new List<CardScrape>();

            string html = "https://www.nerdwallet.com/blog/top-credit-cards/nerdwallets-best-travel-credit-cards/?trk=nw_gn1_4.0";
            HtmlWeb web = new HtmlWeb();
            HtmlDocument htmlDoc = web.Load(html);

            HtmlNode[] headers = htmlDoc.DocumentNode.SelectNodes("//h3[@class='nw-summary-table-heading']").ToArray();

            foreach (HtmlNode item in headers)
            {
                CardScrape obj = new CardScrape();
                obj.CardHeading = item.InnerHtml;
                list.Add(obj);
            }

            HtmlNode[] titles = htmlDoc.DocumentNode.SelectNodes("//h3[@class='nw-product-card-title']").ToArray();

            for (int i = 0; i < list.Count; i++)
            {
                list[i].CardTitle = titles[i].InnerHtml;
                list[i].CardTitle = list[i].CardTitle.Replace("&reg;", "");
                list[i].CardTitle = list[i].CardTitle.Replace("&#8480;", "");
            }

            HtmlNode[] images = htmlDoc.DocumentNode.SelectNodes("//img[@class='card-image card-image-medium']").ToArray();

            for (int i = 0; i < list.Count; i++)
            {
                list[i].CardImage = images[i].Attributes["src"].Value;
                list[i].CardImage = list[i].CardImage.Substring(2);
            }

            return list;
        }

        public List<CardScrape> BalanceTransferScrape()
        {
            List<CardScrape> list = new List<CardScrape>();

            string html = "https://www.nerdwallet.com/blog/top-credit-cards/nerdwallets-best-balance-transfer-credit-cards/?trk=nw_gn1_4.0";
            HtmlWeb web = new HtmlWeb();
            HtmlDocument htmlDoc = web.Load(html);

            HtmlNode[] headers = htmlDoc.DocumentNode.SelectNodes("//h3[@class='nw-summary-table-heading']").ToArray();

            foreach (HtmlNode item in headers)
            {
                CardScrape obj = new CardScrape();
                obj.CardHeading = item.InnerHtml;
                list.Add(obj);
            }

            HtmlNode[] titles = htmlDoc.DocumentNode.SelectNodes("//h3[@class='nw-product-card-title']").ToArray();

            for (int i = 0; i < list.Count; i++)
            {
                list[i].CardTitle = titles[i].InnerHtml;
                list[i].CardTitle = list[i].CardTitle.Replace("&reg;", "");
                list[i].CardTitle = list[i].CardTitle.Replace("&#8480;", "");
            }

            HtmlNode[] images = htmlDoc.DocumentNode.SelectNodes("//img[@class='card-image card-image-medium']").ToArray();

            for (int i = 0; i < list.Count; i++)
            {
                list[i].CardImage = images[i].Attributes["src"].Value;
                list[i].CardImage = list[i].CardImage.Substring(2);
            }

            return list;
        }


    }
}