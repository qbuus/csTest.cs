namespace Project
{

    public interface IStorage{
        int Id {get; set;}
        string Name  {get; set;}
    }

    public class User : IStorage
    {
        
        public int Id {get; set;}
        public string Name{get; set;}
    }

    public class Restau : IStorage
    {
        public int Id {get; set;}
        public string Name{get; set;}
    }

    public class PaginatedResults<T>
    {   
        public List<T> ListResults {get; set;}
        public int ResultsStart {get; set;}
        public int ResultsFinish {get; set;}

        public int TotalPages {get; set;}
        public int TotalResults {get; set;}
    }
}