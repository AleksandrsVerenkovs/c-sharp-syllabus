namespace AdApp
{
    public class TVAd : Advert
    {
        private int peakTime;
        private int _seconds;
        private int peakTimeRate;
        public TVAd(int fee, int totalTimeSec, int peakTimeSec = 0) : base(fee)
        {
            _seconds = totalTimeSec;
            peakTime = peakTimeSec;
            peakTimeRate = 2;
        }

        public new int Cost()
        {
            var fee = base.Cost() * _seconds - peakTime;
            if (peakTime > 0)
            {
                fee += base.Cost() * peakTime * peakTimeRate;
            }
            return fee;
        }

        public override string ToString()
        {
            return "\nTVAd: Fee=" + Cost();
        }
    }
}