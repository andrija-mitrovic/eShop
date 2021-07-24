using System;

namespace ApplicationCore.Exceptions
{
    public class DuplicateCatalogItemNameException : Exception
    {
        public int DuplicateItemId { get; }

        public DuplicateCatalogItemNameException(string message, int duplicateItemId) : base(message)
        {
            DuplicateItemId = duplicateItemId;
        }
    }
}
