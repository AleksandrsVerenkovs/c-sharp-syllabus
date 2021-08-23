namespace AdApp
{
    public class Poster : Advert
    {
        private int _height;
        private int _width;
        private int _copies;
        private int _pricePerCopy;
        public Poster(int fee, int height, int width, int numCopies, int pricePerCopy) : base(fee)
        {
            _height = height;
            _width = width;
            _copies = numCopies;
            _pricePerCopy = pricePerCopy;
            base.SetFee(fee);
        }
        private new int Cost()
        {
            var fee = base.Cost();
            fee += _copies * _pricePerCopy;
            return fee;
        }

        public override string ToString()
        {
            return "\nPoster: Fee=" + Cost();
        }
    }
}
