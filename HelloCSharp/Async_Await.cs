

namespace Async_Await
{
    /*Allow task to run independently of the main flow to enable other new tasks to start
     Async: processes bg task
    Await pauses execution of calling method
    Async uses Task type. Task is done in future to prevent blocking program*/
    public class Async_Await
    {
        //use 'Async' keyword to mark a method as asynchronou
        public async Task GetDataAsync()
        {
            try
            {
            var data = await GetDataFromApi();
            return data;
            } catch (Exception ex)
            {
                // Handle exceptions
                Console.WriteLine($"An error occurred: {ex.Message}");

            }
    }
}