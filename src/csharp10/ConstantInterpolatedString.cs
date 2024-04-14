namespace csharp10
{
    //Antes
    public static class EmailMessagesAntes
    {
        private const string _salutation = "Welcome";
        public static class Header
        {
            public const string SalutionTeamplate = _salutation + " to constant Interpolation";
        }
    }

    //Depois
    public static class EmailMessagesDepois
    {
        private const string _salutation = "Welcome";
        public static class Header
        {
            public const string SalutionTeamplate = $"{_salutation} to Interpolation";
        }
    }
}
