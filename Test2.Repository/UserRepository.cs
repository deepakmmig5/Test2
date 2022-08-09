namespace Test2.Repository;
using Test2.Models;
public interface IUserRepository
{
    //Create

    Users Create(Users obj);
    //Read
    List<Users> GetAllUsers();

    //Update
     Users Update(Users obj);
    //Delete

     bool Delete(string _id);

}

public class UserRepository : IUserRepository
{

     private readonly IdbContext _context;
public UserRepository(IdbContext context){

_context=context;
}


    public Users Create(Users obj)
    {
        var data =_context.GetCollection<Users>(typeof(Users).Name);
        data.InsertOne(obj);
        return obj;
    }

    public bool Delete(string _id)
    {
        throw new NotImplementedException();
    }

    public List<Users> GetAllUsers()
    {
        throw new NotImplementedException();
    }

    public Users Update(Users obj)
    {
        throw new NotImplementedException();
    }
}
