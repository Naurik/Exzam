using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Exzam
{
    [Serializable]
    public delegate void KeyPressEvent(object sender);
    public class Item
    {
        public event KeyPressEvent keyPress;

        public int CntItems { get; set; }
        public string NameItems { get; set; }
        public int PriceItems { get; set; }
       


        public void AddItems(int cntItem, int priceItem, string nameItem)
        {
            CntItems = cntItem;
            NameItems = nameItem;
            PriceItems = priceItem;
            keyPress?.Invoke("Добавлены данные о товаре");
        }
        
    }
}
