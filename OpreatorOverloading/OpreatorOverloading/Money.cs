using System;

namespace OpreatorOverloading
{
    //Opreator Overloading
    //// Mean That I Make User Defined Type(class) And Want To Make Opreators(+,-,/,*,++,--,>,<,==) on It
    class Money
    {
        private decimal _amount;
        public decimal Amount => this._amount;
        public Money(decimal value)
        {
            this._amount = Math.Round(value, 2);
        }
        public static Money operator +(Money money1, Money money2)
        {
            var value = money1.Amount + money2.Amount;
            return new Money(value);
        }
        public static Money operator -(Money money1,Money money2)
        {
            var value = money1.Amount - money2.Amount;
            return new Money(value);
        }
        public static Money operator *(Money money,Money money1)
        {
            var value = money.Amount * money1.Amount;
            return new Money(value);
        }
        public static Money operator /(Money money, Money money1)
        {
            var value = money.Amount / money1.Amount;
            return new Money(value);
        }
        public static bool operator >(Money money,Money money1)
        {
            return money.Amount > money1.Amount;
        }
        public static bool operator <(Money money, Money money1)
        {
            return money.Amount < money1.Amount;
        }
        public static bool operator ==(Money money, Money money1)
        {
            return money.Amount == money1.Amount;
        }
        public static bool operator !=(Money money, Money money1)
        {
            return money.Amount != money1.Amount;
        }
        public static Money operator ++(Money money)
        {
            var value = money._amount++;
            return new Money(value);
        }
        public static Money operator --(Money money)
        {
            var value = money._amount--;
            return new Money(value);
        }
        //Now I have user defined type(Money) and i can done opreator on it 
    }
}
