namespace CollectionsExamples.App
{
    public class Timer
    {
        // Fields

        // Constructors
        public Timer(){}

        // Methods
        public TimeSpan Run()
        {

            // start a timer
            DateTime start = DateTime.Now;

            // some time intensive action
            // Demo tmp = new Demo();
            // tmp.getDifferences();
            
            StackQueue sq = new StackQueue();
            sq.clearStackQueue();

            // stop the timer
            DateTime stop = DateTime.Now;

            TimeSpan ts = stop - start;

            // return the value of the timer
            return ts;
        }

    }
}