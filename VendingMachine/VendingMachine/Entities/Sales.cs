using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Entities.Enums;

namespace VendingMachine.Entities
{
    class Sales
    {
        public double TotalEarn { get; set; }
        public int TotalSold { get; set; }


        public Sales()
        {
            TotalEarn = 0;
            TotalSold = 0;
        }

        public double Sell(double Price, double Money)
        {
            TotalEarn += Price;
            TotalSold += 1;
            return Money - Price;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if(TotalSold == 0)
            {
                sb.Append("Não foi vendido nenhuma bebida");
            }else if(TotalSold == 1)
            {
                sb.Append("A quantidade de bebida vendida foi de ");
                sb.Append(TotalSold);
                sb.Append(" bebida. E o total de dinheiro ganho foi de R$ ");
                sb.Append(TotalEarn.ToString("F"));
            }
            else
            {
                sb.Append("A quantidade de bebidas vendidas foi de ");
                sb.Append(TotalSold);
                sb.Append(" bebidas. E o total de dinheiro ganho foi de R$ ");
                sb.Append(TotalEarn.ToString("F"));
            }
            return sb.ToString();
        }
    }
}
