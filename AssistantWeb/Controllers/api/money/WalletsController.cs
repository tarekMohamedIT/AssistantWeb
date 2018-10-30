using AssistantWeb.DatabaseContext;
using AssistantWeb.Models.Money;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AssistantWeb.Controllers.api.money
{
    public class WalletsController : ApiController
    {
        private AssistantDbContext _context;

        public WalletsController()
        {
            _context = new AssistantDbContext();
        }

        // /api/money/wallets
        public IHttpActionResult GetWallets()
        {
            var content = _context
                .Wallets
                .ToList();

            if (content == null)
                return BadRequest("An error occured while fetching the data from the database.");

            return Ok(content);
        }

        // /api/money/wallets/{Id}
        public IHttpActionResult GetWallets(int Id)
        {
            var content = _context
                .Wallets
                .Select(i => i.Id == Id);

            if (content == null)
                return BadRequest("Testing");

            return Ok(content);
        }


        // POST /api/money/wallets

        [HttpPost]
        public IHttpActionResult AddWallet(Wallet wallet)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            _context.Wallets.Add(wallet);
            _context.SaveChanges();

            return Ok(wallet);
        }

        [HttpPut]
        public void UpdateWallet(int Id, Wallet wallet)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var walletInDb = _context.Wallets.FirstOrDefault(c => c.Id == Id);

            if (walletInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            walletInDb.Name = wallet.Name;
            walletInDb.TotalMoney = wallet.TotalMoney;
            walletInDb.RemainingMoney = wallet.RemainingMoney;

            _context.SaveChanges();
        }

        [HttpDelete]
        public void DeleteWallet(int Id)
        {
            var walletInDb = _context.Wallets.FirstOrDefault(c => c.Id == Id);

            if (walletInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Wallets.Remove(walletInDb);
            _context.SaveChanges();
        }
    }
}
