using Group2_VatTu_Test.BaseClass;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;

namespace Group2_VatTu_Test
{
    public class MaterialManagement : BaseTest
    {
        IWebElement ele;
        string str;
        [Test, Category("DirectButtonManagement"), Order(6)]
        public void txtTimKiemCheck()
        {          
            ele = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-material-management/app-material-management-group2/div/div[2]/div/p-multiselect"));
            ele.Click();
            Thread.Sleep(300);
            ele = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-material-management/app-material-management-group2/div/div[2]/div/p-multiselect/div/div[4]/div[2]/ul/li[2]"));
            ele.Click();
            ele = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-material-management/app-material-management-group2/div/div[2]/form/div/input"));
            ele.SendKeys("Loa");
            ele.SendKeys(Keys.Enter);
            Thread.Sleep(2000);
        }


        [Test, Category("DirectButtonManagement"), Order(1)]
        public void btnThemMoiCheck()
        {
            this.NagativeToManagement();
            ele = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-material-management/app-material-management-group2/div/div[1]/div[1]/div/ul/li[1]"));
            ele.Click();
            ele = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-material-add/app-material-add-group2/div/div[1]/div[2]/div/div/span[1]"));
            str = ele.Text;
            Assert.AreEqual("Thêm vật tư", str);
            webDriver.Navigate().Back();
            Thread.Sleep(300);
        }
        [Test, Category("DirectButtonManagement"), Order(2)]
        public void btnChinhSua()
        {
            ele = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-material-management/app-material-management-group2/div/div[3]/div/div/div/p-table/div/div/table/tbody/tr[2]/td[1]/label/span"));
            ele.Click();
            ele = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-material-management/app-material-management-group2/div/div[1]/div[1]/div/ul/li[2]"));
            ele.Click();
            ele = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-material-edit/app-material-edit-group2/div/div[1]/div[2]/div/div/span[1]"));
            str = ele.Text;
            Assert.AreEqual("Chỉnh sửa vật tư", str);
            webDriver.Navigate().Back();
            Thread.Sleep(300);
        }
        [Test, Category("DirectButtonManagement"), Order(3)]
        public void btnThanhLy()
        {
            ele = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-material-management/app-material-management-group2/div/div[3]/div/div/div/p-table/div/div/table/tbody/tr[4]/td[1]/label/span"));
            ele.Click();
            ele = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-material-management/app-material-management-group2/div/div[1]/div[1]/div/ul/li[3]"));
            ele.Click();
            ele = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-material-sub/app-material-sub-group2/div/div[1]/div[2]/div/div/span[1]"));
            str = ele.Text;
            Assert.AreEqual("Thanh lý", str);
            webDriver.Navigate().Back();
            Thread.Sleep(300);
        }
        [Test, Category("DirectButtonManagement"), Order(4)]
        public void btnLichSuThanhLy()
        {
            ele = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-material-management/app-material-management-group2/div/div[1]/div[1]/div/ul/li[4]"));
            ele.Click();
            ele = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-material-del/app-material-delete-group2/div/div[1]/div[2]/div/div/span[1]"));
            str = ele.Text;
            Assert.AreEqual("Lịch sử thanh lý", str);
            webDriver.Navigate().Back();
            Thread.Sleep(300);
        }
        [Test, Category("DirectButtonManagement"), Order(5)]
        public void btnVatTuTheoXe()
        {
            ele = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-material-management/app-material-management-group2/div/div[1]/div[1]/div/ul/li[5]"));
            ele.Click();
            ele = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-material-car/app-material-car-group2/div/div[1]/div[2]/div/div/span[1]"));
            str = ele.Text;
            Assert.AreEqual("Vật tư theo xe", str);
            webDriver.Navigate().Back();
            Thread.Sleep(300);
        }
    }
}