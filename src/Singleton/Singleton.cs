namespace Singleton
{
    // Singleton class
    public sealed class Singleton
    {
        // The singleton instance
        private static Singleton instance = null;

        // The list of strings
        private List<string> values;

        // Private constructor to prevent instantiation from outside the class
        private Singleton()
        {
            // Initialize the list of strings
            values = new List<string>();
            values.Add("Apple");
            values.Add("Banana");
            values.Add("Cherry");
        }

        // Public method to get a reference to the singleton instance
        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }

            return instance;
        }

        // Public method to get the list of strings
        public List<string> GetValues()
        {
            return values;
        }
    }
}
