using Group2_VatTu_Test.BaseClass;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Group2_VatTu_Test
{
    public class MaterialEdit : BaseTest
    {
        IWebElement ele;
        string str;
        IWebElement txtTenVatTu, txtSoLuong, txtDonGia, txtTongGia, txtMoTa, btnLuu, btnHuy;

        void GetElement()
        {
            ele = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-material-management/app-material-management-group2/div/div[3]/div/div/div/p-table/div/div/table/tbody/tr[2]/td[1]/label/span"));
            ele.Click();
            ele = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-material-management/app-material-management-group2/div/div[1]/div[1]/div/ul/li[2]"));
            ele.Click();
            Thread.Sleep(200);
            txtTenVatTu = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-material-edit/app-material-edit-group2/div/div[2]/div/div[1]/form/div[1]/div[2]/div/input"));
            txtSoLuong = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-material-edit/app-material-edit-group2/div/div[2]/div/div[1]/form/div[2]/div[2]/div/input"));
            txtDonGia = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-material-edit/app-material-edit-group2/div/div[2]/div/div[1]/form/div[3]/div[2]/div/input"));
            txtTongGia = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-material-edit/app-material-edit-group2/div/div[2]/div/div[1]/form/div[3]/div[3]/div/input"));
            txtMoTa = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-material-edit/app-material-edit-group2/div/div[2]/div/div[1]/form/div[4]/div[2]/div/textarea"));
            btnLuu = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-material-edit/app-material-edit-group2/div/div[2]/div/div[1]/div/div[2]/div/form/div/div/ul/li[2]"));
            btnHuy = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-material-edit/app-material-edit-group2/div/div[2]/div/div[1]/div/div[2]/div/form/div/div/ul/li[1]"));
        }

        [Test, Category("RightInputMaterialEdit"), Order(1)]
        public void txtTenVatTuCheck()
        {
            this.NagativeToManagement();
            this.GetElement();
            str = txtTenVatTu.GetAttribute("value");
            Assert.IsNotNull(str);
        }
        [Test, Category("RightInputMaterialEdit"), Order(2)]
        public void txtSoLuongCheck()
        {
            str = txtSoLuong.GetAttribute("value");
            Assert.IsNotNull(str);
        }
        [Test, Category("RightInputMaterialEdit"), Order(3)]
        public void txtDonGiaCheck()
        {
            str = txtDonGia.GetAttribute("value");
            Assert.IsNotNull(str);
        }
        [Test, Category("RightInputMaterialEdit"), Order(4)]
        public void txtTongGiaCheck()
        {
            str = txtTongGia.GetAttribute("value");
            Assert.IsNotNull(str);
        }
        [Test, Category("RightInputMaterialEdit"), Order(5)]
        public void txtMoTaCheck()
        {
            str = txtMoTa.GetAttribute("value");
            Assert.IsNotNull(str);
        }

        [Test, Category("RightInputMaterialEdit"), Order(6)]
        public void modalXacNhanCheck()
        {
            btnLuu.Click();
            ele = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-material-edit/app-material-edit-group2/div/p-dialog/div/div[2]"));
            str = ele.Text;
            Assert.AreEqual("Xác nhận chỉnh sửa vật tư?", str);
        }

        [Test, Category("RightInputMaterialEdit"), Order(7)]
        public void cancelXacnhan()
        {
            ele = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-material-edit/app-material-edit-group2/div/p-dialog/div/div[3]/p-footer/button[2]"));
            ele.Click();
        }
        [Test, Category("RightInputMaterialEdit"), Order(8)]
        public void confirmXacNhanCheck()
        {
            btnLuu.Click();
            ele = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-material-edit/app-material-edit-group2/div/p-dialog/div/div[3]/p-footer/button[1]"));
            ele.Click();
            ele = webDriver.FindElement(By.ClassName("toast-message"));
            str = ele.Text;
            Assert.AreEqual("Chỉnh sửa vật tư thành công", str);
        }

    }
}
