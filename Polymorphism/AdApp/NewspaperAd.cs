namespace AdApp
{
    public class NewspaperAd : Advert
    {
        private int _column;
        private int _columnLength;

        public NewspaperAd(int fee) : base(fee)
        {
            _column = 1;
            _columnLength = 1;
            base.SetFee(fee);
        }
        public NewspaperAd(int fee, int colNum, int colLength) : base(fee)
        {
            _column = colNum;
            _columnLength = colLength;
            base.SetFee(fee);
        }
        private new int Cost()
        {
           
            var fee = base.Cost();
            return fee * (_column * _columnLength);
        }

        public override string ToString()
        {
            return "\nNewspapperAd: Fee=" + Cost();
        }
    }
}