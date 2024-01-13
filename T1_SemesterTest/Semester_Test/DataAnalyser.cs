using Semester_Test;

public class DataAnalyser
{
    private List<int> onumber;
    private AverageSummary oavgSumariser;
    private MinMaxSummary ominMaxSummariser;
    private SummaryStrategy ostrategy;

    public SummaryStrategy Strategy
    {
        get { return ostrategy; }
        set { ostrategy = value; }
    }

    public DataAnalyser() : this(new List<int>(), new AverageSummary()) { }

    public DataAnalyser(List<int> numbers, SummaryStrategy sumstrategy)
    {
        onumber = numbers;
        ostrategy = sumstrategy;
    }

    // New constructor
    public DataAnalyser(List<int> numbers)
    {
        onumber = numbers;
        ostrategy = new AverageSummary();
    }

    public void AddNumber(int num)
    {
        onumber.Add(num);
    }

    public void Summarise(string typeOfSummary)
    {
        if (Strategy is MinMaxSummary)
        {
            ostrategy.PrintSummary(onumber);
        }
        else if (Strategy is AverageSummary)
        {
            ostrategy.PrintSummary(onumber);
        }
    }
}