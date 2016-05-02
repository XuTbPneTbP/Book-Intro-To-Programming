using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSteps
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Laptop lenovo = new Laptop();
            Console.WriteLine("This is with empty constructor :  \n{0}", lenovo.ToString());
            Console.WriteLine("*****************************************************************");
            Laptop asus = new Laptop("Republic of Gamers", "Asus", 1000);
            Console.WriteLine("This is with constructor with values:  \n{0}", asus.ToString());
            Console.WriteLine("*****************************************************************");
            Post post = new Post();
            Console.WriteLine("This is with empty constructor :  \n{0}", post.ToString());
            Console.WriteLine("*****************************************************************");
            Post post2 = new Post("Bugs Bunny", "Мамата си джаса!", "Джаса си мамата здрау!");
            Console.WriteLine("This is with constructor with values:  \n{0}", post2.ToString());
            Console.WriteLine("*****************************************************************");

            post = null;
            /* Check for null before C# 6.0 */
            Console.WriteLine(post != null ? post.Comment : "No Rank");
            /* Check for null with ?. in C# 6.0 */
            Console.WriteLine(post?.Comment ?? "Empty object");
        }

        /*
        Each object is an instance of just one class and is created according to a pattern of this class. The instance is the object itself, wich is created runtime.
        Object consist of two things: state and behavior => state is specific for the object (name, breed, fur color, nationality); behavior is common for all objects which are instances of this class.
        */

        /* Properties :
        The only way to initialize an Auto Property is to implement an explicit constructor and set property values inside it. Defined properties keep their values in the hidden private fields
       */
        public class Laptop
        {
            /* Fields for laptop */
            private string _model = string.Empty;
            private string _manufacturer = string.Empty;
            private int _price;

            /* Auto Property Initialzier Before C# 6.0 */
            public int Price
            {
                get
                {
                    return _price;
                }

                set
                {
                    this._price = value;
                }
            }

            public string Manufacturer
            {
                get
                {
                    return _manufacturer;
                }

                set
                {
                    this._manufacturer = value;
                }
            }

            public string Model
            {
                get
                {
                    return _model;
                }

                set
                {
                    this._model = value;
                }
            }

            /* Constructor */
            public Laptop()
            {
                this._model = "No model";
                this._manufacturer = "No manufactorer ;)";
                this._price = 0;
            }
            public Laptop(string model, string manufacturer, int price)
            {
                this._model = model;
                this._manufacturer = manufacturer;
                this._price = price;
            }

            public override string ToString()
            {
                string q = string.Format("Model : {0} +> \nManufacturer : {1} => \nPrice : ${2}", this.Model, this.Manufacturer, this.Price);
                return q.ToString();
            }


        }

        /* 
         In C# 6, auto implemented property with initial value can be initialized without having to write the constructor. We can simplify the above example to the following: 
         */
        public class Post
        {
            public Post(string username, string postTitle, string comment)
            {
                this.Username = username;
                this.PostTitle = postTitle;
                this.Comment = comment;
            }

            public Post()
            {
            }

            /* Auto Property Initialzier Now in  C# 6.0 without constructor */
            public string Username { get; set; } = "You are funny!";
            public string PostTitle { get; } = "How to escape from bears!";
            public string Comment { get; protected set; } = "Глей си работата!";

            public Guid ID { get; } = new Guid("{B75B77A6-E793-4D51-A5CF-283A8AB02E0A}");

            public override string ToString()
            {
                string q = string.Format("Username : {0} +> \nPostTitle : {1} => \nComment : {2} => \nID: {3}", this.Username, this.PostTitle, this.Comment, this.ID);
                return q.ToString();
            }
        }

    }
}
