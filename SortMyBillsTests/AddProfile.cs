using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using SortMyBills;

namespace SortMyBillsTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddProfile()
        {
            Person person = new Person();
            person.getName();
            person.getAge();
            person.getIncome();

            bool result = person.addProfile();
            bool expected = true;
            Assert.AreEqual(expected, result);
        }

        public void AddBills()
        {
            Bill bill1 = new Bill();
            bill1.getBillType();
            bill1.getBillAmount();
            bill1.getBillDue();

            bool result = bill1.addBills();
            bool expected = true;
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void getBalance()
        {
            Bill bill = new Bill();
            bill.getBillType();
            bill.getBillAmount();
            String userName = "Joe Bloggs";
            double amt = 500.00;
            List<Bill> billList = bill.getBalance(userName,amt);

            double result = bill.TotalBills(amt);
            Assert.IsNull(result);
            

        }

    }
}
