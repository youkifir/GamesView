public static class Validator
{
    public static string ValidateEmail(string email)
    {
        if (string.IsNullOrWhiteSpace(email))
            return "Введіть email";

        if (!email.Contains("@") || !email.Contains("."))
            return "Невірний формат email";

        return null;
    }

    public static string ValidateLogin(string login)
    {
        if (string.IsNullOrWhiteSpace(login))
            return "Введіть логін";

        if (login.Length < 3)
            return "Логін закороткий (мін. 3 символи)";

        if (login.Length > 20)
            return "Логін задовгий (макс. 20 символів)";

        return null;
    }

    public static string ValidatePassword(string password)
    {
        if (string.IsNullOrWhiteSpace(password))
            return "Введіть пароль";

        if (password.Length < 6)
            return "Пароль закороткий (мін. 6 символів)";

        return null;
    }

    public static string ValidateRegistration(string login, string email, string password, string confirmPassword)
    {
        return ValidateLogin(login)
            ?? ValidateEmail(email)
            ?? ValidatePassword(password)
            ?? (password != confirmPassword ? "Паролі не співпадають" : null);
    }
}