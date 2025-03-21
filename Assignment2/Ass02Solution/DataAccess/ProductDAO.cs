﻿using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ProductDAO
    {
        private static ProductDAO instance = null;
        private static readonly object instanceLock = new object();
        private MyStoreContext _context;
        private ProductDAO() 
        { 
            _context = new MyStoreContext();
        }
        public static ProductDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ProductDAO();
                    }
                    return instance;
                }
            }
        }
        public IEnumerable<Product> GetMembers()
        {
            return _context.Products.ToList();
        }
        public void Add(Product entity)
        {
            if (entity == null) throw new ArgumentNullException("Entity is null");
            else
            {
                _context.Products.Add(entity);
                _context.SaveChanges();
            }
        }
        public void Remove(Product entity)
        {
            if (entity == null) throw new ArgumentNullException("Entity is null");
            else
            {
                var found = _context.Products.Where(m => m.ProductId == entity.ProductId).FirstOrDefault();
                if (found != null)
                {
                    _context.Products.Remove(found);
                    _context.SaveChanges();
                }
            }
        }
        public void Update(Product entity)
        {
            if (entity == null) throw new ArgumentNullException("Entity is null");
            else
            {
                var found = _context.Products.Where(m => m.ProductId == entity.ProductId).FirstOrDefault();
                if (found != null)
                {
                    _context.Entry(found).CurrentValues.SetValues(entity);
                    _context.SaveChanges();
                }
            }
        }
    }
}
