using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Property
    {
        //ID
        //tipo imovel
        //venda ou aluguel
        //valor venda
        //valor aluguel
        //endereço

        public int Id { get; set; }
        public string? PropertyType { get; set; }
        public string? SellOrRent { get; set; }
        public double SellValue { get; set; }
        public double RentValue { get; set; }
        public string? Address { get; set; }

        public Property(
            int id, 
            string? propertyType, 
            string? sellOrRent, 
            double sellValue, 
            double rentValue, 
            string? address
        )
        {
            Id = id;
            PropertyType = propertyType;
            SellOrRent = sellOrRent;
            SellValue = sellValue;
            RentValue = rentValue;
            Address = address;
        }

        public bool Validate()
        {
            if (string.IsNullOrWhiteSpace(PropertyType)) return false;
            if (string.IsNullOrWhiteSpace(SellOrRent)) return false;

        }
    }
}
