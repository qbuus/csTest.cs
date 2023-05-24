namespace Project
{
    class Anotherfile : IFile
    {
        // interface (is abstract how have to implement)
        public string? Name {get; set;}
        public int Size {get; set;}
        public DateTime whenCreatedFile {get; set;}
        public void Info()
        {
            Console.WriteLine($"FileName: {Name}, FileSize: {Size}, WasCreatedOn: {whenCreatedFile}");
        }
    }
}