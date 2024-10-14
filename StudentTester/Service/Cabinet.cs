using System.Net.Sockets;
using System.Threading.Channels;
using StudentTester.Entities;

namespace StudentTester.Service;

public class Cabinet
{
    private Student[] _arr;
    private int _count = 0;
    
    //why using _backing-field, not using property
    //array must be flexible => how?
    public Cabinet(int size)
    {
        if (size < 1)
            size = 1;
        _arr = new Student[size];
    }
    //Mở rộng: Nếu muốn trong ram chỉ có 1 object được tạo ra, ko nhiều hơn 1 vùng new => SINGLETON!!!
    //design pattern - các mẫu, kĩ thuật thiết kế class ~ SOLID 
    public int Count => _count;
    public bool IsFull() => _count >= _arr.Length;
    
    public void Add (Student s)
    {
        if (IsFull())
        {
            Console.WriteLine("Cabinet is full");
            return;
        }
            
        _arr[_count++] = s;
    }

    public void Add(string id, string name, int yob, double gpa) =>
        _arr[_count++] = new Student() { Id = id, Name = name, Yob = yob, Gpa = gpa };
    


    public void PrintCabinet()
    {
        if (_count <= 0)
        {
            throw new InvalidOperationException("Cabinet is empty");
        }
        
        Console.WriteLine($"Cabinet has {_count} students:");
        for (int i = 0; i < _count; i++)
        {
              _arr[i].ShowProfile();  
        }

    }

    public void Delete(string id)
    {
        int? pos = SearchById(id);
        if (pos.HasValue)
        {
            _count--;
            for (int i = (int)pos; i < _count; i++)
            {
                _arr[i] = _arr[i + 1];
            }
        }
    
    }

    public void Update(string id, string? newName, int? newYob, double? newGpa)
    {
        int? pos = SearchById(id);
        if (pos.HasValue)
        {
            _arr[(int)pos].Name = newName is null ? _arr[(int)pos].Name : newName;
            _arr[(int)pos].Yob = newYob is null ? _arr[(int)pos].Yob : newYob;
            _arr[(int)pos].Gpa = newGpa is null ? _arr[(int)pos].Gpa : newGpa;
        } 
        //BTVN: Them cau If de check neu nhap update = null, thi giu nhu cu ko doi
    }
    //Hàm tìm kiếm người dùng tìm vị trí theo id 
    //Java ko the == 2 string, nhung C# thi duoc tai vi no da override lai
    public int? SearchById(string id)
    {
        if (_count <= 0) return null;
        for (int i = 0; i < _count; i++)
        {
            if (_arr[i].Id.ToLower() == id.ToLower())
                return i;
        }

        return null;
    }
    //1. Hoàn thành Update 
}                           