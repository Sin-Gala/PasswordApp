namespace PasswordApp.src.Helpers
{
    public enum Command
    {
        MainMenu = 0,
        SettingsMenu = 1,

        AddUI = 10, // Used when calling the UserInteraction Add
        AddWebsite = 11, // Called when calling the PasswordDico Add and asking for password
        AddWebsitePassword = 12, // Called when calling the PasswordDico with all datas

        RemoveUI = 20,
        RemoveWebsite = 21,

        EditUI = 30,
        EditWebsite = 31,
        EditWebsitePassword = 32,

        RemoveAll = 40,

        See = 50
    }
}
