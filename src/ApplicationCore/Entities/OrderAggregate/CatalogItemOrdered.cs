using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities.OrderAggregate
{
    /// <summary>
    /// Represents a snapshot of the item that was ordered. If catalog item details change, details of
    /// the item that was part of a completed order should not change.
    /// </summary>
    public class CatalogItemOrdered // ValueObject
    {
        public int CatalogItemId { get; private set; }
        public string ProductName { get; private set; }
        public string PictureUri { get; private set; }

        public CatalogItemOrdered(int catalogItemId, string productName, string pictureUri)
        {
            if (!(catalogItemId >= 1 && catalogItemId <= int.MaxValue)) throw new ArgumentOutOfRangeException();
            if (productName == null) throw new ArgumentNullException();
            if (productName == string.Empty) throw new ArgumentException("ProductName cannot be empty");
            if (pictureUri == null) throw new ArgumentNullException();
            if (pictureUri == string.Empty) throw new ArgumentException("PictureUri cannot be empty");

            CatalogItemId = catalogItemId;
            ProductName = productName;
            PictureUri = pictureUri;
        }

        private CatalogItemOrdered()
        {
            // required by EF
        }
    }
}
