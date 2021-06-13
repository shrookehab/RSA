    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;    
    using System.Numerics;

    namespace RSA
    {
        class Program
        {
            static string reverse(string str)
            {
                string reverse = "";
                int Length = 0;
                Length = str.Length - 1;
                while (Length >= 0)
                {
                    reverse = reverse + str[Length];
                    Length--;
                }
                return reverse;
            }
            static void Main(string[] args)
            {
                Console.WriteLine("Congratulations!");
                Big_Integer b = new Big_Integer();
                ////////////FOR ADD FUNCTION///////////////
                //read test cases for add function in a list
                List<string> add_list = new List<string>();
                StreamReader sr_add = new StreamReader("AddTestCases.txt");
                string num_to_add = sr_add.ReadLine();
                while (num_to_add != null)
                {
                    add_list.Add(num_to_add);
                    num_to_add = sr_add.ReadLine();
                }
                sr_add.Close();
                //create file and write the outputs in it "add outputs"
                FileStream fs_add = new FileStream("Add-Output.txt", FileMode.OpenOrCreate);
                StreamWriter sw_add = new StreamWriter(fs_add);
                Console.WriteLine(" <== ADD TEST CASES TIME ==>");
                for (int i = 0; i < add_list.Count; i += 2)
                {
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();
                    string result_add = b.add(add_list[i], add_list[i + 1]);
                    stopwatch.Stop();
                    Console.Write(stopwatch.ElapsedMilliseconds + " ms");
                    Console.Write(" =====> ");
                    Console.WriteLine(stopwatch.ElapsedMilliseconds / 1000 + " sec");
                    sw_add.WriteLine(result_add);
                    sw_add.WriteLine();
                }
                sw_add.Close();
                fs_add.Close();
                ////////////FOR SUB FUNCTION///////////////
                //read test cases for sub function in a list
                List<string> sub_list = new List<string>();
                StreamReader sr_sub = new StreamReader("SubtractTestCases.txt");
                string num_to_sub = sr_sub.ReadLine();
                while (num_to_sub != null)
                {
                    sub_list.Add(num_to_sub);
                    num_to_sub = sr_sub.ReadLine();
                }
                sr_add.Close();
                //create file and write the outputs in it "sub outputs"
                FileStream fs_sub = new FileStream("Sub-Output.txt", FileMode.OpenOrCreate);
                StreamWriter sw_sub = new StreamWriter(fs_sub);
                Console.WriteLine(" <== SUB TEST CASES TIME ==>");
                for (int i = 0; i < sub_list.Count; i += 2)
                {
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();
                    string result_sub = b.sub(sub_list[i], sub_list[i + 1]);
                    stopwatch.Stop();
                    Console.Write(stopwatch.ElapsedMilliseconds + " ms");
                    Console.Write(" =====> ");
                    Console.WriteLine(stopwatch.ElapsedMilliseconds / 1000 + " sec");
                    sw_sub.WriteLine(result_sub);
                    sw_sub.WriteLine();
                }
                sw_sub.Close();
                fs_sub.Close();
                ////////////FOR MUL FUNCTION///////////////
                //read test cases for mul function in a list
                List<string> mul_list = new List<string>();
                StreamReader sr_mul = new StreamReader("MultiplyTestCases.txt");
                string num_to_mul = sr_mul.ReadLine();
                while (num_to_mul != null)
                {
                    mul_list.Add(num_to_mul);
                    num_to_mul = sr_mul.ReadLine();
                }
                sr_mul.Close();
                //create file and write the outputs in it "mul outputs"
                FileStream fs_mul = new FileStream("Mul-Output.txt", FileMode.OpenOrCreate);
                StreamWriter sw_mul = new StreamWriter(fs_mul);
                Console.WriteLine(" <== MUL TEST CASES TIME ==>");
                for (int i = 0; i < mul_list.Count; i += 2)
                {
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();
                    string result_mul = b.mul(mul_list[i], mul_list[i + 1]);
                    stopwatch.Stop();
                    Console.Write(stopwatch.ElapsedMilliseconds + " ms");
                    Console.Write(" =====> ");
                    Console.WriteLine(stopwatch.ElapsedMilliseconds / 1000 + " sec");
                    sw_mul.WriteLine(result_mul);
                    sw_mul.WriteLine();
                }
                sw_mul.Close();
                fs_mul.Close();
                ////////////FOR SAMPLE TEST CASES///////////////
                //read sample test cases in a list
                List<string> sample_list = new List<string>();
                StreamReader sr_sample = new StreamReader("SampleRSA.txt");
                string num_to_sample = sr_sample.ReadLine();
                while (num_to_sample != null)
                {
                    sample_list.Add(num_to_sample);
                    num_to_sample = sr_sample.ReadLine();
                }
                sr_sample.Close();
                //create file and write the outputs in it "sample encryption outputs"
                FileStream fs_sample_enc = new FileStream("SampleRSA-ENCRYPTION-Output.txt", FileMode.OpenOrCreate);
                StreamWriter sw_sample_enc = new StreamWriter(fs_sample_enc);
                int index_sample_enc = 4;
                string result_sample_enc = "";
                Console.WriteLine(" <== SAMPLE ENCRYPTION TEST CASES TIME ==>");
                for (int i = 1; i < sample_list.Count; i += 8)
                {
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();
                    result_sample_enc = b.encryption(sample_list[index_sample_enc - 3], sample_list[index_sample_enc - 2], sample_list[index_sample_enc - 1]);
                    stopwatch.Stop();
                    Console.Write(stopwatch.ElapsedMilliseconds + " ms");
                    Console.Write(" =====> ");
                    Console.WriteLine(stopwatch.ElapsedMilliseconds / 1000 + " sec");
                    sw_sample_enc.WriteLine(result_sample_enc);
                    index_sample_enc += 8;
                }
                sw_sample_enc.Close();
                fs_sample_enc.Close();
                //create file and write the outputs in it "sample decryption outputs"
                FileStream fs_sample_dec = new FileStream("SampleRSA-DECRYPTION-Output.txt", FileMode.OpenOrCreate);
                StreamWriter sw_sample_dec = new StreamWriter(fs_sample_dec);
                string result_sample_dec = "";
                Console.WriteLine(" <== SAMPLE DECRYPTION TEST CASES TIME ==>");
                for (int i = 5; i < sample_list.Count; i += 8)
                {
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();
                    result_sample_dec = b.encryption(sample_list[i], sample_list[i + 1], sample_list[i + 2]);
                    stopwatch.Stop();
                    Console.Write(stopwatch.ElapsedMilliseconds + " ms");
                    Console.Write(" =====> ");
                    Console.WriteLine(stopwatch.ElapsedMilliseconds / 1000 + " sec");
                    sw_sample_dec.WriteLine(result_sample_dec);
                }
                sw_sample_dec.Close();
                fs_sample_dec.Close();
                ////////////FOR COMPLETE TEST CASES///////////////
                //read complete test cases in a list
                List<string> complete_list = new List<string>();
                StreamReader sr_complete = new StreamReader("TestRSA.txt");
                string num_to_complete = sr_complete.ReadLine();
                while (num_to_complete != null)
                {
                    complete_list.Add(num_to_complete);
                    num_to_complete = sr_complete.ReadLine();
                }
                sr_complete.Close();
                //create file and write the outputs in it "test encryption outputs"
                FileStream fs_complete_enc = new FileStream("TestRSA-ENCRYPTION-Output.txt", FileMode.OpenOrCreate);
                StreamWriter sw_complete_enc = new StreamWriter(fs_complete_enc);
                int index_complete_enc = 4;
                string result_complete_enc = "";
                Console.WriteLine(" <== COMPLETE ENCRYPTION TEST CASES TIME ==>");
                for (int i = 1; i < complete_list.Count; i += 8)
                {
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();
                    result_complete_enc = b.encryption(complete_list[index_complete_enc - 3], complete_list[index_complete_enc - 2], complete_list[index_complete_enc - 1]);
                    stopwatch.Stop();
                    Console.Write(stopwatch.ElapsedMilliseconds + " ms");
                    Console.Write(" =====> ");
                    Console.Write(stopwatch.ElapsedMilliseconds / 1000 + " sec");
                    Console.Write(" =====> ");
                    Console.WriteLine(stopwatch.ElapsedMilliseconds / (1000 * 60) + " min");
                    sw_complete_enc.WriteLine(result_complete_enc);
                    index_complete_enc += 8;
                }
                sw_complete_enc.Close();
                fs_complete_enc.Close();
                //create file and write the outputs in it "test decryption outputs"
                FileStream fs_complete_dec = new FileStream("TestRSA-DECRYPTION-Output.txt", FileMode.OpenOrCreate);
                StreamWriter sw_complete_dec = new StreamWriter(fs_complete_dec);
                string result_complete_dec = "";
                Console.WriteLine(" <== COMPLETE DECRYPTION TEST CASES TIME ==>");
                for (int i = 5; i < complete_list.Count; i += 8)
                {
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();
                    result_complete_dec = b.decryption(complete_list[i], complete_list[i + 1], complete_list[i + 2]);
                    stopwatch.Stop();
                    Console.Write(stopwatch.ElapsedMilliseconds + " ms");
                    Console.Write(" =====> ");
                    Console.Write(stopwatch.ElapsedMilliseconds / 1000 + " sec");
                    Console.Write(" =====> ");
                    Console.WriteLine(stopwatch.ElapsedMilliseconds / (1000 * 60) + " min");
                    sw_complete_dec.WriteLine(result_complete_dec);
                }
                sw_complete_dec.Close();
                fs_complete_dec.Close();
            }
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                //string x = b.encryption("145906768007583323230186939349070635292401872375357164399581871019873438799005358938369571402670149802121818086292467422828157022922076746906543401224889672472407926969987100581290103199317858753663710862357656510507883714297115637342788911463535102712032765166518411726859837988672111837205085526346618740053", "89489425009274444368228545921773093919669586065884257445497854456487674839629818390934941973262879616797970608917283679875499331574161113854088813275488110588247193077582527278437906504015680623423550067240042466665654232383502922215493623289472138866445818789127946123407807725702626644091036502372545139713", "35052111338673026690212423937053328511880760811579981620642802346685810623109850235943049080973386241113784040794704193978215378499765413083646438784740952306932534945195080183861574225226218879827232453912820596886440377536082465681750074417459151485407445862511023472235560823053497791518928820272257787786");
                //Console.WriteLine(x); 
                ////////////////////////////////////BONUS/////////////////////////////////////
                 //function genertaes public key
         int public_key(int e, string n)
        {
            Big_Integer b = new Big_Integer();
            int key = 0;
            int p = 0;
            int q = 0;
            string phi_val = "";
            int phi = 0;
            /////compute p and q
            n = b.mul(p.ToString(), q.ToString());
            ////compute phi=(p-1)(q-1)
            int first_term = p - 1;
            int second_term = q - 1;
            phi_val = b.mul(first_term.ToString(), second_term.ToString());
            Int32.TryParse(phi_val, out phi);

            ////choose e

            return key;
        }


        // Utility function to do modular  
        // exponentiation. It returns (x^y) % p 
        public int power(int x, int y, int p)
        {

            int res = 1; // Initialize result 

            // Update x if it is more than  
            // or equal to p 
            x = x % p;

            while (y > 0)
            {

                // If y is odd, multiply x with result 
                if ((y & 1) == 1)
                    res = (res * x) % p;

                // y must be even now 
                y = y >> 1; // y = y/2 
                x = (x * x) % p;
            }

            return res;
        }

        // This function is called for all k trials.  
        // It returns false if n is composite and  
        // returns false if n is probably prime. 
        // d is an odd number such that d*2<sup>r</sup> 
        // = n-1 for some r >= 1 
         bool millerTest(int d, int n)
        {
            // Pick a random number in [2..n-2] 
            // Corner cases make sure that n > 4 
            Random r = new Random();
            int a = 2 + (int)(r.Next() % (n - 4));

            // Compute a^d % n 
            int x = power(a, d, n);

            if (x == 1 || x == n - 1)
                return true;
            // Keep squaring x while one of the 
            // following doesn't happen 
            // (i) d does not reach n-1 
            // (ii) (x^2) % n is not 1 
            // (iii) (x^2) % n is not n-1 
            while (d != n - 1)
            {
                x = (x * x) % n;
                d *= 2;

                if (x == 1)
                    return false;
                if (x == n - 1)
                    return true;
            }

            // Return composite 
            return false;
        }

        // It returns false if n is composite  
        // and returns true if n is probably  
        // prime. k is an input parameter that  
        // determines accuracy level. Higher  
        // value of k indicates more accuracy. 
         bool isPrime(int n, int k)
        {

            // Corner cases 
            if (n <= 1 || n == 4)
                return false;
            if (n <= 3)
                return true;

            // Find r such that n = 2^d * r + 1  
            // for some r >= 1 
            int d = n - 1;

            while (d % 2 == 0)
                d /= 2;

            // Iterate given nber of 'k' times 
            for (int i = 0; i < k; i++)
                if (millerTest(d, n) == false)
                    return false;

            return true;
        }
        }
    }
