using System;
using System.Collections.Generic;
using System.Linq;
using BlazorAssignment.Models;

namespace BlazorAssignment.Data.Impl
{
    public class InMemoryUserService : IUserService {
        private List<User> users;

        public InMemoryUserService() {
            users = new[] {
                new User {
                    Password = "123456",
                    Role ="Adult",
                    SecurityLevel = 1,
                    UserName = "NotKasper"
                },
                new User()
                {
                    Password = "11111",
                    Role="NotAdult",
                    SecurityLevel = 2,
                    UserName = "ParamPum"
                }
                
            }.ToList();
        }


        public User ValidateUser(string userName, string password) {
            User first = users.FirstOrDefault(user => user.UserName.Equals(userName));
            if (first == null) {
                throw new Exception("User not found");
            }

            if (!first.Password.Equals(password)) {
                throw new Exception("Incorrect password");
            }

            return first;
        }
    }
}