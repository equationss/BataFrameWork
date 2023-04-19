using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_Bata.Login;
using Project_Bata.Filter;
using Project_Bata.SearchLoc;
using Project_Bata.AddToCart;
using Project_Bata.Cart;

namespace Project_Bata.executionClass
{
    [TestClass]
    public class executionClass
    {
        // TestContext TestContext { get; set; }

        [AssemblyInitialize]

        public static void AssemblyRun(TestContext TestContext)
        {
            LoginMethod log = new LoginMethod();
            ClassBase.SetDriver("Edge");
            log.LoginWithValidCredentials();

        }

        [AssemblyCleanup]

        public  static void AssemblyClean()
        {
            ClassBase.Close();
        }

        [TestMethod]

        public void Run()

        {
            FilterMethod filter = new FilterMethod();
            filter.FilterItem();

            SearchMethod search = new SearchMethod();
            search.KeyToBeSearch();

            CartMtd cart = new CartMtd();
            cart.filterSneakers();

            CartCalMtd cartCal = new CartCalMtd();
            cartCal.CheckAddTOCart();
        }
    }
}
