using AgencyBankingWebAPI.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AgencyBankingWebAPI.Models;

namespace AgencyBankingWebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly ApiContext _context;
        public TransactionController(ApiContext context)
        {
            _context = context;
        }
        //Create/ Edit
        [HttpPost]
        public JsonResult CreateEdit(Transaction transaction)
        {
            if (transaction.Id == 0)
            {
                _context.Transactions.Add(transaction);
            }
            else
            {
                var transactionInDb = _context.Transactions.Find(transaction.Id);
                if (transactionInDb == null)
                    return new JsonResult(NotFound());
                transactionInDb = transaction;
            }
            _context.SaveChanges();
            return new JsonResult(Ok(transaction));
        }
        //Get
        [HttpGet]
        public JsonResult Get(int id)
        {
            var result = _context.Transactions.Find(id);
            if (result == null)
                return new JsonResult(NotFound());
            return new JsonResult(Ok(result));
        }
        //DELETE
        [HttpDelete]
        public JsonResult Delete(int id)
        {
            var result = _context.Transactions.Find(id);
            if (result == null)
                return new JsonResult(NotFound());
            _context.Transactions.Remove(result);
            _context.SaveChanges();

            return new JsonResult(Ok(result));
        }
        //GETALL
        [HttpGet ()]
        public JsonResult GetAll()
        {
            var result = _context.Transactions.ToList();
            return new JsonResult (Ok(result));
        }
    }
}
