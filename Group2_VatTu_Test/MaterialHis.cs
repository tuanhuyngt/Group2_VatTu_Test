using Group2_VatTu_Test.BaseClass;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;

namespace Group2_VatTu_Test
{
    public class MaterialHis : BaseTest
    {
        IWebElement ele;
        string str;
        [Test, Category("MaterialHistory"), Order(1)]
        public void txtTimKiemMaCheck()
        {
            this.NagativeToManagement();
            ele = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-material-management/app-material-management-group2/div/div[1]/div[1]/div/ul/li[4]"));
            ele.Click(); // Go to Lich su thanh ly 

            ele = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-material-del/app-material-delete-group2/div/div[2]/div/div/div[1]/div/p-multiselect"));
            ele.Click();
            Thread.Sleep(300);
            ele = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-material-del/app-material-delete-group2/div/div[2]/div/div/div[1]/div/p-multiselect/div/div[4]/div[2]/ul/li[1]"));
            ele.Click();
            ele = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-material-del/app-material-delete-group2/div/div[2]/div/div/div[1]/form/div/input"));
            ele.SendKeys("1");
            ele.SendKeys(Keys.Enter);
            Thread.Sleep(2000);
        }

        [Test, Category("MaterialHistory"), Order(2)]
        public void txtTimKiemTenCheck()
        {
            ele = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-material-del/app-material-delete-group2/div/div[2]/div/div/div[1]/div/p-multiselect"));
            ele.Click();
            Thread.Sleep(300);
            ele = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-material-del/app-material-delete-group2/div/div[2]/div/div/div[1]/div/p-multiselect/div/div[4]/div[2]/ul/li[1]"));
            ele.Click();
            ele = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-material-del/app-material-delete-group2/div/div[2]/div/div/div[1]/div/p-multiselect/div/div[4]/div[2]/ul/li[2]"));
            ele.Click();
            ele = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-material-del/app-material-delete-group2/div/div[2]/div/div/div[1]/form/div/input"));
            ele.SendKeys("t");
            ele.SendKeys(Keys.Enter);
            Thread.Sleep(2000);
        }

    }
}