


using DatingApp.BusinessLayer.Interface;
using DatingApp.BusinessLayer.Service.Repository;
using DatingApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.BusinessLayer.Service
{
    public class UserService: IUserService
    {
        private readonly IUserRepository _userRepository;
        /// <summary>
        /// Inject userRepository object
        /// </summary>
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        /// <summary>
        /// Call user repository method to Add user profile
        /// </summary>
        /// <param name="profile"></param>
        /// <returns></returns>
        public async Task<Profile> AddProfile(Profile profile)
        {
            //business logic goes here
            throw new NotImplementedException();

        }

        /// <summary>
        ///  let Admin Call user repository method to change any user's password
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="NewPassword"></param>
        /// <returns></returns>
        public async Task<string> ChangePassword(string UserName, string NewPassword)
        {
            //business logic goes here
            throw new NotImplementedException();

        }

        /// <summary>
        /// Call user repository method to create new user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<string> CreateNewUser(User user)
        {
            //business logic goes here
            throw new NotImplementedException();

        }


        /// <summary>
        /// Call user repository method to return list of all Members details
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<User>> ListOfMembers()
        {
            //business logic goes here
            throw new NotImplementedException();

        }

        /// <summary>
        /// let Admin Call user repository method to suspend User
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="userStatus"></param>
        /// <returns></returns>
        public async Task<String> SuspendUser(String UserName, UserStatus userStatus)
        {
            //business logic goes here
            throw new NotImplementedException();

        }

        /// <summary>
        /// Call user repository method to verify user exist or not
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="Password"></param>
        /// <returns></returns>
        public async Task<User> VerifyUser(string UserName, string Password)
        {
            //business logic goes here
            throw new NotImplementedException();

        }
    }
}
