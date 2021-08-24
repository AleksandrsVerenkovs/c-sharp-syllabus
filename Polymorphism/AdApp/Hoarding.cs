namespace AdApp
{
    public class Hoarding : Advert
    {
        private int rate;
        //per day
        private int numDays;
        private bool isPrime;
        public Hoarding(int fee) : base(fee)
        {
            numDays = 1;
            base.SetFee(fee);
        }

        public Hoarding(int fee, int days, bool primeSpot = false) : base(fee)
        {
            numDays = days;
            isPrime = primeSpot;
            rate = primeSpot ? 2 : 0;
            base.SetFee(fee);
        }

        public new int Cost()
        {
            var fee = base.Cost();
            if (isPrime)
            {
                return (fee + fee / rate) * numDays;
            }
            else
            {
            return fee * numDays;
            }
        }

        public override string ToString()
        {
            return "\nHoarding: Fee=" + Cost();
        }
    }
}