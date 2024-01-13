namespace Semester_Test
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("minmax summary");
            List<int> studentID = new List<int>() { 1, 0, 4, 1, 7, 5, 9, 1, 5 };
            DataAnalyser dataAnalyser = new(studentID, new MinMaxSummary());
            dataAnalyser.Summarise("MinMax");
            studentID.Add(10);
            studentID.Add(7);
            studentID.Add(2);

            Console.WriteLine("Average Summary");
            dataAnalyser.Strategy = new AverageSummary();
            dataAnalyser.Summarise("average");
        }
    }
}