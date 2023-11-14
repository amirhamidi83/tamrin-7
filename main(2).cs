amirmahdi hamidi tamrin 7



class Program
{
  static void Main (string[]args)
    Console.WriteLine ("salam,lotfan halat mored nazar ra entekhab konid:");
    Console.WriteLine ("1.namayesh nomarat");
    Console.WriteLine ("2.namayesh maadel");
    Console.WriteLine ("3.taeen adad aval nomarat ");
    Console.WriteLine ("4.namayesh sort maadel");
    Console.WriteLine ("5.end");


  int choice = int.Parse (Console.ReadLine ());
  switch (choice)
    {
    case 1:
      DisplayGrades (students);
      break;
      case 2:DisplayAverages (students);
      break;
      case 3:DisplayPrimeNumbers (students);
      break;
      case 4:SortGrades (students);
      break;
      case 5:Environment.Exit (0);
      break;
      default:Console.ReadLine ("na motabar")
	List < Student > students = new List < Student > ();
      StreamReader sr = new StreamReader (@"C:\Students");
      while (!sr.EndOfStream)
	{
	  string line = sr.ReadLine ();
	  Student student = new Student ();
	    student.FName = line.Split (',')[0];
	    student.LName = line.Split (',')[1];
	    student.pishrafteh1 = Convert.ToDouble (line.Split (',')[2]);
	    student.tafsir = Convert.ToDouble (line.Split (',')[3]);
	    student.riazi = Convert.ToDouble (line.Split (',')[4]);
	    student.kargah = Convert.ToDouble (line.Split (',')[5]);
	    student.zaban = Convert.ToDouble (line.Split (',')[6]);
	    student.pishrafteh2 = Convert.ToDouble (line.Split (',')[7]);
	    student.sheygeraii = Convert.ToDouble (line.Split (',')[8]);
	    student.varzesh = Convert.ToDouble (line.Split (',')[9]);
	    student.sistem amel = Convert.ToDouble (line.Split (',')[10]);
	    student.algoritm = Convert.ToDouble (line.Split (',')[11]);

	    students.Add (student);
	}
      foreach (var student in students)
      {
	Console.WriteLine (student.TotalAverage ());
      }
      class Student
      {
	public string FName
	{
	  get;
	  set;
	}
	public string LName
	{
	  get;
	  set;
	}
	public double pishrafteh1
	{
	  get;
	  set;
	}
	public double tafsir
	{
	  get;
	  set;
	}
	public double riazi
	{
	  get;
	  set;
	}
	public double kargah
	{
	  get;
	  set;
	}
	public double zaban
	{
	  get;
	  set;
	}
	public double pishrafteh2
	{
	  get;
	  set;
	}
	public double sheygeraii
	{
	  get;
	  set;
	}
	public double varzesh
	{
	  get;
	  set;
	}
	public double sistem amel
	{
	  get;
	  set;
	}
	public double algoritm
	{
	  get;
	  set;
	}

	public double TotalAverage ()
	{
	  return ((pishrafteh1 3) + (tafsir 1) + (riazi 2) + (kargah 3) +
		  (zaban 2) + (pishrafteh2 3) + (sheygeraii 3) + (varzesh 1) +
		  (sistem amel 3) + (algoritm 3)) / 22;
	}
      }

      Random random = new Random ();
      for (int i = 0; i < 100; i++)
	{
	  Student student = new Student ();
	  student.Name = "student9" + (i + 1);
	  for (int j = 0; j < 10; j++)
	    {
	      int score = random.Next (0, 21);
	      student.Grades.Add (score);
	    }
	  students.Add (student);
	}
      return students;
    }

  static void DisplayGrades (List < Student > students)
  {
    foreach (Student student in students)
    {
      Console.WriteLine (" nam daneshjo: " + student.Name);
      Console.WriteLine (" nomarat:");
      for (int i = 0; i < student.Grades.Count; i++)
	{
	  Console.WriteLine ("X/X1X3 " + (i + 1) + ": " + student.Grades[i]);
	}
