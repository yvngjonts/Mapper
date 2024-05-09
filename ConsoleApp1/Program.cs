using AutoMapper;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mapper");

           Dodge emp = new Dodge();

            emp.Id = 100000;
            emp.Name = "Dodge";
            emp.Title = "Hellcat";
            emp.Description = "Supercharged";

            DodgeDto dto = new DodgeDto();

            dto.Id = emp.Id;
            dto.Name = emp.Name;
            dto.Title = emp.Title;
            dto.Description = emp.Description;

            Console.WriteLine(dto.Id + " " + dto.Name + " " + dto.Title + " " + dto.Description);
            Console.WriteLine("----------------------Nüüd algab Automapper-------------------------");
            Console.WriteLine("----------------------Facebook Marketplace Hind----------------------");

            Dodge employee = new Dodge()
            {
                Id = 50000,
                Name = "Dodge 2019",
                Description = "Scatpack",
                Title = "Turbocharged",
            };
            var mapper = Program.InitializeAutoMapper();

            var empDto2 = mapper.Map<Dodge, DodgeDto>(employee);

            Console.WriteLine(empDto2.Id + " " + empDto2.Name + " " + empDto2.Title + " " + empDto2.Description);

     
        }



        public static Mapper InitializeAutoMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Dodge, DodgeDto>();
            });

            var mapper = new Mapper(config);

            return mapper;

        }
    }

    public class Dodge
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

    }

    public class DodgeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

    }
}
