using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Traveler
{
    public partial class Expenses : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, System.EventArgs e)
        {
            double a, b, c;
            a = int.Parse(TextBox1.text);
            b = int.Parse(TextBox2.text);
            c = int.Parse(TextBox3.text);
            TextBox4.text = (a + b + c).ToString;
        }

         protected void go(object sender, System.EventArgs e)
         {  a = int.Parse(TextBox1.text);
            b = int.Parse(TextBox2.text);
            c = int.Parse(TextBox3.text);
          Console.WriteLine("Expenses for travelling are :"+a);
          Console.WriteLine("Expenses for hotel stay are :"+b);
          Console.WriteLine("Expenses for food are :"+c);




    }
}