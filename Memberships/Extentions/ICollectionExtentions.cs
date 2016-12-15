using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Memberships.Extentions
{
    public static class ICollectionExtentions
    {
        public static IEnumerable<SelectListItem> ToSelectListItem<T>(this ICollection<T> items, int selectedValue)
        {
            return from item in items
                select new SelectListItem
                {
                    Text = item.getPropertyValue("Title"),
                    Value = item.getPropertyValue("Id"),
                    Selected = item.getPropertyValue("Id").Equals(selectedValue.ToString())
                };
        }

    }
}