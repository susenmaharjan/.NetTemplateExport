namespace Susen.ResultProject.Services.DataAccess.Interfaces
{
    public interface IUserContext
    {
        string FullName { get; set; }
        string Name { get; set; }

        IUserContext GetContext();
    }
}