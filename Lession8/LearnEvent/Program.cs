using System;

namespace LearnEvent
{
    class Program
    {
        // 1. Tạo delegate
        //public delegate void Notify();

        // Tạo ra lớp Publisher
        class ProcessBusinessLogic
        {
            // 2. Tạo event liên kết đến delegate
            // public event Notify ProcessCompleted;

            public EventHandler ProcessCompleted;

            protected virtual void OnProcessCompleted(EventArgs e)
            {
                // ProcessCompleted?.Invoke();
                ProcessCompleted?.Invoke(this, e);
            }

            public void StartProcess()
            {
                Console.WriteLine(" Process started...");
                OnProcessCompleted(EventArgs.Empty);
            }
        }


        
        // Subcriber
        static void Main(string[] args)
        {
            ProcessBusinessLogic bl = new ProcessBusinessLogic();

            // 3. Đăng kí sự kiện
            bl.ProcessCompleted += EventHandlerCompleted;

            // 4. Phát sinh sự kiện
            bl.StartProcess();
        }

        // event handler
        public static void EventHandlerCompleted(object sender, EventArgs e)
        {
            Console.WriteLine(" Process completed!");
        }
    }
}
