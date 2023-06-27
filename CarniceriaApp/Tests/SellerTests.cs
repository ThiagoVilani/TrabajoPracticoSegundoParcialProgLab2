using BibliotecaDeClases;

namespace Tests
{
    [TestClass]
    public class SellerTests
    {
        [TestMethod]
        public void CalculateSubTotal_CuandoRecibeDosProductosDeMilPesosCadaUno_DeberiaRetornar2000() 
        {
            //  Arrange
            Seller seller = new Seller("nombre", "mail", "contraseña", 1);
            List<Product> products = new List<Product>();
            products.Add(new Product("p1", 1000, 1, "detalle"));
            products.Add(new Product("p2", 1000, 1, "detalle"));
            double resultadoEsperado = 2000;

            //  Act
            double result = seller.CalculateSubTotal(products);
            
            //Assert
            Assert.AreEqual(resultadoEsperado, result);
        }


        [TestMethod]
        public void CalculateTotal_CuandoRecibeCreditoComoMetodoDePagoYDosProductosDeMilPesosCadaUno_DeberiaRetornarDosMilCien()
        {
            //  Arrange
            Seller seller = new Seller("nombre", "mail", "contraseña", 1);
            List<Product> products = new List<Product>();
            products.Add(new Product("p1", 1000, 1, "detalle"));
            products.Add(new Product("p2", 1000, 1, "detalle"));
            double resultadoEsperado = 2100;

            //  Act
            double result = seller.CalculateTotal("Credito",products);

            //Assert
            Assert.AreEqual(resultadoEsperado, result);
        }

        [TestMethod]
        public void CalculateTotal_CuandoRecibeDebitoComoMetodoDePagoYTresProductosDeMilPesosCadaUno_DeberiaRetornarTresmil()
        {
            //  Arrange
            Seller seller = new Seller("nombre", "mail", "contraseña", 1);
            List<Product> products = new List<Product>();
            products.Add(new Product("p1", 1000, 1, "detalle"));
            products.Add(new Product("p2", 1000, 1, "detalle"));
            products.Add(new Product("p3", 1000, 1, "detalle"));
            double resultadoEsperado = 3000;

            //  Act
            double result = seller.CalculateTotal("Debito", products);

            //Assert
            Assert.AreEqual(resultadoEsperado, result);
        }
    }
}