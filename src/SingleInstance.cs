namespace SingleInstance
{
    using System;
    using System.Threading;
    using System.Windows.Forms;

    class Program
    {
        private readonly static Mutex mutex =
            new Mutex (true, "{af27de79-07f3-42c0-b9c7-3de63cbdfd7d}");

        private readonly static string SingleInstanceErrMsg =
            "Only one instance of the application may be running at a time.";

        public static void DetectSingleInstance (Mutex m)
        {
            if (!m.WaitOne (TimeSpan.Zero, true))
            {
                Console.WriteLine (SingleInstanceErrMsg);
                MessageBox.Show (SingleInstanceErrMsg);
                Environment.Exit (1);
            }
        }

        [STAThread]
        public static void Main (string[]args)
        {
            DetectSingleInstance (mutex);

            while (true)
            {
                Thread.Sleep (1000);
            }
        }
    }
}
