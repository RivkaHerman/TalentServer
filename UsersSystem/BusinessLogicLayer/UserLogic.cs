using System.Collections.Generic;
using System.Linq;


namespace JB
{
    public class UserLogic
    {
        protected Dal dal = new Dal();

        public List<UserDTO> GetUsers(int groupName)
        {
            int minMonth = dal.users.Select(x => x.birthdate.Month).Min();

            var q = from u in dal.users
                    where u.birthdate.Month >= minMonth + groupName * 3 && u.birthdate.Month <= minMonth + (groupName * 3 + 2)
                    select new UserDTO
                    {
                        idUser = u.id,
                        nameUser = u.name,
                        emailUser = u.email,
                        birthdateUser = u.birthdate,
                        genderUser = u.gender
                    };

            return q.ToList();
        }

    }
}
