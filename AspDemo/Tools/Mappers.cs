using AspDemo.FormModels;
using AspDemo.Models;

namespace AspDemo.Tools
{
    public static class Mappers
    {
        public static Client ToClient(this ClientForm form)
        {
            return new Client
            {
                Email = form.Email,
                Name = form.Name
            };
        }
    }
}
