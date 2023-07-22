using System.Threading.Tasks;

namespace Informations
{
    public static class Tarea
    {
        public static async Task Esperar_Async(params Task[] tasks)
        {
            await Task.Run(async () =>
            {
                foreach (Task row in tasks)
                {
                    await row;
                }
            });
        }
    }
}
