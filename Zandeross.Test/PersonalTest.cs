using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
    
namespace Zandeross.Test
{
    [TestClass]
    public class PersonalTest
    {
        Domain.PersonalDataService service = new Domain.PersonalDataService();

        [TestMethod]
        public void GetData()
        {
            var result = service.PersonalGetData();
            Debug.WriteLine(result);
        }
        [TestMethod]
        public void  Insert()
        {
            Domain.Personal p = new Domain.Personal();
            p.Name = "TEST";
            p.Lastname = "TEST ";
            int result = service.InsertCommand(p);
            Debug.WriteLine(result);
        }
        [TestMethod]
        public void InsertScalar()
        {
            Domain.Personal p = new Domain.Personal();
            p.Name = "Scalar ";
            p.Lastname = "Execute";
            int result = service.InsertCommandScalar(p);
            Debug.WriteLine(result);
        }
        [TestMethod]
        public void GetDataList()
        {
            var result = service.PersonalGetDataList();
            foreach (var item in result)
            {
                Debug.WriteLine(item.Name);

            }
        }
        [TestMethod]
        public void FastInsert()
        {
            Domain.Personal p = new Domain.Personal();
            p.Name = "";
            p.Lastname = "Teknoloji";
            int result = service.FastInsert(p);
            Debug.WriteLine(result);
        }

        [TestMethod]
        public void GetPersonalById()
        {
            Domain.Personal p = new Domain.Personal();
            p.Id = 2;
            var result = service.GetPersonalByIdTest(p);
            Debug.WriteLine(result.Name);

            
        }
    }
}
