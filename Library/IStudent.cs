namespace Library
{
    public interface IStudent
    {
        int age { get; }
        double grade { get; }
        string name { get; }
        int year { get; }

        void SetAge(int age);
        void SetGrade(double grade);
        void SetName(string name);
        void SetYear(int year);
    }
}