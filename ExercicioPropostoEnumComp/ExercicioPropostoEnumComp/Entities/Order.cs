using System;
using System.Collections.Generic;
using System.Text;
using ExercicioPropostoEnumComp.Entities.Enums;
using System.Globalization;

namespace ExercicioPropostoEnumComp.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();


        public Order()
        {

        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItems(OrderItem items)
        {
            Items.Add(items);
        }

        public void RemoveItems(OrderItem items)
        {
            Items.Remove(items);
        }

        public double Total()
        {
            double sum = 0.0;
            foreach (OrderItem items in Items)
                sum += items.SubTotal();

            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("ORDER SUMMARY: ");
            sb.AppendLine($"Order moment: {Moment.ToString("dd/MM/yyyy hh:MM:ss")}");
            sb.AppendLine($"Order status: {Status}");
            sb.AppendLine($"Client: {Client}");
            sb.AppendLine("Order items: ");
            foreach (OrderItem items in Items)
                sb.AppendLine($"{items}");

            sb.AppendLine($"Total price: {Total().ToString("F2", CultureInfo.InvariantCulture)}");
            return sb.ToString();
        }
    }
}
