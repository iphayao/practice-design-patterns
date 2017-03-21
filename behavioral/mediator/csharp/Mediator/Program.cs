using System;

namespace Mediator
{
    interface IChatRoomMediator
    {
        void ShowMessage(User user, string message);
    }

    class ChatRoom : IChatRoomMediator
    {
        public void ShowMessage(User user, string message)
        {
            string sender = user.GetName();
            Console.WriteLine("{0} [{1}]:{2}", DateTime.Now.ToString("MMMM dd, yyyy H:mm:ss"), sender, message);
        }
    }

    class User
    {
        protected string name;
        protected IChatRoomMediator chateMediator;

        public User(string name, IChatRoomMediator chateMediator)
        {
            this.name = name;
            this.chateMediator = chateMediator;
        }

        public string GetName()
        {
            return this.name;
        }

        public void send(string message)
        {
            this.chateMediator.ShowMessage(this, message);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ChatRoom mediator = new ChatRoom();

            User john = new User("John Doe", mediator);
            User jane = new User("Jane Doe", mediator);

            john.send("Hi there!");
            jane.send("Hey!");
        }
    }
}
