using MyProducts.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Mvc;
//using System.Data.Entity;
//using System.Data.Entity.Infrastructure;

namespace MyProducts.WebAPI.Controllers
{
    /*
    public class TestController : ApiController
    {


        //public HttpResponseMessage Get()
        //{
        //    return new HttpResponseMessage()
        //    {
        //        Content = new StringContent("GET: Test message")
        //    };
        //}

        //public HttpResponseMessage Post()
        //{
        //    return new HttpResponseMessage()
        //    {
        //        Content = new StringContent("POST: Test message")
        //    };
        //}

        //public HttpResponseMessage Put()
        //{
        //    return new HttpResponseMessage()
        //    {
        //        Content = new StringContent("PUT: Test message")
        //    };
        //}

    }
    */

    [EnableCors(origins: "http://localhost:44888", headers: "*", methods: "*")]
    public class TestController : ApiController
    {
        private MyProductsLocalDBEntities db = new MyProductsLocalDBEntities();
        // GET: api/Product
        public IEnumerable<Object> Get()
        {
            var myObjects = (from prod in db.Products
                             join img in db.ProductImages on prod.Id equals img.ProductId
                             select new
                             {
                                 prod.Name,
                                 prod.Description,
                                 img.ImageSource
                             }).ToList();
            return myObjects;
        }
    }
}