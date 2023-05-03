
using ConsoleApp.Test;

Console.WriteLine("----------------- START: CLASS ---------------------");

var student = new Student();
student.FirstName = "Student Fullname";
Console.WriteLine($"Student FistName [student]: {student.FirstName}");

string studentFullName = student.GetFullName("Enco", "Tahiri");
Console.WriteLine($"Student Full Name [student]: {studentFullName}");

// 
string studentFullNameStatic = StudentStatic.GetFullName("Enco", "Tahiri");
Console.WriteLine($"Student Full Name [student]: {studentFullNameStatic}");

//var lastStudent = new Student("Student Fullname 2");
//Console.WriteLine($"Student FistName [lastStudent]: {lastStudent.FirstName}");


Console.WriteLine("----------------- START: CLASS ---------------------");




//string fullName = "Student Fullname";
//Console.WriteLine($"Original value = {fullName}");

//fullName = "Student Fullname 2";
//Console.WriteLine($"New value = {fullName}");

//const string middleName = "MiddleName";
//Console.WriteLine($"Original value = {middleName}");
////middleName = "MiddleName 2";
////Console.WriteLine($"New value = {middleName}");

//int number1 = 1;
//int number2 = 2;

//int shume = number1 + number2;

//Console.WriteLine($"Shuma e dy numrave eshte {shume}");

//int number3 = 3;
//int number4 = 4;

//var mesatarjs = Math.Sqrt;

//Console.WriteLine("----------------- START: LOOPS ---------------------");

////For Loop
//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine($"For Loop: {i}");
//}

////While Loop
//int j = 0;
//while (j < 10)
//{
//    Console.WriteLine($"While Loop: {j}");
//    j++;
//}

////Do While Loop
//int k = 0;
//do
//{
//    Console.WriteLine($"Do While Loop: {k}");
//    k++;
//} while (k < 10);


//Console.WriteLine("----------------- END: LOOPS ---------------------");


//Console.WriteLine("----------------- START: STATEMENTS ---------------------");



////Even and odd numbers example
//int m = 5;
//if (m % 2 == 0)
//{
//    Console.WriteLine($"Even Number: {m}");
//}
//else
//{
//    Console.WriteLine($"Odd Number: {m}");
//}

////Switch
//int n = 5;
//switch (n)
//{
//    case 1:
//        Console.WriteLine("Case 1");
//        break;
//    case 2:
//        Console.WriteLine("Case 2");
//        break;
//    case 3:
//        Console.WriteLine("Case 3");
//        break;
//    case 4:
//        Console.WriteLine("Case 4");
//        break;
//    default:
//        Console.WriteLine("Default Case");
//        break;
//}

////If Statement
//int l = 5;
//if(l == 1)
//{
//    Console.WriteLine("Case 1");
//} else if (l == 2)
//{
//    Console.WriteLine("Case 2");
//} else if (l == 3)
//{
//    Console.WriteLine("Case 3");
//} else if (l == 4)
//{
//    Console.WriteLine("Case 4");
//}
//else
//{
//    Console.WriteLine("Default Case");
//}

//Console.WriteLine("----------------- END: STATEMENTS ---------------------");


//Console.WriteLine("----------------- START: LIST ---------------------");

//// List with Integers
//List<string> studentIds = new List<string>
//{
//    "1234",
//    "2345",
//    "3456"
//};

//foreach (var studentId in studentIds)
//{
//    Console.WriteLine(studentId);
//}



//Console.WriteLine("----------------- END: LIST ---------------------");

//Console.WriteLine("----------------- START: ARRAY ---------------------");

//// Array with Integers
//string[] studentIdsArray = new string[10];

//Console.WriteLine("----------------- END: ARRAY ---------------------");




////DateTime now = DateTime.Now;
////Console.WriteLine(now);
////DateTime nowUtc = DateTime.UtcNow;
////Console.WriteLine(nowUtc);

////var age = "1";
////var address = "Student Address";
////var phoneNumber = 2345;


////int age = 30;
////string address = "Student Address";
////string phoneNumber = "Student Phone Number";
////string email = "Student Email";
////string course = "Student Course";
////string university = "Student University";

////string faculty = "Student Faculty";

////string specialty = "Student Specialty";

////string studentId = "Student ID";

////string universityId = "Student University ID";




