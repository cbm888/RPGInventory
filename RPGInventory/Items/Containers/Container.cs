using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGInventory.Items.Containers
{
   public abstract class Container : Item
    {
        // capacity - available to container, and it's children
        protected int _capacity;
        protected Item[] _items;
        protected int _currentIndex;

        public Container(int capacity)
        {
            _capacity = capacity;
            _items = new Item[capacity];
            _currentIndex = 0;
        }

        public bool AddItem(Item itemToAdd)
        {
            if (_capacity == _currentIndex)
            {
                return false;
            }
            else
            {
                _items[_currentIndex] = itemToAdd;
                _currentIndex++;
                return true;
            }
        }
    }
}
