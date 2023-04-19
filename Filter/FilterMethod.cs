using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_Bata.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Bata.Filter
{
    [TestClass]
    public class FilterMethod : ClassBase

    {
        FilterLoc obj = new FilterLoc();

        [TestMethod]
        
            public void FilterItem()
            {
             ClassBase.SetDriver("Chrome");
                obj.MoveToElement();
          
            base.dealingAlertDismiss();
            }
    }
} 