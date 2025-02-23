namespace SchoolReinforcement.Interfaces.Service
{
    public interface IService <T> where T : class
    {
        T GetById(int id);
    }
}
