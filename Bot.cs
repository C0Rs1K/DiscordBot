using DSharpPlus;
using DSharpPlus.EventArgs;


namespace DiscordBot;

public class Bot
{
    public void Initialize(DiscordClient client)
    {
        client.MessageCreated += OnMessageCreated;
    }

    private async Task OnMessageCreated(DiscordClient sender, MessageCreateEventArgs e)
    {
        if (e.Message.Content.StartsWith("Экз", true, System.Globalization.CultureInfo.CurrentCulture))
        {
            await sender.SendMessageAsync(e.Channel, "pik");
        }
    }
}