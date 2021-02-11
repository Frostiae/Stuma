using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FireSharp;
using FireSharp.Config;
using FireSharp.Response;

namespace Stuma.Control
{
    public class Database
    {
        public static Student currentUser { get; set; }
        static FirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "q5RDnge7vWIoAtuDJa1avsgkTjAt1FHbEcitVhQM",
            BasePath = "https://student-manager-21372-default-rtdb.firebaseio.com/"
        };

        static FirebaseClient client = new FirebaseClient(config);

        public static async void SetData(object data)
        {
            await client.SetAsync("Users/" + currentUser.username, data);
        }

        public static async Task<FirebaseResponse> GetData(string path)
        {
            FirebaseResponse response = await client.GetAsync(path);
            return response;
        }

        public static async Task<bool> DataExists(string path)
        {
            FirebaseResponse response = await client.GetAsync(path);
            if (response.Body == "null")
                return false;

            return true;
        }
    }
}
