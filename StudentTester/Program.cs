using StudentTester.Service;

namespace StudentTester;

class Program
{
    static void Main(string[] args)
    {
        Cabinet tuSE = new(500);
        Cabinet tuIA = new(500);
        tuSE.Add("SE1", "Dieu Vi", 2004, 8.8);
        tuSE.Add("SE2", "Dieu Vi", 2004, 8.8);
        tuSE.Add("SE3", "Dieu Vi", 2004, 8.8);
        tuSE.Update("SE3", "TOKI", 2004, 8.8);
        tuSE.Update("SE1", "Hi", null, null);
        tuSE.PrintCabinet();
        tuSE.Delete("SE2");
        tuSE.PrintCabinet();
    }
    
}