using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSA
{
    class Big_Integer
    {
        public  Big_Integer() { }

        /// <summary>
        /// the user will enter two numbers and the function will calculate the addition of them
        /// in O(N) Time Complexity
        /// </summary>
        /// <param name="number1">the first number</param>
        /// <param name="number2">the second number</param>
        /// <returns> addition of the two numbers</returns>
        public string add(string number1, string number2)
        {
            StringBuilder result = new StringBuilder();
            //string result = "";
            int carry = 0;//O(1)
            // if num1 is longer than num2 swap them
            // num2 should be the longest string
            if (number1.Length > number2.Length)//O(1)
            {
                string temp = number1;//O(N)
                number1 = number2;//O(N)
                number2 = temp;//O(N)
            }
            int num1_len = number1.Length;//O(1)
            int num2_len = number2.Length;//O(1)
            int diff_len = num2_len - num1_len;//O(1)
            //step1 add numbers from mun1 and num2 till num1 length which is the shortest one
            for (int i = num1_len - 1; i >= 0; i--)//O(N)
            {
                int sum = ((int)(number1[i] - '0') + (int)(number2[i + diff_len] - '0') + carry);//O(1)
                result.Append((char)(sum % 10 + '0'));//O(1)
                carry = sum / 10;//O(1)
            }
            //step2 add the rest numbers of num2 which is the longest one
            for (int i = diff_len - 1; i >= 0; i--)//O(N)
            {
                int sum = ((int)(number2[i] - '0') + carry);//O(1)
                result.Append((char)(sum % 10 + '0'));//O(1)
                carry = sum / 10;//O(1)
            }
            //step3 add carry
            if (carry > 0)//O(1)
            {
                result.Append((char)(carry + '0'));//O(1)
            }
            //reverse result string
            string result_builder = result.ToString();//O(N)
            char[] newresult = result_builder.ToCharArray();//O(N)
            Array.Reverse(newresult);//O(N)
            StringBuilder final_result = new StringBuilder();//O(1)
            int nuewresult_length = newresult.Length;
            for (int i = 0; i < nuewresult_length; i++)//O(N)
            {
                if (newresult[i] == '0')//O(1)
                {
                    newresult[i] = '$';//O(1)
                }
                else//O(1)
                {
                    break;//O(1)
                }
            }
            for (int i = 0; i < nuewresult_length; i++)//O(N)
            {
                if (newresult[i] != '$')//O(1)
                {
                    final_result.Append(newresult[i]);//O(1)
                }
            }
            return final_result.ToString();//O(N)
            //return new string(newresult);
            //return result;
        }
        /// <summary>
        /// the user will enter two numbers and the function will calculate the Subtraction of them
        /// in O(N) Time Complexity
        /// </summary>
        /// <param name="number1">the first number</param>
        /// <param name="number2">the second number</param>
        /// <returns> subtraction of the two numbers</returns>
        public string sub(string number1, string number2)
        {
            StringBuilder result = new StringBuilder();//O(1)
            // x and y holds the values of number1 and number2 as integers  
            //int x = 0;//O(1)
            //Int32.TryParse(number1, out x);//O(N)
            //int y = 0;//O(N)
            //Int32.TryParse(number2, out y);//O(N)
            //if both strings are equal in value
            if (number1 == number2)//O(N)
            {
                return ("0");//O(1)
            }
            //if both strings are different then check lentgh and value
            else //O(1)
            {
                //if num2 is longer than num1 then swap
                // num1 should be the longest one
                if (number2.Length > number1.Length)//O(1)
                {
                    string temp = number2;//O(N)
                    number2 = number1;//O(N)
                    number1 = temp;//O(N)
                }
                //if number2 is larger than number1 then swap them
                //else if (number1.Length == number2.Length)//O(1)
                //{
                   //if (y > x)//O(1)
                    //{
                        //int temp = y;//O(1)
                        //y = x;//O(1)
                        //x = temp;//O(1)
                    //}
                    //number1 = x.ToString();//O(N)
                    //number2 = y.ToString();//O(N)
                }
                int num1_len = number1.Length;//O(1)
                int num2_len = number2.Length;//O(1)
                int diff_len = num1_len - num2_len;//O(1)
                int borrow = 0;//O(1)
                //char[] arr = new char[1000];
                //step1 subtract num1 from num2 until the length of num2 which is the shortest
                for (int i = num2_len - 1; i >= 0; i--)//O(N)
                {
                    int diff = (((int)number1[i + diff_len] - (int)'0') - ((int)number2[i] - (int)'0') - borrow);//O(1)
                    if (diff < 0)//O(1)
                    {
                        diff += 10; //O(1)
                        borrow = 1;//O(1)
                    }
                    else //O(1)
                    {
                        borrow = 0;//O(1)
                    }
                    result.Append((char)(diff + '0'));//O(1)
                    //arr[i] += (char)diff;//O(1)
                    //result.Append(diff.ToString());
                }
                //result.Append(arr.ToString());//O(1)
                //step2 accumalate rest bits from num1 which is the longest one to the result
                for (int i = diff_len - 1; i >= 0; i--)//O(N)
                {
                    if (number1[i] == '0' && borrow > 0)//O(1)
                    {
                        result.Append("9");//O(1)
                        continue;//O(1)
                    }
                    int diff = (((int)number1[i] - (int)'0') - borrow);//O(1)
                    if (i > 0 || diff > 0)//O(1)
                    {

                        //result.Append(diff.ToString());
                        //arr[i] += (char)diff;//O(1)
                        result.Append((char)(diff + '0'));//O(1)
                    }
                    borrow = 0;//O(1)
                }
                //result.Append(arr.ToString());//O(N)
                string result_builder = result.ToString();//O(N)
                char[] newresult = result_builder.ToCharArray();//O(N)
                Array.Reverse(newresult);//O(N)
                StringBuilder final_result = new StringBuilder();//O(1)
                int newresult_length = newresult.Length;
                for (int i = 0; i < newresult_length; i++)//O(N)
                {
                    if (newresult[i] == '0')//O(1)
                    {
                        newresult[i] = '$';//O(1)
                    }
                    else//O(1)
                    {
                        break;//O(1)
                    }
                }
                for (int i = 0; i < newresult_length; i++)//O(N)
               {
                    if (newresult[i] != '$')//O(1)
                    {
                        final_result.Append(newresult[i]);//O(1)
                    }
                }
                return final_result.ToString();//O(N)
                //return new string(newresult);
                //return result;
            }
        /// <summary>
        /// make the two strings equal to each other in O(N) Time comlexity.
        /// </summary>
        /// <param name="number1">the first number</param>
        /// <param name="number2">the second number</param>
        /// <returns>the lenght of any of the two strings</returns>
        static int equallystrings(ref string number1, ref string number2)
        {
            int num1_length = number1.Length;//O(1)
            int num2_length = number2.Length;//O(1)
            //both strings must be equal in length
            if (num1_length > num2_length)//O(1)
            {
                number2 = number2.PadLeft(num1_length, '0');  //O(1) //shift the string from left and put 0's according to the biggest lenght
                return number2.Length;//O(1)
            }
            else if (num1_length < num2_length)//O(1)
                number1 = number1.PadLeft(num2_length, '0');//O(1)
            return number1.Length;//O(1) //return the number1Lenght when length1 >= length2
        }
        /// <summary>
        /// the user will enter two numbers and the function will calculate the multiplication of them
        /// in O(N^1.58) Time Complexity.
        /// ------>>>>Recurrence Analysis:-
        ///           T(N) = 3T(N/2) + θ(N)
        /// using Master Method:- => where :- f(N)=N, a=3, b=2
        ///     f(N) VS (N^log a base b)
        ///       N  VS (N^log 3 base 2)
        ///       N  VS (N^1.58)
        ///       =>Case1:-
        ///           f(N) = O(N^log a base b - Ɛ)
        ///            N = O(N^1.58 - Ɛ)
        ///            any 1.58 > Ɛ > 0
        ///            ∴ θ(N^1.58) in worstCase.
        /// </summary>
        /// <param name="number1">the first number</param>
        /// <param name="number2">the second number</param>
        /// <returns> multiplication of the two numbers</returns>
        public string mul(string number1, string number2)
        {
            //function that return the length after equalling them
            int num_length = equallystrings(ref number1, ref number2);//O(1)
            int mid = num_length / 2;//O(1)
            //base case
            if (num_length == 1)//O(1)
            {
                return (((number1[0]) - '0') * ((number2[0]) - '0')).ToString();//O(1)
            }
            else if (num_length == 0)//O(1)
            {
                return "0";//O(1)
            }
            //divide step
            string a = number1.Substring(0, mid);//O(N)
            string b = number1.Substring(mid);//O(N)
            string c = number2.Substring(0, mid);//O(N)
            string d = number2.Substring(mid);//O(N)
            //conquer step
            string ac = mul(a, c);//recursive step //T(N/2)
            string bd = mul(b, d);//recursive step //T(N/2)
            string z = mul(add(a, b), add(c, d));//recursive step //T(N/2)+O(N)
            string firstTerm = add(ac, bd);//O(N)
            string remainingTerm = sub(z, firstTerm);//O(N)
            //combine step
            string ans = add(ac.PadRight((ac.Length + (num_length - mid) * 2), '0'), remainingTerm.PadRight((remainingTerm.Length + (num_length - mid)), '0'));//O(N)
            string finalAns = add(ans, bd);//O(N)
            return finalAns;//O(1)
        }
        /// <summary>
        /// the user will enter two numbers and the function will calculate the 
        /// division of them in 
        /// </summary>
        /// <param name="number1">The first number</param>
        /// <param name="number2">The second number</param>
        /// <returns>the qoutient and reminder of the division as a 
        /// object that contain two strings</returns>
        divide bi = new divide();//O(1)
        public divide div(string number1, string number2)
        {
            int number1_length = number1.Length;//O(1)
            int number2_length = number2.Length;//O(1)
            bool num2 = false;//O(1)
            if (number2_length > number1_length)//O(N)
            {
                bi.qoutient = "0";//O(1)
                bi.remainder = number1;//O(N)
                return bi;//O(1)
            }
            else if (number1_length == number2_length)//O(N)
            {
                for (int i = 0; i < number1_length; i++)//O(N)
                {
                    if ((number2[i] - '0') > (number1[i] - '0'))//O(1)
                    {
                        num2 = true;//O(1)
                        break;//O(1)
                    }
                    else if ((number1[i] - '0') > (number2[i] - '0'))//O(1)
                        break;//O(1)
                }
                if (num2)//O(N)
                {
                    bi.qoutient = "0";//O(1)
                    bi.remainder = number1;//O(N)
                    return bi;//O(1)
                }
            }
            bool check = false;//O(1)
            string double_number2 = add(number2, number2);//O(N)
            //Recurence Step
            bi = div(number1, double_number2);//T(N/2)
            bi.qoutient = add(bi.qoutient, bi.qoutient);//O(N)
            if (bi.remainder.Length < number2_length)//O(1)
            {
                return bi;//O(1)
            }
            else if (bi.remainder.Length == number2_length)//O(N)
            {
                for (int i = 0; i < number2_length; i++)//O(N)
                {
                    if (bi.remainder[i] < number2[i])//O(1)
                    {
                        check = true;//O(1)
                        break;//O(1)
                    }
                    else if (bi.remainder[i] > number2[i])//O(1)
                    {
                        break;//O(1)
                    }
                }
            }
            if (check)//O(1)
            {
                return bi;//O(1)
            }
            else//O(N)
            {
                bi.qoutient = add(bi.qoutient, "1");//O(N)
                bi.remainder = sub(bi.remainder, number2);//O(N)
                return bi;//O(1)
            }
        }
        /// <summary>
        /// A function to calculate the power of a number and get its modules in θ(log N) Time Complexity
        /// ------>>>>Recurrence Analysis:-
        ///           T(P) = T(P/2) + θ(1)
        /// using Master Method:- => where :- f(P)=P^1.58, a=1, b=2 
        ///     f(P) VS (P^log a base b)
        ///       1  VS (P^log 1 base 2)
        ///       1  VS   1
        ///       =>Case1:-
        ///           f(N) = O(P^log 1 base 2)
        ///           ∴ θ(1*log P)
        ///           ∴ θ(log P)
        /// </summary>
        /// <param name="Number">Base</param>
        /// <param name="N">Powr</param>
        /// <param name="exponential">divisor</param>
        /// <returns>the mod of power as a string</returns>
        public string mod_of_power(string exponential, string N, string Number)
        {
            bool odd;//O(1)
            string M = div(N, "2").qoutient;//O(N)
            //base case
            if (N == "0")//O(1)
            {  
                return "1";//O(1)
            }//O(1)
            //check the num even or odd
            if ((N[N.Length - 1] - '0') % 2 == 0)//O(1)
            {
                odd = false;//O(1)
            }
            else//O(1)
            {
                odd = true;//O(1)
            }
            //divide step
            string pow = mod_of_power(exponential, M, Number);//T(P/2) 
            if (odd == true)//O(1)
            {
                //conquer step
                string result = mul(pow, pow);//O(N^1.58)
                string finalPower = mul(result, Number);//O(N^1.58)
                //combine step
                return div(finalPower, exponential).remainder;//O(N)
            }
            else//O(1)
            {
                //conquer step
                string result = mul(pow, pow);//O(N^1.58)
                //combine step
                return div(result, exponential).remainder;//O(N)
            }
        }
        /// <summary>
        /// function that calculate the encrypted communication E(M)
        /// </summary>
        /// <param name="M">the base</param>
        /// <param name="e">the power</param>
        /// <param name="n">the divisor</param>
        /// <returns>the encrypted communication E(M) message as a string</returns>
        public string encryption(string n, string e, string m)
        {
            return mod_of_power(n, e, m);//O(N^1.58)
        }
        /// <summary>
        /// function that decrypts the message 
        /// </summary>
        /// <param name="EM">The encrypted communication E(M)</param>
        /// <param name="d">power</param>
        /// <param name="n">divisor</param>
        /// <returns>The decrypted message as a string</returns>
        public string decryption(string n, string d, string e)
        {
            return mod_of_power(n, d, e);//O(N^1.58)
        }
    }
}