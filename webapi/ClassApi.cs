namespace Api
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Average { get; set; }
        public string ToStringNew(Student student)
        {
            return $"Id: {student.Id}\tName: {student.Name,-15}\tAverage: {student.Average: 0.00}";
        }
    }
}