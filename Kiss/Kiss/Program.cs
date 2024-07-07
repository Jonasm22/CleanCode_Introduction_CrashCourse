namespace MyApp
{
    internal class Program
    {
      
        public void ReadFile(string filePatch)
        {
            try
            {
                    string content = File.ReadAllText(filePatch);
                    Console.WriteLine(content);

            }
            catch(FileNotFoundException ex) 
            {
                Console.WriteLine("File not Found: " +  ex.Message); 
            } 
            catch(UnauthorizedAccessException ex) 
            {
                Console.WriteLine("Access denied: " +  ex.Message);

            }

            catch (Exception ex) 
            {
                Console.WriteLine("An error occured " +  ex.Message);
            }

        }
    }
}
