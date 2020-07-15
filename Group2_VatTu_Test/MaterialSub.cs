using Group2_VatTu_Test.BaseClass;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Group2_VatTu_Test
{
    public class MaterialSub : BaseTest
    {
        IWebElement ele;
        string str;
        IWebElement txtTenVatTu, txtSoLuong, txtDonGia, txtTongGia, txtMoTa, btnLuu, btnHuy, txtLyDo, txtTongGiaThanhLy, txtSoLuongThanhLy;

        void GetElement()
        {
            ele = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-material-management/app-material-management-group2/div/div[3]/div/div/div/p-table/div/div/table/tbody/tr[4]/td[1]/label/span"));
            ele.Click();
            ele = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-material-management/app-material-management-group2/div/div[1]/div[1]/div/ul/li[3]"));
            ele.Click();
            ele = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-material-sub/app-material-sub-group2/div/div[2]/div/form/div/div[2]/div[2]/label"));
            ele.Click(); //Thanh ly 1 phan
            Thread.Sleep(200);
            txtTenVatTu = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-material-sub/app-material-sub-group2/div/div[2]/div/form/div/div[1]/div[1]/input"));
            txtSoLuong = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-material-sub/app-material-sub-group2/div/div[2]/div/form/div/div[1]/div[3]/input"));
            txtDonGia = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-material-sub/app-material-sub-group2/div/div[2]/div/form/div/div[1]/div[2]/input"));
            txtTongGia = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-material-sub/app-material-sub-group2/div/div[2]/div/form/div/div[1]/div[4]/input"));
            txtMoTa = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-material-sub/app-material-sub-group2/div/div[2]/div/form/div/div[1]/textarea"));
            btnLuu = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-material-sub/app-material-sub-group2/div/div[2]/div/div/div[2]/div/form/div/div/ul/li[2]"));
            btnHuy = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-material-sub/app-material-sub-group2/div/div[2]/div/div/div[2]/div/form/div/div/ul/li[1]"));
            txtLyDo = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-material-sub/app-material-sub-group2/div/div[2]/div/form/div/div[2]/textarea"));
            txtTongGiaThanhLy = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-material-sub/app-material-sub-group2/div/div[2]/div/form/div/div[2]/div[3]/input"));
            txtSoLuongThanhLy = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-material-sub/app-material-sub-group2/div/div[2]/div/form/div/div[2]/div[4]/div/input"));
        }

        [Test, Category("RightInputMaterialSub"), Order(1)]
        public void txtTenVatTuCheck()
        {
            this.NagativeToManagement();
            this.GetElement();
            str = txtTenVatTu.GetAttribute("value");
            Assert.IsNotNull(str);
        }
        [Test, Category("RightInputMaterialSub"), Order(2)]
        public void txtSoLuongCheck()
        {
            str = txtSoLuong.GetAttribute("value");
            Assert.IsNotNull(str);
        }
        [Test, Category("RightInputMaterialSub"), Order(3)]
        public void txtDonGiaCheck()
        {
            str = txtDonGia.GetAttribute("value");
            Assert.IsNotNull(str);
        }
        [Test, Category("RightInputMaterialSub"), Order(4)]
        public void txtTongGiaCheck()
        {
            str = txtTongGia.GetAttribute("value");
            Assert.IsNotNull(str);
        }
        [Test, Category("RightInputMaterialSub"), Order(5)]
        public void txtMoTaCheck()
        {
            str = txtMoTa.GetAttribute("value");
            Assert.IsNotNull(str);
        }
        [Test, Category("RightInputMaterialSub"), Order(6)]
        public void txtLyDoCheck()
        {
            txtLyDo.SendKeys("Đây là lý do");
            str = txtLyDo.GetAttribute("value");
            Assert.AreEqual("Đây là lý do", str);
        }
        [Test, Category("RightInputMaterialSub"), Order(7)]
        public void txtTongGiaThanhLyCheck()
        {
            txtTongGiaThanhLy.SendKeys("35okjoo0000t0");
            str = txtTongGiaThanhLy.GetAttribute("value");
            Assert.AreEqual("3500000", str);
        }
        [Test, Category("RightInputMaterialSub"), Order(8)]
        public void txtSoLuongThanhLyCheck()
        {
            txtSoLuongThanhLy.SendKeys("1okt");
            str = txtSoLuongThanhLy.GetAttribute("value");
            Assert.AreEqual("1", str);
        }

        [Test, Category("RightInputMaterialSub"), Order(9)]
        public void modalXacNhanCheck()
        {
            btnLuu.Click();
            ele = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-material-sub/app-material-sub-group2/div/p-dialog/div/div[2]"));
            str = ele.Text;
            Assert.AreEqual("Xác nhận thanh lý vật tư?", str);
        }

        [Test, Category("RightInputMaterialSub"), Order(10)]
        public void cancelXacnhan()
        {
            ele = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-material-sub/app-material-sub-group2/div/p-dialog/div/div[3]/p-footer/button[2]"));
            ele.Click();
        }
        [Test, Category("RightInputMaterialSub"), Order(11)]
        public void confirmXacNhanCheck()
        {
            btnLuu.Click();
            ele = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-material-sub/app-material-sub-group2/div/p-dialog/div/div[3]/p-footer/button[1]"));
            ele.Click();
            ele = webDriver.FindElement(By.ClassName("toast-message"));
            str = ele.Text;
            Assert.AreEqual("Thanh lý thành công", str);
        }

    }
}
