using System;
using System.Linq;
using System.Threading.Tasks;
using Vendor.Contract;

namespace Vendor.Console
{
    public class Program
    {
        public void Main(string[] args)
        {
            VendorContext context = new VendorContext();

            //for (int i = 3; i < 20; i++)
            //{
            //    Vendor.Contract.Vendor vendor = new Contract.Vendor()
            //    {
            //        ID = i.ToString(),
            //        Name = string.Format("TestAccount{0}", i),
            //        Description = "FirstDocDBAccount",
            //        Website = "wwww.TestAccount.Docdb",
            //        LastModifiedDate = System.DateTime.UtcNow,
            //        IsPreffered = false,
            //        BlockVendor = false,
            //        Email = "testaccount@docdb.test",
            //        KeyWords = "test unittest",
            //        Addresses = new VendorAddress[]
            //    {
            //        new VendorAddress()
            //        {
            //            Address1 = "Address1",
            //            Address2 = "Address2",
            //            City = "Bellevue",
            //            Country = "USA",
            //            Id = 2,
            //            LastModifiedDate = DateTime.UtcNow,
            //            PhoneNumber = "444-444-5858",
            //            State = "WA",
            //            ZipCode = "98000"
            //        }
            //    }
            //    };

            //    //context.SaveAsync<Contract.Vendor>(vendor).Wait();
            //}

            Vendor.Contract.Vendor vendor = new Contract.Vendor()
            {
                ID = "21",
                Name = "fivedevs",//string.Format("TestAccount{0}", i),
                FullName = "Five devs and dash",
                Description = "FirstDocDBAccount",
                Website = "wwww.TestAccount.Docdb",
                LastModifiedDate = System.DateTime.UtcNow,
                IsPreffered = false,
                BlockVendor = false,
                Email = "testaccount@docdb.test",
                KeyWords = "test unittest",
                Addresses = new VendorAddress[]
{
                    new VendorAddress()
                    {
                        Address1 = "Address1",
                        Address2 = "Address2",
                        City = "Bellevue",
                        Country = "USA",
                        Id = 2,
                        LastModifiedDate = DateTime.UtcNow,
                        PhoneNumber = "444-444-5858",
                        State = "WA",
                        ZipCode = "98000"
                    }
}
            };


            context.SaveAsync<Contract.Vendor>(vendor).Wait();
            //var item = context.GetAsync("1");
            var item = context.GetAsync();
            //context.UpdateAsync(vendor).Wait();
            var result = context.GetByNameAsync("Test");

        }
    }
}
