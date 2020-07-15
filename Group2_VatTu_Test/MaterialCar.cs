using Group2_VatTu_Test.BaseClass;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Group2_VatTu_Test
{
    public class MaterialCar : BaseTest
    {
        IWebElement ele;
        string str;
        IWebElement txtTenVatTu, txtMaVatTu, txtBienSo1, txtBienSo2;

        void GetElement()
        {
            ele = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-material-management/app-material-management-group2/div/div[1]/div[1]/div/ul/li[5]"));
            ele.Click();
            Thread.Sleep(200);
            txtTenVatTu = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-material-car/app-material-car-group2/div/div[2]/div/form/div/div[1]/div/p-autocomplete/span/input"));
            txtBienSo1 = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-material-car/app-material-car-group2/div/div[2]/div/div[1]/form/div/div[3]/div/input"));
            txtBienSo2 = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-material-car/app-material-car-group2/div/div[2]/div/div[3]/form/div/div[3]/div/input"));
        }

        [Test, Category("MaterialCar"), Order(1)]
        public void TimKiemVatTuCheck()
        {
            this.NagativeToManagement();
            this.GetElement();
            ele = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-material-car/app-material-car-group2/div/div[2]/div/form/div/div[2]/div/p-autocomplete/span/button"));
            ele.Click();
            ele = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-material-car/app-material-car-group2/div/div[2]/div/form/div/div[2]/div/p-autocomplete/span/div/ul/li[3]"));
            ele.Click();
            Thread.Sleep(500);
        }
        [Test, Category("MaterialCar"), Order(2)]
        public void TimKiemXe1Check()
        {
            txtBienSo1.SendKeys("8");
            txtBienSo1.SendKeys(Keys.Enter);
        }
        [Test, Category("MaterialCar"), Order(3)]
        public void ThemXeSuDungCheck()
        {
            ele = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-material-car/app-material-car-group2/div/div[2]/div/div[1]/div/div/div/p-table/div/div/table/tbody/tr[1]/td[6]/a"));
            ele.Click();
            ele = webDriver.FindElement(By.ClassName("toast-message"));
            str = ele.Text;
            Assert.AreEqual("Thêm thành công", str);
            Thread.Sleep(7000);
        }

        [Test, Category("MaterialCar"), Order(4)]
        public void TimKiemXe2Check()
        {
            txtBienSo2.SendKeys("8");
            txtBienSo2.SendKeys(Keys.Enter);
        }
        [Test, Category("MaterialCar"), Order(5)]
        public void XoaXeSuDungCheck()
        {
            ele = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-material-car/app-material-car-group2/div/div[2]/div/div[3]/div/div/div/p-table/div/div/table/tbody/tr[1]/td[6]/span"));
            ele.Click();
            ele = webDriver.FindElement(By.ClassName("toast-message"));
            str = ele.Text;
            Assert.AreEqual("Xoá thành công", str);
        }

    }
}
