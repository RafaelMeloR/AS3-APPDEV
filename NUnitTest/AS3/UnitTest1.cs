using FarmersMarketAPI;
using FarmersMarketAPI.DataAccessLayer;
using FarmersMarketAPI.Models;
using System.Net.Http.Json;

namespace AS3
{
    public class Tests
    {

        static HttpClient httpClient = utilities.API.conn();

        [Test]
        public async Task TestADODataInsertion()
        {
            Products products = new Products();
            products.Name = "Test Product";
            products.Amount = 10.5M;
            products.Price = 9.99M;
            bool insert = await dal.set.InsertProduct(products.Name, products.Amount, products.Price);
            Assert.IsTrue(insert);
            Products result = dal.get.selectProductByName(products.Name);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Name, Is.EqualTo(products.Name));
            Assert.That(result.Price, Is.EqualTo(products.Price));
            Assert.That(result.Amount, Is.EqualTo(products.Amount));
        }


        [Test]
        public async Task TestRESTDataInsertion()
        {

            Products product = new Products();
            product.Name = "Test Product API";
            product.Amount = 17.00M;
            product.Price = 19.00M;

            var response = await httpClient.PostAsJsonAsync<Products>("InsertProduct", product);
            Assert.IsTrue(response.IsSuccessStatusCode);

            Products result = dal.get.selectProductByName(product.Name);
            Assert.That(product.Name, Is.EqualTo(result.Name));
            Assert.That(product.Price, Is.EqualTo(result.Price));
            Assert.That(product.Amount, Is.EqualTo(result.Amount));


        }

        [Test]
        public async Task TestADODataUpdate()
        {
            Products products = new Products();
            products.Id = 63;
            products.Name = "Test Product UPDATED";
            products.Amount = 10.5M;
            products.Price = 9.99M;
            bool insert = await dal.set.UpdateProduct(products.Id, products.Name, products.Amount, products.Price);
            Assert.IsTrue(insert);
            Products result = dal.get.selectProductById(products.Id);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Id, Is.EqualTo(products.Id));
            Assert.That(result.Name, Is.EqualTo(products.Name));
            Assert.That(result.Price, Is.EqualTo(products.Price));
            Assert.That(result.Amount, Is.EqualTo(products.Amount));
        }


        [Test]
        public async Task TestRESTDataUpdate()
        {

            Products product = new Products();
            product.Id = 62;
            product.Name = "Test Product API UPDATED";
            product.Amount = 17.00M;
            product.Price = 19.00M;

            var response = await httpClient.PutAsJsonAsync<Products>("UpdateProduct", product);
            Assert.IsTrue(response.IsSuccessStatusCode);

            Products result = dal.get.selectProductById(product.Id);
            Assert.That(result.Id, Is.EqualTo(product.Id));
            Assert.That(product.Name, Is.EqualTo(result.Name));
            Assert.That(product.Price, Is.EqualTo(result.Price));
            Assert.That(product.Amount, Is.EqualTo(result.Amount));

        }

        [Test]
        public async Task TestADODataDelete()
        {
            Products products = new Products();
            products.Id = 58;
            bool insert = await dal.set.DeleteProduct(products.Id);
            Assert.IsTrue(insert);

        }


        [Test]
        public async Task TestRESTDataDelete()
        {

            Products product = new Products();
            product.Id = 59;

            var response = await httpClient.DeleteAsync("DeleteProduct/" + product.Id);
            Assert.IsTrue(response.IsSuccessStatusCode);

        }

    }


}