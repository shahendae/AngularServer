using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using AngularServer.Models;

namespace AngularServer.Controllers
{
    public class OrdersController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/Orders
        public IQueryable<Order> GetOrders()
        {
            return db.Orders;
        }

        // GET: api/Orders/5      
 
        [ResponseType(typeof(Order))]
        public IHttpActionResult GetOrder(int id)
        {

            Order order = db.Orders.Find(id);
            if (order == null)
            {
                return NotFound();
            }

            return Ok(order);
        }


        // api for orders of user in specific period of time 
        // GET: api/Orders/{ApplicationUserId , Date to , Date from}
        [Route("api/Order/{id}/{from}/{to}")] // /{id}
        [ResponseType(typeof(Order))]
        public IQueryable<Order> GetOrder(string id, DateTime from, DateTime to)
        {
            var order = db.Orders.Where(a => a.ApplicationUserId == id && a.Date >= from && a.Date <= to);
            return order;
        }



        // PUT: api/Orders/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutOrder(int id)
        {
            var order = db.Orders.First(o => o.Id == id);
            order.Action = "Done";
            db.Entry(order).State = EntityState.Modified;
            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Orders
        [ResponseType(typeof(Order))]
        public IHttpActionResult PostOrder(Order order)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Orders.Add(order);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = order.Id }, order);
        }

        // DELETE: api/Orders/5
        [ResponseType(typeof(Order))]
        public IHttpActionResult DeleteOrder(int id)
        {
            Order order = db.Orders.Find(id);
            if (order == null)
            {
                return NotFound();
            }

            db.Orders.Remove(order);
            db.SaveChanges();

            return Ok(order);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool OrderExists(int id)
        {
            return db.Orders.Count(e => e.Id == id) > 0;
        }

        [Route("api/Order/products")] // /{id}
        [ResponseType(typeof(Order))]
        public IQueryable GetOrderProuducts()
        {
            var today = DateTime.Now.Date;
            var orders = db.Orders
                        .Where(o => o.Date == today && o.Action == "Waiting")
                        .Select(order => new
                        {
                            order.Id,
                            order.ApplicationUser.UserName,
                            order.Date,
                            order.Notes,
                            order.Action,
                            order.TotalAmount,
                            products = order.Products.Select(p=>new { p.ProductName })
                        });
            return orders;
        }
    }
}