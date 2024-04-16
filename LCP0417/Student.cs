namespace b// folder b
{
    public class Student
    {
        public string Id;
        public string Name;
        public double Grade;
        public char LetterGrade;

        public char GetLG()
        {
            if (Grade >= 90)
            {
                LetterGrade = 'A';
            }
            else if (Grade >= 80)
            {
                LetterGrade = 'B';
            }
            else if (Grade >= 70)
            {
                LetterGrade = 'C';
            }
            else if (Grade >= 60)
            {
                LetterGrade = 'D';
            }
            else
            {
                LetterGrade = 'F';
            }
            return LetterGrade;
        }

        public string GetInfor()
        {
            return $"ID: {Id}, Name: {Name}, Grade: {Grade} ({LetterGrade})";
        
        }
    }
}