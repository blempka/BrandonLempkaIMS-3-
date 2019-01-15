using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrandonLempkaIMS
{
    public abstract class Product
    {
        private BindingList<Part> _associatedParts;

        public BindingList<Part> AssociatedParts
        { get
            {
                if (_associatedParts == null)
                    _associatedParts = new BindingList<Part>();
                return _associatedParts;
            }
            set
            {
                _associatedParts = value;
            }
        }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public void AddAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

        public bool RemoveAssociatedPart(int partNo)
        {
            var part = AssociatedParts.FirstOrDefault(x => x.PartId == partNo);
            if (part != null)
                AssociatedParts.Remove(part);
            return part != null;
        }

        public Part LookupAssociatedPart(int partNo)
        {
            return AssociatedParts.FirstOrDefault(x => x.PartId == partNo);
        }
    }
}
