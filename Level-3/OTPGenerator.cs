/* using System;
class OTPGenerator
{
    // This function generates a 6-digit OTP using Math.Random()
    public static int Generate_OTP()
    {
        Random random = new Random();
        return random.Next(100000, 1000000);
    }

    // This function ensures that OTP numbers are unique
    public static bool OTPs_Uniq(int[] otp_Arr)
    {
        HashSet<int> otp_Set = new HashSet<int>(otp_Arr);
        return otp_Set.Count == otp_Arr.Length; 
    }

    public static void Main(string[] args)
    {
        int[] otp_Arr = new int[10]; 

        Console.WriteLine("Generated OTPs:");
        for (int i = 0; i < otp_Arr.Length; i++)
        {
            otp_Arr[i] = Generate_OTP();
            Console.WriteLine($"OTP {i + 1}: {otp_Arr[i]}");
        }

        bool is_Uniq = OTPs_Uniq(otp_Arr);

        Console.WriteLine("Validation Result:");
        Console.WriteLine(is_Uniq ? "All OTPs are unique." : "Some OTPs are repeated.");
    }
}
 */