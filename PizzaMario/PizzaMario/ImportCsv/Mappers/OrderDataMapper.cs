using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PizzaMario.ImportCsv.Models;
using PizzaMario.Models;

namespace PizzaMario.ImportCsv.Mappers
{
    public interface IOrderDataMapper
    {
        OrderData Map(CsvOrderData orderData);
    }

    public class OrderDataMapper : IOrderDataMapper
    {
        public OrderData Map(CsvOrderData orderData)
        {
            return new OrderData
            {
                Address = orderData.Adres,
                Amount = orderData.Aantal,
                City = orderData.Woonplaats,
                CouponDiscount = orderData.CouponKorting,
                Crust = orderData.PizzaBodem,
                CustomerName = orderData.Klantnaam,
                DeliveryCost = orderData.Bezorgkosten,
                DeliveryDate = orderData.AfleverDatum,
                DeliveryMoment = orderData.AfleverMoment,
                DeliveryType = orderData.AfleverType,
                Email = orderData.Email,
                ExtraIngredient = orderData.ExtraIngrediënten,
                ExtraIngredientPrice = orderData.PrijsExtraIngrediënten,
                OrderDate = orderData.Besteldatum,
                OrderLinePrice = orderData.Regelprijs,
                Price = orderData.Prijs,
                Product = orderData.Product,
                Saus = orderData.PizzaSaus,
                StoreName = orderData.Winkelnaam,
                TelephoneNumber = orderData.TelefoonNr,
                TotalOrderLinePrice = orderData.Totaalprijs,
                TotalPrice = orderData.TeBetalen,
                UserCoupon = orderData.GebruikteCoupon
            };
        }
    }
}