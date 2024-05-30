namespace Models
{
    public class Car
    {
        public static readonly string INSERT = "INSERT INTO TB_Car (Name, Color, Year) VALUES (@Name, @Color, @Year)";
        public static readonly string UPDATE = "UPDATE TB_Car SET Name = @Name, Color = @Color, Year = @Year WHERE Id = @Id";
        public static readonly string DELETE = "DELETE FROM TB_Car WHERE Id = @Id";
        public static readonly string GET = "SELECT * FROM TB_Car WHERE Id = @Id";
        public static readonly string GETALL = "SELECT * FROM TB_Car";
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Nome: {Name}, Cor: {Color}, Ano: {Year}";
        }
    }
}
