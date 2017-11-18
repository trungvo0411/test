using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTest
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://localhost:5927/KTPM/Staff/Staff_HomePage.aspx";
            // Nhap du lieu hop le
            driver.FindElement(By.Id("ContentPlaceHolder1_txtUser")).SendKeys("trung");
            driver.FindElement(By.Id("ContentPlaceHolder1_txtPass")).SendKeys("912");
            driver.FindElement(By.Id("ContentPlaceHolder1_btnSignIn")).Click();
            //Test chức năng gửi tiền
            driver.FindElement(By.Id("LinkButton3")).Click(); //Gui/Rut
            driver.FindElement(By.Id("ContentPlaceHolder2_txtSearch")).SendKeys("a1");
            driver.FindElement(By.Id("ContentPlaceHolder2_btnSearch")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder2_txtIncome")).SendKeys("10000");
            driver.FindElement(By.Id("ContentPlaceHolder2_btnNap")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder2_txtIncome")).Clear();
            //Kiểm tra số dư hiện tại
            driver.FindElement(By.Id("ContentPlaceHolder2_btnSearch")).Click();
            //Test chức năng rút tiền
            driver.FindElement(By.Id("LinkButton3")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder2_txtSearch")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder2_txtSearch")).SendKeys("a1");
            driver.FindElement(By.Id("ContentPlaceHolder2_btnSearch")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder2_txtIncome")).SendKeys("5000");
            driver.FindElement(By.Id("ContentPlaceHolder2_btnRut")).Click();
            //Kiểm tra số dư hiện tại
            driver.FindElement(By.Id("ContentPlaceHolder2_btnSearch")).Click();
            //Khi chạy sẽ phát sinh trường hợp page ko reload, dữ liệu trong ô nhập số tiền muốn gửi hoặc muốn rút không xóa trắng mà vẫn còn giá trị cũ, nên viết test phải bắt buộc gọi Clear             
        
           //Test chức năng mở tài khoản
            driver.FindElement(By.Id("LinkButton4")).Click();
            //Nhập các thông tin page yêu cầu
            driver.FindElement(By.Id("ContentPlaceHolder2_txtHo")).SendKeys("Hoàng");
            driver.FindElement(By.Id("ContentPlaceHolder2_txtTen")).SendKeys("Văn Thái");
            driver.FindElement(By.Id("ContentPlaceHolder2_txtNgSinh")).SendKeys("13/12/1991");
            driver.FindElement(By.Id("ContentPlaceHolder2_txtDT")).SendKeys("01212112112");
            driver.FindElement(By.Id("ContentPlaceHolder2_txtEmail")).SendKeys("HoangThai321@gmail.com");
            driver.FindElement(By.Id("ContentPlaceHolder2_txtDC")).SendKeys("1990 Xô Viết Nghệ Tĩnh");
            driver.FindElement(By.Id("ContentPlaceHolder2_txtUser")).SendKeys("thaideptrai123");
            driver.FindElement(By.Id("ContentPlaceHolder2_txtPass")).SendKeys("taolathai");
            driver.FindElement(By.Id("ContentPlaceHolder2_btnDK")).Click();
            //Kiểm tra thông tin khách hàng đã đăng ký
            driver.FindElement(By.Id("LinkButton1")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder2_txtSearch")).SendKeys("thaideptrai123");
            driver.FindElement(By.Id("ContentPlaceHolder2_btnSearch")).Click();
        }
    }
}
