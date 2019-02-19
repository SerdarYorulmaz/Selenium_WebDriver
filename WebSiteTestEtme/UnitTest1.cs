using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebSiteTestEtme
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver driver = new ChromeDriver();
        
        [TestMethod]
        public void bireyIlanAra()
        {
            string mail = "minnos123@hotmail.com";//(ilk once kullaniciGuncelleme calistirilirse )Test ederken Degistirilmeli
            string sifre = "123456";//(ilk once kullaniciGuncelleme calistirilirse )Test ederken Degistirilmeli


            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com/");//google gidecek
            driver.FindElement(By.Name("q")).SendKeys("unclesoftware");
            driver.FindElement(By.Name("q")).Submit(); //aratiyoruz (istedigimiz linkler geliyor)
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id='rso']/div[1]/div/div/div/div/div[1]/a/h3")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/ul/li[2]/a")).Click();
            Thread.Sleep(3000);

            driver.FindElement(By.Name("emailorname")).SendKeys(mail);
            driver.FindElement(By.Name("password")).SendKeys(sifre);
            driver.FindElement(By.XPath("//*[@id='loginForm']/div[3]/a")).Click();
            Thread.Sleep(3000);

            driver.FindElement(By.CssSelector("a#search-job-btn")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("/ html / body / nav / div / div[3] / form / div[1] / div / div / button")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("/ html / body / nav / div / div[3] / form / div[1] / div / div / div / ul / li[5]")).Click();
            Thread.Sleep(3000);



            driver.FindElement(By.XPath("/ html / body / nav / div / div[3] / form / div[2] / div / div / button")).Click();
            Thread.Sleep(3000);


            driver.FindElement(By.XPath("/ html / body / nav / div / div[3] / form / div[2] / div / div / div / ul / li[34]")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Id("search-job-form-btn")).Click();
            Thread.Sleep(3000);


        }
        [TestMethod]
        public  void FirmakayitOl()
        {
            string adSoyad = "freelancerAbc"; //Test ederken Degistirilmeli
            string mail = "serdar6543210101234@hotmail.com";//Test ederken Degistirilmeli
            string sifre = "654321010124";//Test ederken Degistirilmeli
            string Kullanicitel = "(222) 651 8901";
            string kullanici = "freetime12301234"; //Test ederken Degistirilmeli
            string firma = "vesteldfgfdşgkdflgkşdlfgabc"; //Test ederken Degistirilmeli
            string Firmatel = "(221) 651 8901";
            string tarih = "2018 - 12 - 12";
            string adres = "www.google.com";
            string aciklama = "ssdsdsdffdflşgkfdlşgkldfşgkfdlşgkdflkgşl";

            driver.Navigate().GoToUrl("https://www.google.com/");//google gidecek
            driver.FindElement(By.Name("q")).SendKeys("unclesoftware");
            driver.FindElement(By.Name("q")).Submit(); //aratiyoruz (istedigimiz linkler geliyor)
            driver.FindElement(By.XPath("//*[@id='rso']/div[1]/div/div/div/div/div[1]/a/h3")).Click();
            Thread.Sleep(3000);

            driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/ul/li[1]/a")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Id("i1")).SendKeys(adSoyad);
            driver.FindElement(By.Id("i2")).SendKeys(mail);
            driver.FindElement(By.Id("i3")).SendKeys(sifre);
            driver.FindElement(By.XPath("//*[@id='signupForm']/div[2]/div[4]/label[2]")).Click();

              driver.FindElement(By.XPath("//*[@id='signupForm']/div[3]/a")).Click();
              Thread.Sleep(3000);
            driver.FindElement(By.Id("nick")).SendKeys(kullanici);
            
            driver.FindElement(By.Id("phoneUser")).SendKeys(Kullanicitel);
            
            driver.FindElement(By.Id("companyName")).SendKeys(firma);
           
            driver.FindElement(By.Id("phoneCompany")).SendKeys(Firmatel);
            driver.FindElement(By.Id("companyDate")).SendKeys(tarih);
            driver.FindElement(By.Id("companyMail")).SendKeys(mail);
            driver.FindElement(By.Id("companyWeb")).SendKeys(adres);
            driver.FindElement(By.Name("companyAbout")).SendKeys(aciklama);
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id='welcomeCForm']/div[2]/a")).Click();

           








            Thread.Sleep(3000);


            

        }



        [TestMethod]
        public void KullaniciGuncelle()
        {
            string mail = "minnos123@hotmail.com";// ilk calistirildiginda birey ilanla ayni olmali
            string sifre = "123456";// ilk calistirildiginda birey ilanla ayni olmali
            string yeniSifre = "6543211";


            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com/");//google gidecek
            driver.FindElement(By.Name("q")).SendKeys("unclesoftware");
            driver.FindElement(By.Name("q")).Submit(); //aratiyoruz (istedigimiz linkler geliyor)
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id='rso']/div[1]/div/div/div/div/div[1]/a/h3")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/ul/li[2]/a")).Click();
            Thread.Sleep(3000);

            driver.FindElement(By.Name("emailorname")).SendKeys(mail);
            driver.FindElement(By.Name("password")).SendKeys(sifre);
            driver.FindElement(By.XPath("//*[@id='loginForm']/div[3]/a")).Click();
            Thread.Sleep(3000);
           
           driver.Navigate().GoToUrl("http://www.unclesoftware.com/setting/account");
            
            
            driver.FindElement(By.XPath("/ html / body / div / div / div[1] / div[2] / ul / li[3] / a")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Name("password_current")).SendKeys(sifre);
           
            driver.FindElement(By.Name("password_new")).SendKeys(yeniSifre);//sonuna 7 ekledik


            driver.FindElement(By.Name("password_new_confirm")).SendKeys(yeniSifre);
            Thread.Sleep(3000);
            driver.FindElement(By.Name("password_form")).Click();
            Thread.Sleep(3000);



           


        }
    }
}
