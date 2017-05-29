using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoDatabase.Utilities;

namespace AutoDatabase
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
            using (var context = new AutoShopEntities())
            {
                User user = context.Users.FirstOrDefault(x => x.Username == "admin");
                if (user == null)
                {
                    Client client = new Client()
                    {
                        Adress = "not found",
                        IsCompany = false,
                        Name = "Admin",
                        Telephone = "000",
                        User = new User()
                        {
                            IsAdmin = true,
                            Username = "admin",
                            PasswordHash = PasswordHashing.StringToSHA1("admin")
                        }
                    };
                    client.User.Client = client;
                    context.Clients.Add(client);
                    context.Users.Add(client.User);
                }
            }
            Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
	}
}
