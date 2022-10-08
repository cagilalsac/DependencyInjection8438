Service service = new Service();
service.GetList(new SqlDatabase()); // constructor injection üzerinden tek bir obje enjekte edilip enjekte edilen class'ta kullanılabilir, method ve property injection'da farklı objeler enjekte edilebilir

class Service
{
    public void GetList(IDatabase database) // method injection
    {
        database.List();
    }
}

interface IDatabase
{
    void List();
}

class SqlDatabase : IDatabase
{
    public void List()
    {
        Console.WriteLine("Listed by SQL");
    }
}
