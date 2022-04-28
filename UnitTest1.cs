using FinalProjectClasses;
using System;
using Xunit;

namespace FinalProjectUnitTests1
{
    public class UnitTest1
    {
        [Fact]
        public void testCustomersToString()
        {
            //ARRAGE
            int userId = 5555;
            string password = "Marco1235";
            string firstName = "THOMAS";
            string lastName = "PORTER";
            string email = "tporter@gmail.com";
            string phone = "5153341925";

            //ACT
            Customers customers = new Customers(userId, password, firstName, lastName, email, phone);

            //ASSERT
            string expected = "\n*Account Summary Information*\nUser ID: 5555\nUser Password: Marco1235\nFirst Name: THOMAS\nLast Name: PORTER\nEmail: tporter@gmail.com\nPhone Number: 5153341925\n";
            string actual = customers.ToString();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void testInventoryToString()
        {
            //ARRAGE
            int itemNum = 50052;
            string name = "Fender Player Stratocaster";
            double price = 849.99;
            int quantity = 9;
            string type = "Electric";
            string model = "Player Series";

            //ACT
            Inventory inventory = new Inventory(itemNum, name, price, quantity, type, model);

            //ASSERT
            string expected = "Item#: 50052\nName: Fender Player Stratocaster\nPrice: $849.99\nQuantity: 9\nType: Electric\nModel: Player Series";
            string actual = inventory.ToString();

            Assert.Equal(expected , actual);
        }

        [Fact]
        public void testPurchaseGuitar()
        {
            //ARRANGE
            Inventory item = new Inventory(50050, "Fender JV Modified '60s Custom Telecaster", 1349.99, 6, "Electric", "JV Modified Series");

            // ACT
            string expected = "Item#: 50050\nName: Fender JV Modified '60s Custom Telecaster\nPrice: $1349.99\nQuantity: 6\nType: Electric\nModel: JV Modified Series";
            string actual = item.ToString();

            // ASSERT
            Assert.Equal(expected, actual);
        }
    }
}