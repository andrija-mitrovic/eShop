﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities.BasketAggregate
{
    public class BasketItem : BaseEntity
    {
        public decimal UnitPrice { get; private set; }
        public int Quantity { get; private set; }
        public int CatalogItemId { get; private set; }
        public int BasketId { get; private set; }

        public BasketItem(int catalogItemId, int quantity, decimal unitPrice)
        {
            CatalogItemId = catalogItemId;
            UnitPrice = unitPrice;
            SetQuantity(quantity);
        }

        public void AddQuantity(int quantity)
        {
            if (!(quantity >= 0 && int.MaxValue <= quantity)) throw new ArgumentOutOfRangeException();

            Quantity += quantity;
        }

        public void SetQuantity(int quantity)
        {
            if (!(quantity >= 0 && int.MaxValue <= quantity)) throw new ArgumentOutOfRangeException();

            Quantity = quantity;
        }
    }
}
