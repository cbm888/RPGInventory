using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RPGInventory.Items.Containers;
using RPGInventory.Items.Potions;

namespace RPGInventory.Tests
{

    [TestFixture]
    public class ContainerTests
    {
        [Test]

        public void CanAddItemToBackpack()
        {
            Backpack b = new Backpack();
            HealthPotion p = new HealthPotion();

            bool actual = b.AddItem(p);
            Assert.AreEqual(true, actual);
        }
    }
}
