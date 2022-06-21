using DSharpPlus;

namespace DiscordBot;
public static class DiscordExtentions
{
    private static Bot? _bot;

    public static DiscordClient AddBot(this DiscordClient client)
    {
        _bot = new();
        _bot.Initialize(client);

        return client;
    }
}