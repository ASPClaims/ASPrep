using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using oops.Utility;

namespace oops
{
    public partial class _Default : Page
    {
        Aperture objoops = new Aperture();
        oops.Aperture objClass1 = new oops.Aperture();
        ChildClass objchild = new ChildClass();
        absDerived objabs = new absDerived();
        derployClass objPoly = new derployClass();
        EnClass1 objEn = new EnClass1();
        protected void Page_Load(object sender, EventArgs e)
        {
            double x=objoops.get_volume();
            objClass1.get_volume();
            abcd.InnerText = objchild.msg1();
            P1.InnerHtml=objabs.AddNumbers(10,10).ToString();
            P2.InnerHtml = objPoly.addNames();
            P2.InnerHtml = objPoly.addNumb().ToString();
            P3.InnerHtml = objEn.EnMethod();
        }
    }
}