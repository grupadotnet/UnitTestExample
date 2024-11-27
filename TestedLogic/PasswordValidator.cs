namespace TestedLogic
{
    public static class PasswordValidator
    {
        public static IEnumerable<string> Validate(string? password)
        {
            List<string> errors = new();

            if (password == null)
            {
                errors.Add("Password cannot be null.");

                return errors;
            }

            if (password.Length < 8)
            {
                errors.Add("Password must contain at least 8 characters.");
            }

            if (!password.Any(char.IsUpper))
            {
                errors.Add("Pasword must contain at least one uppercase character.");
            }

            if (!password.Any(char.IsLower))
            {
                errors.Add("Pasword must contain at least one lowercase character.");
            }

            if (!password.Any(char.IsDigit))
            {
                errors.Add("Pasword must contain at least one digit.");
            }

            if (!password.Any(x => !char.IsLetterOrDigit(x)))
            {
                errors.Add("Pasword must contain at least special character.");
            }

            return errors;
        }
    }

}
