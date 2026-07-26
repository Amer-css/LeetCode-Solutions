public class Solution {
    public bool StrongPasswordCheckerII(string password) 
    {
        if (password.Length < 8) return false;
        
        bool hasLower = false;
        bool hasUpper = false;
        bool hasDigit = false;
        bool hasSpecial = false;

        HashSet<char> specialChars = new HashSet<char>("!@#$%^&*()-+");

        for (int i = 0; i < password.Length; i++) 
        {
            char c = password[i];
             if (i > 0 && c == password[i - 1]) {
                return false;
            }
              if (char.IsLower(c)) hasLower = true;
            else if (char.IsUpper(c)) hasUpper = true;
            else if (char.IsDigit(c)) hasDigit = true;
            else if (specialChars.Contains(c)) hasSpecial =true;
        }

            return hasLower && hasUpper && hasDigit && hasSpecial;
    }
}