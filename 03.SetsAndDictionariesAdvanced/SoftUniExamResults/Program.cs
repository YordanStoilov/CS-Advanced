
SortedDictionary<string, int> courses = new();
List<Student> students = new();

string command;
while ((command = Console.ReadLine()) != "exam finished")
{
    string[] split = command.Split("-");
    string name = split[0], courseName = split[1];
    if (!StudentExists(name))
    {
        students.Add(new Student(name));
    }
    Student currentStudent = FindStudentByName(name);
    if (courseName == "banned")
    {
        students.Remove(currentStudent);
        continue;
    }
    int score = int.Parse(split[2]);
    if (currentStudent.Courses.ContainsKey(courseName))
    {
        int oldScore = currentStudent.Courses[courseName];
        if (score > oldScore)
        {
            currentStudent.Courses[courseName] = score;
            currentStudent.Points += score - oldScore;
        }
    }
    else
    {
        currentStudent.Courses[courseName] = score;
        currentStudent.Points += score;
    }

    if (!courses.ContainsKey(courseName))
    {
        courses[courseName] = 0;
    }
    courses[courseName]++;
}

Console.WriteLine("Results:");

List<Student> sorted = students
.OrderByDescending(student => student.Points)
.ThenBy(student => student.Name)
.ToList();

foreach (Student student in sorted)
{
    Console.WriteLine($"{student.Name} | {student.Points}");
}

Console.WriteLine("Submissions:");

foreach (var (course, count) in courses)
{
    Console.WriteLine($"{course} - {count}");
}

bool StudentExists(string name)
{
    foreach (Student student in students)
    {
        if (student.Name == name)
        {
            return true;
        }
    }
    return false;
}

Student FindStudentByName(string name)
{
    foreach (Student student in students)
    {
        if (student.Name == name)
        {
            return student;
        }
    }
    return null;
}

class Student
{
    public string Name { get; set; }
    public int Points { get; set; }
    public Dictionary<string, int> Courses { get; set; }

    public Student(string name)
    {
        Name = name;
        Points = 0;
        Courses = new();
    }
}