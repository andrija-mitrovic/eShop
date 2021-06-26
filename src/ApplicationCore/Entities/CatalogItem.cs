using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class CatalogItem : BaseEntity, IAggregateRoot
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public string PictureUri { get; private set; }
        public int CatalogTypeId { get; private set; }
        public CatalogType CatalogType { get; private set; }
        public int CatalogBrandId { get; private set; }
        public CatalogBrand CatalogBrand { get; private set; }

        public CatalogItem(
            string name,
            string description,
            decimal price,
            string pictureUri,
            int catalogTypeId,
            int catalogBrandId)
        {
            Name = name;
            Description = description;
            Price = price;
            PictureUri = pictureUri;
            CatalogTypeId = catalogTypeId;
            CatalogBrandId = catalogBrandId;
        }

        public void UpdateDetails(string name, string description, decimal price)
        {
            if (name==null) throw new ArgumentNullException();
            if (name == string.Empty) throw new ArgumentException("Name cannot be empty");
            if (description == null) throw new ArgumentNullException();
            if (description == string.Empty) throw new ArgumentException("Description cannot be empty");
            if (string.IsNullOrEmpty(description)) throw new ArgumentNullException();
            if (price <= 0) throw new ArgumentException("Price cannot be less or equal than 0");

            Name = name;
            Description = description;
            Price = price;
        }

        public void UpdateBrand(int catalogBrandId)
        {
            if (catalogBrandId == 0) throw new ArgumentException("Catalog brand Id cannot be 0");

            CatalogBrandId = catalogBrandId;
        }

        public void UpdateType(int catalogTypeId)
        {
            if (catalogTypeId == 0) throw new ArgumentException("Catalog type Id cannot be 0");

            CatalogTypeId = catalogTypeId;
        }

        public void UpdatePictureUri(string pictureName)
        {
            if (string.IsNullOrEmpty(pictureName))
            {
                PictureUri = string.Empty;
                return;
            }

            PictureUri = $@"images\products\{pictureName}?{new DateTime().Ticks}";
        }
    }
}
