using Dal;
using Infrastructure.Model.Common;
using MRDbIdentity.Infrastructure.Interface;
using MRDbIdentity.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Manager
{

    public class BaseManager
    {
        protected readonly AppUserManager _appUserManager;
        protected readonly IUserRepository _userRepository;
        protected readonly IRoleRepository _roleRepository;

        public BaseManager(AppUserManager appUserManager, IUserRepository userRepository, IRoleRepository roleRepository)
        {
            _appUserManager = appUserManager;
            _userRepository = userRepository;
            _roleRepository = roleRepository;
        }

        public ApiResponse Ok(object response = null, string message = null)
        {
            return new ApiResponse
            {
                IsSuccess = true,
                Message = message,
                Response = response,
                Error = null
            };
        }

        public ApiResponse Fail(string message = null, object error = null)
        {
            return new ApiResponse
            {
                IsSuccess = false,
                Error = error,
                Message = message,
                Response = null
            };
        }
    }
}
