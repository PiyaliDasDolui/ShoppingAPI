using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

namespace TodoApi.Controllers{
    [Route("api/[controller]")]
    [ApiController]

    public class ShoppingController : ControllerBase {

        private readonly ShoppingContext _context;
        public ShoppingController(ShoppingContext context) {
            _context = context;
        }

        [HttpGet]
        public  async Task<IEnumerable<ShoppingItem>> ShowCart() {
            return await _context.ShoppingItems.ToListAsync();
        }

        [HttpPost]
        public async Task<ShoppingItem>  AddToCart(ShoppingItem shoppingItem){
            _context.ShoppingItems.Add(shoppingItem);
            await _context.SaveChangesAsync();  
        
            return shoppingItem;
        }
    }
}