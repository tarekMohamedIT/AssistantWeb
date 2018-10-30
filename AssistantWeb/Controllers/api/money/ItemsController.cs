using AssistantWeb.DatabaseContext;
using AssistantWeb.Models.Money;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AssistantWeb.Controllers.api.money
{
    public class ItemsController : ApiController
    {
        private AssistantDbContext _context;

        public ItemsController()
        {
            _context = new AssistantDbContext();
        }

        // /api/money/items
        public IHttpActionResult GetItems()
        {
            var content = _context
                .Items
                .Include(i => i.Wallet).ToList();

            if (content == null)
                return BadRequest("An error occured while fetching the data from the database.");

            return Ok(content);
        }

        // /api/money/items/{Id}
        public IHttpActionResult GetItems(int Id)
        {
            var content = _context
                .Items
                .Include(i => i.Wallet)
                .Select(i => i.Id == Id);

            if (content == null)
                return BadRequest("Testing");

            return Ok(content);
        }


        // POST /api/money/items

        [HttpPost]
        public IHttpActionResult AddItem(Item item)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            _context.Items.Add(item);
            _context.SaveChanges();

            return Ok(item);
        }

        [HttpPut]
        public void UpdateCustomer(int Id, Item item)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var itemInDb = _context.Items.FirstOrDefault(c => c.Id == Id);

            if (itemInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            itemInDb.Name = item.Name;
            itemInDb.quantity = item.quantity;
            itemInDb.PricePerUnit = item.PricePerUnit;
            itemInDb.Wallet = item.Wallet;
            itemInDb.WalletId = item.WalletId;
            itemInDb.DateAdded = item.DateAdded;

            _context.SaveChanges();
        }

        [HttpDelete]
        public void DeleteCustomer(int Id)
        {
            var itemInDb = _context.Items.FirstOrDefault(c => c.Id == Id);

            if (itemInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Items.Remove(itemInDb);
            _context.SaveChanges();
        }
    }
}
