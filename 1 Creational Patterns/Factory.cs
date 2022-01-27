using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns
{
    #region 
    public interface CreditCard
    {
        string GetCardType();
        int GetCreditLimit();
        int GetAnnualCharge();
    }
    #endregion

    #region 
    public class Platinum : CreditCard
    {
        public string GetCardType() => "Platinum Plus";
        public int GetCreditLimit() => 35000;
        public int GetAnnualCharge() => 2000;

    }
    public class Titanium : CreditCard
    {
        public string GetCardType() => "Titanium Edge";
        public int GetCreditLimit() => 25000;
        public int GetAnnualCharge() => 1500;

    }
    public class MoneyBack : CreditCard
    {
        public string GetCardType() => "MoneyBack";
        public int GetCreditLimit() => 15000;
        public int GetAnnualCharge() => 500;

    }

    #endregion

    #region Factory Interface
    public abstract class CreditCardFactory
    {
        protected abstract CreditCard MakeProduct();
        public CreditCard CreateProduct() => this.MakeProduct();

    }
    #endregion

    #region CreditCard Factory
    public class MoneyBackFactory : CreditCardFactory
    {
        protected override CreditCard MakeProduct() => new MoneyBack();
    }
    public class PlatinumFactory : CreditCardFactory
    {
        protected override CreditCard MakeProduct() => new Platinum();
    }
    public class TitaniumFactory : CreditCardFactory
    {
        protected override CreditCard MakeProduct() => new Titanium();
    }
    #endregion
}