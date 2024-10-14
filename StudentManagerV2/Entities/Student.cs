namespace StudentTester.Entities;

public class Student
{
    public string Id { get; set; }
    public string Name { get; set; }
    public int Yob { get; set; }
    public double Gpa { get; set; }

    public override string ToString() => $"Id: {Id}, Name: {Name}, Gpa: {Gpa}";
    //Nguyen ly solid la moi class chi lam 1 nhiem vu => class nay k nen la thung chua
    //Retrieve: Lay toan bo info\
    //Tủ đựng hồ sơ, tủ đựng balo=> có dịch vụ lưu trữ hồ sơ cho khách hàng=> Service 
    public void ShowProfile() => Console.WriteLine($"Id: {Id}, Name: {Name}, Gpa: {Gpa}");
}