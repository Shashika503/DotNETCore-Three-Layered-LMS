using LibraryData.Models;
using System;
using System.Collections.Generic;


namespace LibraryData
{
    public interface ICheckout
    {
        IEnumerable<CheckoutHistory> GetCheckoutHistory(int id);
        IEnumerable<Hold> GetCurrentHolds(int id);
        IEnumerable<Checkout> GetAll();
        Checkout GetById(int checkoutId);
        Checkout GetLatestCheckout(int assetId);

        string GetCurrentCheckoutPatron(int id);
        string GetCurrentHoldPatronName(int id);
        DateTime GetCurrentHoldPlaced(int id);

        bool IsCheckedOut(int id);  

        void Add(Checkout newCheckout);
        void CheckoutItem(int assetId, int libraryCardId);
        void CheckInItem(int assetId, int libraryCardId);
        void PlaceHold(int assetId, int libraryCardId);
        void MarkLost(int assetId);
        void MarkFound(int assetId);







    }
}
