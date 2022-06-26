using System;

namespace eHouseManager.Common
{
    public static class Constants
    {
        public const string DOMAIN_NAME = "https://localhost:44373/";
        public const string ENTITY_NOT_FOUND = "Entity not found";

        public const string SESSION_ROLE_KEY = "CurrentRole";
        public const string SESSION_ID_KEY = "CurrentId";
        public const string SESSION_AUTH_KEY = "CurrentUser";

        public const string HEADER_AUTH_KEY = "Authorization";

        public const string ROLE_EMPLOYEE = "Admin";
        public const string ROLE_USER = "User";

        public const string NOT_LOGGED = "You are not logged!";
        public const string NOT_AUTHORIZED = "You are not authorized!";
        public const string WRONG_CREDENTIALS = "Wrong credentials!";

        public const string LOGGED = "You logged successfully!";
        public const string REQUIRED = "This field is required!";
        public const string ACCOUNT_NOT_FOUND = "Account not found!";
        public const string WRONG_ID = "Wrong id!";
        public const string INCORRECT_DATA = "Incorrect or missing data!";
    }
}
