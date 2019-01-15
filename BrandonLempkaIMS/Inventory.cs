using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrandonLempkaIMS
{
    public abstract class Inventory
    {
        private BindingList<Product> _products;
        private static BindingList<Part> _allParts;

        public BindingList<Product> Products
        {
            get
            {
                if (_products == null)
                    _products = new BindingList<Product>();
                return _products;
            }
            set
            {
                _products = value;
            }
        }

        public static BindingList<Part> AllParts
        {
            get
            {
                if (_allParts == null)
                    _allParts = new BindingList<Part>();
                return _allParts;
            }
            set
            {
                _allParts = value;
            }
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public bool RemoveProduct(int prodNo)
        {
            var product = Products.FirstOrDefault(x => x.ProductId == prodNo);
            if (product != null)
                Products.Remove(product);
            return product != null;
        }

        public Product LookupProduct(int prodNo)
        {
            return Products.FirstOrDefault(x => x.ProductId == prodNo);
        }

        public void UpdateProduct(int productNo, Product product)
        {
            if (product == null)
                return;
            var existingProduct = Products.FirstOrDefault(x => x.ProductId == productNo);
            if (existingProduct != null)
            {
                var prodIndex = Products.IndexOf(existingProduct);
                Products[prodIndex].ProductId = product.ProductId;
                Products[prodIndex].Name = product.Name;
                Products[prodIndex].Price = product.Price;
                Products[prodIndex].InStock = product.InStock;
                Products[prodIndex].Min = product.Min;
                Products[prodIndex].Max = product.Max;
                Products[prodIndex].AssociatedParts = product.AssociatedParts;
            }
        }

        public void AddPart(Part part)
        {
            AllParts.Add(part);
        }

        public bool DeletePart(int partNo)
        {
            var existingPart = AllParts.FirstOrDefault(x => x.PartId == partNo);
            if (existingPart != null)
                AllParts.Remove(existingPart);
            return existingPart != null;
        }

        public Part LookupPart(int partNo)
        {
            return AllParts.FirstOrDefault(x => x.PartId == partNo);
        }

        public void UpdatePart(int partNo, Part part)
        {
            if (part == null)
                return;
            var existingPart = AllParts.FirstOrDefault(x => x.PartId == partNo);
            if (existingPart != null)
            {
                if (part is InHouse)
                {
                    var inHousePart = (InHouse)part;
                    var partIndex = AllParts.IndexOf(existingPart);

                    var foundPart = (InHouse)AllParts[partIndex];

                    foundPart.PartId = inHousePart.PartId;
                    foundPart.Name = inHousePart.Name;
                    foundPart.Price = inHousePart.Price;
                    foundPart.InStock = inHousePart.InStock;
                    foundPart.Min = inHousePart.Min;
                    foundPart.Max = inHousePart.Max;
                    foundPart.MachineId = inHousePart.MachineId;
                    AllParts[partIndex] = foundPart;
                }

                else if(part is Outsourced)
                {
                    var outsourcedPart = (Outsourced)part;
                    var partIndex = AllParts.IndexOf(existingPart);

                    var foundPart = (Outsourced)AllParts[partIndex];

                    foundPart.PartId = outsourcedPart.PartId;
                    foundPart.Name = outsourcedPart.Name;
                    foundPart.Price = outsourcedPart.Price;
                    foundPart.InStock = outsourcedPart.InStock;
                    foundPart.Min = outsourcedPart.Min;
                    foundPart.Max = outsourcedPart.Max;
                    foundPart.CompanyName = outsourcedPart.CompanyName;
                    AllParts[partIndex] = foundPart;
                }

            }
        }
    }
}