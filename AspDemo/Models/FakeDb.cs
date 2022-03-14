namespace AspDemo.Models
{
    public static class FakeDb
    {
        public static List<Client> liste = new List<Client>() {
                new Client { Id = 1, Name = "Arthur", Email = "arthur@mail.com" },
                new Client { Id = 2, Name = "Perceval", Email = "Perceval@mail.com" },
                new Client { Id = 3, Name = "Karadoc", Email = "Karadoc@mail.com" },
                new Client { Id = 4, Name = "Merlin", Email = "Merlin@mail.com" },
                new Client { Id = 5, Name = "Léodagan", Email = "Léodagan@mail.com" },
                new Client { Id = 6, Name = "Bohort", Email = "Bohort@mail.com" }
            };

        public static void Delete(int id)
        {
            liste.Remove(liste.FirstOrDefault(x => x.Id == id));
        }

        public static Client GetById(int id)
        {
            return liste.FirstOrDefault(x => x.Id == id);
        }
    }
}
