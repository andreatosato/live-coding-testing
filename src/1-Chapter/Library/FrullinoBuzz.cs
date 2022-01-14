namespace Library
{
    /// <summary>
    /// Restituire la string Frullino se multiplo di 3
    /// Restituire la string 42 se multiplo di 5
    /// 
    /// 
    /// </summary>
    public class FrullinoBuzz
    {
        public string[] Output()
        {
            var output = new string[100];
            for (int i = 0; i < 100; i++)
            {
                if ((i % 3) == 0)
                    output[i] = "Frullino";

                if ((i % 5) == 0)
                    output[i] = "42";

                if ((i % 3) == 0 && (i % 5) == 0)
                    output[i] = "Frullino42";

                if (string.IsNullOrEmpty(output[i]))
                    output[i] = i.ToString();
            }
            return output;
        }
    }
}