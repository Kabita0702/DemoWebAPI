namespace FirstWebApiApplication.Repository
{
    public interface ISchoolRepository<T> where T : class
    {
        public List<T> ReadUser(string path);
        public void SaveUser(string path, List<T> _jsonData);
    }
}
