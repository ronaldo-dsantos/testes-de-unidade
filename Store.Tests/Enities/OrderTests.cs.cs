using Store.Domain.Entities;
using Store.Domain.Enums;

namespace Store.Tests.Enities
{
    [TestClass]
    public class OrderTests
    {
        private readonly Customer _customer = new Customer("Ronaldo Domingues", "ronaldo@email.com");
        private readonly Product _product = new Product("Produto 01", 10, true);
        private readonly Discount _discount = new Discount(10, DateTime.Now.AddDays(5));

        [TestMethod]
        [TestCategory("Domain")]
        public void Dado_um_novo_pedido_valido_ele_deve_gerar_um_numero_com_8_caracreteres()
        {
            var order = new Order(_customer, 0, null);

            Assert.AreEqual(8, order.Number.Length);
        }

        [TestMethod]
        [TestCategory("Domain")]
        public void Dado_um_novo_pedido_valido_ele_deve_ter_o_status_aguardando_pagamento()
        {
            var order = new Order(_customer, 0, null);

            Assert.AreEqual(EOrderStatus.WaitingPayment, order.Status);
        }

        [TestMethod]
        [TestCategory("Domain")]
        public void Dado_um_pagamento_do_pedido_seu_status_deve_mudar_para_aguardando_entrega()
        {
            var order = new Order(_customer, 0, null);
            order.AddItem(_product, 1);
            order.Pay(10);
            Assert.AreEqual(EOrderStatus.WaitingDelivery, order.Status);
        }
    }
}
