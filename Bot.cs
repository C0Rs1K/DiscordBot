using System.Text;
using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;


namespace DiscordBot;

public class Bot
{

    public void Initialize(DiscordClient client)
    {
        var commands = client.UseCommandsNext(new CommandsNextConfiguration()
        {
            StringPrefixes = new[] { "!" }
        });

        commands.RegisterCommands<CommandsModule>();
    }
}

public class CommandsModule : BaseCommandModule
{
    [Command("price")]
    public async Task PriceCommand(CommandContext ctx, [RemainingText] string currencyName)
    {
        if (!string.IsNullOrWhiteSpace(currencyName))
        {
            await ctx.RespondAsync(GetPriceMessage(currencyName));
        }
    }

    private string GetPriceMessage(string currencyName)
    {
        var provider = new PriceProvider();
        currencyName = currencyName.Trim();
        if (provider.GetPriceInChaos(currencyName) == -1)
        {
            return $"{currencyName.FirstUpper()} is not found";
        }
        else
        {
            decimal chaosPrice = provider.GetPriceInChaos(currencyName);
            StringBuilder sb = new();
            sb.Append($"{currencyName.FirstUpper()} price is {chaosPrice} chaos");

            if (chaosPrice > provider.GetPriceInChaos("exalted orb"))
            {
                sb.Append($" or {provider.GetPriceInExalted(currencyName)} ex");
            }

            return sb.ToString();
        }
    }
}
