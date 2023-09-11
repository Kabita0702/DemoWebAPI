using FirstWebApiApplication.Repository;
using System.Net;
using FirstWebApiApplication.Models.DTO;
using FirstWebApiApplication.Models.Domain;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebApiApplication.Service
{
    public class LoginUser
    {
        public Response UserLogin(User inputRequest)
        {
            var userList = UserDataRepository.GetUserData();
            var flag = userList.FirstOrDefault(item => (item.UserName == inputRequest.UserName && item.Password == inputRequest.Password));
            if (flag == null)
            {
                throw new Exception("Invaild user please check the username and password");
            }
            return new Response()
            {
                StatusCode = HttpStatusCode.OK,
                Message = " Login Successfully"
            };
        }
    }
}
