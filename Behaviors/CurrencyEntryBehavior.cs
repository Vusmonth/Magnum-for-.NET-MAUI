namespace Avalon.Maui.Magnum.Behaviors;

public class CurrencyEntryBehavior : Behavior<Entry>
{
    protected override void OnAttachedTo(Entry entry)
    {
        entry.TextChanged += Entry_TextChanged;

        base.OnAttachedTo(entry);
    }

    protected override void OnDetachingFrom(Entry entry)
    {
        entry.TextChanged -= Entry_TextChanged;

        base.OnDetachingFrom(entry);
    }

    private void Entry_TextChanged(object? sender, TextChangedEventArgs e)
    {
        if (sender is not Entry entry || string.IsNullOrEmpty(e.NewTextValue))
            return;

        // Remove any non-numeric characters from the text
        var newText = new string(e.NewTextValue.Where(char.IsDigit).ToArray());

        // Convert the numeric text to a decimal value
        if (decimal.TryParse(newText, out var amount) && amount > 0)
        {
            // Format the decimal amount to the desired currency format
            string formattedAmount = $"{amount / 100:C}";

            // Set the formatted text to the Entry
            entry.Text = formattedAmount;
        }
        else
        {
            // If parsing fails, reset the Entry text
            entry.Text = string.Empty;
        }

        // Move the cursor to the end of the text
        entry.CursorPosition = entry.Text.Length;
    }
}