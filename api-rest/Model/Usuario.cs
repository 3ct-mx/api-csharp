using System;
namespace api_rest.Model
{
	public class Usuario
	{

		public string id { get; set; }
		public string email { get; set; }
		public string password { get; set; }

        public Usuario()
		{
		}

        public Usuario(string id, string email, string password)
        {
            this.id = id;
            this.email = email;
            this.password = password;
        }
    }
}

