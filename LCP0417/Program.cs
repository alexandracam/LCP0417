// MIS 3013 001
// April 17, 2024
//Alexandra Camarena
// 113568154

using b;// go to b folder to find definition of Student

Console.WriteLine("List");

List<Student> stuList;
stuList= new List<Student>();

stuList.Add(new Student());


stuList[0].Id = "S101";
stuList[0].Name = "Tom";
stuList[0].Grade = 96.6;
stuList[0].GetLG();// function call

Console.WriteLine(stuList[0].GetInfor());