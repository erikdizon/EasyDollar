using DbConnector.Tools;
using FinanceProject.Interfaces;
using FinanceProject.Models;
using FinanceProject.Models.Requests;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FinanceProject.Services
{
    public class CreditCardService : BaseService, ICreditCardService
    {
        public IEnumerable<CreditCard> SelectAll()
        {
            return Adapter.LoadObject<CreditCard>("dbo.CreditCard_SelectAll");
        }

        public CreditCard SelectById(int id)
        {
            return Adapter.LoadObject<CreditCard>("dbo.CreditCard_SelectById", new[] { new SqlParameter("@Id", id) }).FirstOrDefault();
        }

        public int Insert(CreditCardAddRequest model)
        {
            int id = 0;
            Adapter.ExecuteQuery("dbo.CreditCard_Insert",
                new[]
                {
                    new SqlParameter("@Name", model.Name),
                    new SqlParameter("@AnnualFee", model.AnnualFee),
                    new SqlParameter("@BonusOffer", model.BonusOffer),
                    new SqlParameter("@Description", model.Description),
                    new SqlParameter("@FileRepositoryId", model.FileRepositoryId),
                    new SqlParameter("@DisplayOrder", model.DisplayOrder),
                    new SqlParameter("@IsActive", model.IsActive),
                    SqlDbParameter.Instance.BuildParameter("@Id", 0, System.Data.SqlDbType.Int, paramDirection: System.Data.ParameterDirection.Output)
                },
                (parameters =>
                {
                    id = parameters.GetParmValue<int>("@Id");
                }
                ));
            return id;
        }

        public void Update(CreditCardUpdateRequest model)
        {
            Adapter.ExecuteQuery("dbo.CreditCard_Update",
                new[]
                {
                    new SqlParameter("@Id", model.Id),
                    new SqlParameter("@Name", model.Name),
                    new SqlParameter("@AnnualFee", model.AnnualFee),
                    new SqlParameter("@BonusOffer", model.BonusOffer),
                    new SqlParameter("@Description", model.Description),
                    new SqlParameter("@FileRepositoryId", model.FileRepositoryId),
                    new SqlParameter("@DisplayOrder", model.DisplayOrder),
                    new SqlParameter("@IsActive", model.IsActive)
                });
        }

        public void Delete(int id)
        {
            Adapter.ExecuteQuery("dbo.CreditCard_Delete",
                new[]
                {
                     new SqlParameter("@Id", id)
                }
                );
        }
    }
}