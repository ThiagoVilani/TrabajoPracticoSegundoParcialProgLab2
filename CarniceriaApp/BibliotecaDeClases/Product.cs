﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BibliotecaDeClases
{
    /// <summary>
    /// Representa a un producto de carniceria
    /// </summary>
    public class Product
    {
        private static int IDCount = 1000;

        [XmlIgnore]
        public int ID { get; private set; }
        public double Price { get; set; }
        public string Name { get; set; }
        public double Stock { get; set; }
        public string Details { get; set; }



        public Product() { }

        /// <summary>
        /// Se encarga de cargar el nombre, precio, stock y detalles del producto
        /// </summary>
        /// <param name="name">Recibe el nombre que lleva el producto</param>
        /// <param name="price">Recibe el precio del producto</param>
        /// <param name="stock">Recibe la cantidad de kilos que hay del producto</param>
        /// <param name="details">Recibe los detalles del producto</param>
        public Product(string name, double price, double stock,string details) 
        {
            this.Name = name;
            this.Price = price;
            this.Stock = stock;
            this.Details = details;
            IDCount++;
            this.ID = IDCount;
        }

        public Product(string name, double price, double stock, string details,int ID) :this(name,price,stock,details) 
        {
            this.ID = ID;
        }
    }
}
